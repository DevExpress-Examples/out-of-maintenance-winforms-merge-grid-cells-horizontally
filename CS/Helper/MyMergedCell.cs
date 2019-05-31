using DevExpress.XtraGrid.Columns;
using System;

namespace WindowsApplication1
{
    public class MyMergedCell
    {
        private GridColumn _Column1;

        private GridColumn _Column2;
        private int _RowHandle;

        public MyMergedCell(int rowHandle, GridColumn col1, GridColumn col2)
        {
            _RowHandle = rowHandle;
            _Column1 = col1;
            _Column2 = col2;
        }


        public GridColumn Column1 {
            get { return _Column1; }
            set {
                _Column1 = value;

            }
        }


        public GridColumn Column2 {
            get { return _Column2; }
            set {
                _Column2 = value;

            }
        }
        public int RowHandle {
            get { return _RowHandle; }
            set { _RowHandle = value; }
        }


    }
}
