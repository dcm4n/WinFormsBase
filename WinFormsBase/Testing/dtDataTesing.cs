using System.Collections.Generic;
using System.Data;

namespace WinFormsBase.Testing
{
    public static class dtDataTesing
    {   
        public static DataTable GetSimpleDataTableForDataGridView()
        {
            DataTable dummyDataTable = new DataTable() { TableName = "Dummy data" };

            dummyDataTable.Columns.Add("Id", typeof(Int16));
            dummyDataTable.Columns.Add("Name", typeof(string));
            dummyDataTable.Columns.Add("Birthday", typeof(DateTime));
            dummyDataTable.Columns.Add("Rating", typeof(Decimal));
            dummyDataTable.Columns.Add("Active", typeof(bool));

            dummyDataTable.Rows.Add(1, "Emily", "16/12/2024", 1.5, true);
            dummyDataTable.Rows.Add(2, "Nicko", "14/02/2025", 3, false);
            dummyDataTable.Rows.Add(3, "Denice", "01/11/2024", 1.5, false);
            dummyDataTable.Rows.Add(4, "Sanford", "14/03/2025", 4, false);
            dummyDataTable.Rows.Add(5, "Artair", "03/06/2025", 12, true);
            dummyDataTable.Rows.Add(6, "Dev", "20/10/2024", 3, true);
            dummyDataTable.Rows.Add(7, "Tiler", "15/04/2025", 4.5, false);
            dummyDataTable.Rows.Add(8, "Nicolai", "13/10/2024", 12, false);
            dummyDataTable.Rows.Add(9, "Carce", "08/11/2024", 15, false);
            dummyDataTable.Rows.Add(10, "Farr", "20/03/2025", 3, true);

            return dummyDataTable;
        }

        public static DataTable GetSimpleDataTableForComboBox()
        {
            DataTable dummyDataTable = new DataTable() { TableName = "Dummy data" };

            dummyDataTable.Columns.Add("Id", typeof(Int16));
            dummyDataTable.Columns.Add("Name", typeof(string));

            dummyDataTable.Rows.Add(1, "Emily");
            dummyDataTable.Rows.Add(2, "Nicko");
            dummyDataTable.Rows.Add(3, "Denice");
            dummyDataTable.Rows.Add(4, "Sanford");
            dummyDataTable.Rows.Add(5, "Artair");
            dummyDataTable.Rows.Add(6, "Dev");
            dummyDataTable.Rows.Add(7, "Tiler");
            dummyDataTable.Rows.Add(8, "Nicolai");
            dummyDataTable.Rows.Add(9, "Carce");
            dummyDataTable.Rows.Add(10, "Farr");

            return dummyDataTable;
        }
    }
}



