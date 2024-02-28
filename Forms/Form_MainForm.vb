Public Class Form_MainForm


    Private Sub Form_MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Openconnection()
        Dim customrenderer As New customrenderer()
        MenuStrip1.Renderer = customrenderer
        PanelRemove()
    End Sub

    Private Sub AdminControlsToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles AdminControlsToolStripMenuItem.MouseEnter
        AdminControlsToolStripMenuItem.BackColor = Color.LightBlue
    End Sub

    Private Sub AdminControlsToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles AdminControlsToolStripMenuItem.MouseLeave
        AdminControlsToolStripMenuItem.BackColor = Color.Transparent
    End Sub
    Private Sub AttendanceToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.MouseEnter
        AttendanceToolStripMenuItem.BackColor = Color.LightBlue
    End Sub

    Private Sub AttendanceToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.MouseLeave
        AttendanceToolStripMenuItem.BackColor = Color.Transparent
    End Sub
    Private Sub BarcodePrintingToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles BarcodePrintingToolStripMenuItem.MouseEnter
        BarcodePrintingToolStripMenuItem.BackColor = Color.LightBlue
    End Sub

    Private Sub BarcodePrintingToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles BarcodePrintingToolStripMenuItem.MouseLeave
        BarcodePrintingToolStripMenuItem.BackColor = Color.Transparent
    End Sub
    Private Sub ReportsToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.MouseLeave
        ReportsToolStripMenuItem.BackColor = Color.Transparent
    End Sub
    Private Sub ReportsToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.MouseEnter
        ReportsToolStripMenuItem.BackColor = Color.LightBlue
    End Sub
    Private Sub LogoutToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.MouseLeave
        LogoutToolStripMenuItem.BackColor = Color.Transparent
    End Sub
    Private Sub LogoutToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.MouseEnter
        LogoutToolStripMenuItem.BackColor = Color.LightBlue
    End Sub
    Private Sub Form_MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PanelRemove()
        Form_Login.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "MCA-AMS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub UserMaintenanceToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.MouseLeave
        UserMaintenanceToolStripMenuItem.BackColor = Color.Transparent
    End Sub
    Private Sub UserMaintenanceToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.MouseEnter
        UserMaintenanceToolStripMenuItem.BackColor = Color.LightBlue
    End Sub
    Private Sub UserMaintenanceStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.Click
        PanelRemove()

        With Form_UserManagement
            .TopLevel = False
            Panel3.Controls.Add(Form_UserManagement)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub StudentMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentMaintenanceToolStripMenuItem.Click
        PanelRemove()

        With Form_StudentMaintenance
            .TopLevel = False
            Panel3.Controls.Add(Form_StudentMaintenance)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub StudentRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        PanelRemove()

        With Form_StudentRegistration
            .TopLevel = False
            Panel3.Controls.Add(Form_StudentRegistration)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub AdminControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminControlsToolStripMenuItem.Click
        AdminControlsToolStripMenuItem.BackColor = Color.Pink
    End Sub

    Private Sub BarcodePrintingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarcodePrintingToolStripMenuItem.Click
        PanelRemove()
        With Form_BarcodePrinting
            .TopLevel = False
            Panel3.Controls.Add(Form_BarcodePrinting)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        PanelRemove()
        With Form_ViewingAttendance
            .TopLevel = False
            Panel3.Controls.Add(Form_ViewingAttendance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Sampleclass1 As New SampleClass1
        Sampleclass1.Remarks()
    End Sub

    Private Sub TeacherAndSubjectMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherAndSubjectMaintenanceToolStripMenuItem.Click
        PanelRemove()
        With Form_Maintenance
            .TopLevel = False
            Panel3.Controls.Add(Form_Maintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub DailyAttendanceGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyAttendanceGeneralToolStripMenuItem.Click
        PanelRemove()
        With Form_PrintGeneralAttendance
            .TopLevel = False
            Panel3.Controls.Add(Form_PrintGeneralAttendance)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub DailyAttendanceSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyAttendanceSubjectToolStripMenuItem.Click
        PanelRemove()
        With Form_PrintSubjectAttendance
            .TopLevel = False
            Panel3.Controls.Add(Form_PrintSubjectAttendance)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class