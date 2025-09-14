using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using System.ComponentModel;
using System.Data;

namespace WinFormsBase.Controls
{
    public partial class SuperGrid : UserControl
    {
        [Browsable(true)]
        public SuperGridControl SuperGridView
        {
            get => superGridView;
        }

        public SuperGrid()
        {
            InitializeComponent();

            // Theme
            StyleManager styleManager = new StyleManager();
            styleManager.ManagerStyle = eStyle.Metro;

            // Initial style
            Dock = DockStyle.Fill;
            superGridView.PrimaryGrid.GridPanel.ColumnHeader.FilterImageVisibility = ImageVisibility.Never;

            // Preload empty datatable
            DataTable dummyDataTable = new DataTable();
            dummyDataTable.Rows.Add();
            superGridView.PrimaryGrid.DataSource = dummyDataTable;
        }

        private void SuperGridView_GetCellStyle(object sender, GridGetCellStyleEventArgs e)
        {
            // Center checkbox in CheckBox columns
            if (e.GridCell?.GridColumn.EditorType == typeof(GridCheckBoxXEditControl))
            {
                e.Style.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            }
        }
    }
}
