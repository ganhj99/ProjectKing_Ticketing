<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTicketing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketing))
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.pnlHall = New System.Windows.Forms.Panel()
        Me.lblHall = New System.Windows.Forms.Label()
        Me.cboDateTime = New System.Windows.Forms.ComboBox()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picAvailable = New System.Windows.Forms.PictureBox()
        Me.picSold = New System.Windows.Forms.PictureBox()
        Me.picSelected = New System.Windows.Forms.PictureBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.numSenior = New System.Windows.Forms.NumericUpDown()
        Me.numChild = New System.Windows.Forms.NumericUpDown()
        Me.numAdult = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.picRating = New System.Windows.Forms.PictureBox()
        Me.picTicketDetails = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.WToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactionNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementMemberRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementMemberList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementMovie = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementReportMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementReportStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementReportMovie = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManagementReportSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.picAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSenior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTicketDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label39.Location = New System.Drawing.Point(12, 20)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(46, 15)
        Me.Label39.TabIndex = 218
        Me.Label39.Text = "Movie :"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label41.Location = New System.Drawing.Point(252, 20)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 15)
        Me.Label41.TabIndex = 221
        Me.Label41.Text = "Showing Time :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlHall
        '
        Me.pnlHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlHall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHall.Location = New System.Drawing.Point(12, 214)
        Me.pnlHall.Name = "pnlHall"
        Me.pnlHall.Size = New System.Drawing.Size(640, 420)
        Me.pnlHall.TabIndex = 224
        '
        'lblHall
        '
        Me.lblHall.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHall.Location = New System.Drawing.Point(178, 5)
        Me.lblHall.Name = "lblHall"
        Me.lblHall.Size = New System.Drawing.Size(295, 24)
        Me.lblHall.TabIndex = 226
        Me.lblHall.Text = "Hall 3 [BIG]"
        Me.lblHall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboDateTime
        '
        Me.cboDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboDateTime.FormattingEnabled = True
        Me.cboDateTime.Location = New System.Drawing.Point(346, 17)
        Me.cboDateTime.Name = "cboDateTime"
        Me.cboDateTime.Size = New System.Drawing.Size(170, 23)
        Me.cboDateTime.TabIndex = 228
        '
        'lblMovie
        '
        Me.lblMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMovie.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMovie.Location = New System.Drawing.Point(64, 16)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(155, 23)
        Me.lblMovie.TabIndex = 229
        Me.lblMovie.Text = "Movie Name Here"
        Me.lblMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(577, 675)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 230
        Me.btnRefresh.Text = "&Refresh"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refresh")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(339, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Seat(s) :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNext.Location = New System.Drawing.Point(577, 131)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 24)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "N&ext"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Proceed to Payment Summary")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCount.Location = New System.Drawing.Point(395, 157)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(105, 15)
        Me.lblCount.TabIndex = 705
        Me.lblCount.Text = "X out of Y selected"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.picAvailable)
        Me.Panel1.Controls.Add(Me.picSold)
        Me.Panel1.Controls.Add(Me.picSelected)
        Me.Panel1.Location = New System.Drawing.Point(12, 633)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 36)
        Me.Panel1.TabIndex = 706
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(294, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(413, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sold"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(175, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected"
        '
        'picAvailable
        '
        Me.picAvailable.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.available
        Me.picAvailable.Location = New System.Drawing.Point(355, 5)
        Me.picAvailable.Name = "picAvailable"
        Me.picAvailable.Size = New System.Drawing.Size(24, 24)
        Me.picAvailable.TabIndex = 2
        Me.picAvailable.TabStop = False
        '
        'picSold
        '
        Me.picSold.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.sold
        Me.picSold.Location = New System.Drawing.Point(449, 5)
        Me.picSold.Name = "picSold"
        Me.picSold.Size = New System.Drawing.Size(24, 24)
        Me.picSold.TabIndex = 1
        Me.picSold.TabStop = False
        '
        'picSelected
        '
        Me.picSelected.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.selected
        Me.picSelected.Location = New System.Drawing.Point(232, 5)
        Me.picSelected.Name = "picSelected"
        Me.picSelected.Size = New System.Drawing.Size(24, 24)
        Me.picSelected.TabIndex = 0
        Me.picSelected.TabStop = False
        '
        'txtSeats
        '
        Me.txtSeats.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeats.Location = New System.Drawing.Point(393, 93)
        Me.txtSeats.Multiline = True
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.ReadOnly = True
        Me.txtSeats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSeats.Size = New System.Drawing.Size(148, 62)
        Me.txtSeats.TabIndex = 707
        '
        'numSenior
        '
        Me.numSenior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSenior.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numSenior.Location = New System.Drawing.Point(228, 36)
        Me.numSenior.Name = "numSenior"
        Me.numSenior.Size = New System.Drawing.Size(54, 23)
        Me.numSenior.TabIndex = 8
        Me.numSenior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.numSenior, "Price per Ticket : RM 10.00")
        '
        'numChild
        '
        Me.numChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numChild.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numChild.Location = New System.Drawing.Point(62, 51)
        Me.numChild.Name = "numChild"
        Me.numChild.Size = New System.Drawing.Size(54, 23)
        Me.numChild.TabIndex = 7
        Me.numChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.numChild, "Price per Ticket : RM 9.00")
        '
        'numAdult
        '
        Me.numAdult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numAdult.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numAdult.Location = New System.Drawing.Point(62, 22)
        Me.numAdult.Name = "numAdult"
        Me.numAdult.Size = New System.Drawing.Size(54, 23)
        Me.numAdult.TabIndex = 6
        Me.numAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.numAdult, "Price per Ticket : RM 14.00")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(134, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Senior Citizen : "
        Me.ToolTip1.SetToolTip(Me.Label11, "Price per Ticket : RM 10.00")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(14, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Adult :"
        Me.ToolTip1.SetToolTip(Me.Label12, "Price Per Ticket - RM 14.00")
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblChild.Location = New System.Drawing.Point(14, 53)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(44, 15)
        Me.lblChild.TabIndex = 3
        Me.lblChild.Text = "Child : "
        Me.ToolTip1.SetToolTip(Me.lblChild, "Price per Ticket : RM 9.00")
        '
        'picRating
        '
        Me.picRating.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRating.Image = Global.ProjectKing_Ticketing.My.Resources.Resources.classU_50px
        Me.picRating.Location = New System.Drawing.Point(196, 17)
        Me.picRating.Name = "picRating"
        Me.picRating.Size = New System.Drawing.Size(22, 21)
        Me.picRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRating.TabIndex = 709
        Me.picRating.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picRating, "Movie Classification, click to know more")
        '
        'picTicketDetails
        '
        Me.picTicketDetails.Image = CType(resources.GetObject("picTicketDetails.Image"), System.Drawing.Image)
        Me.picTicketDetails.Location = New System.Drawing.Point(6, -1)
        Me.picTicketDetails.Name = "picTicketDetails"
        Me.picTicketDetails.Size = New System.Drawing.Size(18, 18)
        Me.picTicketDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTicketDetails.TabIndex = 9
        Me.picTicketDetails.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picTicketDetails, "Ticket Pricing, click to know more")
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblHall)
        Me.Panel2.Location = New System.Drawing.Point(12, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 36)
        Me.Panel2.TabIndex = 707
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picTicketDetails)
        Me.GroupBox2.Controls.Add(Me.numSenior)
        Me.GroupBox2.Controls.Add(Me.numChild)
        Me.GroupBox2.Controls.Add(Me.numAdult)
        Me.GroupBox2.Controls.Add(Me.lblChild)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 86)
        Me.GroupBox2.TabIndex = 712
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "      Ticket Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picRating)
        Me.GroupBox1.Controls.Add(Me.lblMovie)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.cboDateTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 51)
        Me.GroupBox1.TabIndex = 713
        Me.GroupBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 675)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 717
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTransaction, Me.mnuManagement, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 24)
        Me.MenuStrip1.TabIndex = 719
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAccount, Me.mnuFileLogout, Me.WToolStripMenuItem, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileAccount
        '
        Me.mnuFileAccount.Name = "mnuFileAccount"
        Me.mnuFileAccount.Size = New System.Drawing.Size(179, 22)
        Me.mnuFileAccount.Text = "Account Settings"
        '
        'mnuFileLogout
        '
        Me.mnuFileLogout.Name = "mnuFileLogout"
        Me.mnuFileLogout.Size = New System.Drawing.Size(179, 22)
        Me.mnuFileLogout.Text = "{StaffName} Logout"
        '
        'WToolStripMenuItem
        '
        Me.WToolStripMenuItem.Name = "WToolStripMenuItem"
        Me.WToolStripMenuItem.Size = New System.Drawing.Size(176, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(179, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTransactionNew})
        Me.mnuTransaction.Name = "mnuTransaction"
        Me.mnuTransaction.Size = New System.Drawing.Size(79, 20)
        Me.mnuTransaction.Text = "&Transaction"
        '
        'mnuTransactionNew
        '
        Me.mnuTransactionNew.Name = "mnuTransactionNew"
        Me.mnuTransactionNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuTransactionNew.Size = New System.Drawing.Size(204, 22)
        Me.mnuTransactionNew.Text = "&New Transaction"
        '
        'mnuManagement
        '
        Me.mnuManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManagementMember, Me.mnuManagementStaff, Me.mnuManagementMovie, Me.ScheduleToolStripMenuItem, Me.mnuManagementReport})
        Me.mnuManagement.Name = "mnuManagement"
        Me.mnuManagement.Size = New System.Drawing.Size(90, 20)
        Me.mnuManagement.Text = "&Management"
        '
        'mnuManagementMember
        '
        Me.mnuManagementMember.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManagementMemberRegister, Me.mnuManagementMemberList})
        Me.mnuManagementMember.Name = "mnuManagementMember"
        Me.mnuManagementMember.Size = New System.Drawing.Size(122, 22)
        Me.mnuManagementMember.Text = "Member"
        '
        'mnuManagementMemberRegister
        '
        Me.mnuManagementMemberRegister.Name = "mnuManagementMemberRegister"
        Me.mnuManagementMemberRegister.Size = New System.Drawing.Size(191, 22)
        Me.mnuManagementMemberRegister.Text = "Register New Member"
        '
        'mnuManagementMemberList
        '
        Me.mnuManagementMemberList.Name = "mnuManagementMemberList"
        Me.mnuManagementMemberList.Size = New System.Drawing.Size(191, 22)
        Me.mnuManagementMemberList.Text = "Member List"
        '
        'mnuManagementStaff
        '
        Me.mnuManagementStaff.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterStaffToolStripMenuItem, Me.ViewStaffToolStripMenuItem})
        Me.mnuManagementStaff.Name = "mnuManagementStaff"
        Me.mnuManagementStaff.Size = New System.Drawing.Size(122, 22)
        Me.mnuManagementStaff.Text = "Staff"
        '
        'RegisterStaffToolStripMenuItem
        '
        Me.RegisterStaffToolStripMenuItem.Name = "RegisterStaffToolStripMenuItem"
        Me.RegisterStaffToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RegisterStaffToolStripMenuItem.Text = "New Staff"
        '
        'ViewStaffToolStripMenuItem
        '
        Me.ViewStaffToolStripMenuItem.Name = "ViewStaffToolStripMenuItem"
        Me.ViewStaffToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ViewStaffToolStripMenuItem.Text = "View Staff"
        '
        'mnuManagementMovie
        '
        Me.mnuManagementMovie.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMovieToolStripMenuItem, Me.EditMovieToolStripMenuItem})
        Me.mnuManagementMovie.Name = "mnuManagementMovie"
        Me.mnuManagementMovie.Size = New System.Drawing.Size(122, 22)
        Me.mnuManagementMovie.Text = "Movie"
        '
        'NewMovieToolStripMenuItem
        '
        Me.NewMovieToolStripMenuItem.Name = "NewMovieToolStripMenuItem"
        Me.NewMovieToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NewMovieToolStripMenuItem.Text = "New Movie"
        '
        'EditMovieToolStripMenuItem
        '
        Me.EditMovieToolStripMenuItem.Name = "EditMovieToolStripMenuItem"
        Me.EditMovieToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EditMovieToolStripMenuItem.Text = "Edit Movie"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewScheduleToolStripMenuItem, Me.EditScheduleToolStripMenuItem})
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'NewScheduleToolStripMenuItem
        '
        Me.NewScheduleToolStripMenuItem.Name = "NewScheduleToolStripMenuItem"
        Me.NewScheduleToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewScheduleToolStripMenuItem.Text = "New Schedule"
        '
        'EditScheduleToolStripMenuItem
        '
        Me.EditScheduleToolStripMenuItem.Name = "EditScheduleToolStripMenuItem"
        Me.EditScheduleToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EditScheduleToolStripMenuItem.Text = "Edit Schedule"
        '
        'mnuManagementReport
        '
        Me.mnuManagementReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManagementReportMember, Me.mnuManagementReportStaff, Me.mnuManagementReportMovie, Me.mnuManagementReportSales})
        Me.mnuManagementReport.Name = "mnuManagementReport"
        Me.mnuManagementReport.Size = New System.Drawing.Size(122, 22)
        Me.mnuManagementReport.Text = "Report"
        '
        'mnuManagementReportMember
        '
        Me.mnuManagementReportMember.Name = "mnuManagementReportMember"
        Me.mnuManagementReportMember.Size = New System.Drawing.Size(196, 22)
        Me.mnuManagementReportMember.Text = "Member Report"
        '
        'mnuManagementReportStaff
        '
        Me.mnuManagementReportStaff.Name = "mnuManagementReportStaff"
        Me.mnuManagementReportStaff.Size = New System.Drawing.Size(196, 22)
        Me.mnuManagementReportStaff.Text = "Staff Report"
        '
        'mnuManagementReportMovie
        '
        Me.mnuManagementReportMovie.Name = "mnuManagementReportMovie"
        Me.mnuManagementReportMovie.Size = New System.Drawing.Size(196, 22)
        Me.mnuManagementReportMovie.Text = "Movie Schedule Report"
        '
        'mnuManagementReportSales
        '
        Me.mnuManagementReportSales.Name = "mnuManagementReportSales"
        Me.mnuManagementReportSales.Size = New System.Drawing.Size(196, 22)
        Me.mnuManagementReportSales.Text = "Sales Report"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpView, Me.ToolStripSeparator1, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpView
        '
        Me.mnuHelpView.Name = "mnuHelpView"
        Me.mnuHelpView.ShortcutKeyDisplayString = ""
        Me.mnuHelpView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuHelpView.Size = New System.Drawing.Size(173, 22)
        Me.mnuHelpView.Text = "View Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(173, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'frmTicketing
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 709)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pnlHall)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCount)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTicketing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticketing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSenior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAdult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTicketDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label39 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents pnlHall As Panel
    Friend WithEvents lblHall As Label
    Friend WithEvents cboDateTime As ComboBox
    Friend WithEvents lblMovie As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picSelected As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picAvailable As PictureBox
    Friend WithEvents picSold As PictureBox
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents picRating As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents numSenior As NumericUpDown
    Friend WithEvents numChild As NumericUpDown
    Friend WithEvents numAdult As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblChild As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents picTicketDetails As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileAccount As ToolStripMenuItem
    Friend WithEvents mnuFileLogout As ToolStripMenuItem
    Friend WithEvents WToolStripMenuItem As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuTransaction As ToolStripMenuItem
    Friend WithEvents mnuTransactionNew As ToolStripMenuItem
    Friend WithEvents mnuManagement As ToolStripMenuItem
    Friend WithEvents mnuManagementMember As ToolStripMenuItem
    Friend WithEvents mnuManagementMemberRegister As ToolStripMenuItem
    Friend WithEvents mnuManagementMemberList As ToolStripMenuItem
    Friend WithEvents mnuManagementStaff As ToolStripMenuItem
    Friend WithEvents RegisterStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuManagementMovie As ToolStripMenuItem
    Friend WithEvents NewMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuManagementReport As ToolStripMenuItem
    Friend WithEvents mnuManagementReportMember As ToolStripMenuItem
    Friend WithEvents mnuManagementReportStaff As ToolStripMenuItem
    Friend WithEvents mnuManagementReportMovie As ToolStripMenuItem
    Friend WithEvents mnuManagementReportSales As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpView As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
End Class
