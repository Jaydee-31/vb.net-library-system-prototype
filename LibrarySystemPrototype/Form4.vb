Public Class frmAccount

    Private Sub frmAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmBody.Show()
        Me.Hide()
    End Sub

    Private Sub frmAccount_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtID.Text = frmLogin.ID
        txtLast.Text = frmLogin.last
        txtGiven.Text = frmLogin.given
        txtMiddle.Text = frmLogin.middle
    End Sub

    Private Sub lnkPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPass.LinkClicked
        frmChangePass.Show()
        Me.Hide()
    End Sub

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class