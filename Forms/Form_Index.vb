Public Class Form_Index
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_AttendanceOption.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Login.Show()
        Me.Close()
    End Sub

    Private Sub Form_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        SetAttendance()
        Dim Sampleclass1 As New SampleClass1
        Sampleclass1.Remarks()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class