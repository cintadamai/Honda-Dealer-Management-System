﻿Imports Honda_Dealer_Management_System.HDMS

Public Class DataSupplierForm
    Private Sub DataSupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        idTxt.ReadOnly = True
        NamaSupplierTxt.ReadOnly = True
        AlamatTxt.ReadOnly = True
        KotaTxt.ReadOnly = True
        NoTeleponTxt.ReadOnly = True
        NPWPTxt.ReadOnly = True
        NamaNPWPTxt.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        idTxt.ReadOnly = True
        NamaSupplierTxt.ReadOnly = False
        AlamatTxt.ReadOnly = False
        KotaTxt.ReadOnly = False
        NoTeleponTxt.ReadOnly = False
        NPWPTxt.ReadOnly = False
        NamaNPWPTxt.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        SupplierBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        SupplierBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim s As UnitSupplierModel = SupplierBS.Current
        SupplierXP.Add(s)
        UOW.CommitChanges()
        SupplierBS.EndEdit()

        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin Hapus data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim s As UnitSupplierModel = SupplierBS.Current
            SupplierXP.Remove(s)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub
End Class