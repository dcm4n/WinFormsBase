using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using System.ComponentModel;
using System.Data;

namespace WinFormsBase.Controls
{
    public partial class SuperGrid : UserControl
    {
        #region PUBLIC PROPERTIES

        [Browsable(true)]
        public SuperGridControl SuperGridView
        {
            get => superGridView;
        }

        #endregion

        #region PUBLIC METHODS

        public event EventHandler<GridCellDoubleClickEventArgs> CellDoubleClick
        {
            add => SuperGridView.CellDoubleClick += value;
            remove => SuperGridView.CellDoubleClick -= value;
        }

        public event EventHandler<GridRowDoubleClickEventArgs> RowDoubleClick
        {
            add => SuperGridView.RowDoubleClick += value;
            remove => SuperGridView.RowDoubleClick -= value;
        }

        public event EventHandler<GridGetCellStyleEventArgs> GetCellStyle
        {
            add => SuperGridView.GetCellStyle += value;
            remove => SuperGridView.GetCellStyle -= value;
        }

        #endregion

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
