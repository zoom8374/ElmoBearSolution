using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace ElmoBearSolutionApp
{
    public partial class MainForm : Form
    {
        #region Variable
        private SystemParameter SysParam;
        private ucResultManager ucResManager;
        #endregion

        #region Initizlie & DeInitialize
        public MainForm()
        {
            InitializeComponent();

            InitializeParameter();
            InitializeControl();

            SetProgramVersion();
        }

        private void InitializeParameter()
        {
            SysParam = new SystemParameter();
            SysParam.ReadParameter();
        }

        private void InitializeControl()
        {
            ucResManager = new ucResultManager();
            ucResManager.Location = new Point(5, 752);
            panelMain.Controls.Add(ucResManager);
        }

        private void DeInitialize()
        {

        }

        private void SetProgramVersion()
        {
            Assembly _Assembly = Assembly.GetExecutingAssembly();
            System.Version _Version = _Assembly.GetName().Version;

            if (labelProgramVer.InvokeRequired)
            {
                labelProgramVer.Invoke(new MethodInvoker(delegate () { labelProgramVer.Text = string.Format("Ver.{0}", _Version.ToString()); }));
            }
            else
            {
                labelProgramVer.Text = string.Format("Ver.{0}", _Version.ToString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //for (int iLoopCount = 0; iLoopCount < INSP_COUNT; ++iLoopCount) ucInspManager[iLoopCount].ContinuesGrabStop();

                DialogResult dlgResult = MessageBox.Show(new Form { TopMost = true }, "Do you want exit program ? ", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes != dlgResult) return;
                //WriteLog(LOG_PART.LOCAL, LOG_TYPE.INFO, "PC : KP Int Vision inspection program exit!!", LOG_LV.MID);

                DeInitialize();
                Environment.Exit(0);
            }

            catch (Exception ex)
            {
                //WriteLog(LOG_PART.LOCAL, LOG_TYPE.INFO, "PC : KP Int Vision inspection program Exception exit!!", LOG_LV.MID);
                Environment.Exit(0);
            }    
        }
        #endregion

        private void ImgBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ImgBtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                //for (int iLoopCount = 0; iLoopCount < INSP_COUNT; ++iLoopCount) ucInspManager[iLoopCount].ContinuesGrabStop();

                DialogResult dlgResult = MessageBox.Show(new Form { TopMost = true }, "Do you want exit program ? ", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes != dlgResult) return;
                //WriteLog(LOG_PART.LOCAL, LOG_TYPE.INFO, "PC : KP Int Vision inspection program exit!!", LOG_LV.MID);

                DeInitialize();
                Environment.Exit(0);
            }

            catch (Exception ex)
            {
                //WriteLog(LOG_PART.LOCAL, LOG_TYPE.INFO, "PC : KP Int Vision inspection program Exception exit!!", LOG_LV.MID);
                Environment.Exit(0);
            }
        }
    }
}
