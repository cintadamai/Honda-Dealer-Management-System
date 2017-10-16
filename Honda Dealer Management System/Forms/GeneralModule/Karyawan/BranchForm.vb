Imports Honda_Dealer_Management_System.HDMS

Public Class BranchForm
    Private Sub BranchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        IdTxt.Properties.ReadOnly = True
        NamaBarnchTxt.Properties.ReadOnly = True
        AlamatTxt.Properties.ReadOnly = True
        KotaKabupatenTxt.Properties.ReadOnly = True
        NoTeleponTxt.Properties.ReadOnly = True
        NoFaxTxt.Properties.ReadOnly = True
        EmailTxt.Properties.ReadOnly = True
        IsActiveTxt.Properties.ReadOnly = True
        TanggalAktifTxt.Properties.ReadOnly = True
        NpwpTxt.Properties.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        IdTxt.Properties.ReadOnly = True
        NamaBarnchTxt.Properties.ReadOnly = False
        AlamatTxt.Properties.ReadOnly = False
        KotaKabupatenTxt.Properties.ReadOnly = False
        NoTeleponTxt.Properties.ReadOnly = False
        NoFaxTxt.Properties.ReadOnly = False
        EmailTxt.Properties.ReadOnly = False
        IsActiveTxt.Properties.ReadOnly = False
        TanggalAktifTxt.Properties.ReadOnly = False
        NpwpTxt.Properties.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        BranchBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        BranchBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim b As BranchModel = BranchBS.Current
        BranchXpCollection.Add(b)
        UOW.CommitChanges()
        BranchBS.EndEdit()

        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin Hapus Data ? Setelah dihapus data tidak dapat kembali.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim b As BranchModel = BranchBS.Current
            BranchXpCollection.Remove(b)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub
End Class