<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScheduleEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleEdit))
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cboMovie = New System.Windows.Forms.ComboBox()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cboHall = New System.Windows.Forms.ComboBox()
        Me.lblHall = New System.Windows.Forms.Label()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check})
        Me.dgvSchedule.Location = New System.Drawing.Point(32, 70)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvSchedule.Size = New System.Drawing.Size(542, 246)
        Me.dgvSchedule.TabIndex = 0
        '
        'Check
        '
        Me.Check.HeaderText = "Available"
        Me.Check.Name = "Check"
        '
        'cboMovie
        '
        Me.cboMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMovie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMovie.FormattingEnabled = True
        Me.cboMovie.Location = New System.Drawing.Point(95, 34)
        Me.cboMovie.Name = "cboMovie"
        Me.cboMovie.Size = New System.Drawing.Size(149, 23)
        Me.cboMovie.TabIndex = 1
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovie.Location = New System.Drawing.Point(28, 38)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(49, 15)
        Me.lblMovie.TabIndex = 2
        Me.lblMovie.Text = "Movie : "
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.Location = New System.Drawing.Point(30, 333)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(63, 15)
        Me.lblRecord.TabIndex = 5
        Me.lblRecord.Text = "0 record(s)"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(499, 326)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 28)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.cboHall)
        Me.GroupBox1.Controls.Add(Me.lblHall)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.lblMovie)
        Me.GroupBox1.Controls.Add(Me.lblRecord)
        Me.GroupBox1.Controls.Add(Me.cboMovie)
        Me.GroupBox1.Controls.Add(Me.dgvSchedule)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 373)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Schedule Available"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(404, 326)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 28)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cboHall
        '
        Me.cboHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHall.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHall.FormattingEnabled = True
        Me.cboHall.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboHall.Location = New System.Drawing.Point(347, 34)
        Me.cboHall.Name = "cboHall"
        Me.cboHall.Size = New System.Drawing.Size(59, 23)
        Me.cboHall.TabIndex = 8
        '
        'lblHall
        '
        Me.lblHall.AutoSize = True
        Me.lblHall.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHall.Location = New System.Drawing.Point(297, 38)
        Me.lblHall.Name = "lblHall"
        Me.lblHall.Size = New System.Drawing.Size(34, 15)
        Me.lblHall.TabIndex = 7
        Me.lblHall.Text = "Hall :"
        '
        'frmScheduleEdit
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScheduleEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Schedule"
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents cboMovie As ComboBox
    Friend WithEvents lblMovie As Label
    Friend WithEvents lblRecord As Label
    'Friend WithEvents KingDBDataSet As KingDBDataSet
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    'Friend WithEvents MovieTableAdapter1 As KingDBDataSetTableAdapters.MovieTableAdapter
    Friend WithEvents cboHall As ComboBox
    Friend WithEvents lblHall As Label
    Friend WithEvents btnBack As Button
End Class
