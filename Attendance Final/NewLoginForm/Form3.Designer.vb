<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        txtPass2 = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label13 = New Label()
        Label5 = New Label()
        txtLastName = New TextBox()
        Label3 = New Label()
        txtFirstName = New TextBox()
        Label2 = New Label()
        Label8 = New Label()
        cmbYear = New ComboBox()
        cmbDay = New ComboBox()
        cmbMonth = New ComboBox()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        cmbYear2 = New ComboBox()
        txtCourse = New TextBox()
        txtStudid = New TextBox()
        Label14 = New Label()
        Label7 = New Label()
        btnSubmit = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        toSignUp = New Label()
        Label12 = New Label()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        Label1.Location = New Point(516, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 25)
        Label1.TabIndex = 0
        Label1.Text = "Sign Up"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtPass2)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtPhone)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cmbYear)
        GroupBox1.Controls.Add(cmbDay)
        GroupBox1.Controls.Add(cmbMonth)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        GroupBox1.Location = New Point(33, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(360, 367)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ButtonFace
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(9, 207)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Username*"
        txtUsername.Size = New Size(345, 15)
        txtUsername.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.ButtonFace
        Label4.Location = New Point(7, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(347, 41)
        Label4.TabIndex = 21
        ' 
        ' txtPass2
        ' 
        txtPass2.BackColor = SystemColors.ButtonFace
        txtPass2.BorderStyle = BorderStyle.None
        txtPass2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass2.Location = New Point(9, 265)
        txtPass2.Name = "txtPass2"
        txtPass2.PlaceholderText = "Enter Password*"
        txtPass2.Size = New Size(345, 15)
        txtPass2.TabIndex = 18
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ButtonFace
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(9, 152)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter Email*"
        txtEmail.Size = New Size(345, 15)
        txtEmail.TabIndex = 18
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ButtonFace
        txtPhone.BorderStyle = BorderStyle.None
        txtPhone.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhone.Location = New Point(9, 95)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Enter Phone Number*"
        txtPhone.Size = New Size(345, 15)
        txtPhone.TabIndex = 18
        ' 
        ' Label13
        ' 
        Label13.BackColor = SystemColors.ButtonFace
        Label13.Location = New Point(7, 253)
        Label13.Name = "Label13"
        Label13.Size = New Size(347, 41)
        Label13.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.BackColor = SystemColors.ButtonFace
        Label5.Location = New Point(7, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(347, 41)
        Label5.TabIndex = 19
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = SystemColors.ButtonFace
        txtLastName.BorderStyle = BorderStyle.None
        txtLastName.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastName.Location = New Point(186, 36)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Enter Last Name*"
        txtLastName.Size = New Size(168, 15)
        txtLastName.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Location = New Point(7, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(347, 41)
        Label3.TabIndex = 19
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = SystemColors.ButtonFace
        txtFirstName.BorderStyle = BorderStyle.None
        txtFirstName.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstName.Location = New Point(7, 36)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "Enter First Name*"
        txtFirstName.Size = New Size(168, 15)
        txtFirstName.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Location = New Point(184, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 41)
        Label2.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.BackColor = SystemColors.ButtonFace
        Label8.Location = New Point(5, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 41)
        Label8.TabIndex = 19
        ' 
        ' cmbYear
        ' 
        cmbYear.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbYear.ForeColor = SystemColors.WindowFrame
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005"})
        cmbYear.Location = New Point(273, 327)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(79, 24)
        cmbYear.TabIndex = 12
        cmbYear.Text = "Year"
        ' 
        ' cmbDay
        ' 
        cmbDay.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbDay.ForeColor = SystemColors.WindowFrame
        cmbDay.FormattingEnabled = True
        cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmbDay.Location = New Point(170, 327)
        cmbDay.Name = "cmbDay"
        cmbDay.Size = New Size(97, 24)
        cmbDay.TabIndex = 11
        cmbDay.Text = "Day"
        ' 
        ' cmbMonth
        ' 
        cmbMonth.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbMonth.ForeColor = SystemColors.WindowFrame
        cmbMonth.FormattingEnabled = True
        cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        cmbMonth.Location = New Point(13, 327)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(151, 24)
        cmbMonth.TabIndex = 10
        cmbMonth.Text = "Month"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(6, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 16)
        Label6.TabIndex = 9
        Label6.Text = "Birth Date"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cmbYear2)
        GroupBox2.Controls.Add(txtCourse)
        GroupBox2.Controls.Add(txtStudid)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        GroupBox2.Location = New Point(422, 138)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(277, 188)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Academic Information"
        ' 
        ' cmbYear2
        ' 
        cmbYear2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbYear2.ForeColor = SystemColors.WindowFrame
        cmbYear2.FormattingEnabled = True
        cmbYear2.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        cmbYear2.Location = New Point(6, 84)
        cmbYear2.Name = "cmbYear2"
        cmbYear2.Size = New Size(265, 24)
        cmbYear2.TabIndex = 21
        cmbYear2.Text = "Enter Year*"
        ' 
        ' txtCourse
        ' 
        txtCourse.BackColor = SystemColors.ButtonFace
        txtCourse.BorderStyle = BorderStyle.None
        txtCourse.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCourse.Location = New Point(8, 148)
        txtCourse.Name = "txtCourse"
        txtCourse.PlaceholderText = "Enter Course*"
        txtCourse.Size = New Size(263, 15)
        txtCourse.TabIndex = 18
        ' 
        ' txtStudid
        ' 
        txtStudid.BackColor = SystemColors.ButtonFace
        txtStudid.BorderStyle = BorderStyle.None
        txtStudid.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudid.Location = New Point(8, 36)
        txtStudid.Name = "txtStudid"
        txtStudid.PlaceholderText = "Enter Student ID*"
        txtStudid.Size = New Size(263, 15)
        txtStudid.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.BackColor = SystemColors.ButtonFace
        Label14.Location = New Point(6, 136)
        Label14.Name = "Label14"
        Label14.Size = New Size(265, 41)
        Label14.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.BackColor = SystemColors.ButtonFace
        Label7.Location = New Point(6, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(265, 41)
        Label7.TabIndex = 19
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(446, 339)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(231, 40)
        btnSubmit.TabIndex = 14
        btnSubmit.Text = "Sign Up Account"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(696, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 20)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(722, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 20)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' toSignUp
        ' 
        toSignUp.AutoSize = True
        toSignUp.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        toSignUp.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        toSignUp.Location = New Point(618, 382)
        toSignUp.Name = "toSignUp"
        toSignUp.Size = New Size(56, 16)
        toSignUp.TabIndex = 16
        toSignUp.Text = "LOG IN"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        Label12.Location = New Point(450, 382)
        Label12.Name = "Label12"
        Label12.Size = New Size(163, 16)
        Label12.TabIndex = 17
        Label12.Text = "Already have an Account?"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(161))
        Label9.Location = New Point(422, 88)
        Label9.Name = "Label9"
        Label9.Size = New Size(277, 29)
        Label9.TabIndex = 18
        Label9.Text = "Join Us!"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(754, 455)
        Controls.Add(PictureBox5)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox4)
        Controls.Add(toSignUp)
        Controls.Add(GroupBox1)
        Controls.Add(Label12)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(Label9)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents toSignUp As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtStudid As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbYear2 As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
End Class
