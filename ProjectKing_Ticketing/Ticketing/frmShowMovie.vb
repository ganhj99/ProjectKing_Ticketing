Public Class frmShowMovie
    Public staffId As String
    Dim db As New KingDBDataContext()
    Dim movieList As New List(Of Movie)
    Public needRefresh As Boolean = False
    Private Sub frmShowMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = staffId)

        If staffId = Nothing Then
            mnuFileLogout.Text = "Login"
            mnuTransaction.Enabled = False
            mnuManagement.Enabled = False
            mnuFileAccount.Visible = False
        End If

        'Add new panel
        'Dim panel As New Panel

        movieList.Clear()
        movieList = (From p In db.Movies Select p Where p.Movie_Status = "Active").ToList

        Dim intNoOfCol As Integer = 4 'Every row has only max 3 col
        Dim lastColCt As Integer = movieList.Count Mod intNoOfCol
        Dim lastRowCt As Integer = CInt(Math.Floor(movieList.Count / intNoOfCol) + 1) 'If(lastColCt = 0, strMovieList.Count / intNoOfCol, 
        Dim i As Integer = intNoOfCol + lastColCt + lastRowCt

        Dim index = 0
        Dim rowOffset As Integer = 0
        For r As Integer = 1 To lastRowCt
            Dim colOffset As Integer = 0

            For c As Integer = 1 To intNoOfCol
                If r = lastRowCt And c = lastColCt + 1 Then
                    Return
                End If

                Dim panel As New Panel
                Dim lbl As New Label
                Dim picMovie As New PictureBox
                'Panel1
                '
                panel.SuspendLayout()
                CType(picMovie, ComponentModel.ISupportInitialize).BeginInit()
                panel.BorderStyle = BorderStyle.FixedSingle
                panel.Controls.Add(lbl)
                panel.Controls.Add(picMovie)
                panel.Location = New Point(34 + colOffset, 24 + rowOffset)
                'Dim index As Integer = 0 '(r * intNoOfCol) - (intNoOfCol - c)
                panel.Name = "panel" & movieList.Item(index).Movie_Id
                panel.Size = New Size(130, 220)

                '
                'PictureBox1
                '
                picMovie.BorderStyle = BorderStyle.FixedSingle
                picMovie.Location = New Point(-1, -1)
                picMovie.Name = "picBox" & movieList.Item(index).Movie_Id
                picMovie.SizeMode = PictureBoxSizeMode.StretchImage
                picMovie.Size = New Size(130, 200)

                Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MovieImage\")
                Dim PicInFolder As String = System.IO.Path.Combine(path, movieList.Item(index).Movie_Image)
                picMovie.Image = Image.FromFile(PicInFolder)

                '
                'lblTestMovie
                '
                lbl.BackColor = SystemColors.Control
                lbl.BorderStyle = BorderStyle.FixedSingle
                lbl.Location = New Point(-1, 198)
                lbl.Name = "label" & movieList.Item(index).Movie_Id
                lbl.Size = New Size(130, 21)
                lbl.Text = movieList.Item(index).Movie_Title
                lbl.TextAlign = ContentAlignment.MiddleCenter

                AddHandler panel.Click, AddressOf movie_Click
                AddHandler lbl.Click, AddressOf movie_Click
                AddHandler picMovie.Click, AddressOf movie_Click

                pnlMain.Controls.Add(panel)
                CType(picMovie, ComponentModel.ISupportInitialize).EndInit()
                panel.ResumeLayout(False)

                colOffset += 152
                index += 1
            Next
            rowOffset += 241
        Next
    End Sub

    Private Sub movie_Click(sender As Object, e As EventArgs)
        If staffId = Nothing Then
            frmStaffLogin.ShowDialog()
        Else

            Dim selectedId As Integer

            If TypeOf sender Is Panel Then
                Dim panel As Panel = CType(sender, Panel)
                selectedId = CInt(panel.Name.Substring(5))
            ElseIf TypeOf sender Is Label Then
                Dim label As Label = CType(sender, Label)
                selectedId = CInt(label.Name.Substring(5))
            ElseIf TypeOf sender Is PictureBox Then
                Dim picBox As PictureBox = CType(sender, PictureBox)
                selectedId = CInt(picBox.Name.Substring(6))
            Else
                MsgBox("Error!")
            End If

            Dim db As New KingDBDataContext
            'Load all available schedule (3 days to date)
            Dim rs = From o In db.Schedules
                     Where o.Schedule_Date >= Date.Today And o.Schedule_Date <= Date.Today.AddDays(2) AndAlso
                           True = If(o.Schedule_Date = Date.Today, True = If(o.Start_Time >= Date.Now.TimeOfDay, True, False), True) AndAlso
                           o.Movie.Movie_Id = selectedId
            If (rs.Count <> 0) Then
                Me.Enabled = False
                frmLoading.Show()
                Me.UseWaitCursor = True
                Application.DoEvents()

                With frmTicketing
                    .currentMovieId = selectedId
                    .isNewTransaction = True
                    .Show()
                End With

                Me.Hide()
                Me.Enabled = True
                Me.UseWaitCursor = False
                frmLoading.Hide()
            Else
                MessageBox.Show("The selected movie has no available schedule for 3 days to date, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub frmShowMovie_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If needRefresh Then
            needRefresh = False
            For Each pnl As Control In pnlMain.Controls
                If TypeOf pnl Is Panel Then
                    For Each ctrl As Control In pnl.Controls
                        If TypeOf ctrl Is PictureBox Then
                            Dim pic As PictureBox = CType(ctrl, PictureBox)
                            pic.Image.Dispose()
                            pic.Image = Nothing
                        Else
                        End If
                    Next
                End If
            Next
            pnlMain.Controls.Clear()
            frmShowMovie_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub AnnualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmSalesReport.Show()
    End Sub

    Private Sub mnuFileAccount_Click(sender As Object, e As EventArgs) Handles mnuFileAccount.Click
        With frmStaffDetails
            .SelectedId = staffId
            .Text = "My Account"
            .lblTitle.Text = "My Account"
            .cboStaffStatus.Enabled = False
            .cboStaffRole.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub mnuFileLogout_Click(sender As Object, e As EventArgs) Handles mnuFileLogout.Click
        If staffId = Nothing Then
            frmStaffLogin.ShowDialog()
        ElseIf mnuFileLogout.Text.Contains("Logout") Then
            mnuFileLogout.Text = "Login"
            mnuTransaction.Enabled = False
            mnuManagement.Enabled = False
            mnuFileAccount.Visible = False
            UcStaffHeader1.staffPic.Image = My.Resources.available
            UcStaffHeader1.Label1.Text = "Please login to perform an action..."
            UcStaffHeader1.lblLoginNow.Visible = True
            staffId = Nothing
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmAboutPage.ShowDialog()
    End Sub

    Private Sub mnuTransactionNew_Click(sender As Object, e As EventArgs) Handles mnuTransactionNew.Click
        MessageBox.Show("You are already in the first page of creating new transaction, please choose a movie to proceed to next step.", "King's Cinema", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UcStaffHeader1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuManagementReportSales_Click(sender As Object, e As EventArgs) Handles mnuManagementReportSales.Click
        frmSalesReport.ShowDialog()
    End Sub

    Private Sub mnuManagementMemberRegister_Click(sender As Object, e As EventArgs) Handles mnuManagementMemberRegister.Click
        frmRegisterMember.ShowDialog()
    End Sub

    Private Sub mnuManagementMemberList_Click(sender As Object, e As EventArgs) Handles mnuManagementMemberList.Click
        frmMemberList.ShowDialog()
    End Sub

    Private Sub mnuManagementReportMember_Click(sender As Object, e As EventArgs) Handles mnuManagementReportMember.Click
        frmMonthlyNewMemberRegisterReport.ShowDialog()
    End Sub

    Private Sub RegisterStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStaffToolStripMenuItem.Click
        frmAddStaff.ShowDialog()
    End Sub

    Private Sub ViewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStaffToolStripMenuItem.Click
        frmViewStaff.ShowDialog()
    End Sub

    Private Sub mnuManagementReportStaff_Click(sender As Object, e As EventArgs) Handles mnuManagementReportStaff.Click
        frmViewStaff.ShowDialog()
    End Sub

    Private Sub NewMovieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMovieToolStripMenuItem.Click
        frmMovieCreate.ShowDialog()
    End Sub

    Private Sub EditMovieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMovieToolStripMenuItem.Click
        frmMovieEdit.ShowDialog()
    End Sub

    Private Sub NewScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewScheduleToolStripMenuItem.Click
        frmScheduleCreate.ShowDialog()
    End Sub

    Private Sub EditScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditScheduleToolStripMenuItem.Click
        frmScheduleEdit.ShowDialog()
    End Sub

    Private Sub mnuManagementReportMovie_Click(sender As Object, e As EventArgs) Handles mnuManagementReportMovie.Click
        frmMonthlyMovieScheduleReport.ShowDialog()
    End Sub

    Private Sub mnuHelpView_Click(sender As Object, e As EventArgs) Handles mnuHelpView.Click
        Me.Enabled = False
        frmLoading.Show()
        frmLoading.lblMessage.Text = "Loading help file..."
        Me.UseWaitCursor = True
        Application.DoEvents()

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "")
        Dim address As String = System.IO.Path.Combine(path, "User_Manual.html")
        Process.Start(address)

        Me.Hide()
        Me.Enabled = True
        Me.UseWaitCursor = False
        frmLoading.Hide()
        frmLoading.lblMessage.Text = "Loading..."
    End Sub

End Class