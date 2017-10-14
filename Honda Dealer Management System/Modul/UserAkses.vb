Imports DevExpress.Xpo
Imports System.Linq
Imports System.Linq.Expressions
Imports Honda_Dealer_Management_System.HDMS
Module UserAkses
    Dim UOW As New UnitOfWork(XpoDefault.DataLayer)
    Public User As UserModel
    Dim Users As XPQuery(Of UserModel) = UOW.Query(Of UserModel)()
    Dim Roles As XPQuery(Of RoleModel) = UOW.Query(Of RoleModel)()
    Dim Menus As XPQuery(Of MenuModel) = UOW.Query(Of MenuModel)()
    Dim RoleMenus As XPQuery(Of RoleMenuModel) = UOW.Query(Of RoleMenuModel)

    Public Function HasPermission(Menu As String)
        Dim Finds = From c In RoleMenus
                    Where c.Roleid.RoleName = User.Role.RoleName _
                        And c.Menuid.MenuName = Menu
                    Select c

        If Finds.Count < 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub AssignPermission(RoleName As String, MenuName As String)
        Dim role = (From r In Roles Where r.RoleName = RoleName Select r).First
        Dim menu = (From m In Menus Where m.MenuName = MenuName).First

        Dim finds = From rm In RoleMenus
                    Where rm.Roleid.RoleName = role.RoleName _
                        And rm.Menuid.MenuName = menu.MenuName
                    Select rm

        If finds.Count < 1 Then
            Dim rolemenu = New RoleMenuModel(UOW) With {
                .Roleid = role,
                .Menuid = menu
            }
            rolemenu.Save()
            UOW.CommitChanges()
        End If
    End Sub

    Public Sub RevokePermission(RoleName As String, MenuName As String)
        Dim role = (From r In Roles Where r.RoleName = RoleName Select r).First
        Dim menu = (From m In Menus Where m.MenuName = MenuName).First

        Dim finds = From rm In RoleMenus
                    Where rm.Roleid.RoleName = role.RoleName _
                        And rm.Menuid.MenuName = menu.MenuName
                    Select rm

        If finds.Count >= 1 Then
            For Each RM As RoleMenuModel In finds
                RM.Delete()
            Next
            UOW.CommitChanges()
        End If
    End Sub

End Module
