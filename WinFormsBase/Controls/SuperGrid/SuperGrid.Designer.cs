using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace WinFormsBase.Controls
{
    partial class SuperGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuperGridView = new SuperGridControl();
            SuspendLayout();
            // 
            // SuperGridView
            // 
            SuperGridView.BackColor = Color.White;
            SuperGridView.Dock = DockStyle.Fill;
            SuperGridView.ForeColor = Color.Black;
            SuperGridView.Location = new Point(0, 0);
            SuperGridView.Name = "SuperDataGridView";
            SuperGridView.PrimaryGrid.EnableColumnFiltering = true;
            SuperGridView.PrimaryGrid.EnableFiltering = true;
            SuperGridView.PrimaryGrid.Filter.Visible = true;
            SuperGridView.PrimaryGrid.FilterMatchType = FilterMatchType.RegularExpressions;
            SuperGridView.Size = new Size(150, 150);
            SuperGridView.TabIndex = 0;
            SuperGridView.GetCellStyle += SuperGridView_GetCellStyle;
            // 
            // SuperGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SuperGridView);
            Name = "SuperGrid";
            ResumeLayout(false);
        }

        #endregion

        public SuperGridControl SuperGridView;
    }
}
