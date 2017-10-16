<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BranchForm
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
        Me.BranchBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKotakabupaten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoTelepon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalAktif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNpwp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.NpwpTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.EmailTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.NoFaxTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NoTeleponTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.KotaKabupatenTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.NamaBarnchTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.IdTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.AlamatTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.IsActiveTxt = New DevExpress.XtraEditors.CheckEdit()
        Me.TanggalAktifTxt = New DevExpress.XtraEditors.DateEdit()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.NpwpTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFaxTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoTeleponTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KotaKabupatenTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaBarnchTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsActiveTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalAktifTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalAktifTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1154, 487)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(373, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(769, 425)
        Me.PanelControl2.TabIndex = 32
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BranchBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(765, 421)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BranchBS
        '
        Me.BranchBS.DataSource = Me.BranchXpCollection
        '
        'BranchXpCollection
        '
        Me.BranchXpCollection.DeleteObjectOnRemove = True
        Me.BranchXpCollection.DisplayableProperties = "Id;NamaBranch;Alamat;Kotakabupaten;NoTelepon;NoFax;Email;Isactive;TanggalAktif;Np" &
    "wp;Karyawans;UnitSpks"
        Me.BranchXpCollection.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.BranchModel)
        Me.BranchXpCollection.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNamaBranch, Me.colAlamat, Me.colKotakabupaten, Me.colNoTelepon, Me.colNoFax, Me.colEmail, Me.colIsactive, Me.colTanggalAktif, Me.colNpwp})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 74
        '
        'colNamaBranch
        '
        Me.colNamaBranch.FieldName = "NamaBranch"
        Me.colNamaBranch.Name = "colNamaBranch"
        Me.colNamaBranch.Visible = True
        Me.colNamaBranch.VisibleIndex = 1
        Me.colNamaBranch.Width = 211
        '
        'colAlamat
        '
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 2
        Me.colAlamat.Width = 324
        '
        'colKotakabupaten
        '
        Me.colKotakabupaten.FieldName = "Kotakabupaten"
        Me.colKotakabupaten.Name = "colKotakabupaten"
        Me.colKotakabupaten.Visible = True
        Me.colKotakabupaten.VisibleIndex = 3
        Me.colKotakabupaten.Width = 99
        '
        'colNoTelepon
        '
        Me.colNoTelepon.FieldName = "NoTelepon"
        Me.colNoTelepon.Name = "colNoTelepon"
        Me.colNoTelepon.Visible = True
        Me.colNoTelepon.VisibleIndex = 4
        Me.colNoTelepon.Width = 95
        '
        'colNoFax
        '
        Me.colNoFax.FieldName = "NoFax"
        Me.colNoFax.Name = "colNoFax"
        Me.colNoFax.Visible = True
        Me.colNoFax.VisibleIndex = 5
        Me.colNoFax.Width = 88
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 6
        Me.colEmail.Width = 95
        '
        'colIsactive
        '
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.Visible = True
        Me.colIsactive.VisibleIndex = 7
        Me.colIsactive.Width = 72
        '
        'colTanggalAktif
        '
        Me.colTanggalAktif.FieldName = "TanggalAktif"
        Me.colTanggalAktif.Name = "colTanggalAktif"
        Me.colTanggalAktif.Visible = True
        Me.colTanggalAktif.VisibleIndex = 8
        Me.colTanggalAktif.Width = 104
        '
        'colNpwp
        '
        Me.colNpwp.FieldName = "Npwp"
        Me.colNpwp.Name = "colNpwp"
        Me.colNpwp.Visible = True
        Me.colNpwp.VisibleIndex = 9
        Me.colNpwp.Width = 101
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.NpwpTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.EmailTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.NoFaxTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.NoTeleponTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.KotaKabupatenTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.NamaBarnchTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.IdTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.AlamatTxt)
        Me.PanelControl1.Controls.Add(Me.IsActiveTxt)
        Me.PanelControl1.Controls.Add(Me.TanggalAktifTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(355, 425)
        Me.PanelControl1.TabIndex = 31
        '
        'NpwpTxt
        '
        Me.NpwpTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "Npwp", True))
        Me.NpwpTxt.Location = New System.Drawing.Point(121, 283)
        Me.NpwpTxt.Name = "NpwpTxt"
        Me.NpwpTxt.Size = New System.Drawing.Size(204, 20)
        Me.NpwpTxt.TabIndex = 51
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(24, 286)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl10.TabIndex = 50
        Me.LabelControl10.Text = "NPWP"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(24, 260)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl9.TabIndex = 48
        Me.LabelControl9.Text = "Tanggal Aktif"
        '
        'EmailTxt
        '
        Me.EmailTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "Email", True))
        Me.EmailTxt.Location = New System.Drawing.Point(121, 205)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(204, 20)
        Me.EmailTxt.TabIndex = 45
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(24, 208)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 44
        Me.LabelControl7.Text = "Email"
        '
        'NoFaxTxt
        '
        Me.NoFaxTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "NoFax", True))
        Me.NoFaxTxt.Location = New System.Drawing.Point(121, 179)
        Me.NoFaxTxt.Name = "NoFaxTxt"
        Me.NoFaxTxt.Size = New System.Drawing.Size(204, 20)
        Me.NoFaxTxt.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 182)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl6.TabIndex = 42
        Me.LabelControl6.Text = "No Fax"
        '
        'NoTeleponTxt
        '
        Me.NoTeleponTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "NoTelepon", True))
        Me.NoTeleponTxt.Location = New System.Drawing.Point(121, 153)
        Me.NoTeleponTxt.Name = "NoTeleponTxt"
        Me.NoTeleponTxt.Size = New System.Drawing.Size(204, 20)
        Me.NoTeleponTxt.TabIndex = 41
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 156)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 40
        Me.LabelControl5.Text = "No Telepon"
        '
        'KotaKabupatenTxt
        '
        Me.KotaKabupatenTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "Kotakabupaten", True))
        Me.KotaKabupatenTxt.Location = New System.Drawing.Point(121, 127)
        Me.KotaKabupatenTxt.Name = "KotaKabupatenTxt"
        Me.KotaKabupatenTxt.Size = New System.Drawing.Size(204, 20)
        Me.KotaKabupatenTxt.TabIndex = 39
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 130)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Kota / Kabupaten"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 36
        Me.LabelControl3.Text = "Alamat"
        '
        'NamaBarnchTxt
        '
        Me.NamaBarnchTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "NamaBranch", True))
        Me.NamaBarnchTxt.Location = New System.Drawing.Point(121, 41)
        Me.NamaBarnchTxt.Name = "NamaBarnchTxt"
        Me.NamaBarnchTxt.Size = New System.Drawing.Size(204, 20)
        Me.NamaBarnchTxt.TabIndex = 35
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Nama Branch"
        '
        'IdTxt
        '
        Me.IdTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "Id", True))
        Me.IdTxt.Location = New System.Drawing.Point(121, 15)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.Size = New System.Drawing.Size(100, 20)
        Me.IdTxt.TabIndex = 33
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'AlamatTxt
        '
        Me.AlamatTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBS, "Alamat", True))
        Me.AlamatTxt.Location = New System.Drawing.Point(121, 67)
        Me.AlamatTxt.Name = "AlamatTxt"
        Me.AlamatTxt.Size = New System.Drawing.Size(204, 54)
        Me.AlamatTxt.TabIndex = 37
        '
        'IsActiveTxt
        '
        Me.IsActiveTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchBS, "Isactive", True))
        Me.IsActiveTxt.EditValue = Nothing
        Me.IsActiveTxt.Location = New System.Drawing.Point(121, 231)
        Me.IsActiveTxt.Name = "IsActiveTxt"
        Me.IsActiveTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsActiveTxt.Properties.Caption = "IsActive"
        Me.IsActiveTxt.Size = New System.Drawing.Size(204, 19)
        Me.IsActiveTxt.TabIndex = 47
        '
        'TanggalAktifTxt
        '
        Me.TanggalAktifTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchBS, "TanggalAktif", True))
        Me.TanggalAktifTxt.EditValue = Nothing
        Me.TanggalAktifTxt.Location = New System.Drawing.Point(121, 257)
        Me.TanggalAktifTxt.Name = "TanggalAktifTxt"
        Me.TanggalAktifTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalAktifTxt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalAktifTxt.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.TanggalAktifTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalAktifTxt.Properties.EditFormat.FormatString = "dd MMMM yyyy"
        Me.TanggalAktifTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalAktifTxt.Properties.Mask.EditMask = "dd MMMM yyyy"
        Me.TanggalAktifTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TanggalAktifTxt.Size = New System.Drawing.Size(204, 20)
        Me.TanggalAktifTxt.TabIndex = 49
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 30
        Me.BatalBtn.Text = "Batal"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 29
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 28
        Me.EditBtn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 27
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 26
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 25
        Me.TambahBtn.Text = "Tambah"
        '
        'BranchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 487)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "BranchForm"
        Me.Text = "Branch"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.NpwpTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFaxTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoTeleponTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KotaKabupatenTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaBarnchTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsActiveTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalAktifTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalAktifTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IdTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NamaBarnchTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoTeleponTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents KotaKabupatenTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NpwpTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmailTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoFaxTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AlamatTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BranchXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKotakabupaten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTelepon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalAktif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNpwp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BranchBS As BindingSource
    Friend WithEvents IsActiveTxt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TanggalAktifTxt As DevExpress.XtraEditors.DateEdit
End Class
