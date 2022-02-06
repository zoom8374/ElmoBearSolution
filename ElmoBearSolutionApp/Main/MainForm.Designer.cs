namespace ElmoBearSolutionApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.paneMenu = new System.Windows.Forms.Panel();
            this.ImgBtnAlign = new CustomControl.ImageButton();
            this.ImgBtnRecipe = new CustomControl.ImageButton();
            this.ImgBtnLog = new CustomControl.ImageButton();
            this.ImgBtnIO = new CustomControl.ImageButton();
            this.ImgBtnAuto = new CustomControl.ImageButton();
            this.ImgBtnStop = new CustomControl.ImageButton();
            this.labelProgramVer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgBtnMinimize = new CustomControl.ImageButton();
            this.ImgBtnClose = new CustomControl.ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.paneMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.labelProgramVer);
            this.panelTitle.Controls.Add(this.ImgBtnMinimize);
            this.panelTitle.Controls.Add(this.ImgBtnClose);
            this.panelTitle.Controls.Add(this.panel2);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1920, 52);
            this.panelTitle.TabIndex = 2;
            // 
            // paneMenu
            // 
            this.paneMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.paneMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneMenu.Controls.Add(this.panel1);
            this.paneMenu.Controls.Add(this.ImgBtnAlign);
            this.paneMenu.Controls.Add(this.ImgBtnRecipe);
            this.paneMenu.Controls.Add(this.ImgBtnLog);
            this.paneMenu.Controls.Add(this.ImgBtnIO);
            this.paneMenu.Controls.Add(this.ImgBtnAuto);
            this.paneMenu.Controls.Add(this.ImgBtnStop);
            this.paneMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneMenu.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paneMenu.Location = new System.Drawing.Point(0, 52);
            this.paneMenu.Name = "paneMenu";
            this.paneMenu.Size = new System.Drawing.Size(1920, 96);
            this.paneMenu.TabIndex = 6;
            // 
            // ImgBtnAlign
            // 
            this.ImgBtnAlign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ImgBtnAlign.ButtonImage = null;
            this.ImgBtnAlign.ButtonImageDiable = null;
            this.ImgBtnAlign.ButtonImageDown = null;
            this.ImgBtnAlign.ButtonImageOver = null;
            this.ImgBtnAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnAlign.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnAlign.ForeColor = System.Drawing.Color.White;
            this.ImgBtnAlign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImgBtnAlign.Location = new System.Drawing.Point(405, 5);
            this.ImgBtnAlign.Name = "ImgBtnAlign";
            this.ImgBtnAlign.Size = new System.Drawing.Size(74, 86);
            this.ImgBtnAlign.TabIndex = 29;
            this.ImgBtnAlign.Text = "Align";
            this.ImgBtnAlign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnAlign.UseVisualStyleBackColor = false;
            // 
            // ImgBtnRecipe
            // 
            this.ImgBtnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ImgBtnRecipe.ButtonImage = null;
            this.ImgBtnRecipe.ButtonImageDiable = null;
            this.ImgBtnRecipe.ButtonImageDown = null;
            this.ImgBtnRecipe.ButtonImageOver = null;
            this.ImgBtnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnRecipe.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnRecipe.ForeColor = System.Drawing.Color.White;
            this.ImgBtnRecipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImgBtnRecipe.Location = new System.Drawing.Point(247, 5);
            this.ImgBtnRecipe.Name = "ImgBtnRecipe";
            this.ImgBtnRecipe.Size = new System.Drawing.Size(74, 86);
            this.ImgBtnRecipe.TabIndex = 12;
            this.ImgBtnRecipe.Text = "Recipe";
            this.ImgBtnRecipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnRecipe.UseVisualStyleBackColor = false;
            // 
            // ImgBtnLog
            // 
            this.ImgBtnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ImgBtnLog.ButtonImage = null;
            this.ImgBtnLog.ButtonImageDiable = null;
            this.ImgBtnLog.ButtonImageDown = null;
            this.ImgBtnLog.ButtonImageOver = null;
            this.ImgBtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnLog.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnLog.ForeColor = System.Drawing.Color.White;
            this.ImgBtnLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImgBtnLog.Location = new System.Drawing.Point(326, 5);
            this.ImgBtnLog.Name = "ImgBtnLog";
            this.ImgBtnLog.Size = new System.Drawing.Size(74, 86);
            this.ImgBtnLog.TabIndex = 11;
            this.ImgBtnLog.Text = "LOG";
            this.ImgBtnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnLog.UseVisualStyleBackColor = false;
            // 
            // ImgBtnIO
            // 
            this.ImgBtnIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ImgBtnIO.ButtonImage = null;
            this.ImgBtnIO.ButtonImageDiable = null;
            this.ImgBtnIO.ButtonImageDown = null;
            this.ImgBtnIO.ButtonImageOver = null;
            this.ImgBtnIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnIO.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnIO.ForeColor = System.Drawing.Color.White;
            this.ImgBtnIO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImgBtnIO.Location = new System.Drawing.Point(168, 5);
            this.ImgBtnIO.Name = "ImgBtnIO";
            this.ImgBtnIO.Size = new System.Drawing.Size(74, 86);
            this.ImgBtnIO.TabIndex = 10;
            this.ImgBtnIO.Text = "PLC";
            this.ImgBtnIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnIO.UseVisualStyleBackColor = false;
            // 
            // ImgBtnAuto
            // 
            this.ImgBtnAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(21)))));
            this.ImgBtnAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImgBtnAuto.ButtonImage = null;
            this.ImgBtnAuto.ButtonImageDiable = null;
            this.ImgBtnAuto.ButtonImageDown = null;
            this.ImgBtnAuto.ButtonImageOver = null;
            this.ImgBtnAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ImgBtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnAuto.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnAuto.ForeColor = System.Drawing.Color.White;
            this.ImgBtnAuto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImgBtnAuto.Location = new System.Drawing.Point(9, 5);
            this.ImgBtnAuto.Name = "ImgBtnAuto";
            this.ImgBtnAuto.Size = new System.Drawing.Size(74, 86);
            this.ImgBtnAuto.TabIndex = 1;
            this.ImgBtnAuto.Text = "Auto";
            this.ImgBtnAuto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnAuto.UseVisualStyleBackColor = false;
            // 
            // ImgBtnStop
            // 
            this.ImgBtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ImgBtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImgBtnStop.ButtonImage = null;
            this.ImgBtnStop.ButtonImageDiable = null;
            this.ImgBtnStop.ButtonImageDown = null;
            this.ImgBtnStop.ButtonImageOver = null;
            this.ImgBtnStop.Enabled = false;
            this.ImgBtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnStop.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnStop.ForeColor = System.Drawing.Color.White;
            this.ImgBtnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImgBtnStop.Location = new System.Drawing.Point(89, 5);
            this.ImgBtnStop.Name = "ImgBtnStop";
            this.ImgBtnStop.Size = new System.Drawing.Size(74, 86);
            this.ImgBtnStop.TabIndex = 2;
            this.ImgBtnStop.Text = "Stop";
            this.ImgBtnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnStop.UseVisualStyleBackColor = false;
            // 
            // labelProgramVer
            // 
            this.labelProgramVer.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProgramVer.ForeColor = System.Drawing.Color.White;
            this.labelProgramVer.Location = new System.Drawing.Point(160, 26);
            this.labelProgramVer.Name = "labelProgramVer";
            this.labelProgramVer.Size = new System.Drawing.Size(120, 14);
            this.labelProgramVer.TabIndex = 15;
            this.labelProgramVer.Text = "Ver.1.0.0.0";
            this.labelProgramVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImage = global::ElmoBearSolutionApp.Properties.Resources.KP_IC2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(1670, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 111);
            this.panel1.TabIndex = 30;
            // 
            // ImgBtnMinimize
            // 
            this.ImgBtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnMinimize.BackgroundImage = global::ElmoBearSolutionApp.Properties.Resources.Minimize;
            this.ImgBtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgBtnMinimize.ButtonImage = global::ElmoBearSolutionApp.Properties.Resources.Minimize;
            this.ImgBtnMinimize.ButtonImageDiable = global::ElmoBearSolutionApp.Properties.Resources.Minimize;
            this.ImgBtnMinimize.ButtonImageDown = global::ElmoBearSolutionApp.Properties.Resources.Minimize;
            this.ImgBtnMinimize.ButtonImageOver = global::ElmoBearSolutionApp.Properties.Resources.Minimize;
            this.ImgBtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnMinimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ImgBtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnMinimize.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnMinimize.ForeColor = System.Drawing.Color.White;
            this.ImgBtnMinimize.Location = new System.Drawing.Point(1844, 11);
            this.ImgBtnMinimize.Name = "ImgBtnMinimize";
            this.ImgBtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.ImgBtnMinimize.TabIndex = 14;
            this.ImgBtnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnMinimize.UseVisualStyleBackColor = false;
            this.ImgBtnMinimize.Click += new System.EventHandler(this.ImgBtnMinimize_Click);
            // 
            // ImgBtnClose
            // 
            this.ImgBtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnClose.BackgroundImage = global::ElmoBearSolutionApp.Properties.Resources.Close;
            this.ImgBtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgBtnClose.ButtonImage = global::ElmoBearSolutionApp.Properties.Resources.Close;
            this.ImgBtnClose.ButtonImageDiable = global::ElmoBearSolutionApp.Properties.Resources.Close;
            this.ImgBtnClose.ButtonImageDown = global::ElmoBearSolutionApp.Properties.Resources.Close;
            this.ImgBtnClose.ButtonImageOver = global::ElmoBearSolutionApp.Properties.Resources.Close;
            this.ImgBtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ImgBtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ImgBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtnClose.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImgBtnClose.ForeColor = System.Drawing.Color.White;
            this.ImgBtnClose.Location = new System.Drawing.Point(1877, 11);
            this.ImgBtnClose.Name = "ImgBtnClose";
            this.ImgBtnClose.Size = new System.Drawing.Size(30, 30);
            this.ImgBtnClose.TabIndex = 13;
            this.ImgBtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImgBtnClose.UseVisualStyleBackColor = false;
            this.ImgBtnClose.Click += new System.EventHandler(this.ImgBtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.BackgroundImage = global::ElmoBearSolutionApp.Properties.Resources.Program_Logo_White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 45);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Size = new System.Drawing.Size(1918, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vision Inspection Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelMain.Location = new System.Drawing.Point(0, 147);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1920, 933);
            this.panelMain.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.paneMenu);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vision Inspection App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelTitle.ResumeLayout(false);
            this.paneMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel2;
        private CustomControl.ImageButton ImgBtnMinimize;
        private CustomControl.ImageButton ImgBtnClose;
        private System.Windows.Forms.Panel paneMenu;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.ImageButton ImgBtnAlign;
        private CustomControl.ImageButton ImgBtnRecipe;
        private CustomControl.ImageButton ImgBtnLog;
        private CustomControl.ImageButton ImgBtnIO;
        private CustomControl.ImageButton ImgBtnAuto;
        private CustomControl.ImageButton ImgBtnStop;
        private System.Windows.Forms.Label labelProgramVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
    }
}

