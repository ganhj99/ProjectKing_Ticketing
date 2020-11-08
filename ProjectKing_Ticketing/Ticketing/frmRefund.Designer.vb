<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefund
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblAmtRefundable = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFirst = New System.Windows.Forms.CheckBox()
        Me.chkSecond = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrinted = New System.Windows.Forms.Label()
        Me.btnRefundNow = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(184, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 15)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "RM"
        '
        'lblAmtRefundable
        '
        Me.lblAmtRefundable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmtRefundable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtRefundable.Location = New System.Drawing.Point(183, 118)
        Me.lblAmtRefundable.Name = "lblAmtRefundable"
        Me.lblAmtRefundable.Size = New System.Drawing.Size(112, 23)
        Me.lblAmtRefundable.TabIndex = 254
        Me.lblAmtRefundable.Text = "8.00"
        Me.lblAmtRefundable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 15)
        Me.Label16.TabIndex = 253
        Me.Label16.Text = "Total Refundable Amount :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 20)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "Please checked the following item before proceed with this action :"
        '
        'chkFirst
        '
        Me.chkFirst.AutoSize = True
        Me.chkFirst.Location = New System.Drawing.Point(19, 42)
        Me.chkFirst.Name = "chkFirst"
        Me.chkFirst.Size = New System.Drawing.Size(204, 19)
        Me.chkFirst.TabIndex = 257
        Me.chkFirst.Text = "Printed receipt has been collected"
        Me.chkFirst.UseVisualStyleBackColor = True
        '
        'chkSecond
        '
        Me.chkSecond.AutoSize = True
        Me.chkSecond.Location = New System.Drawing.Point(19, 67)
        Me.chkSecond.Name = "chkSecond"
        Me.chkSecond.Size = New System.Drawing.Size(192, 19)
        Me.chkSecond.TabIndex = 258
        Me.chkSecond.Text = "Customer agreed on the refund"
        Me.chkSecond.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrinted)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkSecond)
        Me.GroupBox1.Controls.Add(Me.chkFirst)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 100)
        Me.GroupBox1.TabIndex = 259
        Me.GroupBox1.TabStop = False
        '
        'lblPrinted
        '
        Me.lblPrinted.AutoSize = True
        Me.lblPrinted.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinted.Location = New System.Drawing.Point(220, 43)
        Me.lblPrinted.Name = "lblPrinted"
        Me.lblPrinted.Size = New System.Drawing.Size(122, 15)
        Me.lblPrinted.TabIndex = 259
        Me.lblPrinted.Text = "(Tickets is not printed)"
        '
        'btnRefundNow
        '
        Me.btnRefundNow.Location = New System.Drawing.Point(301, 117)
        Me.btnRefundNow.Name = "btnRefundNow"
        Me.btnRefundNow.Size = New System.Drawing.Size(112, 26)
        Me.btnRefundNow.TabIndex = 260
        Me.btnRefundNow.Text = "&Refund Now"
        Me.btnRefundNow.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(13, 150)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 261
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmRefund
        '
        Me.AcceptButton = Me.btnRefundNow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(438, 185)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRefundNow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblAmtRefundable)
        Me.Controls.Add(Me.Label16)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRefund"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cancel Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents lblAmtRefundable As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkFirst As CheckBox
    Friend WithEvents chkSecond As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrinted As Label
    Friend WithEvents btnRefundNow As Button
    Friend WithEvents btnBack As Button
End Class
