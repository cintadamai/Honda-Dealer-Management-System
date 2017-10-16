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

    Private Sub KaryawanFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles KaryawanFormBtn.ItemClick
        Dim f As New KaryawanForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub DivisiFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DivisiFormBtn.ItemClick
        Dim f As New DivisiForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub JabatanFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles JabatanFormBtn.ItemClick
        Dim f As New JabatanForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub BranchFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BranchFormBtn.ItemClick
        Dim f As New BranchForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub
End Class