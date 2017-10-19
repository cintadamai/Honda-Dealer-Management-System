<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSupplierForm
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
        Me.SupplierBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoTelepon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNpwp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaNpwp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.NPWPTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.NamaNPWPTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NoTeleponTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.KotaTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.NamaSupplierTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.idTxt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.AlamatTxt = New DevExpress.XtraEditors.MemoEdit()
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
        CType(Me.SupplierBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.NPWPTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaNPWPTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoTeleponTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KotaTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaSupplierTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1103, 487)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(454, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(637, 425)
        Me.PanelControl2.TabIndex = 38
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SupplierBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(633, 421)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SupplierBS
        '
        Me.SupplierBS.DataSource = Me.SupplierXP
        '
        'SupplierXP
        '
        Me.SupplierXP.DeleteObjectOnRemove = True
        Me.SupplierXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitSupplierModel)
        Me.SupplierXP.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNamaSupplier, Me.colAlamat, Me.colKota, Me.colNoTelepon, Me.colNpwp, Me.colNamaNpwp})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
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
        'colNamaSupplier
        '
        Me.colNamaSupplier.FieldName = "NamaSupplier"
        Me.colNamaSupplier.Name = "colNamaSupplier"
        Me.colNamaSupplier.Visible = True
        Me.colNamaSupplier.VisibleIndex = 1
        Me.colNamaSupplier.Width = 266
        '
        'colAlamat
        '
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 2
        Me.colAlamat.Width = 311
        '
        'colKota
        '
        Me.colKota.FieldName = "Kota"
        Me.colKota.Name = "colKota"
        Me.colKota.Visible = True
        Me.colKota.VisibleIndex = 3
        Me.colKota.Width = 129
        '
        'colNoTelepon
        '
        Me.colNoTelepon.FieldName = "NoTelepon"
        Me.colNoTelepon.Name = "colNoTelepon"
        Me.colNoTelepon.Visible = True
        Me.colNoTelepon.VisibleIndex = 4
        Me.colNoTelepon.Width = 133
        '
        'colNpwp
        '
        Me.colNpwp.FieldName = "Npwp"
        Me.colNpwp.Name = "colNpwp"
        Me.colNpwp.Visible = True
        Me.colNpwp.VisibleIndex = 5
        Me.colNpwp.Width = 179
        '
        'colNamaNpwp
        '
        Me.colNamaNpwp.FieldName = "NamaNpwp"
        Me.colNamaNpwp.Name = "colNamaNpwp"
        Me.colNamaNpwp.Visible = True
        Me.colNamaNpwp.VisibleIndex = 6
        Me.colNamaNpwp.Width = 200
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.NPWPTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.NamaNPWPTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.NoTeleponTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.KotaTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.NamaSupplierTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.idTxt)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.AlamatTxt)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(436, 425)
        Me.PanelControl1.TabIndex = 37
        '
        'NPWPTxt
        '
        Me.NPWPTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "Npwp", True))
        Me.NPWPTxt.Location = New System.Drawing.Point(128, 190)
        Me.NPWPTxt.Name = "NPWPTxt"
        Me.NPWPTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NPWPTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NPWPTxt.Size = New System.Drawing.Size(154, 20)
        Me.NPWPTxt.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(24, 193)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "NPWP"
        '
        'NamaNPWPTxt
        '
        Me.NamaNPWPTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "NamaNpwp", True))
        Me.NamaNPWPTxt.Location = New System.Drawing.Point(128, 216)
        Me.NamaNPWPTxt.Name = "NamaNPWPTxt"
        Me.NamaNPWPTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NamaNPWPTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NamaNPWPTxt.Size = New System.Drawing.Size(205, 20)
        Me.NamaNPWPTxt.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 219)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Nama NPWP"
        '
        'NoTeleponTxt
        '
        Me.NoTeleponTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "NoTelepon", True))
        Me.NoTeleponTxt.Location = New System.Drawing.Point(128, 164)
        Me.NoTeleponTxt.Name = "NoTeleponTxt"
        Me.NoTeleponTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NoTeleponTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NoTeleponTxt.Size = New System.Drawing.Size(154, 20)
        Me.NoTeleponTxt.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 167)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "No Telepon"
        '
        'KotaTxt
        '
        Me.KotaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "Kota", True))
        Me.KotaTxt.Location = New System.Drawing.Point(128, 138)
        Me.KotaTxt.Name = "KotaTxt"
        Me.KotaTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.KotaTxt.Properties.Appearance.Options.UseBackColor = True
        Me.KotaTxt.Size = New System.Drawing.Size(154, 20)
        Me.KotaTxt.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 141)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Kota"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Alamat"
        '
        'NamaSupplierTxt
        '
        Me.NamaSupplierTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "NamaSupplier", True))
        Me.NamaSupplierTxt.Location = New System.Drawing.Point(128, 43)
        Me.NamaSupplierTxt.Name = "NamaSupplierTxt"
        Me.NamaSupplierTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.NamaSupplierTxt.Properties.Appearance.Options.UseBackColor = True
        Me.NamaSupplierTxt.Size = New System.Drawing.Size(205, 20)
        Me.NamaSupplierTxt.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Nama Supplier"
        '
        'idTxt
        '
        Me.idTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "Id", True))
        Me.idTxt.Location = New System.Drawing.Point(128, 17)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.idTxt.Properties.Appearance.Options.UseBackColor = True
        Me.idTxt.Size = New System.Drawing.Size(154, 20)
        Me.idTxt.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'AlamatTxt
        '
        Me.AlamatTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBS, "Alamat", True))
        Me.AlamatTxt.Location = New System.Drawing.Point(128, 69)
        Me.AlamatTxt.Name = "AlamatTxt"
        Me.AlamatTxt.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.AlamatTxt.Properties.Appearance.Options.UseBackColor = True
        Me.AlamatTxt.Size = New System.Drawing.Size(237, 63)
        Me.AlamatTxt.TabIndex = 5
        '
        'BatalBtn
        '
        Me.BatalBtn.Enabled = False
        Me.BatalBtn.Location = New System.Drawing.Point(204, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 32)
        Me.BatalBtn.TabIndex = 36
        Me.BatalBtn.Text = "Batal"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(492, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 35
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(396, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 32)
        Me.EditBtn.TabIndex = 34
        Me.EditBtn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(300, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 33
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Enabled = False
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 32
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 31
        Me.TambahBtn.Text = "Tambah"
        '
        'DataSupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 487)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Name = "DataSupplierForm"
        Me.Text = "Data Supplier"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.NPWPTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaNPWPTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoTeleponTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KotaTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaSupplierTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NPWPTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NamaNPWPTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NoTeleponTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents KotaTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NamaSupplierTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AlamatTxt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents SupplierXP As DevExpress.Xpo.XPCollection
    Friend WithEvents SupplierBS As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTelepon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNpwp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaNpwp As DevExpress.XtraGrid.Columns.GridColumn
End Class
