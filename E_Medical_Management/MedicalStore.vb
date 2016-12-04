Imports System.Data.SqlClient
Public Class MedicalStoreMainPage
    Public sn As Integer = 1

    Private Sub AlloPathy_Click(sender As Object, e As EventArgs) Handles AlloPathy.Click
        Dim connection As New SqlConnection("Server=ROCK;Database =Login; Integrated Security = true")
        Dim command As New SqlCommand("select S_name ,Address ,Phone_No  from AllopathicStores where Sl_No = @Sl_No", connection)

        command.Parameters.Add("@Sl_No", SqlDbType.Int).Value = sn Mod 5 + 1

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader
        Dim table As New DataTable()

        Dim name As String = ""
        Dim address As String = ""
        Dim phone As String = ""
        With reader
            .Read()

            name = .GetValue(0)
            address = .GetValue(1)
            phone = .GetValue(2)
            .Close()
        End With
        connection.Close()

        Display.DisplayText.Text = name + vbNewLine + address + vbNewLine + phone + vbNewLine
        Display.Show()
        Me.Hide()
    End Sub
End Class