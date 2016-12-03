Public Class MainPage

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginPage.Hide()
    End Sub

    Private Sub Diagnosis_Click(sender As Object, e As EventArgs)
        DiagnosisMainPage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class