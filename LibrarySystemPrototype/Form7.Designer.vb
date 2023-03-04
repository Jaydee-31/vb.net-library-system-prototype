<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookAdd
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
        Me.rbAddExisting = New System.Windows.Forms.RadioButton()
        Me.rbAddNew = New System.Windows.Forms.RadioButton()
        Me.lblSelectBook = New System.Windows.Forms.Label()
        Me.comboSelectBook = New System.Windows.Forms.ComboBox()
        Me.lblExistingISBN = New System.Windows.Forms.Label()
        Me.comboISBN = New System.Windows.Forms.ComboBox()
        Me.lblExistingShelf = New System.Windows.Forms.Label()
        Me.comboExistingShelf = New System.Windows.Forms.ComboBox()
        Me.btnAddExisting = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblNewISBN = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.comboNewShelf = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblNewShelf = New System.Windows.Forms.Label()
        Me.lstvAuthor = New System.Windows.Forms.ListView()
        Me.last = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.given = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.middle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.btnAddAuthor = New System.Windows.Forms.Button()
        Me.btnRemoveAuthor = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbAddExisting
        '
        Me.rbAddExisting.AutoSize = True
        Me.rbAddExisting.Checked = True
        Me.rbAddExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAddExisting.Location = New System.Drawing.Point(38, 80)
        Me.rbAddExisting.Name = "rbAddExisting"
        Me.rbAddExisting.Size = New System.Drawing.Size(219, 22)
        Me.rbAddExisting.TabIndex = 0
        Me.rbAddExisting.TabStop = True
        Me.rbAddExisting.Text = "Add Book With Existing Copy"
        Me.rbAddExisting.UseVisualStyleBackColor = True
        '
        'rbAddNew
        '
        Me.rbAddNew.AutoSize = True
        Me.rbAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAddNew.Location = New System.Drawing.Point(38, 258)
        Me.rbAddNew.Name = "rbAddNew"
        Me.rbAddNew.Size = New System.Drawing.Size(125, 22)
        Me.rbAddNew.TabIndex = 1
        Me.rbAddNew.Text = "Add New Book"
        Me.rbAddNew.UseVisualStyleBackColor = True
        '
        'lblSelectBook
        '
        Me.lblSelectBook.AutoSize = True
        Me.lblSelectBook.Location = New System.Drawing.Point(98, 122)
        Me.lblSelectBook.Name = "lblSelectBook"
        Me.lblSelectBook.Size = New System.Drawing.Size(65, 13)
        Me.lblSelectBook.TabIndex = 2
        Me.lblSelectBook.Text = "Select Book"
        '
        'comboSelectBook
        '
        Me.comboSelectBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboSelectBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboSelectBook.FormattingEnabled = True
        Me.comboSelectBook.Location = New System.Drawing.Point(169, 119)
        Me.comboSelectBook.Name = "comboSelectBook"
        Me.comboSelectBook.Size = New System.Drawing.Size(190, 21)
        Me.comboSelectBook.TabIndex = 3
        '
        'lblExistingISBN
        '
        Me.lblExistingISBN.AutoSize = True
        Me.lblExistingISBN.Location = New System.Drawing.Point(98, 149)
        Me.lblExistingISBN.Name = "lblExistingISBN"
        Me.lblExistingISBN.Size = New System.Drawing.Size(32, 13)
        Me.lblExistingISBN.TabIndex = 4
        Me.lblExistingISBN.Text = "ISBN"
        '
        'comboISBN
        '
        Me.comboISBN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboISBN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboISBN.FormattingEnabled = True
        Me.comboISBN.Location = New System.Drawing.Point(169, 146)
        Me.comboISBN.Name = "comboISBN"
        Me.comboISBN.Size = New System.Drawing.Size(190, 21)
        Me.comboISBN.TabIndex = 5
        '
        'lblExistingShelf
        '
        Me.lblExistingShelf.AutoSize = True
        Me.lblExistingShelf.Location = New System.Drawing.Point(98, 176)
        Me.lblExistingShelf.Name = "lblExistingShelf"
        Me.lblExistingShelf.Size = New System.Drawing.Size(31, 13)
        Me.lblExistingShelf.TabIndex = 6
        Me.lblExistingShelf.Text = "Shelf"
        '
        'comboExistingShelf
        '
        Me.comboExistingShelf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboExistingShelf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboExistingShelf.FormattingEnabled = True
        Me.comboExistingShelf.Location = New System.Drawing.Point(169, 173)
        Me.comboExistingShelf.Name = "comboExistingShelf"
        Me.comboExistingShelf.Size = New System.Drawing.Size(190, 21)
        Me.comboExistingShelf.Sorted = True
        Me.comboExistingShelf.TabIndex = 7
        '
        'btnAddExisting
        '
        Me.btnAddExisting.Location = New System.Drawing.Point(284, 199)
        Me.btnAddExisting.Name = "btnAddExisting"
        Me.btnAddExisting.Size = New System.Drawing.Size(75, 23)
        Me.btnAddExisting.TabIndex = 8
        Me.btnAddExisting.Text = "Add"
        Me.btnAddExisting.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblNewISBN
        '
        Me.lblNewISBN.AutoSize = True
        Me.lblNewISBN.Location = New System.Drawing.Point(98, 302)
        Me.lblNewISBN.Name = "lblNewISBN"
        Me.lblNewISBN.Size = New System.Drawing.Size(32, 13)
        Me.lblNewISBN.TabIndex = 10
        Me.lblNewISBN.Text = "ISBN"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(169, 299)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(190, 20)
        Me.txtISBN.TabIndex = 11
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(169, 325)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(190, 20)
        Me.txtTitle.TabIndex = 12
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(169, 454)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(190, 20)
        Me.txtYear.TabIndex = 13
        '
        'comboNewShelf
        '
        Me.comboNewShelf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboNewShelf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboNewShelf.FormattingEnabled = True
        Me.comboNewShelf.Location = New System.Drawing.Point(169, 480)
        Me.comboNewShelf.Name = "comboNewShelf"
        Me.comboNewShelf.Size = New System.Drawing.Size(190, 21)
        Me.comboNewShelf.Sorted = True
        Me.comboNewShelf.TabIndex = 14
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(98, 328)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Title"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(98, 457)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = "Year"
        '
        'lblNewShelf
        '
        Me.lblNewShelf.AutoSize = True
        Me.lblNewShelf.Location = New System.Drawing.Point(98, 483)
        Me.lblNewShelf.Name = "lblNewShelf"
        Me.lblNewShelf.Size = New System.Drawing.Size(31, 13)
        Me.lblNewShelf.TabIndex = 17
        Me.lblNewShelf.Text = "Shelf"
        '
        'lstvAuthor
        '
        Me.lstvAuthor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.last, Me.given, Me.middle})
        Me.lstvAuthor.FullRowSelect = True
        Me.lstvAuthor.GridLines = True
        Me.lstvAuthor.Location = New System.Drawing.Point(169, 351)
        Me.lstvAuthor.Name = "lstvAuthor"
        Me.lstvAuthor.Size = New System.Drawing.Size(190, 97)
        Me.lstvAuthor.TabIndex = 18
        Me.lstvAuthor.UseCompatibleStateImageBehavior = False
        Me.lstvAuthor.View = System.Windows.Forms.View.Details
        '
        'last
        '
        Me.last.Text = "Last Name"
        Me.last.Width = 100
        '
        'given
        '
        Me.given.Text = "Given Name"
        Me.given.Width = 100
        '
        'middle
        '
        Me.middle.Text = "Middle Initial"
        Me.middle.Width = 40
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(98, 373)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(49, 13)
        Me.lblAuthor.TabIndex = 19
        Me.lblAuthor.Text = "Author(s)"
        '
        'btnAddAuthor
        '
        Me.btnAddAuthor.Location = New System.Drawing.Point(365, 351)
        Me.btnAddAuthor.Name = "btnAddAuthor"
        Me.btnAddAuthor.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAuthor.TabIndex = 20
        Me.btnAddAuthor.Text = "Add Author"
        Me.btnAddAuthor.UseVisualStyleBackColor = True
        '
        'btnRemoveAuthor
        '
        Me.btnRemoveAuthor.Location = New System.Drawing.Point(365, 380)
        Me.btnRemoveAuthor.Name = "btnRemoveAuthor"
        Me.btnRemoveAuthor.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAuthor.TabIndex = 21
        Me.btnRemoveAuthor.Text = "Remove"
        Me.btnRemoveAuthor.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(284, 507)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 22
        Me.btnAddNew.Text = "Add"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(365, 409)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAll.TabIndex = 23
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'frmBookAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnRemoveAuthor)
        Me.Controls.Add(Me.btnAddAuthor)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lstvAuthor)
        Me.Controls.Add(Me.lblNewShelf)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.comboNewShelf)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblNewISBN)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddExisting)
        Me.Controls.Add(Me.comboExistingShelf)
        Me.Controls.Add(Me.lblExistingShelf)
        Me.Controls.Add(Me.comboISBN)
        Me.Controls.Add(Me.lblExistingISBN)
        Me.Controls.Add(Me.comboSelectBook)
        Me.Controls.Add(Me.lblSelectBook)
        Me.Controls.Add(Me.rbAddNew)
        Me.Controls.Add(Me.rbAddExisting)
        Me.Name = "frmBookAdd"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbAddExisting As RadioButton
    Friend WithEvents rbAddNew As RadioButton
    Friend WithEvents lblSelectBook As Label
    Friend WithEvents comboSelectBook As ComboBox
    Friend WithEvents lblExistingISBN As Label
    Friend WithEvents comboISBN As ComboBox
    Friend WithEvents lblExistingShelf As Label
    Friend WithEvents comboExistingShelf As ComboBox
    Friend WithEvents btnAddExisting As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblNewISBN As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents comboNewShelf As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblNewShelf As Label
    Friend WithEvents lstvAuthor As ListView
    Friend WithEvents lblAuthor As Label
    Friend WithEvents btnAddAuthor As Button
    Friend WithEvents btnRemoveAuthor As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents last As ColumnHeader
    Friend WithEvents given As ColumnHeader
    Friend WithEvents middle As ColumnHeader
    Friend WithEvents btnRemoveAll As Button
End Class
