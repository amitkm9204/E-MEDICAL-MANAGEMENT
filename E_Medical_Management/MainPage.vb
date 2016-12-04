Public Class MainPage

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginPage.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Diagnosis.Click
        DiagnosisMainPage.Show()
        Me.Hide()
    End Sub

    Private Sub Laboratories_Click(sender As Object, e As EventArgs) Handles Laboratories.Click
        Laboratory.Show()
        Me.Hide()
    End Sub

    Private Sub MedicalStore_Click(sender As Object, e As EventArgs) Handles MedicalStore.Click
        MedicalStoreMainPage.Show()
        Me.Hide()
    End Sub
End Class