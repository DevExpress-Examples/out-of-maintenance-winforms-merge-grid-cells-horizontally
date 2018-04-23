using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;

namespace WindowsApplication1 {
    public class MyCellMergeHelper {

        MyGridPainter painter;
        GridView _view;
        private List<MyMergedCell> _MergedCells = new List<MyMergedCell>();
        public List<MyMergedCell> MergedCells {
            get {
                return _MergedCells;
            }
        }
        public MyCellMergeHelper(GridView view) {
            _view = view;
            view.CustomDrawCell += new RowCellCustomDrawEventHandler(view_CustomDrawCell);
            view.GridControl.PaintEx += GridControl_PaintEx;
            view.CellValueChanged += new CellValueChangedEventHandler(view_CellValueChanged);
            painter = new MyGridPainter(view);
        }

        private void GridControl_PaintEx(object sender, DevExpress.XtraGrid.PaintExEventArgs e) {
            DrawMergedCells(e);
        }

        public MyMergedCell AddMergedCell(int rowHandle, GridColumn col1, GridColumn col2) {
            MyMergedCell cell = new MyMergedCell(rowHandle, col1, col2);
            _MergedCells.Add(cell);
            return cell;
        }
        public void AddMergedCell(int rowHandle, int col1, int col2, object value) {
            AddMergedCell(rowHandle, _view.Columns[col1], _view.Columns[col2]);
        }

        public void AddMergedCell(int rowHandle, GridColumn col1, GridColumn col2, object value) {
            MyMergedCell cell = AddMergedCell(rowHandle, col1, col2);
            SafeSetMergedCellValue(cell, value);
        }

        public void SafeSetMergedCellValue(MyMergedCell cell, object value) {
            if(cell != null) {
                SafeSetCellValue(cell.RowHandle, cell.Column1, value);
                SafeSetCellValue(cell.RowHandle, cell.Column2, value);
            }
        }
        public void SafeSetCellValue(int rowHandle, GridColumn column, object value) {
            if(_view.GetRowCellValue(rowHandle, column) != value)
                _view.SetRowCellValue(rowHandle, column, value);
        }
        private MyMergedCell GetMergedCell(int rowHandle, GridColumn column) {
            foreach(MyMergedCell cell in _MergedCells) {
                if(cell.RowHandle == rowHandle && (column == cell.Column1 || column == cell.Column2))
                    return cell;
            }
            return null;
        }

        private bool IsMergedCell(int rowHandle, GridColumn column) {
            return GetMergedCell(rowHandle, column) != null;
        }

        private void DrawMergedCells(PaintExEventArgs e) {
            foreach(MyMergedCell cell in _MergedCells) {
                painter.DrawMergedCell(cell, e);
            }
        }

        void view_CellValueChanged(object sender, CellValueChangedEventArgs e) {
            SafeSetMergedCellValue(GetMergedCell(e.RowHandle, e.Column), e.Value);
        }

        void view_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
            if(IsMergedCell(e.RowHandle, e.Column))
                e.Handled = !painter.IsCustomPainting;
        }
    }
}