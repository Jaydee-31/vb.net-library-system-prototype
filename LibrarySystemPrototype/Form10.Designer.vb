<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditBooks
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
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemoveAuthor = New System.Windows.Forms.Button()
        Me.btnAddAuthor = New System.Windows.Forms.Button()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lstvAuthor = New System.Windows.Forms.ListView()
        Me.last = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.given = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.middle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblShelf = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.comboShelf = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.chbxHold = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(284, 178)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAll.TabIndex = 37
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(203, 276)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRemoveAuthor
        '
        Me.btnRemoveAuthor.Location = New System.Drawing.Point(284, 149)
        Me.btnRemoveAuthor.Name = "btnRemoveAuthor"
        Me.btnRemoveAuthor.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAuthor.TabIndex = 35
        Me.btnRemoveAuthor.Text = "Remove"
        Me.btnRemoveAuthor.UseVisualStyleBackColor = True
        '
        'btnAddAuthor
        '
        Me.btnAddAuthor.Location = New System.Drawing.Point(284, 120)
        Me.btnAddAuthor.Name = "btnAddAuthor"
        Me.btnAddAuthor.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAuthor.TabIndex = 34
        Me.btnAddAuthor.Text = "Add Author"
        Me.btnAddAuthor.UseVisualStyleBackColor = True
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(17, 142)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(49, 13)
        Me.lblAuthor.TabIndex = 33
        Me.lblAuthor.Text = "Author(s)"
        '
        'lstvAuthor
        '
        Me.lstvAuthor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.last, Me.given, Me.middle})
        Me.lstvAuthor.FullRowSelect = True
        Me.lstvAuthor.GridLines = True
        Me.lstvAuthor.Location = New System.Drawing.Point(88, 120)
        Me.lstvAuthor.Name = "lstvAuthor"
        Me.lstvAuthor.Size = New System.Drawing.Size(190, 97)
        Me.lstvAuthor.TabIndex = 32
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
        'lblShelf
        '
        Me.lblShelf.AutoSize = True
        Me.lblShelf.Location = New System.Drawing.Point(17, 252)
        Me.lblShelf.Name = "lblShelf"
        Me.lblShelf.Size = New System.Drawing.Size(31, 13)
        Me.lblShelf.TabIndex = 31
        Me.lblShelf.Text = "Shelf"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(17, 226)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 30
        Me.lblYear.Text = "Year"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(17, 97)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 29
        Me.lblTitle.Text = "Title"
        '
        'comboShelf
        '
        Me.comboShelf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboShelf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboShelf.FormattingEnabled = True
        Me.comboShelf.Location = New System.Drawing.Point(88, 249)
        Me.comboShelf.Name = "comboShelf"
        Me.comboShelf.Size = New System.Drawing.Size(190, 21)
        Me.comboShelf.Sorted = True
        Me.comboShelf.TabIndex = 28
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(88, 223)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(190, 20)
        Me.txtYear.TabIndex = 27
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(88, 94)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(190, 20)
        Me.txtTitle.TabIndex = 26
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(88, 68)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(190, 20)
        Me.txtISBN.TabIndex = 25
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(17, 71)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(32, 13)
        Me.lblISBN.TabIndex = 24
        Me.lblISBN.Text = "ISBN"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 38
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCopy
        '
        Me.lblCopy.Location = New System.Drawing.Point(93, 17)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(264, 23)
        Me.lblCopy.TabIndex = 39
        Me.lblCopy.Text = "Copy Number:"
        Me.lblCopy.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chbxHold
        '
        Me.chbxHold.AutoSize = True
        Me.chbxHold.Location = New System.Drawing.Point(12, 282)
        Me.chbxHold.Name = "chbxHold"
        Me.chbxHold.Size = New System.Drawing.Size(48, 17)
        Me.chbxHold.TabIndex = 40
        Me.chbxHold.Text = "Hold"
        Me.chbxHold.UseVisualStyleBackColor = True
        '
        'frmEditBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 311)
        Me.Controls.Add(Me.chbxHold)
        Me.Controls.Add(Me.lblCopy)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemoveAuthor)
        Me.Controls.Add(Me.btnAddAuthor)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lstvAuthor)
        Me.Controls.Add(Me.lblShelf)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.comboShelf)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblISBN)
        Me.Name = "frmEditBooks"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemoveAuthor As Button
    Friend WithEvents btnAddAuthor As Button
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lstvAuthor As ListView
    Friend WithEvents last As ColumnHeader
    Friend WithEvents given As ColumnHeader
    Friend WithEvents middle As ColumnHeader
    Friend WithEvents lblShelf As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents comboShelf As ComboBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lblISBN As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblCopy As Label
    Friend WithEvents chbxHold As CheckBox
End Class
