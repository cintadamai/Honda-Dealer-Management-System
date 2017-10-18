Imports DevOne.Security.Cryptography.BCrypt
Public Class Hashing
    Public Function GenerateSalt()
        Return BCryptHelper.GenerateSalt(12)
    End Function

    Public Function HashPassword(pass As String)
        Return BCryptHelper.HashPassword(pass, GenerateSalt)
    End Function

    Public Function ValidatePass(pass As String, hashed As String)
        Return BCryptHelper.CheckPassword(pass, hashed)
    End Function
End Class
