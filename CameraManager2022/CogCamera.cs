using System;
using System.Threading;

using Cognex.VisionPro;

namespace CameraManager2022
{
    public class CogCamera
    {
        private int CameraNumber;
        private int AvailableDeviceCount;

        public bool IsInitialize;
        public bool IsCameraStatus;

        private ICogAcqFifo AcqFifo = null;
        private CogFrameGrabbers FrameGrabbers;
        private ICogFrameGrabber FrameGrabber;
        private string ImageFormat;

        private Thread ThreadContinuousGrab;
        private bool IsThreadContinuousGrabExit;
        private bool IsThreadContinuousGrabTrigger;

        public delegate void CogGrabHandler(ICogImage _CogGrabImage);
        public event CogGrabHandler CogGrabEvent;

        public CogCamera()
        {
            FrameGrabbers = new CogFrameGrabbers();
            AvailableDeviceCount = FrameGrabbers.Count;
        }

        public bool Initialize(int _ID, string _DeviceID)//, eTrgMode _TrgMode)
        {
            bool _Result = false;
            CameraNumber = _ID;

            try
            {
                for (int iLoopCount = 0; iLoopCount < AvailableDeviceCount; ++iLoopCount)
                {
                    FrameGrabber = FrameGrabbers[iLoopCount];

                    if (FrameGrabber.SerialNumber != _DeviceID)
                        continue;

                    ImageFormat = "Generic GigEVision (Mono)";
                    AcqFifo = FrameGrabber.CreateAcqFifo(ImageFormat, CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                    AcqFifo.Timeout = 1000;
                    AcqFifo.Flush();

                    _Result = true;

                    break;
                }

                if (false == _Result) return false;

                ThreadContinuousGrab = new Thread(ThreadContinuousGrabFunc);
                ThreadContinuousGrab.IsBackground = true;
                IsThreadContinuousGrabExit = false;
                IsThreadContinuousGrabTrigger = false;
                ThreadContinuousGrab.Start();

                IsInitialize = _Result;
                IsCameraStatus = _Result;
            }
            catch (Exception ex)
            {
                _Result = false;
            }

            return _Result;
        }

        public void DeInitialize()
        {
            if (ThreadContinuousGrab != null) { IsThreadContinuousGrabExit = true; Thread.Sleep(100); ThreadContinuousGrab.Abort(); ThreadContinuousGrab = null; }
            if (null != FrameGrabber)
            {
                FrameGrabber.Disconnect(true);
                FrameGrabber = null;
            }
        }

        public bool CameraStatus()
        {
            return IsCameraStatus;
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
                Thread.Sleep(1);
            }
        }

        public void OneShot()
        {
            int _TrgNum;
            var _CogGrabEvent = CogGrabEvent;
            try
            {
                _CogGrabEvent?.Invoke(AcqFifo.Acquire(out _TrgNum));
                GC.Collect();
            }
            catch
            {
                GC.Collect();
            }
        }

        public void Live(bool _IsLive)
        {
            if (true == _IsLive) IsThreadContinuousGrabTrigger = true;
            else IsThreadContinuousGrabTrigger = false;
        }
    }
}
