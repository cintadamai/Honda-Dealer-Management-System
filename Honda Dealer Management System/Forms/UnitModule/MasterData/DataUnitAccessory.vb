Imports Honda_Dealer_Management_System.HDMS

Public Class DataUnitAccessory
    Private Sub DataUnitAccessory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        NamaAccessoryTxt.ReadOnly = True
        keteranganTxt.ReadOnly = True
        statusTxt.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False


        NamaAccessoryTxt.ReadOnly = False
        keteranganTxt.ReadOnly = False
        statusTxt.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        UnitAccessoryBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        UnitAccessoryBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim ua As UnitAccessoryModel = UnitAccessoryBS.Current
        UnitAccessoryXP.Add(ua)
        UOW.CommitChanges()
        UnitAccessoryBS.EndEdit()

        ViewState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin ingin menghapus Data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim ua As UnitAccessoryModel = UnitAccessoryBS.Current
            UnitAccessoryXP.Remove(ua)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub

    Private Sub idTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles idTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            NamaAccessoryTxt.Focus()
        End If
    End Sub

    Private Sub NamaAccessoryTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NamaAccessoryTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            keteranganTxt.Focus()
        End If
    End Sub
End Class