using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System.ComponentModel;

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
            superGridView = new SuperGridControl();
            SuspendLayout();
            // 
            // SuperGridView
            // 
            superGridView.BackColor = Color.White;
            superGridView.Dock = DockStyle.Fill;
            superGridView.ForeColor = Color.Black;
            superGridView.Location = new Point(0, 0);
            superGridView.Name = "SuperDataGridView";
            superGridView.PrimaryGrid.EnableColumnFiltering = true;
            superGridView.PrimaryGrid.EnableFiltering = true;
            superGridView.PrimaryGrid.Filter.Visible = true;
            superGridView.PrimaryGrid.FilterMatchType = FilterMatchType.RegularExpressions;
            superGridView.Size = new Size(150, 150);
            superGridView.TabIndex = 0;
            superGridView.GetCellStyle += SuperGridView_GetCellStyle;
            // 
            // SuperGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(superGridView);
            Name = "SuperGrid";
            ResumeLayout(false);
        }

        #endregion
        private SuperGridControl superGridView;
    }
}
