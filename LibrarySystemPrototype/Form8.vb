Public Class frmAddAuthor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtLast.Text = Nothing And txtGiven.Text = Nothing And txtMiddle.Text = Nothing Then

            MsgBox("No Author")

        Else

            Dim items As String() = {txtGiven.Text, txtMiddle.Text}
            lstvAuthors.Items.Add(txtLast.Text).SubItems.AddRange(items)

            txtLast.Text = Nothing
            txtGiven.Text = Nothing
            txtMiddle.Text = Nothing

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lstvAuthors.Items.Clear()
        txtLast.Text = Nothing
        txtGiven.Text = Nothing
        txtMiddle.Text = Nothing
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim Items(lstvAuthors.Items.Count - 1) As ListViewItem
        For i As Integer = 0 To lstvAuthors.Items.Count - 1
            Items(i) = CType(lstvAuthors.Items(i).Clone, ListViewItem)
        Next
        frmBookAdd.lstvAuthor.Items.AddRange(Items)

        lstvAuthors.Items.Clear()

        txtLast.Text = Nothing
        txtGiven.Text = Nothing
        txtMiddle.Text = Nothing

        Me.Close()

    End Sub
End Class