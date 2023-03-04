<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabBooks = New System.Windows.Forms.TabPage()
        Me.lstvBooks = New System.Windows.Forms.ListView()
        Me.isbn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.copy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shelf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabBorrow = New System.Windows.Forms.TabPage()
        Me.lstvBorrow = New System.Windows.Forms.ListView()
        Me.transaction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.librarian = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bookISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bookTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateBorrow = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateDue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabReturn = New System.Windows.Forms.TabPage()
        Me.lstvReturn = New System.Windows.Forms.ListView()
        Me.transaction2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.librarian2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerID2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerName2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bookISBN2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bookTitle2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateBorrow2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateDue2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateReturn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabStat = New System.Windows.Forms.TabPage()
        Me.txtLibrarians = New System.Windows.Forms.TextBox()
        Me.lblLibrarians = New System.Windows.Forms.Label()
        Me.txtFaculties = New System.Windows.Forms.TextBox()
        Me.lblFaculties = New System.Windows.Forms.Label()
        Me.txtStudents = New System.Windows.Forms.TextBox()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.txtBooks = New System.Windows.Forms.TextBox()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.txtFines = New System.Windows.Forms.TextBox()
        Me.lblFines = New System.Windows.Forms.Label()
        Me.txtBooksLeast = New System.Windows.Forms.TextBox()
        Me.lblBooksLeast = New System.Windows.Forms.Label()
        Me.txtBooksMost = New System.Windows.Forms.TextBox()
        Me.lblBooksMost = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tabControl.SuspendLayout()
        Me.tabBooks.SuspendLayout()
        Me.tabBorrow.SuspendLayout()
        Me.tabReturn.SuspendLayout()
        Me.tabStat.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabBooks)
        Me.tabControl.Controls.Add(Me.tabBorrow)
        Me.tabControl.Controls.Add(Me.tabReturn)
        Me.tabControl.Controls.Add(Me.tabStat)
        Me.tabControl.Location = New System.Drawing.Point(12, 41)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(760, 508)
        Me.tabControl.TabIndex = 0
        '
        'tabBooks
        '
        Me.tabBooks.Controls.Add(Me.lstvBooks)
        Me.tabBooks.Location = New System.Drawing.Point(4, 22)
        Me.tabBooks.Name = "tabBooks"
        Me.tabBooks.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBooks.Size = New System.Drawing.Size(752, 482)
        Me.tabBooks.TabIndex = 0
        Me.tabBooks.Text = "Book List"
        Me.tabBooks.UseVisualStyleBackColor = True
        '
        'lstvBooks
        '
        Me.lstvBooks.AutoArrange = False
        Me.lstvBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.isbn, Me.title, Me.copy, Me.author, Me.year, Me.shelf, Me.status})
        Me.lstvBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvBooks.FullRowSelect = True
        Me.lstvBooks.GridLines = True
        Me.lstvBooks.Location = New System.Drawing.Point(6, 6)
        Me.lstvBooks.Name = "lstvBooks"
        Me.lstvBooks.Size = New System.Drawing.Size(740, 470)
        Me.lstvBooks.TabIndex = 8
        Me.lstvBooks.UseCompatibleStateImageBehavior = False
        Me.lstvBooks.View = System.Windows.Forms.View.Details
        '
        'isbn
        '
        Me.isbn.Text = "ISBN"
        Me.isbn.Width = 110
        '
        'title
        '
        Me.title.Text = "Title"
        Me.title.Width = 160
        '
        'copy
        '
        Me.copy.Text = "Copy No."
        Me.copy.Width = 70
        '
        'author
        '
        Me.author.Text = "Author(s)"
        Me.author.Width = 160
        '
        'year
        '
        Me.year.Text = "Year"
        Me.year.Width = 50
        '
        'shelf
        '
        Me.shelf.Text = "Shelf"
        Me.shelf.Width = 90
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 90
        '
        'tabBorrow
        '
        Me.tabBorrow.Controls.Add(Me.lstvBorrow)
        Me.tabBorrow.Location = New System.Drawing.Point(4, 22)
        Me.tabBorrow.Name = "tabBorrow"
        Me.tabBorrow.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBorrow.Size = New System.Drawing.Size(752, 482)
        Me.tabBorrow.TabIndex = 1
        Me.tabBorrow.Text = "Currently Borrowed Books"
        Me.tabBorrow.UseVisualStyleBackColor = True
        '
        'lstvBorrow
        '
        Me.lstvBorrow.AutoArrange = False
        Me.lstvBorrow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.transaction, Me.librarian, Me.borrowerID, Me.borrowerName, Me.bookISBN, Me.bookTitle, Me.dateBorrow, Me.dateDue})
        Me.lstvBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvBorrow.FullRowSelect = True
        Me.lstvBorrow.GridLines = True
        Me.lstvBorrow.Location = New System.Drawing.Point(6, 6)
        Me.lstvBorrow.Name = "lstvBorrow"
        Me.lstvBorrow.Size = New System.Drawing.Size(740, 470)
        Me.lstvBorrow.TabIndex = 9
        Me.lstvBorrow.UseCompatibleStateImageBehavior = False
        Me.lstvBorrow.View = System.Windows.Forms.View.Details
        '
        'transaction
        '
        Me.transaction.Text = "Transaction ID"
        Me.transaction.Width = 100
        '
        'librarian
        '
        Me.librarian.Text = "Librarian In-Charge"
        Me.librarian.Width = 100
        '
        'borrowerID
        '
        Me.borrowerID.Text = "Borrower's ID"
        Me.borrowerID.Width = 100
        '
        'borrowerName
        '
        Me.borrowerName.Text = "Borrower's Name"
        Me.borrowerName.Width = 110
        '
        'bookISBN
        '
        Me.bookISBN.Text = "ISBN"
        Me.bookISBN.Width = 90
        '
        'bookTitle
        '
        Me.bookTitle.Text = "Title"
        Me.bookTitle.Width = 110
        '
        'dateBorrow
        '
        Me.dateBorrow.Text = "Date Borrowed"
        '
        'dateDue
        '
        Me.dateDue.Text = "Due Date"
        '
        'tabReturn
        '
        Me.tabReturn.Controls.Add(Me.lstvReturn)
        Me.tabReturn.Location = New System.Drawing.Point(4, 22)
        Me.tabReturn.Name = "tabReturn"
        Me.tabReturn.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReturn.Size = New System.Drawing.Size(752, 482)
        Me.tabReturn.TabIndex = 2
        Me.tabReturn.Text = "Return History"
        Me.tabReturn.UseVisualStyleBackColor = True
        '
        'lstvReturn
        '
        Me.lstvReturn.AutoArrange = False
        Me.lstvReturn.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.transaction2, Me.librarian2, Me.borrowerID2, Me.borrowerName2, Me.bookISBN2, Me.bookTitle2, Me.dateBorrow2, Me.dateDue2, Me.dateReturn, Me.fine})
        Me.lstvReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvReturn.FullRowSelect = True
        Me.lstvReturn.GridLines = True
        Me.lstvReturn.Location = New System.Drawing.Point(6, 6)
        Me.lstvReturn.Name = "lstvReturn"
        Me.lstvReturn.Size = New System.Drawing.Size(740, 470)
        Me.lstvReturn.TabIndex = 10
        Me.lstvReturn.UseCompatibleStateImageBehavior = False
        Me.lstvReturn.View = System.Windows.Forms.View.Details
        '
        'transaction2
        '
        Me.transaction2.Text = "Transaction ID"
        Me.transaction2.Width = 100
        '
        'librarian2
        '
        Me.librarian2.Text = "Librarian In-Charge"
        Me.librarian2.Width = 100
        '
        'borrowerID2
        '
        Me.borrowerID2.Text = "Borrower's ID"
        Me.borrowerID2.Width = 100
        '
        'borrowerName2
        '
        Me.borrowerName2.Text = "Borrower's Name"
        Me.borrowerName2.Width = 110
        '
        'bookISBN2
        '
        Me.bookISBN2.Text = "ISBN"
        Me.bookISBN2.Width = 90
        '
        'bookTitle2
        '
        Me.bookTitle2.Text = "Title"
        Me.bookTitle2.Width = 110
        '
        'dateBorrow2
        '
        Me.dateBorrow2.Text = "Date Borrowed"
        '
        'dateDue2
        '
        Me.dateDue2.Text = "Due Date"
        '
        'dateReturn
        '
        Me.dateReturn.Text = "Date Returned"
        '
        'fine
        '
        Me.fine.Text = "Fine"
        '
        'tabStat
        '
        Me.tabStat.Controls.Add(Me.txtLibrarians)
        Me.tabStat.Controls.Add(Me.lblLibrarians)
        Me.tabStat.Controls.Add(Me.txtFaculties)
        Me.tabStat.Controls.Add(Me.lblFaculties)
        Me.tabStat.Controls.Add(Me.txtStudents)
        Me.tabStat.Controls.Add(Me.lblStudents)
        Me.tabStat.Controls.Add(Me.txtBooks)
        Me.tabStat.Controls.Add(Me.lblBooks)
        Me.tabStat.Controls.Add(Me.txtFines)
        Me.tabStat.Controls.Add(Me.lblFines)
        Me.tabStat.Controls.Add(Me.txtBooksLeast)
        Me.tabStat.Controls.Add(Me.lblBooksLeast)
        Me.tabStat.Controls.Add(Me.txtBooksMost)
        Me.tabStat.Controls.Add(Me.lblBooksMost)
        Me.tabStat.Location = New System.Drawing.Point(4, 22)
        Me.tabStat.Name = "tabStat"
        Me.tabStat.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStat.Size = New System.Drawing.Size(752, 482)
        Me.tabStat.TabIndex = 3
        Me.tabStat.Text = "Statistics"
        Me.tabStat.UseVisualStyleBackColor = True
        '
        'txtLibrarians
        '
        Me.txtLibrarians.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibrarians.Location = New System.Drawing.Point(312, 375)
        Me.txtLibrarians.Name = "txtLibrarians"
        Me.txtLibrarians.ReadOnly = True
        Me.txtLibrarians.Size = New System.Drawing.Size(299, 31)
        Me.txtLibrarians.TabIndex = 13
        '
        'lblLibrarians
        '
        Me.lblLibrarians.AutoSize = True
        Me.lblLibrarians.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibrarians.Location = New System.Drawing.Point(48, 378)
        Me.lblLibrarians.Name = "lblLibrarians"
        Me.lblLibrarians.Size = New System.Drawing.Size(238, 25)
        Me.lblLibrarians.TabIndex = 12
        Me.lblLibrarians.Text = "Librarians Registered"
        '
        'txtFaculties
        '
        Me.txtFaculties.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaculties.Location = New System.Drawing.Point(312, 338)
        Me.txtFaculties.Name = "txtFaculties"
        Me.txtFaculties.ReadOnly = True
        Me.txtFaculties.Size = New System.Drawing.Size(299, 31)
        Me.txtFaculties.TabIndex = 11
        '
        'lblFaculties
        '
        Me.lblFaculties.AutoSize = True
        Me.lblFaculties.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaculties.Location = New System.Drawing.Point(48, 341)
        Me.lblFaculties.Name = "lblFaculties"
        Me.lblFaculties.Size = New System.Drawing.Size(229, 25)
        Me.lblFaculties.TabIndex = 10
        Me.lblFaculties.Text = "Faculties Registered"
        '
        'txtStudents
        '
        Me.txtStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudents.Location = New System.Drawing.Point(312, 301)
        Me.txtStudents.Name = "txtStudents"
        Me.txtStudents.ReadOnly = True
        Me.txtStudents.Size = New System.Drawing.Size(299, 31)
        Me.txtStudents.TabIndex = 9
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudents.Location = New System.Drawing.Point(48, 304)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(226, 25)
        Me.lblStudents.TabIndex = 8
        Me.lblStudents.Text = "Students Registered"
        '
        'txtBooks
        '
        Me.txtBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBooks.Location = New System.Drawing.Point(312, 42)
        Me.txtBooks.Name = "txtBooks"
        Me.txtBooks.ReadOnly = True
        Me.txtBooks.Size = New System.Drawing.Size(299, 31)
        Me.txtBooks.TabIndex = 7
        '
        'lblBooks
        '
        Me.lblBooks.AutoSize = True
        Me.lblBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooks.Location = New System.Drawing.Point(48, 45)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(137, 25)
        Me.lblBooks.TabIndex = 6
        Me.lblBooks.Text = "Total Books"
        '
        'txtFines
        '
        Me.txtFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFines.Location = New System.Drawing.Point(312, 227)
        Me.txtFines.Name = "txtFines"
        Me.txtFines.ReadOnly = True
        Me.txtFines.Size = New System.Drawing.Size(299, 31)
        Me.txtFines.TabIndex = 5
        '
        'lblFines
        '
        Me.lblFines.AutoSize = True
        Me.lblFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFines.Location = New System.Drawing.Point(48, 230)
        Me.lblFines.Name = "lblFines"
        Me.lblFines.Size = New System.Drawing.Size(236, 25)
        Me.lblFines.TabIndex = 4
        Me.lblFines.Text = "Total Fines Collected"
        '
        'txtBooksLeast
        '
        Me.txtBooksLeast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBooksLeast.Location = New System.Drawing.Point(312, 153)
        Me.txtBooksLeast.Name = "txtBooksLeast"
        Me.txtBooksLeast.ReadOnly = True
        Me.txtBooksLeast.Size = New System.Drawing.Size(299, 31)
        Me.txtBooksLeast.TabIndex = 3
        '
        'lblBooksLeast
        '
        Me.lblBooksLeast.AutoSize = True
        Me.lblBooksLeast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksLeast.Location = New System.Drawing.Point(48, 156)
        Me.lblBooksLeast.Name = "lblBooksLeast"
        Me.lblBooksLeast.Size = New System.Drawing.Size(236, 25)
        Me.lblBooksLeast.TabIndex = 2
        Me.lblBooksLeast.Text = "Least Borrowed Book"
        '
        'txtBooksMost
        '
        Me.txtBooksMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBooksMost.Location = New System.Drawing.Point(312, 116)
        Me.txtBooksMost.Name = "txtBooksMost"
        Me.txtBooksMost.ReadOnly = True
        Me.txtBooksMost.Size = New System.Drawing.Size(299, 31)
        Me.txtBooksMost.TabIndex = 1
        '
        'lblBooksMost
        '
        Me.lblBooksMost.AutoSize = True
        Me.lblBooksMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksMost.Location = New System.Drawing.Point(48, 119)
        Me.lblBooksMost.Name = "lblBooksMost"
        Me.lblBooksMost.Size = New System.Drawing.Size(229, 25)
        Me.lblBooksMost.TabIndex = 0
        Me.lblBooksMost.Text = "Most Borrowed Book"
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
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "frmReports"
        Me.Text = "Library System"
        Me.tabControl.ResumeLayout(False)
        Me.tabBooks.ResumeLayout(False)
        Me.tabBorrow.ResumeLayout(False)
        Me.tabReturn.ResumeLayout(False)
        Me.tabStat.ResumeLayout(False)
        Me.tabStat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabBooks As TabPage
    Friend WithEvents tabBorrow As TabPage
    Friend WithEvents tabReturn As TabPage
    Friend WithEvents tabStat As TabPage
    Friend WithEvents lstvBooks As ListView
    Friend WithEvents isbn As ColumnHeader
    Friend WithEvents title As ColumnHeader
    Friend WithEvents copy As ColumnHeader
    Friend WithEvents author As ColumnHeader
    Friend WithEvents year As ColumnHeader
    Friend WithEvents shelf As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents btnBack As Button
    Friend WithEvents lstvBorrow As ListView
    Friend WithEvents transaction As ColumnHeader
    Friend WithEvents librarian As ColumnHeader
    Friend WithEvents borrowerID As ColumnHeader
    Friend WithEvents borrowerName As ColumnHeader
    Friend WithEvents bookISBN As ColumnHeader
    Friend WithEvents bookTitle As ColumnHeader
    Friend WithEvents dateBorrow As ColumnHeader
    Friend WithEvents dateDue As ColumnHeader
    Friend WithEvents lstvReturn As ListView
    Friend WithEvents transaction2 As ColumnHeader
    Friend WithEvents librarian2 As ColumnHeader
    Friend WithEvents borrowerID2 As ColumnHeader
    Friend WithEvents borrowerName2 As ColumnHeader
    Friend WithEvents bookISBN2 As ColumnHeader
    Friend WithEvents bookTitle2 As ColumnHeader
    Friend WithEvents dateBorrow2 As ColumnHeader
    Friend WithEvents dateDue2 As ColumnHeader
    Friend WithEvents dateReturn As ColumnHeader
    Friend WithEvents fine As ColumnHeader
    Friend WithEvents txtLibrarians As TextBox
    Friend WithEvents lblLibrarians As Label
    Friend WithEvents txtFaculties As TextBox
    Friend WithEvents lblFaculties As Label
    Friend WithEvents txtStudents As TextBox
    Friend WithEvents lblStudents As Label
    Friend WithEvents txtBooks As TextBox
    Friend WithEvents lblBooks As Label
    Friend WithEvents txtFines As TextBox
    Friend WithEvents lblFines As Label
    Friend WithEvents txtBooksLeast As TextBox
    Friend WithEvents lblBooksLeast As Label
    Friend WithEvents txtBooksMost As TextBox
    Friend WithEvents lblBooksMost As Label
End Class
