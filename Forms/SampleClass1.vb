Public Class SampleClass1

    Public Sub Remarks()
        RunCommand("Update tb_attendance as t1
                    JOIN tb_students as t2 on t2.idnumber = t1.idnumber
                    JOIN tb_schedule as t3 on t3.sectionnumber = t2.sectionnumber
                    SET
                    t1.remarks = IF(curtime() > date_add(t3.sched, INTERVAL 8 HOURS), 'ABSENT', t1.remarks)
                    WHERE t1.date = curdate()
                    ")
    End Sub


End Class
