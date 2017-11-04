Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class InputReturPembelianForm
    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        ReturBS.AddNew()
        HeaderEditState()
        PPNCheckEdit.Checked = True
    End Sub

    Sub HeaderEditState()
        SupplierTxt.ReadOnly = False
        TanggalReturPembelianTxt.ReadOnly = False
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
        TanggalReturPembelianTxt.ReadOnly = True
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
        ReturBS.CancelEdit()
        HeaderViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        HeaderEditState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If Not HeaderValidator.Validate Then
            Exit Sub
        End If

        Dim r As UnitPurchaseReturnModel = ReturBS.Current
        If r.Id = vbNull Or r.Id = 0 Then
            r.CreatedAt = DateAndTime.Now
            r.CreatedBy = UserAkses.User.Id
        End If
        r.UpdatedAt = DateAndTime.Now
        r.UpdatedBy = UserAkses.User.Id
        r.Nilai = NilaiTxt.EditValue
        r.Dpp = DppTxt.EditValue
        r.Ppn = PPNtxt.EditValue
        r.Total = TotalTxt.EditValue
        ReturXP.Add(r)
        UOW.CommitChanges()
        ReturBS.EndEdit()

        HeaderViewState()
    End Sub

    Sub CountTotal()
        Dim DetailColl As XPQuery(Of UnitPurchaseReturnDetailsModel)
        DetailColl = UOW.Query(Of UnitPurchaseReturnDetailsModel)
        Dim p As UnitPurchaseModel = ReturBS.Current

        If Not IsDBNull(p.Id) Then
            NilaiTxt.EditValue = (From d In DetailColl
                                  Where d.Retur.Id = p.Id
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

    Private Sub ReturBS_CurrentChanged(sender As Object, e As EventArgs) Handles ReturBS.CurrentChanged

    End Sub

    Private Sub ReturBS_PositionChanged(sender As Object, e As EventArgs) Handles ReturBS.PositionChanged
        Dim DetailColl As XPQuery(Of UnitPurchaseReturnDetailsModel)
        DetailColl = UOW.Query(Of UnitPurchaseReturnDetailsModel)
        Dim p As UnitPurchaseModel = ReturBS.Current
        Dim filterC As BinaryOperator = New BinaryOperator("Retur", p)
        DetailXP.Filter = filterC
    End Sub

    Private Sub InputReturPembelianForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HeaderViewState()
        Dim DetailColl As XPQuery(Of UnitPurchaseReturnDetailsModel)
        DetailColl = UOW.Query(Of UnitPurchaseReturnDetailsModel)
        Dim p As UnitPurchaseModel = ReturBS.Current
        Dim filterC As BinaryOperator = New BinaryOperator("Retur", p)
        DetailXP.Filter = filterC
    End Sub

    Private Sub TambahDetailBtn_Click(sender As Object, e As EventArgs) Handles TambahDetailBtn.Click
        DetailBS.AddNew()
    End Sub

    Private Sub SimpanDetailBtn_Click(sender As Object, e As EventArgs) Handles SimpanDetailBtn.Click
        Dim P As UnitPurchaseReturnModel = ReturBS.Current
        Dim pd As UnitPurchaseReturnDetailsModel = DetailBS.Current
        pd.CreatedAt = DateAndTime.Now
        pd.CreatedBy = UserAkses.User.Id
        pd.Retur = P
        DetailXP.Add(pd)
        UOW.CommitChanges()
        DetailBS.EndEdit()

        Dim total As Long = 0
        For Each d As UnitPurchaseReturnDetailsModel In DetailXP
            total += d.Total
        Next

        P = ReturBS.Current
        P.Nilai = total
        P.Dpp = P.Nilai - P.Potongan
        P.Ppn = P.Dpp / 10
        P.Total = P.Dpp + P.Ppn
        P.Save()
        ReturXP.Add(P)
        UOW.CommitChanges()
        ReturBS.EndEdit()
    End Sub

    Private Sub BatalDetailBtn_Click(sender As Object, e As EventArgs) Handles BatalDetailBtn.Click
        DetailBS.CancelEdit()
    End Sub

    Private Sub HapusDetailBtn_Click(sender As Object, e As EventArgs) Handles HapusDetailBtn.Click
        Dim pd As UnitPurchaseReturnModel = ReturBS.Current
        ReturXP.Remove(pd)
        UOW.CommitChanges()
        ReturBS.EndEdit()

        Dim total As Long = 0
        For Each d As UnitPurchaseReturnDetailsModel In DetailXP
            total += d.Total
        Next

        Dim p As UnitPurchaseModel = ReturBS.Current
        p.Nilai = total
        p.Dpp = p.Nilai - p.Potongan
        p.Ppn = p.Dpp / 10
        p.Total = p.Dpp + p.Ppn
        p.Save()
        ReturXP.Add(p)
        UOW.CommitChanges()
        DetailBS.EndEdit()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Apakah anda yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim r As UnitPurchaseReturnModel = ReturBS.Current
            ReturXP.Remove(r)
            UOW.CommitChanges()

            ReturBS.EndEdit()
            HeaderViewState()
        End If
    End Sub
End Class