<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_StudentMaintenance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbGradeYearLevel = New System.Windows.Forms.GroupBox()
        Me.btnClearLevel = New System.Windows.Forms.Button()
        Me.btnDeleteLevel = New System.Windows.Forms.Button()
        Me.btnEditLevel = New System.Windows.Forms.Button()
        Me.btnAddLevel = New System.Windows.Forms.Button()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbSection = New System.Windows.Forms.GroupBox()
        Me.btnClearSection = New System.Windows.Forms.Button()
        Me.cbLevel = New System.Windows.Forms.ComboBox()
        Me.btnDeleteSection = New System.Windows.Forms.Button()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.btnEditSection = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddSection = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbSched = New System.Windows.Forms.GroupBox()
        Me.txtSched = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSchedSection = New System.Windows.Forms.ComboBox()
        Me.btnClearSched = New System.Windows.Forms.Button()
        Me.cbSchedGYLVL = New System.Windows.Forms.ComboBox()
        Me.btnSchedDelete = New System.Windows.Forms.Button()
        Me.btnSchedEdit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSchedAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbGradeYearLevel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSection.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSched.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbGradeYearLevel
        '
        Me.gbGradeYearLevel.Controls.Add(Me.btnClearLevel)
        Me.gbGradeYearLevel.Controls.Add(Me.btnDeleteLevel)
        Me.gbGradeYearLevel.Controls.Add(Me.btnEditLevel)
        Me.gbGradeYearLevel.Controls.Add(Me.btnAddLevel)
        Me.gbGradeYearLevel.Controls.Add(Me.txtLevel)
        Me.gbGradeYearLevel.Controls.Add(Me.Label1)
        Me.gbGradeYearLevel.Controls.Add(Me.DataGridView1)
        Me.gbGradeYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGradeYearLevel.Location = New System.Drawing.Point(70, 49)
        Me.gbGradeYearLevel.Name = "gbGradeYearLevel"
        Me.gbGradeYearLevel.Size = New System.Drawing.Size(830, 423)
        Me.gbGradeYearLevel.TabIndex = 0
        Me.gbGradeYearLevel.TabStop = False
        Me.gbGradeYearLevel.Text = "Grade / Year Level"
        Me.gbGradeYearLevel.Visible = False
        '
        'btnClearLevel
        '
        Me.btnClearLevel.Location = New System.Drawing.Point(517, 105)
        Me.btnClearLevel.Name = "btnClearLevel"
        Me.btnClearLevel.Size = New System.Drawing.Size(122, 49)
        Me.btnClearLevel.TabIndex = 8
        Me.btnClearLevel.Text = "Clear"
        Me.btnClearLevel.UseVisualStyleBackColor = True
        '
        'btnDeleteLevel
        '
        Me.btnDeleteLevel.Location = New System.Drawing.Point(389, 105)
        Me.btnDeleteLevel.Name = "btnDeleteLevel"
        Me.btnDeleteLevel.Size = New System.Drawing.Size(122, 49)
        Me.btnDeleteLevel.TabIndex = 7
        Me.btnDeleteLevel.Text = "Delete"
        Me.btnDeleteLevel.UseVisualStyleBackColor = True
        '
        'btnEditLevel
        '
        Me.btnEditLevel.Location = New System.Drawing.Point(261, 105)
        Me.btnEditLevel.Name = "btnEditLevel"
        Me.btnEditLevel.Size = New System.Drawing.Size(122, 49)
        Me.btnEditLevel.TabIndex = 6
        Me.btnEditLevel.Text = "Edit"
        Me.btnEditLevel.UseVisualStyleBackColor = True
        '
        'btnAddLevel
        '
        Me.btnAddLevel.Location = New System.Drawing.Point(133, 105)
        Me.btnAddLevel.Name = "btnAddLevel"
        Me.btnAddLevel.Size = New System.Drawing.Size(122, 49)
        Me.btnAddLevel.TabIndex = 5
        Me.btnAddLevel.Text = "Add"
        Me.btnAddLevel.UseVisualStyleBackColor = True
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(296, 44)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(326, 30)
        Me.txtLevel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grade/Year Level"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(829, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "gradeyearnumber"
        Me.Column1.HeaderText = "Grade/Year Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "gradeyearname"
        Me.Column2.HeaderText = "Grade / Year Level"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'gbSection
        '
        Me.gbSection.Controls.Add(Me.btnClearSection)
        Me.gbSection.Controls.Add(Me.cbLevel)
        Me.gbSection.Controls.Add(Me.btnDeleteSection)
        Me.gbSection.Controls.Add(Me.txtSection)
        Me.gbSection.Controls.Add(Me.btnEditSection)
        Me.gbSection.Controls.Add(Me.Label4)
        Me.gbSection.Controls.Add(Me.btnAddSection)
        Me.gbSection.Controls.Add(Me.Label3)
        Me.gbSection.Controls.Add(Me.DataGridView2)
        Me.gbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSection.Location = New System.Drawing.Point(70, 49)
        Me.gbSection.Name = "gbSection"
        Me.gbSection.Size = New System.Drawing.Size(830, 423)
        Me.gbSection.TabIndex = 1
        Me.gbSection.TabStop = False
        Me.gbSection.Text = "Section"
        Me.gbSection.Visible = False
        '
        'btnClearSection
        '
        Me.btnClearSection.Location = New System.Drawing.Point(508, 136)
        Me.btnClearSection.Name = "btnClearSection"
        Me.btnClearSection.Size = New System.Drawing.Size(122, 49)
        Me.btnClearSection.TabIndex = 12
        Me.btnClearSection.Text = "Clear"
        Me.btnClearSection.UseVisualStyleBackColor = True
        '
        'cbLevel
        '
        Me.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Location = New System.Drawing.Point(345, 29)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(326, 33)
        Me.cbLevel.TabIndex = 6
        '
        'btnDeleteSection
        '
        Me.btnDeleteSection.Location = New System.Drawing.Point(380, 136)
        Me.btnDeleteSection.Name = "btnDeleteSection"
        Me.btnDeleteSection.Size = New System.Drawing.Size(122, 49)
        Me.btnDeleteSection.TabIndex = 11
        Me.btnDeleteSection.Text = "Delete"
        Me.btnDeleteSection.UseVisualStyleBackColor = True
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(345, 81)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(326, 30)
        Me.txtSection.TabIndex = 5
        '
        'btnEditSection
        '
        Me.btnEditSection.Location = New System.Drawing.Point(252, 136)
        Me.btnEditSection.Name = "btnEditSection"
        Me.btnEditSection.Size = New System.Drawing.Size(122, 49)
        Me.btnEditSection.TabIndex = 10
        Me.btnEditSection.Text = "Edit"
        Me.btnEditSection.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Section Name"
        '
        'btnAddSection
        '
        Me.btnAddSection.Location = New System.Drawing.Point(124, 136)
        Me.btnAddSection.Name = "btnAddSection"
        Me.btnAddSection.Size = New System.Drawing.Size(122, 49)
        Me.btnAddSection.TabIndex = 9
        Me.btnAddSection.Text = "Add"
        Me.btnAddSection.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grade / Year Level"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView2.Location = New System.Drawing.Point(1, 213)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(829, 210)
        Me.DataGridView2.TabIndex = 1
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "sectionnumber"
        Me.Column4.HeaderText = "Section Number"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "gradeyearname"
        Me.Column5.HeaderText = "Grade / Year Level"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "sectionname"
        Me.Column6.HeaderText = "Section Name"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Section", "Grade", "Schedule"})
        Me.ComboBox1.Location = New System.Drawing.Point(245, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 37)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Category"
        '
        'gbSched
        '
        Me.gbSched.Controls.Add(Me.txtSched)
        Me.gbSched.Controls.Add(Me.Label9)
        Me.gbSched.Controls.Add(Me.cbSchedSection)
        Me.gbSched.Controls.Add(Me.btnClearSched)
        Me.gbSched.Controls.Add(Me.cbSchedGYLVL)
        Me.gbSched.Controls.Add(Me.btnSchedDelete)
        Me.gbSched.Controls.Add(Me.btnSchedEdit)
        Me.gbSched.Controls.Add(Me.Label7)
        Me.gbSched.Controls.Add(Me.btnSchedAdd)
        Me.gbSched.Controls.Add(Me.Label8)
        Me.gbSched.Controls.Add(Me.DataGridView4)
        Me.gbSched.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSched.Location = New System.Drawing.Point(70, 49)
        Me.gbSched.Name = "gbSched"
        Me.gbSched.Size = New System.Drawing.Size(830, 423)
        Me.gbSched.TabIndex = 14
        Me.gbSched.TabStop = False
        Me.gbSched.Text = "Schedule"
        Me.gbSched.Visible = False
        '
        'txtSched
        '
        Me.txtSched.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSched.Location = New System.Drawing.Point(345, 115)
        Me.txtSched.Mask = "00:00:00"
        Me.txtSched.Name = "txtSched"
        Me.txtSched.Size = New System.Drawing.Size(326, 28)
        Me.txtSched.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(107, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(235, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Schedule (HH:MM:SS)"
        '
        'cbSchedSection
        '
        Me.cbSchedSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSchedSection.FormattingEnabled = True
        Me.cbSchedSection.Location = New System.Drawing.Point(345, 68)
        Me.cbSchedSection.Name = "cbSchedSection"
        Me.cbSchedSection.Size = New System.Drawing.Size(326, 33)
        Me.cbSchedSection.TabIndex = 13
        '
        'btnClearSched
        '
        Me.btnClearSched.Location = New System.Drawing.Point(509, 170)
        Me.btnClearSched.Name = "btnClearSched"
        Me.btnClearSched.Size = New System.Drawing.Size(122, 37)
        Me.btnClearSched.TabIndex = 12
        Me.btnClearSched.Text = "Clear"
        Me.btnClearSched.UseVisualStyleBackColor = True
        '
        'cbSchedGYLVL
        '
        Me.cbSchedGYLVL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSchedGYLVL.FormattingEnabled = True
        Me.cbSchedGYLVL.Location = New System.Drawing.Point(345, 29)
        Me.cbSchedGYLVL.Name = "cbSchedGYLVL"
        Me.cbSchedGYLVL.Size = New System.Drawing.Size(326, 33)
        Me.cbSchedGYLVL.TabIndex = 6
        '
        'btnSchedDelete
        '
        Me.btnSchedDelete.Location = New System.Drawing.Point(381, 170)
        Me.btnSchedDelete.Name = "btnSchedDelete"
        Me.btnSchedDelete.Size = New System.Drawing.Size(122, 37)
        Me.btnSchedDelete.TabIndex = 11
        Me.btnSchedDelete.Text = "Delete"
        Me.btnSchedDelete.UseVisualStyleBackColor = True
        '
        'btnSchedEdit
        '
        Me.btnSchedEdit.Location = New System.Drawing.Point(253, 170)
        Me.btnSchedEdit.Name = "btnSchedEdit"
        Me.btnSchedEdit.Size = New System.Drawing.Size(122, 37)
        Me.btnSchedEdit.TabIndex = 10
        Me.btnSchedEdit.Text = "Edit"
        Me.btnSchedEdit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Section Name"
        '
        'btnSchedAdd
        '
        Me.btnSchedAdd.Location = New System.Drawing.Point(125, 170)
        Me.btnSchedAdd.Name = "btnSchedAdd"
        Me.btnSchedAdd.Size = New System.Drawing.Size(122, 37)
        Me.btnSchedAdd.TabIndex = 9
        Me.btnSchedAdd.Text = "Add"
        Me.btnSchedAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Grade / Year Level"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView4.Location = New System.Drawing.Point(1, 213)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(829, 210)
        Me.DataGridView4.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "schednumber"
        Me.Column3.HeaderText = "Schedule Number"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "gradeyearname"
        Me.Column7.HeaderText = "Grade / Year Level"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "sectionname"
        Me.Column8.HeaderText = "Section Name"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "sched"
        Me.Column9.HeaderText = "Schedule"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Form_StudentMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(992, 479)
        Me.Controls.Add(Me.gbSched)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.gbSection)
        Me.Controls.Add(Me.gbGradeYearLevel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_StudentMaintenance"
        Me.Text = "Student Maintenance"
        Me.gbGradeYearLevel.ResumeLayout(False)
        Me.gbGradeYearLevel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSection.ResumeLayout(False)
        Me.gbSection.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSched.ResumeLayout(False)
        Me.gbSched.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbGradeYearLevel As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gbSection As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearLevel As Button
    Friend WithEvents btnDeleteLevel As Button
    Friend WithEvents btnEditLevel As Button
    Friend WithEvents btnAddLevel As Button
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents btnClearSection As Button
    Friend WithEvents cbLevel As ComboBox
    Friend WithEvents btnDeleteSection As Button
    Friend WithEvents txtSection As TextBox
    Friend WithEvents btnEditSection As Button
    Friend WithEvents btnAddSection As Button
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbSched As GroupBox
    Friend WithEvents btnClearSched As Button
    Friend WithEvents btnSchedDelete As Button
    Friend WithEvents btnSchedEdit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSchedAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents txtSched As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSchedSection As ComboBox
    Friend WithEvents cbSchedGYLVL As ComboBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
