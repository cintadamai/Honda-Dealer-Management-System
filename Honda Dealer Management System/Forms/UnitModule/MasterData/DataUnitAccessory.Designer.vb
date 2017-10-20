<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataUnitAccessory
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.UnitAccessoryBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitAccessoryXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaAccessory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.NamaAccessoryTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.statusTxt = New DevExpress.XtraEditors.CheckEdit()
        Me.keteranganTxt = New DevExpress.XtraEditors.MemoEdit()
        Me.idTxt = New DevExpress.XtraEditors.TextEdit()
        Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitAccessoryBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitAccessoryXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.NamaAccessoryTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keteranganTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1071, 506)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(419, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(640, 444)
        Me.PanelControl2.TabIndex = 50
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.UnitAccessoryBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(636, 440)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'UnitAccessoryBS
        '
        Me.UnitAccessoryBS.DataSource = Me.UnitAccessoryXP
        '
        'UnitAccessoryXP
        '
        Me.UnitAccessoryXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitAccessoryModel)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNamaAccessory, Me.colKeterangan, Me.colStatus})
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
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colNamaAccessory
        '
        Me.colNamaAccessory.FieldName = "NamaAccessory"
        Me.colNamaAccessory.Name = "colNamaAccessory"
        Me.colNamaAccessory.Visible = True
        Me.colNamaAccessory.VisibleIndex = 1
        Me.colNamaAccessory.Width = 251
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Visible = True
        Me.colKeterangan.VisibleIndex = 2
        Me.colKeterangan.Width = 349
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 104
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.NamaAccessoryTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.statusTxt)
        Me.PanelControl1.Controls.Add(Me.keteranganTxt)
        Me.PanelControl1.Controls.Add(Me.idTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(401, 444)
        Me.PanelControl1.TabIndex = 49
        '
        'NamaAccessoryTxt
        '
        Me.NamaAccessoryTxt.Location = New System.Drawing.Point(118, 46)
        Me.NamaAccessoryTxt.Name = "NamaAccessoryTxt"
        Me.NamaAccessoryTxt.Size = New System.Drawing.Size(189, 20)
        Me.NamaAccessoryTxt.TabIndex = 56
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 49)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl3.TabIndex = 55
        Me.LabelControl3.Text = "Nama Accessory"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 53
        Me.LabelControl2.Text = "Keterangan"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 51
        Me.LabelControl1.Text = "ID"
        '
        'statusTxt
        '
        Me.statusTxt.EditValue = Nothing
        Me.statusTxt.Location = New System.Drawing.Point(118, 134)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.statusTxt.Properties.Caption = "isActive"
        Me.statusTxt.Size = New System.Drawing.Size(100, 19)
        Me.statusTxt.TabIndex = 58
        '
        'keteranganTxt
        '
        Me.keteranganTxt.Location = New System.Drawing.Point(118, 72)
        Me.keteranganTxt.Name = "keteranganTxt"
        Me.keteranganTxt.Size = New System.Drawing.Size(260, 56)
        Me.keteranganTxt.TabIndex = 54
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(118, 20)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(100, 20)
        Me.idTxt.TabIndex = 52
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 48
        Me.BatalBtn.Text = "Batal"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 47
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 46
        Me.EditBtn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 45
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 44
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 43
        Me.TambahBtn.Text = "Tambah"
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'DataUnitAccessory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 506)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "DataUnitAccessory"
        Me.Text = "Unit Accessory"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitAccessoryBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitAccessoryXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.NamaAccessoryTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keteranganTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NamaAccessoryTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents statusTxt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents keteranganTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents UnitAccessoryXP As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitAccessoryBS As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaAccessory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
