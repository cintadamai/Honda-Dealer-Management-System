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
            CekMenu()
        End If
    End Sub

    Sub CekMenu()

    End Sub

End Class
