<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewStaff))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cboStaffStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.staffDGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboStaffRole = New System.Windows.Forms.ComboBox()
        Me.dtpStaffStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkActivateDate = New System.Windows.Forms.CheckBox()
        Me.StaffDoc = New System.Drawing.Printing.PrintDocument()
        Me.DocPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.staffDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(23, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(269, 348)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboStaffStatus
        '
        Me.cboStaffStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffStatus.FormattingEnabled = True
        Me.cboStaffStatus.Items.AddRange(New Object() {"All Staff", "Active Staff", "Resigned Staff"})
        Me.cboStaffStatus.Location = New System.Drawing.Point(97, 48)
        Me.cboStaffStatus.Name = "cboStaffStatus"
        Me.cboStaffStatus.Size = New System.Drawing.Size(147, 23)
        Me.cboStaffStatus.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Staff &Status : "
        '
        'staffDGV
        '
        Me.staffDGV.AllowUserToAddRows = False
        Me.staffDGV.AllowUserToDeleteRows = False
        Me.staffDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.staffDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.staffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.staffDGV.Location = New System.Drawing.Point(23, 146)
        Me.staffDGV.Name = "staffDGV"
        Me.staffDGV.ReadOnly = True
        Me.staffDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.staffDGV.Size = New System.Drawing.Size(321, 195)
        Me.staffDGV.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Staff &Name : "
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(97, 18)
        Me.txtStaffName.MaxLength = 30
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(147, 23)
        Me.txtStaffName.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Staff &Role : "
        '
        'cboStaffRole
        '
        Me.cboStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffRole.FormattingEnabled = True
        Me.cboStaffRole.Items.AddRange(New Object() {"All Staff", "Manager", "Cashier"})
        Me.cboStaffRole.Location = New System.Drawing.Point(97, 79)
        Me.cboStaffRole.Name = "cboStaffRole"
        Me.cboStaffRole.Size = New System.Drawing.Size(147, 23)
        Me.cboStaffRole.TabIndex = 13
        '
        'dtpStaffStartDate
        '
        Me.dtpStaffStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffStartDate.Location = New System.Drawing.Point(97, 109)
        Me.dtpStaffStartDate.Name = "dtpStaffStartDate"
        Me.dtpStaffStartDate.Size = New System.Drawing.Size(147, 23)
        Me.dtpStaffStartDate.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "&Date : "
        '
        'chkActivateDate
        '
        Me.chkActivateDate.AutoSize = True
        Me.chkActivateDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivateDate.Location = New System.Drawing.Point(252, 113)
        Me.chkActivateDate.Name = "chkActivateDate"
        Me.chkActivateDate.Size = New System.Drawing.Size(96, 19)
        Me.chkActivateDate.TabIndex = 20
        Me.chkActivateDate.Text = "&Activate Date"
        Me.chkActivateDate.UseVisualStyleBackColor = True
        '
        'StaffDoc
        '
        '
        'DocPreview
        '
        Me.DocPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.DocPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.DocPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.DocPreview.Enabled = True
        Me.DocPreview.Icon = CType(resources.GetObject("DocPreview.Icon"), System.Drawing.Icon)
        Me.DocPreview.Name = "DocPreview"
        Me.DocPreview.Visible = False
        '
        'frmViewStaff
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(360, 383)
        Me.Controls.Add(Me.chkActivateDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpStaffStartDate)
        Me.Controls.Add(Me.cboStaffRole)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.staffDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboStaffStatus)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewStaff"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Staff List"
        CType(Me.staffDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents cboStaffStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents staffDGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboStaffRole As ComboBox
    Friend WithEvents dtpStaffStartDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents chkActivateDate As CheckBox
    Friend WithEvents StaffDoc As Printing.PrintDocument
    Friend WithEvents DocPreview As PrintPreviewDialog
End Class
