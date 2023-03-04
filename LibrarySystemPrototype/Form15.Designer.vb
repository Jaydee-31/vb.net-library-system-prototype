<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Me.txtSearchTransaction = New System.Windows.Forms.TextBox()
        Me.txtSearchBorrowerID = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.lblBorrowerID = New System.Windows.Forms.Label()
        Me.lstvBorrowList = New System.Windows.Forms.ListView()
        Me.transaction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.borrowerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.isbn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateBorrow = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateDue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearchTransaction
        '
        Me.txtSearchTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchTransaction.Location = New System.Drawing.Point(189, 12)
        Me.txtSearchTransaction.Name = "txtSearchTransaction"
        Me.txtSearchTransaction.Size = New System.Drawing.Size(283, 24)
        Me.txtSearchTransaction.TabIndex = 3
        '
        'txtSearchBorrowerID
        '
        Me.txtSearchBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBorrowerID.Location = New System.Drawing.Point(189, 42)
        Me.txtSearchBorrowerID.Name = "txtSearchBorrowerID"
        Me.txtSearchBorrowerID.Size = New System.Drawing.Size(283, 24)
        Me.txtSearchBorrowerID.TabIndex = 5
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(12, 14)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(152, 20)
        Me.lblTransaction.TabIndex = 7
        Me.lblTransaction.Text = "Transaction Number"
        '
        'lblBorrowerID
        '
        Me.lblBorrowerID.AutoSize = True
        Me.lblBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerID.Location = New System.Drawing.Point(12, 44)
        Me.lblBorrowerID.Name = "lblBorrowerID"
        Me.lblBorrowerID.Size = New System.Drawing.Size(142, 20)
        Me.lblBorrowerID.TabIndex = 8
        Me.lblBorrowerID.Text = "Student/Faculty ID"
        '
        'lstvBorrowList
        '
        Me.lstvBorrowList.AutoArrange = False
        Me.lstvBorrowList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.transaction, Me.borrowerID, Me.borrowerName, Me.isbn, Me.title, Me.status, Me.dateBorrow, Me.dateDue})
        Me.lstvBorrowList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvBorrowList.FullRowSelect = True
        Me.lstvBorrowList.GridLines = True
        Me.lstvBorrowList.Location = New System.Drawing.Point(12, 72)
        Me.lstvBorrowList.Name = "lstvBorrowList"
        Me.lstvBorrowList.Size = New System.Drawing.Size(460, 198)
        Me.lstvBorrowList.TabIndex = 17
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
        '
        'borrowerName
        '
        Me.borrowerName.Text = "Borrower's Name"
        '
        'isbn
        '
        Me.isbn.Text = "ISBN"
        '
        'title
        '
        Me.title.Text = "Book Title"
        '
        'status
        '
        Me.status.Text = "Status"
        '
        'dateBorrow
        '
        Me.dateBorrow.Text = "Date Borrowed"
        '
        'dateDue
        '
        Me.dateDue.Text = "Due Date"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(189, 276)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 19
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(397, 276)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstvBorrowList)
        Me.Controls.Add(Me.lblBorrowerID)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.txtSearchBorrowerID)
        Me.Controls.Add(Me.txtSearchTransaction)
        Me.Name = "frmReturn"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchTransaction As TextBox
    Friend WithEvents txtSearchBorrowerID As TextBox
    Friend WithEvents lblTransaction As Label
    Friend WithEvents lblBorrowerID As Label
    Friend WithEvents lstvBorrowList As ListView
    Friend WithEvents transaction As ColumnHeader
    Friend WithEvents borrowerID As ColumnHeader
    Friend WithEvents borrowerName As ColumnHeader
    Friend WithEvents isbn As ColumnHeader
    Friend WithEvents title As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents dateBorrow As ColumnHeader
    Friend WithEvents dateDue As ColumnHeader
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCancel As Button
End Class
