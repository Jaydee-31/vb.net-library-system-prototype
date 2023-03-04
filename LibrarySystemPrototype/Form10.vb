Imports System.Data.SqlClient

Public Class frmEditBooks

    Dim dataAuthors As New DataTable()

    Dim idEdit As String = Nothing

    Dim isbnEdit As String = Nothing

    Dim idStatus As String = Nothing

    Private Sub frmEditBooks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        comboShelf.Items.Clear()

        dataAuthors.Columns.Clear()
        dataAuthors.Clear()

        idEdit = Nothing

        lstvAuthor.Items.Clear()

        frmBooks.Show()
        Me.Hide()

    End Sub

    Private Sub frmEditBooks_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If frmBooks.edit <> Nothing Then

            lstvAuthor.Items.Clear()

            idEdit = frmBooks.edit

            If dataAuthors.Columns.Count() < 1 Then
                dataAuthors.Columns.Add("Column1", GetType(System.String))
            End If

            Dim dr As SqlDataReader
            Dim count As Integer
            Dim count2 As Integer
            Dim cmd As SqlCommand
            Dim sql As String

            OpenConnection()

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblBooks WHERE bookID = '" & idEdit & "'"
            cmd.CommandText = sql

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtISBN.Text = table.Rows(0)(1).ToString()
            isbnEdit = table.Rows(0)(1).ToString()
            lblCopy.Text = "Copy Number: " + table.Rows(0)(2).ToString()
            txtTitle.Text = table.Rows(0)(3).ToString()
            txtYear.Text = table.Rows(0)(4).ToString()
            If table.Rows(0)(6).ToString() = "on-hold" Or table.Rows(0)(6).ToString() = "on-loan-and-on-hold" Then
                chbxHold.Checked = True
            ElseIf table.Rows(0)(6).ToString() = "on-shelf" Or table.Rows(0)(6).ToString() = "on-loan" Then
                chbxHold.Checked = False
            Else
                chbxHold.Checked = False
            End If
            idStatus = table.Rows(0)(6).ToString()

            sql = "SELECT * FROM tblShelf WHERE shelfID = '" & table.Rows(0)(5).ToString() & "'"
            cmd.CommandText = sql
            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

                If table2.Rows.Count > 0 Then
                    comboShelf.Text = table2.Rows(0)(1).ToString()
                End If

                sql = "SELECT * FROM tblAuthorBook WHERE bookID = '" & table.Rows(0)(0).ToString() & "'"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()
                count = 0
                While dr.Read
                    count = count + 1
                End While
                dr.Close()

                Dim adapter3 As New SqlDataAdapter(cmd)
                Dim table3 As New DataTable()
                adapter3.Fill(table3)

                Dim adapter4 As New SqlDataAdapter(cmd)
                Dim table4 As New DataTable()

                For i = 0 To count - 1

                    sql = "SELECT * FROM tblAuthors WHERE authorID = '" & table3.Rows(i)(1).ToString() & "'"
                    cmd.CommandText = sql

                    table4.Clear()

                    adapter4.Fill(table4)

                    Dim last As String = table4.Rows(0)(1).ToString()
                    Dim given As String = table4.Rows(0)(2).ToString()
                    Dim middle As String = table4.Rows(0)(3).ToString()

                    If last = Nothing Then
                        last = " "
                    End If
                    If given = Nothing Then
                        given = " "
                    End If
                    If middle = Nothing Then
                        middle = " "
                    End If

                    Dim items As String() = {given, middle, table4.Rows(0)(0).ToString()}
                    lstvAuthor.Items.Add(last).SubItems.AddRange(items)

                Next

                sql = "SELECT * FROM tblShelf"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()
                count2 = 0
                While dr.Read
                    count2 = count2 + 1
                End While
                dr.Close()

                Dim adapter5 As New SqlDataAdapter(cmd)
                Dim table5 As New DataTable()
                adapter5.Fill(table5)

                For i = 0 To count2 - 1
                    comboShelf.Items.Add(table5.Rows(i)(1).ToString())
                Next

            End If

            frmBooks.edit = Nothing

    End Sub

    Private Sub btnRemoveAuthor_Click(sender As Object, e As EventArgs) Handles btnRemoveAuthor.Click

        For i As Integer = lstvAuthor.SelectedItems.Count - 1 To 0 Step -1
            If lstvAuthor.SelectedItems(i).SubItems(3).Text <> Nothing Then
                dataAuthors.Rows.Add(lstvAuthor.SelectedItems(i).SubItems(3).Text)
            End If
            lstvAuthor.SelectedItems(i).Remove()
        Next
        lstvAuthor.SelectedItems.Clear()
        If lstvAuthor.Items.Count > 0 Then
            Dim Index As Integer = lstvAuthor.Items.Count - 1
            lstvAuthor.Items(lstvAuthor.Items.Count - 1).Selected = True
            lstvAuthor.EnsureVisible(Index)
            lstvAuthor.Select()
        End If

    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        For i = 0 To lstvAuthor.Items.Count - 1
            If lstvAuthor.Items(i).SubItems(3).Text <> Nothing Then
                dataAuthors.Rows.Add(lstvAuthor.Items(i).SubItems(3).Text)
            End If
        Next
        lstvAuthor.Items.Clear()
    End Sub

    Private Sub btnAddAuthor_Click(sender As Object, e As EventArgs) Handles btnAddAuthor.Click
        frmAddAuthor2.ShowDialog()
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

        sql = "SELECT * FROM tblBooks WHERE isbn = '" & txtISBN.Text & "' AND isbn <> '" & isbnEdit & "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            MsgBox("That ISBN Has Already Been Taken.")
        Else

            dr.Close()

            Select Case MsgBox("Are you sure? All existing copies of this book will also be changed. Shelf location and status will only change for this copy", MsgBoxStyle.YesNo, "Confirm")

                Case MsgBoxResult.Yes

                    txtTitle.Text = txtTitle.Text.Replace("'", "''")

                    sql = "UPDATE tblBooks SET isbn = '" & txtISBN.Text & "', title = '" & txtTitle.Text & "', year = '" & txtYear.Text & "' WHERE isbn = '" & isbnEdit & "'"

                    Try

                        cmd.Connection = connection
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = sql
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Catch ex As Exception

                        MsgBox("Failed " & ex.ToString)

                    End Try

                    sql = "SELECT * FROM tblShelf WHERE shelfName = '" & comboShelf.Text & "'"
                    cmd.CommandText = sql
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    sql = "UPDATE tblBooks SET shelfid = '" & table.Rows(0)(0).ToString() & "' WHERE bookID = '" & idEdit & "'"

                    Try

                        cmd.Connection = connection
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = sql
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Catch ex As Exception

                        MsgBox("Failed " & ex.ToString)

                    End Try

                    Dim status As String = Nothing

                    If idStatus = "on-shelf" And (chbxHold.Checked) Then
                        status = "on-hold"
                    ElseIf idStatus = "on-shelf" And chbxHold.Checked = False Then
                        status = "on-shelf"
                    ElseIf idStatus = "on-hold" And (chbxHold.Checked) Then
                        status = "on-hold"
                    ElseIf idStatus = "on-hold" And chbxHold.Checked = False Then
                        status = "on-shelf"
                    ElseIf idStatus = "on-loan" And (chbxHold.Checked) Then
                        status = "on-loan-and-on-hold"
                    ElseIf idStatus = "on-loan" And chbxHold.Checked = False Then
                        status = "on-loan"
                    ElseIf idStatus = "on-loan-and-on-hold" And (chbxHold.Checked) Then
                        status = "on-loan-and-on-hold"
                    ElseIf idStatus = "on-loan-and-on-hold" And chbxHold.Checked = False Then
                        status = "on-loan"
                    End If

                    sql = "UPDATE tblBooks SET status = '" & status & "' WHERE bookID = '" & idEdit & "'"

                    Try

                        cmd.Connection = connection
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = sql
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Catch ex As Exception

                        MsgBox("Failed " & ex.ToString)

                    End Try

                    If dataAuthors.Rows.Count > 0 Then

                        sql = "SELECT * FROM tblBooks WHERE isbn = '" & isbnEdit & "'"
                        cmd.CommandText = sql
                        Dim adapter2 As New SqlDataAdapter(cmd)
                        Dim table2 As New DataTable()
                        adapter2.Fill(table2)

                        Dim count As Integer = 0

                        dr = cmd.ExecuteReader()
                        While dr.Read
                            count = count + 1
                        End While
                        dr.Close()

                        For i = 0 To count - 1

                            For o = 0 To dataAuthors.Rows.Count - 1

                                sql = "DELETE FROM tblAuthorBook WHERE bookID = '" & table2.Rows(i)(0).ToString() & "' AND authorID = '" & dataAuthors.Rows(o)(0).ToString & "'"

                                Try

                                    cmd.Connection = connection
                                    cmd.CommandType = CommandType.Text
                                    cmd.CommandText = sql
                                    cmd.ExecuteNonQuery()
                                    cmd.Dispose()

                                Catch ex As Exception

                                    MsgBox("Failed " & ex.ToString)

                                End Try

                            Next

                        Next

                    End If

                    For i = 0 To lstvAuthor.Items.Count() - 1

                        If lstvAuthor.Items(i).SubItems(3).Text = "%%$875621997564839$%%" Then

                            sql = "INSERT INTO tblAuthors(nameLast, nameGiven, middleInitial) VALUES('" & lstvAuthor.Items(i).Text & "', '" & lstvAuthor.Items(i).SubItems(1).Text & "', '" & lstvAuthor.Items(i).SubItems(2).Text & "')"

                            Try

                                cmd.Connection = connection
                                cmd.CommandType = CommandType.Text
                                cmd.CommandText = sql
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()

                            Catch ex As Exception

                                MsgBox("Failed " & ex.ToString)

                            End Try

                        End If

                    Next

                    sql = "SELECT * FROM tblBooks WHERE isbn = '" & isbnEdit & "'"
                    cmd.CommandText = sql

                    dr = cmd.ExecuteReader()
                    Dim count2 As Integer = 0
                    While dr.Read
                        count2 = count2 + 1
                    End While
                    dr.Close()

                    Dim adapter3 As New SqlDataAdapter(cmd)
                    Dim table3 As New DataTable()
                    adapter3.Fill(table3)

                    Dim adapter4 As New SqlDataAdapter(cmd)
                    Dim table4 As New DataTable()
                    Dim count3 As Integer

                    For i = 0 To lstvAuthor.Items.Count() - 1

                        If lstvAuthor.Items(i).SubItems(3).Text = "%%$875621997564839$%%" Then

                            sql = "SELECT * FROM tblAuthors WHERE nameLast = '" & lstvAuthor.Items(i).Text & "' AND nameGiven = '" & lstvAuthor.Items(i).SubItems(1).Text & "' AND middleInitial = '" & lstvAuthor.Items(i).SubItems(2).Text & "'"
                            cmd.CommandText = sql

                            table4.Clear()

                            dr = cmd.ExecuteReader()
                            count3 = 0
                            While dr.Read
                                count3 = count3 + 1
                            End While
                            dr.Close()

                            adapter4.Fill(table4)

                            For o = 0 To count2 - 1

                                sql = "INSERT INTO tblAuthorBook(bookID, authorID) VALUES('" & table3.Rows(o)(0).ToString() & "', '" & table4.Rows(count3 - 1)(0).ToString() & "')"

                                Try

                                    cmd.Connection = connection
                                    cmd.CommandType = CommandType.Text
                                    cmd.CommandText = sql
                                    cmd.ExecuteNonQuery()
                                    cmd.Dispose()

                                Catch ex As Exception

                                    MsgBox("Failed " & ex.ToString)

                                End Try

                            Next

                        End If

                    Next

                    connection.Close()

                    MsgBox("Success!")

                    isbnEdit = Nothing
                    idEdit = Nothing

                    lstvAuthor.Items.Clear()

                    frmBooks.Show()
                    Me.Hide()

                Case MsgBoxResult.No

            End Select

        End If

    End Sub


End Class