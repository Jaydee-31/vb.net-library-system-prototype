Imports System.Data.SqlClient

Public Class frmBookAdd

    Dim sql As String
    Dim dr As SqlDataReader
    Dim count As Integer = 0
    Dim count2 As Integer = 0
    Dim count3 As Integer = 0
    Dim count4 As Integer = 0
    Dim count5 As Integer = 0
    Dim count6 As Integer = 0
    Dim count7 As Integer = 0
    Dim cmd As SqlCommand
    Dim tableA As New DataTable()

    Private Sub frmBookAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub Radio()

        If (rbAddExisting.Checked) Then

            comboSelectBook.Enabled = True
            comboISBN.Enabled = True
            comboExistingShelf.Enabled = True
            btnAddExisting.Enabled = True

            txtISBN.Enabled = False
            txtTitle.Enabled = False

            lstvAuthor.Enabled = False
            btnAddAuthor.Enabled = False
            btnRemoveAuthor.Enabled = False
            btnRemoveAll.Enabled = False

            txtYear.Enabled = False
            comboNewShelf.Enabled = False
            btnAddNew.Enabled = False

        Else

            comboSelectBook.Enabled = False
            comboISBN.Enabled = False
            comboExistingShelf.Enabled = False
            btnAddExisting.Enabled = False

            txtISBN.Enabled = True
            txtTitle.Enabled = True

            lstvAuthor.Enabled = True
            btnAddAuthor.Enabled = True
            btnRemoveAuthor.Enabled = True
            btnRemoveAll.Enabled = True

            txtYear.Enabled = True
            comboNewShelf.Enabled = True
            btnAddNew.Enabled = True

        End If

    End Sub

    Private Sub frmBookAdd_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Radio()

        OpenConnection()
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection
        sql = "SELECT * FROM tblShelf"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        count = 0
        While dr.Read
            count = count + 1
        End While
        dr.Close()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        comboExistingShelf.Items.Clear()
        comboNewShelf.Items.Clear()

        For i = 0 To count - 1
            comboExistingShelf.Items.Add(table.Rows(i)(1).ToString())
            comboNewShelf.Items.Add(table.Rows(i)(1).ToString())
        Next

        sql = "SELECT bookID, isbn, title FROM (SELECT bookID, isbn, title, Row_number() OVER(PARTITION BY isbn ORDER BY title) rn FROM tblBooks) a WHERE rn = 1"

        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        count3 = 0
        While dr.Read
            count3 = count3 + 1
        End While
        dr.Close()

        Dim adapter2 As New SqlDataAdapter(cmd)
        adapter2.Fill(tableA)

        comboISBN.Items.Clear()
        comboSelectBook.Items.Clear()

        For i = 0 To count3 - 1
            comboISBN.Items.Add(tableA.Rows(i)(1).ToString())
            comboSelectBook.Items.Add(tableA.Rows(i)(2).ToString())
        Next

    End Sub

    Private Sub rbAddExisting_CheckedChanged(sender As Object, e As EventArgs) Handles rbAddExisting.CheckedChanged
        Radio()
    End Sub

    Private Sub rbAddNew_CheckedChanged(sender As Object, e As EventArgs) Handles rbAddNew.CheckedChanged
        Radio()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        comboSelectBook.Text = Nothing
        comboISBN.Text = Nothing
        comboExistingShelf.Text = Nothing
        txtISBN.Text = Nothing
        txtTitle.Text = Nothing
        lstvAuthor.Items.Clear()
        txtYear.Text = Nothing
        comboNewShelf.Text = Nothing

        frmBooks.Show()
        Me.Hide()
    End Sub

    Private Sub AddNew()

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblBooks WHERE isbn = '" & txtISBN.Text & "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            MsgBox("That ISBN Has Already Been Taken, Try Adding An Existing Book.")
        Else

            sql = "SELECT * FROM tblShelf WHERE shelfName = '" & comboNewShelf.Text & "'"
            cmd.CommandText = sql
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtTitle.Text = txtTitle.Text.Replace("'", "''")

            sql = "INSERT INTO tblBooks(isbn, number, title, year, shelfid, status) VALUES('" & txtISBN.Text & "', 1, '" & txtTitle.Text & "', '" & txtYear.Text & "', '" & table.Rows(0)(0).ToString() & "', 'on-shelf')"

            Try

                cmd.Connection = connection
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            Catch ex As Exception

                MsgBox("Failed " & ex.ToString)

            End Try

            For i = 0 To lstvAuthor.Items.Count() - 1

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

            Next

            sql = "SELECT * FROM tblBooks WHERE isbn = '" & txtISBN.Text & "'"
            cmd.CommandText = sql
            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            Dim adapter3 As New SqlDataAdapter(cmd)
            Dim table4 As New DataTable()

            For i = 0 To lstvAuthor.Items.Count() - 1

                sql = "SELECT * FROM tblAuthors WHERE nameLast = '" & lstvAuthor.Items(i).Text & "' AND nameGiven = '" & lstvAuthor.Items(i).SubItems(1).Text & "' AND middleInitial = '" & lstvAuthor.Items(i).SubItems(2).Text & "'"
                cmd.CommandText = sql

                table4.Clear()

                dr = cmd.ExecuteReader()
                count2 = 0
                While dr.Read
                    count2 = count2 + 1
                End While
                dr.Close()

                adapter3.Fill(table4)

                sql = "INSERT INTO tblAuthorBook(bookID, authorID) VALUES('" & table2.Rows(0)(0).ToString() & "', '" & table4.Rows(count2 - 1)(0).ToString() & "')"

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

            connection.Close()

            txtISBN.Text = Nothing
            txtTitle.Text = Nothing
            lstvAuthor.Items.Clear()
            txtYear.Text = Nothing
            comboNewShelf.Text = Nothing

            MsgBox("Success!")

            Me.Activate()

        End If

    End Sub

    Private Sub AddExist()

        If comboISBN.Text = Nothing Then
            MsgBox("No Book Selected")
        Else

            If comboExistingShelf.Text = Nothing Then
                MsgBox("Select A Shelf")
            Else

                OpenConnection()

                cmd = New SqlCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = connection

                sql = "SELECT * FROM tblShelf WHERE shelfName = '" & comboExistingShelf.Text & "'"
                cmd.CommandText = sql
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                sql = "SELECT * FROM tblBooks WHERE isbn = '" & comboISBN.Text & "' ORDER BY number"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()
                count5 = 0
                While dr.Read
                    count5 = count5 + 1
                End While
                dr.Close()

                Dim adapter2 As New SqlDataAdapter(cmd)
                Dim table2 As New DataTable()
                adapter2.Fill(table2)

                sql = "INSERT INTO tblBooks(isbn, number, title, year, shelfid, status) VALUES('" & table2.Rows(count5 - 1)(1).ToString() & "', '" & table2.Rows(count5 - 1)(2) + 1 & "', '" & table2.Rows(count5 - 1)(3).ToString() & "', '" & table2.Rows(count5 - 1)(4).ToString() & "', '" & table.Rows(0)(0).ToString() & "', 'on-shelf')"

                Try

                    cmd.Connection = connection
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Catch ex As Exception

                    MsgBox("Failed " & ex.ToString)

                End Try

                sql = "SELECT * FROM tblBooks WHERE isbn = '" & comboISBN.Text & "'"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()
                count6 = 0
                While dr.Read
                    count6 = count6 + 1
                End While
                dr.Close()

                Dim adapter3 As New SqlDataAdapter(cmd)
                Dim table3 As New DataTable()
                adapter3.Fill(table3)

                sql = "SELECT * FROM tblAuthorBook WHERE bookID = '" & table2.Rows(count5 - 1)(0).ToString() & "'"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()
                count7 = 0
                While dr.Read
                    count7 = count7 + 1
                End While
                dr.Close()

                Dim adapter4 As New SqlDataAdapter(cmd)
                Dim table4 As New DataTable()
                adapter4.Fill(table4)

                For i = 0 To count7 - 1

                    sql = "INSERT INTO tblAuthorBook(bookID, authorID) VALUES('" & table3.Rows(count6 - 1)(0).ToString() & "', '" & table4.Rows(i)(1) & "')"

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

                connection.Close()

                comboISBN.Text = Nothing
                comboSelectBook.Text = Nothing
                comboExistingShelf.Text = Nothing

                MsgBox("Success!")

                Me.Activate()

            End If

        End If

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        AddNew()
    End Sub

    Private Sub btnAddAuthor_Click(sender As Object, e As EventArgs) Handles btnAddAuthor.Click
        frmAddAuthor.ShowDialog()
    End Sub

    Private Sub btnRemoveAuthor_Click(sender As Object, e As EventArgs) Handles btnRemoveAuthor.Click

        For i As Integer = lstvAuthor.SelectedItems.Count - 1 To 0 Step -1
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
        lstvAuthor.Items.Clear()
    End Sub

    Private Sub comboSelectBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSelectBook.SelectedIndexChanged

        If comboSelectBook.Text <> Nothing Then
            comboISBN.Text = tableA.Rows(comboSelectBook.SelectedIndex)(1).ToString()
        End If

    End Sub

    Private Sub comboISBN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboISBN.SelectedIndexChanged

        If comboISBN.Text <> Nothing Then
            comboSelectBook.Text = tableA.Rows(comboISBN.SelectedIndex)(2).ToString()
        End If

    End Sub

    Private Sub btnAddExisting_Click(sender As Object, e As EventArgs) Handles btnAddExisting.Click
        AddExist()
    End Sub
End Class