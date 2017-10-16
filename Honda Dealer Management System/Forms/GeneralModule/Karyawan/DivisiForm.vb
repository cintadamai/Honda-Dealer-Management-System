Imports DevExpress.Xpo
Imports Honda_Dealer_Management_System.HDMS

Public Class DivisiForm
    Private Sub DivisiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        idTxt.Properties.ReadOnly = True
        DivisiNameTxt.Properties.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        idTxt.Properties.ReadOnly = True
        DivisiNameTxt.Properties.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        DivisiBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        DivisiBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim divisi As DivisiModel = DivisiBS.Current
        DivisiXpCollection.Add(divisi)
        UOW.CommitChanges()
        DivisiBS.EndEdit()

        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin hapus data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim divisi As DivisiModel = DivisiBS.Current
            DivisiXpCollection.Remove(divisi)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub
End Class