<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        PictureBox2 = New PictureBox()
        ShowPass = New CheckBox()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        toSignUp = New Label()
        Label6 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        Label1.Location = New Point(449, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 29)
        Label1.TabIndex = 0
        Label1.Text = "Login Account"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = SystemColors.ButtonFace
        txtUser.BorderStyle = BorderStyle.None
        txtUser.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(465, 156)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Enter Email"
        txtUser.Size = New Size(231, 15)
        txtUser.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = SystemColors.ButtonFace
        txtPass.BorderStyle = BorderStyle.None
        txtPass.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(465, 219)
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "Enter Password"
        txtPass.Size = New Size(231, 15)
        txtPass.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(449, 305)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(231, 40)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-1, -5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(378, 463)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' ShowPass
        ' 
        ShowPass.AutoSize = True
        ShowPass.BackColor = Color.Transparent
        ShowPass.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point)
        ShowPass.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        ShowPass.Location = New Point(436, 263)
        ShowPass.Name = "ShowPass"
        ShowPass.Size = New Size(114, 19)
        ShowPass.TabIndex = 8
        ShowPass.Text = "Show Password"
        ShowPass.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonFace
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(436, 153)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(23, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonFace
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(436, 216)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(23, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(681, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 10
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(722, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 20)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(696, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 20)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Location = New Point(436, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 41)
        Label2.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Location = New Point(436, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(260, 41)
        Label3.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        Label5.Location = New Point(458, 349)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 16)
        Label5.TabIndex = 0
        Label5.Text = "Don't have an Account?"
        ' 
        ' toSignUp
        ' 
        toSignUp.AutoSize = True
        toSignUp.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        toSignUp.ForeColor = Color.FromArgb(CByte(237), CByte(27), CByte(36))
        toSignUp.Location = New Point(607, 349)
        toSignUp.Name = "toSignUp"
        toSignUp.Size = New Size(68, 16)
        toSignUp.TabIndex = 0
        toSignUp.Text = "SIGN UP"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(161))
        Label6.Location = New Point(450, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(231, 29)
        Label6.TabIndex = 0
        Label6.Text = "Welcome Back!"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(754, 455)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(ShowPass)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(toSignUp)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ShowPass As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents toSignUp As Label
    Friend WithEvents Label6 As Label
End Class
