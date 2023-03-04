Imports System.Windows.Forms

Public Class ListViewItemComparer

    Implements IComparer

    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub
    Public Sub New(column As Integer, order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

        Dim returnVal As Integer
        Try
            If IsDate(CType(x, ListViewItem).SubItems(col).Text) And IsDate(CType(y, ListViewItem).SubItems(col).Text) Then
                returnVal = 1
            Else
                If IsNumeric(CType(x, ListViewItem).SubItems(col).Text) And IsNumeric(CType(y, ListViewItem).SubItems(col).Text) Then
                    returnVal = Val(CType(x, ListViewItem).SubItems(col).Text).CompareTo(Val(CType(y, ListViewItem).SubItems(col).Text))
                Else
                    returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
                End If
            End If
        Catch ex As Exception
            Return 1
        End Try

        If order = SortOrder.Descending Then
            returnVal = returnVal * -1
        End If

        Return returnVal

    End Function

End Class
