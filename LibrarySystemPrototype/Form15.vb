Imports System.Data.SqlClient

Public Class frmReturn

    Public selected As Integer = Nothing

    Private Sub frmReturn_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub frmReturn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Activate()

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

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblUsers WHERE idNumber = '" & table.Rows(i)(2).ToString() & "'"
            cmd.CommandText = sql

            Dim adapter3 As New SqlDataAdapter(cmd)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)

            Dim name As String = table3.Rows(0)(2).ToString() + " " + table3.Rows(0)(3).ToString() + " " + table3.Rows(0)(1).ToString()

            Dim title As String = Nothing

            If table2.Rows(0)(2) = 1 Then
                title = table2.Rows(0)(3).ToString()
            Else
                title = table2.Rows(0)(3).ToString() + " (" + table2.Rows(0)(2).ToString() + ")"
            End If

            Dim items As String() = {table.Rows(i)(2).ToString(), name, table2.Rows(0)(1).ToString(), title, table2.Rows(0)(6).ToString(), Format(table.Rows(i)(4), "MM/dd/yyyy"), Format(table.Rows(i)(6), "MM/dd/yyyy")}
            lstvBorrowList.Items.Add(table.Rows(i)(0).ToString()).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtSearchBorrowerID.Text = Nothing
        txtSearchTransaction.Text = Nothing

        Me.Hide()
        frmBooks.Show()
    End Sub

    Private Sub txtSearchTransaction_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTransaction.TextChanged

        Search()

    End Sub

    Private Sub txtSearchBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBorrowerID.TextChanged

        Search()

    End Sub

    Private Sub Search()

        lstvBorrowList.Items.Clear()

        OpenConnection()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblTransaction WHERE status = 'Borrowed' AND (transactionID LIKE '" & txtSearchTransaction.Text + "%' AND idBorrower LIKE '" & txtSearchBorrowerID.Text + "%') ORDER BY transactionID"
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

            Dim name As String = table3.Rows(0)(2).ToString() + " " + table3.Rows(0)(3).ToString() + " " + table3.Rows(0)(1).ToString()

            Dim title As String = Nothing

            If table2.Rows(0)(2) = 1 Then
                title = table2.Rows(0)(3).ToString()
            Else
                title = table2.Rows(0)(3).ToString() + " (" + table2.Rows(0)(2).ToString() + ")"
            End If

            Dim items As String() = {table.Rows(i)(2).ToString(), name, table2.Rows(0)(1).ToString(), title, table2.Rows(0)(6).ToString(), Format(table.Rows(i)(4), "MM/dd/yyyy"), Format(table.Rows(i)(6), "MM/dd/yyyy")}
            lstvBorrowList.Items.Add(table.Rows(i)(0).ToString()).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        If lstvBorrowList.SelectedItems.Count < 1 Then
            MsgBox("No Book Selected")
        ElseIf lstvBorrowList.SelectedItems.Count > 1 Then
            MsgBox("Select Only One Book")
        Else

            If lstvBorrowList.SelectedItems(0).SubItems(5).Text = "on-loan-and-on-hold" Then

                selected = lstvBorrowList.SelectedItems(0).SubItems(0).Text

                Select Case MsgBox("This item is on hold, return anyway?", MsgBoxStyle.YesNo, "Confirm")

                    Case MsgBoxResult.Yes

                        frmReturnDialog.ShowDialog()

                    Case MsgBoxResult.No

                        selected = Nothing

                End Select


            ElseIf lstvBorrowList.SelectedItems(0).SubItems(5).Text = "on-loan" Then

                selected = lstvBorrowList.SelectedItems(0).SubItems(0).Text

                Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Confirm")

                    Case MsgBoxResult.Yes

                        frmReturnDialog.ShowDialog()

                    Case MsgBoxResult.No

                        selected = Nothing

                End Select

            Else

                selected = Nothing
                MsgBox("Error")

            End If

        End If

    End Sub

End Class