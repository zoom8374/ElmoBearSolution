namespace CameraManager2022
{
    public delegate void GrabHandler(object _GrabImageArray);

    interface ICamera
    {
        /// <summary>
        /// Camera Initialize
        /// </summary>
        /// <param name="_ID">카메라 Index</param>
        /// <param name="_DeviceID">Camera Serial</param>
        /// <param name="_TriggerMode">Trigger Mode</param>
        /// <returns></returns>
        bool Initialize(int _ID, string _DeviceID, CamDEF _TriggerMode = CamDEF.SOFT_TRIGGER);

        /// <summary>
        /// Camera DeInitialize
        /// </summary>
        void DeInitialize();

        /// <summary>
        /// Camera status check
        /// </summary>
        /// <returns></returns>
        bool Status();

        void Live(bool _Flag);

        void OneShot();

        event GrabHandler GrabEvent;
    }
}
