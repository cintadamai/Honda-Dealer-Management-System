<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.XtraScrollableControl = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.UserBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Karyawan = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.KaryawanBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaryawanXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.isActiveCkbx = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.personName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.username = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.role = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RoleBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoleXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.validator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.ResetPassBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraScrollableControl.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Karyawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isActiveCkbx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.role.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoleBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoleXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraScrollableControl
        '
        Me.XtraScrollableControl.Controls.Add(Me.BatalBtn)
        Me.XtraScrollableControl.Controls.Add(Me.PanelControl2)
        Me.XtraScrollableControl.Controls.Add(Me.PanelControl1)
        Me.XtraScrollableControl.Controls.Add(Me.HapusBtn)
        Me.XtraScrollableControl.Controls.Add(Me.EditBtn)
        Me.XtraScrollableControl.Controls.Add(Me.PrintBtn)
        Me.XtraScrollableControl.Controls.Add(Me.SimpanBtn)
        Me.XtraScrollableControl.Controls.Add(Me.TambahBtn)
        Me.XtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl.Name = "XtraScrollableControl"
        Me.XtraScrollableControl.Size = New System.Drawing.Size(840, 494)
        Me.XtraScrollableControl.TabIndex = 1
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 12
        Me.BatalBtn.Text = "Batal"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(316, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(516, 404)
        Me.PanelControl2.TabIndex = 11
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.UserBS
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(512, 400)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'UserBS
        '
        Me.UserBS.DataSource = Me.UserXpCollection
        '
        'UserXpCollection
        '
        Me.UserXpCollection.DeleteObjectOnRemove = True
        Me.UserXpCollection.DisplayableProperties = "Id;Username;PersonName;Password;Role;Karyawan;Isactive"
        Me.UserXpCollection.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UserModel)
        Me.UserXpCollection.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colUsername, Me.colPersonName, Me.colIsactive, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUsername, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 45
        '
        'colUsername
        '
        Me.colUsername.FieldName = "Username"
        Me.colUsername.Name = "colUsername"
        Me.colUsername.Visible = True
        Me.colUsername.VisibleIndex = 1
        Me.colUsername.Width = 124
        '
        'colPersonName
        '
        Me.colPersonName.FieldName = "PersonName"
        Me.colPersonName.Name = "colPersonName"
        Me.colPersonName.Visible = True
        Me.colPersonName.VisibleIndex = 2
        Me.colPersonName.Width = 124
        '
        'colIsactive
        '
        Me.colIsactive.Caption = "isActive"
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.Visible = True
        Me.colIsactive.VisibleIndex = 4
        Me.colIsactive.Width = 57
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Role"
        Me.GridColumn1.FieldName = "Role.RoleName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 144
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ResetPassBtn)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.Karyawan)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.isActiveCkbx)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.personName)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.username)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.id)
        Me.PanelControl1.Controls.Add(Me.role)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(298, 404)
        Me.PanelControl1.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 123)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "KaryawanID"
        '
        'Karyawan
        '
        Me.Karyawan.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "Id", True))
        Me.Karyawan.Location = New System.Drawing.Point(107, 120)
        Me.Karyawan.Name = "Karyawan"
        Me.Karyawan.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.Karyawan.Properties.Appearance.Options.UseBackColor = True
        Me.Karyawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Karyawan.Properties.DataSource = Me.KaryawanXpCollection
        Me.Karyawan.Properties.DisplayMember = "NamaKaryawan"
        Me.Karyawan.Properties.NullText = ""
        Me.Karyawan.Properties.View = Me.GridView2
        Me.Karyawan.Size = New System.Drawing.Size(159, 20)
        Me.Karyawan.TabIndex = 9
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.Karyawan, ConditionValidationRule1)
        '
        'KaryawanBS
        '
        Me.KaryawanBS.DataMember = "Karyawan"
        Me.KaryawanBS.DataSource = Me.UserBS
        '
        'KaryawanXpCollection
        '
        Me.KaryawanXpCollection.DisplayableProperties = resources.GetString("KaryawanXpCollection.DisplayableProperties")
        Me.KaryawanXpCollection.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.KaryawanModel)
        Me.KaryawanXpCollection.Session = Me.UOW
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colNamaKaryawan, Me.colIsactive1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        '
        'colNamaKaryawan
        '
        Me.colNamaKaryawan.FieldName = "NamaKaryawan"
        Me.colNamaKaryawan.Name = "colNamaKaryawan"
        Me.colNamaKaryawan.Visible = True
        Me.colNamaKaryawan.VisibleIndex = 1
        '
        'colIsactive1
        '
        Me.colIsactive1.FieldName = "Isactive"
        Me.colIsactive1.Name = "colIsactive1"
        Me.colIsactive1.Visible = True
        Me.colIsactive1.VisibleIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Role"
        '
        'isActiveCkbx
        '
        Me.isActiveCkbx.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBS, "Isactive", True))
        Me.isActiveCkbx.Location = New System.Drawing.Point(107, 146)
        Me.isActiveCkbx.Name = "isActiveCkbx"
        Me.isActiveCkbx.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.isActiveCkbx.Properties.Appearance.Options.UseBackColor = True
        Me.isActiveCkbx.Properties.Caption = "isActive"
        Me.isActiveCkbx.Size = New System.Drawing.Size(75, 19)
        Me.isActiveCkbx.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Person Name"
        '
        'personName
        '
        Me.personName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBS, "PersonName", True))
        Me.personName.Location = New System.Drawing.Point(107, 68)
        Me.personName.Name = "personName"
        Me.personName.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.personName.Properties.Appearance.Options.UseBackColor = True
        Me.personName.Size = New System.Drawing.Size(159, 20)
        Me.personName.TabIndex = 4
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.personName, ConditionValidationRule2)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Username"
        '
        'username
        '
        Me.username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBS, "Username", True))
        Me.username.Location = New System.Drawing.Point(107, 42)
        Me.username.Name = "username"
        Me.username.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.username.Properties.Appearance.Options.UseBackColor = True
        Me.username.Size = New System.Drawing.Size(159, 20)
        Me.username.TabIndex = 2
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.username, ConditionValidationRule3)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ID"
        '
        'id
        '
        Me.id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBS, "Id", True))
        Me.id.Location = New System.Drawing.Point(107, 16)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.id.Properties.Appearance.Options.UseBackColor = True
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 0
        '
        'role
        '
        Me.role.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RoleBS, "Id", True))
        Me.role.Location = New System.Drawing.Point(107, 94)
        Me.role.Name = "role"
        Me.role.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.role.Properties.Appearance.Options.UseBackColor = True
        Me.role.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.role.Properties.DataSource = Me.RoleXpCollection
        Me.role.Properties.DisplayMember = "RoleName"
        Me.role.Properties.NullText = ""
        Me.role.Properties.ValueMember = "Id"
        Me.role.Properties.View = Me.GridLookUpEdit1View
        Me.role.Size = New System.Drawing.Size(159, 20)
        Me.role.TabIndex = 7
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.role, ConditionValidationRule4)
        '
        'RoleBS
        '
        Me.RoleBS.DataMember = "Role"
        Me.RoleBS.DataSource = Me.UserBS
        '
        'RoleXpCollection
        '
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
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 9
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 8
        Me.EditBtn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 7
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 6
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 5
        Me.TambahBtn.Text = "Tambah"
        '
        'ResetPassBtn
        '
        Me.ResetPassBtn.Location = New System.Drawing.Point(107, 185)
        Me.ResetPassBtn.Name = "ResetPassBtn"
        Me.ResetPassBtn.Size = New System.Drawing.Size(90, 24)
        Me.ResetPassBtn.TabIndex = 11
        Me.ResetPassBtn.Text = "Reset Password"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 494)
        Me.Controls.Add(Me.XtraScrollableControl)
        Me.Name = "UserForm"
        Me.Text = "User"
        Me.XtraScrollableControl.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Karyawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isActiveCkbx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.role.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoleBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoleXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents UserBS As BindingSource
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents personName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents isActiveCkbx As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents role As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RoleBS As BindingSource
    Friend WithEvents RoleXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents validator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Karyawan As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KaryawanXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaKaryawan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KaryawanBS As BindingSource
    Friend WithEvents ResetPassBtn As DevExpress.XtraEditors.SimpleButton
End Class
