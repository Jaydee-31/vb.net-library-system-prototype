Imports System.Data.SqlClient

Public Class frmAddPatron

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim sql As String = "INSERT INTO tblUsers(idNumber, nameLast, nameGiven, nameMiddle, type, course, address, password) VALUES('" & txtID.Text & "', '" & txtLast.Text & "', '" & txtGiven.Text & "', '" & txtMiddle.Text & "', '" & comboType.Text & "', '" & comboCourse.Text & "', '" & txtAddress.Text & "', CONVERT(VARCHAR(50),HashBytes('MD5', '" & txtID.Text & "'),2))"
        SignUp(sql)

    End Sub

    Private Sub SignUp(ByVal sql As String)

        Dim cmd As New SqlCommand
        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd2 As SqlCommand
        Dim sql2 As String
        cmd2 = New SqlCommand
        cmd2.CommandType = CommandType.Text
        cmd2.Connection = connection

        sql2 = "SELECT * FROM tblUsers WHERE idNumber = '" & txtID.Text & "'"
        cmd2.CommandText = sql2
        dr = cmd2.ExecuteReader()

        If dr.HasRows Then
            dr.Close()
            MsgBox("Student ID Already Registered")
        Else

            dr.Close()

            If frmLogin.type = "Admin" And Not (comboType.Text = "Student" Or comboType.Text = "Faculty" Or comboType.Text = "Former Student/Faculty" Or comboType.Text = "Librarian") Then

                MsgBox("Invalid Type")

            ElseIf frmLogin.type <> "Admin" And Not (comboType.Text = "Student" Or comboType.Text = "Faculty" Or comboType.Text = "Former Student/Faculty") Then

                MsgBox("Invalid Type")

            Else

                If txtID.Text = Nothing Or txtLast.Text = Nothing Or txtGiven.Text = Nothing Or comboType.Text = Nothing Then

                    MsgBox("Bold Fields Are Required")

                Else

                    Try

                        cmd.Connection = connection
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = sql
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        connection.Close()

                    Catch ex As Exception

                        MsgBox("Failed " & ex.ToString)

                    End Try

                    txtID.Text = Nothing
                    txtLast.Text = Nothing
                    txtGiven.Text = Nothing
                    txtMiddle.Text = Nothing
                    comboCourse.Text = Nothing
                    comboType.Text = Nothing
                    txtAddress.Text = Nothing

                    MsgBox("Added Successfully!")

                End If

            End If

        End If

    End Sub

    Private Sub frmRegister_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        txtID.Text = Nothing
        txtLast.Text = Nothing
        txtGiven.Text = Nothing
        txtMiddle.Text = Nothing
        comboCourse.Text = Nothing
        comboType.Text = Nothing

        frmPatrons.Show()
        Me.Hide()

    End Sub

    Private Sub comboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboType.SelectedIndexChanged
        If comboType.Text = "Faculty" Or comboType.Text = "Former Student/Faculty" Or comboType.Text = "Librarian" Then
            comboCourse.Text = Nothing
            comboCourse.Enabled = False
        Else
            comboCourse.Enabled = True
        End If
    End Sub

    Private Sub frmAddPatron_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If frmLogin.type = "Admin" And Not comboType.Items.Contains("Librarian") Then

            comboType.Items.Add("Librarian")

        ElseIf frmLogin.type <> "Admin" And comboType.Items.Contains("Librarian") Then

            comboType.Items.Remove("Librarian")

        End If

    End Sub
End Class