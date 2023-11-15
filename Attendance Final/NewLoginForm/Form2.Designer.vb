<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        btnLogout = New Button()
        btnTimeout = New Button()
        LabelDate = New Label()
        txtStudentID = New TextBox()
        Timer1 = New Timer(components)
        rtbmessages = New RichTextBox()
        btnTimein = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(12, -5)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 54)
        Label1.TabIndex = 0
        Label1.Text = "Student Attendance"
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.Location = New Point(637, 396)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(104, 42)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnTimeout
        ' 
        btnTimeout.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        btnTimeout.Location = New Point(392, 74)
        btnTimeout.Name = "btnTimeout"
        btnTimeout.Size = New Size(113, 45)
        btnTimeout.TabIndex = 2
        btnTimeout.Text = "Time Out"
        btnTimeout.UseVisualStyleBackColor = True
        ' 
        ' LabelDate
        ' 
        LabelDate.AutoSize = True
        LabelDate.BackColor = SystemColors.ButtonFace
        LabelDate.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        LabelDate.ForeColor = SystemColors.ActiveCaptionText
        LabelDate.Location = New Point(597, 15)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(57, 28)
        LabelDate.TabIndex = 4
        LabelDate.Text = "Date"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        txtStudentID.Location = New Point(250, 358)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(255, 25)
        txtStudentID.TabIndex = 6
        txtStudentID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' rtbmessages
        ' 
        rtbmessages.Enabled = False
        rtbmessages.Font = New Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point)
        rtbmessages.Location = New Point(107, 125)
        rtbmessages.Name = "rtbmessages"
        rtbmessages.Size = New Size(537, 211)
        rtbmessages.TabIndex = 8
        rtbmessages.Text = ""
        ' 
        ' btnTimein
        ' 
        btnTimein.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        btnTimein.Location = New Point(250, 74)
        btnTimein.Name = "btnTimein"
        btnTimein.Size = New Size(113, 45)
        btnTimein.TabIndex = 9
        btnTimein.Text = "Time In"
        btnTimein.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(753, 450)
        Controls.Add(btnTimein)
        Controls.Add(rtbmessages)
        Controls.Add(txtStudentID)
        Controls.Add(LabelDate)
        Controls.Add(btnTimeout)
        Controls.Add(btnLogout)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Attendance System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnTimeout As Button
    Friend WithEvents LabelDate As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents rtbmessages As RichTextBox
    Friend WithEvents btnTimein As Button
End Class
