Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Xpo
Public Class UserForm
    Dim RoleColl As XPQuery(Of RoleModel)
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
        RoleColl = UOW.Query(Of RoleModel)()
    End Sub

    Sub ViewState()
        id.Properties.ReadOnly = True
        username.Properties.ReadOnly = True
        personName.Properties.ReadOnly = True
        role.Properties.ReadOnly = True
        isActiveCkbx.Properties.ReadOnly = True

        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True
    End Sub

    Sub EditState()
        'id.Properties.ReadOnly = False
        username.Properties.ReadOnly = False
        personName.Properties.ReadOnly = False
        role.Properties.ReadOnly = False
        isActiveCkbx.Properties.ReadOnly = False

        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        UserBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        UserBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If Not validator.Validate Then
            Exit Sub
        End If

        Dim user As UserModel
        user = UserBS.Current
        user.Role = (From r In RoleColl Where r.Id = Convert.ToInt64(role.EditValue) Select r).First
        If user.Id = 0 Or user.Id = vbNull Then
            user.Password = "123"
        End If
        UserXpCollection.Add(user)
        UserBS.EndEdit()
        UOW.CommitChanges()

        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin ingin menghapus user ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            UserXpCollection.Remove(UserBS.Current)
            UOW.CommitChanges()
        End If
    End Sub
End Class