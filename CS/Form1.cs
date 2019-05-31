using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {

        private MyCellMergeHelper _Helper;

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            _Helper = new MyCellMergeHelper(gridView1);
            _Helper.AddMergedCell(1, 1, 2, "MyMergedCell1 (Very long text)");
            _Helper.AddMergedCell(2, 2, 3, "MyMergedCell2");
            _Helper.AddMergedCell(3, 1, 2, "MyMergedCell3");
            _Helper.AddMergedCell(3, 2, 3, "MyMergedCell3");
        }

        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name1", typeof(string));
            tbl.Columns.Add("Name2", typeof(string));
            tbl.Columns.Add("Name3", typeof(string));
            tbl.Columns.Add("Name4", typeof(string));
            for(int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), String.Format("Name{0}", i), String.Format("Name{0}", i), String.Format("Name{0}", i) });
            return tbl;
        }
        private void MergeItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.GridCell[] cells = gridView1.GetSelectedCells();
            if(cells.Length == 2 && Math.Abs(cells[0].Column.AbsoluteIndex - cells[1].Column.AbsoluteIndex) == 1)
            {
                int rowHandle = cells[0].RowHandle;
                if(rowHandle == cells[1].RowHandle)
                {
                    object value = gridView1.GetRowCellValue(rowHandle, cells[0].Column);
                    _Helper.AddMergedCell(rowHandle, cells[0].Column.AbsoluteIndex, cells[1].Column.AbsoluteIndex, value);
                    gridView1.RefreshRow(rowHandle);
                }
            }
        }
    }
}