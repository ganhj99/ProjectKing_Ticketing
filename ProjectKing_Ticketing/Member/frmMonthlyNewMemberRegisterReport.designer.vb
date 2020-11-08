<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonthlyNewMemberRegisterReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthlyNewMemberRegisterReport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dlgPreviewMember = New System.Windows.Forms.PrintPreviewDialog()
        Me.docMember = New System.Drawing.Printing.PrintDocument()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvMember = New System.Windows.Forms.DataGridView()
        Me.lblCMRM = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpicker = New System.Windows.Forms.DateTimePicker()
        Me.ttipPrintReport = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipFilterReport = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'docMember
        '
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(894, 391)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 30)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMember.CausesValidation = False
        Me.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMember.Location = New System.Drawing.Point(12, 71)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersWidth = 70
        Me.dgvMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMember.RowTemplate.Height = 24
        Me.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMember.Size = New System.Drawing.Size(977, 300)
        Me.dgvMember.TabIndex = 3
        '
        'lblCMRM
        '
        Me.lblCMRM.AutoSize = True
        Me.lblCMRM.Location = New System.Drawing.Point(12, 398)
        Me.lblCMRM.Name = "lblCMRM"
        Me.lblCMRM.Size = New System.Drawing.Size(118, 17)
        Me.lblCMRM.TabIndex = 3
        Me.lblCMRM.Text = "0 record(s) found"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter by : "
        '
        'dtpicker
        '
        Me.dtpicker.CustomFormat = "MM/yyyy"
        Me.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpicker.Location = New System.Drawing.Point(88, 23)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(125, 22)
        Me.dtpicker.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleDescription = ""
        Me.btnPrint.AccessibleName = "Print"
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Image = My.Resources.Resources.print_icon
        Me.btnPrint.Location = New System.Drawing.Point(941, 17)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(48, 48)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Tag = ""
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = My.Resources.Resources.information_icon
        Me.PictureBox1.Location = New System.Drawing.Point(219, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.ttipFilterReport.SetToolTip(Me.PictureBox1, "Filter monthly new member register report by month or year")
        '
        'MonthlyNewMemberRegisterReport
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1001, 445)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCMRM)
        Me.Controls.Add(Me.dgvMember)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MonthlyNewMemberRegisterReport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgPreviewMember As PrintPreviewDialog
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvMember As DataGridView
    Friend WithEvents lblCMRM As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpicker As DateTimePicker
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPhotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberICNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberMobileNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberBirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberJoinedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberRewardPointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberRewardPointExpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents docMember As Printing.PrintDocument
    Friend WithEvents ttipPrintReport As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ttipFilterReport As ToolTip
End Class
