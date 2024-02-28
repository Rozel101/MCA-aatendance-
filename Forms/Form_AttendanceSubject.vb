Imports System.ComponentModel

Public Class Form_AttendanceSubject
    Public Sub Clear()
        txtSubjectCode.Clear()
        txtPassword.Clear()
        DataGridView1.DataSource = Nothing
        txtSubjectCode.Enabled = True
        txtPassword.Enabled = True
        lblSched.Text = ""
        lblSection.Text = ""
        lblGradeYearLevel.Text = ""
        lblSection.Text = ""
        lblTeacherName.Text = ""
        lblSubjectName.Text = ""
    End Sub
    Public Sub loadstudents()
        RunQuery("Select t1.idnumber,t1.lastname,t1.firstname,t2.login,t2.remarks from tb_students as t1
                  JOIN tb_subjattendance as t2 on t2.idnumber = t1.idnumber
                  WHERE t2.subjectcode = '" & txtSubjectCode.Text & "' and t2.date = CURDATE()")
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = ds.Tables("querytable")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSubjectCode.Text = "" Or txtPassword.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select t1.subjectname,t2.teachername,t1.sched,t3.gradeyearname,t4.sectionname from tb_subject as t1
                  JOIN tb_teacher as t2 on t2.id = t1.teacherid
                  JOIN tb_gradeyearlvl as t3 on t3.gradeyearnumber = t1.gradeyearnumber
                  JOIN tb_section as t4 on t4.sectionnumber = t1.sectionnumber
                  WHERE t1.subjectcode = '" & txtSubjectCode.Text & "' and t1.password = '" & txtPassword.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            lblSubjectName.Text = ds.Tables("querytable").Rows(0)(0).ToString
            lblTeacherName.Text = ds.Tables("querytable").Rows(0)(1).ToString
            lblSched.Text = ds.Tables("querytable").Rows(0)(2).ToString
            lblGradeYearLevel.Text = ds.Tables("querytable").Rows(0)(3).ToString
            lblSection.Text = ds.Tables("querytable").Rows(0)(4).ToString
        Else
            Crit("Please check subject code or password")
            Clear()
            Exit Sub
        End If
        Label9.Text = Format(Today, "MMM-dd-yyyy")
        loadstudents()
        txtPassword.Enabled = False
        txtSubjectCode.Enabled = False


    End Sub

    Private Sub Form_AttendanceSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        Try
            Dim grade As String
            Dim section As String
            RunQuery("Select * from tb_students WHERE idnumber='" & txtBarcode.Text & "'")
            If ds.Tables("querytable").Rows.Count = 0 Then
                Exit Sub
            Else
                grade = ds.Tables("querytable").Rows(0)("gradeyearnumber").ToString
                section = ds.Tables("querytable").Rows(0)("sectionnumber").ToString
            End If

            RunQuery("Select gradeyearnumber,sectionnumber from tb_subject WHERE subjectcode = '" & txtSubjectCode.Text & "'")
            If grade <> ds.Tables("querytable").Rows(0)("gradeyearnumber").ToString Or section <> ds.Tables("querytable").Rows(0)("sectionnumber").ToString Then
                MsgBox("Student not enrolled on this subject")
                txtBarcode.Clear()
                Exit Sub
            End If

            RunQuery("Select * from tb_subjattendance WHERE idnumber = '" & txtBarcode.Text & "' and date = CURDATE() and subjectcode = '" & txtSubjectCode.Text & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                MsgBox("Student already logged in")
                txtBarcode.Clear()
                Exit Sub
            End If


            RunCommand("Insert IGNORE into tb_subjattendance (idnumber,subjectcode,date,login,remarks) VALUES ('" & txtBarcode.Text & "', '" & txtSubjectCode.Text & "', CURDATE(),CURTIME(),'PRESENT')")
            com.ExecuteNonQuery()
            MsgBox("Success")
            txtBarcode.Clear()
            loadstudents()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
    End Sub

    Private Sub Form_AttendanceSubject_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form_AttendanceOption.Show()
    End Sub
End Class