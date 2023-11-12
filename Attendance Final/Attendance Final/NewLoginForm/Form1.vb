Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Public Class Form1
    Private connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RoundCornerButtom(btnLogin)
        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter a Valid Student Id and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Login(username, password) Then
                Me.Hide()
            Else
                MessageBox.Show("Invalid Student Id and Pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Function Login(username As String, password As String) As Boolean
        Dim studID As String = ""
        Dim adminUser As String = ""
        Dim adminPass As String = ""

        If isUser(username, password, studID) Then
            MessageBox.Show("Successfully Logged in as Student", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form2 As New Form2(username, studID)
            form2.Show()
            Return True
        ElseIf isAdmin(username, password, adminUser, adminPass) Then
            MessageBox.Show("Successfully Logged in as Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form4 As New Form4(adminUser, adminPass)
            form4.Show()
            Return True
        Else
            Return False
        End If
    End Function
    Private connections As String = "server=localhost;user=root;password=;port=3306;database=studentdb"
    Private connection As MySqlConnection = New MySqlConnection(connections)
    Private Function isUser(username As String, password As String, ByRef studID As String) As Boolean
        Dim query As String = "SELECT STUD_ID FROM table_student WHERE USERNAME = @Username AND PASSWORD = @Password"
        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                studID = reader("STUD_ID").ToString()
                connection.Close()
                Return True
            End If
        End Using
        connection.Close()
        Return False
    End Function
    Private Function isAdmin(username As String, password As String, ByRef adminUser As String, ByRef adminPass As String) As Boolean
        Dim query As String = "SELECT ADMIN_USER, ADMIN_PASS FROM table_student WHERE ADMIN_USER = @Username AND ADMIN_PASS = @Password"
        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                adminUser = reader("ADMIN_USER").ToString()
                adminPass = reader("ADMIN_PASS").ToString()
                connection.Close()
                Return True
            End If
        End Using
        connection.Close()
        Return False
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles toSignUp.Click, Label5.Click, Label6.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub
    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
    Private Sub txtUser_MouseEnter(sender As Object, e As EventArgs) Handles txtUser.MouseEnter
        If txtUser.Text = "Enter Email" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtUser_MouseLeave(sender As Object, e As EventArgs) Handles txtUser.MouseLeave
        If txtUser.Text = "" Then
            txtUser.Text = "Enter Email"
            txtUser.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.Text <> "Enter Password" Then
            If ShowPass.Checked Then
                txtPass.PasswordChar = ControlChars.NullChar
            Else
                txtPass.PasswordChar = If(txtPass.Focused, "*", ControlChars.NullChar)
            End If
        End If
    End Sub
    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        If txtPass.Text = "Enter Password" Then
            txtPass.Text = ""
            txtPass.PasswordChar = If(ShowPass.Checked, ControlChars.NullChar, "*")
            txtPass.ForeColor = Color.Black
        End If
    End Sub
    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass.CheckedChanged
        If ShowPass.Checked Then
            txtPass.PasswordChar = ControlChars.NullChar
            txtPass.ForeColor = Color.Black
        Else
            txtPass.PasswordChar = "*"c
            If txtPass.Text = "Enter Password" Then
                txtPass.ForeColor = Color.Gray
            Else
                txtPass.ForeColor = Color.Black
            End If
        End If

        txtPass_TextChanged(txtPass, EventArgs.Empty)

        If ShowPass.Checked Then
            ShowPass.ForeColor = Color.Red
        Else
            ShowPass.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = Keys.Tab Then
            txtPass.PasswordChar = If(ShowPass.Checked, ControlChars.NullChar, "*")
        End If
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Class CustomMessageBox

        Inherits Form

        Public Sub New(ByVal message As String)

            Me.Text = "Custom Message Box"
            Me.Size = New Size(300, 150)

            Me.BackColor = ColorTranslator.FromHtml("#f0f0f0")

            Dim label As New Label()
            label.Text = message
            label.Dock = DockStyle.Fill
            Me.Controls.Add(label)

            Dim okButton As New Button()
            okButton.Text = "OK"
            okButton.Dock = DockStyle.Bottom
            AddHandler okButton.Click, AddressOf Me.OkButtonClick
            Me.Controls.Add(okButton)
        End Sub

        Private Sub OkButtonClick(sender As Object, e As EventArgs)
            Me.Close()
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.White


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()


        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)


        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)


        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)


        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Private Sub RoundCornerButtom(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(237, 27, 36)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(btnLogin.Width, 20, btn.Width, btn.Height - 10)
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        btnLogin.Region = New Region(rad)
    End Sub
End Class