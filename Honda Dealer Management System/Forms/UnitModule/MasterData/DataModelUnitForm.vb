Imports Honda_Dealer_Management_System.HDMS

Public Class DataModelUnitForm
    Private Sub DataModelUnitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

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
End Class