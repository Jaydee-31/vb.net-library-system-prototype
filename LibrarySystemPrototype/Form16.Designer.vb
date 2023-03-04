<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnDialog
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
        Me.txtDateBorrow = New System.Windows.Forms.TextBox()
        Me.lblDateBorrow = New System.Windows.Forms.Label()
        Me.txtDateDue = New System.Windows.Forms.TextBox()
        Me.lblDateDue = New System.Windows.Forms.Label()
        Me.txtDateCurrent = New System.Windows.Forms.TextBox()
        Me.lblDateCurrent = New System.Windows.Forms.Label()
        Me.txtDaysLate = New System.Windows.Forms.TextBox()
        Me.lblDaysLate = New System.Windows.Forms.Label()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.lblFine = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Location = New System.Drawing.Point(12, 15)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(83, 13)
        Me.lblTransaction.TabIndex = 0
        Me.lblTransaction.Text = "Transaction No."
        '
        'txtTransaction
        '
        Me.txtTransaction.Location = New System.Drawing.Point(101, 12)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.ReadOnly = True
        Me.txtTransaction.Size = New System.Drawing.Size(171, 20)
        Me.txtTransaction.TabIndex = 1
        '
        'txtDateBorrow
        '
        Me.txtDateBorrow.Location = New System.Drawing.Point(101, 38)
        Me.txtDateBorrow.Name = "txtDateBorrow"
        Me.txtDateBorrow.ReadOnly = True
        Me.txtDateBorrow.Size = New System.Drawing.Size(171, 20)
        Me.txtDateBorrow.TabIndex = 3
        '
        'lblDateBorrow
        '
        Me.lblDateBorrow.AutoSize = True
        Me.lblDateBorrow.Location = New System.Drawing.Point(12, 41)
        Me.lblDateBorrow.Name = "lblDateBorrow"
        Me.lblDateBorrow.Size = New System.Drawing.Size(78, 13)
        Me.lblDateBorrow.TabIndex = 2
        Me.lblDateBorrow.Text = "Date Borrowed"
        '
        'txtDateDue
        '
        Me.txtDateDue.Location = New System.Drawing.Point(101, 64)
        Me.txtDateDue.Name = "txtDateDue"
        Me.txtDateDue.ReadOnly = True
        Me.txtDateDue.Size = New System.Drawing.Size(171, 20)
        Me.txtDateDue.TabIndex = 5
        '
        'lblDateDue
        '
        Me.lblDateDue.AutoSize = True
        Me.lblDateDue.Location = New System.Drawing.Point(12, 67)
        Me.lblDateDue.Name = "lblDateDue"
        Me.lblDateDue.Size = New System.Drawing.Size(53, 13)
        Me.lblDateDue.TabIndex = 4
        Me.lblDateDue.Text = "Due Date"
        '
        'txtDateCurrent
        '
        Me.txtDateCurrent.Location = New System.Drawing.Point(101, 90)
        Me.txtDateCurrent.Name = "txtDateCurrent"
        Me.txtDateCurrent.Size = New System.Drawing.Size(171, 20)
        Me.txtDateCurrent.TabIndex = 7
        '
        'lblDateCurrent
        '
        Me.lblDateCurrent.AutoSize = True
        Me.lblDateCurrent.Location = New System.Drawing.Point(12, 93)
        Me.lblDateCurrent.Name = "lblDateCurrent"
        Me.lblDateCurrent.Size = New System.Drawing.Size(67, 13)
        Me.lblDateCurrent.TabIndex = 6
        Me.lblDateCurrent.Text = "Current Date"
        '
        'txtDaysLate
        '
        Me.txtDaysLate.Location = New System.Drawing.Point(101, 116)
        Me.txtDaysLate.Name = "txtDaysLate"
        Me.txtDaysLate.ReadOnly = True
        Me.txtDaysLate.Size = New System.Drawing.Size(171, 20)
        Me.txtDaysLate.TabIndex = 9
        '
        'lblDaysLate
        '
        Me.lblDaysLate.AutoSize = True
        Me.lblDaysLate.Location = New System.Drawing.Point(12, 119)
        Me.lblDaysLate.Name = "lblDaysLate"
        Me.lblDaysLate.Size = New System.Drawing.Size(61, 13)
        Me.lblDaysLate.TabIndex = 8
        Me.lblDaysLate.Text = "Day(s) Late"
        '
        'txtFine
        '
        Me.txtFine.Location = New System.Drawing.Point(101, 142)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.ReadOnly = True
        Me.txtFine.Size = New System.Drawing.Size(171, 20)
        Me.txtFine.TabIndex = 11
        '
        'lblFine
        '
        Me.lblFine.AutoSize = True
        Me.lblFine.Location = New System.Drawing.Point(12, 145)
        Me.lblFine.Name = "lblFine"
        Me.lblFine.Size = New System.Drawing.Size(65, 13)
        Me.lblFine.TabIndex = 10
        Me.lblFine.Text = "Fine (Pesos)"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(101, 176)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(197, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmReturnDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtFine)
        Me.Controls.Add(Me.lblFine)
        Me.Controls.Add(Me.txtDaysLate)
        Me.Controls.Add(Me.lblDaysLate)
        Me.Controls.Add(Me.txtDateCurrent)
        Me.Controls.Add(Me.lblDateCurrent)
        Me.Controls.Add(Me.txtDateDue)
        Me.Controls.Add(Me.lblDateDue)
        Me.Controls.Add(Me.txtDateBorrow)
        Me.Controls.Add(Me.lblDateBorrow)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.lblTransaction)
        Me.Name = "frmReturnDialog"
        Me.Text = "Return"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTransaction As Label
    Friend WithEvents txtTransaction As TextBox
    Friend WithEvents txtDateBorrow As TextBox
    Friend WithEvents lblDateBorrow As Label
    Friend WithEvents txtDateDue As TextBox
    Friend WithEvents lblDateDue As Label
    Friend WithEvents txtDateCurrent As TextBox
    Friend WithEvents lblDateCurrent As Label
    Friend WithEvents txtDaysLate As TextBox
    Friend WithEvents lblDaysLate As Label
    Friend WithEvents txtFine As TextBox
    Friend WithEvents lblFine As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCancel As Button
End Class
