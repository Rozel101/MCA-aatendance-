Public Class Form_AdminRegistration
    Public Function ClearFields(Optional ByVal ctlCol As Control.ControlCollection = Nothing)
        ClearFields = ""
        txtIdnumber.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtAddress.Clear()
        txtContactnumber.Clear()
        txtFullname.Clear()
    End Function
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtIdnumber.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtFullname.Text = "" Or txtAddress.Text = "" Or txtContactnumber.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_user 
                  where idnumber='" & txtIdnumber.Text & "'
                  or username ='" & txtUsername.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("Username or Password already exist!")
            ClearFields()
            Exit Sub
        End If

        RunCommand("Insert into tb_user VALUES (
                    '" & txtIdnumber.Text & "',
                    '" & txtUsername.Text & "',
                    '" & txtPassword.Text & "',
                    '" & txtFullname.Text & "',
                    '" & txtAddress.Text & "',
                    '" & txtContactnumber.Text & "')")
        If com.ExecuteNonQuery = 1 Then
            OkOnly("Successfully Registered!")
            ClearFields()
            Form_Login.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Form_AdminRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
    End Sub

    Private Sub txtIdnumber_TextChanged(sender As Object, e As EventArgs) Handles txtIdnumber.TextChanged

    End Sub

    Private Sub txtIdnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdnumber.KeyPress
        e.Handled = Not (NumbersOnly.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        e.Handled = Not (NoSpace.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        e.Handled = Not (NoSpace.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtContactnumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactnumber.TextChanged

    End Sub

    Private Sub txtContactnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactnumber.KeyPress
        e.Handled = Not (NumbersOnly.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub
End Class
