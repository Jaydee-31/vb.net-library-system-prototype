<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstvBooks = New System.Windows.Forms.ListView()
        Me.isbn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shelf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.comboYear = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.comboShelf = New System.Windows.Forms.ComboBox()
        Me.lblShelf = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.comboYear2 = New System.Windows.Forms.ComboBox()
        Me.chbxRange = New System.Windows.Forms.CheckBox()
        Me.btnShelf = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 409)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 40)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstvBooks
        '
        Me.lstvBooks.AutoArrange = False
        Me.lstvBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.isbn, Me.title, Me.author, Me.year, Me.shelf, Me.status})
        Me.lstvBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvBooks.FullRowSelect = True
        Me.lstvBooks.GridLines = True
        Me.lstvBooks.Location = New System.Drawing.Point(1, 69)
        Me.lstvBooks.Name = "lstvBooks"
        Me.lstvBooks.Size = New System.Drawing.Size(582, 334)
        Me.lstvBooks.TabIndex = 7
        Me.lstvBooks.UseCompatibleStateImageBehavior = False
        Me.lstvBooks.View = System.Windows.Forms.View.Details
        '
        'isbn
        '
        Me.isbn.Text = "ISBN"
        Me.isbn.Width = 100
        '
        'title
        '
        Me.title.Text = "Title"
        Me.title.Width = 140
        '
        'author
        '
        Me.author.Text = "Author(s)"
        Me.author.Width = 140
        '
        'year
        '
        Me.year.Text = "Year"
        Me.year.Width = 50
        '
        'shelf
        '
        Me.shelf.Text = "Shelf"
        Me.shelf.Width = 70
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 70
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(482, 409)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 40)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(386, 409)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(90, 40)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(202, 24)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(220, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(290, 409)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 40)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'comboYear
        '
        Me.comboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboYear.FormattingEnabled = True
        Me.comboYear.Items.AddRange(New Object() {"None"})
        Me.comboYear.Location = New System.Drawing.Point(363, 39)
        Me.comboYear.Name = "comboYear"
        Me.comboYear.Size = New System.Drawing.Size(76, 21)
        Me.comboYear.TabIndex = 5
        Me.comboYear.Text = "None"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(328, 47)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'comboShelf
        '
        Me.comboShelf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboShelf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboShelf.FormattingEnabled = True
        Me.comboShelf.Items.AddRange(New Object() {"None"})
        Me.comboShelf.Location = New System.Drawing.Point(496, 12)
        Me.comboShelf.Name = "comboShelf"
        Me.comboShelf.Size = New System.Drawing.Size(76, 21)
        Me.comboShelf.TabIndex = 4
        Me.comboShelf.Text = "None"
        '
        'lblShelf
        '
        Me.lblShelf.AutoSize = True
        Me.lblShelf.Location = New System.Drawing.Point(461, 20)
        Me.lblShelf.Name = "lblShelf"
        Me.lblShelf.Size = New System.Drawing.Size(31, 13)
        Me.lblShelf.TabIndex = 0
        Me.lblShelf.Text = "Shelf"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(320, 20)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status"
        '
        'comboStatus
        '
        Me.comboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"None", "on-shelf", "on-loan", "on-hold", "on-loan-and-on-hold"})
        Me.comboStatus.Location = New System.Drawing.Point(363, 12)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(76, 21)
        Me.comboStatus.TabIndex = 3
        Me.comboStatus.Text = "None"
        '
        'comboYear2
        '
        Me.comboYear2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboYear2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboYear2.FormattingEnabled = True
        Me.comboYear2.Location = New System.Drawing.Point(496, 39)
        Me.comboYear2.Name = "comboYear2"
        Me.comboYear2.Size = New System.Drawing.Size(76, 21)
        Me.comboYear2.TabIndex = 6
        '
        'chbxRange
        '
        Me.chbxRange.AutoSize = True
        Me.chbxRange.Location = New System.Drawing.Point(451, 43)
        Me.chbxRange.Name = "chbxRange"
        Me.chbxRange.Size = New System.Drawing.Size(35, 17)
        Me.chbxRange.TabIndex = 15
        Me.chbxRange.Text = "to"
        Me.chbxRange.UseVisualStyleBackColor = True
        '
        'btnShelf
        '
        Me.btnShelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShelf.Location = New System.Drawing.Point(130, 409)
        Me.btnShelf.Name = "btnShelf"
        Me.btnShelf.Size = New System.Drawing.Size(135, 40)
        Me.btnShelf.TabIndex = 16
        Me.btnShelf.Text = "Manage Shelves"
        Me.btnShelf.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.Location = New System.Drawing.Point(12, 42)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(75, 24)
        Me.btnBorrow.TabIndex = 17
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(93, 42)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 24)
        Me.btnReturn.TabIndex = 18
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnShelf)
        Me.Controls.Add(Me.chbxRange)
        Me.Controls.Add(Me.comboYear2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.lblShelf)
        Me.Controls.Add(Me.comboShelf)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.comboYear)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstvBooks)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmBooks"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents lstvBooks As ListView
    Friend WithEvents isbn As ColumnHeader
    Friend WithEvents title As ColumnHeader
    Friend WithEvents author As ColumnHeader
    Friend WithEvents year As ColumnHeader
    Friend WithEvents shelf As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents comboYear As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents comboShelf As ComboBox
    Friend WithEvents lblShelf As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents comboYear2 As ComboBox
    Friend WithEvents chbxRange As CheckBox
    Friend WithEvents btnShelf As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReturn As Button
End Class
