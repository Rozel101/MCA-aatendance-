Public Class Form_AttendanceGeneral
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.Text = "" Then
        Else

            RunQuery("Select * from tb_attendance WHERE idnumber = '" & txtBarcode.Text & "' and date=CURDATE()")
            If ds.Tables("querytable").Rows.Count > 0 Then
                ''Check if no login
                If ds.Tables("querytable").Rows(0)(3).ToString = "00:00:00" Then
                    RunCommand("UPDATE tb_attendance AS t1
                    JOIN tb_students AS t2 ON t2.idnumber = t1.idnumber
                    JOIN tb_schedule AS t3 ON t3.sectionnumber = t2.sectionnumber AND t3.gradeyearnumber = t2.gradeyearnumber
                    SET t1.login = CURTIME(), t1.remarks = CASE
                    WHEN t1.login > t3.sched THEN 'LATE'
                    ELSE 'PRESENT'
                    END
                    WHERE t1.date = CURDATE()")
                    com.ExecuteNonQuery()
                    MsgBox("Login success")
                    txtBarcode.Clear()
                ElseIf ds.Tables("querytable").Rows(0)(3).tostring <> "00:00:00" And ds.Tables("querytable").Rows(0)(4).ToString = "00:00:00" Then
                    RunCommand("Update tb_attendance SET logout=CURTIME() WHERE idnumber = '" & txtBarcode.Text & "' and date=CURDATE()")
                    com.ExecuteNonQuery()
                    MsgBox("Logout success")
                    txtBarcode.Clear()
                ElseIf ds.Tables("querytable").Rows(0)(3).tostring <> "00:00:00" And ds.Tables("querytable").Rows(0)(4).ToString <> "00:00:00" Then
                    MsgBox("Already logged in and logged out")
                    txtBarcode.Clear()
                End If

            End If
        End If
    End Sub
End Class