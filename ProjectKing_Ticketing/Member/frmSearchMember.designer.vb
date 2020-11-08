<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchMember
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
        Me.searchMemberErr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.mskMemberID = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskMemberContact = New System.Windows.Forms.MaskedTextBox()
        Me.mskMemberIC = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpMemberProfile = New System.Windows.Forms.GroupBox()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblRewardPoint = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblICNO = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.searchMemberErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpMemberProfile.SuspendLayout()
        CType(Me.picProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchMemberErr
        '
        Me.searchMemberErr.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.mskMemberID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mskMemberContact)
        Me.GroupBox1.Controls.Add(Me.mskMemberIC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(419, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search A Member"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "*Please use either field to search for a member"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(213, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 42)
        Me.Panel1.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(178, 84)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(68, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "&Search"
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search member")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'mskMemberID
        '
        Me.mskMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberID.Location = New System.Drawing.Point(136, 49)
        Me.mskMemberID.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberID.Mask = "&0000000"
        Me.mskMemberID.Name = "mskMemberID"
        Me.mskMemberID.Size = New System.Drawing.Size(67, 19)
        Me.mskMemberID.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Member ID : "
        '
        'mskMemberContact
        '
        Me.mskMemberContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberContact.Location = New System.Drawing.Point(316, 60)
        Me.mskMemberContact.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberContact.Mask = "000-000 0000"
        Me.mskMemberContact.Name = "mskMemberContact"
        Me.mskMemberContact.Size = New System.Drawing.Size(90, 19)
        Me.mskMemberContact.TabIndex = 2
        '
        'mskMemberIC
        '
        Me.mskMemberIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberIC.Location = New System.Drawing.Point(316, 37)
        Me.mskMemberIC.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberIC.Mask = "000000-00-0000"
        Me.mskMemberIC.Name = "mskMemberIC"
        Me.mskMemberIC.Size = New System.Drawing.Size(90, 19)
        Me.mskMemberIC.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Contact No. (P) : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "IC No. : "
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(16, 335)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "&Back"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'grpMemberProfile
        '
        Me.grpMemberProfile.Controls.Add(Me.lblMemberID)
        Me.grpMemberProfile.Controls.Add(Me.Label4)
        Me.grpMemberProfile.Controls.Add(Me.picProfilePicture)
        Me.grpMemberProfile.Controls.Add(Me.lblRewardPoint)
        Me.grpMemberProfile.Controls.Add(Me.Label5)
        Me.grpMemberProfile.Controls.Add(Me.lblEmail)
        Me.grpMemberProfile.Controls.Add(Me.Label7)
        Me.grpMemberProfile.Controls.Add(Me.lblContactNo)
        Me.grpMemberProfile.Controls.Add(Me.Label8)
        Me.grpMemberProfile.Controls.Add(Me.lblICNO)
        Me.grpMemberProfile.Controls.Add(Me.Label9)
        Me.grpMemberProfile.Controls.Add(Me.Label10)
        Me.grpMemberProfile.Controls.Add(Me.lblFullName)
        Me.grpMemberProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMemberProfile.Location = New System.Drawing.Point(16, 135)
        Me.grpMemberProfile.Margin = New System.Windows.Forms.Padding(2)
        Me.grpMemberProfile.Name = "grpMemberProfile"
        Me.grpMemberProfile.Padding = New System.Windows.Forms.Padding(2)
        Me.grpMemberProfile.Size = New System.Drawing.Size(419, 196)
        Me.grpMemberProfile.TabIndex = 22
        Me.grpMemberProfile.TabStop = False
        Me.grpMemberProfile.Text = "Searched Member"
        '
        'lblMemberID
        '
        Me.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberID.Location = New System.Drawing.Point(115, 26)
        Me.lblMemberID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(131, 21)
        Me.lblMemberID.TabIndex = 12
        Me.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Member ID : "
        '
        'picProfilePicture
        '
        Me.picProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfilePicture.Location = New System.Drawing.Point(268, 24)
        Me.picProfilePicture.Margin = New System.Windows.Forms.Padding(2)
        Me.picProfilePicture.Name = "picProfilePicture"
        Me.picProfilePicture.Size = New System.Drawing.Size(136, 152)
        Me.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfilePicture.TabIndex = 0
        Me.picProfilePicture.TabStop = False
        '
        'lblRewardPoint
        '
        Me.lblRewardPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRewardPoint.Location = New System.Drawing.Point(115, 155)
        Me.lblRewardPoint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRewardPoint.Name = "lblRewardPoint"
        Me.lblRewardPoint.Size = New System.Drawing.Size(131, 21)
        Me.lblRewardPoint.TabIndex = 19
        Me.lblRewardPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Full Name : "
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Location = New System.Drawing.Point(115, 129)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(131, 21)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "IC No. : "
        '
        'lblContactNo
        '
        Me.lblContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContactNo.Location = New System.Drawing.Point(115, 103)
        Me.lblContactNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(131, 21)
        Me.lblContactNo.TabIndex = 16
        Me.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Contact No. (P) : "
        '
        'lblICNO
        '
        Me.lblICNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblICNO.Location = New System.Drawing.Point(115, 77)
        Me.lblICNO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblICNO.Name = "lblICNO"
        Me.lblICNO.Size = New System.Drawing.Size(131, 21)
        Me.lblICNO.TabIndex = 15
        Me.lblICNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 132)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Email : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 158)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Reward Point(s) : "
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Location = New System.Drawing.Point(115, 52)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(131, 21)
        Me.lblFullName.TabIndex = 13
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(360, 335)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&Enter PIN"
        Me.ToolTip1.SetToolTip(Me.btnOK, "Press this button to redeem point as this member")
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmSearchMember
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(449, 373)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpMemberProfile)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchMember"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Member"
        CType(Me.searchMemberErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpMemberProfile.ResumeLayout(False)
        Me.grpMemberProfile.PerformLayout()
        CType(Me.picProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchMemberErr As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents mskMemberID As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskMemberContact As MaskedTextBox
    Friend WithEvents mskMemberIC As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents grpMemberProfile As GroupBox
    Friend WithEvents lblMemberID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picProfilePicture As PictureBox
    Friend WithEvents lblRewardPoint As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblICNO As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
