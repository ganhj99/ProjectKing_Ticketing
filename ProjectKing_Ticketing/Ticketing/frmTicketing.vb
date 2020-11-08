Imports System.ComponentModel

Public Class frmTicketing
    Public isNewTransaction As Boolean 'Calling this form must provided this data, TRUE: New Trx, FALSE: Return from prev page

    Private ucGrand As New ucHallGrand
    Private ucNormal As New ucHallNormal

    Friend currentMovieId As Integer 'pass from prev form

    Private scheduleList As New List(Of Schedule)

    Private intSelectedShowTimeIndex As Integer

    Friend intMaxSeatCount As Integer
    Friend intAdultCt As Integer
    Friend intChildCt As Integer
    Friend intSeniorCt As Integer
    Private Sub frmTicketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        If isNewTransaction Then
            UpdateSeats()
            pnlHall.Controls.Add(ucGrand)
            ucGrand.Hide()
            pnlHall.Controls.Add(ucNormal)
            ucNormal.Hide()

            cboDateTime_SelectedIndexChanged(Nothing, Nothing)

            If CurrentSchedule.sch.Movie.Movie_Rating = "18" Then
                picRating.Image = My.Resources.class18_50px
            ElseIf CurrentSchedule.sch.Movie.Movie_Rating = "P13" Then
                picRating.Image = My.Resources.classP13_50px
            ElseIf CurrentSchedule.sch.Movie.Movie_Rating = "U" Then
                picRating.Image = My.Resources.classU_50px
            End If

            numAdult.Value = 0
            numChild.Value = 0
            numSenior.Value = 0

            CurrentTransaction.strSeatSelected.Clear()
            CurrentTransaction.trx = New Transaction
            CurrentTransaction.trxDetsList.Clear()
            CurrentTransaction.ticDetsList.Clear()

            If CurrentSchedule.sch.Movie.Movie_Rating = "18" Then
                ToolTip1.SetToolTip(lblChild, "Child category is not available in '18' rating movie.")
                numChild.Enabled = False
            Else
                numChild.Enabled = True
                ToolTip1.Hide(lblChild)
            End If
        End If
    End Sub

    Private Sub cboDateTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateTime.SelectedIndexChanged
        UpdateLatestDateTimeSelected()
        UpdateCurrentSchedule()

        lblHall.Text = "Hall " & CurrentSchedule.ToHallString()

        'If isNewTransaction Then
        strSeatSelected.Clear()
        'End If

        'Hide all uc first, then only display (to trigger onVisibleChange
        ucNormal.Hide()
        ucGrand.Hide()

        Select Case CurrentSchedule.sch.Hall.Hall_Type.ToUpper
            Case "GRAND"
                ucGrand.Show()
            Case "NORMAL"
                ucNormal.Show()
        End Select

        DisplaySelectedTicketCount()
    End Sub

    Private Sub UpdateLatestDateTimeSelected()
        If cboDateTime.Items.Count = 0 Then
            Return
        End If

        Dim strSplit() As String = cboDateTime.SelectedItem.ToString.Split(CType("[", Char()))
        Dim strDate As Date = Date.ParseExact(strSplit(0).Trim, "ddd, d MMM yyyy", Nothing)
        Dim strTime As DateTime = DateTime.ParseExact(strSplit(1).Substring(0, strSplit(1).Length - 1), "h:mmtt", Nothing)

        For Each sch In scheduleList
            If sch Is Nothing Then
                Exit For
            End If

            If strTime = DateTime.Today.Add(sch.Start_Time) And
               strDate = sch.Schedule_Date Then
                CurrentSchedule.intSelectedId = sch.Schedule_Id
                Exit For
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If CurrentTransaction.strSeatSelected.Count <> 0 Then
            Dim result As DialogResult = MessageBox.Show("All selected seats will be removed and update to the latest status. Are you sure to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                RefreshSeatLayout()
            End If
        Else
            RefreshSeatLayout()
        End If
    End Sub

    Private Sub RefreshSeatLayout()
        'To get latest seats status
        Dim index As Integer = cboDateTime.SelectedIndex
        cboDateTime_SelectedIndexChanged(Nothing, Nothing)
        cboDateTime.SelectedIndex = index
    End Sub

    Private Sub UpdateSeats()
        GetScheduleList()
        UpdateCurrentSchedule()


        'Load lblHall, lblMovie, cboDateTime
        lblHall.Text = "Hall " & CurrentSchedule.ToHallString()
        lblMovie.Text = CurrentSchedule.ToMovieString()
        cboDateTime.Items.Clear()

        Dim i As Integer = 0
        For Each sch In scheduleList
            If sch Is Nothing Then
                Exit For
            End If

            If (sch.Schedule_Id = CurrentSchedule.intSelectedId) Then
                intSelectedShowTimeIndex = i
            End If

            Dim startTime As DateTime = DateTime.Today.Add(sch.Start_Time)
            'Eg: Sat, 28 Mar 2020 [4:30PM]
            cboDateTime.Items.Add(String.Format("{0:ddd, d MMM yyyy} [{1:h:mmtt}]", sch.Schedule_Date, startTime))
            i += 1 'To keep track current index (to be used by SelectedIndex)
        Next

        'Pass in the selectedTime from previous form
        cboDateTime.SelectedIndex = If(i = 0, -1, intSelectedShowTimeIndex)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            Dim selectedCt As Integer ' = 0
            selectedCt = CurrentTransaction.strSeatSelected.Count
            'Select Case CurrentSchedule.sch.Hall.Hall_Type.ToUpper
            '    Case "GRAND"
            '        selectedCt = ucGrand.intSelectedCount
            '    Case "NORMAL"
            '        selectedCt = ucNormal.intSelectedCount
            'End Select

            If selectedCt <> intMaxSeatCount Then
                Throw New Exception("The number of selected seats doesn't meet with the number of tickets")
            ElseIf intMaxSeatCount = 0 Then
                Throw New Exception("Transaction cannot be proceed without any ticket.")
            Else
                frmPayment.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetScheduleList() 'Get latest 3 days record, from all
        Try
            Dim db As New KingDBDataContext

            'Load all available schedule (3 days to date)
            Dim rs = From o In db.Schedules
                     Where o.Schedule_Date >= Date.Today And o.Schedule_Date <= Date.Today.AddDays(2) AndAlso
                           True = If(o.Schedule_Date = Date.Today, True = If(o.Start_Time >= Date.Now.TimeOfDay, True, False), True) AndAlso
                           o.Movie.Movie_Id = currentMovieId AndAlso o.Schedule_Status = "Available"
            'DateTime.Add will cause "the datepart millisecond is not supported by date function dateadd for data type date."

            scheduleList = rs.ToList
            CurrentSchedule.intSelectedId = scheduleList.Item(0).Schedule_Id
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateCurrentSchedule()
        Try
            Dim db As New KingDBDataContext

            'Find which sch is selected from previousForm 
            Dim sch As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Schedule_Id = CurrentSchedule.intSelectedId And o.Schedule_Status = "Available")

            If sch IsNot Nothing Then
                CurrentSchedule.sch = sch
            Else
                Throw New Exception("No such movie schedule is found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub picRating_Click(sender As Object, e As EventArgs) Handles picRating.Click
        frmMovieClassification.ShowDialog()
    End Sub

    Private Sub numTicketDetails_ValueChanged(sender As Object, e As EventArgs) Handles numAdult.ValueChanged, numChild.ValueChanged, numSenior.ValueChanged,
                                                                                        numAdult.TextChanged, numChild.TextChanged, numSenior.TextChanged
        Try

            '    If (IsExceededRange()) Then
            '        numAdult.Value = intAdultCt
            '        numChild.Value = intChildCt
            '        numSenior.Value = intSeniorCt
            '        Throw New Exception("The number of selected seats has exceeded the range. Please remove the seat selected to proceed with this action.")
            '    Else
            Dim selectedCt As Integer '= 0
            selectedCt = CurrentTransaction.strSeatSelected.Count

            'Select Case CurrentSchedule.sch.Hall.Hall_Type.ToUpper
            '    Case "GRAND"
            '        selectedCt = ucGrand.intSelectedCount
            '    Case "NORMAL"
            '        selectedCt = ucNormal.intSelectedCount
            'End Select

            If selectedCt > intMaxSeatCount Then
                numAdult.Value = intAdultCt
                numChild.Value = intChildCt
                numSenior.Value = intSeniorCt
                Throw New Exception("The number of selected seats has exceeded the range. Please remove the seat selected to proceed with this action.")
                'ElseIf ucNormal.intSelectedCount = intMaxSeatCount Then

            Else
                intAdultCt = CInt(numAdult.Value)
                intChildCt = CInt(numChild.Value)
                intSeniorCt = CInt(numSenior.Value)

                intMaxSeatCount = intAdultCt + intChildCt + intSeniorCt

                DisplaySelectedTicketCount()
            End If

            '        End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub numTicketDetails_GotFocus(sender As Object, e As EventArgs) Handles numAdult.GotFocus, numChild.GotFocus, numSenior.GotFocus
        intAdultCt = Convert.ToInt32(numAdult.Value)
        intChildCt = Convert.ToInt32(numChild.Value)
        intSeniorCt = Convert.ToInt32(numSenior.Value)
    End Sub

    Private Sub DisplaySelectedTicketCount()
        lblCount.Text = String.Format("{0} of {1} selected", CurrentTransaction.strSeatSelected.Count, intMaxSeatCount)

        'Select Case CurrentSchedule.sch.Hall.Hall_Type.ToUpper
        '    Case "GRAND"
        '        lblCount.Text = String.Format("{0} of {1} selected", ucGrand.intSelectedCount, intMaxSeatCount)
        '    Case "NORMAL"
        '        lblCount.Text = String.Format("{0} of {1} selected", ucNormal.intSelectedCount, intMaxSeatCount)
        'End Select
    End Sub

    Private Function IsExceededRange() As Boolean 'Return -1:Smaller(still can add seat), 0:Same(no), 1:Larger(no)
        Return If(CurrentTransaction.strSeatSelected.Count >= intMaxSeatCount, True, False)

        'Select Case CurrentSchedule.sch.Hall.Hall_Type.ToUpper
        '    Case "GRAND"
        '        If ucGrand.intSelectedCount > intMaxSeatCount Then
        '            Return True
        '        End If
        '    Case "NORMAL"
        '        If ucNormal.intSelectedCount > intMaxSeatCount Then
        '            Return True
        '        End If
        'End Select
        'Return False
    End Function

    Private Sub frmTicketing_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateSeats()
        'btnRefresh_Click(Nothing, Nothing)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmTicketing_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
        frmShowMovie.Show()
    End Sub

    Private Sub picTicketDetails_Click(sender As Object, e As EventArgs) Handles picTicketDetails.Click
        frmTicketPrice.ShowDialog()
    End Sub

    Private Sub picTicketDetails_MouseHover(sender As Object, e As EventArgs) Handles picTicketDetails.MouseHover
        picTicketDetails.Image = My.Resources.information_icon
    End Sub

    Private Sub picTicketDetails_MouseLeave(sender As Object, e As EventArgs) Handles picTicketDetails.MouseLeave
        picTicketDetails.Image = My.Resources.information_icon_grey
    End Sub

    Private Sub mnuFileAccount_Click(sender As Object, e As EventArgs) Handles mnuFileAccount.Click
        With frmStaffDetails
            .SelectedId = frmShowMovie.staffId
            .Text = "My Account"
            .lblTitle.Text = "My Account"
            .cboStaffStatus.Enabled = False
            .cboStaffRole.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub mnuFileLogout_Click(sender As Object, e As EventArgs) Handles mnuFileLogout.Click
        If frmShowMovie.staffId = Nothing Then
            frmStaffLogin.ShowDialog()
        ElseIf mnuFileLogout.Text.Contains("Logout") Then
            mnuFileLogout.Text = "Login"
            mnuTransaction.Enabled = False
            mnuManagement.Enabled = False
            mnuFileAccount.Visible = False
            frmShowMovie.UcStaffHeader1.staffPic.Image = My.Resources.default_profile_pic
            frmShowMovie.UcStaffHeader1.Label1.Text = "Please login to perform an action..."
            frmShowMovie.UcStaffHeader1.lblLoginNow.Visible = True
            frmShowMovie.staffId = Nothing
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmAboutPage.ShowDialog()
    End Sub

    Private Sub mnuTransactionNew_Click(sender As Object, e As EventArgs) Handles mnuTransactionNew.Click
        Dim result As DialogResult = MessageBox.Show("You are already in the process of creating new transaction, continue with this action will clear all data associated with this transaction", "King's Cinema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            frmShowMovie.Show()
            Me.Dispose()
            Me.Dispose()
        End If
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
