<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddStaff
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpStaffDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pbStaffImage = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskStaffPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mskStaffIC = New System.Windows.Forms.MaskedTextBox()
        Me.txtStaffJoinDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStaffStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboStaffRole = New System.Windows.Forms.ComboBox()
        Me.txtStaffConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtStaffPass = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.staffErr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.staffTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbStaffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.staffErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name :"
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(102, 33)
        Me.txtStaffName.MaxLength = 30
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffName.TabIndex = 9
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.Location = New System.Drawing.Point(507, 248)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStaff.TabIndex = 15
        Me.btnAddStaff.Text = "&Add"
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(507, 277)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(426, 248)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(75, 23)
        Me.btnClearForm.TabIndex = 17
        Me.btnClearForm.Text = "&Clear"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpStaffDOB)
        Me.GroupBox1.Controls.Add(Me.btnCapture)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.pbStaffImage)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.lblStaffID)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mskStaffPhone)
        Me.GroupBox1.Controls.Add(Me.mskStaffIC)
        Me.GroupBox1.Controls.Add(Me.txtStaffJoinDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtStaffStatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboStaffRole)
        Me.GroupBox1.Controls.Add(Me.txtStaffConfirmPass)
        Me.GroupBox1.Controls.Add(Me.txtStaffPass)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnAddStaff)
        Me.GroupBox1.Controls.Add(Me.txtStaffEmail)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnClearForm)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStaffName)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 321)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Staff"
        '
        'dtpStaffDOB
        '
        Me.dtpStaffDOB.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffDOB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStaffDOB.Location = New System.Drawing.Point(102, 62)
        Me.dtpStaffDOB.Name = "dtpStaffDOB"
        Me.dtpStaffDOB.Size = New System.Drawing.Size(130, 23)
        Me.dtpStaffDOB.TabIndex = 66
        '
        'btnCapture
        '
        Me.btnCapture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(426, 169)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(88, 23)
        Me.btnCapture.TabIndex = 65
        Me.btnCapture.Text = "Capture Image"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(426, 138)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(88, 23)
        Me.btnStart.TabIndex = 64
        Me.btnStart.Text = "Start Camera"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pbStaffImage
        '
        Me.pbStaffImage.Location = New System.Drawing.Point(265, 138)
        Me.pbStaffImage.Name = "pbStaffImage"
        Me.pbStaffImage.Size = New System.Drawing.Size(155, 162)
        Me.pbStaffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStaffImage.TabIndex = 63
        Me.pbStaffImage.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = My.Resources.Resources.Button_Refresh_icon
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(507, 29)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(36, 32)
        Me.btnRefresh.TabIndex = 33
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(371, 33)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(130, 23)
        Me.lblStaffID.TabIndex = 32
        Me.lblStaffID.Text = "S0000"
        Me.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(171, 285)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(51, 19)
        Me.radMale.TabIndex = 31
        Me.radMale.Text = "&Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Checked = True
        Me.radFemale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(102, 285)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(63, 19)
        Me.radFemale.TabIndex = 30
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Gender :"
        '
        'mskStaffPhone
        '
        Me.mskStaffPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStaffPhone.Location = New System.Drawing.Point(102, 196)
        Me.mskStaffPhone.Mask = "000-0000000"
        Me.mskStaffPhone.Name = "mskStaffPhone"
        Me.mskStaffPhone.Size = New System.Drawing.Size(130, 23)
        Me.mskStaffPhone.TabIndex = 28
        '
        'mskStaffIC
        '
        Me.mskStaffIC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStaffIC.Location = New System.Drawing.Point(102, 92)
        Me.mskStaffIC.Mask = "000000-00-0000"
        Me.mskStaffIC.Name = "mskStaffIC"
        Me.mskStaffIC.Size = New System.Drawing.Size(130, 23)
        Me.mskStaffIC.TabIndex = 27
        '
        'txtStaffJoinDate
        '
        Me.txtStaffJoinDate.Enabled = False
        Me.txtStaffJoinDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffJoinDate.Location = New System.Drawing.Point(102, 255)
        Me.txtStaffJoinDate.Name = "txtStaffJoinDate"
        Me.txtStaffJoinDate.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffJoinDate.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "&Join Date :"
        '
        'txtStaffStatus
        '
        Me.txtStaffStatus.Enabled = False
        Me.txtStaffStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffStatus.Location = New System.Drawing.Point(102, 138)
        Me.txtStaffStatus.Name = "txtStaffStatus"
        Me.txtStaffStatus.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffStatus.TabIndex = 23
        Me.txtStaffStatus.Text = "Active"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "S&tatus :"
        '
        'cboStaffRole
        '
        Me.cboStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffRole.FormattingEnabled = True
        Me.cboStaffRole.Items.AddRange(New Object() {"Cashier", "Manager"})
        Me.cboStaffRole.Location = New System.Drawing.Point(102, 166)
        Me.cboStaffRole.Name = "cboStaffRole"
        Me.cboStaffRole.Size = New System.Drawing.Size(130, 23)
        Me.cboStaffRole.TabIndex = 21
        '
        'txtStaffConfirmPass
        '
        Me.txtStaffConfirmPass.Enabled = False
        Me.txtStaffConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffConfirmPass.Location = New System.Drawing.Point(371, 94)
        Me.txtStaffConfirmPass.MaxLength = 30
        Me.txtStaffConfirmPass.Name = "txtStaffConfirmPass"
        Me.txtStaffConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtStaffConfirmPass.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffConfirmPass.TabIndex = 20
        '
        'txtStaffPass
        '
        Me.txtStaffPass.Enabled = False
        Me.txtStaffPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPass.Location = New System.Drawing.Point(371, 64)
        Me.txtStaffPass.MaxLength = 30
        Me.txtStaffPass.Name = "txtStaffPass"
        Me.txtStaffPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtStaffPass.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffPass.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(302, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 15)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Pass&word :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(341, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "ID :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(255, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 15)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "&Confirm Password :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(60, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "&Role :"
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffEmail.Location = New System.Drawing.Point(102, 226)
        Me.txtStaffEmail.MaxLength = 30
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffEmail.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 198)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "P&hone No. :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "&Email :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "&IC Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "&Date of Birth  :"
        '
        'staffErr
        '
        Me.staffErr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.staffErr.ContainerControl = Me
        '
        'AddStaff
        '
        Me.AcceptButton = Me.btnAddStaff
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(629, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddStaff"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Staff"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbStaffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.staffErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboStaffRole As ComboBox
    Friend WithEvents txtStaffConfirmPass As TextBox
    Friend WithEvents txtStaffPass As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents txtStaffStatus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffJoinDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskStaffPhone As MaskedTextBox
    Friend WithEvents mskStaffIC As MaskedTextBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents staffErr As ErrorProvider
    Friend WithEvents lblStaffID As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pbStaffImage As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents staffTooltip As ToolTip
    Friend WithEvents dtpStaffDOB As DateTimePicker
End Class
