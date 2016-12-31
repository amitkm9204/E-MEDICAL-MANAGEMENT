Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data

Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim i As Integer
        Dim cnn As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
        cnn.Open()
        If txtAge.Text = "" Or txtName.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Or txtSex.Text = "" Or txtUserId.Text = "" Then
            MsgBox("Fill all the Informatio")
            txtPhone.Text = ""
            txtSex.Text = ""
            txtUserId.Text = ""
            txtAge.Text = ""
            txtName.Text = ""
            txtPassword.Text = ""
        Else
            Using cmd As New Data.SqlClient.SqlCommand("insert into SignUpPage(UserId,Name,Sex,Age,Phone,Password) values('" & txtUserId.Text & "','" & txtName.Text & "','" & txtSex.Text & "','" & txtAge.Text & "','" & txtPhone.Text & "','" & txtPassword.Text & "')", cnn)
            i = cmd.ExecuteNonQuery
        End Using
        If (i > 0) Then
            MsgBox("Sign Up sucessful!!")
            StartPage.Show()
                Me.Close()
            End If
        End If
            cnn.Close()
    End Sub
End Class