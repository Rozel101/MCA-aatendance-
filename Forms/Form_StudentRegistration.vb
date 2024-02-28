Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_StudentRegistration
    Dim id As String = ""
    Dim idnumber As String = ""
    Public Sub Load_data()
        RunQuery("Select t1.id,t1.idnumber,t1.lastname,t1.firstname,t1.birthday,t2.gradeyearname,t3.sectionname,t1.contactperson,t1.contactnumber,t1.address from tb_students as t1
                  JOIN tb_gradeyearlvl as t2 on t2.gradeyearnumber = t1.gradeyearnumber 
                  JOIN tb_section as t3 on t3.sectionnumber = t1.sectionnumber")
        DataGridView1.DataSource = ds.Tables("querytable")

        RunQuery("Select * from tb_gradeyearlvl")
        cbGradeYearLevel.DataSource = ds.Tables("querytable")
        cbGradeYearLevel.ValueMember = "gradeyearnumber"
        cbGradeYearLevel.DisplayMember = "gradeyearname"

    End Sub
    Public Sub ClearFields()
        Load_data()
        txtIdNumber.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        dtpBirthday.Value = Now
        cbGradeYearLevel.SelectedIndex = -1
        cbSection.SelectedIndex = -1
        txtContactPerson.Clear()
        txtContactNumber.Clear()
        txtAddress.Clear()
        PictureBox1.Image = Nothing
        DataGridView1.ClearSelection()
        id = ""
        idnumber = ""
    End Sub
    Public Sub SetParameters()

        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        com.Parameters.AddWithValue("@idnumber", txtIdNumber.Text)
        com.Parameters.AddWithValue("@lastname", txtLastName.Text)
        com.Parameters.AddWithValue("@firstname", txtFirstName.Text)
        com.Parameters.AddWithValue("@birthday", Format(dtpBirthday.Value, "yyyy-MM-dd"))
        com.Parameters.AddWithValue("@gradeyearnumber", cbGradeYearLevel.Text)
        com.Parameters.AddWithValue("@sectionnumber", cbSection.Text)
        com.Parameters.AddWithValue("@contactperson", txtContactPerson.Text)
        com.Parameters.AddWithValue("@contactnumber", txtContactNumber.Text)
        com.Parameters.AddWithValue("@address", txtAddress.Text)
        com.Parameters.AddWithValue("@barcode", arrImage)
    End Sub
    Public Sub CheckData()
        If txtIdNumber.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or cbGradeYearLevel.Text = "" Or cbSection.Text = "" Or txtContactPerson.Text = "" Or txtContactNumber.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Fields are required!", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Private Sub Form_StudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        ClearFields()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        CheckData()

        RunQuery("Select * from tb_students WHERE idnumber = '" & txtIdNumber.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Crit("ID Number already registered!")
            txtIdNumber.Clear()
            Exit Sub
        End If


        RunCommand("Insert into tb_students (idnumber,lastname,firstname,birthday,gradeyearnumber,sectionnumber,contactperson,contactnumber,address,barcode)
                    SELECT @idnumber,@lastname,@firstname,@birthday,t2.gradeyearnumber,t3.sectionnumber,@contactperson,@contactnumber,@address,@barcode
                    FROM tb_gradeyearlvl as t2
                    JOIN tb_section as t3 on t2.gradeyearname = @gradeyearnumber and t3.sectionname = @sectionnumber
                    ")
        SetParameters()
        com.ExecuteNonQuery()
        OkOnly("Success!")
        ClearFields()


    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If id = "" Then
            Crit("Please select a student to edit!")
            Exit Sub
        End If

        CheckData()

        If idnumber <> txtIdNumber.Text Then
            RunQuery("Select * from tb_students WHERE idnumber = '" & txtIdNumber.Text & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Crit("ID Number already registered!")
                Exit Sub
            End If
        End If

        RunCommand("Update tb_students as t1
                    JOIN tb_gradeyearlvl as t2 on t2.gradeyearname = @gradeyearnumber
                    JOIN tb_section as t3 on t3.sectionname = @sectionnumber
                    SET
                    t1.idnumber=@idnumber,
                    t1.lastname=@lastname,
                    t1.firstname=@firstname,
                    t1.birthday=@birthday,
                    t1.gradeyearnumber=t2.gradeyearnumber,
                    t1.sectionnumber=t3.sectionnumber,
                    t1.contactperson=@contactperson,
                    t1.contactnumber=@contactnumber,
                    t1.address=@address,
                    t1.barcode=@barcode
                    WHERE t1.id='" & id & "'")
        SetParameters()
        com.ExecuteNonQuery()
        OkOnly("Updated Successfully!")
        ClearFields()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If id = "" Then
            Crit("Please select a profile to delete!")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this profile?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RunCommand("Delete from tb_students WHERE id = '" & id & "'")
            com.ExecuteNonQuery()
            OkOnly("Deleted Successfully!")
            ClearFields()
        End If
        ResetAutoIncrement()
    End Sub

    Private Sub CbGradeYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGradeYearLevel.SelectedIndexChanged
        RunQuery("Select t1.sectionname from tb_section as t1
                  join tb_gradeyearlvl as t2 on t2.gradeyearnumber = t1.gradeyearnumber
                  WHERE t2.gradeyearname = '" & cbGradeYearLevel.Text & "'")
        cbSection.DataSource = ds.Tables("querytable")
        cbSection.ValueMember = "sectionname"
        cbSection.DisplayMember = "sectionname"
        cbSection.SelectedIndex = -1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            If txtIdNumber.Text = "" Then
                PictureBox1.Image = Nothing
            Else
                Dim barcodeimage As Image
                barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.UPCSupplemental5Digit, txtIdNumber.Text))
                PictureBox1.Image = barcodeimage
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dgvselected As DataGridViewRow
            dgvselected = DataGridView1.Rows(e.RowIndex)
            id = dgvselected.Cells(0).Value
            idnumber = dgvselected.Cells(1).Value
            txtIdNumber.Text = dgvselected.Cells(1).Value
            txtLastName.Text = dgvselected.Cells(2).Value
            txtFirstName.Text = dgvselected.Cells(3).Value
            dtpBirthday.Value = dgvselected.Cells(4).Value
            cbGradeYearLevel.Text = dgvselected.Cells(5).Value
            cbSection.Text = dgvselected.Cells(6).Value
            txtContactPerson.Text = dgvselected.Cells(7).Value
            txtContactNumber.Text = dgvselected.Cells(8).Value
            txtAddress.Text = dgvselected.Cells(9).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtIdNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIdNumber.TextChanged

    End Sub

    Private Sub txtIdNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdNumber.KeyPress
        e.Handled = Not (NumbersOnly.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        e.Handled = Not (Names.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        e.Handled = Not (Names.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtContactPerson_TextChanged(sender As Object, e As EventArgs) Handles txtContactPerson.TextChanged

    End Sub

    Private Sub txtContactPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactPerson.KeyPress
        e.Handled = Not (Names.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged

    End Sub

    Private Sub txtContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        e.Handled = Not (NumbersOnly.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
            OrElse e.KeyChar = Convert.ToChar(Keys.Back))

    End Sub
End Class