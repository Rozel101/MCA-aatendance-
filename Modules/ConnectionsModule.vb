Imports MySql.Data.MySqlClient
Module ConnectionsModule

    Public con As New MySqlConnection("host=localhost;user=mca_ams;password=sadthesis2023;port=3306;database=db_mcaams")
    Public com As New MySqlCommand
    Public adp As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public Sub Openconnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub RunQuery(ByVal querystatement As String)
        Try
            adp = New MySqlDataAdapter(querystatement, con)
            ds = New DataSet
            adp.Fill(ds, "querytable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RunCommand(ByVal commandstatement As String)
        Try
            com = New MySqlCommand(commandstatement, con)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub PanelRemove()
        ResetAutoIncrement()
        SetAttendance()
        Form_AdminRegistration.Close()
        Form_PrintGeneralAttendance.Close()
        Form_AttendanceGeneral.Close()
        Form_AttendanceSubject.Close()
        Form_BarcodePrinting.Close()
        Form_Maintenance.Close()
        Form_StudentMaintenance.Close()
        Form_StudentRegistration.Close()
        Form_UserManagement.Close()
        Form_ViewingAttendance.Close()
        Form_PrintSubjectAttendance.Close()
    End Sub

    Public Sub Crit(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.Critical, "MCA-AMS")
    End Sub
    Public Sub OkOnly(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.OkOnly, "MCA-AMS")
    End Sub

    Public Sub ResetAutoIncrement()
        RunQuery("Select * from tb_students")
        If ds.Tables("querytable").Rows.Count = 0 Then
            RunCommand("Alter table tb_students auto_increment = 1")
            com.ExecuteNonQuery()
        End If

        RunQuery("Select * from tb_attendance")
        If ds.Tables("querytable").Rows.Count = 0 Then
            RunCommand("Alter table tb_attendance auto_increment = 1")
            com.ExecuteNonQuery()
        End If
    End Sub
End Module