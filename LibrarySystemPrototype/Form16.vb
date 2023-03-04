Imports System.Data.SqlClient

Public Class frmReturnDialog

    Dim dateNow As Date = Nothing

    Dim idEdit As Integer = Nothing

    Private Sub frmReturnDialog_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If frmReturn.selected <> Nothing Then

            idEdit = frmReturn.selected

            frmReturn.selected = Nothing

            dateNow = DateTime.UtcNow.Date

            OpenConnection()

            Dim cmd As SqlCommand
            Dim sql As String

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblTransaction WHERE transactionID = '" & idEdit & "'"
            cmd.CommandText = sql

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtTransaction.Text = table.Rows(0)(0).ToString()
            txtDateBorrow.Text = Format(table.Rows(0)(4), "MM/dd/yyyy")
            txtDateDue.Text = Format(table.Rows(0)(6), "MM/dd/yyyy")
            txtDateCurrent.Text = Format(dateNow, "MM/dd/yyyy")
            Dim late As Integer = DateDiff(DateInterval.Day, table.Rows(0)(6), dateNow)
            If late <= 0 Then
                late = 0
            End If
            txtDaysLate.Text = late
            txtFine.Text = late * 5

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmReturn.selected = Nothing
        Me.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        If Val(txtFine.Text) > 0 Then

            Select Case MsgBox("Confirm Payment", MsgBoxStyle.YesNo, "Confirm")

                Case MsgBoxResult.Yes

                    ReturnNow()

                Case MsgBoxResult.No

            End Select

        ElseIf Val(txtFine.Text) <= 0 Then

            Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Confirm")

                Case MsgBoxResult.Yes

                    ReturnNow()

                Case MsgBoxResult.No

            End Select

        End If

    End Sub

    Private Sub ReturnNow()

        OpenConnection()

        Dim cmd As SqlCommand
        Dim sql As String

        cmd = New SqlCommand

        sql = "UPDATE tblTransaction SET dateReturn = '" & dateNow & "', fine = '" & txtFine.Text & "', status = 'Returned' WHERE transactionID ='" & idEdit & "'"
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
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblTransaction WHERE transactionID = '" & idEdit & "'"
        cmd.CommandText = sql

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        cmd = New SqlCommand

        sql = "UPDATE tblBooks SET status = 'on-shelf' WHERE bookID ='" & table.Rows(0)(3).ToString() & "'"
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

        Me.Close()

    End Sub

End Class