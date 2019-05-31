using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public class MyCellMergeHelper
    {
        private List<MyMergedCell> _MergedCells = new List<MyMergedCell>();
        GridView _view;

        MyGridPainter painter;

        public MyCellMergeHelper(GridView view)
        {
            _view = view;
            view.CustomDrawCell += view_CustomDrawCell;
            view.GridControl.Paint += GridControl_Paint;
            view.CellValueChanged += view_CellValueChanged;
            painter = new MyGridPainter(view);
        }

        private void DrawMergedCells(DXPaintEventArgs e)
        {
            foreach(MyMergedCell cell in _MergedCells)
            {
                painter.DrawMergedCell(cell, e);
            }
        }
        private MyMergedCell GetMergedCell(int rowHandle, GridColumn column)
        {
            foreach(MyMergedCell cell in _MergedCells)
            {
                if(cell.RowHandle == rowHandle && (column == cell.Column1 || column == cell.Column2))
                    return cell;
            }
            return null;
        }

        private void GridControl_Paint(object sender, PaintEventArgs e)
        {
            DXPaintEventArgs args = new DXPaintEventArgs(e);
            DrawMergedCells(args);
        }

        private bool IsMergedCell(int rowHandle, GridColumn column)
        {
            return GetMergedCell(rowHandle, column) != null;
        }

        void view_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            SafeSetMergedCellValue(GetMergedCell(e.RowHandle, e.Column), e.Value);
        }

        void view_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if(IsMergedCell(e.RowHandle, e.Column))
                e.Handled = !painter.IsCustomPainting;
        }

        public MyMergedCell AddMergedCell(int rowHandle, GridColumn col1, GridColumn col2)
        {
            MyMergedCell cell = new MyMergedCell(rowHandle, col1, col2);
            _MergedCells.Add(cell);
            return cell;
        }
        public void AddMergedCell(int rowHandle, int col1, int col2, object value)
        {
            SafeSetMergedCellValue(AddMergedCell(rowHandle, _view.Columns[col1], _view.Columns[col2]), value);
        }

        public void AddMergedCell(int rowHandle, GridColumn col1, GridColumn col2, object value)
        {
            MyMergedCell cell = AddMergedCell(rowHandle, col1, col2);
            SafeSetMergedCellValue(cell, value);
        }
        public void SafeSetCellValue(int rowHandle, GridColumn column, object value)
        {
            if(_view.GetRowCellValue(rowHandle, column) != value)
                _view.SetRowCellValue(rowHandle, column, value);
        }

        public void SafeSetMergedCellValue(MyMergedCell cell, object value)
        {
            if(cell != null)
            {
                SafeSetCellValue(cell.RowHandle, cell.Column1, value);
                SafeSetCellValue(cell.RowHandle, cell.Column2, value);
            }
        }

        public List<MyMergedCell> MergedCells {
            get {
                return _MergedCells;
            }
        }
    }
}