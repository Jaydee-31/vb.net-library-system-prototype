<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAuthor
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
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblGiven = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lstvAuthors = New System.Windows.Forms.ListView()
        Me.last = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.given = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.middle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(30, 30)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 0
        Me.lblLast.Text = "Last Name"
        '
        'lblGiven
        '
        Me.lblGiven.AutoSize = True
        Me.lblGiven.Location = New System.Drawing.Point(30, 56)
        Me.lblGiven.Name = "lblGiven"
        Me.lblGiven.Size = New System.Drawing.Size(66, 13)
        Me.lblGiven.TabIndex = 1
        Me.lblGiven.Text = "Given Name"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(105, 27)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(133, 20)
        Me.txtLast.TabIndex = 2
        '
        'txtGiven
        '
        Me.txtGiven.Location = New System.Drawing.Point(105, 53)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.Size = New System.Drawing.Size(133, 20)
        Me.txtGiven.TabIndex = 3
        '
        'txtMiddle
        '
        Me.txtMiddle.Location = New System.Drawing.Point(105, 79)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(53, 20)
        Me.txtMiddle.TabIndex = 4
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Location = New System.Drawing.Point(30, 82)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(65, 13)
        Me.lblMiddle.TabIndex = 5
        Me.lblMiddle.Text = "Middle Initial"
        '
        'lstvAuthors
        '
        Me.lstvAuthors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.last, Me.given, Me.middle})
        Me.lstvAuthors.GridLines = True
        Me.lstvAuthors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstvAuthors.Location = New System.Drawing.Point(12, 146)
        Me.lstvAuthors.Name = "lstvAuthors"
        Me.lstvAuthors.Size = New System.Drawing.Size(260, 224)
        Me.lstvAuthors.TabIndex = 6
        Me.lstvAuthors.UseCompatibleStateImageBehavior = False
        Me.lstvAuthors.View = System.Windows.Forms.View.Details
        '
        'last
        '
        Me.last.Text = "Last"
        Me.last.Width = 100
        '
        'given
        '
        Me.given.Text = "Given"
        Me.given.Width = 100
        '
        'middle
        '
        Me.middle.Text = "Middle"
        Me.middle.Width = 50
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(127, 117)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(197, 376)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(116, 376)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmAddAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstvAuthors)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtGiven)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.lblGiven)
        Me.Controls.Add(Me.lblLast)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmAddAuthor"
        Me.Text = "Add Author"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLast As Label
    Friend WithEvents lblGiven As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtGiven As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lstvAuthors As ListView
    Friend WithEvents btnAdd As Button
    Friend WithEvents last As ColumnHeader
    Friend WithEvents given As ColumnHeader
    Friend WithEvents middle As ColumnHeader
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
End Class
