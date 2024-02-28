<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BarcodePrinting
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddRange = New System.Windows.Forms.Button()
        Me.btnAddSingle = New System.Windows.Forms.Button()
        Me.PanelRange = New System.Windows.Forms.Panel()
        Me.PanelSingle = New System.Windows.Forms.Panel()
        Me.txtSingle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRange.SuspendLayout()
        Me.PanelSingle.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(223, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(769, 479)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.Location = New System.Drawing.Point(50, 431)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(122, 37)
        Me.btnPrintBarcode.TabIndex = 1
        Me.btnPrintBarcode.Text = "Print"
        Me.btnPrintBarcode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(11, 93)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(189, 22)
        Me.txtTo.TabIndex = 4
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(12, 37)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(189, 22)
        Me.txtFrom.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(11, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(206, 146)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'btnAddRange
        '
        Me.btnAddRange.Location = New System.Drawing.Point(45, 196)
        Me.btnAddRange.Name = "btnAddRange"
        Me.btnAddRange.Size = New System.Drawing.Size(122, 37)
        Me.btnAddRange.TabIndex = 7
        Me.btnAddRange.Text = "Add"
        Me.btnAddRange.UseVisualStyleBackColor = True
        Me.btnAddRange.Visible = False
        '
        'btnAddSingle
        '
        Me.btnAddSingle.Location = New System.Drawing.Point(45, 196)
        Me.btnAddSingle.Name = "btnAddSingle"
        Me.btnAddSingle.Size = New System.Drawing.Size(122, 37)
        Me.btnAddSingle.TabIndex = 8
        Me.btnAddSingle.Text = "Add"
        Me.btnAddSingle.UseVisualStyleBackColor = True
        Me.btnAddSingle.Visible = False
        '
        'PanelRange
        '
        Me.PanelRange.Controls.Add(Me.txtFrom)
        Me.PanelRange.Controls.Add(Me.txtTo)
        Me.PanelRange.Controls.Add(Me.Label1)
        Me.PanelRange.Controls.Add(Me.Label2)
        Me.PanelRange.Location = New System.Drawing.Point(11, 62)
        Me.PanelRange.Name = "PanelRange"
        Me.PanelRange.Size = New System.Drawing.Size(206, 128)
        Me.PanelRange.TabIndex = 9
        Me.PanelRange.Visible = False
        '
        'PanelSingle
        '
        Me.PanelSingle.Controls.Add(Me.txtSingle)
        Me.PanelSingle.Controls.Add(Me.Label4)
        Me.PanelSingle.Location = New System.Drawing.Point(11, 62)
        Me.PanelSingle.Name = "PanelSingle"
        Me.PanelSingle.Size = New System.Drawing.Size(206, 128)
        Me.PanelSingle.TabIndex = 10
        Me.PanelSingle.Visible = False
        '
        'txtSingle
        '
        Me.txtSingle.Location = New System.Drawing.Point(10, 33)
        Me.txtSingle.Name = "txtSingle"
        Me.txtSingle.Size = New System.Drawing.Size(189, 22)
        Me.txtSingle.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID Number"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Single Barcode", "Range of Barcode"})
        Me.ComboBox1.Location = New System.Drawing.Point(11, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 24)
        Me.ComboBox1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Selection Mode:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form_BarcodePrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(992, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PanelSingle)
        Me.Controls.Add(Me.PanelRange)
        Me.Controls.Add(Me.btnAddSingle)
        Me.Controls.Add(Me.btnAddRange)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Form_BarcodePrinting"
        Me.Text = "Print Barcode"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRange.ResumeLayout(False)
        Me.PanelRange.PerformLayout()
        Me.PanelSingle.ResumeLayout(False)
        Me.PanelSingle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPrintBarcode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddRange As Button
    Friend WithEvents btnAddSingle As Button
    Friend WithEvents PanelRange As Panel
    Friend WithEvents PanelSingle As Panel
    Friend WithEvents txtSingle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
