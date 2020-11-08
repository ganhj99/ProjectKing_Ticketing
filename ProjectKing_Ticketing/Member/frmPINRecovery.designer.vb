<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPINRecovery
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblNewPIN = New System.Windows.Forms.Label()
        Me.lblNewPIN2 = New System.Windows.Forms.Label()
        Me.txtNewPIN = New System.Windows.Forms.TextBox()
        Me.txtNewPIN2 = New System.Windows.Forms.TextBox()
        Me.grpPINRecovery = New System.Windows.Forms.GroupBox()
        Me.grpPINRecovery.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Location = New System.Drawing.Point(112, 128)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(68, 24)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "O&K"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblNewPIN
        '
        Me.lblNewPIN.AutoSize = True
        Me.lblNewPIN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPIN.Location = New System.Drawing.Point(77, 33)
        Me.lblNewPIN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewPIN.Name = "lblNewPIN"
        Me.lblNewPIN.Size = New System.Drawing.Size(62, 15)
        Me.lblNewPIN.TabIndex = 0
        Me.lblNewPIN.Text = "New PIN : "
        '
        'lblNewPIN2
        '
        Me.lblNewPIN2.AutoSize = True
        Me.lblNewPIN2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPIN2.Location = New System.Drawing.Point(29, 70)
        Me.lblNewPIN2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewPIN2.Name = "lblNewPIN2"
        Me.lblNewPIN2.Size = New System.Drawing.Size(110, 15)
        Me.lblNewPIN2.TabIndex = 2
        Me.lblNewPIN2.Text = "Re-enter New PIN : "
        '
        'txtNewPIN
        '
        Me.txtNewPIN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPIN.Location = New System.Drawing.Point(143, 30)
        Me.txtNewPIN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewPIN.MaximumSize = New System.Drawing.Size(76, 24)
        Me.txtNewPIN.MaxLength = 6
        Me.txtNewPIN.MinimumSize = New System.Drawing.Size(76, 24)
        Me.txtNewPIN.Name = "txtNewPIN"
        Me.txtNewPIN.Size = New System.Drawing.Size(76, 24)
        Me.txtNewPIN.TabIndex = 1
        Me.txtNewPIN.UseSystemPasswordChar = True
        '
        'txtNewPIN2
        '
        Me.txtNewPIN2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPIN2.Location = New System.Drawing.Point(143, 67)
        Me.txtNewPIN2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewPIN2.MaxLength = 6
        Me.txtNewPIN2.Name = "txtNewPIN2"
        Me.txtNewPIN2.Size = New System.Drawing.Size(76, 23)
        Me.txtNewPIN2.TabIndex = 3
        Me.txtNewPIN2.UseSystemPasswordChar = True
        '
        'grpPINRecovery
        '
        Me.grpPINRecovery.Controls.Add(Me.txtNewPIN)
        Me.grpPINRecovery.Controls.Add(Me.txtNewPIN2)
        Me.grpPINRecovery.Controls.Add(Me.lblNewPIN2)
        Me.grpPINRecovery.Controls.Add(Me.lblNewPIN)
        Me.grpPINRecovery.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPINRecovery.Location = New System.Drawing.Point(9, 12)
        Me.grpPINRecovery.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpPINRecovery.Name = "grpPINRecovery"
        Me.grpPINRecovery.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpPINRecovery.Size = New System.Drawing.Size(283, 105)
        Me.grpPINRecovery.TabIndex = 5
        Me.grpPINRecovery.TabStop = False
        Me.grpPINRecovery.Text = "Reset New PIN"
        '
        'frmPINRecovery
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 164)
        Me.Controls.Add(Me.grpPINRecovery)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPINRecovery"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIN Recovery"
        Me.grpPINRecovery.ResumeLayout(False)
        Me.grpPINRecovery.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents lblNewPIN As Label
    Friend WithEvents lblNewPIN2 As Label
    Friend WithEvents txtNewPIN As TextBox
    Friend WithEvents txtNewPIN2 As TextBox
    Friend WithEvents grpPINRecovery As GroupBox
End Class
