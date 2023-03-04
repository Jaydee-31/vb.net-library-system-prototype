<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUser
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
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblGiven = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(244, 279)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 26)
        Me.txtAddress.TabIndex = 33
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(84, 278)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(91, 25)
        Me.lblAddress.TabIndex = 32
        Me.lblAddress.Text = "Address"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 31
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'comboType
        '
        Me.comboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"Student", "Faculty", "Former Student/Faculty"})
        Me.comboType.Location = New System.Drawing.Point(244, 245)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(178, 28)
        Me.comboType.TabIndex = 29
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(84, 245)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(64, 25)
        Me.lblType.TabIndex = 28
        Me.lblType.Text = "Type"
        '
        'comboCourse
        '
        Me.comboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Location = New System.Drawing.Point(244, 211)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(178, 28)
        Me.comboCourse.TabIndex = 27
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(183, 356)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtMiddle
        '
        Me.txtMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle.Location = New System.Drawing.Point(244, 180)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(178, 26)
        Me.txtMiddle.TabIndex = 25
        '
        'txtGiven
        '
        Me.txtGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiven.Location = New System.Drawing.Point(244, 148)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.Size = New System.Drawing.Size(178, 26)
        Me.txtGiven.TabIndex = 24
        '
        'txtLast
        '
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(244, 116)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(178, 26)
        Me.txtLast.TabIndex = 23
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(244, 84)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(178, 26)
        Me.txtID.TabIndex = 21
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(84, 211)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(81, 25)
        Me.lblCourse.TabIndex = 20
        Me.lblCourse.Text = "Course"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.Location = New System.Drawing.Point(84, 179)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(138, 25)
        Me.lblMiddle.TabIndex = 19
        Me.lblMiddle.Text = "Middle Name"
        '
        'lblGiven
        '
        Me.lblGiven.AutoSize = True
        Me.lblGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiven.Location = New System.Drawing.Point(84, 147)
        Me.lblGiven.Name = "lblGiven"
        Me.lblGiven.Size = New System.Drawing.Size(140, 25)
        Me.lblGiven.TabIndex = 18
        Me.lblGiven.Text = "Given Name"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(84, 115)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(124, 25)
        Me.lblLast.TabIndex = 17
        Me.lblLast.Text = "Last Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(84, 83)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(122, 25)
        Me.lblID.TabIndex = 22
        Me.lblID.Text = "ID Number"
        '
        'frmEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 391)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.comboType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtGiven)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblGiven)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmEditUser"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents comboType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents txtGiven As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblGiven As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblID As Label
End Class
