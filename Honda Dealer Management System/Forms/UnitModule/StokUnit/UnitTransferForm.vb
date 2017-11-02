Imports DevExpress.Xpo
Imports Honda_Dealer_Management_System.HDMS

Public Class UnitTransferForm
    Private Sub UnitTransferForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = True
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        idTxt.ReadOnly = True
        NoBuktiTxt.ReadOnly = True
        tanggalTransferTxt.ReadOnly = True
        GudangTujuanTxt.ReadOnly = True
        ModelTxt.ReadOnly = True
        KeteranganTxt.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        NoBuktiTxt.ReadOnly = False
        tanggalTransferTxt.ReadOnly = False
        GudangTujuanTxt.ReadOnly = False
        ModelTxt.ReadOnly = False
        KeteranganTxt.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        TransferBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        TransferBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
        ModelTxt.ReadOnly = True
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim t As UnitTransferModel = TransferBS.Current
        If IsDBNull(t.Id) Or t.Id = 0 Then
            t.CreatedAt = DateTime.Now
            t.CreatedBy = UserAkses.User.Id
        End If
        t.GudangAsal = (From c In UOW.Query(Of UnitGudangModel)
                        Where c.Id = Convert.ToInt64(GudangAsalTxt.EditValue)
                        Select c).First
        t.UpdatedAt = DateTime.Now
        t.UpdatedBy = UserAkses.User.Id
        TransferXP.Add(t)
        UOW.CommitChanges()

        Dim m As UnitStockModel = t.UnitStock
        m.Gudang = t.GudangTujuan
        m.Save()
        UOW.CommitChanges()
        TransferBS.EndEdit()

        ViewState()
    End Sub

    Private Sub ModelTxt_EditValueChanged(sender As Object, e As EventArgs) Handles ModelTxt.EditValueChanged
        If ModelTxt.Text = "" Or IsDBNull(ModelTxt.EditValue) Then
            Exit Sub
        End If
        Dim coll As XPQuery(Of UnitStockModel) = UOW.Query(Of UnitStockModel)()
        Dim s As UnitStockModel = (From c In coll
                                   Where c.Id = Convert.ToInt64(ModelTxt.EditValue)
                                   Select c).First
        GudangAsalTxt.EditValue = s.Gudang.Id
        VariantTxt.Text = s.Model.Tipe
        TransmisiTxt.Text = s.Model.Transmisi
        NoRangkaTxt.Text = s.Rangka
        NoMesinTxt.Text = s.Mesin
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Apakah anda yakn ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim t As UnitTransferModel = TransferBS.Current
            Dim u As UnitStockModel = t.UnitStock
            u.Gudang = t.GudangAsal
            u.Save()
            TransferXP.Remove(t)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub

    Private Sub UnitTransferForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If ModelTxt.Text = "" Or IsDBNull(ModelTxt.EditValue) Then
            Exit Sub
        End If
        Dim coll As XPQuery(Of UnitStockModel) = UOW.Query(Of UnitStockModel)()
        Dim s As UnitStockModel = (From c In coll
                                   Where c.Id = Convert.ToInt64(ModelTxt.EditValue)
                                   Select c).First
        GudangAsalTxt.EditValue = s.Gudang.Id
        VariantTxt.Text = s.Model.Tipe
        TransmisiTxt.Text = s.Model.Transmisi
        NoRangkaTxt.Text = s.Rangka
        NoMesinTxt.Text = s.Mesin
    End Sub
End Class