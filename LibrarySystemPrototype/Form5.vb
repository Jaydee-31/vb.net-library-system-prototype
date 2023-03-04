Imports System.Data.SqlClient

Public Class frmChangePass
    Private Sub frmChangePass_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql As String = "UPDATE tblUsers SET password = CONVERT(VARCHAR(50),HashBytes('MD5', '" & txtNewPass.Text & "'),2) WHERE idNumber = '" & frmLogin.ID & "'"
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

        sql2 = "SELECT * FROM tblUsers WHERE idNumber = '" & frmLogin.ID & "' AND password = CONVERT(VARCHAR(50),HashBytes('MD5','" & txtCrrntPass.Text & "'),2)"
        cmd2.CommandText = sql2
        dr = cmd2.ExecuteReader()

        If dr.HasRows = False Then
            dr.Close()
            MsgBox("Current Password Incorrect")
            txtCrrntPass.Text = Nothing
            txtNewPass.Text = Nothing
            txtCnfrmPass.Text = Nothing
        ElseIf dr.HasRows Then
            If txtNewPass.Text <> txtCnfrmPass.Text Then
                dr.Close()
                MsgBox("New Password Confirmation Incorrect")
                txtCrrntPass.Text = Nothing
                txtNewPass.Text = Nothing
                txtCnfrmPass.Text = Nothing
            Else
                If txtCrrntPass.Text = txtNewPass.Text Then
                    dr.Close()
                    MsgBox("There's No Password Change")
                    txtCrrntPass.Text = Nothing
                    txtNewPass.Text = Nothing
                    txtCnfrmPass.Text = Nothing
                Else

                    dr.Close()

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

                    txtCrrntPass.Text = Nothing
                    txtNewPass.Text = Nothing
                    txtCnfrmPass.Text = Nothing

                    MsgBox("Password Changed!")

                    frmAccount.Show()
                    Me.Hide()

                End If

            End If

        Else
            MsgBox("Error")
            txtCrrntPass.Text = Nothing
            txtNewPass.Text = Nothing
            txtCnfrmPass.Text = Nothing
        End If

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtCrrntPass.Text = Nothing
        txtNewPass.Text = Nothing
        txtCnfrmPass.Text = Nothing

        frmAccount.Show()
        Me.Hide()
    End Sub

    Private Sub frmChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class