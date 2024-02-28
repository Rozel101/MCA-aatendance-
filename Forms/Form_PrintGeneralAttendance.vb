Imports MySql.Data.MySqlClient
Public Class Form_PrintGeneralAttendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim date1 As String = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        dt = New DataTable("DS_AttendancePrinting")
        adp = New MySqlDataAdapter("select t1.idnumber,CONCAT(t1.lastname,' ',t1.firstname) as fullname, t2.gradeyearname, t3.sectionname,t4.date,t5.sched,t4.login,t4.logout,if(t4.login > t5.sched,'LATE','PRESENT') as remarks from tb_students as t1 join tb_gradeyearlvl as t2 on t2.gradeyearnumber = t1.gradeyearnumber join tb_section as t3 on t3.sectionnumber = t1.sectionnumber join tb_attendance as t4 on t4.idnumber = t1.idnumber join tb_schedule as t5 on t5.sectionnumber = t1.sectionnumber WHERE t4.date = '" & date1 & "'", con)
        adp.Fill(dt)

        If dt.Rows.Count = 0 Then
            MsgBox("No records")
            Exit Sub
        End If

        Dim AttendanceReport As New AttendanceReport
        AttendanceReport.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = AttendanceReport
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
    End Sub
End Class