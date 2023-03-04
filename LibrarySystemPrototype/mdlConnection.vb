Imports System.Data.SqlClient

Module mdlConnection

    Public connection As SqlConnection

    Sub OpenConnection()

        Try

            connection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ironman\source\repos\LibrarySystemPrototype\LibrarySystemPrototypeDB.mdf;Integrated Security=True;Connect Timeout=30")
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

        Catch ex As Exception
            MsgBox("Failed to connect, Error at " & ex.ToString)
        End Try

    End Sub

End Module
