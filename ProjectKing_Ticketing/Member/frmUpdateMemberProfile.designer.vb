<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateMemberProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateMemberProfile))
        Me.grpProfile = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mskMobileNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.lblRewardPointExpDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblRewardPoint = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblICNO = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpProfile.SuspendLayout()
        CType(Me.picProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProfile
        '
        Me.grpProfile.Controls.Add(Me.txtEmail)
        Me.grpProfile.Controls.Add(Me.mskMobileNo)
        Me.grpProfile.Controls.Add(Me.lblMemberID)
        Me.grpProfile.Controls.Add(Me.lblRewardPointExpDate)
        Me.grpProfile.Controls.Add(Me.Label1)
        Me.grpProfile.Controls.Add(Me.picProfilePicture)
        Me.grpProfile.Controls.Add(Me.lblRewardPoint)
        Me.grpProfile.Controls.Add(Me.Label2)
        Me.grpProfile.Controls.Add(Me.Label3)
        Me.grpProfile.Controls.Add(Me.Label4)
        Me.grpProfile.Controls.Add(Me.Label5)
        Me.grpProfile.Controls.Add(Me.lblICNO)
        Me.grpProfile.Controls.Add(Me.Label6)
        Me.grpProfile.Controls.Add(Me.lblPIN)
        Me.grpProfile.Controls.Add(Me.Label7)
        Me.grpProfile.Controls.Add(Me.lblFullName)
        Me.grpProfile.Controls.Add(Me.Label9)
        Me.grpProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProfile.Location = New System.Drawing.Point(9, 10)
        Me.grpProfile.Margin = New System.Windows.Forms.Padding(2)
        Me.grpProfile.Name = "grpProfile"
        Me.grpProfile.Padding = New System.Windows.Forms.Padding(2)
        Me.grpProfile.Size = New System.Drawing.Size(566, 278)
        Me.grpProfile.TabIndex = 24
        Me.grpProfile.TabStop = False
        Me.grpProfile.Text = "Member Profile"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(171, 181)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(192, 23)
        Me.txtEmail.TabIndex = 22
        '
        'mskMobileNo
        '
        Me.mskMobileNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMobileNo.Location = New System.Drawing.Point(171, 151)
        Me.mskMobileNo.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMobileNo.Mask = "000-000 0000"
        Me.mskMobileNo.MaximumSize = New System.Drawing.Size(192, 25)
        Me.mskMobileNo.MinimumSize = New System.Drawing.Size(192, 25)
        Me.mskMobileNo.Name = "mskMobileNo"
        Me.mskMobileNo.Size = New System.Drawing.Size(192, 23)
        Me.mskMobileNo.TabIndex = 21
        '
        'lblMemberID
        '
        Me.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(171, 29)
        Me.lblMemberID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(192, 21)
        Me.lblMemberID.TabIndex = 12
        Me.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRewardPointExpDate
        '
        Me.lblRewardPointExpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRewardPointExpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewardPointExpDate.Location = New System.Drawing.Point(171, 237)
        Me.lblRewardPointExpDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRewardPointExpDate.Name = "lblRewardPointExpDate"
        Me.lblRewardPointExpDate.Size = New System.Drawing.Size(192, 21)
        Me.lblRewardPointExpDate.TabIndex = 20
        Me.lblRewardPointExpDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member ID : "
        '
        'picProfilePicture
        '
        Me.picProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfilePicture.Location = New System.Drawing.Point(377, 29)
        Me.picProfilePicture.Margin = New System.Windows.Forms.Padding(2)
        Me.picProfilePicture.Name = "picProfilePicture"
        Me.picProfilePicture.Size = New System.Drawing.Size(166, 229)
        Me.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfilePicture.TabIndex = 0
        Me.picProfilePicture.TabStop = False
        '
        'lblRewardPoint
        '
        Me.lblRewardPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRewardPoint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewardPoint.Location = New System.Drawing.Point(171, 207)
        Me.lblRewardPoint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRewardPoint.Name = "lblRewardPoint"
        Me.lblRewardPoint.Size = New System.Drawing.Size(192, 21)
        Me.lblRewardPoint.TabIndex = 19
        Me.lblRewardPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PIN : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "IC No. : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact No. (P) : "
        '
        'lblICNO
        '
        Me.lblICNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblICNO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNO.Location = New System.Drawing.Point(171, 120)
        Me.lblICNO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblICNO.Name = "lblICNO"
        Me.lblICNO.Size = New System.Drawing.Size(192, 21)
        Me.lblICNO.TabIndex = 15
        Me.lblICNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(122, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email : "
        '
        'lblPIN
        '
        Me.lblPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPIN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIN.Location = New System.Drawing.Point(171, 90)
        Me.lblPIN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(192, 21)
        Me.lblPIN.TabIndex = 14
        Me.lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Reward Point(s) : "
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(171, 59)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(192, 21)
        Me.lblFullName.TabIndex = 13
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 240)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Reward Points Expired Date : "
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(507, 295)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 24)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(9, 295)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(68, 24)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmUpdateMemberProfile
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(586, 330)
        Me.Controls.Add(Me.grpProfile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateMemberProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Member"
        Me.grpProfile.ResumeLayout(False)
        Me.grpProfile.PerformLayout()
        CType(Me.picProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProfile As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mskMobileNo As MaskedTextBox
    Friend WithEvents lblMemberID As Label
    Friend WithEvents lblRewardPointExpDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picProfilePicture As PictureBox
    Friend WithEvents lblRewardPoint As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblICNO As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPIN As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
