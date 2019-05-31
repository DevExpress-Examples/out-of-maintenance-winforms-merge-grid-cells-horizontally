Namespace WindowsApplication1
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.mergeItem = New DevExpress.XtraBars.BarButtonItem()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 51)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(548, 380)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsCustomization.AllowSort = False
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mergeItem})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 1
            Me.barManager1.StatusBar = Me.bar3
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.Text = "Tools"
            Me.bar1.Visible = False
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mergeItem)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            Me.bar3.Visible = False
            Me.mergeItem.Caption = "Merge"
            Me.mergeItem.Id = 0
            Me.mergeItem.Name = "mergeItem"
            AddHandler Me.mergeItem.ItemClick, AddressOf Me.MergeItem_ItemClick
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(548, 454)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private mergeItem As DevExpress.XtraBars.BarButtonItem
        Private bar3 As DevExpress.XtraBars.Bar
    End Class
End Namespace