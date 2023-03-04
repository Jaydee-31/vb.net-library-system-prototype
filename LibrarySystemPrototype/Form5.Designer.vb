<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCnfrmPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtCrrntPass = New System.Windows.Forms.TextBox()
        Me.lblPass3 = New System.Windows.Forms.Label()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.lblPass1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCnfrmPass
        '
        Me.txtCnfrmPass.Location = New System.Drawing.Point(172, 86)
        Me.txtCnfrmPass.Name = "txtCnfrmPass"
        Me.txtCnfrmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCnfrmPass.Size = New System.Drawing.Size(100, 20)
        Me.txtCnfrmPass.TabIndex = 13
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(172, 53)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass.TabIndex = 12
        '
        'txtCrrntPass
        '
        Me.txtCrrntPass.Location = New System.Drawing.Point(172, 10)
        Me.txtCrrntPass.Name = "txtCrrntPass"
        Me.txtCrrntPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCrrntPass.Size = New System.Drawing.Size(100, 20)
        Me.txtCrrntPass.TabIndex = 11
        '
        'lblPass3
        '
        Me.lblPass3.AutoSize = True
        Me.lblPass3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass3.Location = New System.Drawing.Point(12, 85)
        Me.lblPass3.Name = "lblPass3"
        Me.lblPass3.Size = New System.Drawing.Size(132, 18)
        Me.lblPass3.TabIndex = 10
        Me.lblPass3.Text = "Confirm Password"
        '
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass2.Location = New System.Drawing.Point(12, 52)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(109, 18)
        Me.lblPass2.TabIndex = 9
        Me.lblPass2.Text = "New Password"
        '
        'lblPass1
        '
        Me.lblPass1.AutoSize = True
        Me.lblPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass1.Location = New System.Drawing.Point(12, 9)
        Me.lblPass1.Name = "lblPass1"
        Me.lblPass1.Size = New System.Drawing.Size(128, 18)
        Me.lblPass1.TabIndex = 8
        Me.lblPass1.Text = "Current Password"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 139)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 40)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(183, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 191)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtCnfrmPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtCrrntPass)
        Me.Controls.Add(Me.lblPass3)
        Me.Controls.Add(Me.lblPass2)
        Me.Controls.Add(Me.lblPass1)
        Me.Name = "frmChangePass"
        Me.Text = "Library System - Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCnfrmPass As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtCrrntPass As TextBox
    Friend WithEvents lblPass3 As Label
    Friend WithEvents lblPass2 As Label
    Friend WithEvents lblPass1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
End Class
