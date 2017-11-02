Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Xpo
Public Class PenerimaanKendaraanForm
    Private Sub XtraScrollableControl1_Click(sender As Object, e As EventArgs) Handles XtraScrollableControl1.Click

    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        PenerimaanBS.AddNew()
        EditState()
    End Sub

    Sub ViewState()
        idTxt.ReadOnly = True
        NomorSJTxt.ReadOnly = True
        TanggalSJTxt.ReadOnly = True
        ModelTxt.ReadOnly = True
        TipeTxt.ReadOnly = True
        TransmisiTxt.ReadOnly = True
        RangkaTxt.ReadOnly = True
        MesinTxt.ReadOnly = True
        NoKunciTxt.ReadOnly = True
        WarnaTxt.ReadOnly = True
        GudangTxt.ReadOnly = True
        KeteranganTxt.ReadOnly = True


        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = True
        EditBtn.Enabled = True
        HapusBtn.Enabled = True
    End Sub

    Sub EditState()
        idTxt.ReadOnly = True
        NomorSJTxt.ReadOnly = False
        TanggalSJTxt.ReadOnly = False
        ModelTxt.ReadOnly = False
        RangkaTxt.ReadOnly = False
        MesinTxt.ReadOnly = False
        NoKunciTxt.ReadOnly = False
        WarnaTxt.ReadOnly = False
        GudangTxt.ReadOnly = False
        KeteranganTxt.ReadOnly = False

        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False
    End Sub

    Private Sub BuktiPenerimaanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If Not validator.Validate Then
            Exit Sub
        End If

        Dim p As UnitReceiveModel = PenerimaanBS.Current
        Dim u As UnitStockModel
        If IsDBNull(p.Id) Or idTxt.Text = "0" Or p.Id = vbNull Then
            p.CreatedAt = DateTime.Now
            p.CreatedBy = UserAkses.User.Id

            u = New UnitStockModel(UOW) With {
                .Model = p.Model,
                .Warna = p.Warna,
                .Rangka = p.NoRangka,
                .Mesin = p.NoMesin,
                .Tahun = p.Tahun,
                .Gudang = p.Gudang,
                .TanggalMasuk = p.TanggalDiterima,
                .Status = "OnHand",
                .CreatedAt = DateTime.Now,
                .CreatedBy = UserAkses.User.Id,
                .Suratjalanmasuk = p.Id
            }
            u.Save()
        Else
            Dim coll As XPQuery(Of UnitStockModel) = UOW.Query(Of UnitStockModel)()
            u = (From c In coll
                 Where c.Suratjalanmasuk = p.Id
                 Select c).First
            u.Model = p.Model
            u.Warna = p.Warna
            u.Rangka = p.NoRangka
            u.Mesin = p.NoMesin
            u.Tahun = p.Tahun
            u.Gudang = p.Gudang
            u.TanggalMasuk = p.TanggalDiterima
            u.Status = "OnHand"
            u.CreatedAt = DateTime.Now
            u.CreatedBy = UserAkses.User.Id
            u.Suratjalanmasuk = p.Id
            u.Save()
        End If
        p.UpdatedAt = DateTime.Now
        p.UpdatedBy = UserAkses.User.Id
        u.UpdatedAt = DateTime.Now
        u.UpdatedBy = UserAkses.User.Id
        PenerimaanXP.Add(p)
        UOW.CommitChanges()
        u.Suratjalanmasuk = p.Id
        u.Save()
        UOW.CommitChanges()
        PenerimaanBS.EndEdit()

        ViewState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        PenerimaanBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin ingin menghapus data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim p As UnitReceiveModel = PenerimaanBS.Current
            Dim coll As XPQuery(Of UnitStockModel) = UOW.Query(Of UnitStockModel)()
            Dim u As UnitStockModel = (From c In coll
                                       Where c.Suratjalanmasuk = p.Id
                                       Select c).First
            u.Delete()
            PenerimaanXP.Remove(p)

            UOW.CommitChanges()
            PenerimaanBS.EndEdit()

            ViewState()
        End If
    End Sub
End Class