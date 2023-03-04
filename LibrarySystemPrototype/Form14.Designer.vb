<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.lblBorrowerID = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.lblBorrowDate = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.dateBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.lstvBorrowList = New System.Windows.Forms.ListView()
        Me.transaction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.isbn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateBorrow = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateDue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.numCopy = New System.Windows.Forms.NumericUpDown()
        CType(Me.numCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Location = New System.Drawing.Point(12, 9)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(103, 13)
        Me.lblTransaction.TabIndex = 0
        Me.lblTransaction.Text = "Transaction Number"
        '
        'txtTransaction
        '
        Me.txtTransaction.Location = New System.Drawing.Point(121, 6)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.ReadOnly = True
        Me.txtTransaction.Size = New System.Drawing.Size(100, 20)
        Me.txtTransaction.TabIndex = 1
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Location = New System.Drawing.Point(121, 32)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(100, 20)
        Me.txtBorrowerID.TabIndex = 3
        '
        'lblBorrowerID
        '
        Me.lblBorrowerID.AutoSize = True
        Me.lblBorrowerID.Location = New System.Drawing.Point(12, 35)
        Me.lblBorrowerID.Name = "lblBorrowerID"
        Me.lblBorrowerID.Size = New System.Drawing.Size(97, 13)
        Me.lblBorrowerID.TabIndex = 2
        Me.lblBorrowerID.Text = "Student/Faculty ID"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(121, 58)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.ReadOnly = True
        Me.txtBorrowerName.Size = New System.Drawing.Size(100, 20)
        Me.txtBorrowerName.TabIndex = 5
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.AutoSize = True
        Me.lblBorrowerName.Location = New System.Drawing.Point(12, 61)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(87, 13)
        Me.lblBorrowerName.TabIndex = 4
        Me.lblBorrowerName.Text = "Borrower's Name"
        '
        'lblBorrowDate
        '
        Me.lblBorrowDate.AutoSize = True
        Me.lblBorrowDate.Location = New System.Drawing.Point(263, 61)
        Me.lblBorrowDate.Name = "lblBorrowDate"
        Me.lblBorrowDate.Size = New System.Drawing.Size(66, 13)
        Me.lblBorrowDate.TabIndex = 10
        Me.lblBorrowDate.Text = "Borrow Date"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(372, 32)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(263, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(55, 13)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Book Title"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(372, 6)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 20)
        Me.txtISBN.TabIndex = 7
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(263, 9)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(32, 13)
        Me.lblISBN.TabIndex = 6
        Me.lblISBN.Text = "ISBN"
        '
        'dateBorrowDate
        '
        Me.dateBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBorrowDate.Location = New System.Drawing.Point(372, 58)
        Me.dateBorrowDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dateBorrowDate.Name = "dateBorrowDate"
        Me.dateBorrowDate.Size = New System.Drawing.Size(100, 20)
        Me.dateBorrowDate.TabIndex = 11
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(397, 276)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(210, 276)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrow.TabIndex = 15
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'lstvBorrowList
        '
        Me.lstvBorrowList.AutoArrange = False
        Me.lstvBorrowList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.transaction, Me.borrowerID, Me.isbn, Me.title, Me.dateBorrow, Me.dateDue})
        Me.lstvBorrowList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvBorrowList.FullRowSelect = True
        Me.lstvBorrowList.GridLines = True
        Me.lstvBorrowList.Location = New System.Drawing.Point(12, 84)
        Me.lstvBorrowList.Name = "lstvBorrowList"
        Me.lstvBorrowList.Size = New System.Drawing.Size(460, 186)
        Me.lstvBorrowList.TabIndex = 16
        Me.lstvBorrowList.UseCompatibleStateImageBehavior = False
        Me.lstvBorrowList.View = System.Windows.Forms.View.Details
        '
        'transaction
        '
        Me.transaction.Text = "Transaction No."
        '
        'borrowerID
        '
        Me.borrowerID.Text = "Borrower's ID"
        Me.borrowerID.Width = 100
        '
        'isbn
        '
        Me.isbn.Text = "ISBN"
        '
        'title
        '
        Me.title.Text = "Book Title"
        Me.title.Width = 115
        '
        'dateBorrow
        '
        Me.dateBorrow.Text = "Date Borrowed"
        '
        'dateDue
        '
        Me.dateDue.Text = "Due Date"
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.Location = New System.Drawing.Point(12, 278)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(71, 13)
        Me.lblCopy.TabIndex = 17
        Me.lblCopy.Text = "Copy Number"
        '
        'numCopy
        '
        Me.numCopy.Location = New System.Drawing.Point(89, 276)
        Me.numCopy.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numCopy.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCopy.Name = "numCopy"
        Me.numCopy.Size = New System.Drawing.Size(40, 20)
        Me.numCopy.TabIndex = 18
        Me.numCopy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.numCopy)
        Me.Controls.Add(Me.lblCopy)
        Me.Controls.Add(Me.lstvBorrowList)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dateBorrowDate)
        Me.Controls.Add(Me.lblBorrowDate)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.txtBorrowerName)
        Me.Controls.Add(Me.lblBorrowerName)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.lblBorrowerID)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.lblTransaction)
        Me.Name = "frmBorrow"
        Me.Text = "Library System"
        CType(Me.numCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTransaction As Label
    Friend WithEvents txtTransaction As TextBox
    Friend WithEvents txtBorrowerID As TextBox
    Friend WithEvents lblBorrowerID As Label
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents lblBorrowDate As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lblISBN As Label
    Friend WithEvents dateBorrowDate As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents lstvBorrowList As ListView
    Friend WithEvents transaction As ColumnHeader
    Friend WithEvents borrowerID As ColumnHeader
    Friend WithEvents isbn As ColumnHeader
    Friend WithEvents title As ColumnHeader
    Friend WithEvents dateBorrow As ColumnHeader
    Friend WithEvents dateDue As ColumnHeader
    Friend WithEvents lblCopy As Label
    Friend WithEvents numCopy As NumericUpDown
End Class
