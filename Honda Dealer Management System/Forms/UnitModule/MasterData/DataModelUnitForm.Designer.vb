<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataModelUnitForm
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
        Me.UnitModelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitModelXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransmisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.HapusAccBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahAccBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idAccTxt = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UAccXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaAccessory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TransmisiTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TipeTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ModelTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.idTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.UAccMoBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UAccMoXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitModelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitModelXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idAccTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UAccXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransmisiTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipeTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UAccMoBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UAccMoXP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(983, 491)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(416, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(555, 429)
        Me.PanelControl2.TabIndex = 44
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.UnitModelBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(551, 425)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'UnitModelBS
        '
        Me.UnitModelBS.DataSource = Me.UnitModelXP
        '
        'UnitModelXP
        '
        Me.UnitModelXP.DeleteObjectOnRemove = True
        Me.UnitModelXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitModelModel)
        Me.UnitModelXP.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colModel, Me.colTipe, Me.colTransmisi})
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
        Me.colId.Width = 141
        '
        'colModel
        '
        Me.colModel.FieldName = "Model"
        Me.colModel.Name = "colModel"
        Me.colModel.Visible = True
        Me.colModel.VisibleIndex = 1
        Me.colModel.Width = 309
        '
        'colTipe
        '
        Me.colTipe.FieldName = "Tipe"
        Me.colTipe.Name = "colTipe"
        Me.colTipe.Visible = True
        Me.colTipe.VisibleIndex = 2
        Me.colTipe.Width = 309
        '
        'colTransmisi
        '
        Me.colTransmisi.FieldName = "Transmisi"
        Me.colTransmisi.Name = "colTransmisi"
        Me.colTransmisi.Visible = True
        Me.colTransmisi.VisibleIndex = 3
        Me.colTransmisi.Width = 309
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.TransmisiTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.TipeTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.ModelTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.idTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(398, 429)
        Me.PanelControl1.TabIndex = 43
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.HapusAccBtn)
        Me.PanelControl3.Controls.Add(Me.TambahAccBtn)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Controls.Add(Me.idAccTxt)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 126)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(388, 298)
        Me.PanelControl3.TabIndex = 8
        '
        'HapusAccBtn
        '
        Me.HapusAccBtn.Location = New System.Drawing.Point(280, 9)
        Me.HapusAccBtn.Name = "HapusAccBtn"
        Me.HapusAccBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusAccBtn.TabIndex = 8
        Me.HapusAccBtn.Text = "Hapus"
        '
        'TambahAccBtn
        '
        Me.TambahAccBtn.Location = New System.Drawing.Point(199, 9)
        Me.TambahAccBtn.Name = "TambahAccBtn"
        Me.TambahAccBtn.Size = New System.Drawing.Size(75, 23)
        Me.TambahAccBtn.TabIndex = 7
        Me.TambahAccBtn.Text = "Tambah"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GridControl2)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 37)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(378, 256)
        Me.PanelControl4.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(374, 252)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsDetail.EnableMasterViewMode = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nama Accessory"
        Me.GridColumn4.FieldName = "AccId.NamaAccessory"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 914
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id"
        Me.GridColumn1.FieldName = "AccId.Id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 154
        '
        'idAccTxt
        '
        Me.idAccTxt.EditValue = "Accessory"
        Me.idAccTxt.Location = New System.Drawing.Point(7, 11)
        Me.idAccTxt.Name = "idAccTxt"
        Me.idAccTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.idAccTxt.Properties.Appearance.Options.UseBackColor = True
        Me.idAccTxt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idAccTxt.Properties.DataSource = Me.UAccXP
        Me.idAccTxt.Properties.DisplayMember = "NamaAccessory"
        Me.idAccTxt.Properties.NullText = ""
        Me.idAccTxt.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.idAccTxt.Properties.ValueMember = "This"
        Me.idAccTxt.Properties.View = Me.GridLookUpEdit1View
        Me.idAccTxt.Size = New System.Drawing.Size(186, 20)
        Me.idAccTxt.TabIndex = 5
        '
        'UAccXP
        '
        Me.UAccXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitAccessoryModel)
        Me.UAccXP.Session = Me.UOW
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colNamaAccessory, Me.colKeterangan, Me.colStatus})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        Me.colId1.Width = 113
        '
        'colNamaAccessory
        '
        Me.colNamaAccessory.FieldName = "NamaAccessory"
        Me.colNamaAccessory.Name = "colNamaAccessory"
        Me.colNamaAccessory.Visible = True
        Me.colNamaAccessory.VisibleIndex = 1
        Me.colNamaAccessory.Width = 361
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Visible = True
        Me.colKeterangan.VisibleIndex = 2
        Me.colKeterangan.Width = 296
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 298
        '
        'TransmisiTxt
        '
        Me.TransmisiTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitModelBS, "Transmisi", True))
        Me.TransmisiTxt.Location = New System.Drawing.Point(115, 100)
        Me.TransmisiTxt.Name = "TransmisiTxt"
        Me.TransmisiTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.TransmisiTxt.Properties.Appearance.Options.UseBackColor = True
        Me.TransmisiTxt.Size = New System.Drawing.Size(83, 20)
        Me.TransmisiTxt.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(22, 103)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Transmisi"
        '
        'TipeTxt
        '
        Me.TipeTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitModelBS, "Tipe", True))
        Me.TipeTxt.Location = New System.Drawing.Point(115, 74)
        Me.TipeTxt.Name = "TipeTxt"
        Me.TipeTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.TipeTxt.Properties.Appearance.Options.UseBackColor = True
        Me.TipeTxt.Size = New System.Drawing.Size(136, 20)
        Me.TipeTxt.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 77)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tipe"
        '
        'ModelTxt
        '
        Me.ModelTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitModelBS, "Model", True))
        Me.ModelTxt.Location = New System.Drawing.Point(115, 48)
        Me.ModelTxt.Name = "ModelTxt"
        Me.ModelTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.ModelTxt.Properties.Appearance.Options.UseBackColor = True
        Me.ModelTxt.Size = New System.Drawing.Size(167, 20)
        Me.ModelTxt.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Model"
        '
        'idTxt
        '
        Me.idTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitModelBS, "Id", True))
        Me.idTxt.Location = New System.Drawing.Point(115, 22)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.idTxt.Properties.Appearance.Options.UseBackColor = True
        Me.idTxt.Size = New System.Drawing.Size(83, 20)
        Me.idTxt.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 11
        Me.BatalBtn.Text = "Batal"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 14
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 13
        Me.EditBtn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 12
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 10
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 9
        Me.TambahBtn.Text = "Tambah"
        '
        'UAccMoBS
        '
        Me.UAccMoBS.DataSource = Me.UAccMoXP
        '
        'UAccMoXP
        '
        Me.UAccMoXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitAccessoryModelModel)
        Me.UAccMoXP.Session = Me.UOW
        '
        'DataModelUnitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 491)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "DataModelUnitForm"
        Me.Text = "Model Unit"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitModelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitModelXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idAccTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UAccXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransmisiTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipeTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UAccMoBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UAccMoXP, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents idTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TipeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModelTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransmisiTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents UnitModelXP As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitModelBS As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransmisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HapusAccBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahAccBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents idAccTxt As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UAccXP As DevExpress.Xpo.XPCollection
    Friend WithEvents UAccMoXP As DevExpress.Xpo.XPCollection
    Friend WithEvents UAccMoBS As BindingSource
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaAccessory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
