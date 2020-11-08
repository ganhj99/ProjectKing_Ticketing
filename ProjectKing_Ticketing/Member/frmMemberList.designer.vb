<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMemberList
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.dgvMemberList = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpSearchMember = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mskMemberID = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskMemberContact = New System.Windows.Forms.MaskedTextBox()
        Me.mskMemberIC = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvMemberList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(9, 313)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(71, 24)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(479, 313)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(68, 24)
        Me.btnReport.TabIndex = 8
        Me.btnReport.Text = "&Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'dgvMemberList
        '
        Me.dgvMemberList.AllowUserToAddRows = False
        Me.dgvMemberList.AllowUserToDeleteRows = False
        Me.dgvMemberList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMemberList.CausesValidation = False
        Me.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMemberList.Location = New System.Drawing.Point(9, 150)
        Me.dgvMemberList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMemberList.Name = "dgvMemberList"
        Me.dgvMemberList.ReadOnly = True
        Me.dgvMemberList.RowHeadersWidth = 51
        Me.dgvMemberList.RowTemplate.Height = 24
        Me.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMemberList.Size = New System.Drawing.Size(538, 139)
        Me.dgvMemberList.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(213, 84)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(68, 24)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpSearchMember
        '
        Me.grpSearchMember.Controls.Add(Me.Panel1)
        Me.grpSearchMember.Controls.Add(Me.mskMemberID)
        Me.grpSearchMember.Controls.Add(Me.Label4)
        Me.grpSearchMember.Controls.Add(Me.mskMemberContact)
        Me.grpSearchMember.Controls.Add(Me.mskMemberIC)
        Me.grpSearchMember.Controls.Add(Me.Label5)
        Me.grpSearchMember.Controls.Add(Me.Label7)
        Me.grpSearchMember.Controls.Add(Me.Label6)
        Me.grpSearchMember.Controls.Add(Me.btnSearch)
        Me.grpSearchMember.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchMember.Location = New System.Drawing.Point(9, 17)
        Me.grpSearchMember.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSearchMember.Name = "grpSearchMember"
        Me.grpSearchMember.Padding = New System.Windows.Forms.Padding(2)
        Me.grpSearchMember.Size = New System.Drawing.Size(538, 119)
        Me.grpSearchMember.TabIndex = 14
        Me.grpSearchMember.TabStop = False
        Me.grpSearchMember.Text = "Search Member"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(247, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 42)
        Me.Panel1.TabIndex = 31
        '
        'mskMemberID
        '
        Me.mskMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberID.Location = New System.Drawing.Point(159, 49)
        Me.mskMemberID.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberID.Mask = "&0000000"
        Me.mskMemberID.Name = "mskMemberID"
        Me.mskMemberID.Size = New System.Drawing.Size(67, 19)
        Me.mskMemberID.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Member ID : "
        '
        'mskMemberContact
        '
        Me.mskMemberContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberContact.Location = New System.Drawing.Point(355, 60)
        Me.mskMemberContact.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberContact.Mask = "000-000 0000"
        Me.mskMemberContact.Name = "mskMemberContact"
        Me.mskMemberContact.Size = New System.Drawing.Size(90, 19)
        Me.mskMemberContact.TabIndex = 26
        '
        'mskMemberIC
        '
        Me.mskMemberIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMemberIC.Location = New System.Drawing.Point(355, 37)
        Me.mskMemberIC.Margin = New System.Windows.Forms.Padding(2)
        Me.mskMemberIC.Mask = "000000-00-0000"
        Me.mskMemberIC.Name = "mskMemberIC"
        Me.mskMemberIC.Size = New System.Drawing.Size(90, 19)
        Me.mskMemberIC.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Contact No. (P) : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(307, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "IC No. : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "*Please use either field to search for a member"
        '
        'frmMemberList
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(556, 348)
        Me.Controls.Add(Me.grpSearchMember)
        Me.Controls.Add(Me.dgvMemberList)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemberList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Lists"
        CType(Me.dgvMemberList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchMember.ResumeLayout(False)
        Me.grpSearchMember.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPhotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberICNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberMobileNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberBirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberJoinedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberRewardPointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberRewardPointExpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvMemberList As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents grpSearchMember As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mskMemberID As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskMemberContact As MaskedTextBox
    Friend WithEvents mskMemberIC As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
