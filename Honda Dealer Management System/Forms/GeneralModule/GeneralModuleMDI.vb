Public Class GeneralModuleMDI
    Private Sub UserFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UserFormBtn.ItemClick
        Dim f As New UserForm
        f.MdiParent = Me
        f.Show()
        f.Focus()
    End Sub

    Private Sub RoleFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RoleFormBtn.ItemClick
        Dim f As New RoleForm
        f.MdiParent = Me
        f.Show()
        f.Focus()
    End Sub

    Private Sub RolesMenuFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RolesMenuFormBtn.ItemClick
        Dim f As New RoleMenu
        f.MdiParent = Me
        f.Show()
        f.Focus()
    End Sub
End Class