Public Class UnitModuleMDI
    Private Sub DataSupplierFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DataSupplierFormBtn.ItemClick
        Dim f As New DataSupplierForm
        With f
            .MdiParent = Me
        End With
        f.Show()
        f.Focus()
    End Sub

    Private Sub DataUnitGudangFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DataUnitGudangFormBtn.ItemClick
        Dim f As New DataGudangUnitForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub
End Class