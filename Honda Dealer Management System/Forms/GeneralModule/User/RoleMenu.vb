Imports DevExpress.Xpo
Imports Honda_Dealer_Management_System.HDMS
Imports Humanizer
Public Class RoleMenu
    Dim RoleMenuColl As XPQuery(Of RoleMenuModel)
    Dim RoleColl As XPQuery(Of RoleModel)
    Dim MenuColl As XPQuery(Of MenuModel)
    Private Sub RoleNameTxt_EditValueChanged(sender As Object, e As EventArgs) Handles RoleNameTxt.EditValueChanged
        RefreshData()
    End Sub

    Private Sub RoleMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoleMenuBS.DataSource = vbNull
        RoleMenuColl = UOW.Query(Of RoleMenuModel)
        MenuColl = UOW.Query(Of MenuModel)()
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        UserAkses.AssignPermission(RoleNameTxt.Text, MenuNameTxt.Text)
        RefreshData()
    End Sub

    Sub RefreshData()
        Dim filtered = From rm In RoleMenuColl
                       Join m In MenuColl On rm.Menuid.Id Equals m.Id
                       Where rm.Roleid.RoleName = RoleNameTxt.Text
                       Select New With {rm.Id, m.MenuName, .MenuName1 = m.MenuName.ToString().Humanize(LetterCasing.AllCaps), m.MenuLevel}

        RoleMenuBS.DataSource = filtered

        MenuBS.DataSource = MenuColl.Except(From f In filtered
                                            Join m In MenuColl On f.MenuName Equals m.MenuName
                                            Select m)
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim selected = GridView1.GetFocusedRowCellValue(GridColumn2).ToString
        UserAkses.RevokePermission(RoleNameTxt.Text, selected)
        RefreshData()
    End Sub
End Class