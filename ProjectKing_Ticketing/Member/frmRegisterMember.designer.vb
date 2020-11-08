<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterMember))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.mskMemberContact = New System.Windows.Forms.MaskedTextBox()
        Me.txtMemberEmail = New System.Windows.Forms.TextBox()
        Me.dtpickMemberBOF = New System.Windows.Forms.DateTimePicker()
        Me.btnOpenCam = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.mskMemberIC = New System.Windows.Forms.MaskedTextBox()
        Me.picMemberPhoto = New System.Windows.Forms.PictureBox()
        Me.grpMemberRegister = New System.Windows.Forms.GroupBox()
        Me.grpCapturePicture = New System.Windows.Forms.GroupBox()
        Me.sfdImg = New System.Windows.Forms.SaveFileDialog()
        CType(Me.picMemberPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMemberRegister.SuspendLayout()
        Me.grpCapturePicture.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. IC : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contact No. (P) : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 189)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Birth of Date : "
        '
        'txtMemberName
        '
        Me.txtMemberName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(117, 33)
        Me.txtMemberName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(155, 23)
        Me.txtMemberName.TabIndex = 0
        '
        'mskMemberContact
        '
        Me.mskMemberContact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberContact.Location = New System.Drawing.Point(117, 109)
        Me.mskMemberContact.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberContact.Mask = "000-000 0000"
        Me.mskMemberContact.Name = "mskMemberContact"
        Me.mskMemberContact.Size = New System.Drawing.Size(155, 23)
        Me.mskMemberContact.TabIndex = 2
        '
        'txtMemberEmail
        '
        Me.txtMemberEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberEmail.Location = New System.Drawing.Point(118, 147)
        Me.txtMemberEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMemberEmail.Name = "txtMemberEmail"
        Me.txtMemberEmail.Size = New System.Drawing.Size(155, 23)
        Me.txtMemberEmail.TabIndex = 3
        '
        'dtpickMemberBOF
        '
        Me.dtpickMemberBOF.CustomFormat = "dd/MM/yyyy"
        Me.dtpickMemberBOF.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpickMemberBOF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickMemberBOF.Location = New System.Drawing.Point(118, 183)
        Me.dtpickMemberBOF.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpickMemberBOF.Name = "dtpickMemberBOF"
        Me.dtpickMemberBOF.Size = New System.Drawing.Size(129, 23)
        Me.dtpickMemberBOF.TabIndex = 4
        Me.dtpickMemberBOF.Value = New Date(2020, 4, 19, 0, 0, 0, 0)
        '
        'btnOpenCam
        '
        Me.btnOpenCam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCam.Location = New System.Drawing.Point(165, 28)
        Me.btnOpenCam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpenCam.Name = "btnOpenCam"
        Me.btnOpenCam.Size = New System.Drawing.Size(76, 24)
        Me.btnOpenCam.TabIndex = 5
        Me.btnOpenCam.Text = "&Open Cam"
        Me.btnOpenCam.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(165, 67)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(76, 24)
        Me.btnCapture.TabIndex = 6
        Me.btnCapture.Text = "&Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(510, 249)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(68, 24)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(11, 249)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(68, 24)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'mskMemberIC
        '
        Me.mskMemberIC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberIC.Location = New System.Drawing.Point(117, 69)
        Me.mskMemberIC.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberIC.Mask = "000000-00-0000"
        Me.mskMemberIC.Name = "mskMemberIC"
        Me.mskMemberIC.Size = New System.Drawing.Size(155, 23)
        Me.mskMemberIC.TabIndex = 1
        '
        'picMemberPhoto
        '
        Me.picMemberPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMemberPhoto.Location = New System.Drawing.Point(14, 28)
        Me.picMemberPhoto.Margin = New System.Windows.Forms.Padding(2)
        Me.picMemberPhoto.Name = "picMemberPhoto"
        Me.picMemberPhoto.Size = New System.Drawing.Size(135, 178)
        Me.picMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMemberPhoto.TabIndex = 0
        Me.picMemberPhoto.TabStop = False
        '
        'grpMemberRegister
        '
        Me.grpMemberRegister.Controls.Add(Me.Label1)
        Me.grpMemberRegister.Controls.Add(Me.mskMemberIC)
        Me.grpMemberRegister.Controls.Add(Me.Label2)
        Me.grpMemberRegister.Controls.Add(Me.Label3)
        Me.grpMemberRegister.Controls.Add(Me.Label4)
        Me.grpMemberRegister.Controls.Add(Me.Label5)
        Me.grpMemberRegister.Controls.Add(Me.txtMemberName)
        Me.grpMemberRegister.Controls.Add(Me.dtpickMemberBOF)
        Me.grpMemberRegister.Controls.Add(Me.mskMemberContact)
        Me.grpMemberRegister.Controls.Add(Me.txtMemberEmail)
        Me.grpMemberRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMemberRegister.Location = New System.Drawing.Point(16, 17)
        Me.grpMemberRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.grpMemberRegister.Name = "grpMemberRegister"
        Me.grpMemberRegister.Padding = New System.Windows.Forms.Padding(2)
        Me.grpMemberRegister.Size = New System.Drawing.Size(295, 228)
        Me.grpMemberRegister.TabIndex = 16
        Me.grpMemberRegister.TabStop = False
        Me.grpMemberRegister.Text = "New Member Register Form"
        '
        'grpCapturePicture
        '
        Me.grpCapturePicture.Controls.Add(Me.picMemberPhoto)
        Me.grpCapturePicture.Controls.Add(Me.btnOpenCam)
        Me.grpCapturePicture.Controls.Add(Me.btnCapture)
        Me.grpCapturePicture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCapturePicture.Location = New System.Drawing.Point(315, 17)
        Me.grpCapturePicture.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCapturePicture.Name = "grpCapturePicture"
        Me.grpCapturePicture.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCapturePicture.Size = New System.Drawing.Size(263, 228)
        Me.grpCapturePicture.TabIndex = 17
        Me.grpCapturePicture.TabStop = False
        Me.grpCapturePicture.Text = "Image Capturing"
        '
        'sfdImg
        '
        Me.sfdImg.FileName = "RegisterMember"
        Me.sfdImg.Filter = "Bitmap|*.png"
        '
        'frmRegisterMember
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(592, 282)
        Me.Controls.Add(Me.grpCapturePicture)
        Me.Controls.Add(Me.grpMemberRegister)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegisterMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Registration"
        CType(Me.picMemberPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMemberRegister.ResumeLayout(False)
        Me.grpMemberRegister.PerformLayout()
        Me.grpCapturePicture.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMemberPhoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents mskMemberContact As MaskedTextBox
    Friend WithEvents txtMemberEmail As TextBox
    Friend WithEvents dtpickMemberBOF As DateTimePicker
    Friend WithEvents btnOpenCam As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents mskMemberIC As MaskedTextBox
    Friend WithEvents grpMemberRegister As GroupBox
    Friend WithEvents grpCapturePicture As GroupBox
    Friend WithEvents sfdImg As SaveFileDialog
End Class
