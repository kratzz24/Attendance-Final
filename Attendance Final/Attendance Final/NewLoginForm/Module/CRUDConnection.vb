Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Module CRUDConnection

    Public result As String
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Private connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"

    Public Sub Create(ByVal sql As String)
        Dim strcon As New MySqlConnection(connectionString)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Data failed to insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Data has been successfully inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
        Finally
            strcon.Close()

        End Try

    End Sub

    Public Sub Reload(ByVal sql As String, ByVal DTG As Object)
        Dim strcon As New MySqlConnection(connectionString)
        Try
            strcon.Open()
            dt = New DataTable
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub reloadtxt(ByVal sql As String)
        Dim strcon As New MySqlConnection(connectionString)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With

            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)
        Catch ex As Exception
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub createlogged(ByVal sql As String)
        Dim strcon As New MySqlConnection(connectionString)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub updateslogged(ByVal sql As String)
        Dim strcon As New MySqlConnection(connectionString)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
        Finally
            strcon.Close()
        End Try
    End Sub
End Module
