Imports System.Data.SqlClient

Public Class frmAdminAdd

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim sql As String = "INSERT INTO tblUsers(idNumber, type, password) VALUES('" & txtID.Text & "', 'Admin', CONVERT(VARCHAR(50),HashBytes('MD5', '" & txtPassword.Text & "'),2))"
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
            MsgBox("Invalid ID")
        Else

            dr.Close()

            If txtID.Text = Nothing Or txtPassword.Text = Nothing Then

                MsgBox("Fields Are Required")

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
                txtPassword.Text = Nothing

                MsgBox("Added Successfully!")

                frmLogin.Show()
                Me.Hide()

            End If

        End If

    End Sub

    Private Sub frmAdminAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub
End Class