﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public class ImageButton : Button
    {
        public Bitmap ButtonImage { get; set; }
        public Bitmap ButtonImageOver { get; set; }
        public Bitmap ButtonImageDown { get; set; }
        public Bitmap ButtonImageDiable { get; set; }

        public ImageButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ImageButton
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ImageButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ImageButton_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_MouseUp);
            this.EnabledChanged += new EventHandler(this.ImageButton_EnabledChanged);
            this.ResumeLayout(false);

        }

        private void ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = ButtonImageDown;
            if (false == this.Enabled) SetImageButtonEnable(this.Enabled);
        }

        private void ImageButton_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = ButtonImageOver;
            if (false == this.Enabled) SetImageButtonEnable(this.Enabled);
        }

        private void ImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = ButtonImage;
            if (false == this.Enabled) SetImageButtonEnable(this.Enabled);
        }

        private void ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = ButtonImage;
            if (false == this.Enabled) SetImageButtonEnable(this.Enabled);
        }

        private void ImageButton_EnabledChanged(object sender, EventArgs e)
        {
            SetImageButtonEnable(this.Enabled);
        }

        private void SetImageButtonEnable(bool _Enabled)
        {
            if (_Enabled)
            {
                this.BackgroundImage = ButtonImage;
            }

            else
            {
                this.BackgroundImage = ButtonImageDiable;
            }
        }
    }
}
