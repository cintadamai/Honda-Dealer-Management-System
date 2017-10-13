<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.masuk = New DevExpress.XtraEditors.SimpleButton()
        Me.password = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.username = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.validator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.UOW = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GeneralModule = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Adobe Ming Std L", 20.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(198, 104)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(413, 28)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Honda Dealer Management System"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.keluar)
        Me.PanelControl1.Controls.Add(Me.masuk)
        Me.PanelControl1.Controls.Add(Me.password)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.username)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(178, 157)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(444, 202)
        Me.PanelControl1.TabIndex = 1
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(233, 126)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(99, 35)
        Me.keluar.TabIndex = 5
        Me.keluar.Text = "Keluar"
        '
        'masuk
        '
        Me.masuk.Location = New System.Drawing.Point(114, 126)
        Me.masuk.Name = "masuk"
        Me.masuk.Size = New System.Drawing.Size(99, 35)
        Me.masuk.TabIndex = 4
        Me.masuk.Text = "Masuk"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(181, 68)
        Me.password.Name = "password"
        Me.password.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.password.Properties.Appearance.Options.UseBackColor = True
        Me.password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(160, 20)
        Me.password.TabIndex = 3
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.password, ConditionValidationRule2)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(105, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Password"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(181, 42)
        Me.username.Name = "username"
        Me.username.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.username.Properties.Appearance.Options.UseBackColor = True
        Me.username.Size = New System.Drawing.Size(160, 20)
        Me.username.TabIndex = 1
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Harus di isi."
        Me.validator.SetValidationRule(Me.username, ConditionValidationRule3)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(105, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Username"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GeneralModule)
        Me.GroupControl1.Location = New System.Drawing.Point(56, 382)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(702, 134)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Menu"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.Honda_Dealer_Management_System.My.Resources.Resources._1409092
        Me.PictureEdit1.Location = New System.Drawing.Point(349, 22)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Size = New System.Drawing.Size(95, 76)
        Me.PictureEdit1.TabIndex = 3
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
        '
        'UOW
        '
        Me.UOW.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UOW.TrackPropertiesModifications = False
        '
        'GeneralModule
        '
        Me.GeneralModule.Location = New System.Drawing.Point(24, 34)
        Me.GeneralModule.Name = "GeneralModule"
        Me.GeneralModule.Size = New System.Drawing.Size(99, 35)
        Me.GeneralModule.TabIndex = 5
        Me.GeneralModule.Text = "General Modul"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 543)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents masuk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents validator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents UOW As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GeneralModule As DevExpress.XtraEditors.SimpleButton
End Class
