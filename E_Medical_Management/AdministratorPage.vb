Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class AdministratorPage
    Public Property str1 As String
    Public Property TName As String
    Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
    Private Sub AdministratorPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        cnn.Open()
        Dim command As New SqlCommand("select * from SignUpPage where UserId = '" & txtUser.Text & "' and Password = '" & txtPassword.Text & "'", cnn)
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
            str1 = lblName.Text
            GrpBx.Visible = False
            llAdministrators.Visible = True
            llAllopathicStore.Visible = False
            llAyurvedicStore.Visible = False
            llDiagnosis.Visible = True
            llHomeopathicStore.Visible = False
            llLaboratories.Visible = True
            llLogOut.Visible = True
            llMedicalStore.Visible = True
            llUsersDetails.Visible = True

        End If
        Str1 = lblName.Text
        cnn.Close()
    End Sub

    Private Sub llLogOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLogOut.LinkClicked
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub llMedicalStore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llMedicalStore.LinkClicked
        llHomeopathicStore.Visible = True
        llAllopathicStore.Visible = True
        llAyurvedicStore.Visible = True

    End Sub

    Private Sub llLaboratories_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLaboratories.LinkClicked
        TName = "Laboratories"
        Dim cmd As New SqlCommand("select * from Laboratories", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.lbl1.Text = "TYPE"
        TableUpdate.txt1.Width = 391
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        llHomeopathicStore.Visible = False
        llAllopathicStore.Visible = False
        llAyurvedicStore.Visible = False
        TableUpdate.lbl6.Visible = False
        TableUpdate.txt6.Visible = False
        TableUpdate.lblTableName.Text = "LABORATORIES TABLE"
    End Sub

    Private Sub llDiagnosis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llDiagnosis.LinkClicked
        TName = "diagnosis"
        Dim cmd As New SqlCommand("select * from diagnosis", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.lbl1.Text = "TYPE"
        TableUpdate.txt1.Width = 391
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        llHomeopathicStore.Visible = False
        llAllopathicStore.Visible = False
        llAyurvedicStore.Visible = False
        TableUpdate.lbl6.Visible = False
        TableUpdate.txt6.Visible = False
        TableUpdate.lblTableName.Text = "DIAGNOSIS TABLE"
    End Sub

    Private Sub llUsersDetails_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llUsersDetails.LinkClicked
        TName = "SignUpPage"
        Dim cmd As New SqlCommand("select * from SignUpPage", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        llHomeopathicStore.Visible = False
        llAllopathicStore.Visible = False
        llAyurvedicStore.Visible = False
        TableUpdate.lbl1.Text = "USER ID"
        TableUpdate.lbl2.Text = "USER NAME"
        TableUpdate.lbl3.Text = "SEX"
        TableUpdate.lbl4.Text = "AGE"
        TableUpdate.lbl5.Text = "PHONE"
        TableUpdate.txt1.Width = 391
        TableUpdate.txt3.Width = 99
        TableUpdate.txt4.Width = 99
        TableUpdate.lblTableName.Text = "USERS DETAILS"
    End Sub

    Private Sub llAdministrators_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAdministrators.LinkClicked
        TName = "administrator"
        Dim cmd As New SqlCommand("select * from administrator", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        llHomeopathicStore.Visible = False
        llAllopathicStore.Visible = False
        llAyurvedicStore.Visible = False
        TableUpdate.lbl4.Visible = False
        TableUpdate.txt4.Visible = False
        TableUpdate.lbl5.Visible = False
        TableUpdate.txt5.Visible = False
        TableUpdate.lbl6.Visible = False
        TableUpdate.txt6.Visible = False
        TableUpdate.lbl1.Text = "USER ID"
        TableUpdate.lbl2.Text = "USER NAME"
        TableUpdate.lbl3.Text = "PASSWORD"
        TableUpdate.txt1.Width = 391
        TableUpdate.txt2.Width = 391
        TableUpdate.txt3.Width = 391
        TableUpdate.lblTableName.Text = "ADMINISTRATOR TABLE"
    End Sub

    Private Sub llAllopathicStore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAllopathicStore.LinkClicked
        TName = "Allopathic"
        Dim cmd As New SqlCommand("select * from Allopathic", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.lblTableName.Text = "ALLOPATHIC STORE TABLE"
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        TableUpdate.lbl6.Visible = False
        TableUpdate.txt6.Visible = False
    End Sub

    Private Sub llAyurvedicStore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAyurvedicStore.LinkClicked
        TName = "Ayurvadic"
        Dim cmd As New SqlCommand("select * from Ayurvadic", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.lblTableName.Text = "AYURVEDIC STORE TABLE"
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        TableUpdate.lbl6.Visible = False
        TableUpdate.txt6.Visible = False
    End Sub

    Private Sub llHomeopathicStore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llHomeopathicStore.LinkClicked
        TName = "Homeopathy"
        Dim cmd As New SqlCommand("select * from Homeopathy", cnn)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        ad.Fill(table)
        TableUpdate.dgv.DataSource = table
        TableUpdate.lblTableName.Text = "HOMEOPATHIC STORE TABLE"
        TableUpdate.Show()
        Me.Hide()
        TableUpdate.lblName.Text = str1
        TableUpdate.lbl6.Visible = False
        TableUpdate.txt6.Visible = False
    End Sub
End Class