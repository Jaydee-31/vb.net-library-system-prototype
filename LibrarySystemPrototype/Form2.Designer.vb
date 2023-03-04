<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPatron
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
        Me.lblSignup = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblGiven = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSignup
        '
        Me.lblSignup.AutoSize = True
        Me.lblSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignup.Location = New System.Drawing.Point(255, 9)
        Me.lblSignup.Name = "lblSignup"
        Me.lblSignup.Size = New System.Drawing.Size(149, 31)
        Me.lblSignup.TabIndex = 0
        Me.lblSignup.Text = "Add Patron"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(84, 83)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(122, 25)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID Number"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(84, 115)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(124, 25)
        Me.lblLast.TabIndex = 0
        Me.lblLast.Text = "Last Name"
        '
        'lblGiven
        '
        Me.lblGiven.AutoSize = True
        Me.lblGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiven.Location = New System.Drawing.Point(84, 147)
        Me.lblGiven.Name = "lblGiven"
        Me.lblGiven.Size = New System.Drawing.Size(140, 25)
        Me.lblGiven.TabIndex = 0
        Me.lblGiven.Text = "Given Name"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.Location = New System.Drawing.Point(84, 179)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(138, 25)
        Me.lblMiddle.TabIndex = 0
        Me.lblMiddle.Text = "Middle Name"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(84, 211)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(81, 25)
        Me.lblCourse.TabIndex = 0
        Me.lblCourse.Text = "Course"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(244, 84)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(178, 26)
        Me.txtID.TabIndex = 0
        '
        'txtLast
        '
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(244, 116)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(178, 26)
        Me.txtLast.TabIndex = 1
        '
        'txtGiven
        '
        Me.txtGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiven.Location = New System.Drawing.Point(244, 148)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.Size = New System.Drawing.Size(178, 26)
        Me.txtGiven.TabIndex = 2
        '
        'txtMiddle
        '
        Me.txtMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle.Location = New System.Drawing.Point(244, 180)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(178, 26)
        Me.txtMiddle.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(183, 356)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'comboCourse
        '
        Me.comboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Location = New System.Drawing.Point(244, 211)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(178, 28)
        Me.comboCourse.TabIndex = 9
        '
        'comboType
        '
        Me.comboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"Student", "Faculty", "Former Student/Faculty"})
        Me.comboType.Location = New System.Drawing.Point(244, 245)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(178, 28)
        Me.comboType.TabIndex = 11
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(84, 245)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(64, 25)
        Me.lblType.TabIndex = 10
        Me.lblType.Text = "Type"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(113, 334)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(224, 13)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "ID NUMBER IS THE DEFAULT PASSWORD"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(244, 279)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 26)
        Me.txtAddress.TabIndex = 15
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(84, 278)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(91, 25)
        Me.lblAddress.TabIndex = 14
        Me.lblAddress.Text = "Address"
        '
        'frmAddPatron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 391)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.comboType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtGiven)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblGiven)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblSignup)
        Me.Name = "frmAddPatron"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System - Add Patron"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSignup As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblGiven As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtGiven As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents comboType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
End Class
