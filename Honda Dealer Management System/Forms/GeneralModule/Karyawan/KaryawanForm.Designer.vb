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
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoTelepon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoHandphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalMasuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalResign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeteranganResign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DivisiTxt = New DevExpress.XtraEditors.GridLookUpEdit()
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
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.isActiveCk = New DevExpress.XtraEditors.CheckEdit()
        Me.SPVTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.BranchXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.DivisiXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.JabatanXP = New DevExpress.Xpo.XPCollection(Me.components)
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
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isActiveCk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPVTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisiXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JabatanXP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNoKtp, Me.colNamaKaryawan, Me.colAlamat, Me.colNoTelepon, Me.colEmail, Me.colNoHandphone, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colIsactive, Me.GridColumn5, Me.GridColumn6, Me.colTanggalMasuk, Me.colTanggalResign, Me.colKeteranganResign, Me.colCreatedBy, Me.colCreatedAt, Me.colUpdatedBy, Me.colUpdatedAt, Me.GridColumn7, Me.GridColumn8})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
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
        '
        'colNamaKaryawan
        '
        Me.colNamaKaryawan.FieldName = "NamaKaryawan"
        Me.colNamaKaryawan.Name = "colNamaKaryawan"
        Me.colNamaKaryawan.Visible = True
        Me.colNamaKaryawan.VisibleIndex = 2
        '
        'colAlamat
        '
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 3
        '
        'colNoTelepon
        '
        Me.colNoTelepon.FieldName = "NoTelepon"
        Me.colNoTelepon.Name = "colNoTelepon"
        Me.colNoTelepon.Visible = True
        Me.colNoTelepon.VisibleIndex = 4
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 5
        '
        'colNoHandphone
        '
        Me.colNoHandphone.FieldName = "NoHandphone"
        Me.colNoHandphone.Name = "colNoHandphone"
        Me.colNoHandphone.Visible = True
        Me.colNoHandphone.VisibleIndex = 6
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Divisi!"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Divisi!Key"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 8
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Jabatan!"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 9
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "Jabatan!Key"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 10
        '
        'colIsactive
        '
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.Visible = True
        Me.colIsactive.VisibleIndex = 11
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "Spv!"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 12
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Spv!Key"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 13
        '
        'colTanggalMasuk
        '
        Me.colTanggalMasuk.FieldName = "TanggalMasuk"
        Me.colTanggalMasuk.Name = "colTanggalMasuk"
        Me.colTanggalMasuk.Visible = True
        Me.colTanggalMasuk.VisibleIndex = 14
        '
        'colTanggalResign
        '
        Me.colTanggalResign.FieldName = "TanggalResign"
        Me.colTanggalResign.Name = "colTanggalResign"
        Me.colTanggalResign.Visible = True
        Me.colTanggalResign.VisibleIndex = 15
        '
        'colKeteranganResign
        '
        Me.colKeteranganResign.FieldName = "KeteranganResign"
        Me.colKeteranganResign.Name = "colKeteranganResign"
        Me.colKeteranganResign.Visible = True
        Me.colKeteranganResign.VisibleIndex = 16
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        Me.colCreatedBy.Visible = True
        Me.colCreatedBy.VisibleIndex = 17
        '
        'colCreatedAt
        '
        Me.colCreatedAt.FieldName = "CreatedAt"
        Me.colCreatedAt.Name = "colCreatedAt"
        Me.colCreatedAt.Visible = True
        Me.colCreatedAt.VisibleIndex = 18
        '
        'colUpdatedBy
        '
        Me.colUpdatedBy.FieldName = "UpdatedBy"
        Me.colUpdatedBy.Name = "colUpdatedBy"
        Me.colUpdatedBy.Visible = True
        Me.colUpdatedBy.VisibleIndex = 19
        '
        'colUpdatedAt
        '
        Me.colUpdatedAt.FieldName = "UpdatedAt"
        Me.colUpdatedAt.Name = "colUpdatedAt"
        Me.colUpdatedAt.Visible = True
        Me.colUpdatedAt.VisibleIndex = 20
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "Branch!"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 21
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "Branch!Key"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 22
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
        Me.DivisiTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisiTxt.Properties.NullText = ""
        Me.DivisiTxt.Properties.View = Me.GridView1
        Me.DivisiTxt.Size = New System.Drawing.Size(166, 20)
        Me.DivisiTxt.TabIndex = 30
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
        Me.EmailTxt.Size = New System.Drawing.Size(166, 20)
        Me.EmailTxt.TabIndex = 11
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
        Me.NamaTxt.Size = New System.Drawing.Size(166, 20)
        Me.NamaTxt.TabIndex = 5
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
        Me.AlamatTxt.Size = New System.Drawing.Size(203, 47)
        Me.AlamatTxt.TabIndex = 7
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
        '
        'TanggalResignTxt
        '
        Me.TanggalResignTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBS, "KeteranganResign", True))
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
        Me.JabatanTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JabatanTxt.Properties.NullText = ""
        Me.JabatanTxt.Properties.View = Me.GridLookUpEdit2View
        Me.JabatanTxt.Size = New System.Drawing.Size(166, 20)
        Me.JabatanTxt.TabIndex = 17
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
        Me.SPVTxt.Properties.NullText = ""
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
        Me.BranchTxt.Properties.NullText = ""
        Me.BranchTxt.Properties.View = Me.GridView2
        Me.BranchTxt.Size = New System.Drawing.Size(166, 20)
        Me.BranchTxt.TabIndex = 29
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
        'BranchXP
        '
        Me.BranchXP.DeleteObjectOnRemove = True
        Me.BranchXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.BranchModel)
        Me.BranchXP.Session = Me.uow
        '
        'DivisiXP
        '
        Me.DivisiXP.DeleteObjectOnRemove = True
        Me.DivisiXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.DivisiModel)
        Me.DivisiXP.Session = Me.uow
        '
        'JabatanXP
        '
        Me.JabatanXP.DeleteObjectOnRemove = True
        Me.JabatanXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.JabatanModel)
        Me.JabatanXP.Session = Me.uow
        '
        'KaryawanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 554)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "KaryawanForm"
        Me.Text = "KaryawanForm"
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
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isActiveCk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPVTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisiXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JabatanXP, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTelepon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoHandphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalMasuk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalResign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeteranganResign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
