Imports System.Data.SqlClient

Public Class frmEditUser

    Dim edit As String = Nothing

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        edit = Nothing

        frmPatrons.Show()
        Me.Hide()
    End Sub

    Private Sub frmEditUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub frmEditUser_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If frmPatrons.edit <> Nothing Then

            edit = frmPatrons.edit

            Dim cmd As SqlCommand
            Dim sql As String

            OpenConnection()

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblUsers WHERE idNumber = '" & edit & "'"
            cmd.CommandText = sql

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtID.Text = table.Rows(0)(0).ToString()
            txtLast.Text = table.Rows(0)(1).ToString()
            txtGiven.Text = table.Rows(0)(2).ToString()
            txtMiddle.Text = table.Rows(0)(3).ToString()
            comboCourse.Text = table.Rows(0)(5).ToString()
            comboType.Text = table.Rows(0)(4).ToString()
            txtAddress.Text = table.Rows(0)(6).ToString()

            comboType_SelectedIndexChanged(sender, e)

        End If

        frmPatrons.edit = Nothing

        If frmLogin.type = "Admin" And Not comboType.Items.Contains("Librarian") Then

            comboType.Items.Add("Librarian")

        ElseIf frmLogin.type <> "Admin" And comboType.Items.Contains("Librarian") Then

            comboType.Items.Remove("Librarian")

        End If

    End Sub

    Private Sub comboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboType.SelectedIndexChanged

        If comboType.Text = "Faculty" Or comboType.Text = "Former Student/Faculty" Or comboType.Text = "Librarian" Then
            comboCourse.Text = Nothing
            comboCourse.Enabled = False
        Else
            comboCourse.Enabled = True
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Add()
    End Sub

    Private Sub Add()

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblUsers WHERE idNumber = '" & txtID.Text & "' AND idNumber <> '" & edit & "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            dr.Close()
            MsgBox("That ID Has Already Been Taken.")
        Else

            dr.Close()

            If txtID.Text = Nothing Or txtLast.Text = Nothing Or txtGiven.Text = Nothing Or comboType.Text = Nothing Then

                MsgBox("Bold Fields Are Required")

            Else

                sql = "UPDATE tblUsers SET idNumber = '" & txtID.Text & "', nameLast = '" & txtLast.Text & "', nameGiven = '" & txtGiven.Text & "', nameMiddle = '" & txtMiddle.Text & "', type = '" & comboType.Text & "', course = '" & comboCourse.Text & "', address = '" & txtAddress.Text & "' WHERE idNumber = '" & edit & "'"

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

                MsgBox("User Updated!")

                frmPatrons.Show()
                Me.Hide()

            End If

        End If

    End Sub


End Class