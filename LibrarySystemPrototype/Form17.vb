Imports System.Data.SqlClient

Public Class frmReports

    Private Sub frmReports_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub frmReports_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tabControl_TabIndexChanged(sender, e)
    End Sub

    Private Sub tabControl_TabIndexChanged(sender As Object, e As EventArgs) Handles tabControl.TabIndexChanged
        BookList()
        BookBorrow()
        BookReturn()
        'Stat()
    End Sub

    Private Sub BookList()

        Dim Visbn As String = Nothing
        Dim Vnumber As Integer = Nothing
        Dim Vtitle As String = Nothing

        Dim Vauthor As String = Nothing
        Dim authorLast As String = Nothing
        Dim authorGiven As String = Nothing
        Dim authorMiddle As String = Nothing

        Dim Vyear As Integer = Nothing
        Dim Vshelf As String = Nothing
        Dim Vstatus As String = Nothing

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        lstvBooks.Items.Clear()

        Vauthor = Nothing

        sql = "SELECT * FROM tblBooks ORDER BY title"
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

        For i = 0 To count - 1

            Visbn = table.Rows(i)(1).ToString()
            Vnumber = table.Rows(i)(2).ToString()
            Vtitle = table.Rows(i)(3).ToString()
            Vyear = table.Rows(i)(4).ToString()
            Vshelf = table.Rows(i)(5).ToString()
            Vstatus = table.Rows(i)(6).ToString()

            sql = "SELECT * FROM tblAuthorBook WHERE bookID = '" & table.Rows(i)(0).ToString() & "'"
            cmd.CommandText = sql

            Dim count2 As Integer = 0

            dr = cmd.ExecuteReader()
            While dr.Read
                count2 = count2 + 1
            End While
            dr.Close()

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            For o = 0 To count2 - 1

                sql = "SELECT * FROM tblAuthors WHERE authorID = '" & table2.Rows(o)(1).ToString() & "'"
                cmd.CommandText = sql
                Dim adapter3 As New SqlDataAdapter(cmd)
                Dim table3 As New DataTable()
                adapter3.Fill(table3)

                authorLast = table3.Rows(0)(1).ToString()
                authorGiven = table3.Rows(0)(2).ToString() + " "
                If IsDBNull(table3.Rows(0)(3)) Then
                    authorMiddle = Nothing
                Else
                    authorMiddle = table3.Rows(0)(3) + ". "
                End If

                If o < count2 - 1 Then
                    Vauthor = Vauthor + " " + authorGiven + authorMiddle + authorLast + ";"
                Else
                    Vauthor = Vauthor + " " + authorGiven + authorMiddle + authorLast
                End If

            Next

            sql = "SELECT * FROM tblShelf WHERE shelfID = '" & Vshelf & "'"
            cmd.CommandText = sql
            Dim adapter4 As New SqlDataAdapter(cmd)
            Dim table4 As New DataTable()
            adapter4.Fill(table4)

            If table4.Rows.Count > 0 Then
                Vshelf = table4.Rows(0)(1).ToString()
            End If

            If Visbn = Nothing Then
                Visbn = " "
            End If
            If Vtitle = Nothing Then
                Vtitle = " "
            End If
            If Vauthor = Nothing Then
                Vauthor = " "
            End If
            If Vyear = Nothing Then
                Vyear = " "
            End If
            If Vshelf = Nothing Then
                Vshelf = " "
            End If
            If Vstatus = Nothing Then
                Vstatus = " "
            End If

            Dim items As String() = {Vtitle, Vnumber, Vauthor, Vyear, Vshelf, Vstatus}
            lstvBooks.Items.Add(Visbn).SubItems.AddRange(items)

            Vauthor = Nothing

        Next

    End Sub

    Private Sub BookBorrow()

        lstvBorrow.Items.Clear()

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblTransaction WHERE status = 'Borrowed' ORDER BY transactionID"
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

        For i = 0 To count - 1

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblBooks WHERE bookID = '" & table.Rows(i)(3).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblUsers WHERE idNumber = '" & table.Rows(i)(2).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter3 As New SqlDataAdapter(cmd)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)

            sql = "SELECT * FROM tblUsers WHERE idNumber = '" & table.Rows(i)(1).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter4 As New SqlDataAdapter(cmd)
            Dim table4 As New DataTable()
            adapter4.Fill(table4)

            Dim name As String = table3.Rows(0)(2).ToString() + " " + table3.Rows(0)(3).ToString() + " " + table3.Rows(0)(1).ToString()
            Dim librarian As String = table4.Rows(0)(2).ToString() + " " + table4.Rows(0)(3).ToString() + " " + table4.Rows(0)(1).ToString()

            Dim title As String = Nothing

            If table2.Rows(0)(2) = 1 Then
                title = table2.Rows(0)(3).ToString()
            Else
                title = table2.Rows(0)(3).ToString() + " (" + table2.Rows(0)(2).ToString() + ")"
            End If

            Dim items As String() = {librarian, table.Rows(i)(2).ToString(), name, table2.Rows(0)(1).ToString(), title, Format(table.Rows(i)(4), "MM/dd/yyyy"), Format(table.Rows(i)(6), "MM/dd/yyyy")}
            lstvBorrow.Items.Add(table.Rows(i)(0).ToString()).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub BookReturn()

        lstvReturn.Items.Clear()

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblTransaction WHERE status = 'Returned' ORDER BY transactionID"
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

        For i = 0 To count - 1

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblBooks WHERE bookID = '" & table.Rows(i)(3).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblUsers WHERE idNumber = '" & table.Rows(i)(2).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter3 As New SqlDataAdapter(cmd)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)

            sql = "SELECT * FROM tblUsers WHERE idNumber = '" & table.Rows(i)(1).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter4 As New SqlDataAdapter(cmd)
            Dim table4 As New DataTable()
            adapter4.Fill(table4)

            Dim name As String = table3.Rows(0)(2).ToString() + " " + table3.Rows(0)(3).ToString() + " " + table3.Rows(0)(1).ToString()
            Dim librarian As String = table4.Rows(0)(2).ToString() + " " + table4.Rows(0)(3).ToString() + " " + table4.Rows(0)(1).ToString()

            Dim title As String = Nothing

            If table2.Rows(0)(2) = 1 Then
                title = table2.Rows(0)(3).ToString()
            Else
                title = table2.Rows(0)(3).ToString() + " (" + table2.Rows(0)(2).ToString() + ")"
            End If

            Dim items As String() = {librarian, table.Rows(i)(2).ToString(), name, table2.Rows(0)(1).ToString(), title, Format(table.Rows(i)(4), "MM/dd/yyyy"), Format(table.Rows(i)(6), "MM/dd/yyyy"), Format(table.Rows(i)(5), "MM/dd/yyyy"), table.Rows(i)(7).ToString}
            lstvReturn.Items.Add(table.Rows(i)(0).ToString()).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub Stat()

        txtBooks.Text = Nothing
        txtBooksMost.Text = Nothing
        txtBooksLeast.Text = Nothing
        txtFines.Text = Nothing
        txtStudents.Text = Nothing
        txtFaculties.Text = Nothing
        txtLibrarians.Text = Nothing

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblBooks"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        Dim count As Integer = 0
        While dr.Read
            count = count + 1
        End While
        dr.Close()

        txtBooks.Text = count

        Dim dataTrans As New DataTable()
        dataTrans.Columns.Add("transactionNumber", GetType(System.String))
        dataTrans.Columns.Add("isbn", GetType(System.String))
        dataTrans.Columns.Add("title", GetType(System.String))

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblTransaction ORDER BY bookID"
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

        For i = 0 To count - 1

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblBooks WHERE bookID = '" & table.Rows(i)(3).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            dataTrans.Rows.Add(table.Rows(i)(0).ToString(), table2.Rows(0)(1).ToString(), table2.Rows(0)(3).ToString())

        Next

        dataTrans.DefaultView.Sort = "transactionNumber ASC"

        dataTrans = dataTrans.DefaultView.ToTable()

        Dim dataTransDT As DataTable = dataTrans.DefaultView.ToTable(True, "isbn")

        count = 0

        For i = 0 To dataTransDT.Rows.Count - 1

            If i = 0 Then
                count = dataTrans.Select("isbn = dataTransDT.Rows('" & i & "')(0)").Count
            End If

            If dataTrans.Select("isbn = dataTransDT.Rows('" & i & "')(0)").Count > count Then

                count = dataTrans.Select("isbn = dataTransDT.Rows('" & i & "')(0)").Count

            End If

        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmBody.Show()
        Me.Hide()
    End Sub


End Class