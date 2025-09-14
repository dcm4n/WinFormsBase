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

            suggestionsComboBox1.DataSource = dtDataTesing.GetSimpleDataTableForComboBox();
            suggestionsComboBox1.ValueMember = "Id";
            suggestionsComboBox1.DisplayMember = "Name";
        }
    }
}
