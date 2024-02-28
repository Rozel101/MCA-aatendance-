Public Class Form_StudentMaintenance
    Dim gradeyearnumber As String = ""
    Dim gradeyearname As String = ""
    Dim sectionnumber As String = ""
    Dim sectionname As String = ""
    Dim schednumber As String = ""
    Dim schedgylvl As String = ""
    Dim schedgysec As String = ""
    Public Sub ClearLevel()
        txtLevel.Clear()
        gradeyearnumber = ""
        gradeyearname = ""
    End Sub
    Public Sub ClearSection()
        cbLevel.SelectedIndex = -1
        txtSection.Clear()
        sectionnumber = ""
        sectionname = ""
    End Sub
    Public Sub ClearSched()
        cbSchedGYLVL.SelectedIndex = -1
        cbSchedSection.SelectedIndex = -1
        txtSched.Clear()
        schednumber = ""
        schedgylvl = ""
        schedgysec = ""
    End Sub
    Public Sub Load_data()
        RunQuery("Select * from tb_gradeyearlvl")
        DataGridView1.DataSource = ds.Tables("querytable")
        cbLevel.DataSource = ds.Tables("querytable")
        cbLevel.DisplayMember = "gradeyearname"
        cbLevel.ValueMember = "gradeyearnumber"
        cbLevel.SelectedIndex = -1

        cbSchedGYLVL.DataSource = ds.Tables("querytable")
        cbSchedGYLVL.DisplayMember = "gradeyearname"
        cbSchedGYLVL.ValueMember = "gradeyearnumber"
        cbSchedGYLVL.SelectedIndex = -1

    End Sub
    Public Sub Load_data2()
        RunQuery("Select t1.sectionnumber,t2.gradeyearname,t1.sectionname from tb_section as t1
                  JOIN tb_gradeyearlvl as t2 on t2.gradeyearnumber = t1.gradeyearnumber")
        DataGridView2.DataSource = ds.Tables("querytable")
    End Sub
    Public Sub Load_data3()
        RunQuery("Select t1.schednumber, t2.gradeyearname, t3.sectionname,t1.sched from tb_schedule as t1
                  JOIN tb_gradeyearlvl as t2 on t1.gradeyearnumber = t2.gradeyearnumber
                  JOIN tb_section as t3 on t1.sectionnumber = t3.sectionnumber")
        DataGridView4.DataSource = ds.Tables("querytable")
    End Sub
    Private Sub Form_StudentMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        Load_data()
        Load_data2()
        Load_data3()
    End Sub
    Private Sub BtnAddLevel_Click(sender As Object, e As EventArgs) Handles btnAddLevel.Click
        If txtLevel.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_gradeyearlvl WHERE gradeyearname='" & txtLevel.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("Grade or Year level already registered!")
            txtLevel.Clear()
            Exit Sub
        End If

        RunCommand("Insert into tb_gradeyearlvl (gradeyearname) VALUES
                    ('" & txtLevel.Text & "')")
        If com.ExecuteNonQuery = 1 Then
            OkOnly("Grade/Year level added successfully")
            ClearLevel()
            Load_data()
            Load_data2()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dgv1selected As DataGridViewRow
            dgv1selected = DataGridView1.Rows(e.RowIndex)
            gradeyearnumber = dgv1selected.Cells(0).Value
            txtLevel.Text = dgv1selected.Cells(1).Value
            gradeyearname = dgv1selected.Cells(1).Value
            MsgBox(gradeyearname)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            Dim dgv2selected As DataGridViewRow
            dgv2selected = DataGridView2.Rows(e.RowIndex)
            sectionnumber = dgv2selected.Cells(0).Value
            cbLevel.Text = dgv2selected.Cells(1).Value
            sectionname = dgv2selected.Cells(2).Value
            txtSection.Text = dgv2selected.Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEditLevel_Click(sender As Object, e As EventArgs) Handles btnEditLevel.Click
        If gradeyearnumber = "" Then
            Crit("Please select a grade/year level to update!")
            Exit Sub
        End If

        If txtLevel.Text <> gradeyearname Then
            RunQuery("Select * from tb_gradeyearlvl WHERE 
                      gradeyearname = '" & txtLevel.Text & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Crit("Grade or Year level already registered!")
                txtLevel.Clear()
                Exit Sub
            End If
        End If

        RunCommand("Update tb_gradeyearlvl SET
                    gradeyearname = '" & txtLevel.Text & "'
                    WHERE gradeyearnumber = '" & gradeyearnumber & "'")
        com.ExecuteNonQuery()
        OkOnly("Updated successfully!")


        ClearLevel()
        Load_data()
        Load_data2()
    End Sub

    Private Sub BtnDeleteLevel_Click(sender As Object, e As EventArgs) Handles btnDeleteLevel.Click
        If gradeyearnumber = "" Then
            Crit("Please select a level to delete!")
            Exit Sub
        End If

        RunQuery("Select gradeyearname from tb_section 
                  JOIN tb_gradeyearlvl on tb_gradeyearlvl.gradeyearnumber = tb_section.gradeyearnumber
                  WHERE tb_gradeyearlvl.gradeyearname = '" & gradeyearname & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("Grade or Year level is in use.")
            Exit Sub
        End If


        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_gradeyearlvl WHERE gradeyearnumber = '" & gradeyearnumber & "'")
            If com.ExecuteNonQuery = 1 Then
                OkOnly("Deleted successfully!")
                Load_data()
                Load_data2()
                ClearLevel()
            End If
        End If

    End Sub
    Private Sub BtnAddSection_Click(sender As Object, e As EventArgs) Handles btnAddSection.Click
        If cbLevel.Text = "" Or txtSection.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        RunQuery("Select * from tb_section WHERE
                 sectionname = '" & txtSection.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("Section name already registered!")
            txtSection.Clear()
            Exit Sub
        End If

        RunCommand("Insert into tb_section (gradeyearnumber,sectionname) 
                    SELECT t2.gradeyearnumber,'" & txtSection.Text & "'
                    FROM tb_gradeyearlvl as t2
                    WHERE t2.gradeyearname = '" & cbLevel.Text & "'
                    ")
        com.ExecuteNonQuery()
        OkOnly("Section added successfully!")
        ClearSection()
        Load_data()
        Load_data2()
    End Sub

    Private Sub BtnEditSection_Click(sender As Object, e As EventArgs) Handles btnEditSection.Click
        If sectionnumber = "" Then
            Crit("Please select a section to update!")
            Exit Sub
        End If

        If txtSection.Text <> sectionname Then
            RunQuery("Select * from tb_section 
                     where sectionname='" & txtSection.Text & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Crit("Section name already registered!")
                txtSection.Clear()
                Exit Sub
            End If
        End If

        RunCommand("Update tb_section as t1
                    join tb_gradeyearlvl as t2 on t2.gradeyearname = '" & cbLevel.Text & "'
                    SET
                    t1.gradeyearnumber = t2.gradeyearnumber,
                    t1.sectionname = '" & txtSection.Text & "'
                    WHERE t1.sectionnumber = '" & sectionnumber & "'")
        com.ExecuteNonQuery()
        OkOnly("Updated successfully!")
        ClearSection()
        Load_data()
        Load_data2()
    End Sub

    Private Sub BtnDeleteSection_Click(sender As Object, e As EventArgs) Handles btnDeleteSection.Click
        If sectionnumber = "" Then
            Crit("Please select a section to delete!")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_section where sectionnumber = '" & sectionnumber & "'")
            If com.ExecuteNonQuery = 1 Then
                OkOnly("Deleted successfully")
                ClearSection()
                Load_data()
                Load_data2()
            End If
        End If

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            gbSection.Show()
            gbGradeYearLevel.Hide()
            gbSched.Hide()
            Load_data2()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            gbSched.Hide()
            gbSection.Hide()
            gbGradeYearLevel.Show()
            Load_data()
        Else
            gbSched.Show()
            gbSection.Hide()
            gbGradeYearLevel.Hide()
        End If
    End Sub

    Private Sub CbSchedGYLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSchedGYLVL.SelectedIndexChanged

        RunQuery("Select t1.sectionname from tb_section as t1
                  JOIN tb_gradeyearlvl as t2 on t2.gradeyearnumber = t1.gradeyearnumber
                  WHERE t2.gradeyearname = '" & cbSchedGYLVL.Text & "'
                    ")

        If ds.Tables("querytable").Rows.Count > 0 Then
            cbSchedSection.DataSource = ds.Tables("querytable")
            cbSchedSection.DisplayMember = "sectionname"
            cbSchedSection.ValueMember = "sectionname"
            cbSchedSection.SelectedIndex = -1
        Else
            cbSchedSection.DataSource = Nothing
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnSchedAdd.Click
        If cbSchedGYLVL.Text = "" Or cbSchedSection.Text = "" Or txtSched.Text = "  :  :" Then
            Crit("Fields are required!")
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


        RunQuery("Select t1.sectionnumber from tb_schedule as t1
                  JOIN tb_section as t2 on t2.sectionnumber = t1.sectionnumber
                  WHERE t2.sectionname = '" & cbSchedSection.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("A schedule is already set to the specific Grade and Section!")
            ClearSched()
            Exit Sub
        End If

        RunCommand("Insert into tb_schedule (gradeyearnumber,sectionnumber,sched)
                    SELECT t1.gradeyearnumber, t2.sectionnumber, '" & txtSched.Text & "' from tb_gradeyearlvl as t1
                    JOIN tb_section as t2 on t2.sectionname = '" & cbSchedSection.Text & "' and t1.gradeyearname = '" & cbSchedGYLVL.Text & "'")
        com.ExecuteNonQuery()
        OkOnly("Schedule Added!")
        ClearSched()
        Load_data3()

    End Sub
    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Try
            Dim dg4selected As DataGridViewRow
            dg4selected = DataGridView4.Rows(e.RowIndex)
            schednumber = dg4selected.Cells(0).Value
            schedgylvl = dg4selected.Cells(1).Value
            schedgysec = dg4selected.Cells(2).Value
            cbSchedGYLVL.Text = schedgylvl
            cbSchedSection.Text = schedgysec
            txtSched.Text = dg4selected.Cells(3).Value.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSchedEdit.Click
        If schednumber = "" Then
            Crit("Select a schedule to update!")
            ClearSched()
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


        If cbSchedSection.Text <> schedgysec Then
            RunQuery("Select t1.sectionnumber from tb_schedule as t1
                  JOIN tb_section as t2 on t2.sectionnumber = t1.sectionnumber
                  WHERE t2.sectionname = '" & cbSchedSection.Text & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Crit("A schedule is already set to the specific Grade and Section!")
                cbSchedGYLVL.SelectedIndex = -1
                cbSchedSection.SelectedIndex = -1
                txtSched.Clear()
                Exit Sub
            End If
        End If

        RunCommand("Update tb_schedule as t1
                    JOIN tb_gradeyearlvl as t2 on t2.gradeyearname = '" & cbSchedGYLVL.Text & "'
                    JOIN tb_section as t3 on t3.sectionname = '" & cbSchedSection.Text & "'
                    SET
                    t1.gradeyearnumber = t2.gradeyearnumber,
                    t1.sectionnumber = t3.sectionnumber,
                    t1.sched = '" & txtSched.Text & "'
                    WHERE t1.schednumber = '" & schednumber & "'")
        com.ExecuteNonQuery()
        OkOnly("Schedule updated!")
        ClearSched()
        Load_data3()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClearSched.Click
        ClearSched()
    End Sub

    Private Sub BtnSchedDelete_Click(sender As Object, e As EventArgs) Handles btnSchedDelete.Click
        If schednumber = "" Then
            Crit("Please select a schedule to delete!")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_schedule WHERE schednumber = '" & schednumber & "'")
            com.ExecuteNonQuery()
            OkOnly("Schedule deleted!")
            Load_data3()
            ClearSched()
        End If

    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged

    End Sub

    Private Sub txtSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSection.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtLevel_TextChanged(sender As Object, e As EventArgs) Handles txtLevel.TextChanged

    End Sub

    Private Sub txtLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLevel.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub
End Class