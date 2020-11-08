<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPayable = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskCardNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskCCV = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpCardDetails = New System.Windows.Forms.GroupBox()
        Me.radMaster = New System.Windows.Forms.RadioButton()
        Me.radVisa = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.errCardPay = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpCardDetails.SuspendLayout()
        CType(Me.errCardPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "RM"
        '
        'lblPayable
        '
        Me.lblPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayable.Location = New System.Drawing.Point(180, 20)
        Me.lblPayable.Name = "lblPayable"
        Me.lblPayable.Size = New System.Drawing.Size(104, 23)
        Me.lblPayable.TabIndex = 249
        Me.lblPayable.Text = "75.00"
        Me.lblPayable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 248
        Me.Label7.Text = "Total Amount :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskCardNo
        '
        Me.mskCardNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCardNo.Location = New System.Drawing.Point(130, 79)
        Me.mskCardNo.Mask = "0000-0000-0000-0000"
        Me.mskCardNo.Name = "mskCardNo"
        Me.mskCardNo.Size = New System.Drawing.Size(132, 23)
        Me.mskCardNo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Card Number :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "Card Type :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskCCV
        '
        Me.mskCCV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCCV.Location = New System.Drawing.Point(375, 79)
        Me.mskCCV.Mask = "000"
        Me.mskCCV.Name = "mskCCV"
        Me.mskCCV.Size = New System.Drawing.Size(28, 23)
        Me.mskCCV.TabIndex = 4
        Me.mskCCV.Text = "888"
        Me.mskCCV.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 257
        Me.Label5.Text = "CCV/CVC :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboYear)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboMonth)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(284, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 61)
        Me.GroupBox1.TabIndex = 259
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expiry"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboYear.Location = New System.Drawing.Point(64, 31)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(61, 23)
        Me.cboYear.TabIndex = 260
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 15)
        Me.Label8.TabIndex = 259
        Me.Label8.Text = "Year"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(14, 31)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(42, 23)
        Me.cboMonth.TabIndex = 258
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Month"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 15)
        Me.Label9.TabIndex = 260
        Me.Label9.Text = "Card Holder Name :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(130, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 23)
        Me.txtName.TabIndex = 2
        Me.txtName.Tag = ""
        '
        'grpCardDetails
        '
        Me.grpCardDetails.Controls.Add(Me.radMaster)
        Me.grpCardDetails.Controls.Add(Me.radVisa)
        Me.grpCardDetails.Controls.Add(Me.txtName)
        Me.grpCardDetails.Controls.Add(Me.mskCardNo)
        Me.grpCardDetails.Controls.Add(Me.Label9)
        Me.grpCardDetails.Controls.Add(Me.Label2)
        Me.grpCardDetails.Controls.Add(Me.GroupBox1)
        Me.grpCardDetails.Controls.Add(Me.Label3)
        Me.grpCardDetails.Controls.Add(Me.mskCCV)
        Me.grpCardDetails.Controls.Add(Me.Label5)
        Me.grpCardDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCardDetails.Location = New System.Drawing.Point(15, 59)
        Me.grpCardDetails.Name = "grpCardDetails"
        Me.grpCardDetails.Size = New System.Drawing.Size(431, 113)
        Me.grpCardDetails.TabIndex = 262
        Me.grpCardDetails.TabStop = False
        Me.grpCardDetails.Text = "Card Details"
        '
        'radMaster
        '
        Me.radMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.radMaster.CausesValidation = False
        Me.radMaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMaster.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.master
        Me.radMaster.Location = New System.Drawing.Point(204, 16)
        Me.radMaster.Name = "radMaster"
        Me.radMaster.Size = New System.Drawing.Size(58, 33)
        Me.radMaster.TabIndex = 1
        Me.radMaster.UseVisualStyleBackColor = True
        '
        'radVisa
        '
        Me.radVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.radVisa.CausesValidation = False
        Me.radVisa.Checked = True
        Me.radVisa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVisa.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.visa
        Me.radVisa.Location = New System.Drawing.Point(132, 16)
        Me.radVisa.Name = "radVisa"
        Me.radVisa.Size = New System.Drawing.Size(58, 33)
        Me.radVisa.TabIndex = 0
        Me.radVisa.TabStop = True
        Me.radVisa.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.CausesValidation = False
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(371, 35)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 24)
        Me.btnReset.TabIndex = 264
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Enabled = False
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(290, 6)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 53)
        Me.btnPay.TabIndex = 263
        Me.btnPay.Text = "&Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.CausesValidation = False
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(15, 179)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 24)
        Me.btnBack.TabIndex = 265
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'errCardPay
        '
        Me.errCardPay.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errCardPay.ContainerControl = Me
        '
        'frmCardPayment
        '
        Me.AcceptButton = Me.btnPay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(458, 214)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.grpCardDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPayable)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCardPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Card Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCardDetails.ResumeLayout(False)
        Me.grpCardDetails.PerformLayout()
        CType(Me.errCardPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPayable As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mskCardNo As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskCCV As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpCardDetails As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents radVisa As RadioButton
    Friend WithEvents radMaster As RadioButton
    Friend WithEvents errCardPay As ErrorProvider
End Class
