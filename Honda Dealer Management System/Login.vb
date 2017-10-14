Imports DevExpress.Xpo
Imports System.Linq
Imports System.Linq.Expressions
Imports Honda_Dealer_Management_System.HDMS
Public Class Login

    Dim Users As XPQuery(Of UserModel)
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
        Users = UOW.Query(Of UserModel)()
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub

    Private Sub Masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click
        If Not validator.Validate() Then
            Exit Sub
        End If

        Dim User = From u In Users
                   Where u.Username = username.Text And u.Password = password.Text
                   Select u

        If User.Count < 1 Then
            MsgBox("Username atau Password tidak Valid", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If User.Count > 1 Then
            MsgBox("Duplicate Username, silahkan hubungi System Administrator", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If User.Count = 1 Then
            UserAkses.User = User.First
            GroupControl1.Enabled = True
            username.Enabled = False
            password.Enabled = False
            masuk.Enabled = False
            CekMenu()
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

    Private Sub GeneralModule_Click(sender As Object, e As EventArgs) Handles GeneralModule.Click
        GeneralModuleMDI.Show()
        GeneralModuleMDI.Focus()
    End Sub

    Private Sub ServiceModul_Click(sender As Object, e As EventArgs) Handles ServiceModul.Click
        'coba lagi
    End Sub
End Class
