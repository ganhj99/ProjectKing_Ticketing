<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfirmPIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblICNO = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtPIN1 = New System.Windows.Forms.TextBox()
        Me.txtPIN2 = New System.Windows.Forms.TextBox()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PIN : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Re-enter PIN : "
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(242, 261)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 24)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.lblBirthDate)
        Me.grpSummary.Controls.Add(Me.lblEmail)
        Me.grpSummary.Controls.Add(Me.lblMobileNo)
        Me.grpSummary.Controls.Add(Me.lblICNO)
        Me.grpSummary.Controls.Add(Me.lblName)
        Me.grpSummary.Controls.Add(Me.Label7)
        Me.grpSummary.Controls.Add(Me.Label6)
        Me.grpSummary.Controls.Add(Me.Label5)
        Me.grpSummary.Controls.Add(Me.Label4)
        Me.grpSummary.Controls.Add(Me.Label3)
        Me.grpSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSummary.Location = New System.Drawing.Point(11, 11)
        Me.grpSummary.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Padding = New System.Windows.Forms.Padding(2)
        Me.grpSummary.Size = New System.Drawing.Size(306, 174)
        Me.grpSummary.TabIndex = 5
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Registration Summary"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBirthDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(91, 133)
        Me.lblBirthDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(189, 23)
        Me.lblBirthDate.TabIndex = 9
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(91, 106)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(189, 23)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMobileNo
        '
        Me.lblMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMobileNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.Location = New System.Drawing.Point(91, 79)
        Me.lblMobileNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(189, 23)
        Me.lblMobileNo.TabIndex = 7
        Me.lblMobileNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblICNO
        '
        Me.lblICNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblICNO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNO.Location = New System.Drawing.Point(91, 53)
        Me.lblICNO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblICNO.Name = "lblICNO"
        Me.lblICNO.Size = New System.Drawing.Size(189, 23)
        Me.lblICNO.TabIndex = 6
        Me.lblICNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(91, 26)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(189, 23)
        Me.lblName.TabIndex = 5
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 138)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Birth Date : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Email : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Mobile No. : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "No. IC : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Full Name : "
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(11, 261)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 24)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtPIN1
        '
        Me.txtPIN1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN1.Location = New System.Drawing.Point(135, 198)
        Me.txtPIN1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPIN1.MaxLength = 6
        Me.txtPIN1.Name = "txtPIN1"
        Me.txtPIN1.Size = New System.Drawing.Size(100, 23)
        Me.txtPIN1.TabIndex = 7
        Me.txtPIN1.UseSystemPasswordChar = True
        '
        'txtPIN2
        '
        Me.txtPIN2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN2.Location = New System.Drawing.Point(135, 225)
        Me.txtPIN2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPIN2.MaxLength = 6
        Me.txtPIN2.Name = "txtPIN2"
        Me.txtPIN2.Size = New System.Drawing.Size(100, 23)
        Me.txtPIN2.TabIndex = 8
        Me.txtPIN2.UseSystemPasswordChar = True
        '
        'frmConfirmPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 295)
        Me.Controls.Add(Me.txtPIN2)
        Me.Controls.Add(Me.txtPIN1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmPIN"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Enter PIN"
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMobileNo As Label
    Friend WithEvents lblICNO As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtPIN1 As TextBox
    Friend WithEvents txtPIN2 As TextBox
End Class
