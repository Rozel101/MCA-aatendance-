Imports MySql.Data.MySqlClient
Public Class Form_BarcodePrinting

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            PanelSingle.Show()
            PanelRange.Hide()
            btnAddSingle.Show()
            btnAddRange.Hide()
        Else
            PanelRange.Show()
            PanelSingle.Hide()
            btnAddRange.Show()
            btnAddSingle.Hide()
        End If
    End Sub

    Private Sub BtnAddSingle_Click(sender As Object, e As EventArgs) Handles btnAddSingle.Click
        If txtSingle.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        For Each item As DataGridViewRow In DataGridView1.Rows
            If item.Cells(0).Value = txtSingle.Text Then
                Crit("ID Number already added!")
                txtSingle.Clear()
                Exit Sub
            End If
        Next

        RunQuery("Select * from tb_students WHERE idnumber='" & txtSingle.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            DataGridView1.Rows.Add(txtSingle.Text)
            txtSingle.Clear()
        Else
            Crit("ID Number does not exist!")
            txtSingle.Clear()
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then

            For Each i As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(i)
            Next


        Else
            Crit("Please select an ID Number to remove!")
            Exit Sub
        End If
        DataGridView1.ClearSelection()

    End Sub
    Private Sub BtnAddRange_Click(sender As Object, e As EventArgs) Handles btnAddRange.Click
        If txtFrom.Text = "" Or txtTo.Text = "" Then
            Crit("Fields are required!")
            Exit Sub
        End If

        If Val(txtFrom.Text) > Val(txtTo.Text) Then
            Crit("Please enter a proper range!")
            txtFrom.Clear()
            txtTo.Clear()
            Exit Sub
        End If

        RunQuery("Select idnumber from tb_students WHERE idnumber BETWEEN '" & txtFrom.Text & "' AND '" & txtTo.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            For Each row As DataRow In ds.Tables("querytable").Rows
                DataGridView1.Rows.Add(row(0).ToString)
            Next
            txtFrom.Clear()
            txtTo.Clear()
        Else
            Crit("ID Number does not exist!")
            Exit Sub
        End If
        DataGridView1.ClearSelection()

    End Sub

    Private Sub BtnPrintBarcode_Click(sender As Object, e As EventArgs) Handles btnPrintBarcode.Click
        If DataGridView1.Rows.Count = 0 Then
            Crit("Please enter an ID number on the list!")
            Exit Sub
        End If
        dt = New DataTable("DT_BarcodePrinting")
        dt.Clear()

        For Each item As DataGridViewRow In DataGridView1.Rows
            Dim idnumber As String = item.Cells(0).Value
            adp = New MySqlDataAdapter("Select idnumber,barcode from tb_students WHERE idnumber = '" & idnumber & "'", con)
            ds = New DataSet
            adp.Fill(dt)
        Next

        Dim crystal As New CR_BarcodePrinting
        crystal.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crystal
    End Sub
End Class