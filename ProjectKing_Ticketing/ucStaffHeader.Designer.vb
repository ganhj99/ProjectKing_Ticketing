<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStaffHeader
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timeCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoginNow = New System.Windows.Forms.LinkLabel()
        Me.staffPic = New System.Windows.Forms.PictureBox()
        CType(Me.staffPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCurrentTime.Location = New System.Drawing.Point(444, 29)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(155, 17)
        Me.lblCurrentTime.TabIndex = 718
        Me.lblCurrentTime.Text = "88:88:88 AM"
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCurrentDate.Location = New System.Drawing.Point(405, 12)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(195, 17)
        Me.lblCurrentDate.TabIndex = 717
        Me.lblCurrentDate.Text = "Saturday, 88 November, 8888"
        Me.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 27)
        Me.Label1.TabIndex = 720
        Me.Label1.Text = "Please login to perform an action..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'timeCurrentTime
        '
        '
        'lblLoginNow
        '
        Me.lblLoginNow.AutoSize = True
        Me.lblLoginNow.Location = New System.Drawing.Point(3, 38)
        Me.lblLoginNow.Name = "lblLoginNow"
        Me.lblLoginNow.Size = New System.Drawing.Size(65, 15)
        Me.lblLoginNow.TabIndex = 721
        Me.lblLoginNow.TabStop = True
        Me.lblLoginNow.Text = "Login Now"
        '
        'staffPic
        '
        Me.staffPic.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.default_profile_pic
        Me.staffPic.Location = New System.Drawing.Point(609, 0)
        Me.staffPic.Name = "staffPic"
        Me.staffPic.Size = New System.Drawing.Size(58, 58)
        Me.staffPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.staffPic.TabIndex = 719
        Me.staffPic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.staffPic, "Go to Account Settings")
        '
        'ucStaffHeader
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.lblLoginNow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.staffPic)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucStaffHeader"
        Me.Size = New System.Drawing.Size(667, 58)
        CType(Me.staffPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents staffPic As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents timeCurrentTime As Timer
    Friend WithEvents lblLoginNow As LinkLabel
End Class
