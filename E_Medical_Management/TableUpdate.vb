Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Data
Public Class TableUpdate
    Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VISUAL STUDIO\E-MEDICAL-MANAGEMENT\E-MEDICAL MANAGEMENT\Database1.mdf;Integrated Security=True")
    Private Sub llLogOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLogOut.LinkClicked
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub TableUpdate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AdministratorPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        cnn.Open()

        If AdministratorPage.TName = "Laboratories" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt1.Text = "" Or txt2.Text = "" Or txt2.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into Laboratories(TYPE,NAME,ADDRESS,PHONE,TIME) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from Laboratories", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If

        ElseIf AdministratorPage.TName = "Allopathic" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into Allopathic(S.NO,NAME,ADDRESS,PHONE,TIME) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from Allopathic", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "Ayurvadic" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into Ayurvadic(S.NO,NAME,ADDRESS,PHONE,TIME) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from Ayurvadic", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "Homeopathy" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into Homeopathy(S.NO,NAME,ADDRESS,PHONE,TIME) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from Homeopathy", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "diagnosis" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into diagnosis(TYPE,NAME,ADDRESS,PHONE,TIME) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from diagnosis", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "administrator" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into administrator(USERS_ID,USERS_NAME,PASSWORD) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from administrator", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "SignUpPage" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Or txt6.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("insert into SignUpPage(UserId,Name,Sex,Age,Phone,Password) VALUES ( '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "','" & txt6.Text & "')", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("NEW DATA INSERTED")
                End If
                Dim cmd1 As New SqlCommand("select * from SignUpPage", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        End If
        txt3.Clear()
        txt1.Clear()
        txt2.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        cnn.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cnn.Open()

        If AdministratorPage.TName = "Laboratories" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter type and name to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("select * from Laboratories where TYPE='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                    txt4.Text = tb.Rows(0)(3).ToString()
                    txt5.Text = tb.Rows(0)(4).ToString()
                End If
            End If
        ElseIf AdministratorPage.TName = "Allopathic" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter s.no and name to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("select * from Allopathic where S_NO='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                    txt4.Text = tb.Rows(0)(3).ToString()
                    txt5.Text = tb.Rows(0)(4).ToString()
                End If
            End If
        ElseIf AdministratorPage.TName = "Ayurvadic" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter s.no and name to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("select * from Ayurvadic where S_NO='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                    txt4.Text = tb.Rows(0)(3).ToString()
                    txt5.Text = tb.Rows(0)(4).ToString()
                End If
            End If
        ElseIf AdministratorPage.TName = "Homeopathy" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter s.no and name to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("select * from Homeopathy where S_NO='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                    txt4.Text = tb.Rows(0)(3).ToString()
                    txt5.Text = tb.Rows(0)(4).ToString()
                End If
            End If
        ElseIf AdministratorPage.TName = "diagnosis" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter type and name to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("select * from diagnosis where TYPE='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                    txt4.Text = tb.Rows(0)(3).ToString()
                    txt5.Text = tb.Rows(0)(4).ToString()
                End If
            End If
        ElseIf AdministratorPage.TName = "administrator" Then
            If txt1.Text = "" Then
                MsgBox("please enter user_id to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
            Else
                Dim cmd As New SqlCommand("select * from administrator where USERS_ID='" & txt1.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                End If
            End If
        ElseIf AdministratorPage.TName = "SignUpPage" Then
            If txt1.Text = "" Then
                MsgBox("please enter user_id to search record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
                txt6.Clear()
            Else
                Dim cmd As New SqlCommand("select * from SignUpPage where UserId='" & txt1.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    txt1.Text = tb.Rows(0)(0).ToString()
                    txt2.Text = tb.Rows(0)(1).ToString()
                    txt3.Text = tb.Rows(0)(2).ToString()
                    txt4.Text = tb.Rows(0)(3).ToString()
                    txt5.Text = tb.Rows(0)(4).ToString()
                    txt6.Text = tb.Rows(0)(5).ToString()
                End If
            End If
        End If
        cnn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cnn.Open()

        If AdministratorPage.TName = "Laboratories" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt1.Text = "" Or txt2.Text = "" Or txt2.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update Laboratories set ADDRESS='" & txt3.Text & "',PHONE='" & txt4.Text & "',TIME='" & txt5.Text & "' where TYPE='" & txt1.Text & "'and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from Laboratories", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the address, phone number and time")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                    txt4.Clear()
                    txt5.Clear()
                End If
            End If

        ElseIf AdministratorPage.TName = "Allopathic" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update Allopathic set ADDRESS='" & txt3.Text & "',PHONE='" & txt4.Text & "',TIME='" & txt5.Text & "' where S.NO='" & txt1.Text & "'and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from Allopathic", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the address, phone number and time")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                    txt4.Clear()
                    txt5.Clear()
                End If
            End If
        ElseIf AdministratorPage.TName = "Ayurvadic" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update Ayurvadic set ADDRESS='" & txt3.Text & "',PHONE='" & txt4.Text & "',TIME='" & txt5.Text & "' where S.NO='" & txt1.Text & "'and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from Ayurvadic", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the address, phone number and time")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                    txt4.Clear()
                    txt5.Clear()
                End If
            End If
        ElseIf AdministratorPage.TName = "Homeopathy" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update Homeopathy set ADDRESS='" & txt3.Text & "',PHONE='" & txt4.Text & "',TIME='" & txt5.Text & "' where S.NO='" & txt1.Text & "'and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from Homeopathy", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the address, phone number and time")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                    txt4.Clear()
                    txt5.Clear()
                End If
            End If
        ElseIf AdministratorPage.TName = "diagnosis" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update diagnosis set ADDRESS='" & txt3.Text & "',PHONE='" & txt4.Text & "',TIME='" & txt5.Text & "' where TYPE='" & txt1.Text & "'and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from diagnosis", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the address, phone number and time")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                    txt4.Clear()
                    txt5.Clear()
                End If
            End If
        ElseIf AdministratorPage.TName = "administrator" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update administrator set PASSWORD='" & txt3.Text & "' where USERS_ID='" & txt1.Text & "'and USERS_NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from administrator", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the password")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                End If
            End If
        ElseIf AdministratorPage.TName = "SignUpPage" Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Or txt6.Text = "" Then
                MsgBox("please insert all the parameters")
            Else

                Dim cmd As New SqlCommand("update SignUpPage set Age='" & txt4.Text & "',Phone='" & txt5.Text & "',Password='" & txt6.Text & "' where UserId='" & txt1.Text & "' and Name='" & txt2.Text & "' and Sex='" & txt3.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA UPDATED")
                    Dim cmd1 As New SqlCommand("select * from SignUpPage", cnn)
                    Dim ad1 As New SqlDataAdapter(cmd1)
                    Dim table As New DataTable
                    ad1.Fill(table)
                    dgv.DataSource = table
                Else
                    MsgBox("you can only update the age, phone number and password")
                    txt3.Clear()
                    txt1.Clear()
                    txt2.Clear()
                    txt4.Clear()
                    txt5.Clear()
                    txt6.Clear()
                End If
            End If
        End If
        txt3.Clear()
        txt1.Clear()
        txt2.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        cnn.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cnn.Open()

        If AdministratorPage.TName = "Laboratories" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter type and name to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("delete from Laboratories where TYPE='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from Laboratories", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "Allopathic" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter s.no and name to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("delete from Allopathic where S_NO='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from Allopathic", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "Ayurvadic" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter s.no and name to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("delete from Ayurvadic where S_NO='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from Ayurvadic", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "Homeopathy" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter s.no and name to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("delete from Homeopathy where S_NO='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from Homeopathy", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "diagnosis" Then
            If txt1.Text = "" Or txt2.Text = "" Then
                MsgBox("please enter type and name to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
            Else
                Dim cmd As New SqlCommand("delete from diagnosis where TYPE='" & txt1.Text & "' and NAME='" & txt2.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from diagnosis", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "administrator" Then
            If txt1.Text = "" Then
                MsgBox("please enter user_id to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
            Else
                Dim cmd As New SqlCommand("delete from administrator where USERS_ID='" & txt1.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from administrator", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        ElseIf AdministratorPage.TName = "SignUpPage" Then
            If txt1.Text = "" Then
                MsgBox("please enter user_id to delete record")
                txt3.Clear()
                txt1.Clear()
                txt2.Clear()
                txt4.Clear()
                txt5.Clear()
                txt6.Clear()
            Else
                Dim cmd As New SqlCommand("delete from SignUpPage where UserId='" & txt1.Text & "'", cnn)
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count() >= 0 Then
                    MsgBox("DATA DELETED")

                End If
                Dim cmd1 As New SqlCommand("select * from SignUpPage", cnn)
                Dim ad1 As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                ad1.Fill(table)
                dgv.DataSource = table
            End If
        End If
        txt3.Clear()
        txt1.Clear()
        txt2.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        cnn.Close()
    End Sub

    Private Sub btnBak_Click(sender As Object, e As EventArgs) Handles btnBak.Click
        Me.Hide()
        AdministratorPage.Show()
        txt3.Clear()
        txt1.Clear()
        txt2.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
    End Sub
End Class