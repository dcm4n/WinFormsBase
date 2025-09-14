using DevComponents.DotNetBar.SuperGrid.Style;
using WinFormsBase.Testing;

namespace WinFormsBase
{
    public partial class frmSuperGridTesting : Form
    {
        public frmSuperGridTesting()
        {
            InitializeComponent();

            superGrid1.SuperGridView.PrimaryGrid.DataSource = dtDataTesing.GetSimpleDataTableForDataGridView();
            superGrid1.SuperGridView.GetCellStyle += SuperGridView_GetCellStyle;

            suggestionsComboBox1.DataSource = dtDataTesing.GetSimpleDataTableForComboBox();
            suggestionsComboBox1.ValueMember = "Id";
            suggestionsComboBox1.DisplayMember = "Name";
        }

        private void SuperGridView_GetCellStyle(object? sender, DevComponents.DotNetBar.SuperGrid.GridGetCellStyleEventArgs e)
        {

        }

        private void frmSuperGridTesting_FormClosing(object sender, FormClosingEventArgs e)
        {
            superGrid1.SuperGridView.GetCellStyle -= SuperGridView_GetCellStyle;
        }
    }
}
