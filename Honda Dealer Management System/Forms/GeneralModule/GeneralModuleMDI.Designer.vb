<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeneralModuleMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralModuleMDI))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.UserFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.RoleFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.UserPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.UserPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.MdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.UserFormBtn, Me.RoleFormBtn})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 3
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.UserPage})
        Me.RibbonControl1.Size = New System.Drawing.Size(757, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'UserFormBtn
        '
        Me.UserFormBtn.Caption = "User"
        Me.UserFormBtn.Id = 1
        Me.UserFormBtn.ImageOptions.Image = CType(resources.GetObject("UserFormBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.UserFormBtn.Name = "UserFormBtn"
        Me.UserFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'RoleFormBtn
        '
        Me.RoleFormBtn.Caption = "Roles"
        Me.RoleFormBtn.Id = 2
        Me.RoleFormBtn.ImageOptions.Image = Global.Honda_Dealer_Management_System.My.Resources.Resources.role_32x32
        Me.RoleFormBtn.Name = "RoleFormBtn"
        Me.RoleFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'UserPage
        '
        Me.UserPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.UserPageGroup})
        Me.UserPage.Name = "UserPage"
        Me.UserPage.Text = "User"
        '
        'UserPageGroup
        '
        Me.UserPageGroup.ItemLinks.Add(Me.UserFormBtn)
        Me.UserPageGroup.ItemLinks.Add(Me.RoleFormBtn)
        Me.UserPageGroup.Name = "UserPageGroup"
        Me.UserPageGroup.Text = "User Akses"
        '
        'MdiManager
        '
        Me.MdiManager.MdiParent = Me
        '
        'GeneralModuleMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 491)
        Me.Controls.Add(Me.RibbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "GeneralModuleMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Module"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents UserPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents UserPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents UserFormBtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RoleFormBtn As DevExpress.XtraBars.BarButtonItem
End Class
