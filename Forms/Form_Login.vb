Imports mysql.data.mysqlclient
Public Class Form_Login

    Private closebuttonclicked As Boolean = False
    Public Function ClearFields()
        ClearFields = ""
        txtUsername.Clear()
        txtPassword.Clear()
    End Function

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Fields are required!", MsgBoxStyle.Critical, "MCA-AMS")
            Exit Sub
        End If

        RunQuery("Select * from tb_user WHERE 
                  BINARY username = '" & txtUsername.Text & "' 
                  and BINARY password= '" & txtPassword.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            OkOnly("Login success!")
            Form_MainForm.Show()
            ClearFields()
            closebuttonclicked = True
            Me.Close()
            Exit Sub
        End If

        Crit("Please check username or password!")
        ClearFields()
        Exit Sub
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to exit the application?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        Dim Sampleclass1 As New SampleClass1
        Sampleclass1.Remarks()
        RunQuery("Select * from tb_user")
        If ds.Tables("querytable").Rows.Count = 0 Then
            Crit("No registered Admin yet!")
            Form_AdminRegistration.Show()
            closebuttonclicked = True
            Me.Close()
        End If

    End Sub
    Private Sub Form_Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not closebuttonclicked Then
            Form_Index.Show()
        End If
    End Sub
End Class
