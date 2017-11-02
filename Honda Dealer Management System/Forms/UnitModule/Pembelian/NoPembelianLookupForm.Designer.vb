<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoPembelianLookupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDpp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPotongan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNilai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsppn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoFaktur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPpn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PembelianBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianXP = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl1)
        Me.XtraScrollableControl1.Controls.Add(Me.TableLayoutPanel1)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(950, 494)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'colTotal
        '
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 9
        Me.colTotal.Width = 103
        '
        'colDpp
        '
        Me.colDpp.FieldName = "Dpp"
        Me.colDpp.Name = "colDpp"
        Me.colDpp.Visible = True
        Me.colDpp.VisibleIndex = 7
        Me.colDpp.Width = 92
        '
        'colPotongan
        '
        Me.colPotongan.FieldName = "Potongan"
        Me.colPotongan.Name = "colPotongan"
        Me.colPotongan.Visible = True
        Me.colPotongan.VisibleIndex = 6
        Me.colPotongan.Width = 92
        '
        'colNilai
        '
        Me.colNilai.FieldName = "Nilai"
        Me.colNilai.Name = "colNilai"
        Me.colNilai.Visible = True
        Me.colNilai.VisibleIndex = 5
        Me.colNilai.Width = 92
        '
        'colIsppn
        '
        Me.colIsppn.FieldName = "Isppn"
        Me.colIsppn.Name = "colIsppn"
        Me.colIsppn.Width = 84
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Width = 167
        '
        'colNoFaktur
        '
        Me.colNoFaktur.FieldName = "NoFaktur"
        Me.colNoFaktur.Name = "colNoFaktur"
        Me.colNoFaktur.Visible = True
        Me.colNoFaktur.VisibleIndex = 4
        Me.colNoFaktur.Width = 182
        '
        'colNoInvoice
        '
        Me.colNoInvoice.FieldName = "NoInvoice"
        Me.colNoInvoice.Name = "colNoInvoice"
        Me.colNoInvoice.Visible = True
        Me.colNoInvoice.VisibleIndex = 3
        Me.colNoInvoice.Width = 140
        '
        'colTanggalPembelian
        '
        Me.colTanggalPembelian.FieldName = "TanggalPembelian"
        Me.colTanggalPembelian.Name = "colTanggalPembelian"
        Me.colTanggalPembelian.Visible = True
        Me.colTanggalPembelian.VisibleIndex = 2
        Me.colTanggalPembelian.Width = 148
        '
        'colPpn
        '
        Me.colPpn.FieldName = "Ppn"
        Me.colPpn.Name = "colPpn"
        Me.colPpn.Visible = True
        Me.colPpn.VisibleIndex = 8
        Me.colPpn.Width = 92
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nama Supplier"
        Me.GridColumn1.FieldName = "Supplier.NamaSupplier"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 205
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.GridColumn1, Me.colTanggalPembelian, Me.colNoInvoice, Me.colNoFaktur, Me.colKeterangan, Me.colIsppn, Me.colNilai, Me.colPotongan, Me.colDpp, Me.colPpn, Me.colTotal})
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
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PembelianBS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(922, 431)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PembelianBS
        '
        Me.PembelianBS.DataSource = Me.PembelianXP
        '
        'PembelianXP
        '
        Me.PembelianXP.ObjectType = GetType(Honda_Dealer_Management_System.HDMS.UnitPurchaseModel)
        Me.PembelianXP.Session = Me.UOW
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(926, 435)
        Me.PanelControl1.TabIndex = 3
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(792, 453)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'NoPembelianLookupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 494)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NoPembelianLookupForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lookup Pembelian"
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents PembelianBS As BindingSource
    Friend WithEvents PembelianXP As DevExpress.Xpo.XPCollection
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalPembelian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoInvoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoFaktur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPotongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDpp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPpn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
End Class
