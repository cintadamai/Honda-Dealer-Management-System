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
        Me.RolesMenuFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.KaryawanFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.DivisiFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.JabatanFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.BranchFormBtn = New DevExpress.XtraBars.BarButtonItem()
        Me.UserPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.UserPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.KaryawanPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.KaryawanPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.MdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.UserFormBtn, Me.RoleFormBtn, Me.RolesMenuFormBtn, Me.KaryawanFormBtn, Me.DivisiFormBtn, Me.JabatanFormBtn, Me.BranchFormBtn})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.UserPage, Me.KaryawanPage})
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
        'RolesMenuFormBtn
        '
        Me.RolesMenuFormBtn.Caption = "Roles Menu"
        Me.RolesMenuFormBtn.Id = 3
        Me.RolesMenuFormBtn.ImageOptions.Image = Global.Honda_Dealer_Management_System.My.Resources.Resources.publicfix_32x32
        Me.RolesMenuFormBtn.Name = "RolesMenuFormBtn"
        Me.RolesMenuFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'KaryawanFormBtn
        '
        Me.KaryawanFormBtn.Caption = "Karyawan"
        Me.KaryawanFormBtn.Id = 4
        Me.KaryawanFormBtn.ImageOptions.Image = Global.Honda_Dealer_Management_System.My.Resources.Resources.bocustomer_32x32
        Me.KaryawanFormBtn.Name = "KaryawanFormBtn"
        Me.KaryawanFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'DivisiFormBtn
        '
        Me.DivisiFormBtn.Caption = "Divisi"
        Me.DivisiFormBtn.Id = 5
        Me.DivisiFormBtn.ImageOptions.Image = Global.Honda_Dealer_Management_System.My.Resources.Resources.bocountry_32x32
        Me.DivisiFormBtn.Name = "DivisiFormBtn"
        Me.DivisiFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'JabatanFormBtn
        '
        Me.JabatanFormBtn.Caption = "Jabatan"
        Me.JabatanFormBtn.Id = 6
        Me.JabatanFormBtn.ImageOptions.Image = Global.Honda_Dealer_Management_System.My.Resources.Resources.boposition_32x32
        Me.JabatanFormBtn.Name = "JabatanFormBtn"
        Me.JabatanFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BranchFormBtn
        '
        Me.BranchFormBtn.Caption = "Branch"
        Me.BranchFormBtn.Id = 7
        Me.BranchFormBtn.ImageOptions.Image = Global.Honda_Dealer_Management_System.My.Resources.Resources.home_32x32
        Me.BranchFormBtn.Name = "BranchFormBtn"
        Me.BranchFormBtn.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
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
        Me.UserPageGroup.ItemLinks.Add(Me.RolesMenuFormBtn)
        Me.UserPageGroup.Name = "UserPageGroup"
        Me.UserPageGroup.Text = "User Akses"
        '
        'KaryawanPage
        '
        Me.KaryawanPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.KaryawanPageGroup})
        Me.KaryawanPage.Name = "KaryawanPage"
        Me.KaryawanPage.Text = "Karyawan"
        '
        'KaryawanPageGroup
        '
        Me.KaryawanPageGroup.ItemLinks.Add(Me.KaryawanFormBtn)
        Me.KaryawanPageGroup.ItemLinks.Add(Me.DivisiFormBtn)
        Me.KaryawanPageGroup.ItemLinks.Add(Me.JabatanFormBtn)
        Me.KaryawanPageGroup.ItemLinks.Add(Me.BranchFormBtn)
        Me.KaryawanPageGroup.Name = "KaryawanPageGroup"
        Me.KaryawanPageGroup.Text = "Karyawan"
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
    Friend WithEvents RolesMenuFormBtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents KaryawanPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents KaryawanPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents KaryawanFormBtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DivisiFormBtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents JabatanFormBtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BranchFormBtn As DevExpress.XtraBars.BarButtonItem
End Class
