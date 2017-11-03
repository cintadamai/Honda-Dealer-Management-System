﻿Public Class UnitModuleMDI
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

    Private Sub InputPembelianFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InputPembelianFormBtn.ItemClick
        Dim f As New InputPembelianForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub BuktiPenerimaanUnitFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BuktiPenerimaanUnitFormBtn.ItemClick

    End Sub

    Private Sub PenerimaanPembelianUnitFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PenerimaanPembelianUnitFormBtn.ItemClick
        Dim f As New PenerimaanKendaraanForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub TransferUnitFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TransferUnitFormBtn.ItemClick
        Dim f As New UnitTransferForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub

    Private Sub InputReturPembelianFormBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InputReturPembelianFormBtn.ItemClick
        Dim f As New InputReturPembelianForm With {.MdiParent = Me}
        f.Show()
        f.Focus()
    End Sub
End Class