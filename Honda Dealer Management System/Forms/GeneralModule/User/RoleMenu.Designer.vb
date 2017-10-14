<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoleMenu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.RoleMenuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoleMenuXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RoleNameTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RoleXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MenuNameTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MenuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoleMenuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoleMenuXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoleNameTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoleXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuNameTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl1)
        Me.XtraScrollableControl1.Controls.Add(Me.BatalBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.HapusBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.EditBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.PrintBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.SimpanBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.TambahBtn)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(844, 476)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.RoleNameTxt)
        Me.PanelControl1.Controls.Add(Me.MenuNameTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(786, 391)
        Me.PanelControl1.TabIndex = 19
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(24, 93)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(731, 259)
        Me.PanelControl2.TabIndex = 4
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.RoleMenuBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(727, 255)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RoleMenuBS
        '
        Me.RoleMenuBS.DataSource = Me.RoleMenuXpCollection
        '
        'RoleMenuXpCollection
        '
        Me.RoleMenuXpCollection.DisplayableProperties = "Id;Roleid;Menuid"
        Me.RoleMenuXpCollection.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.RoleMenuModel)
        Me.RoleMenuXpCollection.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 111
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Menu Name"
        Me.GridColumn2.FieldName = "MenuName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 319
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Menu Level"
        Me.GridColumn3.FieldName = "MenuLevel"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 319
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Menu Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Roles Name"
        '
        'RoleNameTxt
        '
        Me.RoleNameTxt.Location = New System.Drawing.Point(115, 25)
        Me.RoleNameTxt.Name = "RoleNameTxt"
        Me.RoleNameTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RoleNameTxt.Properties.DataSource = Me.RoleXpCollection
        Me.RoleNameTxt.Properties.DisplayMember = "RoleName"
        Me.RoleNameTxt.Properties.NullText = ""
        Me.RoleNameTxt.Properties.View = Me.GridLookUpEdit1View
        Me.RoleNameTxt.Size = New System.Drawing.Size(185, 20)
        Me.RoleNameTxt.TabIndex = 1
        '
        'RoleXpCollection
        '
        Me.RoleXpCollection.DisplayableProperties = "Id;RoleName;CreatedAt;CreatedBy;RoleMenus;Users"
        Me.RoleXpCollection.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.RoleModel)
        Me.RoleXpCollection.Session = Me.UOW
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'MenuNameTxt
        '
        Me.MenuNameTxt.Location = New System.Drawing.Point(115, 51)
        Me.MenuNameTxt.Name = "MenuNameTxt"
        Me.MenuNameTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MenuNameTxt.Properties.DataSource = Me.MenuBS
        Me.MenuNameTxt.Properties.DisplayMember = "MenuName"
        Me.MenuNameTxt.Properties.NullText = ""
        Me.MenuNameTxt.Properties.ValueMember = "Id"
        Me.MenuNameTxt.Properties.View = Me.GridView2
        Me.MenuNameTxt.Size = New System.Drawing.Size(185, 20)
        Me.MenuNameTxt.TabIndex = 3
        '
        'MenuBS
        '
        Me.MenuBS.DataSource = Me.MenuXpCollection
        '
        'MenuXpCollection
        '
        Me.MenuXpCollection.DisplayableProperties = "Id;MenuName;MenuLevel;ParentMenu;CreatedAt;CreatedBy;RoleMenus"
        Me.MenuXpCollection.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.MenuModel)
        Me.MenuXpCollection.Session = Me.UOW
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 18
        Me.BatalBtn.Text = "Batal"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 17
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBtn
        '
        Me.EditBtn.Enabled = False
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 16
        Me.EditBtn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 15
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 14
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 13
        Me.TambahBtn.Text = "Tambah"
        '
        'RoleMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 476)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "RoleMenu"
        Me.Text = "Roles Menu"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoleMenuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoleMenuXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoleNameTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoleXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuNameTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RoleNameTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MenuNameTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RoleMenuXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RoleMenuBS As BindingSource
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RoleXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents MenuXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents MenuBS As BindingSource
End Class
