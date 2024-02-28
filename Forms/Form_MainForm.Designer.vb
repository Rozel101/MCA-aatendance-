<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherAndSubjectMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarcodePrintingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyAttendanceGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyAttendanceSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BackgroundImage = Global.MCA_AMS.My.Resources.Resources.MCA_logo
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(116, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1010, 526)
        Me.Panel3.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Brown
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminControlsToolStripMenuItem, Me.BarcodePrintingToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 46)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminControlsToolStripMenuItem
        '
        Me.AdminControlsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AdminControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMaintenanceToolStripMenuItem, Me.StudentMaintenanceToolStripMenuItem, Me.StudentRegistrationToolStripMenuItem, Me.TeacherAndSubjectMaintenanceToolStripMenuItem})
        Me.AdminControlsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdminControlsToolStripMenuItem.Name = "AdminControlsToolStripMenuItem"
        Me.AdminControlsToolStripMenuItem.Size = New System.Drawing.Size(237, 42)
        Me.AdminControlsToolStripMenuItem.Text = "&Admin Controls"
        '
        'UserMaintenanceToolStripMenuItem
        '
        Me.UserMaintenanceToolStripMenuItem.Name = "UserMaintenanceToolStripMenuItem"
        Me.UserMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(547, 42)
        Me.UserMaintenanceToolStripMenuItem.Text = "&User Maintenance"
        '
        'StudentMaintenanceToolStripMenuItem
        '
        Me.StudentMaintenanceToolStripMenuItem.Name = "StudentMaintenanceToolStripMenuItem"
        Me.StudentMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(547, 42)
        Me.StudentMaintenanceToolStripMenuItem.Text = "Student &Maintenance"
        '
        'StudentRegistrationToolStripMenuItem
        '
        Me.StudentRegistrationToolStripMenuItem.Name = "StudentRegistrationToolStripMenuItem"
        Me.StudentRegistrationToolStripMenuItem.Size = New System.Drawing.Size(547, 42)
        Me.StudentRegistrationToolStripMenuItem.Text = "&Student Registration"
        '
        'TeacherAndSubjectMaintenanceToolStripMenuItem
        '
        Me.TeacherAndSubjectMaintenanceToolStripMenuItem.Name = "TeacherAndSubjectMaintenanceToolStripMenuItem"
        Me.TeacherAndSubjectMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(547, 42)
        Me.TeacherAndSubjectMaintenanceToolStripMenuItem.Text = "&Teacher and Subject Maintenance"
        '
        'BarcodePrintingToolStripMenuItem
        '
        Me.BarcodePrintingToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.BarcodePrintingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BarcodePrintingToolStripMenuItem.Name = "BarcodePrintingToolStripMenuItem"
        Me.BarcodePrintingToolStripMenuItem.Size = New System.Drawing.Size(251, 42)
        Me.BarcodePrintingToolStripMenuItem.Text = "&Barcode Printing"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AttendanceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(181, 42)
        Me.AttendanceToolStripMenuItem.Text = "&Attendance"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyAttendanceGeneralToolStripMenuItem, Me.DailyAttendanceSubjectToolStripMenuItem})
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(132, 42)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'DailyAttendanceGeneralToolStripMenuItem
        '
        Me.DailyAttendanceGeneralToolStripMenuItem.Name = "DailyAttendanceGeneralToolStripMenuItem"
        Me.DailyAttendanceGeneralToolStripMenuItem.Size = New System.Drawing.Size(461, 42)
        Me.DailyAttendanceGeneralToolStripMenuItem.Text = "&Daily Attendance - General"
        '
        'DailyAttendanceSubjectToolStripMenuItem
        '
        Me.DailyAttendanceSubjectToolStripMenuItem.Name = "DailyAttendanceSubjectToolStripMenuItem"
        Me.DailyAttendanceSubjectToolStripMenuItem.Size = New System.Drawing.Size(461, 42)
        Me.DailyAttendanceSubjectToolStripMenuItem.Text = "&Daily Attendance - Subject"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(124, 42)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Brown
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(116, 526)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 54)
        Me.Panel1.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Brown
        Me.Panel4.Location = New System.Drawing.Point(1126, 96)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(118, 526)
        Me.Panel4.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Brown
        Me.Panel5.Location = New System.Drawing.Point(0, 622)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1244, 54)
        Me.Panel5.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form_MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1244, 677)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form_MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StudentMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BarcodePrintingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TeacherAndSubjectMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyAttendanceGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyAttendanceSubjectToolStripMenuItem As ToolStripMenuItem
End Class
