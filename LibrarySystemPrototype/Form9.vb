Imports System.Data.SqlClient

Public Class frmPatrons

    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim sql As String

    Public edit As String = Nothing

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddPatron.Show()
        Me.Hide()
    End Sub

    Private Sub frmPatrons_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmBody.Show()
        Me.Hide()
    End Sub

    Private Sub frmPatrons_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        txtSearch.Text = Nothing

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblUsers WHERE type = 'Student' OR type = 'Faculty' OR type = 'Librarian' ORDER BY nameLast"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        Dim count As Integer = 0
        While dr.Read
            count = count + 1
        End While
        dr.Close()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        lstvUsers.Items.Clear()

        Dim VID As String
        Dim Vlast As String
        Dim Vgiven As String
        Dim Vmiddle As String
        Dim Vtype As String
        Dim Vcourse As String
        Dim Vaddress As String

        For i = 0 To count - 1

            VID = table.Rows(i)(0).ToString()
            Vlast = table.Rows(i)(1).ToString()
            Vgiven = table.Rows(i)(2).ToString()
            Vmiddle = table.Rows(i)(3).ToString()
            Vtype = table.Rows(i)(4).ToString()
            Vcourse = table.Rows(i)(5).ToString()
            Vaddress = table.Rows(i)(6).ToString()

            Dim items As String() = {Vlast, Vgiven, Vmiddle, Vtype, Vcourse, Vaddress}
            lstvUsers.Items.Add(VID).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstvUsers.SelectedItems.Count < 1 Then
            MsgBox("No Users Selected")
        Else

            Dim selected As Integer = lstvUsers.SelectedItems.Count

            Dim user As New DataTable()

            user.Columns.Add("Column1", GetType(System.String))
            user.Columns.Add("Column2", GetType(System.String))

            For i As Integer = selected - 1 To 0 Step -1

                user.Rows.Add(lstvUsers.SelectedItems(i).SubItems(0).Text, lstvUsers.SelectedItems(i).SubItems(4).Text)


            Next

            Dim errormsg As Integer = 0

            Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Confirm")

                Case MsgBoxResult.Yes

                    For i As Integer = selected - 1 To 0 Step -1

                        If user.Rows(i)(1).ToString <> "Librarian" Or frmLogin.type = "Admin" Then

                            sql = "DELETE  FROM tblUsers WHERE idNumber = '" & user.Rows(i)(0).ToString & "'"
                            Try

                                cmd.Connection = connection
                                cmd.CommandType = CommandType.Text
                                cmd.CommandText = sql
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()

                            Catch ex As Exception

                                MsgBox("Failed " & ex.ToString)

                            End Try

                        Else

                            If user.Rows(i)(0).ToString = frmLogin.ID Then

                                errormsg = 2

                            Else

                                errormsg = 1

                            End If

                        End If

                    Next

                Case MsgBoxResult.No

            End Select

            If errormsg = 1 Then

                MsgBox("Librarians Cannot Remove Other Librarians")

                errormsg = 0

            ElseIf errormsg = 2 Then

                MsgBox("You Cannot Remove Yourself")

                errormsg = 0

            End If

            connection.Close()

            selected = 0

            frmPatrons_Activated(sender, e)

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSearch.Text <> Nothing Then

            SearchA()

        Else

            SearchB()

        End If

    End Sub

    Private Sub SearchA()

        lstvUsers.Items.Clear()

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        Dim Lstudent As String = Nothing
        Dim Lfaculty As String = Nothing
        Dim Llibrarian As String = Nothing
        Dim Lformer As String = Nothing
        Dim Lcourse As String = comboCourse.Text

        If (chbxStudent.Checked) Then
            Lstudent = "Student"
        End If
        If (chbxFaculty.Checked) Then
            Lfaculty = "Faculty"
        End If
        If (chbxLibrarian.Checked) Then
            Llibrarian = "Librarian"
        End If
        If (chbxFormer.Checked) Then
            Lformer = "Former Student/Faculty"
        End If
        If comboCourse.Text = "None" Then
            Lcourse = "AND course LIKE '%%'"
        Else
            Lcourse = "AND course = '" + Lcourse + "'"
        End If

        sql = "SELECT * FROM tblUsers WHERE (idNumber = '" & txtSearch.Text & "' OR nameLast LIKE '%" + txtSearch.Text + "%' OR nameGiven LIKE '%" + txtSearch.Text + "%' OR nameMiddle LIKE '%" + txtSearch.Text + "%') AND ((type = '" & Lstudent & "' OR type = '" & Lfaculty & "' OR type = '" & Llibrarian & "' OR type = '" & Lformer & "') " + Lcourse + ") ORDER BY nameLast"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        Dim count As Integer = 0
        While dr.Read
            count = count + 1
        End While
        dr.Close()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        lstvUsers.Items.Clear()

        Dim VID As String
        Dim Vlast As String
        Dim Vgiven As String
        Dim Vmiddle As String
        Dim Vtype As String
        Dim Vcourse As String
        Dim Vaddress As String

        For i = 0 To count - 1

            VID = table.Rows(i)(0).ToString()
            Vlast = table.Rows(i)(1).ToString()
            Vgiven = table.Rows(i)(2).ToString()
            Vmiddle = table.Rows(i)(3).ToString()
            Vtype = table.Rows(i)(4).ToString()
            Vcourse = table.Rows(i)(5).ToString()
            Vaddress = table.Rows(i)(6).ToString()

            Dim items As String() = {Vlast, Vgiven, Vmiddle, Vtype, Vcourse, Vaddress}
            lstvUsers.Items.Add(VID).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub SearchB()

        lstvUsers.Items.Clear()

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        Dim Lstudent As String = Nothing
        Dim Lfaculty As String = Nothing
        Dim Llibrarian As String = Nothing
        Dim Lformer As String = Nothing
        Dim Lcourse As String = comboCourse.Text

        If (chbxStudent.Checked) Then
            Lstudent = "Student"
        End If
        If (chbxFaculty.Checked) Then
            Lfaculty = "Faculty"
        End If
        If (chbxLibrarian.Checked) Then
            Llibrarian = "Librarian"
        End If
        If (chbxFormer.Checked) Then
            Lformer = "Former Student/Faculty"
        End If
        If comboCourse.Text = "None" Then
            Lcourse = "AND course LIKE '%%'"
        Else
            Lcourse = "AND course = '" + Lcourse + "'"
        End If

        sql = "SELECT * FROM tblUsers WHERE (type = '" & Lstudent & "' OR type = '" & Lfaculty & "' OR type = '" & Llibrarian & "' OR type = '" & Lformer & "') " + Lcourse + " ORDER BY nameLast"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        Dim count As Integer = 0
        While dr.Read
            count = count + 1
        End While
        dr.Close()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        lstvUsers.Items.Clear()

        Dim VID As String
        Dim Vlast As String
        Dim Vgiven As String
        Dim Vmiddle As String
        Dim Vtype As String
        Dim Vcourse As String
        Dim Vaddress As String

        For i = 0 To count - 1

            VID = table.Rows(i)(0).ToString()
            Vlast = table.Rows(i)(1).ToString()
            Vgiven = table.Rows(i)(2).ToString()
            Vmiddle = table.Rows(i)(3).ToString()
            Vtype = table.Rows(i)(4).ToString()
            Vcourse = table.Rows(i)(5).ToString()
            Vaddress = table.Rows(i)(6).ToString()

            Dim items As String() = {Vlast, Vgiven, Vmiddle, Vtype, Vcourse, Vaddress}
            lstvUsers.Items.Add(VID).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lstvUsers.SelectedItems.Count < 1 Then
            MsgBox("No User Selected")
        ElseIf lstvUsers.SelectedItems.Count > 1 Then
            MsgBox("Select Only One User")
        Else

            Dim errormsg As Integer = 0

            If lstvUsers.SelectedItems(0).SubItems(4).Text <> "Librarian" Or frmLogin.type = "Admin" Then

                edit = lstvUsers.SelectedItems(0).SubItems(0).Text

                frmEditUser.Show()
                Me.Hide()

            Else

            End If

        End If

    End Sub

End Class