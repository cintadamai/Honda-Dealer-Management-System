<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputPembelianForm
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
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputPembelianForm))
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.DetailGrid = New DevExpress.XtraGrid.GridControl()
        Me.PembelianDetailBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianDetailXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNilai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPotongan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelDetail = New DevExpress.XtraEditors.PanelControl()
        Me.HapusDetailBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.BatalDetailBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanDetailBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.TambahDetailBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.ModelTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ModelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransmisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NilaiPembelianDetTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.PotonganDetailTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.TotalDetailTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TanggalPembelianTxt = New DevExpress.XtraEditors.DateEdit()
        Me.PembelianBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.KeteranganTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.PPNCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.NoFakturTxt = New DevExpress.XtraEditors.TextEdit()
        Me.NoInvoiceTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.IDTxt = New DevExpress.XtraEditors.ButtonEdit()
        Me.SupplierTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNpwp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaNpwp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NilaiTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.PotonganTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.DppTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.PPNtxt = New DevExpress.XtraEditors.SpinEdit()
        Me.TotalTxt = New DevExpress.XtraEditors.SpinEdit()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HeaderValidator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.DetailGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetailBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetailXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiPembelianDetTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganDetailTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalDetailTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TanggalPembelianTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPembelianTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPNCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFakturTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoInvoiceTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DppTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPNtxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.BindingNavigator1)
        Me.XtraScrollableControl1.Controls.Add(Me.DetailGrid)
        Me.XtraScrollableControl1.Controls.Add(Me.PanelDetail)
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl1)
        Me.XtraScrollableControl1.Controls.Add(Me.SimpanBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.PrintBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.BatalBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.EditBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.TambahBtn)
        Me.XtraScrollableControl1.Controls.Add(Me.HapusBtn)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1008, 532)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'DetailGrid
        '
        Me.DetailGrid.DataSource = Me.PembelianDetailBS
        Me.DetailGrid.Location = New System.Drawing.Point(304, 241)
        Me.DetailGrid.MainView = Me.GridView2
        Me.DetailGrid.Name = "DetailGrid"
        Me.DetailGrid.Size = New System.Drawing.Size(649, 259)
        Me.DetailGrid.TabIndex = 52
        Me.DetailGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.DetailGrid.Visible = False
        '
        'PembelianDetailBS
        '
        Me.PembelianDetailBS.DataSource = Me.PembelianDetailXP
        '
        'PembelianDetailXP
        '
        Me.PembelianDetailXP.DeleteObjectOnRemove = True
        Me.PembelianDetailXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitPurchaseDetailModel)
        Me.PembelianDetailXP.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.colNilai, Me.colPotongan, Me.colTotal, Me.GridColumn1})
        Me.GridView2.GridControl = Me.DetailGrid
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsDetail.EnableMasterViewMode = False
        Me.GridView2.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Model"
        Me.GridColumn3.FieldName = "Model.Model"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 221
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tipe"
        Me.GridColumn4.FieldName = "Model.Tipe"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 108
        '
        'colNilai
        '
        Me.colNilai.DisplayFormat.FormatString = "N00"
        Me.colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNilai.FieldName = "Nilai"
        Me.colNilai.Name = "colNilai"
        Me.colNilai.Visible = True
        Me.colNilai.VisibleIndex = 3
        Me.colNilai.Width = 101
        '
        'colPotongan
        '
        Me.colPotongan.DisplayFormat.FormatString = "N00"
        Me.colPotongan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPotongan.FieldName = "Potongan"
        Me.colPotongan.Name = "colPotongan"
        Me.colPotongan.Visible = True
        Me.colPotongan.VisibleIndex = 4
        Me.colPotongan.Width = 123
        '
        'colTotal
        '
        Me.colTotal.DisplayFormat.FormatString = "N00"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        Me.colTotal.Width = 122
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Transmisi"
        Me.GridColumn1.FieldName = "Model.Transmisi"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'PanelDetail
        '
        Me.PanelDetail.Controls.Add(Me.HapusDetailBtn)
        Me.PanelDetail.Controls.Add(Me.BatalDetailBtn)
        Me.PanelDetail.Controls.Add(Me.SimpanDetailBtn)
        Me.PanelDetail.Controls.Add(Me.TextEdit2)
        Me.PanelDetail.Controls.Add(Me.LabelControl17)
        Me.PanelDetail.Controls.Add(Me.TextEdit1)
        Me.PanelDetail.Controls.Add(Me.LabelControl16)
        Me.PanelDetail.Controls.Add(Me.TambahDetailBtn)
        Me.PanelDetail.Controls.Add(Me.LabelControl19)
        Me.PanelDetail.Controls.Add(Me.LabelControl15)
        Me.PanelDetail.Controls.Add(Me.LabelControl13)
        Me.PanelDetail.Controls.Add(Me.LabelControl7)
        Me.PanelDetail.Controls.Add(Me.ModelTxt)
        Me.PanelDetail.Controls.Add(Me.NilaiPembelianDetTxt)
        Me.PanelDetail.Controls.Add(Me.PotonganDetailTxt)
        Me.PanelDetail.Controls.Add(Me.TotalDetailTxt)
        Me.PanelDetail.Location = New System.Drawing.Point(12, 241)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(286, 259)
        Me.PanelDetail.TabIndex = 51
        Me.PanelDetail.Visible = False
        '
        'HapusDetailBtn
        '
        Me.HapusDetailBtn.ImageOptions.Image = CType(resources.GetObject("HapusDetailBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.HapusDetailBtn.Location = New System.Drawing.Point(241, 213)
        Me.HapusDetailBtn.Name = "HapusDetailBtn"
        Me.HapusDetailBtn.Size = New System.Drawing.Size(40, 38)
        Me.HapusDetailBtn.TabIndex = 53
        '
        'BatalDetailBtn
        '
        Me.BatalDetailBtn.ImageOptions.Image = CType(resources.GetObject("BatalDetailBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.BatalDetailBtn.Location = New System.Drawing.Point(195, 213)
        Me.BatalDetailBtn.Name = "BatalDetailBtn"
        Me.BatalDetailBtn.Size = New System.Drawing.Size(40, 38)
        Me.BatalDetailBtn.TabIndex = 52
        '
        'SimpanDetailBtn
        '
        Me.SimpanDetailBtn.ImageOptions.Image = CType(resources.GetObject("SimpanDetailBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpanDetailBtn.Location = New System.Drawing.Point(149, 213)
        Me.SimpanDetailBtn.Name = "SimpanDetailBtn"
        Me.SimpanDetailBtn.Size = New System.Drawing.Size(40, 38)
        Me.SimpanDetailBtn.TabIndex = 51
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(118, 70)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(126, 20)
        Me.TextEdit2.TabIndex = 50
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(11, 73)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl17.TabIndex = 49
        Me.LabelControl17.Text = "Transmisi"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(118, 44)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(126, 20)
        Me.TextEdit1.TabIndex = 48
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(11, 47)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl16.TabIndex = 47
        Me.LabelControl16.Text = "Tipe"
        '
        'TambahDetailBtn
        '
        Me.TambahDetailBtn.ImageOptions.Image = CType(resources.GetObject("TambahDetailBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.TambahDetailBtn.Location = New System.Drawing.Point(103, 213)
        Me.TambahDetailBtn.Name = "TambahDetailBtn"
        Me.TambahDetailBtn.Size = New System.Drawing.Size(40, 38)
        Me.TambahDetailBtn.TabIndex = 45
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(11, 99)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl19.TabIndex = 27
        Me.LabelControl19.Text = "Nilai"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(11, 151)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Total"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(11, 125)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl13.TabIndex = 17
        Me.LabelControl13.Text = "Potongan"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(11, 21)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "Model"
        '
        'ModelTxt
        '
        Me.ModelTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianDetailBS, "Model!Key", True))
        Me.ModelTxt.Location = New System.Drawing.Point(118, 18)
        Me.ModelTxt.Name = "ModelTxt"
        Me.ModelTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModelTxt.Properties.DataSource = Me.ModelBS
        Me.ModelTxt.Properties.DisplayMember = "Model"
        Me.ModelTxt.Properties.NullText = ""
        Me.ModelTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.ModelTxt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ModelTxt.Properties.ValueMember = "Id"
        Me.ModelTxt.Properties.View = Me.GridView1
        Me.ModelTxt.Size = New System.Drawing.Size(126, 20)
        Me.ModelTxt.TabIndex = 15
        '
        'ModelBS
        '
        Me.ModelBS.DataSource = Me.ModelXP
        '
        'ModelXP
        '
        Me.ModelXP.DeleteObjectOnRemove = True
        Me.ModelXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitModelModel)
        Me.ModelXP.Session = Me.UOW
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colModel, Me.colTipe, Me.colTransmisi})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colModel, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        Me.colId1.Width = 116
        '
        'colModel
        '
        Me.colModel.FieldName = "Model"
        Me.colModel.Name = "colModel"
        Me.colModel.Visible = True
        Me.colModel.VisibleIndex = 1
        Me.colModel.Width = 317
        '
        'colTipe
        '
        Me.colTipe.FieldName = "Tipe"
        Me.colTipe.Name = "colTipe"
        Me.colTipe.Visible = True
        Me.colTipe.VisibleIndex = 2
        Me.colTipe.Width = 317
        '
        'colTransmisi
        '
        Me.colTransmisi.FieldName = "Transmisi"
        Me.colTransmisi.Name = "colTransmisi"
        Me.colTransmisi.Visible = True
        Me.colTransmisi.VisibleIndex = 3
        Me.colTransmisi.Width = 318
        '
        'NilaiPembelianDetTxt
        '
        Me.NilaiPembelianDetTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianDetailBS, "Nilai", True))
        Me.NilaiPembelianDetTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NilaiPembelianDetTxt.Location = New System.Drawing.Point(118, 96)
        Me.NilaiPembelianDetTxt.Name = "NilaiPembelianDetTxt"
        Me.NilaiPembelianDetTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NilaiPembelianDetTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.NilaiPembelianDetTxt.Properties.IsFloatValue = False
        Me.NilaiPembelianDetTxt.Properties.Mask.EditMask = "N00"
        Me.NilaiPembelianDetTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.NilaiPembelianDetTxt.Size = New System.Drawing.Size(126, 20)
        Me.NilaiPembelianDetTxt.TabIndex = 29
        '
        'PotonganDetailTxt
        '
        Me.PotonganDetailTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianDetailBS, "Potongan", True))
        Me.PotonganDetailTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PotonganDetailTxt.Location = New System.Drawing.Point(118, 122)
        Me.PotonganDetailTxt.Name = "PotonganDetailTxt"
        Me.PotonganDetailTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PotonganDetailTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.PotonganDetailTxt.Properties.IsFloatValue = False
        Me.PotonganDetailTxt.Properties.Mask.EditMask = "N00"
        Me.PotonganDetailTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PotonganDetailTxt.Size = New System.Drawing.Size(126, 20)
        Me.PotonganDetailTxt.TabIndex = 20
        '
        'TotalDetailTxt
        '
        Me.TotalDetailTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianDetailBS, "Total", True))
        Me.TotalDetailTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalDetailTxt.Location = New System.Drawing.Point(118, 148)
        Me.TotalDetailTxt.Name = "TotalDetailTxt"
        Me.TotalDetailTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TotalDetailTxt.Properties.Appearance.Options.UseFont = True
        Me.TotalDetailTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalDetailTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TotalDetailTxt.Properties.IsFloatValue = False
        Me.TotalDetailTxt.Properties.Mask.EditMask = "N00"
        Me.TotalDetailTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TotalDetailTxt.Properties.ReadOnly = True
        Me.TotalDetailTxt.Size = New System.Drawing.Size(126, 26)
        Me.TotalDetailTxt.TabIndex = 22
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TanggalPembelianTxt)
        Me.PanelControl1.Controls.Add(Me.KeteranganTxt)
        Me.PanelControl1.Controls.Add(Me.PPNCheckEdit)
        Me.PanelControl1.Controls.Add(Me.NoFakturTxt)
        Me.PanelControl1.Controls.Add(Me.NoInvoiceTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.IDTxt)
        Me.PanelControl1.Controls.Add(Me.SupplierTxt)
        Me.PanelControl1.Controls.Add(Me.NilaiTxt)
        Me.PanelControl1.Controls.Add(Me.PotonganTxt)
        Me.PanelControl1.Controls.Add(Me.DppTxt)
        Me.PanelControl1.Controls.Add(Me.PPNtxt)
        Me.PanelControl1.Controls.Add(Me.TotalTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 66)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(941, 169)
        Me.PanelControl1.TabIndex = 49
        '
        'TanggalPembelianTxt
        '
        Me.TanggalPembelianTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "TanggalPembelian", True))
        Me.TanggalPembelianTxt.EditValue = Nothing
        Me.TanggalPembelianTxt.Location = New System.Drawing.Point(129, 67)
        Me.TanggalPembelianTxt.Name = "TanggalPembelianTxt"
        Me.TanggalPembelianTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.TanggalPembelianTxt.Properties.Appearance.Options.UseBackColor = True
        Me.TanggalPembelianTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPembelianTxt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPembelianTxt.Properties.DisplayFormat.FormatString = ""
        Me.TanggalPembelianTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalPembelianTxt.Properties.EditFormat.FormatString = ""
        Me.TanggalPembelianTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalPembelianTxt.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.TanggalPembelianTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TanggalPembelianTxt.Size = New System.Drawing.Size(142, 20)
        Me.TanggalPembelianTxt.TabIndex = 53
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Harus di isi."
        Me.HeaderValidator.SetValidationRule(Me.TanggalPembelianTxt, ConditionValidationRule4)
        '
        'PembelianBS
        '
        Me.PembelianBS.DataSource = Me.PembelianXP
        '
        'PembelianXP
        '
        Me.PembelianXP.DeleteObjectOnRemove = True
        Me.PembelianXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitPurchaseModel)
        Me.PembelianXP.Session = Me.UOW
        '
        'KeteranganTxt
        '
        Me.KeteranganTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Keterangan", True))
        Me.KeteranganTxt.Location = New System.Drawing.Point(635, 47)
        Me.KeteranganTxt.Name = "KeteranganTxt"
        Me.KeteranganTxt.Size = New System.Drawing.Size(202, 110)
        Me.KeteranganTxt.TabIndex = 52
        '
        'PPNCheckEdit
        '
        Me.PPNCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Isppn", True))
        Me.PPNCheckEdit.EditValue = True
        Me.PPNCheckEdit.Location = New System.Drawing.Point(379, 94)
        Me.PPNCheckEdit.Name = "PPNCheckEdit"
        Me.PPNCheckEdit.Properties.Caption = "PPN"
        Me.PPNCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.PPNCheckEdit.TabIndex = 17
        '
        'NoFakturTxt
        '
        Me.NoFakturTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembelianBS, "NoFaktur", True))
        Me.NoFakturTxt.Location = New System.Drawing.Point(129, 119)
        Me.NoFakturTxt.Name = "NoFakturTxt"
        Me.NoFakturTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NoFakturTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NoFakturTxt.Size = New System.Drawing.Size(142, 20)
        Me.NoFakturTxt.TabIndex = 16
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Harus di isi."
        Me.HeaderValidator.SetValidationRule(Me.NoFakturTxt, ConditionValidationRule5)
        '
        'NoInvoiceTxt
        '
        Me.NoInvoiceTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembelianBS, "NoInvoice", True))
        Me.NoInvoiceTxt.Location = New System.Drawing.Point(129, 93)
        Me.NoInvoiceTxt.Name = "NoInvoiceTxt"
        Me.NoInvoiceTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NoInvoiceTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NoInvoiceTxt.Size = New System.Drawing.Size(142, 20)
        Me.NoInvoiceTxt.TabIndex = 15
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Harus di isi."
        Me.HeaderValidator.SetValidationRule(Me.NoInvoiceTxt, ConditionValidationRule1)
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(544, 18)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl12.TabIndex = 11
        Me.LabelControl12.Text = "Total"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(302, 122)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "PPN"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(302, 71)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Dpp"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(302, 45)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Potongan"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(302, 19)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Nilai"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(544, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Keterangan"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(21, 122)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "No Faktur"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "No Invoice"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Tanggal Pembelian"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Supplier"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "No Pembelian"
        '
        'IDTxt
        '
        Me.IDTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembelianBS, "Id", True))
        Me.IDTxt.Location = New System.Drawing.Point(129, 15)
        Me.IDTxt.Name = "IDTxt"
        Me.IDTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IDTxt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.IDTxt.Size = New System.Drawing.Size(142, 20)
        Me.IDTxt.TabIndex = 12
        '
        'SupplierTxt
        '
        Me.SupplierTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Supplier!Key", True))
        Me.SupplierTxt.Location = New System.Drawing.Point(129, 41)
        Me.SupplierTxt.Name = "SupplierTxt"
        Me.SupplierTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.SupplierTxt.Properties.Appearance.Options.UseBackColor = True
        Me.SupplierTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierTxt.Properties.DataSource = Me.SupplierXP
        Me.SupplierTxt.Properties.DisplayMember = "NamaSupplier"
        Me.SupplierTxt.Properties.NullText = ""
        Me.SupplierTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.SupplierTxt.Properties.ValueMember = "Id"
        Me.SupplierTxt.Properties.View = Me.GridLookUpEdit1View
        Me.SupplierTxt.Size = New System.Drawing.Size(142, 20)
        Me.SupplierTxt.TabIndex = 13
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Pilih Salah Satu."
        Me.HeaderValidator.SetValidationRule(Me.SupplierTxt, ConditionValidationRule2)
        '
        'SupplierXP
        '
        Me.SupplierXP.DeleteObjectOnRemove = True
        Me.SupplierXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitSupplierModel)
        Me.SupplierXP.Session = Me.UOW
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNamaSupplier, Me.colNpwp, Me.colNamaNpwp})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNamaSupplier, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 77
        '
        'colNamaSupplier
        '
        Me.colNamaSupplier.FieldName = "NamaSupplier"
        Me.colNamaSupplier.Name = "colNamaSupplier"
        Me.colNamaSupplier.Visible = True
        Me.colNamaSupplier.VisibleIndex = 1
        Me.colNamaSupplier.Width = 164
        '
        'colNpwp
        '
        Me.colNpwp.FieldName = "Npwp"
        Me.colNpwp.Name = "colNpwp"
        Me.colNpwp.Visible = True
        Me.colNpwp.VisibleIndex = 2
        Me.colNpwp.Width = 164
        '
        'colNamaNpwp
        '
        Me.colNamaNpwp.FieldName = "NamaNpwp"
        Me.colNamaNpwp.Name = "colNamaNpwp"
        Me.colNamaNpwp.Visible = True
        Me.colNamaNpwp.VisibleIndex = 3
        Me.colNamaNpwp.Width = 171
        '
        'NilaiTxt
        '
        Me.NilaiTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Nilai", True))
        Me.NilaiTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NilaiTxt.Location = New System.Drawing.Point(379, 15)
        Me.NilaiTxt.Name = "NilaiTxt"
        Me.NilaiTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NilaiTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.NilaiTxt.Properties.IsFloatValue = False
        Me.NilaiTxt.Properties.Mask.EditMask = "N00"
        Me.NilaiTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.NilaiTxt.Properties.ReadOnly = True
        Me.NilaiTxt.Size = New System.Drawing.Size(142, 20)
        Me.NilaiTxt.TabIndex = 49
        '
        'PotonganTxt
        '
        Me.PotonganTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Potongan", True))
        Me.PotonganTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PotonganTxt.Location = New System.Drawing.Point(379, 41)
        Me.PotonganTxt.Name = "PotonganTxt"
        Me.PotonganTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PotonganTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.PotonganTxt.Properties.IsFloatValue = False
        Me.PotonganTxt.Properties.Mask.EditMask = "N00"
        Me.PotonganTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PotonganTxt.Size = New System.Drawing.Size(142, 20)
        Me.PotonganTxt.TabIndex = 50
        '
        'DppTxt
        '
        Me.DppTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Dpp", True))
        Me.DppTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DppTxt.Location = New System.Drawing.Point(379, 67)
        Me.DppTxt.Name = "DppTxt"
        Me.DppTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DppTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DppTxt.Properties.IsFloatValue = False
        Me.DppTxt.Properties.Mask.EditMask = "N00"
        Me.DppTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DppTxt.Properties.ReadOnly = True
        Me.DppTxt.Size = New System.Drawing.Size(142, 20)
        Me.DppTxt.TabIndex = 51
        '
        'PPNtxt
        '
        Me.PPNtxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Ppn", True))
        Me.PPNtxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PPNtxt.Location = New System.Drawing.Point(379, 119)
        Me.PPNtxt.Name = "PPNtxt"
        Me.PPNtxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PPNtxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.PPNtxt.Properties.IsFloatValue = False
        Me.PPNtxt.Properties.Mask.EditMask = "N00"
        Me.PPNtxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PPNtxt.Properties.ReadOnly = True
        Me.PPNtxt.Size = New System.Drawing.Size(142, 20)
        Me.PPNtxt.TabIndex = 18
        '
        'TotalTxt
        '
        Me.TotalTxt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianBS, "Total", True))
        Me.TotalTxt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalTxt.Location = New System.Drawing.Point(635, 15)
        Me.TotalTxt.Name = "TotalTxt"
        Me.TotalTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TotalTxt.Properties.Appearance.Options.UseFont = True
        Me.TotalTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalTxt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TotalTxt.Properties.IsFloatValue = False
        Me.TotalTxt.Properties.Mask.EditMask = "N00"
        Me.TotalTxt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TotalTxt.Properties.ReadOnly = True
        Me.TotalTxt.Size = New System.Drawing.Size(202, 26)
        Me.TotalTxt.TabIndex = 19
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 28)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 44
        Me.SimpanBtn.Text = "Simpan"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 28)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 45
        Me.PrintBtn.Text = "Print"
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 28)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 48
        Me.BatalBtn.Text = "Batal"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 28)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 46
        Me.EditBtn.Text = "Edit"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 28)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 43
        Me.TambahBtn.Text = "Tambah"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 28)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 47
        Me.HapusBtn.Text = "Hapus"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.PembelianBS
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1008, 25)
        Me.BindingNavigator1.TabIndex = 53
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InputPembelianForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 532)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "InputPembelianForm"
        Me.Text = "Pembelian"
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.DetailGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetailBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetailXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelDetail.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiPembelianDetTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganDetailTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalDetailTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TanggalPembelianTxt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPembelianTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPNCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFakturTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoInvoiceTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DppTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPNtxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderValidator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PPNCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents NoFakturTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NoInvoiceTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DetailGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KeteranganTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IDTxt As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SupplierTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ModelTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PembelianXP As DevExpress.Xpo.XPCollection
    Friend WithEvents PembelianBS As BindingSource
    Friend WithEvents PembelianDetailBS As BindingSource
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPotongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents SupplierXP As DevExpress.Xpo.XPCollection
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNpwp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaNpwp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModelXP As DevExpress.Xpo.XPCollection
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModelBS As BindingSource
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransmisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TanggalPembelianTxt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents NilaiTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PotonganTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DppTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PPNtxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TotalTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeaderValidator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PembelianDetailXP As DevExpress.Xpo.XPCollection
    Friend WithEvents NilaiPembelianDetTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PotonganDetailTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TotalDetailTxt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HapusDetailBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BatalDetailBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpanDetailBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahDetailBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
