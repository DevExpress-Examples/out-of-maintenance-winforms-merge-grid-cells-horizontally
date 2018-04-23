using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Drawing;

namespace WindowsApplication1 {
    public class MyGridPainter : GridPainter {
        private bool _IsCustomPainting;
        public bool IsCustomPainting {
            get {
                return _IsCustomPainting;
            }
            set {
                _IsCustomPainting = value;
            }
        }
        public MyGridPainter(GridView view)
            : base(view) {
        }
        public void DrawMergedCell(MyMergedCell cell, PaintExEventArgs e) {
            int delta = cell.Column1.VisibleIndex - cell.Column2.VisibleIndex;
            if(Math.Abs(delta) > 1)
                return;
            GridViewInfo vi = View.GetViewInfo() as GridViewInfo;
            GridCellInfo gridCellInfo1 = vi.GetGridCellInfo(cell.RowHandle, cell.Column1);
            GridCellInfo gridCellInfo2 = vi.GetGridCellInfo(cell.RowHandle, cell.Column2);
            if(gridCellInfo1 == null || gridCellInfo2 == null)
                return;
            Rectangle targetRect = Rectangle.Union(gridCellInfo1.Bounds, gridCellInfo2.Bounds);
            gridCellInfo1.Bounds = targetRect;
            gridCellInfo1.CellValueRect = targetRect;
            gridCellInfo2.Bounds = targetRect;
            gridCellInfo2.CellValueRect = targetRect;
            if(delta < 0)
                gridCellInfo1 = gridCellInfo2;
            Rectangle bounds = gridCellInfo1.ViewInfo.Bounds;
            bounds.Width = targetRect.Width;
            bounds.Height = targetRect.Height;
            gridCellInfo1.ViewInfo.Bounds = bounds;
            gridCellInfo1.ViewInfo.CalcViewInfo(e.Cache.Graphics);
            IsCustomPainting = true;
            gridCellInfo1.Appearance.FillRectangle(e.Cache, gridCellInfo1.Bounds);
            DrawRowCell(new GridViewDrawArgs(e.Cache, vi, vi.ViewRects.Bounds), gridCellInfo1);
            IsCustomPainting = false;
        }

    }

}
