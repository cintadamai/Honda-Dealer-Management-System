<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTemplate
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
        Me.XtraScrollableControl = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.HapusBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.EditBrn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TambahBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraScrollableControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraScrollableControl
        '
        Me.XtraScrollableControl.Controls.Add(Me.HapusBtn)
        Me.XtraScrollableControl.Controls.Add(Me.EditBrn)
        Me.XtraScrollableControl.Controls.Add(Me.PrintBtn)
        Me.XtraScrollableControl.Controls.Add(Me.SimpanBtn)
        Me.XtraScrollableControl.Controls.Add(Me.TambahBtn)
        Me.XtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl.Name = "XtraScrollableControl"
        Me.XtraScrollableControl.Size = New System.Drawing.Size(826, 487)
        Me.XtraScrollableControl.TabIndex = 0
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(396, 12)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(90, 32)
        Me.HapusBtn.TabIndex = 9
        Me.HapusBtn.Text = "Hapus"
        '
        'EditBrn
        '
        Me.EditBrn.Location = New System.Drawing.Point(300, 12)
        Me.EditBrn.Name = "EditBrn"
        Me.EditBrn.Size = New System.Drawing.Size(90, 32)
        Me.EditBrn.TabIndex = 8
        Me.EditBrn.Text = "Edit"
        '
        'PrintBtn
        '
        Me.PrintBtn.Location = New System.Drawing.Point(204, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(90, 32)
        Me.PrintBtn.TabIndex = 7
        Me.PrintBtn.Text = "Print"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(108, 12)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(90, 32)
        Me.SimpanBtn.TabIndex = 6
        Me.SimpanBtn.Text = "Simpan"
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(12, 12)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(90, 32)
        Me.TambahBtn.TabIndex = 5
        Me.TambahBtn.Text = "Tambah"
        '
        'FormTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 487)
        Me.Controls.Add(Me.XtraScrollableControl)
        Me.Name = "FormTemplate"
        Me.Text = "FormTemplate"
        Me.XtraScrollableControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraScrollableControl As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents HapusBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditBrn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TambahBtn As DevExpress.XtraEditors.SimpleButton
End Class
