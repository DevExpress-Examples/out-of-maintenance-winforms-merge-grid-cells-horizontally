Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Private _Helper As MyCellMergeHelper
        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As New DataTable()
            tbl.Columns.Add("Name1", GetType(String))
            tbl.Columns.Add("Name2", GetType(String))
            tbl.Columns.Add("Name3", GetType(String))
            tbl.Columns.Add("Name4", GetType(String))
            For i As Integer = 0 To RowCount - 1
                tbl.Rows.Add(New Object() { String.Format("Name{0}", i), String.Format("Name{0}", i), String.Format("Name{0}", i), String.Format("Name{0}", i) })
            Next i
            Return tbl
        End Function
        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = CreateTable(20)
            _Helper = New MyCellMergeHelper(gridView1)
            _Helper.AddMergedCell(1, 1, 2, "MyMergedCell1 (Very long text)")
            _Helper.AddMergedCell(2, 2, 3, "MyMergedCell2")
            _Helper.AddMergedCell(3, 1, 2, "MyMergedCell3")
            _Helper.AddMergedCell(3, 2, 3, "MyMergedCell3")
        End Sub
        Private Sub MergeItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mergeItem.ItemClick
            Dim cells() As DevExpress.XtraGrid.Views.Base.GridCell = gridView1.GetSelectedCells()
            If cells.Length = 2 AndAlso Math.Abs(cells(0).Column.AbsoluteIndex - cells(1).Column.AbsoluteIndex) = 1 Then
                Dim rowHandle As Integer = cells(0).RowHandle
                If rowHandle = cells(1).RowHandle Then
                    Dim value As Object = gridView1.GetRowCellValue(rowHandle, cells(0).Column)
                    _Helper.AddMergedCell(rowHandle, cells(0).Column.AbsoluteIndex, cells(1).Column.AbsoluteIndex, value)
                    gridView1.RefreshRow(rowHandle)
                End If
            End If
        End Sub
    End Class
End Namespace