﻿namespace CustomControl
{
    partial class GridViewManager
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridViewControl = new CustomControl.QuickDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewControl)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewControl
            // 
            this.GridViewControl.AllowUserToAddRows = false;
            this.GridViewControl.AllowUserToDeleteRows = false;
            this.GridViewControl.AllowUserToResizeColumns = false;
            this.GridViewControl.AllowUserToResizeRows = false;
            this.GridViewControl.BackgroundColor = System.Drawing.Color.White;
            this.GridViewControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewControl.Location = new System.Drawing.Point(0, 0);
            this.GridViewControl.MultiSelect = false;
            this.GridViewControl.Name = "GridViewControl";
            this.GridViewControl.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewControl.RowHeadersVisible = false;
            this.GridViewControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewControl.RowTemplate.Height = 23;
            this.GridViewControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewControl.Size = new System.Drawing.Size(1262, 600);
            this.GridViewControl.TabIndex = 3;
            this.GridViewControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewControl_CellDoubleClick);
            this.GridViewControl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridViewControl_CellFormatting);
            // 
            // GridViewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridViewControl);
            this.Name = "GridViewManager";
            this.Size = new System.Drawing.Size(1262, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QuickDataGridView GridViewControl;
    }

    #region QuickDataGridView
    public class QuickDataGridView : System.Windows.Forms.DataGridView
    {
        public QuickDataGridView()
        {
            DoubleBuffered = true;
        }
    }
    #endregion QuickDataGridView
}
