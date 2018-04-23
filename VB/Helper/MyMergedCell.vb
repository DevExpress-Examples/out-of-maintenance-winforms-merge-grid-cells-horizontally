Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication1
    Public Class MyMergedCell

        Public Sub New(ByVal rowHandle As Integer, ByVal col1 As GridColumn, ByVal col2 As GridColumn)
            _RowHandle = rowHandle
            _Column1 = col1
            _Column2 = col2
        End Sub

        Private _Column2 As GridColumn
Private _Column1 As GridColumn
        Private _RowHandle As Integer
        Public Property RowHandle() As Integer
            Get
                Return _RowHandle
            End Get
            Set(ByVal value As Integer)
                _RowHandle = value
            End Set
        End Property


        Public Property Column1() As GridColumn
            Get
                Return _Column1
            End Get
            Set(ByVal value As GridColumn)
                _Column1 = value

            End Set
        End Property


        Public Property Column2() As GridColumn
            Get
                Return _Column2
            End Get
            Set(ByVal value As GridColumn)
                _Column2 = value

            End Set
        End Property


    End Class
End Namespace
