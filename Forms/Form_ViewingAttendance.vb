Public Class Form_ViewingAttendance

    Public Function Load_data()
        Dim dtpdate As String = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        RunQuery("SELECT t1.idnumber 'ID Number', t1.lastname 'Last Name',t1.firstname 'First Name',t2.gradeyearname 'Grade Level',
                  t3.sectionname 'Section',t4.sched 'Schedule',t5.date 'Date',t5.login 'Login',t5.logout 'Logout',t5.remarks 'Remarks' from tb_students t1
                  join tb_gradeyearlvl t2 on t2.gradeyearnumber = t1.gradeyearnumber
                  join tb_section t3 on t3.sectionnumber = t1.sectionnumber
                  join tb_schedule t4 on t4.sectionnumber = t3.sectionnumber
                  join tb_attendance t5 on t5.idnumber = t1.idnumber
                  WHERE t5.date = '" & dtpdate & "'
                  Order by t5.date, t2.gradeyearname, t3.sectionname, t1.lastname, t1.firstname")
        DataGridView1.DataSource = ds.Tables("querytable")
    End Function
    Private Sub Form_ViewingAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        load_data()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Load_data()
    End Sub
End Class