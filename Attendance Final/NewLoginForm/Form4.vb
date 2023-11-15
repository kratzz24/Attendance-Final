Public Class Form4
    Private adminUser As String
    Private adminPass As String

    Public Sub New()
    End Sub

    Public Sub New(adminUser As String, adminPass As String)
        InitializeComponent()
        Me.adminUser = adminUser
        Me.adminPass = adminPass
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Dim formreq As New Form5()
        formreq.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim formacc As New Form6()
        formacc.Show()
        Me.Close()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class