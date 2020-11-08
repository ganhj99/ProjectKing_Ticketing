<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyMovieScheduleReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthlyMovieScheduleReport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.docMember = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreviewMember = New System.Windows.Forms.PrintPreviewDialog()
        Me.ttipPrintReport = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipFilterReport = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgvMovieSchedule = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dtpicker = New System.Windows.Forms.DateTimePicker()
        Me.lblCMRM = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMovieSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'docMember
        '
        '
        'dlgPreviewMember
        '
        Me.dlgPreviewMember.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewMember.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewMember.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewMember.Document = Me.docMember
        Me.dlgPreviewMember.Enabled = True
        Me.dlgPreviewMember.Icon = CType(resources.GetObject("dlgPreviewMember.Icon"), System.Drawing.Icon)
        Me.dlgPreviewMember.Name = "prtPrevDlgMNMR"
        Me.dlgPreviewMember.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(179, 35)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.dgvMovieSchedule)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.dtpicker)
        Me.GroupBox1.Controls.Add(Me.lblCMRM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 358)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monthly Movie Schedule Report"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(637, 315)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dgvMovieSchedule
        '
        Me.dgvMovieSchedule.AllowUserToAddRows = False
        Me.dgvMovieSchedule.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvMovieSchedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMovieSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovieSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvMovieSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMovieSchedule.CausesValidation = False
        Me.dgvMovieSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovieSchedule.Location = New System.Drawing.Point(21, 57)
        Me.dgvMovieSchedule.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMovieSchedule.Name = "dgvMovieSchedule"
        Me.dgvMovieSchedule.ReadOnly = True
        Me.dgvMovieSchedule.RowHeadersWidth = 70
        Me.dgvMovieSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMovieSchedule.RowTemplate.Height = 24
        Me.dgvMovieSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovieSchedule.Size = New System.Drawing.Size(691, 244)
        Me.dgvMovieSchedule.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(520, 315)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(71, 25)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dtpicker
        '
        Me.dtpicker.CustomFormat = "MM/yyyy"
        Me.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpicker.Location = New System.Drawing.Point(88, 25)
        Me.dtpicker.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(95, 23)
        Me.dtpicker.TabIndex = 8
        '
        'lblCMRM
        '
        Me.lblCMRM.AutoSize = True
        Me.lblCMRM.Location = New System.Drawing.Point(20, 320)
        Me.lblCMRM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCMRM.Name = "lblCMRM"
        Me.lblCMRM.Size = New System.Drawing.Size(98, 15)
        Me.lblCMRM.TabIndex = 10
        Me.lblCMRM.Text = "0 record(s) found"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Filter by : "
        '
        'frmMonthlyMovieScheduleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 386)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonthlyMovieScheduleReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monthly Movie Schedule"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMovieSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents docMember As Printing.PrintDocument
    Friend WithEvents dlgPreviewMember As PrintPreviewDialog
    Friend WithEvents ttipPrintReport As ToolTip
    Friend WithEvents ttipFilterReport As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgvMovieSchedule As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents dtpicker As DateTimePicker
    Friend WithEvents lblCMRM As Label
    Friend WithEvents Label1 As Label
End Class
