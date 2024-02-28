Public Class Form_Maintenance
    Dim id As String = ""
    Dim subjid As String = ""
    Public Sub Clear()
        txtIdNumber.Clear()
        txtTeacherName.Clear()
        com.Parameters.Clear()
        id = ""
        subjid = ""
        txtSubjCode.Clear()
        txtSubjName.Clear()
        txtSched.Clear()
        txtPassword.Clear()
        cbTeacher.SelectedIndex = -1
        cbGYlevel.SelectedIndex = -1
        cbSection.SelectedIndex = -1
    End Sub
    Public Sub ComParameters()
        com.Parameters.AddWithValue("@idnumber", txtIdNumber.Text)
        com.Parameters.AddWithValue("@teacher", txtTeacherName.Text)
    End Sub
    Public Sub load_data()
        RunQuery("Select * from tb_teacher")
        DataGridView4.DataSource = ds.Tables("querytable")

        RunQuery("Select t1.id,t1.subjectcode,t1.subjectname,t2.teachername as teacher,t1.sched,t3.gradeyearname as grade,t4.sectionname as section,password from tb_subject as t1
                  JOIN tb_teacher as t2 on t2.id = t1.teacherid
                  JOIN tb_gradeyearlvl as t3 on t3.gradeyearnumber = t1.gradeyearnumber
                  JOIN tb_section as t4 on t4.sectionnumber = t1.sectionnumber")
        DataGridView1.DataSource = ds.Tables("querytable")

        RunQuery("Select * from tb_teacher")
        cbTeacher.DataSource = ds.Tables("querytable")
        cbTeacher.DisplayMember = "teachername"
        cbTeacher.ValueMember = "id"
        cbTeacher.SelectedIndex = -1

        RunQuery("Select * from tb_gradeyearlvl")
        cbGYlevel.DataSource = ds.Tables("querytable")
        cbGYlevel.DisplayMember = "gradeyearname"
        cbGYlevel.ValueMember = "gradeyearnumber"
        cbGYlevel.SelectedIndex = -1


    End Sub

    Private Sub btnTeacherAdd_Click(sender As Object, e As EventArgs) Handles btnTeacherAdd.Click
        If txtIdNumber.Text = "" Or txtTeacherName.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_teacher where idnumber = '" & txtIdNumber.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("ID Number already exist!")
            txtIdNumber.Clear()
            Exit Sub
        End If

        Dim input As String = txtIdNumber.Text
        Dim result As Integer

        If Integer.TryParse(input, result) Then
            RunCommand("Insert into tb_teacher (idnumber,teachername) VALUES (@idnumber,@teacher)")
            ComParameters()
            com.ExecuteNonQuery()
            OkOnly("Success!")
            Clear()
            load_data()
        Else
            Crit("Please enter a valid id number")
            Exit Sub
        End If


    End Sub
    Private Sub Form_Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        load_data()
    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Try
            For Each row As DataGridViewRow In DataGridView4.SelectedRows
                id = row.Cells(0).Value
                txtIdNumber.Text = row.Cells(1).Value
                txtTeacherName.Text = row.Cells(2).Value
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnTeacherEdit_Click(sender As Object, e As EventArgs) Handles btnTeacherEdit.Click
        If id = "" Then
            Crit("Please select an item to update!")
            Exit Sub
        End If

        If txtIdNumber.Text = "" Or txtTeacherName.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_teacher WHERE idnumber = '" & txtIdNumber.Text & "' and id <> '" & id & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("ID number already registered")
            Exit Sub
        End If

        RunCommand("Update tb_teacher set idnumber = @idnumber, teachername = @teacher where id = '" & id & "'")
        ComParameters()
        com.ExecuteNonQuery()
        OkOnly("Success")
        Clear()
        load_data()

    End Sub

    Private Sub btnTeacherDelete_Click(sender As Object, e As EventArgs) Handles btnTeacherDelete.Click
        If id = "" Then
            Crit("Please select a profile to delete!")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_teacher where id = '" & id & "'")
            com.ExecuteNonQuery()
            OkOnly("Success")
            Clear()
            load_data()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            gbTeacher.Show()
            gbSubject.Hide()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            gbTeacher.Hide()
            gbSubject.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If txtSubjCode.Text = "" Or txtSubjName.Text = "" Or cbTeacher.Text = "" Or txtSched.Text = "" Or cbGYlevel.Text = "" Or cbSection.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_subject where subjectcode = '" & txtSubjCode.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("Subject Code already registered")
            txtSubjCode.Clear()
            Exit Sub
        End If


        Dim inputTimeText As String = txtSched.Text

        ' Attempt to parse the entered time
        Dim isValidTime As Boolean = TimeSpan.TryParse(inputTimeText, Nothing)

        If Not isValidTime Then
            Crit("Invalid time format. Please enter a valid time (HH:MM:SS).")
            txtSched.Focus()
            txtSched.Clear()
            Exit Sub
        End If

        RunCommand("Insert into tb_subject (subjectcode,subjectname,teacherid,sched,gradeyearnumber,sectionnumber,password) VALUES (@subjectcode,@subjectname,@teacherid,@sched,@gradeyearnumber,@sectionnumber,@password)")
        com.Parameters.AddWithValue("@subjectcode", txtSubjCode.Text)
        com.Parameters.AddWithValue("@subjectname", txtSubjName.Text)
        com.Parameters.AddWithValue("@teacherid", cbTeacher.SelectedValue)
        com.Parameters.AddWithValue("@sched", txtSched.Text)
        com.Parameters.AddWithValue("@gradeyearnumber", cbGYlevel.SelectedValue)
        com.Parameters.AddWithValue("@sectionnumber", cbSection.SelectedValue)
        com.Parameters.AddWithValue("@password", txtPassword.Text)
        com.ExecuteNonQuery()
        OkOnly("Success")
        Clear()
        load_data()
    End Sub

    Private Sub cbGYlevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGYlevel.SelectedIndexChanged
        Try
            RunQuery("Select * from tb_section WHERE gradeyearnumber = '" & cbGYlevel.SelectedValue & "'")
            cbSection.DataSource = ds.Tables("querytable")
            cbSection.DisplayMember = "sectionname"
            cbSection.ValueMember = "sectionnumber"
            cbSection.SelectedIndex = -1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If subjid = "" Then
            Crit("Please select a subject to update!")
            Exit Sub
        End If

        If txtSubjCode.Text = "" Or txtSubjName.Text = "" Or cbTeacher.Text = "" Or txtSched.Text = "" Or cbGYlevel.Text = "" Or cbSection.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_subject where subjectcode = '" & txtSubjCode.Text & "' and id <> '" & subjid & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("Subject code already exist!")
            Exit Sub
        End If

        Dim inputTimeText As String = txtSched.Text

        ' Attempt to parse the entered time
        Dim isValidTime As Boolean = TimeSpan.TryParse(inputTimeText, Nothing)

        If Not isValidTime Then
            Crit("Invalid time format. Please enter a valid time (HH:MM:SS).")
            txtSched.Focus()
            txtSched.Clear()
            Exit Sub
        End If

        RunCommand("Update tb_subject SET subjectcode=@subjectcode,subjectname=@subjectname,teacherid=@teacherid,sched=@sched,gradeyearnumber=@gradeyearnumber,sectionnumber=@sectionnumber,password=@password WHERE id = '" & subjid & "'")
        com.Parameters.AddWithValue("@subjectcode", txtSubjCode.Text)
        com.Parameters.AddWithValue("@subjectname", txtSubjName.Text)
        com.Parameters.AddWithValue("@teacherid", cbTeacher.SelectedValue)
        com.Parameters.AddWithValue("@sched", txtSched.Text)
        com.Parameters.AddWithValue("@gradeyearnumber", cbGYlevel.SelectedValue)
        com.Parameters.AddWithValue("@sectionnumber", cbSection.SelectedValue)
        com.Parameters.AddWithValue("@password", txtPassword.Text)
        com.ExecuteNonQuery()
        OkOnly("Success")
        Clear()
        load_data()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                subjid = row.Cells(0).Value
                txtSubjCode.Text = row.Cells(1).Value
                txtSubjName.Text = row.Cells(2).Value
                cbTeacher.Text = row.Cells(3).Value
                txtSched.Text = row.Cells(4).Value
                cbGYlevel.Text = row.Cells(5).Value
                cbSection.Text = row.Cells(6).Value
                txtPassword.Text = row.Cells(7).Value
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If subjid = "" Then
            Crit("Select a subject to delete")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "TFVC-LMS") = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_subject WHERE id = '" & subjid & "'")
            com.ExecuteNonQuery()
            OkOnly("Success")
            Clear()
            load_data()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub

    Private Sub btnClearSched_Click(sender As Object, e As EventArgs) Handles btnClearSched.Click
        Clear()
    End Sub

    Private Sub txtSubjCode_TextChanged(sender As Object, e As EventArgs) Handles txtSubjCode.TextChanged

    End Sub

    Private Sub txtSubjCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubjCode.KeyPress
        e.Handled = Not (NoSpace.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtSubjName_TextChanged(sender As Object, e As EventArgs) Handles txtSubjName.TextChanged

    End Sub

    Private Sub txtSubjName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubjName.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        e.Handled = Not (NoSpace.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtIdNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIdNumber.TextChanged

    End Sub

    Private Sub txtIdNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdNumber.KeyPress
        e.Handled = Not (NumbersOnly.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtTeacherName_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherName.TextChanged

    End Sub

    Private Sub txtTeacherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeacherName.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub
End Class