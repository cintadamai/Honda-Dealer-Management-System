Public Class GeneralModuleMDI
    Private Sub UserFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UserFormBtn.ItemClick
        Dim f As New UserForm
        f.MdiParent = Me
        f.Show()
        f.Focus()
    End Sub
End Class