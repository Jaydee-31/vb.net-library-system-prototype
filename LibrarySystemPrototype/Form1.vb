Imports System.Data.SqlClient

Public Class frmLogin

    Public ID As String = Nothing
    Public last As String = Nothing
    Public given As String = Nothing
    Public middle As String = Nothing
    Public type As String = Nothing
    Public course As String = Nothing
    Public address As String = Nothing

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        OpenConnection()
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection
        sql = "SELECT * FROM tblUsers WHERE type = 'Admin'"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        If dr.HasRows = False Then
            dr.Close()
            txtID.Text = Nothing
            txtPassword.Text = Nothing

            frmAdminAdd.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        OpenConnection()
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection
        sql = "SELECT * FROM tblUsers WHERE idNumber = '" & txtID.Text & "' AND password = CONVERT(VARCHAR(50),HashBytes('MD5','" & txtPassword.Text & "'),2)"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        If dr.HasRows = False Then
            dr.Close()
            MsgBox("Invalid Student ID or Password")
            txtPassword.Text = Nothing
        ElseIf dr.HasRows Then

            dr.Close()

            txtID.Text = Nothing
            txtPassword.Text = Nothing

            dr.Close()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            type = table.Rows(0)(4).ToString()

            If type = "Former Student/Faculty" Then

                MsgBox("A Former Student or Faculty Can't Log In")

            ElseIf type = "Admin" Or type = "Librarian" Then

                ID = table.Rows(0)(0).ToString()
                last = table.Rows(0)(1).ToString()
                given = table.Rows(0)(2).ToString()
                middle = table.Rows(0)(3).ToString()
                type = table.Rows(0)(4).ToString()
                course = table.Rows(0)(5).ToString()
                address = table.Rows(0)(6).ToString()

                frmBody.Show()
                Me.Hide()

            ElseIf type = "Student" Or type = "Faculty" Then

                MsgBox("Hi User")

            End If

        Else
            dr.Close()
            MsgBox("Error")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        txtID.Text = Nothing
        txtPassword.Text = Nothing

        frmAddPatron.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtID.Clear()

        txtPassword.Clear()

    End Sub

End Class
