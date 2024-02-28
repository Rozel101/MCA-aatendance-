Public Class Form_UserManagement
    Dim idnumber As String = ""
    Dim username As String = ""
    Public Sub Load_data()
        RunQuery("select * from tb_user")
        DataGridView1.DataSource = ds.Tables("querytable")
        DataGridView1.ClearSelection()
    End Sub
    Public Function ClearFields()
        ClearFields = ""
        txtIdnumber.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtAddress.Clear()
        txtContactnumber.Clear()
        txtFullname.Clear()
        idnumber = ""
        username = ""
    End Function
    Private Sub Form_UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        Load_data()
    End Sub
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
            Load_data()
            ClearFields()
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idnumber = "" Then
            Crit("Please select a profile to delete!")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this user's profile?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_user WHERE idnumber='" & idnumber & "'")
            If com.ExecuteNonQuery = 1 Then
                OkOnly("Deleted Successfully!")
                Load_data()
                ClearFields()
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dgvselected As DataGridViewRow
            dgvselected = DataGridView1.Rows(e.RowIndex)
            txtIdnumber.Text = dgvselected.Cells(0).Value
            idnumber = dgvselected.Cells(0).Value
            txtUsername.Text = dgvselected.Cells(1).Value
            username = dgvselected.Cells(1).Value
            txtPassword.Text = dgvselected.Cells(2).Value
            txtFullname.Text = dgvselected.Cells(3).Value
            txtAddress.Text = dgvselected.Cells(4).Value
            txtContactnumber.Text = dgvselected.Cells(5).Value

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtIdnumber.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtAddress.Text = "" Or txtContactnumber.Text = "" Or txtFullname.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        If txtIdnumber.Text <> idnumber Or txtUsername.Text <> username Then
            RunQuery("Select * from tb_user WHERE 
                      idnumber = '" & txtIdnumber.Text & "' or
                      username = '" & txtUsername.Text & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Crit("ID Number or Username already exist!")
                Exit Sub
                txtUsername.Clear()
                txtIdnumber.Clear()
            End If
        End If

        RunCommand("Update tb_user SET 
                    idnumber = '" & txtIdnumber.Text & "',
                    username = '" & txtUsername.Text & "',
                    password = '" & txtPassword.Text & "',
                    fullname = '" & txtFullname.Text & "',
                    address = '" & txtAddress.Text & "',
                    contactnumber ='" & txtContactnumber.Text & "'
                    WHERE idnumber = '" & idnumber & "' and username='" & username & "'")
        If com.ExecuteNonQuery = 1 Then
            OkOnly("Updated Successfully!")
            Load_data()
            ClearFields()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
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
        e.Handled = Not (Names.IndexOf(e.KeyChar) > -1 _
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