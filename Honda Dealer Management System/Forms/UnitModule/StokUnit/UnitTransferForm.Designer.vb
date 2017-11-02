<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnitTransferForm
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
        Me.TransferBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransferXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GudangXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.StockXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.validator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalTransfer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.NoMesinTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.NoRangkaTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.TransmisiTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.VariantTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.NoBuktiTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.idTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.KeteranganTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.tanggalTransferTxt = New DevExpress.XtraEditors.DateEdit()
        Me.GudangAsalTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GudangTujuanTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ModelTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StockBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRangka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMesin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TransferBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GudangXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.NoMesinTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoRangkaTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransmisiTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariantTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoBuktiTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalTransferTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalTransferTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GudangAsalTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GudangTujuanTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransferBS
        '
        Me.TransferBS.DataSource = Me.TransferXP
        '
        'TransferXP
        '
        Me.TransferXP.DeleteObjectOnRemove = True
        Me.TransferXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitTransferModel)
        Me.TransferXP.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GudangXP
        '
        Me.GudangXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitGudangModel)
        Me.GudangXP.Session = Me.UOW
        '
        'StockXP
        '
        Me.StockXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitStockModel)
        Me.StockXP.Session = Me.UOW
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(966, 529)
        Me.XtraTabControl1.TabIndex = 61
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(912, 523)
        Me.XtraTabPage2.Text = "History"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TransferBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(912, 523)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTanggalTransfer, Me.GridColumn1, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.colKeterangan, Me.colNoBukti, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsDetail.EnableMasterViewMode = False
        Me.GridView3.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colTanggalTransfer
        '
        Me.colTanggalTransfer.FieldName = "TanggalTransfer"
        Me.colTanggalTransfer.Name = "colTanggalTransfer"
        Me.colTanggalTransfer.Visible = True
        Me.colTanggalTransfer.VisibleIndex = 2
        Me.colTanggalTransfer.Width = 130
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Gudang Asal"
        Me.GridColumn1.FieldName = "GudangAsal.NamaGudang"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 126
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Gudang Tujuan"
        Me.GridColumn3.FieldName = "GudangTujuan.NamaGudang"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 124
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Model"
        Me.GridColumn5.FieldName = "UnitStock.Model.Model"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 103
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Variant"
        Me.GridColumn6.FieldName = "UnitStock.Model.Tipe"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 92
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        '
        'colNoBukti
        '
        Me.colNoBukti.FieldName = "NoBukti"
        Me.colNoBukti.Name = "colNoBukti"
        Me.colNoBukti.Visible = True
        Me.colNoBukti.VisibleIndex = 1
        Me.colNoBukti.Width = 146
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Transmisi"
        Me.GridColumn7.FieldName = "UnitStock.Model.Transmisi"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "No Rangka"
        Me.GridColumn8.FieldName = "UnitStock.Rangka"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 120
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "No Mesin"
        Me.GridColumn9.FieldName = "UnitStock.Mesin"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 136
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage1.Controls.Add(Me.SimpanBtn)
        Me.XtraTabPage1.Controls.Add(Me.PrintBtn)
        Me.XtraTabPage1.Controls.Add(Me.BatalBtn)
        Me.XtraTabPage1.Controls.Add(Me.EditBtn)
        Me.XtraTabPage1.Controls.Add(Me.TambahBtn)
        Me.XtraTabPage1.Controls.Add(Me.HapusBtn)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(912, 523)
        Me.XtraTabPage1.Text = "Input"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.NoMesinTxt)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.NoRangkaTxt)
        Me.PanelControl2.Controls.Add(Me.LabelControl9)
        Me.PanelControl2.Controls.Add(Me.TransmisiTxt)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.VariantTxt)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.NoBuktiTxt)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.idTxt)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.KeteranganTxt)
        Me.PanelControl2.Controls.Add(Me.tanggalTransferTxt)
        Me.PanelControl2.Controls.Add(Me.GudangAsalTxt)
        Me.PanelControl2.Controls.Add(Me.GudangTujuanTxt)
        Me.PanelControl2.Controls.Add(Me.ModelTxt)
        Me.PanelControl2.Location = New System.Drawing.Point(30, 49)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(739, 414)
        Me.PanelControl2.TabIndex = 89
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(21, 273)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl11.TabIndex = 42
        Me.LabelControl11.Text = "Keterangan"
        '
        'NoMesinTxt
        '
        Me.NoMesinTxt.Location = New System.Drawing.Point(114, 246)
        Me.NoMesinTxt.Name = "NoMesinTxt"
        Me.NoMesinTxt.Properties.ReadOnly = True
        Me.NoMesinTxt.Size = New System.Drawing.Size(149, 20)
        Me.NoMesinTxt.TabIndex = 39
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(21, 247)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl10.TabIndex = 40
        Me.LabelControl10.Text = "No Mesin"
        '
        'NoRangkaTxt
        '
        Me.NoRangkaTxt.Location = New System.Drawing.Point(114, 220)
        Me.NoRangkaTxt.Name = "NoRangkaTxt"
        Me.NoRangkaTxt.Properties.ReadOnly = True
        Me.NoRangkaTxt.Size = New System.Drawing.Size(149, 20)
        Me.NoRangkaTxt.TabIndex = 37
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(21, 223)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl9.TabIndex = 38
        Me.LabelControl9.Text = "No Rangka"
        '
        'TransmisiTxt
        '
        Me.TransmisiTxt.Location = New System.Drawing.Point(114, 194)
        Me.TransmisiTxt.Name = "TransmisiTxt"
        Me.TransmisiTxt.Properties.ReadOnly = True
        Me.TransmisiTxt.Size = New System.Drawing.Size(53, 20)
        Me.TransmisiTxt.TabIndex = 35
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(21, 197)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl8.TabIndex = 36
        Me.LabelControl8.Text = "Transmisi"
        '
        'VariantTxt
        '
        Me.VariantTxt.Location = New System.Drawing.Point(114, 168)
        Me.VariantTxt.Name = "VariantTxt"
        Me.VariantTxt.Properties.ReadOnly = True
        Me.VariantTxt.Size = New System.Drawing.Size(124, 20)
        Me.VariantTxt.TabIndex = 33
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(21, 171)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl7.TabIndex = 34
        Me.LabelControl7.Text = "Variant"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(21, 145)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "Model"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(21, 93)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 30
        Me.LabelControl5.Text = "Gudang Asal"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 119)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl4.TabIndex = 28
        Me.LabelControl4.Text = "Gudang Tujuan"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Tanggal Transfer"
        '
        'NoBuktiTxt
        '
        Me.NoBuktiTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransferBS, "NoBukti", True))
        Me.NoBuktiTxt.Location = New System.Drawing.Point(114, 38)
        Me.NoBuktiTxt.Name = "NoBuktiTxt"
        Me.NoBuktiTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NoBuktiTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NoBuktiTxt.Size = New System.Drawing.Size(149, 20)
        Me.NoBuktiTxt.TabIndex = 23
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "No Bukti"
        '
        'idTxt
        '
        Me.idTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransferBS, "Id", True))
        Me.idTxt.Location = New System.Drawing.Point(114, 12)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.idTxt.Properties.Appearance.Options.UseBackColor = True
        Me.idTxt.Size = New System.Drawing.Size(138, 20)
        Me.idTxt.TabIndex = 22
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "ID"
        '
        'KeteranganTxt
        '
        Me.KeteranganTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransferBS, "Keterangan", True))
        Me.KeteranganTxt.Location = New System.Drawing.Point(114, 272)
        Me.KeteranganTxt.Name = "KeteranganTxt"
        Me.KeteranganTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.KeteranganTxt.Properties.Appearance.Options.UseBackColor = True
        Me.KeteranganTxt.Size = New System.Drawing.Size(191, 102)
        Me.KeteranganTxt.TabIndex = 41
        '
        'tanggalTransferTxt
        '
        Me.tanggalTransferTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TransferBS, "TanggalTransfer", True))
        Me.tanggalTransferTxt.EditValue = Nothing
        Me.tanggalTransferTxt.Location = New System.Drawing.Point(114, 64)
        Me.tanggalTransferTxt.Name = "tanggalTransferTxt"
        Me.tanggalTransferTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.tanggalTransferTxt.Properties.Appearance.Options.UseBackColor = True
        Me.tanggalTransferTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalTransferTxt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalTransferTxt.Properties.DisplayFormat.FormatString = ""
        Me.tanggalTransferTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tanggalTransferTxt.Properties.EditFormat.FormatString = ""
        Me.tanggalTransferTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tanggalTransferTxt.Properties.Mask.EditMask = ""
        Me.tanggalTransferTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.tanggalTransferTxt.Size = New System.Drawing.Size(149, 20)
        Me.tanggalTransferTxt.TabIndex = 25
        '
        'GudangAsalTxt
        '
        Me.GudangAsalTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TransferBS, "GudangAsal!Key", True))
        Me.GudangAsalTxt.Location = New System.Drawing.Point(114, 90)
        Me.GudangAsalTxt.Name = "GudangAsalTxt"
        Me.GudangAsalTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GudangAsalTxt.Properties.DataSource = Me.GudangXP
        Me.GudangAsalTxt.Properties.DisplayMember = "NamaGudang"
        Me.GudangAsalTxt.Properties.NullText = ""
        Me.GudangAsalTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.GudangAsalTxt.Properties.ReadOnly = True
        Me.GudangAsalTxt.Properties.ValueMember = "Id"
        Me.GudangAsalTxt.Properties.View = Me.GridLookUpEdit1View
        Me.GudangAsalTxt.Size = New System.Drawing.Size(149, 20)
        Me.GudangAsalTxt.TabIndex = 29
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GudangTujuanTxt
        '
        Me.GudangTujuanTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TransferBS, "GudangTujuan!Key", True))
        Me.GudangTujuanTxt.Location = New System.Drawing.Point(114, 116)
        Me.GudangTujuanTxt.Name = "GudangTujuanTxt"
        Me.GudangTujuanTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.GudangTujuanTxt.Properties.Appearance.Options.UseBackColor = True
        Me.GudangTujuanTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GudangTujuanTxt.Properties.DataSource = Me.GudangXP
        Me.GudangTujuanTxt.Properties.DisplayMember = "NamaGudang"
        Me.GudangTujuanTxt.Properties.NullText = ""
        Me.GudangTujuanTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.GudangTujuanTxt.Properties.ValueMember = "Id"
        Me.GudangTujuanTxt.Properties.View = Me.GridView1
        Me.GudangTujuanTxt.Size = New System.Drawing.Size(149, 20)
        Me.GudangTujuanTxt.TabIndex = 27
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ModelTxt
        '
        Me.ModelTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TransferBS, "UnitStock!Key", True))
        Me.ModelTxt.Location = New System.Drawing.Point(114, 142)
        Me.ModelTxt.Name = "ModelTxt"
        Me.ModelTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.ModelTxt.Properties.Appearance.Options.UseBackColor = True
        Me.ModelTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModelTxt.Properties.DataSource = Me.StockBS
        Me.ModelTxt.Properties.DisplayMember = "Model.Model"
        Me.ModelTxt.Properties.NullText = ""
        Me.ModelTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.ModelTxt.Properties.ValueMember = "Id"
        Me.ModelTxt.Properties.View = Me.GridView2
        Me.ModelTxt.Size = New System.Drawing.Size(149, 20)
        Me.ModelTxt.TabIndex = 31
        '
        'StockBS
        '
        Me.StockBS.DataSource = Me.StockXP
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn11, Me.colRangka, Me.colMesin, Me.colTahun, Me.GridColumn12, Me.GridColumn13})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        Me.colId1.Width = 69
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Model"
        Me.GridColumn2.FieldName = "Model.Model"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 159
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Variant"
        Me.GridColumn4.FieldName = "Model.Tipe"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 61
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Warna"
        Me.GridColumn11.FieldName = "Warna.Warna"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 173
        '
        'colRangka
        '
        Me.colRangka.FieldName = "Rangka"
        Me.colRangka.Name = "colRangka"
        Me.colRangka.Visible = True
        Me.colRangka.VisibleIndex = 5
        Me.colRangka.Width = 127
        '
        'colMesin
        '
        Me.colMesin.FieldName = "Mesin"
        Me.colMesin.Name = "colMesin"
        Me.colMesin.Visible = True
        Me.colMesin.VisibleIndex = 6
        Me.colMesin.Width = 127
        '
        'colTahun
        '
        Me.colTahun.FieldName = "Tahun"
        Me.colTahun.Name = "colTahun"
        Me.colTahun.Visible = True
        Me.colTahun.VisibleIndex = 7
        Me.colTahun.Width = 127
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Lokasi"
        Me.GridColumn12.FieldName = "Gudang.NamaGudang"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 145
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Transmisi"
        Me.GridColumn13.FieldName = "Model.Transmisi"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 80
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(126, 11)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 84
        Me.SimpanBtn.Text = "Simpan"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(318, 11)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 85
        Me.PrintBtn.Text = "Print"
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(222, 11)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 88
        Me.BatalBtn.Text = "Batal"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(414, 11)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 86
        Me.EditBtn.Text = "Edit"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(30, 11)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 83
        Me.TambahBtn.Text = "Tambah"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(510, 11)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 87
        Me.HapusBtn.Text = "Hapus"
        '
        'UnitTransferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 529)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "UnitTransferForm"
        Me.Text = "Unit Transfer"
        CType(Me.TransferBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GudangXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.NoMesinTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoRangkaTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransmisiTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariantTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoBuktiTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalTransferTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalTransferTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GudangAsalTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GudangTujuanTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents TransferXP As DevExpress.Xpo.XPCollection
    Friend WithEvents TransferBS As BindingSource
    Friend WithEvents GudangXP As DevExpress.Xpo.XPCollection
    Friend WithEvents StockXP As DevExpress.Xpo.XPCollection
    Friend WithEvents validator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalTransfer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoMesinTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoRangkaTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransmisiTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VariantTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoBuktiTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents idTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents KeteranganTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tanggalTransferTxt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GudangAsalTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GudangTujuanTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ModelTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StockBS As BindingSource
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRangka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class
