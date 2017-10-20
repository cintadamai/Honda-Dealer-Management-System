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

    Private Sub DataUnitWarnaFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DataUnitWarnaFormBtn.ItemClick
        Dim f As New DataWarnaUnitForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub DataModelUnitFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DataModelUnitFormBtn.ItemClick
        Dim f As New DataModelUnitForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub DataUnitAccessoryFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DataUnitAccessoryFormBtn.ItemClick
        Dim f As New DataUnitAccessory With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub
End Class