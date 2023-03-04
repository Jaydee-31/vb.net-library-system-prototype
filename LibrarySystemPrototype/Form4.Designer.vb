<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblGiven = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lnkPass = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(12, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(79, 18)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID Number"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(12, 42)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(80, 18)
        Me.lblLast.TabIndex = 1
        Me.lblLast.Text = "Last Name"
        '
        'lblGiven
        '
        Me.lblGiven.AutoSize = True
        Me.lblGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiven.Location = New System.Drawing.Point(12, 75)
        Me.lblGiven.Name = "lblGiven"
        Me.lblGiven.Size = New System.Drawing.Size(90, 18)
        Me.lblGiven.TabIndex = 2
        Me.lblGiven.Text = "Given Name"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.Location = New System.Drawing.Point(12, 108)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(95, 18)
        Me.lblMiddle.TabIndex = 3
        Me.lblMiddle.Text = "Middle Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(137, 10)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(137, 43)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.ReadOnly = True
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 6
        '
        'txtGiven
        '
        Me.txtGiven.Location = New System.Drawing.Point(137, 76)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.ReadOnly = True
        Me.txtGiven.Size = New System.Drawing.Size(100, 20)
        Me.txtGiven.TabIndex = 7
        '
        'txtMiddle
        '
        Me.txtMiddle.Location = New System.Drawing.Point(137, 109)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.ReadOnly = True
        Me.txtMiddle.Size = New System.Drawing.Size(100, 20)
        Me.txtMiddle.TabIndex = 8
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(16, 172)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 40)
        Me.btnMenu.TabIndex = 10
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lnkPass
        '
        Me.lnkPass.AutoSize = True
        Me.lnkPass.Location = New System.Drawing.Point(144, 149)
        Me.lnkPass.Name = "lnkPass"
        Me.lnkPass.Size = New System.Drawing.Size(93, 13)
        Me.lnkPass.TabIndex = 11
        Me.lnkPass.TabStop = True
        Me.lnkPass.Text = "Change Password"
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 231)
        Me.Controls.Add(Me.lnkPass)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtGiven)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblGiven)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmAccount"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblGiven As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtGiven As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents lnkPass As LinkLabel
End Class
