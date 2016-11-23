Imports System.Data.SqlClient
Public Class FormFill

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server=ROCK;Database =Login; Integrated Security = true")
        Dim command As New SqlCommand("insert into LoginDetails(Name,Phone,Age,Sex,LoginId,Password) values(@name,@phone,@age,@sex,@userid,@password)", connection)

        command.Parameters.Add("@userid", SqlDbType.VarChar).Value = TextBoxUserId.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBoxName.Text
        command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBoxPhone.Text
        command.Parameters.Add("@age", SqlDbType.Int).Value = TextBoxAge.Text
        command.Parameters.Add("@sex", SqlDbType.Char).Value = TextBoxSex.Text

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("SUCCESFULY ADDED")
        End If
    End Sub

    Private Sub FormFill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginPage.Hide()
    End Sub
End Class