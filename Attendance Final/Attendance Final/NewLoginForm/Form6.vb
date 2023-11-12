Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form6
    Public connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"
    Dim studID As String = ""
    Dim adminUser As String = ""
    Dim adminPass As String = ""
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Public Sub LoadData()
        Try
            Reload("SELECT * FROM table_student", DataGridView1)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        DataGridView1.CurrentCell = Nothing
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtNewFName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtNewLName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtNewPhone.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtNewEmail.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtNewUser.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtNewPass.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        cmbNewYear.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        txtNewCourse.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtNewFName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtNewLName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtNewPhone.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtNewEmail.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtNewUser.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtNewPass.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        cmbNewYear.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        txtNewCourse.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtNewFName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtNewLName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtNewPhone.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtNewEmail.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtNewUser.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtNewPass.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        cmbNewYear.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        txtNewCourse.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formadmin As New Form4(adminUser, adminPass)
        formadmin.Show()
        Me.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"
        Dim connection As New MySqlConnection(connectionString)
        Dim dataTable As New DataTable()

        Try

            connection.Open()


            Dim query As String = "SELECT * FROM table_student WHERE " &
                                 "STUD_ID LIKE @searchTerm OR " &
                                 "FIRST_NAME LIKE @searchTerm OR " &
                                 "LAST_NAME LIKE @searchTerm OR " &
                                 "PHONE LIKE @searchTerm OR " &
                                 "EMAIL LIKE @searchTerm OR " &
                                 "USERNAME LIKE @searchTerm OR " &
                                 "PASSWORD LIKE @searchTerm OR " &
                                 "BIRTHDATE LIKE @searchTerm OR " &
                                 "YEAR LIKE @searchTerm OR " &
                                 "COURSE LIKE @searchTerm"

            Dim cmd As New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@searchTerm", "%" & TextBox1.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim studentID As Integer = CInt(selectedRow.Cells("NUM").Value)
                Dim newFirstName As String = txtNewFName.Text
                Dim newLastName As String = txtNewLName.Text
                Dim newPhone As String = txtNewPhone.Text
                Dim newEmail As String = txtNewEmail.Text
                Dim newUsername As String = txtNewUser.Text
                Dim newPassword As String = txtNewPass.Text
                Dim newYear As String = cmbNewYear.Text
                Dim newCourse As String = txtNewCourse.Text

                Dim updateQuery As String = "UPDATE table_student SET " &
                "FIRST_NAME='" & newFirstName & "', " &
                "LAST_NAME='" & newLastName & "', " &
                "PHONE='" & newPhone & "', " &
                "EMAIL='" & newEmail & "', " &
                "USERNAME='" & newUsername & "', " &
                "PASSWORD='" & newPassword & "', " &
                "YEAR='" & newYear & "', " &
                "COURSE='" & newCourse & "' " &
                "WHERE NUM='" & studentID & "'"

                reloadtxt(updateQuery)

                MessageBox.Show("Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row in the Data to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DataGridView1.CurrentCell = Nothing
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Try

                Dim studentID As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()

                Dim deleteQuery As String = "DELETE FROM table_student WHERE STUD_ID='" & studentID & "'"

                reloadtxt(deleteQuery)

                MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DataGridView1.CurrentCell = Nothing
    End Sub
    Private Sub Form6_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        DataGridView1.CurrentCell = Nothing
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView()
    End Sub

    Private Sub RefreshDataGridView()


        Dim dataTable As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM table_student"
            Using adapter As New MySqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

End Class