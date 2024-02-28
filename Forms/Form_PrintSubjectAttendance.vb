Imports MySql.Data.MySqlClient
Public Class Form_PrintSubjectAttendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter subject code")
            Exit Sub
        End If

        Dim dtp As String = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        dt = New DataTable("DataTable1")
        adp = New MySqlDataAdapter("Select t1.idnumber,t1.subjectcode,t2.subjectname,t3.teachername,t2.sched,t1.date,t1.login,t1.remarks,concat(t4.lastname,' ',t4.firstname) as studentname from tb_subjattendance as t1
                  JOIN tb_subject as t2 on t2.subjectcode = t1.subjectcode
                  JOIN tb_teacher as t3 on t3.id = t2.teacherid
                  JOIN tb_students as t4 on t4.idnumber = t1.idnumber              
                  WHERE t1.date = '" & dtp & "' and t1.subjectcode = '" & TextBox1.Text & "'
                  ORDER by studentname", con)
        adp.Fill(dt)

        If dt.Rows.Count = 0 Then
            MsgBox("No records")
            Exit Sub
        End If

        Dim SubjAttendance As New SubjAttendance
        SubjAttendance.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = SubjAttendance

    End Sub
End Class