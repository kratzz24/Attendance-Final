<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnDaily = New Button()
        btnWeekly = New Button()
        btnMonthly = New Button()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        btnYearly = New Button()
        btnAll = New Button()
        btnExport = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDaily
        ' 
        btnDaily.Location = New Point(12, 12)
        btnDaily.Name = "btnDaily"
        btnDaily.Size = New Size(133, 45)
        btnDaily.TabIndex = 0
        btnDaily.Text = "Daily"
        btnDaily.UseVisualStyleBackColor = True
        ' 
        ' btnWeekly
        ' 
        btnWeekly.Location = New Point(12, 63)
        btnWeekly.Name = "btnWeekly"
        btnWeekly.Size = New Size(133, 45)
        btnWeekly.TabIndex = 1
        btnWeekly.Text = "Weekly"
        btnWeekly.UseVisualStyleBackColor = True
        ' 
        ' btnMonthly
        ' 
        btnMonthly.Location = New Point(12, 114)
        btnMonthly.Name = "btnMonthly"
        btnMonthly.Size = New Size(133, 45)
        btnMonthly.TabIndex = 2
        btnMonthly.Text = "Monthly"
        btnMonthly.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(151, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(626, 491)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(12, 443)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 60)
        Button1.TabIndex = 4
        Button1.Text = "Retunr To Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnYearly
        ' 
        btnYearly.Location = New Point(12, 165)
        btnYearly.Name = "btnYearly"
        btnYearly.Size = New Size(133, 45)
        btnYearly.TabIndex = 5
        btnYearly.Text = "Yearly"
        btnYearly.UseVisualStyleBackColor = True
        ' 
        ' btnAll
        ' 
        btnAll.Location = New Point(12, 216)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(133, 45)
        btnAll.TabIndex = 6
        btnAll.Text = "All Records"
        btnAll.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(12, 267)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(133, 45)
        btnExport.TabIndex = 7
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(789, 515)
        Controls.Add(btnExport)
        Controls.Add(btnAll)
        Controls.Add(btnYearly)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(btnMonthly)
        Controls.Add(btnWeekly)
        Controls.Add(btnDaily)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Check Records"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnDaily As Button
    Friend WithEvents btnWeekly As Button
    Friend WithEvents btnMonthly As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnYearly As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents btnExport As Button
End Class
