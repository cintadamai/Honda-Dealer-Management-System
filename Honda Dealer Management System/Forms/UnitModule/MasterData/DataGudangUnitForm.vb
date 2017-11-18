Imports Honda_Dealer_Management_System.HDMS

Public Class DataGudangUnitForm
    Private Sub DataGudangUnitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        GudangBS.CancelEdit()
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
        NamaTxt.ReadOnly = True
        AlamatTxt.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        NamaTxt.ReadOnly = False
        AlamatTxt.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        GudangBS.AddNew()
        EditState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim g As UnitGudangModel = GudangBS.Current
        GudangXP.Add(g)
        UOW.CommitChanges()

        ViewState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin hapus data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim g As UnitGudangModel = GudangBS.Current
            GudangXP.Remove(g)
            UOW.CommitChanges()

            ViewState()
        End If
    End Sub

    Private Sub idTxt_EditValueChanged(sender As Object, e As EventArgs) Handles idTxt.EditValueChanged

    End Sub

    Private Sub idTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles idTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            NamaTxt.Focus()
        End If
    End Sub

    Private Sub NamaTxt_EditValueChanged(sender As Object, e As EventArgs) Handles NamaTxt.EditValueChanged

    End Sub

    Private Sub NamaTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NamaTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            AlamatTxt.Focus()
        End If
    End Sub
End Class