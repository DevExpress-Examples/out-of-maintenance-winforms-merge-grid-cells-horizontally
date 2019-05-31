Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication1
    Public Class MyCellMergeHelper
        Private _MergedCells As List(Of MyMergedCell) = New List(Of MyMergedCell)()
        Private _view As GridView
        Private painter As MyGridPainter

        Public Sub New(ByVal view As GridView)
            _view = view
            AddHandler view.CustomDrawCell, AddressOf view_CustomDrawCell
            AddHandler view.GridControl.Paint, AddressOf GridControl_Paint
            AddHandler view.CellValueChanged, AddressOf view_CellValueChanged
            painter = New MyGridPainter(view)
        End Sub

        Private Sub DrawMergedCells(ByVal e As DXPaintEventArgs)
            For Each cell As MyMergedCell In _MergedCells
                painter.DrawMyMergedCell(cell, e)
            Next
        End Sub

        Private Function GetMergedCell(ByVal rowHandle As Integer, ByVal column As GridColumn) As MyMergedCell
            For Each cell As MyMergedCell In _MergedCells
                If cell.RowHandle = rowHandle AndAlso (column Is cell.Column1 OrElse column Is cell.Column2) Then Return cell
            Next

            Return Nothing
        End Function

        Private Sub GridControl_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Dim args As DXPaintEventArgs = New DXPaintEventArgs(e)
            DrawMergedCells(args)
        End Sub

        Private Function IsMergedCell(ByVal rowHandle As Integer, ByVal column As GridColumn) As Boolean
            Return GetMergedCell(rowHandle, column) IsNot Nothing
        End Function

        Private Sub view_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
            SafeSetMergedCellValue(GetMergedCell(e.RowHandle, e.Column), e.Value)
        End Sub

        Private Sub view_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
            If IsMergedCell(e.RowHandle, e.Column) Then e.Handled = Not painter.IsCustomPainting
        End Sub

        Public Function AddMergedCell(ByVal rowHandle As Integer, ByVal col1 As GridColumn, ByVal col2 As GridColumn) As MyMergedCell
            Dim cell As MyMergedCell = New MyMergedCell(rowHandle, col1, col2)
            _MergedCells.Add(cell)
            Return cell
        End Function

        Public Sub AddMergedCell(ByVal rowHandle As Integer, ByVal col1 As Integer, ByVal col2 As Integer, ByVal value As Object)
            SafeSetMergedCellValue(AddMergedCell(rowHandle, _view.Columns(col1), _view.Columns(col2)), value)
        End Sub

        Public Sub AddMergedCell(ByVal rowHandle As Integer, ByVal col1 As GridColumn, ByVal col2 As GridColumn, ByVal value As Object)
            Dim cell As MyMergedCell = AddMergedCell(rowHandle, col1, col2)
            SafeSetMergedCellValue(cell, value)
        End Sub

        Public Sub SafeSetCellValue(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal value As Object)
            If _view.GetRowCellValue(rowHandle, column) IsNot value Then _view.SetRowCellValue(rowHandle, column, value)
        End Sub

        Public Sub SafeSetMergedCellValue(ByVal cell As MyMergedCell, ByVal value As Object)
            If cell IsNot Nothing Then
                SafeSetCellValue(cell.RowHandle, cell.Column1, value)
                SafeSetCellValue(cell.RowHandle, cell.Column2, value)
            End If
        End Sub

        Public ReadOnly Property MergedCells As List(Of MyMergedCell)
            Get
                Return _MergedCells
            End Get
        End Property
    End Class
End Namespace
