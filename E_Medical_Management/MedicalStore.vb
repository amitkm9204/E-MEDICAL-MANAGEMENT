Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class MedicalStore
    Public gen As New DataTable()
    Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub MedicalStore_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub MedicalStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName1.Text = StartPage.str.ToString()
    End Sub

    Private Sub btnAllopathic_Click(sender As Object, e As EventArgs) Handles btnAllopathic.Click
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "ALLOPATHIC STORES"
        Dim cmd As New SqlCommand("select * from Allopathic", cnn)
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
    End Sub

    Private Sub llXRay_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llallopatic.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "ALLOPATHIC STORES"
        Dim cmd As New SqlCommand("select * from Allopathic", cnn)
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
    End Sub

    Private Sub btnHomeopathic_Click(sender As Object, e As EventArgs) Handles btnHomeopathic.Click
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "HOMEOPATHIC STORE"
        Dim cmd As New SqlCommand("select * from Homeopathy", cnn)
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1

            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llHomeopathic.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "HOMEOPATHIC STORE"
        Dim cmd As New SqlCommand("select * from Homeopathy", cnn)
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
    End Sub

    Private Sub btnAyurvedic_Click(sender As Object, e As EventArgs) Handles btnAyurvedic.Click
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "AYURVEDIC STORE"
        Dim cmd As New SqlCommand("select * from Ayurvadic", cnn)
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAyurvedic.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "AYURVEDIC STORE"
        Dim cmd As New SqlCommand("select * from Ayurvadic", cnn)
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
    End Sub

    Private Sub llLogOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLogOut.LinkClicked
        StartPage.GrpBx.Visible = True
        StartPage.btnLaboratories.Visible = False
        StartPage.btnDiagnosis.Visible = False
        StartPage.btnMedicalStore.Visible = False
        StartPage.lblName.Text = ""
        StartPage.txtPassword.Text = ""
        StartPage.txtUser.Text = ""
        StartPage.llLogOut.Visible = False
        StartPage.llAdministrator.Visible = True
        Me.Hide()
        StartPage.Show()
    End Sub
End Class