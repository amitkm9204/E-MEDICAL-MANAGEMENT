Public Class Dispaly
    Public Property i As Integer = 0
    Dim test As Integer = 0
    Dim general As New DataTable
    Private Sub Dispaly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName1.Text = StartPage.str.ToString()
    End Sub

    Private Sub Dispaly_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
    End Sub
    Public Sub result(table As DataTable)
        txtName.Text = table.Rows(i)(1).ToString
        txtAddress.Text = table.Rows(i)(2).ToString
        txtPhone.Text = table.Rows(i)(3).ToString
        txtTime.Text = table.Rows(i)(4).ToString
        general = table

    End Sub
    Private Sub lstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstName.SelectedIndexChanged
        i = lstName.SelectedIndex
        i = Math.Floor(i / 2)
        result(general)
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