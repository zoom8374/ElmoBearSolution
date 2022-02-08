using System;
using System.Threading;
using System.Runtime.InteropServices;

using MvCamCtrl.NET;

namespace CameraManager2022
{
    public class HikCamera : ICamera
    {
        public static uint AvailableDeviceCount;
        public static uint DeviceCount;
        private string DeviceID;
        private uint DeviceIndex;

        private UInt32 GrabBufferSize;
        private IntPtr GrabBufferPtr;

        public bool IsInitialize;
        public bool IsCameraStatus;
        public int CameraNumber;

        private Thread ThreadContinuousGrab;
        private bool IsThreadContinuousGrabExit;
        private bool IsThreadContinuousGrabTrigger;
        private object GrabLock;

        private MyCamera HCamera;
        private MyCamera.MV_CC_DEVICE_INFO_LIST DeviceList;
        MyCamera.MV_FRAME_OUT_INFO_EX FrameInfo;

        public event GrabHandler GrabEvent;

        [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

        public HikCamera()
        {
            GrabLock = new object();
            GrabBufferSize = 0;
            GrabBufferPtr = IntPtr.Zero;

            HCamera = new MyCamera();
            HCamera.MV_CC_SetHeartBeatTimeout_NET(3000);

            FrameInfo = new MyCamera.MV_FRAME_OUT_INFO_EX();
            DeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
            int _Ret = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE, ref DeviceList);
            AvailableDeviceCount = (_Ret != 0) ? 0 : DeviceList.nDeviceNum;
            IsCameraStatus = false;
        }

        /// <summary>
        /// Hik Camera initialize
        /// </summary>
        /// <param name="_ID">카메라 Index</param>
        /// <param name="_DeviceID">Camera Serial</param>
        /// <param name="_TriggerMode">Trigger Mode</param>
        /// <returns>true return</returns>
        public bool Initialize(int _ID, string _DeviceID, CamDEF _TrgMode = CamDEF.SOFT_TRIGGER)
        {
            bool _Result = true;
            int _Return = 0;
            if (0 == AvailableDeviceCount) return false;

            CameraNumber = _ID;
            DeviceID = _DeviceID;

            for (int iLoopCount = 0; iLoopCount < AvailableDeviceCount; ++iLoopCount)
            {
                try
                {
                    MyCamera.MV_CC_DEVICE_INFO _Device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(DeviceList.pDeviceInfo[iLoopCount], typeof(MyCamera.MV_CC_DEVICE_INFO));
                    MyCamera.MV_GIGE_DEVICE_INFO _DeviceInfo = (MyCamera.MV_GIGE_DEVICE_INFO)MyCamera.ByteToStruct(_Device.SpecialInfo.stGigEInfo, typeof(MyCamera.MV_GIGE_DEVICE_INFO));

                    if (_DeviceInfo.chSerialNumber != DeviceID) continue;
                    if (null == HCamera) return false;

                    _Return = HCamera.MV_CC_CreateDevice_NET(ref _Device);
                    if (_Return != MyCamera.MV_OK) return false;

                    _Return = HCamera.MV_CC_OpenDevice_NET();
                    if (_Return != MyCamera.MV_OK)
                    {
                        HCamera.MV_CC_DestroyDevice_NET();
                        return false;
                    }

                    int _PacketSize = HCamera.MV_CC_GetOptimalPacketSize_NET();
                    if (_PacketSize > 0)
                    {
                        _Return = HCamera.MV_CC_SetIntValue_NET("GevSCPSPacketSize", (uint)_PacketSize);
                        if (_Return != MyCamera.MV_OK) return false;
                    }
                    else
                    {
                        return false;
                    }

                    if (_TrgMode == CamDEF.SOFT_TRIGGER)
                    {
                        HCamera.MV_CC_SetEnumValue_NET("AcquisitionMode", (uint)MyCamera.MV_CAM_ACQUISITION_MODE.MV_ACQ_MODE_CONTINUOUS);
                        HCamera.MV_CC_SetEnumValue_NET("TriggerMode", (uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_OFF);
                    }

                    ThreadContinuousGrab = new Thread(ThreadContinuousGrabFunc);
                    ThreadContinuousGrab.IsBackground = true;
                    IsThreadContinuousGrabExit = false;
                    IsThreadContinuousGrabTrigger = false;
                    ThreadContinuousGrab.Start();

                    IsInitialize = _Result;
                    IsCameraStatus = _Result;
                }

                catch
                {
                    _Result = false;
                }
            }

            return _Result;
        }

        /// <summary>
        /// Hik Camera Deinitialize
        /// </summary>
        public void DeInitialize()
        {
            if (ThreadContinuousGrab != null) { IsThreadContinuousGrabExit = true; Thread.Sleep(100); ThreadContinuousGrab.Abort(); ThreadContinuousGrab = null; }

            HCamera.MV_CC_CloseDevice_NET();
            HCamera.MV_CC_DestroyDevice_NET();
        }

        public bool Status()
        {
            return IsCameraStatus;
        }

        public void Live(bool _Flag)
        {
            IsThreadContinuousGrabTrigger = _Flag;
        }

        public void OneShot()
        {
            int _Return = 0;

            MyCamera.MV_FRAME_OUT _FrameInfo = new MyCamera.MV_FRAME_OUT();

            _Return = HCamera.MV_CC_StartGrabbing_NET();
            if (_Return != MyCamera.MV_OK)
            {
                HCamera.MV_CC_StopGrabbing_NET();
                return;
            }

            _Return = HCamera.MV_CC_GetImageBuffer_NET(ref _FrameInfo, 1000);
            if (_Return == MyCamera.MV_OK)
            {
                lock (GrabLock)
                {
                    if (GrabBufferPtr == IntPtr.Zero || _FrameInfo.stFrameInfo.nFrameLen > GrabBufferSize)
                    {
                        if (GrabBufferPtr != IntPtr.Zero)
                        {
                            Marshal.Release(GrabBufferPtr);
                            GrabBufferPtr = IntPtr.Zero;
                        }

                        GrabBufferPtr = Marshal.AllocHGlobal((Int32)_FrameInfo.stFrameInfo.nFrameLen);
                        if (GrabBufferPtr == IntPtr.Zero) return;

                        GrabBufferSize = _FrameInfo.stFrameInfo.nFrameLen;
                    }

                    FrameInfo = _FrameInfo.stFrameInfo;
                    CopyMemory(GrabBufferPtr, _FrameInfo.pBufAddr, _FrameInfo.stFrameInfo.nFrameLen);

                    var _GrabEvent = GrabEvent;
                    GrabEvent?.Invoke(GrabBufferPtr);
                }

                HCamera.MV_CC_FreeImageBuffer_NET(ref _FrameInfo);

            }

            _Return = HCamera.MV_CC_StopGrabbing_NET();
            if (_Return != MyCamera.MV_OK) return;
        }

        private void ThreadContinuousGrabFunc()
        {
            try
            {
                while (false == IsThreadContinuousGrabExit)
                {
                    if (IsThreadContinuousGrabTrigger) OneShot();
                    Thread.Sleep(1);
                }
            }

            catch (Exception ex)
            {

            }
        }
    }
}
