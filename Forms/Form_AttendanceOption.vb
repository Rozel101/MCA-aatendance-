Public Class Form_AttendanceOption
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_AttendanceGeneral.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_AttendanceSubject.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_Index.Show()
        Me.Close()
    End Sub
End Class