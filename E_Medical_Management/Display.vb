Imports E_Medical_Management.MedicalStoreMainPage
Public Class Display
    Dim inc As New MedicalStoreMainPage()
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        inc.sn = inc.sn + 1
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        inc.sn = inc.sn - 1
    End Sub


End Class