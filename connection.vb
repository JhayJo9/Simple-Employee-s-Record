Imports MySql.Data
Imports MySql.Data.MySqlClient

Module connection
    'Public connStr As String = "server=localhost;database=users_login_db;Uid=Yohan;Pwd=Yohan;port=3307"
    Public conn As New MySqlConnection()
    Dim rs As Boolean
    Dim connStr As String
    Public Function openconnection() As Boolean
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection
            End If

            If conn.State = ConnectionState.Closed Then
                connStr = "server=localhost;database=db_employee;Uid=Yohan;Pwd=Yohan;port=3307;Convert Zero DateTime=True"
                conn.ConnectionString = connStr
                conn.Open() ' Open the connection here
            End If
            rs = True
        Catch ex As Exception
            MsgBox("OPEN ERROR: " & ex.Message)
            rs = False
        End Try

        Return rs
    End Function


    Public Function closeconnection() As Boolean
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            rs = True
        Catch ex As Exception

            MsgBox("CLOSE ERROR: " & ex.Message)
            rs = False
        End Try
        Return rs
    End Function
End Module
