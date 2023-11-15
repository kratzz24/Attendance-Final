<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        components = New ComponentModel.Container()
        btnUpdate = New Button()
        btnDelete = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        txtNewFName = New TextBox()
        txtNewLName = New TextBox()
        txtNewCourse = New TextBox()
        txtNewEmail = New TextBox()
        txtNewPass = New TextBox()
        txtNewUser = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cmbNewYear = New ComboBox()
        Timer1 = New Timer(components)
        Label8 = New Label()
        txtStudentID = New TextBox()
        Label9 = New Label()
        txtNewPhone = New TextBox()
        TextBox1 = New TextBox()
        btnRefresh = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(10, 442)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(116, 47)
        btnUpdate.TabIndex = 0
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(142, 442)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 47)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(1123, 442)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 47)
        Button3.TabIndex = 2
        Button3.Text = "Return To Dashboard"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(282, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(957, 424)
        DataGridView1.TabIndex = 3
        ' 
        ' txtNewFName
        ' 
        txtNewFName.Location = New Point(12, 55)
        txtNewFName.Name = "txtNewFName"
        txtNewFName.PlaceholderText = "First Name"
        txtNewFName.Size = New Size(100, 23)
        txtNewFName.TabIndex = 4
        ' 
        ' txtNewLName
        ' 
        txtNewLName.Location = New Point(158, 55)
        txtNewLName.Name = "txtNewLName"
        txtNewLName.PlaceholderText = "Last Name"
        txtNewLName.Size = New Size(100, 23)
        txtNewLName.TabIndex = 5
        ' 
        ' txtNewCourse
        ' 
        txtNewCourse.Location = New Point(158, 106)
        txtNewCourse.Name = "txtNewCourse"
        txtNewCourse.PlaceholderText = "Course"
        txtNewCourse.Size = New Size(100, 23)
        txtNewCourse.TabIndex = 7
        ' 
        ' txtNewEmail
        ' 
        txtNewEmail.Location = New Point(13, 250)
        txtNewEmail.Name = "txtNewEmail"
        txtNewEmail.PlaceholderText = "Email"
        txtNewEmail.Size = New Size(246, 23)
        txtNewEmail.TabIndex = 8
        ' 
        ' txtNewPass
        ' 
        txtNewPass.Location = New Point(13, 340)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.PlaceholderText = "Password"
        txtNewPass.Size = New Size(246, 23)
        txtNewPass.TabIndex = 9
        ' 
        ' txtNewUser
        ' 
        txtNewUser.Location = New Point(13, 294)
        txtNewUser.Name = "txtNewUser"
        txtNewUser.PlaceholderText = "Username"
        txtNewUser.Size = New Size(246, 23)
        txtNewUser.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 11
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(158, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 12
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 13
        Label3.Text = "Year"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(158, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 14
        Label4.Text = "Course"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 15
        Label5.Text = "New Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 15)
        Label6.TabIndex = 16
        Label6.Text = "New Username"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 322)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 15)
        Label7.TabIndex = 17
        Label7.Text = "New Password"
        ' 
        ' cmbNewYear
        ' 
        cmbNewYear.ForeColor = SystemColors.WindowFrame
        cmbNewYear.FormattingEnabled = True
        cmbNewYear.Items.AddRange(New Object() {"1st" & vbTab, "2nd", "3rd", "4th"})
        cmbNewYear.Location = New Point(12, 106)
        cmbNewYear.Name = "cmbNewYear"
        cmbNewYear.Size = New Size(121, 23)
        cmbNewYear.TabIndex = 18
        cmbNewYear.Text = "Year"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 144)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 15)
        Label8.TabIndex = 20
        Label8.Text = "Student ID"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Location = New Point(12, 162)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "Student ID"
        txtStudentID.Size = New Size(246, 23)
        txtStudentID.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 188)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 15)
        Label9.TabIndex = 22
        Label9.Text = "New Phone"
        ' 
        ' txtNewPhone
        ' 
        txtNewPhone.Location = New Point(13, 206)
        txtNewPhone.Name = "txtNewPhone"
        txtNewPhone.PlaceholderText = "Phone Number"
        txtNewPhone.Size = New Size(246, 23)
        txtNewPhone.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(13, 390)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(246, 23)
        TextBox1.TabIndex = 23
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(282, 442)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(116, 47)
        btnRefresh.TabIndex = 24
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1251, 501)
        Controls.Add(btnRefresh)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(txtNewPhone)
        Controls.Add(Label8)
        Controls.Add(txtStudentID)
        Controls.Add(cmbNewYear)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNewUser)
        Controls.Add(txtNewPass)
        Controls.Add(txtNewEmail)
        Controls.Add(txtNewCourse)
        Controls.Add(txtNewLName)
        Controls.Add(txtNewFName)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Name = "Form6"
        Text = "Update /  Delete Account"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNewFName As TextBox
    Friend WithEvents txtNewLName As TextBox
    Friend WithEvents txtNewCourse As TextBox
    Friend WithEvents txtNewEmail As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtNewUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbNewYear As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNewPhone As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRefresh As Button
End Class
