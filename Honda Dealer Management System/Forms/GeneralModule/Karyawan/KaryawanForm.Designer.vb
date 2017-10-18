<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KaryawanForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.KaryawanBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.karyawanXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.uow = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoKtp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoTelepon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoHandphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DivisiTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisiXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.HpTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.EmailTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NoTeleponTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.NamaTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.NoKtpTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.idTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.AlamatTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.KeteranganResignTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.TanggalMasukTxt = New DevExpress.XtraEditors.DateEdit()
        Me.TanggalResignTxt = New DevExpress.XtraEditors.DateEdit()
        Me.JabatanTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.JabatanXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.isActiveCk = New DevExpress.XtraEditors.CheckEdit()
        Me.SPVTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BranchXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.validator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.karyawanXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DivisiTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisiXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HpTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoTeleponTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoKtpTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganResignTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalMasukTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalMasukTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalResignTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalResignTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JabatanTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JabatanXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isActiveCk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPVTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl2)
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
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1132, 554)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(368, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(752, 492)
        Me.PanelControl2.TabIndex = 20
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.KaryawanBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(748, 488)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'KaryawanBS
        '
        Me.KaryawanBS.DataSource = Me.karyawanXP
        '
        'karyawanXP
        '
        Me.karyawanXP.DeleteObjectOnRemove = True
        Me.karyawanXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.KaryawanModel)
        Me.karyawanXP.Session = Me.uow
        '
        'uow
        '
        Me.uow.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.uow.TrackPropertiesModifications = False
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNoKtp, Me.colNamaKaryawan, Me.colNoTelepon, Me.colEmail, Me.colNoHandphone, Me.GridColumn1, Me.GridColumn3, Me.colIsactive, Me.GridColumn5, Me.GridColumn8})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsDetail.EnableMasterViewMode = False
        Me.GridView3.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colNoKtp
        '
        Me.colNoKtp.FieldName = "NoKtp"
        Me.colNoKtp.Name = "colNoKtp"
        Me.colNoKtp.Visible = True
        Me.colNoKtp.VisibleIndex = 1
        Me.colNoKtp.Width = 139
        '
        'colNamaKaryawan
        '
        Me.colNamaKaryawan.FieldName = "NamaKaryawan"
        Me.colNamaKaryawan.Name = "colNamaKaryawan"
        Me.colNamaKaryawan.Visible = True
        Me.colNamaKaryawan.VisibleIndex = 2
        Me.colNamaKaryawan.Width = 153
        '
        'colNoTelepon
        '
        Me.colNoTelepon.FieldName = "NoTelepon"
        Me.colNoTelepon.Name = "colNoTelepon"
        Me.colNoTelepon.Visible = True
        Me.colNoTelepon.VisibleIndex = 3
        Me.colNoTelepon.Width = 124
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 4
        Me.colEmail.Width = 122
        '
        'colNoHandphone
        '
        Me.colNoHandphone.FieldName = "NoHandphone"
        Me.colNoHandphone.Name = "colNoHandphone"
        Me.colNoHandphone.Visible = True
        Me.colNoHandphone.VisibleIndex = 5
        Me.colNoHandphone.Width = 143
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Divisi"
        Me.GridColumn1.FieldName = "Divisi.DivisiName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 152
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Jabatan"
        Me.GridColumn3.FieldName = "Jabatan.JabatanName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 7
        Me.GridColumn3.Width = 170
        '
        'colIsactive
        '
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.Visible = True
        Me.colIsactive.VisibleIndex = 8
        Me.colIsactive.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "SPV"
        Me.GridColumn5.FieldName = "Spv.NamaKaryawan"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 131
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Branch"
        Me.GridColumn8.FieldName = "Branch.NamaBranch"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 175
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.DivisiTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.HpTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.EmailTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.NoTeleponTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.NamaTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.NoKtpTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.idTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.AlamatTxt)
        Me.PanelControl1.Controls.Add(Me.KeteranganResignTxt)
        Me.PanelControl1.Controls.Add(Me.TanggalMasukTxt)
        Me.PanelControl1.Controls.Add(Me.TanggalResignTxt)
        Me.PanelControl1.Controls.Add(Me.JabatanTxt)
        Me.PanelControl1.Controls.Add(Me.isActiveCk)
        Me.PanelControl1.Controls.Add(Me.SPVTxt)
        Me.PanelControl1.Controls.Add(Me.BranchTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(350, 492)
        Me.PanelControl1.TabIndex = 19
        '
        'DivisiTxt
        '
        Me.DivisiTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "Divisi!Key", True))
        Me.DivisiTxt.Location = New System.Drawing.Point(132, 229)
        Me.DivisiTxt.Name = "DivisiTxt"
        Me.DivisiTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.DivisiTxt.Properties.Appearance.Options.UseBackColor = True
        Me.DivisiTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisiTxt.Properties.DataSource = Me.DivisiXP
        Me.DivisiTxt.Properties.DisplayMember = "DivisiName"
        Me.DivisiTxt.Properties.NullText = ""
        Me.DivisiTxt.Properties.ValueMember = "Id"
        Me.DivisiTxt.Properties.View = Me.GridView1
        Me.DivisiTxt.Size = New System.Drawing.Size(166, 20)
        Me.DivisiTxt.TabIndex = 30
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.DivisiTxt, ConditionValidationRule1)
        '
        'DivisiXP
        '
        Me.DivisiXP.DeleteObjectOnRemove = True
        Me.DivisiXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.DivisiModel)
        Me.DivisiXP.Session = Me.uow
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(24, 445)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl15.TabIndex = 28
        Me.LabelControl15.Text = "Branch"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(24, 388)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl14.TabIndex = 26
        Me.LabelControl14.Text = "Keterangan Resign"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(24, 362)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl13.TabIndex = 24
        Me.LabelControl13.Text = "Tanggal Resign"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(24, 336)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl12.TabIndex = 22
        Me.LabelControl12.Text = "Tanggal Masuk"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(24, 310)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "SPV"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(24, 258)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Jabatan"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(24, 232)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Divisi"
        '
        'HpTxt
        '
        Me.HpTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "NoHandphone", True))
        Me.HpTxt.Location = New System.Drawing.Point(132, 203)
        Me.HpTxt.Name = "HpTxt"
        Me.HpTxt.Size = New System.Drawing.Size(166, 20)
        Me.HpTxt.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(24, 206)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Handphone"
        '
        'EmailTxt
        '
        Me.EmailTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "Email", True))
        Me.EmailTxt.Location = New System.Drawing.Point(132, 177)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.EmailTxt.Properties.Appearance.Options.UseBackColor = True
        Me.EmailTxt.Size = New System.Drawing.Size(166, 20)
        Me.EmailTxt.TabIndex = 11
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.EmailTxt, ConditionValidationRule2)
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 180)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Email"
        '
        'NoTeleponTxt
        '
        Me.NoTeleponTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "Alamat", True))
        Me.NoTeleponTxt.Location = New System.Drawing.Point(132, 151)
        Me.NoTeleponTxt.Name = "NoTeleponTxt"
        Me.NoTeleponTxt.Size = New System.Drawing.Size(166, 20)
        Me.NoTeleponTxt.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 154)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "No Telepon"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Alamat"
        '
        'NamaTxt
        '
        Me.NamaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "NamaKaryawan", True))
        Me.NamaTxt.Location = New System.Drawing.Point(132, 72)
        Me.NamaTxt.Name = "NamaTxt"
        Me.NamaTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NamaTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NamaTxt.Size = New System.Drawing.Size(166, 20)
        Me.NamaTxt.TabIndex = 5
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.NamaTxt, ConditionValidationRule3)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Nama"
        '
        'NoKtpTxt
        '
        Me.NoKtpTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "NoKtp", True))
        Me.NoKtpTxt.Location = New System.Drawing.Point(132, 46)
        Me.NoKtpTxt.Name = "NoKtpTxt"
        Me.NoKtpTxt.Size = New System.Drawing.Size(166, 20)
        Me.NoKtpTxt.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "No KTP"
        '
        'idTxt
        '
        Me.idTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "Id", True))
        Me.idTxt.Location = New System.Drawing.Point(132, 20)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Properties.ReadOnly = True
        Me.idTxt.Size = New System.Drawing.Size(109, 20)
        Me.idTxt.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'AlamatTxt
        '
        Me.AlamatTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBS, "Alamat", True))
        Me.AlamatTxt.Location = New System.Drawing.Point(132, 98)
        Me.AlamatTxt.Name = "AlamatTxt"
        Me.AlamatTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.AlamatTxt.Properties.Appearance.Options.UseBackColor = True
        Me.AlamatTxt.Size = New System.Drawing.Size(203, 47)
        Me.AlamatTxt.TabIndex = 7
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.AlamatTxt, ConditionValidationRule4)
        '
        'KeteranganResignTxt
        '
        Me.KeteranganResignTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "KeteranganResign", True))
        Me.KeteranganResignTxt.Location = New System.Drawing.Point(132, 385)
        Me.KeteranganResignTxt.Name = "KeteranganResignTxt"
        Me.KeteranganResignTxt.Size = New System.Drawing.Size(203, 51)
        Me.KeteranganResignTxt.TabIndex = 27
        '
        'TanggalMasukTxt
        '
        Me.TanggalMasukTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "TanggalMasuk", True))
        Me.TanggalMasukTxt.EditValue = Nothing
        Me.TanggalMasukTxt.Location = New System.Drawing.Point(132, 333)
        Me.TanggalMasukTxt.Name = "TanggalMasukTxt"
        Me.TanggalMasukTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.TanggalMasukTxt.Properties.Appearance.Options.UseBackColor = True
        Me.TanggalMasukTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalMasukTxt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalMasukTxt.Properties.DisplayFormat.FormatString = ""
        Me.TanggalMasukTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalMasukTxt.Properties.EditFormat.FormatString = ""
        Me.TanggalMasukTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalMasukTxt.Properties.Mask.EditMask = ""
        Me.TanggalMasukTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TanggalMasukTxt.Size = New System.Drawing.Size(166, 20)
        Me.TanggalMasukTxt.TabIndex = 23
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.TanggalMasukTxt, ConditionValidationRule5)
        '
        'TanggalResignTxt
        '
        Me.TanggalResignTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "TanggalResign", True))
        Me.TanggalResignTxt.EditValue = Nothing
        Me.TanggalResignTxt.Location = New System.Drawing.Point(132, 359)
        Me.TanggalResignTxt.Name = "TanggalResignTxt"
        Me.TanggalResignTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalResignTxt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalResignTxt.Properties.DisplayFormat.FormatString = ""
        Me.TanggalResignTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalResignTxt.Properties.EditFormat.FormatString = ""
        Me.TanggalResignTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalResignTxt.Properties.Mask.EditMask = ""
        Me.TanggalResignTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TanggalResignTxt.Size = New System.Drawing.Size(166, 20)
        Me.TanggalResignTxt.TabIndex = 25
        '
        'JabatanTxt
        '
        Me.JabatanTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "Jabatan!Key", True))
        Me.JabatanTxt.Location = New System.Drawing.Point(132, 255)
        Me.JabatanTxt.Name = "JabatanTxt"
        Me.JabatanTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.JabatanTxt.Properties.Appearance.Options.UseBackColor = True
        Me.JabatanTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JabatanTxt.Properties.DataSource = Me.JabatanXP
        Me.JabatanTxt.Properties.DisplayMember = "JabatanName"
        Me.JabatanTxt.Properties.NullText = ""
        Me.JabatanTxt.Properties.ValueMember = "Id"
        Me.JabatanTxt.Properties.View = Me.GridLookUpEdit2View
        Me.JabatanTxt.Size = New System.Drawing.Size(166, 20)
        Me.JabatanTxt.TabIndex = 17
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.JabatanTxt, ConditionValidationRule6)
        '
        'JabatanXP
        '
        Me.JabatanXP.DeleteObjectOnRemove = True
        Me.JabatanXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.JabatanModel)
        Me.JabatanXP.Session = Me.uow
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'isActiveCk
        '
        Me.isActiveCk.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "Isactive", True))
        Me.isActiveCk.EditValue = Nothing
        Me.isActiveCk.Location = New System.Drawing.Point(132, 281)
        Me.isActiveCk.Name = "isActiveCk"
        Me.isActiveCk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.isActiveCk.Properties.Caption = "isActive"
        Me.isActiveCk.Size = New System.Drawing.Size(166, 19)
        Me.isActiveCk.TabIndex = 19
        '
        'SPVTxt
        '
        Me.SPVTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "Spv!Key", True))
        Me.SPVTxt.Location = New System.Drawing.Point(132, 307)
        Me.SPVTxt.Name = "SPVTxt"
        Me.SPVTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SPVTxt.Properties.DataSource = Me.karyawanXP
        Me.SPVTxt.Properties.DisplayMember = "Divisi.DivisiName"
        Me.SPVTxt.Properties.NullText = ""
        Me.SPVTxt.Properties.ValueMember = "Id"
        Me.SPVTxt.Properties.View = Me.GridLookUpEdit1View
        Me.SPVTxt.Size = New System.Drawing.Size(166, 20)
        Me.SPVTxt.TabIndex = 21
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'BranchTxt
        '
        Me.BranchTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "Branch!Key", True))
        Me.BranchTxt.Location = New System.Drawing.Point(132, 442)
        Me.BranchTxt.Name = "BranchTxt"
        Me.BranchTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchTxt.Properties.DataSource = Me.BranchXP
        Me.BranchTxt.Properties.DisplayMember = "Alamat"
        Me.BranchTxt.Properties.NullText = ""
        Me.BranchTxt.Properties.ValueMember = "Id"
        Me.BranchTxt.Properties.View = Me.GridView2
        Me.BranchTxt.Size = New System.Drawing.Size(166, 20)
        Me.BranchTxt.TabIndex = 29
        '
        'BranchXP
        '
        Me.BranchXP.DeleteObjectOnRemove = True
        Me.BranchXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.BranchModel)
        Me.BranchXP.Session = Me.uow
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
        'KaryawanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 554)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "KaryawanForm"
        Me.Text = "Karyawan"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.karyawanXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DivisiTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisiXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HpTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoTeleponTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoKtpTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganResignTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalMasukTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalMasukTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalResignTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalResignTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JabatanTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JabatanXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isActiveCk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPVTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents idTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HpTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmailTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoTeleponTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NamaTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoKtpTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AlamatTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents KeteranganResignTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TanggalMasukTxt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TanggalResignTxt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents JabatanTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DivisiTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isActiveCk As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SPVTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents uow As DevExpress.Xpo.UnitOfWork
    Friend WithEvents karyawanXP As DevExpress.Xpo.XPCollection
    Friend WithEvents KaryawanBS As BindingSource
    Friend WithEvents BranchXP As DevExpress.Xpo.XPCollection
    Friend WithEvents DivisiXP As DevExpress.Xpo.XPCollection
    Friend WithEvents JabatanXP As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoKtp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaKaryawan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTelepon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoHandphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
