Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Xpo

Public Class KaryawanForm
    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        KaryawanBS.AddNew()
        EditState()
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        idTxt.ReadOnly = True
        NoKtpTxt.ReadOnly = False
        NamaTxt.ReadOnly = False
        AlamatTxt.ReadOnly = False
        NoTeleponTxt.ReadOnly = False
        EmailTxt.ReadOnly = False
        HpTxt.ReadOnly = False
        DivisiTxt.ReadOnly = False
        JabatanTxt.ReadOnly = False
        isActiveCk.ReadOnly = False
        SPVTxt.ReadOnly = False
        TanggalMasukTxt.ReadOnly = False
        TanggalResignTxt.ReadOnly = False
        KeteranganResignTxt.ReadOnly = False
        BranchTxt.ReadOnly = False
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        idTxt.ReadOnly = True
        NoKtpTxt.ReadOnly = True
        NamaTxt.ReadOnly = True
        AlamatTxt.ReadOnly = True
        NoTeleponTxt.ReadOnly = True
        EmailTxt.ReadOnly = True
        HpTxt.ReadOnly = True
        DivisiTxt.ReadOnly = True
        JabatanTxt.ReadOnly = True
        isActiveCk.ReadOnly = True
        SPVTxt.ReadOnly = True
        TanggalMasukTxt.ReadOnly = True
        TanggalResignTxt.ReadOnly = True
        KeteranganResignTxt.ReadOnly = True
        BranchTxt.ReadOnly = True
    End Sub

    Private Sub KaryawanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        KaryawanBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If Not validator.Validate Then
            Exit Sub
        End If

        Dim k As KaryawanModel = KaryawanBS.Current
        karyawanXP.Add(k)
        uow.CommitChanges()
        KaryawanBS.EndEdit()

        ViewState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin ingin hapus data karyawan", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim k As KaryawanModel = KaryawanBS.Current
            karyawanXP.Remove(k)
            uow.CommitChanges()

            ViewState()
        End If
    End Sub
End Class