using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmoBearSolutionApp
{
    public enum eProjectItem { PATTERN = 0, CODE, BLOB, LINE, MARK }

    public static class DEF
    {
        public static string PRO_PATH = @"C:\Inspection\";
        public static string PRO_NAME = "ElmoBearSolution";
    }

    public static class Global
    {
        //public static eSysMode SystemMode = eSysMode.MANUAL_MODE;
        public static string MainDrive = @"D:\";
    }
}
