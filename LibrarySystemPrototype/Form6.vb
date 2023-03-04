Imports System.Data.SqlClient

Public Class frmBooks

    Dim VID As Integer = Nothing
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

    Public edit As String = Nothing

    Dim dr As SqlDataReader
    Dim count As Integer = 0
    Dim count2 As Integer = 0
    Dim count3 As Integer = 0
    Dim count4 As Integer = 0
    Dim count5 As Integer = 0
    Dim cmd As SqlCommand
    Dim sql As String

    Private Sub frmBooks_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        txtSearch.Text = Nothing

        comboYear.Text = "None"
        comboYear2.Text = Nothing

        comboStatus.Text = "None"
        comboYear2.Items.Clear()

        chbxRange_CheckedChanged(sender, e)

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        sql = "SELECT * FROM tblShelf ORDER BY shelfName"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        count3 = 0
        While dr.Read
            count3 = count3 + 1
        End While
        dr.Close()

        Dim adapter5 As New SqlDataAdapter(cmd)
        Dim table5 As New DataTable()
        adapter5.Fill(table5)

        comboShelf.Items.Clear()
        comboShelf.Items.Add("None")
        comboShelf.Text = "None"

        For i = 0 To count3 - 1
            comboShelf.Items.Add(table5.Rows(i)(1).ToString())
        Next

        Syear()

        lstvBooks.Items.Clear()

        Vauthor = Nothing

        sql = "SELECT * FROM tblBooks ORDER BY title"
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

            VID = table.Rows(i)(0).ToString()
            Visbn = table.Rows(i)(1).ToString()
            Vnumber = table.Rows(i)(2).ToString()
            If table.Rows(i)(2) > 1 Then
                Vtitle = "(" + table.Rows(i)(2).ToString() + ") " + table.Rows(i)(3).ToString()
            Else
                Vtitle = table.Rows(i)(3).ToString()
            End If
            Vyear = table.Rows(i)(4).ToString()
            Vshelf = table.Rows(i)(5).ToString()
            Vstatus = table.Rows(i)(6).ToString()

            sql = "SELECT * FROM tblAuthorBook WHERE bookID = '" & table.Rows(i)(0).ToString() & "'"
            cmd.CommandText = sql

            count2 = 0

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

            Dim items As String() = {Vtitle, Vauthor, Vyear, Vshelf, Vstatus, VID, Vnumber}
            lstvBooks.Items.Add(Visbn).SubItems.AddRange(items)

            Vauthor = Nothing

        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmBody.Show()
        Me.Hide()
    End Sub

    Private Sub frmBooks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmBookAdd.Show()
        Me.Hide()
    End Sub

    Dim sortColumn As Integer = -1

    Private Sub lstvBooks_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstvBooks.ColumnClick
        If e.Column <> sortColumn Then

            sortColumn = e.Column

            Me.lstvBooks.Sorting = SortOrder.Ascending
        Else

            If lstvBooks.Sorting = SortOrder.Ascending Then
                Me.lstvBooks.Sorting = SortOrder.Descending
            Else
                Me.lstvBooks.Sorting = SortOrder.Ascending
            End If
        End If

        Me.lstvBooks.ListViewItemSorter = New ListViewItemComparer(e.Column, lstvBooks.Sorting)

        lstvBooks.Sort()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSearch.Text <> Nothing Then

            SearchA()

        Else

            SearchB()

        End If

    End Sub

    Private Sub chbxRange_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRange.CheckedChanged
        If Not (chbxRange.Checked) Then
            comboYear2.Enabled = False
        Else
            comboYear2.Enabled = True
        End If

        If comboYear.Text = "None" Then
            chbxRange.Checked = False
            chbxRange.Enabled = False
            comboYear2.Enabled = False
        Else
            comboYear2.Items.Clear()

            Dim yearDate As Integer = DateTime.UtcNow.Year
            For i = Val(comboYear.Text) To DateTime.UtcNow.Year - 1
                If i <> Val(comboYear.Text) Then
                    yearDate = yearDate - 1
                End If
                comboYear2.Items.Add(yearDate)
            Next

            If Val(comboYear2.Text) < Val(comboYear.Text) And comboYear2.Enabled = True Then
                comboYear2.Text = Val(comboYear.Text) + 1
            End If
        End If

    End Sub

    Private Sub comboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboYear.SelectedIndexChanged
        If comboYear.Text = "None" Then
            chbxRange.Checked = False
            chbxRange.Enabled = False
            comboYear2.Enabled = False
        Else
            comboYear2.Items.Clear()

            Dim yearDate As Integer = DateTime.UtcNow.Year
            For i = Val(comboYear.Text) To DateTime.UtcNow.Year - 1
                If i <> Val(comboYear.Text) Then
                    yearDate = yearDate - 1
                End If
                comboYear2.Items.Add(yearDate)
            Next

            If Val(comboYear2.Text) < Val(comboYear.Text) And comboYear2.Enabled = True Then
                comboYear2.Text = Val(comboYear.Text) + 1
            End If
        End If

        If Val(comboYear.Text) = DateTime.UtcNow.Year Then
            chbxRange.Checked = False
            chbxRange.Enabled = False
            comboYear2.Enabled = False
        Else
            chbxRange.Enabled = True
            chbxRange_CheckedChanged(sender, e)
        End If
    End Sub

    Private Sub Syear()
        If comboYear.Text = "None" Then
            chbxRange.Checked = False
            chbxRange.Enabled = False
            comboYear2.Enabled = False
        End If

        comboYear.Items.Clear()

        comboYear.Items.Add("None")

        Dim yearDate As Integer = DateTime.UtcNow.Year
        For i = 1860 To DateTime.UtcNow.Year
            If i <> 1860 Then
                yearDate = yearDate - 1
            End If
            comboYear.Items.Add(yearDate)
        Next
    End Sub

    Private Sub SearchA()

        lstvBooks.Items.Clear()

        Vauthor = Nothing

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        Dim Lstatus As String = comboStatus.Text
        Dim Lshelf As String = comboShelf.Text
        Dim Lyear As String = comboYear.Text
        Dim Lyear2 As String = comboYear2.Text
        Dim LyearF As String = Nothing

        If Lstatus = "None" Then
            Lstatus = "status LIKE '%%'"
        Else
            Lstatus = "status = '" + Lstatus + "'"
        End If
        If Lshelf = "None" Then
            Lshelf = "AND shelfid LIKE '%%'"
        Else

            sql = "SELECT * FROM tblShelf WHERE shelfName = '" & Lshelf & "'"
            cmd.CommandText = sql

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            Lshelf = "AND shelfid = '" & table2.Rows(0)(0).ToString() & "'"

        End If
        If Lyear = "None" Then
            Lyear = Nothing
        End If

        If (chbxRange.Checked) Then
            LyearF = "AND (year >= '" & Lyear & "' AND year <= '" & Lyear2 & "')"
        Else
            LyearF = "AND year LIKE '%" + Lyear + "%'"
        End If

        sql = "SELECT * FROM tblBooks WHERE (title LIKE '%" + txtSearch.Text + "%' OR isbn = '" & txtSearch.Text & "') AND (" + Lstatus + " " + Lshelf + " " + LyearF + ") ORDER BY title"

        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        count4 = 0
        While dr.Read
            count4 = count4 + 1
        End While
        dr.Close()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        For i = 0 To count4 - 1

            VID = table.Rows(i)(0).ToString()
            Visbn = table.Rows(i)(1).ToString()
            Vnumber = table.Rows(i)(2).ToString()
            If table.Rows(i)(2) > 1 Then
                Vtitle = table.Rows(i)(3).ToString() + " (" + table.Rows(i)(2).ToString() + ")"
            Else
                Vtitle = table.Rows(i)(3).ToString()
            End If
            Vyear = table.Rows(i)(4).ToString()
            Vshelf = table.Rows(i)(5).ToString()
            Vstatus = table.Rows(i)(6).ToString()

            sql = "SELECT * FROM tblAuthorBook WHERE bookID = '" & table.Rows(i)(0).ToString() & "'"
            cmd.CommandText = sql

            count5 = 0

            dr = cmd.ExecuteReader()
            While dr.Read
                count5 = count5 + 1
            End While
            dr.Close()

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            For o = 0 To count5 - 1

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

                If o < count5 - 1 Then
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

            Vshelf = table4.Rows(0)(1).ToString()

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

            Dim items As String() = {Vtitle, Vauthor, Vyear, Vshelf, Vstatus, VID, Vnumber}
            lstvBooks.Items.Add(Visbn).SubItems.AddRange(items)

            Vauthor = Nothing

        Next

    End Sub

    Private Sub SearchB()

        lstvBooks.Items.Clear()

        Vauthor = Nothing

        OpenConnection()

        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection

        Dim Lstatus As String = comboStatus.Text
        Dim Lshelf As String = comboShelf.Text
        Dim Lyear As String = comboYear.Text
        Dim Lyear2 As String = comboYear2.Text
        Dim LyearF As String = Nothing

        If Lstatus = "None" Then
            Lstatus = "status LIKE '%%'"
        Else
            Lstatus = "status = '" + Lstatus + "'"
        End If
        If Lshelf = "None" Then
            Lshelf = "AND shelfid LIKE '%%'"
        Else

            sql = "SELECT * FROM tblShelf WHERE shelfName = '" & Lshelf & "'"
            cmd.CommandText = sql

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            Lshelf = "AND shelfid = '" & table2.Rows(0)(0).ToString() & "'"

        End If
        If Lyear = "None" Then
            Lyear = Nothing
        End If

        If (chbxRange.Checked) Then
            LyearF = "AND (year >= '" & Lyear & "' AND year <= '" & Lyear2 & "')"
        Else
            LyearF = "AND year LIKE '%" + Lyear + "%'"
        End If

        sql = "SELECT * FROM tblBooks WHERE " + Lstatus + " " + Lshelf + " " + LyearF + " ORDER BY title"

        cmd.CommandText = sql

        dr = cmd.ExecuteReader()
        count4 = 0
        While dr.Read
            count4 = count4 + 1
        End While
        dr.Close()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        For i = 0 To count4 - 1

            VID = table.Rows(i)(0).ToString()
            Visbn = table.Rows(i)(1).ToString()
            Vnumber = table.Rows(i)(2).ToString()
            If table.Rows(i)(2) > 1 Then
                Vtitle = table.Rows(i)(3).ToString() + " (" + table.Rows(i)(2).ToString() + ")"
            Else
                Vtitle = table.Rows(i)(3).ToString()
            End If
            Vyear = table.Rows(i)(4).ToString()
            Vshelf = table.Rows(i)(5).ToString()
            Vstatus = table.Rows(i)(6).ToString()

            sql = "SELECT * FROM tblAuthorBook WHERE bookID = '" & table.Rows(i)(0).ToString() & "'"
            cmd.CommandText = sql

            count5 = 0

            dr = cmd.ExecuteReader()
            While dr.Read
                count5 = count5 + 1
            End While
            dr.Close()

            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)

            For o = 0 To count5 - 1

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

                If o < count5 - 1 Then
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

            Vshelf = table4.Rows(0)(1).ToString()

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

            Dim items As String() = {Vtitle, Vauthor, Vyear, Vshelf, Vstatus, VID, Vnumber}
            lstvBooks.Items.Add(Visbn).SubItems.AddRange(items)

            Vauthor = Nothing

        Next

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstvBooks.SelectedItems.Count < 1 Then
            MsgBox("No Books Selected")
        Else

            Dim selected As Integer = lstvBooks.SelectedItems.Count

            Dim IDbook As New DataTable()

            IDbook.Columns.Add("Column1", GetType(System.String))

            For i As Integer = selected - 1 To 0 Step -1

                IDbook.Rows.Add(lstvBooks.SelectedItems(i).SubItems(6).Text)

            Next

            Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Confirm")

                Case MsgBoxResult.Yes

                    OpenConnection()
                    cmd = New SqlCommand

                    For i As Integer = selected - 1 To 0 Step -1

                        sql = "DELETE  FROM tblAuthorBook WHERE bookID = '" & IDbook.Rows(i)(0).ToString & "'"
                        Try

                            cmd.Connection = connection
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        Catch ex As Exception

                            MsgBox("Failed " & ex.ToString)

                        End Try

                        sql = "DELETE  FROM tblBooks WHERE bookID = '" & IDbook.Rows(i)(0).ToString & "'"
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

            connection.Close()

            selected = 0

            frmBooks_Activated(sender, e)

        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lstvBooks.SelectedItems.Count < 1 Then
            MsgBox("No Book Selected")
        ElseIf lstvBooks.SelectedItems.Count > 1 Then
            MsgBox("Select Only One Book")
        Else

            edit = lstvBooks.SelectedItems(0).SubItems(6).Text

            frmEditBooks.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub btnShelf_Click(sender As Object, e As EventArgs) Handles btnShelf.Click
        frmShelf.Show()
        Me.Hide()
    End Sub

    Private Sub lstvBooks_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstvBooks.MouseDoubleClick
        If lstvBooks.SelectedItems.Count = 1 Then
            btnEdit_Click(sender, e)
        End If
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        If lstvBooks.SelectedItems.Count < 1 Then
            MsgBox("No Book Selected")
        ElseIf lstvBooks.SelectedItems.Count > 1 Then
            MsgBox("Select Only One Book")
        Else
            If lstvBooks.SelectedItems(0).SubItems(5).Text <> "on-shelf" Then
                MsgBox("Cannot Borrow This Book")
            Else

                edit = lstvBooks.SelectedItems(0).SubItems(6).Text

                frmBorrow.Show()
                Me.Hide()

            End If

        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Me.Hide()
        frmReturn.Show()

    End Sub

End Class