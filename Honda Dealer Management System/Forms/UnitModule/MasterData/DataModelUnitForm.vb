Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Xpo

Public Class DataModelUnitForm

    Dim UAMoColl As XPQuery(Of UnitAccessoryModelModel)
    Private Sub DataModelUnitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
        RefreshGrid()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True
        TambahAccBtn.Enabled = False
        HapusAccBtn.Enabled = False

        idTxt.ReadOnly = True
        ModelTxt.ReadOnly = True
        TipeTxt.ReadOnly = True
        TransmisiTxt.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False
        TambahAccBtn.Enabled = True
        HapusAccBtn.Enabled = True

        ModelTxt.ReadOnly = False
        TipeTxt.ReadOnly = False
        TransmisiTxt.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        UnitModelBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        UnitModelBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim m As UnitModelModel = UnitModelBS.Current
        UnitModelXP.Add(m)
        UOW.CommitChanges()
        UnitModelBS.EndEdit()

        ViewState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin Ingin Hapus Data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim m As UnitModelModel = UnitModelBS.Current
            UnitModelXP.Remove(m)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub

    Private Sub TambahAccBtn_Click(sender As Object, e As EventArgs) Handles TambahAccBtn.Click
        Dim u As UnitModelModel = UnitModelBS.Current
        Dim UAMo As New UnitAccessoryModelModel(UOW) With {
            .AccId = idAccTxt.EditValue,
            .UnitId = u
        }
        u.UnitAccessoryModels.Add(UAMo)
        UOW.CommitChanges()

        RefreshGrid()
    End Sub

    Private Sub HapusAccBtn_Click(sender As Object, e As EventArgs) Handles HapusAccBtn.Click
        Dim UAMo As UnitAccessoryModelModel = UAccMoBS.Current
        UOW.Delete(UAMo)
        UOW.CommitChanges()

        RefreshGrid()
    End Sub

    Sub RefreshGrid()
        UAMoColl = UOW.Query(Of UnitAccessoryModelModel)()
        Dim u As UnitModelModel = UnitModelBS.Current
        Dim Result = From i In UAMoColl
                     Where i.UnitId.Id = u.Id
                     Select i

        GridControl2.DataSource = Result
    End Sub

    Private Sub UnitModelBS_PositionChanged(sender As Object, e As EventArgs) Handles UnitModelBS.PositionChanged
        RefreshGrid()
    End Sub

    Private Sub idTxt_EditValueChanged(sender As Object, e As EventArgs) Handles idTxt.EditValueChanged

    End Sub

    Private Sub idTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles idTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ModelTxt.Focus()
        End If
    End Sub

    Private Sub ModelTxt_EditValueChanged(sender As Object, e As EventArgs) Handles ModelTxt.EditValueChanged

    End Sub

    Private Sub ModelTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles ModelTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            TipeTxt.Focus()
        End If
    End Sub

    Private Sub TipeTxt_EditValueChanged(sender As Object, e As EventArgs) Handles TipeTxt.EditValueChanged

    End Sub

    Private Sub TipeTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles TipeTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            TransmisiTxt.Focus()
        End If
    End Sub

    Private Sub TransmisiTxt_EditValueChanged(sender As Object, e As EventArgs) Handles TransmisiTxt.EditValueChanged

    End Sub

    Private Sub TransmisiTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles TransmisiTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            idAccTxt.Focus()
        End If
    End Sub
End Class