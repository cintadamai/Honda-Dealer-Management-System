Imports DevExpress.Xpo
Imports Honda_Dealer_Management_System.HDMS
Public Class Login

    Dim Users As XPQuery(Of UserModel)
    Dim hasing As New Hashing
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionHelper.Connect(DB.AutoCreateOption.DatabaseAndSchema)
        XpoDefault.Session = New Session(XpoDefault.DataLayer)
        Users = UOW.Query(Of UserModel)()

        'Users.First.Password = hasing.HashPassword("123")
        'Users.First.Save()
        'UOW.CommitChanges()
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub

    Private Sub Masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click
        If Not validator.Validate() Then
            Exit Sub
        End If

        Dim User = From u In Users
                   Where u.Username = username.Text
                   Select u

        If User.Count < 1 Then
            MsgBox("Username tidak Valid", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If User.Count > 1 Then
            MsgBox("Duplicate Username, silahkan hubungi System Administrator", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If User.Count = 1 Then
            UserAkses.User = User.First
            If hasing.ValidatePass(password.Text, UserAkses.User.Password) Then
                GroupControl1.Enabled = True
                username.Enabled = False
                password.Enabled = False
                masuk.Enabled = False
                CekMenu()
            Else
                MsgBox("Password tidak Valid", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        End If
    End Sub

    Sub CekMenu()
        If UserAkses.HasPermission("GeneralModule") Then
            GeneralModule.Enabled = True
        End If

        If UserAkses.HasPermission("UnitModul") Then
            UnitModul.Enabled = True
        End If

        If UserAkses.HasPermission("SparepartModul") Then
            SparepartModul.Enabled = True
        End If

        If UserAkses.HasPermission("ServiceModul") Then
            ServiceModul.Enabled = True
        End If

        If UserAkses.HasPermission("FinanceModul") Then
            FinanceModul.Enabled = True
        End If

        If UserAkses.HasPermission("TaxModul") Then
            TaxModul.Enabled = True
        End If

        If UserAkses.HasPermission("ITSModul") Then
            ITSModul.Enabled = True
        End If
    End Sub

    Private Sub ITSModul_Click(sender As Object, e As EventArgs) Handles ITSModul.Click

    End Sub

    Private Sub username_KeyDown(sender As Object, e As KeyEventArgs) Handles username.KeyDown
        If e.KeyCode = Keys.Enter Then
            password.Select()
        End If
    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            masuk.PerformClick()
        End If
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        'coba coba
    End Sub

    Private Sub GeneralModule_Click(sender As Object, e As EventArgs) Handles GeneralModule.Click
        GeneralModuleMDI.Show()
        GeneralModuleMDI.Focus()
    End Sub

    Private Sub ServiceModul_Click(sender As Object, e As EventArgs) Handles ServiceModul.Click
        'coba lagi
    End Sub

    Private Sub TaxModul_Click(sender As Object, e As EventArgs) Handles TaxModul.Click
        'coba 3
    End Sub

    Private Sub UnitModul_Click(sender As Object, e As EventArgs) Handles UnitModul.Click
        UnitModuleMDI.Show()
        UnitModuleMDI.Focus()
    End Sub
End Class
