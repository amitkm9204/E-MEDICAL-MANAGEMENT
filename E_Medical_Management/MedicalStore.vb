Imports System.Data.SqlClient
Public Class MedicalStoreMainPage
    Public sn As Integer = 0

    Private Sub AlloPathy_Click(sender As Object, e As EventArgs) Handles AlloPathy.Click
        Dim connection As New SqlConnection("Server=ROCK;Database =Login; Integrated Security = true")
        Dim command As New SqlCommand("select S_name ,Address ,Phone_No,Start_Time,End_Time  from AllopathicStore where Sl_No = @Sl_No", connection)

        command.Parameters.Add("@Sl_No", SqlDbType.Int).Value = sn Mod 5 + 1

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader
        Dim table As New DataTable()

        Dim name As String = ""
        Dim address As String = ""
        Dim phone As String = ""
        Dim st As String = ""
        Dim et As String = ""
        With reader
            .Read()

            name = .GetValue(0)
            address = .GetValue(1)
            phone = .GetValue(2)
            st = .GetValue(3)
            et = .GetValue(4)
            .Close()
        End With
        connection.Close()

        Display.DisplayText.Text = name + vbNewLine + address + vbNewLine + phone
        Display.Timing.Text = "Timing  " + st + "AM - " + et + "PM"
        Display.Show()
        Me.Hide()
    End Sub

    Private Sub HomoPathy_Click(sender As Object, e As EventArgs) Handles HomoPathy.Click
        Dim connection As New SqlConnection("Server=ROCK;Database =Login; Integrated Security = true")
        Dim command As New SqlCommand("select S_name ,Address ,Phone_No ,Start_Time,End_Time from HomeopathicStore where Sl_No = @Sl_No", connection)

        command.Parameters.Add("@Sl_No", SqlDbType.Int).Value = sn Mod 5 + 1

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader
        Dim table As New DataTable()

        Dim name As String = ""
        Dim address As String = ""
        Dim phone As String = ""
        Dim st As String = ""
        Dim et As String = ""
        With reader
            .Read()

            name = .GetValue(0)
            address = .GetValue(1)
            phone = .GetValue(2)
            st = .GetValue(3)
            et = .GetValue(4)
            .Close()
        End With
        connection.Close()

        Display.DisplayText.Text = name + vbNewLine + address + vbNewLine + phone
        Display.Timing.Text = "Timing  " + st + "AM - " + et + "PM"
        Display.Show()
        Me.Hide()
    End Sub

    Private Sub AyurVedic_Click(sender As Object, e As EventArgs) Handles AyurVedic.Click
        Dim connection As New SqlConnection("Server=ROCK;Database =Login; Integrated Security = true")
        Dim command As New SqlCommand("select S_name ,Address ,Phone_No ,Start_Time,End_Time from AyurvadicStore where Sl_No = @Sl_No", connection)

        command.Parameters.Add("@Sl_No", SqlDbType.Int).Value = sn Mod 5 + 1

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader
        Dim table As New DataTable()

        Dim name As String = ""
        Dim address As String = ""
        Dim phone As String = ""
        Dim st As String = ""
        Dim et As String = ""
        With reader
            .Read()

            name = .GetValue(0)
            address = .GetValue(1)
            phone = .GetValue(2)
            st = .GetValue(3)
            et = .GetValue(4)
            .Close()
        End With
        connection.Close()

        Display.DisplayText.Text = name + vbNewLine + address + vbNewLine + phone
        Display.Timing.Text = "Timing  " + st + "AM - " + et + "PM"
        Display.Show()
        Me.Hide()
    End Sub
End Class