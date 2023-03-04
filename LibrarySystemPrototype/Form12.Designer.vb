<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShelf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstvShelves = New System.Windows.Forms.ListView()
        Me.shelf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtShelfAdd = New System.Windows.Forms.TextBox()
        Me.txtDescriptionAdd = New System.Windows.Forms.TextBox()
        Me.lblShelfAdd = New System.Windows.Forms.Label()
        Me.lblDescriptionAdd = New System.Windows.Forms.Label()
        Me.lblDescriptionEdit = New System.Windows.Forms.Label()
        Me.lblShelfEdit = New System.Windows.Forms.Label()
        Me.txtDescriptionEdit = New System.Windows.Forms.TextBox()
        Me.txtShelfEdit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstvShelves
        '
        Me.lstvShelves.AutoArrange = False
        Me.lstvShelves.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.shelf, Me.description})
        Me.lstvShelves.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvShelves.FullRowSelect = True
        Me.lstvShelves.GridLines = True
        Me.lstvShelves.Location = New System.Drawing.Point(12, 12)
        Me.lstvShelves.Name = "lstvShelves"
        Me.lstvShelves.Size = New System.Drawing.Size(460, 408)
        Me.lstvShelves.TabIndex = 8
        Me.lstvShelves.UseCompatibleStateImageBehavior = False
        Me.lstvShelves.View = System.Windows.Forms.View.Details
        '
        'shelf
        '
        Me.shelf.Text = "Shelf"
        Me.shelf.Width = 125
        '
        'description
        '
        Me.description.Text = "Description"
        Me.description.Width = 325
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(127, 426)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(208, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtShelfAdd
        '
        Me.txtShelfAdd.Location = New System.Drawing.Point(545, 12)
        Me.txtShelfAdd.Name = "txtShelfAdd"
        Me.txtShelfAdd.Size = New System.Drawing.Size(127, 20)
        Me.txtShelfAdd.TabIndex = 11
        '
        'txtDescriptionAdd
        '
        Me.txtDescriptionAdd.Location = New System.Drawing.Point(545, 38)
        Me.txtDescriptionAdd.Multiline = True
        Me.txtDescriptionAdd.Name = "txtDescriptionAdd"
        Me.txtDescriptionAdd.Size = New System.Drawing.Size(127, 100)
        Me.txtDescriptionAdd.TabIndex = 12
        '
        'lblShelfAdd
        '
        Me.lblShelfAdd.AutoSize = True
        Me.lblShelfAdd.Location = New System.Drawing.Point(508, 15)
        Me.lblShelfAdd.Name = "lblShelfAdd"
        Me.lblShelfAdd.Size = New System.Drawing.Size(31, 13)
        Me.lblShelfAdd.TabIndex = 13
        Me.lblShelfAdd.Text = "Shelf"
        '
        'lblDescriptionAdd
        '
        Me.lblDescriptionAdd.AutoSize = True
        Me.lblDescriptionAdd.Location = New System.Drawing.Point(479, 72)
        Me.lblDescriptionAdd.Name = "lblDescriptionAdd"
        Me.lblDescriptionAdd.Size = New System.Drawing.Size(60, 13)
        Me.lblDescriptionAdd.TabIndex = 14
        Me.lblDescriptionAdd.Text = "Description"
        '
        'lblDescriptionEdit
        '
        Me.lblDescriptionEdit.AutoSize = True
        Me.lblDescriptionEdit.Location = New System.Drawing.Point(479, 284)
        Me.lblDescriptionEdit.Name = "lblDescriptionEdit"
        Me.lblDescriptionEdit.Size = New System.Drawing.Size(60, 13)
        Me.lblDescriptionEdit.TabIndex = 18
        Me.lblDescriptionEdit.Text = "Description"
        '
        'lblShelfEdit
        '
        Me.lblShelfEdit.AutoSize = True
        Me.lblShelfEdit.Location = New System.Drawing.Point(508, 227)
        Me.lblShelfEdit.Name = "lblShelfEdit"
        Me.lblShelfEdit.Size = New System.Drawing.Size(31, 13)
        Me.lblShelfEdit.TabIndex = 17
        Me.lblShelfEdit.Text = "Shelf"
        '
        'txtDescriptionEdit
        '
        Me.txtDescriptionEdit.Enabled = False
        Me.txtDescriptionEdit.Location = New System.Drawing.Point(545, 250)
        Me.txtDescriptionEdit.Multiline = True
        Me.txtDescriptionEdit.Name = "txtDescriptionEdit"
        Me.txtDescriptionEdit.Size = New System.Drawing.Size(127, 100)
        Me.txtDescriptionEdit.TabIndex = 16
        '
        'txtShelfEdit
        '
        Me.txtShelfEdit.Enabled = False
        Me.txtShelfEdit.Location = New System.Drawing.Point(545, 224)
        Me.txtShelfEdit.Name = "txtShelfEdit"
        Me.txtShelfEdit.Size = New System.Drawing.Size(127, 20)
        Me.txtShelfEdit.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(570, 144)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(570, 356)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(597, 426)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmShelf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblDescriptionEdit)
        Me.Controls.Add(Me.lblShelfEdit)
        Me.Controls.Add(Me.txtDescriptionEdit)
        Me.Controls.Add(Me.txtShelfEdit)
        Me.Controls.Add(Me.lblDescriptionAdd)
        Me.Controls.Add(Me.lblShelfAdd)
        Me.Controls.Add(Me.txtDescriptionAdd)
        Me.Controls.Add(Me.txtShelfAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstvShelves)
        Me.Name = "frmShelf"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstvShelves As ListView
    Friend WithEvents shelf As ColumnHeader
    Friend WithEvents description As ColumnHeader
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtShelfAdd As TextBox
    Friend WithEvents txtDescriptionAdd As TextBox
    Friend WithEvents lblShelfAdd As Label
    Friend WithEvents lblDescriptionAdd As Label
    Friend WithEvents lblDescriptionEdit As Label
    Friend WithEvents lblShelfEdit As Label
    Friend WithEvents txtDescriptionEdit As TextBox
    Friend WithEvents txtShelfEdit As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnBack As Button
End Class
