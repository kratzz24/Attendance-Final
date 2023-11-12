<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        btnAccount = New Button()
        Button4 = New Button()
        btnRecord = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(143, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 46)
        Label1.TabIndex = 0
        Label1.Text = "Admin Dashboard"
        ' 
        ' btnAccount
        ' 
        btnAccount.Location = New Point(99, 206)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(130, 53)
        btnAccount.TabIndex = 1
        btnAccount.Text = "Delete / Update Account"
        btnAccount.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(480, 376)
        Button4.Name = "Button4"
        Button4.Size = New Size(109, 34)
        Button4.TabIndex = 4
        Button4.Text = "Logout"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnRecord
        ' 
        btnRecord.Location = New Point(369, 206)
        btnRecord.Name = "btnRecord"
        btnRecord.Size = New Size(130, 53)
        btnRecord.TabIndex = 5
        btnRecord.Text = "Check Record"
        btnRecord.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(601, 422)
        Controls.Add(btnRecord)
        Controls.Add(Button4)
        Controls.Add(btnAccount)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAccount As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnRecord As Button
End Class
