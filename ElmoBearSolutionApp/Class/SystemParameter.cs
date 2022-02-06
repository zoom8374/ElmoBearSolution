using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ElmoBearSolutionApp
{
    public class SystemParameter
    {
        public int MachineNumber;
        public eProjectItem ProjectItem;
        public bool IsSimulationMode;
        public bool IsSoftwareTriggerMode;
        public int  CameraCount;
        public int  ISMModuleCount;
        public string LastRecipeName;

        public SystemParameter()
        {
            //MachineNumber = 1;
            //ProjectItem = eProjectItem.BLOB;
            //IsSimulationMode = false;
            //CameraCount = 1;
            //ISMModuleCount = 2;
            //LastRecipeName = "Default";
        }

        public bool ReadParameter()
        {
            bool _Result = true;

            try
            {
                string _SystemFileName = DEF.PRO_PATH + DEF.PRO_NAME + @"\SystemParameter.sys";
                DirectoryInfo _DirInfo = new DirectoryInfo(DEF.PRO_PATH + DEF.PRO_NAME);
                if (false == _DirInfo.Exists) { _DirInfo.Create(); System.Threading.Thread.Sleep(100); }
                if (false == File.Exists(_SystemFileName))
                {
                    File.Create(_SystemFileName).Close();
                    WriteParameter();
                    System.Threading.Thread.Sleep(100);
                }

                XDocument _XDocument = XDocument.Load(_SystemFileName);
                IEnumerable<XElement> _Xelems = _XDocument.Elements("SystemParameter");
                foreach (var _Xelem in _Xelems)
                {
                    MachineNumber       = Convert.ToInt32(_Xelem.Element("MachineNumber").Value);
                    ProjectItem         = (eProjectItem)Convert.ToInt32((_Xelem.Element("ProjectItem").Value));
                    IsSimulationMode    = Convert.ToBoolean(_Xelem.Element("SimulationMode").Value);
                    CameraCount         = Convert.ToInt32(_Xelem.Element("CameraCount").Value);
                    ISMModuleCount      = Convert.ToInt32(_Xelem.Element("ISMModuleCount").Value);
                    LastRecipeName      = Convert.ToString(_Xelem.Element("LastRecipeName").Value);
                }
            }

            catch
            {
                _Result = false;
            }

            return _Result;
        }

        public void WriteParameter()
        {
            string _SystemFileName = DEF.PRO_PATH + DEF.PRO_NAME + @"\SystemParameter.sys";
            DirectoryInfo _DirInfo = new DirectoryInfo(DEF.PRO_PATH + DEF.PRO_NAME);
            if (false == _DirInfo.Exists) { _DirInfo.Create(); System.Threading.Thread.Sleep(100); }

            #region XML Element Define
            XElement _SystemParameter   = new XElement("SystemParameter");
            XElement _MachineNumber     = new XElement("MachineNumber", MachineNumber);
            XElement _ProjectItem       = new XElement("ProjectItem", (int)ProjectItem);
            XElement _SimulationMode    = new XElement("SimulationMode", IsSimulationMode);
            XElement _CameraCount       = new XElement("CameraCount", CameraCount);
            XElement _ISMModuleCount    = new XElement("ISMModuleCount", ISMModuleCount);
            XElement _LastRecipeName    = new XElement("LastRecipeName", LastRecipeName);
            #endregion

            _SystemParameter.Add(_MachineNumber);
            _SystemParameter.Add(_ProjectItem);
            _SystemParameter.Add(_SimulationMode);
            _SystemParameter.Add(_CameraCount);
            _SystemParameter.Add(_ISMModuleCount);
            _SystemParameter.Add(_LastRecipeName);
            _SystemParameter.Save(_SystemFileName);
        }
    }
}
