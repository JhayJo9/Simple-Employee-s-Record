Imports MySql.Data
Imports MySql.Data.MySqlClient

Module connection

    Private connectionString As String = "Server=127.0.0.1;Database=db_employee;Uid=Yohan;Pwd=Yohan"

    Public conn As MySqlConnection = New MySqlConnection(connectionString)



    Public Function OpenConnection() As MySqlConnection

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
        Catch ex As Exception
            MsgBox("Error opening connection: " & ex.Message)
        End Try

        Return conn
    End Function

    Public Function CloseConnection() As MySqlConnection
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Console.WriteLine("Connection to database closed.")
            End If
        Catch ex As Exception
            MsgBox("Error closing connection: " & ex.Message)
        End Try

        Return conn
    End Function

End Module