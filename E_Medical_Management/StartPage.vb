Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class StartPage
    Public Property str As String

    Private Sub llSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSignUp.LinkClicked
        SignUp.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
        connection.Open()
        Dim command As New SqlCommand("select * from SignUpPage where UserId = '" & txtUser.Text & "' and Password = '" & txtPassword.Text & "'", connection)
            Dim adpater As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adpater.Fill(table)
        If table.Rows.Count() <= 0 Then
            If txtPassword.Text = "" Or txtUser.Text = "" Then
                MsgBox("Invalid Input")
                txtPassword.Text = ""
                txtUser.Text = ""
            End If
        Else
            lblName.Text = table.Rows(0)(1).ToString()
            str = lblName.Text
            GrpBx.Visible = False
            btnLaboratories.Visible = True
            btnDiagnosis.Visible = True
            btnMedicalStore.Visible = True
            llLogOut.Visible = True
            llAdministrator.Visible = False
        End If
        Str = lblName.Text
        connection.Close()
    End Sub
    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        ForgotPassword.Show()
    End Sub

    Private Sub StartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLaboratories.Visible = False
        btnDiagnosis.Visible = False
        btnMedicalStore.Visible = False
        llLogOut.Visible = False
    End Sub

    Private Sub btnDiagnosis_Click(sender As Object, e As EventArgs) Handles btnDiagnosis.Click
        Me.Hide()
        Diagnosis.Show()
    End Sub

    Private Sub btnLaboratories_Click(sender As Object, e As EventArgs) Handles btnLaboratories.Click
        Me.Hide()
        Laboratories.Show()
    End Sub

    Private Sub btnMedicalStore_Click(sender As Object, e As EventArgs) Handles btnMedicalStore.Click
        Me.Hide()
        MedicalStore.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLogOut.LinkClicked
        GrpBx.Visible = True
        btnLaboratories.Visible = False
        btnDiagnosis.Visible = False
        btnMedicalStore.Visible = False
        lblName.Text = ""
        txtPassword.Text = ""
        txtUser.Text = ""
        llLogOut.Visible = False
        llAdministrator.Visible = True
    End Sub

    Private Sub llAdministrator_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAdministrator.LinkClicked
        Me.Hide()
        AdministratorPage.txtUser.Text = ""
        AdministratorPage.txtPassword.Text = ""
        AdministratorPage.Show()
        AdministratorPage.GrpBx.Visible = True
        AdministratorPage.llLogOut.Visible = False
        AdministratorPage.lblName.Text = ""
        AdministratorPage.llMedicalStore.Visible = False
        AdministratorPage.llAyurvedicStore.Visible = False
        AdministratorPage.llHomeopathicStore.Visible = False
        AdministratorPage.llAllopathicStore.Visible = False
        AdministratorPage.llLaboratories.Visible = False
        AdministratorPage.llDiagnosis.Visible = False
        AdministratorPage.llUsersDetails.Visible = False
        AdministratorPage.llAdministrators.Visible = False

    End Sub
End Class