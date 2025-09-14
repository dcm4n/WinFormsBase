using DevComponents.DotNetBar.SuperGrid;

namespace WinFormsBase
{
    partial class frmSuperGridTesting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            suggestionsComboBox1 = new WinFormsBase.Controls.SugestionsComboBox.SuggestionsComboBox();
            superGrid1 = new WinFormsBase.Controls.SuperGrid();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 3);
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(suggestionsComboBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(superGrid1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // suggestionsComboBox1
            // 
            suggestionsComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            suggestionsComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            suggestionsComboBox1.FormattingEnabled = true;
            suggestionsComboBox1.Location = new Point(3, 28);
            suggestionsComboBox1.Name = "suggestionsComboBox1";
            suggestionsComboBox1.Size = new Size(121, 23);
            suggestionsComboBox1.TabIndex = 4;
            // 
            // superGrid1
            // 
            superGrid1.Dock = DockStyle.Fill;
            superGrid1.Location = new Point(3, 68);
            superGrid1.Name = "superGrid1";
            superGrid1.Size = new Size(794, 357);
            superGrid1.TabIndex = 5;
            // 
            // frmSuperGridTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmSuperGridTesting";
            Text = "SuperGridTesting";
            FormClosing += frmSuperGridTesting_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private Controls.SugestionsComboBox.SuggestionsComboBox suggestionsComboBox1;
        private Controls.SuperGrid superGrid1;
    }
}
