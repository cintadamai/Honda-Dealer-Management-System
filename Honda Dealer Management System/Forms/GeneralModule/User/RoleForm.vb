Imports DevExpress.Xpo
Imports Honda_Dealer_Management_System.HDMS

Public Class RoleForm
    Private Sub RoleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Sub ViewState()
        id.Properties.ReadOnly = True
        RoleName.Properties.ReadOnly = True


        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True
    End Sub

    Sub EditState()
        id.Properties.ReadOnly = True
        RoleName.Properties.ReadOnly = False

        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        RoleBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        RoleBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim r As RoleModel = RoleBS.Current
        RoleXpCollection.Add(r)
        RoleBS.EndEdit()
        UOW.CommitChanges()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin ingin menghapus Role ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            RoleXpCollection.Remove(RoleBS.Current)
            UOW.CommitChanges()
        End If
    End Sub
End Class