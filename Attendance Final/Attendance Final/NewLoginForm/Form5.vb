Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cms
Imports ZstdSharp.Unsafe
Public Class Form5
    Dim studID As String = ""
    Dim adminUser As String = ""
    Dim adminPass As String = ""

    Private connectionString As String = "server=localhost;user=root;password=;port=3306;database=studentdb"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ADmin As New Form4(adminUser, adminPass)
        ADmin.Show()
        Me.Close()
    End Sub
    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try
            Reload("SELECT CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULLNAME,LOGDATE,TIME_IN,AM_STATUS,TIME_OUT,PM_STATUS FROM table_attendance INNER JOIN table_student ON table_attendance.STUD_ID=table_student.STUD_ID WHERE DATE(LOGDATE)=CURDATE()", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try
            Reload("SELECT CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULLNAME,LOGDATE,TIME_IN,AM_STATUS,TIME_OUT,PM_STATUS FROM table_attendance INNER JOIN table_student ON table_attendance.STUD_ID=table_student.STUD_ID WHERE WEEK(LOGDATE)=WEEK(NOW())", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Try
            Reload("SELECT CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULLNAME,LOGDATE,TIME_IN,AM_STATUS,TIME_OUT,PM_STATUS FROM table_attendance INNER JOIN table_student ON table_attendance.STUD_ID=table_student.STUD_ID WHERE MONTH(LOGDATE)=MONTH(NOW())", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        Try
            Reload("SELECT CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULLNAME,LOGDATE,TIME_IN,AM_STATUS,TIME_OUT,PM_STATUS FROM table_attendance INNER JOIN table_student ON table_attendance.STUD_ID=table_student.STUD_ID WHERE YEAR(LOGDATE)=YEAR(NOW())", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Try
            Reload("SELECT CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULLNAME,LOGDATE,TIME_IN,AM_STATUS,TIME_OUT,PM_STATUS FROM table_attendance INNER JOIN table_student ON table_attendance.STUD_ID=table_student.STUD_ID", DataGridView1)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class