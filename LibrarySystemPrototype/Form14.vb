Imports System.Data.SqlClient

Public Class frmBorrow

    Dim idEdit As String = Nothing

    Private Sub frmBarrow_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If frmBooks.edit <> Nothing Then

            idEdit = frmBooks.edit

            OpenConnection()

            Dim cmd As SqlCommand
            Dim sql As String

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblBooks WHERE bookID = '" & idEdit & "'"
            cmd.CommandText = sql

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtISBN.Text = table.Rows(0)(1).ToString()

            numCopy.Value = table.Rows(0)(2)

            Activate()

        End If

        frmBooks.edit = Nothing

    End Sub

    Private Sub Activate()

        lstvBorrowList.Items.Clear()

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

            Dim title As String = Nothing

            If table2.Rows(0)(2) = 1 Then
                title = table2.Rows(0)(3).ToString()
            Else
                title = table2.Rows(0)(3).ToString() + " (" + table2.Rows(0)(2).ToString() + ")"
            End If

            Dim items As String() = {table.Rows(i)(2).ToString(), table2.Rows(0)(1).ToString(), title, Format(table.Rows(i)(4), "MM/dd/yyyy"), Format(table.Rows(i)(6), "MM/dd/yyyy")}
            lstvBorrowList.Items.Add(table.Rows(i)(0).ToString()).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub txtBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtBorrowerID.TextChanged

        txtBorrowerName.Text = Nothing

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblUsers WHERE idNumber = '" & txtBorrowerID.Text & "'"
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

        If table.Rows.Count = 1 Then

            txtBorrowerName.Text = table.Rows(0)(2).ToString() + " " + table.Rows(0)(3).ToString() + " " + table.Rows(0)(1).ToString()

        End If

    End Sub

    Private Sub frmBorrow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged

        txtTitle.Text = Nothing

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblBooks WHERE isbn = '" & txtISBN.Text & "'"
        cmd.CommandText = sql

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count >= 1 Then

            txtTitle.Text = table.Rows(0)(3).ToString()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        idEdit = Nothing

        frmBooks.Show()
        Me.Hide()

    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblUsers WHERE idNumber = '" & txtBorrowerID.Text & "'"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        If dr.HasRows = False Then
            dr.Close()
            MsgBox("Invalid Borrower ID")
        ElseIf dr.HasRows Then

            dr.Close()

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblBooks WHERE isbn = '" & txtISBN.Text & "'"
            cmd.CommandText = sql

            dr = cmd.ExecuteReader()

            If dr.HasRows = False Then
                dr.Close()
                MsgBox("Invalid Book ISBN")
            ElseIf dr.HasRows Then

                dr.Close()

                cmd = New SqlCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = connection

                sql = "SELECT * FROM tblBooks WHERE isbn = '" & txtISBN.Text & "' AND number = '" & numCopy.Value.ToString & "'"
                cmd.CommandText = sql

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                dr = cmd.ExecuteReader()

                If dr.HasRows = False Then
                    dr.Close()
                    MsgBox("Invalid Copy Number")
                ElseIf dr.HasRows Then

                    dr.Close()

                    If table.Rows(0)(6).ToString() <> "on-shelf" Then
                        MsgBox("Cannot Borrow This Book")
                    Else

                        cmd = New SqlCommand

                        sql = "INSERT INTO tblTransaction(idLibrarian ,idBorrower, bookID, dateBorrow, dateDue, status) VALUES('" & frmLogin.ID & "', '" & txtBorrowerID.Text & "', '" & table.Rows(0)(0).ToString() & "', '" & dateBorrowDate.Value & "', '" & dateBorrowDate.Value.AddDays(3) & "', 'Borrowed')"
                        Try

                            cmd.Connection = connection
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        Catch ex As Exception

                            MsgBox("Failed " & ex.ToString)

                        End Try

                        cmd = New SqlCommand

                        sql = "UPDATE tblBooks SET status ='on-loan' WHERE bookID ='" & table.Rows(0)(0).ToString() & "'"
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

                        MsgBox("Success!")

                        txtTransaction.Text = Nothing
                        txtBorrowerID.Text = Nothing
                        txtBorrowerName.Text = Nothing
                        txtISBN.Text = Nothing
                        txtTitle.Text = Nothing
                        dateBorrowDate.Refresh()

                        Activate()

                    End If

                Else
                    dr.Close()
                    MsgBox("Error")
                End If

            Else
                dr.Close()
                MsgBox("Error")
            End If

        Else
            dr.Close()
            MsgBox("Error")
        End If

    End Sub

    Private Sub lstvBorrowList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvBorrowList.SelectedIndexChanged

    End Sub
End Class