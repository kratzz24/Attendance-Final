Imports MySql.Data.MySqlClient

Public Class Form3

    Private connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            If String.IsNullOrEmpty(txtFirstName.Text) OrElse
               String.IsNullOrEmpty(txtLastName.Text) OrElse
               String.IsNullOrEmpty(txtPhone.Text) OrElse
               String.IsNullOrEmpty(txtEmail.Text) OrElse
               String.IsNullOrEmpty(txtUsername.Text) OrElse
               String.IsNullOrEmpty(txtPass2.Text) OrElse
               String.IsNullOrEmpty(cmbMonth.Text) OrElse
               String.IsNullOrEmpty(cmbDay.Text) OrElse
               String.IsNullOrEmpty(cmbYear.Text) OrElse
               String.IsNullOrEmpty(txtStudid.Text) OrElse
               String.IsNullOrEmpty(cmbYear2.Text) OrElse
               String.IsNullOrEmpty(txtCourse.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "INSERT INTO table_student (FIRST_NAME, LAST_NAME, PHONE, EMAIL, USERNAME, PASSWORD, BIRTHDATE, STUD_ID, YEAR, COURSE) " &
                                    "VALUES (@FirstName, @LastName, @Phone, @Gender, @Email, @Password, @Birthdate, @StudID, @Year, @Course)"

                Using cmd As New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@Gender", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Email", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPass2.Text)
                    cmd.Parameters.AddWithValue("@Birthdate", cmbMonth.Text & " " & cmbDay.Text & " " & cmbYear.Text)
                    cmd.Parameters.AddWithValue("@StudID", txtStudid.Text)
                    cmd.Parameters.AddWithValue("@Year", cmbYear2.Text)
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Registration Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        Dim Login As New Form1()
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDay.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub toSignUp_Click(sender As Object, e As EventArgs) Handles toSignUp.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.White


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'TOP LEFT CORNER
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'TOP RIGHT CORNER
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'BOTTOM RIGHT CORNER
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'BOTTOM LEFT CORNER
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub
End Class