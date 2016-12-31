Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class Laboratories
    Public gen As New DataTable()
    Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub Laboratories_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Laboratories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName1.Text = StartPage.str.ToString()
        llBloodTest.Visible = False
        llSugarTest.Visible = False
        llUrineTest.Visible = False

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        llBloodTest.Visible = True
        llSugarTest.Visible = True
        llUrineTest.Visible = True
    End Sub

    Private Sub llXRay_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llXRay.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "X-RAY"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "X-Ray"
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
        llBloodTest.Visible = False
        llSugarTest.Visible = False
        llUrineTest.Visible = False
    End Sub

    Private Sub llMRIScan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llMRIScan.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "MRI SCAN LAB"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "MRI"
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
        llBloodTest.Visible = False
        llSugarTest.Visible = False
        llUrineTest.Visible = False
    End Sub

    Private Sub llUltraSound_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llUltraSound.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "ULTRA SOUND LAB"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "Ultrasound"
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
        llBloodTest.Visible = False
        llSugarTest.Visible = False
        llUrineTest.Visible = False
    End Sub

    Private Sub llECGScan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llECGScan.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "ECG SCAN LAB"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "ECG"
        Dim pd As New SqlDataAdapter(cmd)
        pd.Fill(gen)
        For i = 0 To gen.Rows.Count - 1
            Dispaly.lstName.Items.Add(gen.Rows(i)(1).ToString)
            Dispaly.lstName.Items.Add(vbNewLine)
        Next
        Dispaly.result(gen)
        Dispaly.Show()
        cnn.Close()
        llBloodTest.Visible = False
        llSugarTest.Visible = False
        llUrineTest.Visible = False
    End Sub

    Private Sub llUrineTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llUrineTest.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "URINE TEST LAB"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "Urine Test"
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

    Private Sub llBloodTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llBloodTest.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "BLOOD TEST LAB"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "Blood Test"
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

    Private Sub llSugarTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSugarTest.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "SUGAR TEST LAB"
        Dim cmd As New SqlCommand("select * from Laboratories where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "Sugar Test"
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