Imports System.Data.SqlClient

Public Class LoginPage
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim connection As New SqlConnection("Server=ROCK;Database =Login; Integrated Security = true")
        Dim command As New SqlCommand("select * from LoginDetails where LoginId = @LoginId and Password = @password", connection)

        command.Parameters.Add("@LoginId", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MsgBox("Invalid username or password")
        Else
            MainPage.Show()
        End If
        'MainPage.Show()
    End Sub

    Private Sub SignButton_Click(sender As Object, e As EventArgs) Handles SignButton.Click
        FormFill.Show()
    End Sub

End Class
