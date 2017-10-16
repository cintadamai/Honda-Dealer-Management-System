Imports Honda_Dealer_Management_System.HDMS
Imports DevExpress.Xpo

Public Class JabatanForm

    Dim DivisiColl As XPQuery(Of DivisiModel)
    Private Sub JabatanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DivisiColl = UOW.Query(Of DivisiModel)
        ViewState()
    End Sub

    Sub ViewState()
        TambahBtn.Enabled = True
        SimpanBtn.Enabled = False
        BatalBtn.Enabled = False
        PrintBtn.Enabled = False
        EditBtn.Enabled = True
        HapusBtn.Enabled = True

        idTxt.Properties.ReadOnly = True
        DivisiNameTxt.Properties.ReadOnly = True
        JabatanTxt.Properties.ReadOnly = True
    End Sub

    Sub EditState()
        TambahBtn.Enabled = False
        SimpanBtn.Enabled = True
        BatalBtn.Enabled = True
        PrintBtn.Enabled = False
        EditBtn.Enabled = False
        HapusBtn.Enabled = False

        DivisiNameTxt.Properties.ReadOnly = False
        JabatanTxt.Properties.ReadOnly = False
    End Sub

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        JabatanBS.AddNew()
        EditState()
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As EventArgs) Handles BatalBtn.Click
        JabatanBS.CancelEdit()
        ViewState()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        Dim jbtn As JabatanModel = JabatanBS.Current
        jbtn.Divisi = (From d In DivisiColl
                       Where d.DivisiName = DivisiNameTxt.EditValue.ToString()
                       Select d).First
        JabatanXpCollection.Add(jbtn)
        UOW.CommitChanges()

        ViewState()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditState()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        Dim ask = MessageBox.Show("Yakin Hapus Data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.Yes Then
            Dim jbtn As JabatanModel = JabatanBS.Current
            JabatanXpCollection.Remove(jbtn)
            UOW.CommitChanges()
            ViewState()
        End If
    End Sub
End Class