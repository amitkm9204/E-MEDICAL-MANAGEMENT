Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class ForgotPassword
    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        connection.Open()
        Dim i As Integer
        If txtName.Text = "" Or txtPhone.Text = "" Or txtUserId.Text = "" Then
            MsgBox("please enter all the fields")
            txtUserId.Text = ""
            txtPhone.Text = ""
            txtName.Text = ""
        Else
            Using command As New SqlClient.SqlCommand(" SELECT * FROM SignUpPage WHERE UserId='" & txtName.Text & "' and Name = '" & txtUserId.Text & "' and Phone = '" & txtPhone.Text & "'", connection)
                i = command.ExecuteNonQuery
            End Using
            If (i > 0) Then
                MsgBox("Please enter a valid info")
                txtUserId.Text = ""
                txtPhone.Text = ""
                txtName.Text = ""

            Else
                MsgBox("verified")
                Me.Height = 500
                btnVerify.Visible = False
                lblPassword.Visible = True
                lblConfirmPassword.Visible = True
                btnChange.Visible = True
                txtConfirmPassword.Visible = True
                txtPassword.Visible = True
            End If
        End If
        connection.Close()
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 368
        lblPassword.Visible = False
        lblConfirmPassword.Visible = False
        btnChange.Visible = False
        txtConfirmPassword.Visible = False
        txtPassword.Visible = False
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        connection.Open()
        Dim i As Integer
        If txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MsgBox("please enter password")
        Else
            If txtPassword.Text = txtConfirmPassword.Text Then
                Using cmd As New SqlClient.SqlCommand("UPDATE SignUpPage SET Password = '" & txtPassword.Text & "' WHERE UserId = '" & txtUserId.Text & "' and Name = '" & txtName.Text & "' and Phone='" & txtPhone.Text & "'", connection)
                    i = cmd.ExecuteNonQuery
                End Using
                If (i > 0) Then
                    MsgBox("Password has been changed")
                    Me.Close()
                Else
                    MsgBox("Passwords are not matching ")
                    txtPassword.Text = ""
                    txtConfirmPassword.Text = ""
                End If
            End If
        End If
        connection.Close()
    End Sub
End Class