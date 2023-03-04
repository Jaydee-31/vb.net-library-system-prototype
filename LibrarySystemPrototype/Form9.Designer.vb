<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatrons
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstvUsers = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.last = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.given = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.middle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.course = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chbxStudent = New System.Windows.Forms.CheckBox()
        Me.chbxFaculty = New System.Windows.Forms.CheckBox()
        Me.chbxLibrarian = New System.Windows.Forms.CheckBox()
        Me.chbxFormer = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(296, 459)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 40)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(392, 459)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(90, 40)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(488, 459)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 40)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 459)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 40)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(311, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 24)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(293, 24)
        Me.txtSearch.TabIndex = 16
        '
        'lstvUsers
        '
        Me.lstvUsers.AutoArrange = False
        Me.lstvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.last, Me.given, Me.middle, Me.type, Me.course, Me.address})
        Me.lstvUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvUsers.FullRowSelect = True
        Me.lstvUsers.GridLines = True
        Me.lstvUsers.Location = New System.Drawing.Point(12, 89)
        Me.lstvUsers.Name = "lstvUsers"
        Me.lstvUsers.Size = New System.Drawing.Size(580, 364)
        Me.lstvUsers.TabIndex = 8
        Me.lstvUsers.UseCompatibleStateImageBehavior = False
        Me.lstvUsers.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID Number"
        Me.id.Width = 100
        '
        'last
        '
        Me.last.Text = "Last Name"
        Me.last.Width = 150
        '
        'given
        '
        Me.given.Text = "Given Name"
        Me.given.Width = 150
        '
        'middle
        '
        Me.middle.Text = "Middle Name"
        Me.middle.Width = 150
        '
        'type
        '
        Me.type.Text = "Type"
        '
        'course
        '
        Me.course.Text = "Course"
        '
        'address
        '
        Me.address.Text = "Address"
        Me.address.Width = 150
        '
        'comboCourse
        '
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Items.AddRange(New Object() {"None"})
        Me.comboCourse.Location = New System.Drawing.Point(471, 16)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(121, 21)
        Me.comboCourse.TabIndex = 19
        Me.comboCourse.Text = "None"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Course"
        '
        'chbxStudent
        '
        Me.chbxStudent.AutoSize = True
        Me.chbxStudent.Checked = True
        Me.chbxStudent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbxStudent.Location = New System.Drawing.Point(391, 43)
        Me.chbxStudent.Name = "chbxStudent"
        Me.chbxStudent.Size = New System.Drawing.Size(63, 17)
        Me.chbxStudent.TabIndex = 22
        Me.chbxStudent.Text = "Student"
        Me.chbxStudent.UseVisualStyleBackColor = True
        '
        'chbxFaculty
        '
        Me.chbxFaculty.AutoSize = True
        Me.chbxFaculty.Checked = True
        Me.chbxFaculty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbxFaculty.Location = New System.Drawing.Point(460, 43)
        Me.chbxFaculty.Name = "chbxFaculty"
        Me.chbxFaculty.Size = New System.Drawing.Size(60, 17)
        Me.chbxFaculty.TabIndex = 23
        Me.chbxFaculty.Text = "Faculty"
        Me.chbxFaculty.UseVisualStyleBackColor = True
        '
        'chbxLibrarian
        '
        Me.chbxLibrarian.AutoSize = True
        Me.chbxLibrarian.Checked = True
        Me.chbxLibrarian.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbxLibrarian.Location = New System.Drawing.Point(526, 43)
        Me.chbxLibrarian.Name = "chbxLibrarian"
        Me.chbxLibrarian.Size = New System.Drawing.Size(66, 17)
        Me.chbxLibrarian.TabIndex = 24
        Me.chbxLibrarian.Text = "Librarian"
        Me.chbxLibrarian.UseVisualStyleBackColor = True
        '
        'chbxFormer
        '
        Me.chbxFormer.AutoSize = True
        Me.chbxFormer.Location = New System.Drawing.Point(428, 66)
        Me.chbxFormer.Name = "chbxFormer"
        Me.chbxFormer.Size = New System.Drawing.Size(137, 17)
        Me.chbxFormer.TabIndex = 25
        Me.chbxFormer.Text = "Former Student/Faculty"
        Me.chbxFormer.UseVisualStyleBackColor = True
        '
        'frmPatrons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 511)
        Me.Controls.Add(Me.chbxFormer)
        Me.Controls.Add(Me.chbxLibrarian)
        Me.Controls.Add(Me.chbxFaculty)
        Me.Controls.Add(Me.chbxStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstvUsers)
        Me.Name = "frmPatrons"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstvUsers As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents last As ColumnHeader
    Friend WithEvents given As ColumnHeader
    Friend WithEvents middle As ColumnHeader
    Friend WithEvents type As ColumnHeader
    Friend WithEvents course As ColumnHeader
    Friend WithEvents address As ColumnHeader
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chbxStudent As CheckBox
    Friend WithEvents chbxFaculty As CheckBox
    Friend WithEvents chbxLibrarian As CheckBox
    Friend WithEvents chbxFormer As CheckBox
End Class
