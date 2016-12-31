Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class Diagnosis
    Public gen As New DataTable()
    Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub Diagnosis_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Public Sub Diagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName1.Text = StartPage.str.ToString()
    End Sub

    Public Sub llGeneralPhysician_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGeneralPhysician.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "GENERAL PHYSICIAN"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "GEN"
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

    Private Sub llENTSpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llENTSpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "ENT SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "ENT"
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

    Private Sub llEyeSpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llEyeSpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "EYE SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "EYE"
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

    Private Sub llBoneSpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llBoneSpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "BONE SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "BONE"
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

    Private Sub lleethSpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llteethSpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "TEETH SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "TEETH"
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

    Private Sub llAllegySpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAllegySpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "ALLERGY SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "ALLERGY"
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

    Private Sub llHeartSpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llHeartSpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "HEART SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "HEART"
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

    Private Sub llNeuroSpecialists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNeuroSpecialists.LinkClicked
        gen.Clear()
        cnn.Open()
        Dispaly.grpDetails.Text = "NEURO SPECIALISTS"
        Dim cmd As New SqlCommand("select * from diagnosis where TYPE=@name", cnn)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "NEURO"
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