<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PenerimaanKendaraanForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PenerimaanKendaraanForm))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule7 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule8 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PenerimaanBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenerimaanXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuratJalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalDiterima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoRangka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoMesin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoFaktur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoKunci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TransmisiTxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TipeTxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idTxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NomorSJTxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TanggalSJTxt = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RangkaTxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.KeteranganTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NoKunciTxt = New DevExpress.XtraEditors.TextEdit()
        Me.MesinTxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WarnaTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WarnaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarnaXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GudangTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GudangBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.GudangXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaGudang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ModelTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ModelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransmisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.validator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TransmisiTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipeTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorSJTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalSJTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalSJTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangkaTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoKunciTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesinTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnaTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnaBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnaXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GudangTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GudangBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GudangXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.GridControl2)
        Me.XtraScrollableControl1.Controls.Add(Me.SimpanBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.PrintBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.BatalBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.EditBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.TambahBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.HapusBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl1)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1014, 611)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.PenerimaanBS
        Me.GridControl2.Location = New System.Drawing.Point(397, 50)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(595, 484)
        Me.GridControl2.TabIndex = 55
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PenerimaanBS
        '
        Me.PenerimaanBS.DataSource = Me.PenerimaanXP
        '
        'PenerimaanXP
        '
        Me.PenerimaanXP.DeleteObjectOnRemove = True
        Me.PenerimaanXP.DisplayableProperties = resources.GetString("PenerimaanXP.DisplayableProperties")
        Me.PenerimaanXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitReceiveModel)
        Me.PenerimaanXP.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colSuratJalan, Me.colTanggalDiterima, Me.colTahun, Me.colNoRangka, Me.colNoMesin, Me.colNoFaktur, Me.GridColumn9, Me.GridColumn10, Me.colNoKunci, Me.colKeterangan, Me.GridColumn11, Me.GridColumn1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsDetail.EnableMasterViewMode = False
        Me.GridView2.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 73
        '
        'colSuratJalan
        '
        Me.colSuratJalan.FieldName = "SuratJalan"
        Me.colSuratJalan.Name = "colSuratJalan"
        Me.colSuratJalan.Visible = True
        Me.colSuratJalan.VisibleIndex = 1
        Me.colSuratJalan.Width = 114
        '
        'colTanggalDiterima
        '
        Me.colTanggalDiterima.FieldName = "TanggalDiterima"
        Me.colTanggalDiterima.Name = "colTanggalDiterima"
        Me.colTanggalDiterima.Visible = True
        Me.colTanggalDiterima.VisibleIndex = 2
        Me.colTanggalDiterima.Width = 139
        '
        'colTahun
        '
        Me.colTahun.FieldName = "Tahun"
        Me.colTahun.Name = "colTahun"
        Me.colTahun.Visible = True
        Me.colTahun.VisibleIndex = 3
        Me.colTahun.Width = 135
        '
        'colNoRangka
        '
        Me.colNoRangka.FieldName = "NoRangka"
        Me.colNoRangka.Name = "colNoRangka"
        Me.colNoRangka.Visible = True
        Me.colNoRangka.VisibleIndex = 4
        Me.colNoRangka.Width = 130
        '
        'colNoMesin
        '
        Me.colNoMesin.FieldName = "NoMesin"
        Me.colNoMesin.Name = "colNoMesin"
        Me.colNoMesin.Visible = True
        Me.colNoMesin.VisibleIndex = 5
        Me.colNoMesin.Width = 123
        '
        'colNoFaktur
        '
        Me.colNoFaktur.FieldName = "NoFaktur"
        Me.colNoFaktur.Name = "colNoFaktur"
        Me.colNoFaktur.Width = 150
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "Model.Tipe"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 81
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "Model.Transmisi"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 96
        '
        'colNoKunci
        '
        Me.colNoKunci.FieldName = "NoKunci"
        Me.colNoKunci.Name = "colNoKunci"
        Me.colNoKunci.Visible = True
        Me.colNoKunci.VisibleIndex = 9
        Me.colNoKunci.Width = 111
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Width = 76
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "Gudang.NamaGudang"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        Me.GridColumn11.Width = 128
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Model.Model"
        Me.GridColumn1.FieldName = "Model.Model"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 138
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 50
        Me.SimpanBtn.Text = "Simpan"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 51
        Me.PrintBtn.Text = "Print"
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 54
        Me.BatalBtn.Text = "Batal"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 52
        Me.EditBtn.Text = "Edit"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 49
        Me.TambahBtn.Text = "Tambah"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 53
        Me.HapusBtn.Text = "Hapus"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.TransmisiTxt)
        Me.PanelControl1.Controls.Add(Me.Label11)
        Me.PanelControl1.Controls.Add(Me.TipeTxt)
        Me.PanelControl1.Controls.Add(Me.Label10)
        Me.PanelControl1.Controls.Add(Me.idTxt)
        Me.PanelControl1.Controls.Add(Me.Label9)
        Me.PanelControl1.Controls.Add(Me.NomorSJTxt)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.TanggalSJTxt)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.RangkaTxt)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.KeteranganTxt)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.NoKunciTxt)
        Me.PanelControl1.Controls.Add(Me.MesinTxt)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.WarnaTxt)
        Me.PanelControl1.Controls.Add(Me.GudangTxt)
        Me.PanelControl1.Controls.Add(Me.ModelTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(379, 484)
        Me.PanelControl1.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Gudang"
        '
        'TransmisiTxt
        '
        Me.TransmisiTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "Model.Transmisi", True))
        Me.TransmisiTxt.Location = New System.Drawing.Point(84, 152)
        Me.TransmisiTxt.Name = "TransmisiTxt"
        Me.TransmisiTxt.Properties.ReadOnly = True
        Me.TransmisiTxt.Size = New System.Drawing.Size(145, 20)
        Me.TransmisiTxt.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Transmisi"
        '
        'TipeTxt
        '
        Me.TipeTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "Model.Tipe", True))
        Me.TipeTxt.Location = New System.Drawing.Point(84, 126)
        Me.TipeTxt.Name = "TipeTxt"
        Me.TipeTxt.Properties.ReadOnly = True
        Me.TipeTxt.Size = New System.Drawing.Size(145, 20)
        Me.TipeTxt.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tipe"
        '
        'idTxt
        '
        Me.idTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "Id", True))
        Me.idTxt.Location = New System.Drawing.Point(84, 22)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.idTxt.Properties.Appearance.Options.UseBackColor = True
        Me.idTxt.Size = New System.Drawing.Size(145, 20)
        Me.idTxt.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ID"
        '
        'NomorSJTxt
        '
        Me.NomorSJTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "SuratJalan", True))
        Me.NomorSJTxt.Location = New System.Drawing.Point(84, 48)
        Me.NomorSJTxt.Name = "NomorSJTxt"
        Me.NomorSJTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NomorSJTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NomorSJTxt.Size = New System.Drawing.Size(145, 20)
        Me.NomorSJTxt.TabIndex = 8
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.NomorSJTxt, ConditionValidationRule1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor SJ"
        '
        'TanggalSJTxt
        '
        Me.TanggalSJTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanBS, "TanggalDiterima", True))
        Me.TanggalSJTxt.EditValue = Nothing
        Me.TanggalSJTxt.Location = New System.Drawing.Point(84, 74)
        Me.TanggalSJTxt.Name = "TanggalSJTxt"
        Me.TanggalSJTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.TanggalSJTxt.Properties.Appearance.Options.UseBackColor = True
        Me.TanggalSJTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalSJTxt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalSJTxt.Properties.DisplayFormat.FormatString = ""
        Me.TanggalSJTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalSJTxt.Properties.EditFormat.FormatString = ""
        Me.TanggalSJTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalSJTxt.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.TanggalSJTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TanggalSJTxt.Size = New System.Drawing.Size(145, 20)
        Me.TanggalSJTxt.TabIndex = 9
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.TanggalSJTxt, ConditionValidationRule2)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model"
        '
        'RangkaTxt
        '
        Me.RangkaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "NoRangka", True))
        Me.RangkaTxt.Location = New System.Drawing.Point(84, 178)
        Me.RangkaTxt.Name = "RangkaTxt"
        Me.RangkaTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.RangkaTxt.Properties.Appearance.Options.UseBackColor = True
        Me.RangkaTxt.Size = New System.Drawing.Size(145, 20)
        Me.RangkaTxt.TabIndex = 11
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.RangkaTxt, ConditionValidationRule3)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Keterangan"
        '
        'KeteranganTxt
        '
        Me.KeteranganTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "Keterangan", True))
        Me.KeteranganTxt.Location = New System.Drawing.Point(84, 308)
        Me.KeteranganTxt.Name = "KeteranganTxt"
        Me.KeteranganTxt.Size = New System.Drawing.Size(276, 135)
        Me.KeteranganTxt.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Rangka"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Warna"
        '
        'NoKunciTxt
        '
        Me.NoKunciTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "NoKunci", True))
        Me.NoKunciTxt.Location = New System.Drawing.Point(84, 230)
        Me.NoKunciTxt.Name = "NoKunciTxt"
        Me.NoKunciTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NoKunciTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NoKunciTxt.Size = New System.Drawing.Size(145, 20)
        Me.NoKunciTxt.TabIndex = 13
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.NoKunciTxt, ConditionValidationRule4)
        '
        'MesinTxt
        '
        Me.MesinTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenerimaanBS, "NoMesin", True))
        Me.MesinTxt.Location = New System.Drawing.Point(84, 204)
        Me.MesinTxt.Name = "MesinTxt"
        Me.MesinTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.MesinTxt.Properties.Appearance.Options.UseBackColor = True
        Me.MesinTxt.Size = New System.Drawing.Size(145, 20)
        Me.MesinTxt.TabIndex = 12
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.MesinTxt, ConditionValidationRule5)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Mesin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No. Kunci"
        '
        'WarnaTxt
        '
        Me.WarnaTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanBS, "Warna!Key", True))
        Me.WarnaTxt.Location = New System.Drawing.Point(84, 256)
        Me.WarnaTxt.Name = "WarnaTxt"
        Me.WarnaTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.WarnaTxt.Properties.Appearance.Options.UseBackColor = True
        Me.WarnaTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WarnaTxt.Properties.DataSource = Me.WarnaBS
        Me.WarnaTxt.Properties.DisplayMember = "Warna"
        Me.WarnaTxt.Properties.NullText = ""
        Me.WarnaTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.WarnaTxt.Properties.ValueMember = "Id"
        Me.WarnaTxt.Properties.View = Me.GridLookUpEdit1View
        Me.WarnaTxt.Size = New System.Drawing.Size(145, 20)
        Me.WarnaTxt.TabIndex = 14
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.WarnaTxt, ConditionValidationRule6)
        '
        'WarnaBS
        '
        Me.WarnaBS.DataSource = Me.WarnaXP
        '
        'WarnaXP
        '
        Me.WarnaXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitWarnaModel)
        Me.WarnaXP.Session = Me.UOW
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colWarna})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colId2
        '
        Me.colId2.FieldName = "Id"
        Me.colId2.Name = "colId2"
        Me.colId2.Visible = True
        Me.colId2.VisibleIndex = 0
        Me.colId2.Width = 224
        '
        'colWarna
        '
        Me.colWarna.FieldName = "Warna"
        Me.colWarna.Name = "colWarna"
        Me.colWarna.Visible = True
        Me.colWarna.VisibleIndex = 1
        Me.colWarna.Width = 844
        '
        'GudangTxt
        '
        Me.GudangTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanBS, "Gudang!Key", True))
        Me.GudangTxt.Location = New System.Drawing.Point(84, 282)
        Me.GudangTxt.Name = "GudangTxt"
        Me.GudangTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.GudangTxt.Properties.Appearance.Options.UseBackColor = True
        Me.GudangTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GudangTxt.Properties.DataSource = Me.GudangBS
        Me.GudangTxt.Properties.DisplayMember = "NamaGudang"
        Me.GudangTxt.Properties.NullText = ""
        Me.GudangTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.GudangTxt.Properties.ValueMember = "Id"
        Me.GudangTxt.Properties.View = Me.GridView1
        Me.GudangTxt.Size = New System.Drawing.Size(145, 20)
        Me.GudangTxt.TabIndex = 23
        ConditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule7.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.GudangTxt, ConditionValidationRule7)
        '
        'GudangBS
        '
        Me.GudangBS.DataSource = Me.GudangXP
        '
        'GudangXP
        '
        Me.GudangXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitGudangModel)
        Me.GudangXP.Session = Me.UOW
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId3, Me.colNamaGudang, Me.colAlamat})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colId3
        '
        Me.colId3.FieldName = "Id"
        Me.colId3.Name = "colId3"
        Me.colId3.Visible = True
        Me.colId3.VisibleIndex = 0
        Me.colId3.Width = 151
        '
        'colNamaGudang
        '
        Me.colNamaGudang.FieldName = "NamaGudang"
        Me.colNamaGudang.Name = "colNamaGudang"
        Me.colNamaGudang.Visible = True
        Me.colNamaGudang.VisibleIndex = 1
        Me.colNamaGudang.Width = 390
        '
        'colAlamat
        '
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 2
        Me.colAlamat.Width = 527
        '
        'ModelTxt
        '
        Me.ModelTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanBS, "Model!Key", True))
        Me.ModelTxt.Location = New System.Drawing.Point(84, 100)
        Me.ModelTxt.Name = "ModelTxt"
        Me.ModelTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.ModelTxt.Properties.Appearance.Options.UseBackColor = True
        Me.ModelTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModelTxt.Properties.DataSource = Me.ModelBS
        Me.ModelTxt.Properties.DisplayMember = "Model"
        Me.ModelTxt.Properties.NullText = ""
        Me.ModelTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.ModelTxt.Properties.ValueMember = "Id"
        Me.ModelTxt.Properties.View = Me.GridView3
        Me.ModelTxt.Size = New System.Drawing.Size(145, 20)
        Me.ModelTxt.TabIndex = 10
        ConditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule8.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.ModelTxt, ConditionValidationRule8)
        '
        'ModelBS
        '
        Me.ModelBS.DataSource = Me.ModelXP
        '
        'ModelXP
        '
        Me.ModelXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitModelModel)
        Me.ModelXP.Session = Me.UOW
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colModel, Me.colTipe, Me.colTransmisi})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        Me.colId1.Width = 120
        '
        'colModel
        '
        Me.colModel.FieldName = "Model"
        Me.colModel.Name = "colModel"
        Me.colModel.Visible = True
        Me.colModel.VisibleIndex = 1
        Me.colModel.Width = 316
        '
        'colTipe
        '
        Me.colTipe.FieldName = "Tipe"
        Me.colTipe.Name = "colTipe"
        Me.colTipe.Visible = True
        Me.colTipe.VisibleIndex = 2
        Me.colTipe.Width = 316
        '
        'colTransmisi
        '
        Me.colTransmisi.FieldName = "Transmisi"
        Me.colTransmisi.Name = "colTransmisi"
        Me.colTransmisi.Visible = True
        Me.colTransmisi.VisibleIndex = 3
        Me.colTransmisi.Width = 316
        '
        'PenerimaanKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 611)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "PenerimaanKendaraan"
        Me.Text = "Penerimaan Kendaraan"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TransmisiTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipeTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorSJTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalSJTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalSJTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangkaTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoKunciTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesinTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnaTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnaBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnaXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GudangTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GudangBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GudangXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents NoKunciTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MesinTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RangkaTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NomorSJTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TanggalSJTxt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents KeteranganTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents TransmisiTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As Label
    Friend WithEvents TipeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents PenerimaanBS As BindingSource
    Friend WithEvents Label12 As Label
    Friend WithEvents PenerimaanXP As DevExpress.Xpo.XPCollection
    Friend WithEvents ModelXP As DevExpress.Xpo.XPCollection
    Friend WithEvents ModelBS As BindingSource
    Friend WithEvents WarnaTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GudangTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WarnaXP As DevExpress.Xpo.XPCollection
    Friend WithEvents WarnaBS As BindingSource
    Friend WithEvents GudangXP As DevExpress.Xpo.XPCollection
    Friend WithEvents GudangBS As BindingSource
    Friend WithEvents ModelTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents validator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuratJalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalDiterima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoRangka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoMesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoFaktur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoKunci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaGudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransmisi As DevExpress.XtraGrid.Columns.GridColumn
End Class
