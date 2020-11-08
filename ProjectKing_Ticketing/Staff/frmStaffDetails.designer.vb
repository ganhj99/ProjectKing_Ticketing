<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffDetails
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.mskStaffPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboStaffRole = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblStaffAge = New System.Windows.Forms.Label()
        Me.lblStaffIC = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.lblStaffJoinDate = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.StaffErr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboStaffStatus = New System.Windows.Forms.ComboBox()
        Me.StaffPicture = New System.Windows.Forms.PictureBox()
        Me.btnChange = New System.Windows.Forms.Button()
        CType(Me.StaffErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(395, 144)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 15)
        Me.label3.TabIndex = 30
        Me.label3.Text = "Join Date :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(157, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "&Phone No. :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(184, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "&Email :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(155, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "IC Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Date of Birth :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Name :"
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Location = New System.Drawing.Point(232, 171)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(130, 20)
        Me.txtStaffEmail.TabIndex = 37
        '
        'mskStaffPhone
        '
        Me.mskStaffPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStaffPhone.Location = New System.Drawing.Point(232, 141)
        Me.mskStaffPhone.Mask = "000-0000000"
        Me.mskStaffPhone.Name = "mskStaffPhone"
        Me.mskStaffPhone.Size = New System.Drawing.Size(130, 20)
        Me.mskStaffPhone.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Status :"
        '
        'cboStaffRole
        '
        Me.cboStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffRole.FormattingEnabled = True
        Me.cboStaffRole.Items.AddRange(New Object() {"Cashier", "Manager"})
        Me.cboStaffRole.Location = New System.Drawing.Point(462, 110)
        Me.cboStaffRole.Name = "cboStaffRole"
        Me.cboStaffRole.Size = New System.Drawing.Size(130, 21)
        Me.cboStaffRole.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(435, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 15)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "ID "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(420, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Role :"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(132, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(324, 17)
        Me.lblTitle.TabIndex = 51
        Me.lblTitle.Text = "Staff Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.CausesValidation = False
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 200)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblStaffName
        '
        Me.lblStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffName.Location = New System.Drawing.Point(232, 49)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(130, 20)
        Me.lblStaffName.TabIndex = 55
        Me.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStaffAge
        '
        Me.lblStaffAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffAge.Location = New System.Drawing.Point(232, 78)
        Me.lblStaffAge.Name = "lblStaffAge"
        Me.lblStaffAge.Size = New System.Drawing.Size(130, 20)
        Me.lblStaffAge.TabIndex = 56
        Me.lblStaffAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStaffIC
        '
        Me.lblStaffIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffIC.Location = New System.Drawing.Point(232, 108)
        Me.lblStaffIC.Name = "lblStaffIC"
        Me.lblStaffIC.Size = New System.Drawing.Size(130, 20)
        Me.lblStaffIC.TabIndex = 57
        Me.lblStaffIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Location = New System.Drawing.Point(462, 49)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(130, 20)
        Me.lblStaffID.TabIndex = 58
        Me.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStaffJoinDate
        '
        Me.lblStaffJoinDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffJoinDate.Location = New System.Drawing.Point(462, 141)
        Me.lblStaffJoinDate.Name = "lblStaffJoinDate"
        Me.lblStaffJoinDate.Size = New System.Drawing.Size(130, 20)
        Me.lblStaffJoinDate.TabIndex = 59
        Me.lblStaffJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(517, 169)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'StaffErr
        '
        Me.StaffErr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.StaffErr.ContainerControl = Me
        '
        'cboStaffStatus
        '
        Me.cboStaffStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffStatus.FormattingEnabled = True
        Me.cboStaffStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStaffStatus.Location = New System.Drawing.Point(462, 79)
        Me.cboStaffStatus.Name = "cboStaffStatus"
        Me.cboStaffStatus.Size = New System.Drawing.Size(130, 21)
        Me.cboStaffStatus.TabIndex = 61
        '
        'StaffPicture
        '
        Me.StaffPicture.Location = New System.Drawing.Point(12, 49)
        Me.StaffPicture.Name = "StaffPicture"
        Me.StaffPicture.Size = New System.Drawing.Size(129, 145)
        Me.StaffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StaffPicture.TabIndex = 62
        Me.StaffPicture.TabStop = False
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(386, 169)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(125, 23)
        Me.btnChange.TabIndex = 63
        Me.btnChange.Text = "&Change Password"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'frmStaffDetails
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(622, 234)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.StaffPicture)
        Me.Controls.Add(Me.cboStaffStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblStaffJoinDate)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.lblStaffIC)
        Me.Controls.Add(Me.lblStaffAge)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboStaffRole)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.mskStaffPhone)
        Me.Controls.Add(Me.txtStaffEmail)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStaffDetails"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Staff Details"
        CType(Me.StaffErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents mskStaffPhone As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboStaffRole As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblStaffName As Label
    Friend WithEvents lblStaffAge As Label
    Friend WithEvents lblStaffIC As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents lblStaffJoinDate As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents StaffErr As ErrorProvider
    Friend WithEvents cboStaffStatus As ComboBox
    Friend WithEvents StaffPicture As PictureBox
    Friend WithEvents btnChange As Button
End Class
