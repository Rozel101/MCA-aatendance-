<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Maintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbTeacher = New System.Windows.Forms.GroupBox()
        Me.txtTeacherName = New System.Windows.Forms.TextBox()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.btnClearSched = New System.Windows.Forms.Button()
        Me.btnTeacherDelete = New System.Windows.Forms.Button()
        Me.btnTeacherEdit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTeacherAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gbSubject = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSection = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbGYlevel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSched = New System.Windows.Forms.MaskedTextBox()
        Me.cbTeacher = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubjName = New System.Windows.Forms.TextBox()
        Me.txtSubjCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbTeacher.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSubject.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTeacher
        '
        Me.gbTeacher.Controls.Add(Me.txtTeacherName)
        Me.gbTeacher.Controls.Add(Me.txtIdNumber)
        Me.gbTeacher.Controls.Add(Me.btnClearSched)
        Me.gbTeacher.Controls.Add(Me.btnTeacherDelete)
        Me.gbTeacher.Controls.Add(Me.btnTeacherEdit)
        Me.gbTeacher.Controls.Add(Me.Label7)
        Me.gbTeacher.Controls.Add(Me.btnTeacherAdd)
        Me.gbTeacher.Controls.Add(Me.Label8)
        Me.gbTeacher.Controls.Add(Me.DataGridView4)
        Me.gbTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTeacher.Location = New System.Drawing.Point(76, 55)
        Me.gbTeacher.Name = "gbTeacher"
        Me.gbTeacher.Size = New System.Drawing.Size(830, 394)
        Me.gbTeacher.TabIndex = 15
        Me.gbTeacher.TabStop = False
        Me.gbTeacher.Text = "Teacher"
        Me.gbTeacher.Visible = False
        '
        'txtTeacherName
        '
        Me.txtTeacherName.Location = New System.Drawing.Point(332, 83)
        Me.txtTeacherName.Name = "txtTeacherName"
        Me.txtTeacherName.Size = New System.Drawing.Size(259, 30)
        Me.txtTeacherName.TabIndex = 14
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(332, 39)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(259, 30)
        Me.txtIdNumber.TabIndex = 13
        '
        'btnClearSched
        '
        Me.btnClearSched.Location = New System.Drawing.Point(508, 152)
        Me.btnClearSched.Name = "btnClearSched"
        Me.btnClearSched.Size = New System.Drawing.Size(122, 37)
        Me.btnClearSched.TabIndex = 12
        Me.btnClearSched.Text = "Clear"
        Me.btnClearSched.UseVisualStyleBackColor = True
        '
        'btnTeacherDelete
        '
        Me.btnTeacherDelete.Location = New System.Drawing.Point(380, 152)
        Me.btnTeacherDelete.Name = "btnTeacherDelete"
        Me.btnTeacherDelete.Size = New System.Drawing.Size(122, 37)
        Me.btnTeacherDelete.TabIndex = 11
        Me.btnTeacherDelete.Text = "Delete"
        Me.btnTeacherDelete.UseVisualStyleBackColor = True
        '
        'btnTeacherEdit
        '
        Me.btnTeacherEdit.Location = New System.Drawing.Point(252, 152)
        Me.btnTeacherEdit.Name = "btnTeacherEdit"
        Me.btnTeacherEdit.Size = New System.Drawing.Size(122, 37)
        Me.btnTeacherEdit.TabIndex = 10
        Me.btnTeacherEdit.Text = "Edit"
        Me.btnTeacherEdit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Teacher's Name"
        '
        'btnTeacherAdd
        '
        Me.btnTeacherAdd.Location = New System.Drawing.Point(124, 152)
        Me.btnTeacherAdd.Name = "btnTeacherAdd"
        Me.btnTeacherAdd.Size = New System.Drawing.Size(122, 37)
        Me.btnTeacherAdd.TabIndex = 9
        Me.btnTeacherAdd.Text = "Add"
        Me.btnTeacherAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ID Number"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column7, Me.Column8})
        Me.DataGridView4.Location = New System.Drawing.Point(1, 213)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(829, 181)
        Me.DataGridView4.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "id"
        Me.Column3.HeaderText = "ID"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "idnumber"
        Me.Column7.HeaderText = "ID Number"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "teachername"
        Me.Column8.HeaderText = "Teacher's Name"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Teacher", "Subject"})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(259, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'gbSubject
        '
        Me.gbSubject.Controls.Add(Me.txtPassword)
        Me.gbSubject.Controls.Add(Me.Label9)
        Me.gbSubject.Controls.Add(Me.cbSection)
        Me.gbSubject.Controls.Add(Me.Label6)
        Me.gbSubject.Controls.Add(Me.cbGYlevel)
        Me.gbSubject.Controls.Add(Me.Label5)
        Me.gbSubject.Controls.Add(Me.txtSched)
        Me.gbSubject.Controls.Add(Me.cbTeacher)
        Me.gbSubject.Controls.Add(Me.Label4)
        Me.gbSubject.Controls.Add(Me.Label3)
        Me.gbSubject.Controls.Add(Me.txtSubjName)
        Me.gbSubject.Controls.Add(Me.txtSubjCode)
        Me.gbSubject.Controls.Add(Me.Button1)
        Me.gbSubject.Controls.Add(Me.Button2)
        Me.gbSubject.Controls.Add(Me.Button3)
        Me.gbSubject.Controls.Add(Me.Label1)
        Me.gbSubject.Controls.Add(Me.Button4)
        Me.gbSubject.Controls.Add(Me.Label2)
        Me.gbSubject.Controls.Add(Me.DataGridView1)
        Me.gbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubject.Location = New System.Drawing.Point(76, 55)
        Me.gbSubject.Name = "gbSubject"
        Me.gbSubject.Size = New System.Drawing.Size(878, 412)
        Me.gbSubject.TabIndex = 17
        Me.gbSubject.TabStop = False
        Me.gbSubject.Text = "Subject"
        Me.gbSubject.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(660, 158)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(197, 30)
        Me.txtPassword.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(467, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Password"
        '
        'cbSection
        '
        Me.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.Location = New System.Drawing.Point(664, 116)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(193, 33)
        Me.cbSection.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Section"
        '
        'cbGYlevel
        '
        Me.cbGYlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGYlevel.FormattingEnabled = True
        Me.cbGYlevel.Location = New System.Drawing.Point(664, 77)
        Me.cbGYlevel.Name = "cbGYlevel"
        Me.cbGYlevel.Size = New System.Drawing.Size(193, 33)
        Me.cbGYlevel.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Grade / Year Level"
        '
        'txtSched
        '
        Me.txtSched.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSched.Location = New System.Drawing.Point(660, 43)
        Me.txtSched.Mask = "00:00:00"
        Me.txtSched.Name = "txtSched"
        Me.txtSched.Size = New System.Drawing.Size(197, 28)
        Me.txtSched.TabIndex = 19
        '
        'cbTeacher
        '
        Me.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTeacher.FormattingEnabled = True
        Me.cbTeacher.Location = New System.Drawing.Point(214, 158)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.Size = New System.Drawing.Size(215, 33)
        Me.cbTeacher.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(467, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Teacher"
        '
        'txtSubjName
        '
        Me.txtSubjName.Location = New System.Drawing.Point(214, 97)
        Me.txtSubjName.Name = "txtSubjName"
        Me.txtSubjName.Size = New System.Drawing.Size(215, 30)
        Me.txtSubjName.TabIndex = 14
        '
        'txtSubjCode
        '
        Me.txtSubjCode.Location = New System.Drawing.Point(214, 41)
        Me.txtSubjCode.Name = "txtSubjCode"
        Me.txtSubjCode.Size = New System.Drawing.Size(215, 30)
        Me.txtSubjCode.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 37)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(272, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subject Name"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(144, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 37)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subject Code"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 269)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(874, 137)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "subjectcode"
        Me.Column2.HeaderText = "Subject Code"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "subjectname"
        Me.Column4.HeaderText = "Subject Name"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "teacher"
        Me.Column5.HeaderText = "Teacher"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "sched"
        Me.Column6.HeaderText = "Schedule"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "grade"
        Me.Column9.HeaderText = "Grade / Year Level"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "section"
        Me.Column10.HeaderText = "Section"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "password"
        Me.Column11.HeaderText = "Password"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Form_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(992, 479)
        Me.Controls.Add(Me.gbSubject)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.gbTeacher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Maintenance"
        Me.Text = "Maintenance"
        Me.gbTeacher.ResumeLayout(False)
        Me.gbTeacher.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSubject.ResumeLayout(False)
        Me.gbSubject.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbTeacher As GroupBox
    Friend WithEvents btnClearSched As Button
    Friend WithEvents btnTeacherDelete As Button
    Friend WithEvents btnTeacherEdit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTeacherAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents txtTeacherName As TextBox
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents gbSubject As GroupBox
    Friend WithEvents cbTeacher As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubjName As TextBox
    Friend WithEvents txtSubjCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbSection As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbGYlevel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSched As MaskedTextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
