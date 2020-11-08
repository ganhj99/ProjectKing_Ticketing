<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtStaffPassword = New System.Windows.Forms.TextBox()
        Me.llForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.staffErr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.staffErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Password "
        '
        'txtStaffID
        '
        Me.txtStaffID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(83, 9)
        Me.txtStaffID.MaxLength = 5
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(121, 23)
        Me.txtStaffID.TabIndex = 2
        '
        'txtStaffPassword
        '
        Me.txtStaffPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPassword.Location = New System.Drawing.Point(83, 37)
        Me.txtStaffPassword.Name = "txtStaffPassword"
        Me.txtStaffPassword.Size = New System.Drawing.Size(121, 23)
        Me.txtStaffPassword.TabIndex = 3
        Me.txtStaffPassword.UseSystemPasswordChar = True
        '
        'llForgetPassword
        '
        Me.llForgetPassword.AutoSize = True
        Me.llForgetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llForgetPassword.Location = New System.Drawing.Point(21, 72)
        Me.llForgetPassword.Name = "llForgetPassword"
        Me.llForgetPassword.Size = New System.Drawing.Size(95, 15)
        Me.llForgetPassword.TabIndex = 4
        Me.llForgetPassword.TabStop = True
        Me.llForgetPassword.Text = "Forgot Password"
        '
        'btnSignIn
        '
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.Location = New System.Drawing.Point(129, 68)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(75, 23)
        Me.btnSignIn.TabIndex = 5
        Me.btnSignIn.Text = "&Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'staffErr
        '
        Me.staffErr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.staffErr.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.kings_cinema_gold
        Me.PictureBox1.Location = New System.Drawing.Point(65, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtStaffID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSignIn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.llForgetPassword)
        Me.Panel1.Controls.Add(Me.txtStaffPassword)
        Me.Panel1.Location = New System.Drawing.Point(12, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 100)
        Me.Panel1.TabIndex = 8
        '
        'frmStaffLogin
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(254, 243)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStaffLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Login"
        CType(Me.staffErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents txtStaffPassword As TextBox
    Friend WithEvents llForgetPassword As LinkLabel
    Friend WithEvents btnSignIn As Button
    Friend WithEvents staffErr As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
