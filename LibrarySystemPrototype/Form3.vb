Public Class frmBody

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmAccount.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Confirm")
            Case MsgBoxResult.Yes

                frmLogin.ID = Nothing
                frmLogin.last = Nothing
                frmLogin.given = Nothing
                frmLogin.middle = Nothing
                frmLogin.type = Nothing
                frmLogin.course = Nothing
                frmLogin.type = Nothing

                frmLogin.Show()
                Me.Hide()

            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBooks.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmPatrons.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmReports.Show()
        Me.Hide()
    End Sub
End Class