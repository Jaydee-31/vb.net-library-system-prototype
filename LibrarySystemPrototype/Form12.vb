Imports System.Data.SqlClient

Public Class frmShelf

    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim sql As String

    Dim shelfid As Integer = Nothing

    Private Sub frmShelf_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub frmShelf_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        lstvShelves.Items.Clear()

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblShelf ORDER BY shelfName"
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

            Dim items As String() = {table.Rows(i)(2).ToString(), table.Rows(i)(0).ToString()}
            lstvShelves.Items.Add(table.Rows(i)(1).ToString()).SubItems.AddRange(items)

        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtShelfAdd.Text = Nothing Then
            MsgBox("Shelf Name Required")
        Else

            OpenConnection()

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblShelf WHERE shelfName = '" & txtShelfAdd.Text & "'"
            cmd.CommandText = sql

            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                dr.Close()
                MsgBox("A Shelf With That Name Already Exists")
            Else

                dr.Close()

                sql = "INSERT INTO tblShelf(shelfName, description) VALUES('" & txtShelfAdd.Text & "', '" & txtDescriptionAdd.Text & "')"

                Try

                    cmd.Connection = connection
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Catch ex As Exception

                    MsgBox("Failed " & ex.ToString)

                End Try

                connection.Close()

                MsgBox("Successfully Added!")

                txtShelfAdd.Text = Nothing
                txtDescriptionAdd.Text = Nothing

                frmShelf_Activated(sender, e)

            End If

        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lstvShelves.SelectedItems.Count < 1 Then
            MsgBox("No Shelf Selected")
        ElseIf lstvShelves.SelectedItems.Count > 1 Then
            MsgBox("Select Only One Shelf")
        Else

            shelfid = lstvShelves.SelectedItems(0).SubItems(2).Text

            txtShelfEdit.Enabled = True
            txtDescriptionEdit.Enabled = True
            btnUpdate.Enabled = True

            txtShelfEdit.Text = lstvShelves.SelectedItems(0).SubItems(0).Text
            txtDescriptionEdit.Text = lstvShelves.SelectedItems(0).SubItems(1).Text

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtShelfEdit.Text = Nothing Then
            MsgBox("Shelf Name Required")
        Else

            OpenConnection()

            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = connection

            sql = "SELECT * FROM tblShelf WHERE shelfName = '" & txtShelfEdit.Text & "'"
            cmd.CommandText = sql

            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                dr.Close()
                MsgBox("A Shelf With That Name Already Exists")
            Else

                dr.Close()

                Select Case MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Confirm")

                    Case MsgBoxResult.Yes

                        sql = "UPDATE tblShelf SET shelfName = '" & txtShelfEdit.Text & "', description = '" & txtDescriptionEdit.Text & "' WHERE shelfID = '" & shelfid & "'"

                        Try

                            cmd.Connection = connection
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        Catch ex As Exception

                            MsgBox("Failed " & ex.ToString)

                        End Try

                        connection.Close()

                        MsgBox("Success!")

                        txtShelfEdit.Enabled = False
                        txtDescriptionEdit.Enabled = False
                        btnUpdate.Enabled = False

                        txtShelfEdit.Text = Nothing
                        txtDescriptionEdit.Text = Nothing

                        shelfid = Nothing

                    Case MsgBoxResult.No

                End Select

            End If

            connection.Close()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        txtShelfAdd.Text = Nothing
        txtDescriptionAdd.Text = Nothing

        txtShelfEdit.Enabled = False
        txtDescriptionEdit.Enabled = False
        btnUpdate.Enabled = False

        txtShelfEdit.Text = Nothing
        txtDescriptionEdit.Text = Nothing

        shelfid = Nothing

        frmBooks.Show()
        Me.Hide()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstvShelves.SelectedItems.Count < 1 Then
            MsgBox("No Shelves Selected")
        Else

            Dim selected As Integer = lstvShelves.SelectedItems.Count

            Dim IDshelf As New DataTable()

            IDshelf.Columns.Add("Column1", GetType(System.String))

            For i As Integer = selected - 1 To 0 Step -1

                IDshelf.Rows.Add(lstvShelves.SelectedItems(i).SubItems(2).Text)

            Next

            Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Confirm")

                Case MsgBoxResult.Yes

                    OpenConnection()
                    cmd = New SqlCommand

                    For i As Integer = selected - 1 To 0 Step -1

                        sql = "UPDATE tblBooks SET shelfid = NULL WHERE shelfID = '" & IDshelf.Rows(i)(0).ToString & "'"

                        Try

                            cmd.Connection = connection
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        Catch ex As Exception

                            MsgBox("Failed " & ex.ToString)

                        End Try

                        sql = "DELETE  FROM tblShelf WHERE shelfID = '" & IDshelf.Rows(i)(0).ToString & "'"

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

                Case MsgBoxResult.No

            End Select

            selected = 0

            frmShelf_Activated(sender, e)

        End If

    End Sub

    Private Sub lstvShelves_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstvShelves.MouseDoubleClick
        If lstvShelves.SelectedItems.Count = 1 Then
            btnEdit_Click(sender, e)
        End If
    End Sub

End Class