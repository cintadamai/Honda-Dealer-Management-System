﻿Imports Honda_Dealer_Management_System.HDMS

Public Class DataWarnaUnitForm
    Private Sub DataWarnaUnitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        WarnaTxt.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        WarnaTxt.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        UnitWarnaBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        UnitWarnaBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim w As UnitWarnaModel = UnitWarnaBS.Current
        UnitWarnaXP.Add(w)
        UOW.CommitChanges()
        UnitWarnaBS.EndEdit()

        ViewState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin Hapus Data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim w As UnitWarnaModel = UnitWarnaBS.Current
            UnitWarnaXP.Remove(w)
            UOW.CommitChanges()
            UnitWarnaBS.EndEdit()

            ViewState()
        End If
    End Sub

    Private Sub idTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles idTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            WarnaTxt.Focus()
        End If
    End Sub
End Class