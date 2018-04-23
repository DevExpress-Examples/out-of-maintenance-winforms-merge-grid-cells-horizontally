Namespace WindowsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.mergeItem = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 51)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(548, 380)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsCustomization.AllowSort = False
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            ' 
            ' gridView2
            ' 
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.mergeItem})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 1
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(548, 51)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 431)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(548, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 380)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(548, 51)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 380)
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.Text = "Tools"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.mergeItem)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' mergeItem
            ' 
            Me.mergeItem.Caption = "Merge"
            Me.mergeItem.Id = 0
            Me.mergeItem.Name = "mergeItem"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(548, 454)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private WithEvents mergeItem As DevExpress.XtraBars.BarButtonItem
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace

