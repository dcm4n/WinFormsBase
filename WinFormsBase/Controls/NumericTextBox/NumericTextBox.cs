using System.Windows.Forms;

namespace WinFormsBase.Controls.NumericTextBox
{
    public class NumericTextBox : NumericUpDown
    {
        public NumericTextBox()
        {
            Controls[0].Visible = false;
            Maximum = Decimal.MaxValue;
            DecimalPlaces = 2;
        }

        protected override void OnTextBoxResize(object? source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }
    }
}
