Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cms
Imports ZstdSharp.Unsafe

Public Class Form2
    Private connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"
    Private _username As String
    Private _studID As String


    Public Sub New(username As String, studID As String)
        InitializeComponent()
        _username = username
        _studID = studID
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudentID.Text = _studID
        rtbmessages.SelectionAlignment = HorizontalAlignment.Center
        ReloadAttendance()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelDate.Text = DateTime.Now.ToString("yyyy/M/dd")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim loginform As New Form1
        loginform.Show()
    End Sub

    Private Sub btnTimein_Click(sender As Object, e As EventArgs) Handles btnTimein.Click
        Try
            rtbmessages.Clear()
            If txtStudentID.Text = "" Then
                rtbmessages.AppendText("Please enter Student ID" & Environment.NewLine)
            Else
                reloadtxt("SELECT * FROM table_student WHERE STUD_ID='" & txtStudentID.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM table_attendance WHERE STUD_ID='" & txtStudentID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND AM_STATUS='Time In'")
                    If dt.Rows.Count > 0 Then
                        rtbmessages.AppendText("You have already timed in for today" & Environment.NewLine)
                    Else
                        createlogged("INSERT INTO table_attendance(STUD_ID, LOGDATE, TIME_IN, AM_STATUS) VALUES('" & txtStudentID.Text & "', '" & LabelDate.Text & "', '" & TimeOfDay & "', 'Time in')")
                        rtbmessages.AppendText("Successfully Timed In" & Environment.NewLine)
                    End If
                End If
            End If
        Catch ex As Exception
            ' Handle any exceptions here
        End Try
    End Sub

    Private Sub btnTimeout_Click(sender As Object, e As EventArgs) Handles btnTimeout.Click
        Try
            rtbmessages.Clear()

            If txtStudentID.Text = "" Then
                rtbmessages.AppendText("Please enter Student ID" & Environment.NewLine)
            Else
                reloadtxt("SELECT * FROM table_student WHERE STUD_ID='" & txtStudentID.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM table_attendance WHERE STUD_ID='" & txtStudentID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND AM_STATUS='Time In'")
                    If dt.Rows.Count > 0 Then
                        reloadtxt("SELECT * FROM table_attendance WHERE STUD_ID='" & txtStudentID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND PM_STATUS='Time Out'")
                        If dt.Rows.Count > 0 Then
                            rtbmessages.AppendText("You have already timed out for today. You cannot time out again." & Environment.NewLine)
                        Else
                            updateslogged("UPDATE table_attendance SET TIME_OUT='" & TimeOfDay & "', PM_STATUS='Time Out' WHERE STUD_ID='" & txtStudentID.Text & "' AND LOGDATE='" & LabelDate.Text & "'")
                            rtbmessages.AppendText("Successfully Timed Out" & Environment.NewLine)
                            rtbmessages.AppendText("Have a safe day!" & Environment.NewLine)
                        End If
                    Else
                        rtbmessages.AppendText("You have not timed in today. Please time in first." & Environment.NewLine)
                    End If
                End If
            End If
        Catch ex As Exception
            ' Handle exceptions
        End Try
    End Sub



    Public Sub ReloadAttendance()
        Try
            NewMethod()
        Catch ex As Exception

        End Try
    End Sub

    Private Shared Sub NewMethod()
        Reload("SELECT * FROM table_attendance")
    End Sub

    Private Shared Sub Reload(v As String)
        Throw New NotImplementedException()
    End Sub

    Private Sub rtbmessages_TextChanged(sender As Object, e As EventArgs) Handles rtbmessages.TextChanged

    End Sub
End Class
