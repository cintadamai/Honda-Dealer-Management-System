Imports DevExpress.Xpo
Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Data.Filtering

Public Class InputPembelianForm
    Dim ModelColl As XPQuery(Of UnitModelModel)
    Dim DetailColl As XPQuery(Of UnitPurchaseDetailModel)
    Private Sub XtraScrollableControl1_Click(sender As Object, e As EventArgs) Handles XtraScrollableControl1.Click

    End Sub

    Private Sub InputPembelianForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HeaderViewState()
        DetailColl = UOW.Query(Of UnitPurchaseDetailModel)
        ModelColl = UOW.Query(Of UnitModelModel)
        Dim p As UnitPurchaseModel = PembelianBS.Current
        Dim filterC As BinaryOperator = New BinaryOperator("Pembelian", p)
        PembelianDetailXP.Filter = filterC
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        PembelianBS.AddNew()
        HeaderEditState()
        PPNCheckEdit.Checked = True
    End Sub

    Sub HeaderEditState()
        SupplierTxt.ReadOnly = False
        TanggalPembelianTxt.ReadOnly = False
        NoInvoiceTxt.ReadOnly = False
        NoFakturTxt.ReadOnly = False
        PotonganTxt.ReadOnly = False
        KeteranganTxt.ReadOnly = False
        PPNCheckEdit.ReadOnly = False

        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        PanelDetail.Visible = False
        DetailGrid.Visible = False
    End Sub

    Sub HeaderViewState()
        SupplierTxt.ReadOnly = True
        TanggalPembelianTxt.ReadOnly = True
        NoInvoiceTxt.ReadOnly = True
        NoFakturTxt.ReadOnly = True
        PotonganTxt.ReadOnly = True
        KeteranganTxt.ReadOnly = True
        PPNCheckEdit.ReadOnly = True

        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = True
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        PanelDetail.Visible = True
        DetailGrid.Visible = True
    End Sub


    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        PembelianBS.CancelEdit()
        HeaderViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        HeaderEditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click

    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If Not HeaderValidator.Validate Then
            Exit Sub
        End If

        Dim p As UnitPurchaseModel = PembelianBS.Current
        If p.Id = vbNull Or p.Id = 0 Then
            p.CreatedAt = DateAndTime.Now
            p.CreatedBy = UserAkses.User.Id
        End If
        p.UpdatedAt = DateAndTime.Now
        p.UpdatedBy = UserAkses.User.Id
        p.Nilai = NilaiTxt.EditValue
        p.Dpp = DppTxt.EditValue
        p.Ppn = PPNtxt.EditValue
        p.Total = TotalTxt.EditValue
        PembelianXP.Add(p)
        UOW.CommitChanges()
        PembelianBS.EndEdit()

        HeaderViewState()
    End Sub

    Sub CountTotal()
        ModelColl = UOW.Query(Of UnitModelModel)
        Dim p As UnitPurchaseModel = PembelianBS.Current

        If Not IsDBNull(p.Id) Then
            NilaiTxt.EditValue = (From d In DetailColl
                                  Where d.Pembelian.Id = p.Id
                                  Select d.Total).Sum
        End If

        If PPNCheckEdit.Checked = True Then
            DppTxt.EditValue = NilaiTxt.EditValue - PotonganTxt.EditValue
            PPNtxt.EditValue = DppTxt.EditValue * 0.1
            TotalTxt.EditValue = DppTxt.EditValue + PPNtxt.EditValue
        Else
            DppTxt.EditValue = 0
            PPNtxt.EditValue = 0
            TotalTxt.EditValue = NilaiTxt.EditValue - PotonganTxt.EditValue
        End If
    End Sub

    Private Sub PotonganTxt_EditValueChanged(sender As Object, e As EventArgs) Handles PotonganTxt.EditValueChanged
        CountTotal()
    End Sub

    Private Sub PPNCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles PPNCheckEdit.CheckedChanged
        CountTotal()
    End Sub

    Private Sub ModelTxt_EditValueChanged(sender As Object, e As EventArgs) Handles ModelTxt.EditValueChanged
        ModelColl = UOW.Query(Of UnitModelModel)
        If Not IsDBNull(ModelTxt.EditValue) Then
            TextEdit1.Text = (From m In ModelColl
                              Where m.Id = ModelTxt.EditValue.ToString
                              Select m).First.Tipe

            TextEdit2.Text = (From m In ModelColl
                              Where m.Id = ModelTxt.EditValue.ToString
                              Select m).First.Transmisi
        Else
            TextEdit1.Text = ""
            TextEdit2.Text = ""
        End If

    End Sub

    Sub CountDetail()
        TotalDetailTxt.EditValue = NilaiPembelianDetTxt.EditValue - PotonganDetailTxt.EditValue
    End Sub

    Private Sub PembelianBS_PositionChanged(sender As Object, e As EventArgs) Handles PembelianBS.PositionChanged
        DetailColl = UOW.Query(Of UnitPurchaseDetailModel)
        Dim p As UnitPurchaseModel = PembelianBS.Current
        Dim filterC As BinaryOperator = New BinaryOperator("Pembelian", p)
        PembelianDetailXP.Filter = filterC
    End Sub

    Private Sub TambahDetailBtn_Click(sender As Object, e As EventArgs) Handles TambahDetailBtn.Click
        PembelianDetailBS.AddNew()
    End Sub

    Private Sub SimpanDetailBtn_Click(sender As Object, e As EventArgs) Handles SimpanDetailBtn.Click
        Dim P As UnitPurchaseModel = PembelianBS.Current
        Dim pd As UnitPurchaseDetailModel = PembelianDetailBS.Current
        pd.CreatedAt = DateAndTime.Now
        pd.CreatedBy = UserAkses.User.Id
        pd.Pembelian = P
        PembelianDetailXP.Add(pd)
        UOW.CommitChanges()
        PembelianDetailBS.EndEdit()

        P = PembelianBS.Current
        P.Nilai = P.Nilai + pd.Total
        P.Dpp = P.Nilai - P.Potongan
        P.Ppn = P.Dpp / 10
        P.Total = P.Dpp + P.Ppn
        P.Save()
        PembelianXP.Add(P)
        UOW.CommitChanges()
        PembelianBS.EndEdit()
    End Sub

    Private Sub BatalDetailBtn_Click(sender As Object, e As EventArgs) Handles BatalDetailBtn.Click
        PembelianDetailBS.CancelEdit()
    End Sub

    Private Sub HapusDetailBtn_Click(sender As Object, e As EventArgs) Handles HapusDetailBtn.Click
        Dim pd As UnitPurchaseDetailModel = PembelianDetailBS.Current
        PembelianDetailXP.Remove(pd)
        UOW.CommitChanges()
        PembelianDetailBS.EndEdit()

        Dim p As UnitPurchaseModel = PembelianBS.Current
        p.Nilai = p.Nilai - pd.Total
        p.Dpp = p.Nilai - p.Potongan
        p.Ppn = p.Dpp / 10
        p.Total = p.Dpp + p.Ppn
        p.Save()
        PembelianXP.Add(p)
        UOW.CommitChanges()
        PembelianDetailBS.EndEdit()
    End Sub

    Private Sub NilaiPembelianDetTxt_EditValueChanged(sender As Object, e As EventArgs) Handles NilaiPembelianDetTxt.EditValueChanged
        CountDetail()
    End Sub

    Private Sub PotonganDetailTxt_EditValueChanged(sender As Object, e As EventArgs) Handles PotonganDetailTxt.EditValueChanged
        CountDetail()
    End Sub
End Class