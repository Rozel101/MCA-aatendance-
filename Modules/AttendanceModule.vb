Imports MySql.Data.MySqlClient
Module AttendanceModule
    Public Sub SetAttendance()
        RunQuery("Select idnumber from tb_students")
        For Each row As DataRow In ds.Tables("querytable").Rows
            Dim idnumber As String = row(0).ToString
            RunQuery("Select * from tb_attendance WHERE idnumber = '" & idnumber & "' and date = CURDATE()")
            If ds.Tables("querytable").Rows.Count > 0 Then

            Else
                RunCommand("Insert into tb_attendance (idnumber,date,login,logout,remarks) VALUES (
                           '" & idnumber & "',
                           CURDATE(),
                           '',
                           '',
                           '')")
                com.ExecuteNonQuery()
            End If
        Next
    End Sub

End Module
