Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Text
Imports BarcodeLib

Public Class frmPayment
    Friend blnIsPaid As Boolean = False
    Friend blnIsPrint As Boolean = False
    Friend blnIsMember As Boolean = False
    Friend blnIsRefund As Boolean = False
    Friend decAmtPayable As Decimal

    Private intAdultCt As Integer
    Private intChildCt As Integer
    Private intSeniorCt As Integer
    Private ticketTypeList() As Ticket = {Nothing}

    Private Const decSERVICE_TAX_RATE As Decimal = 0.06D
    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click, Button1.Click
        decAmtPayable = CDec(lblGrandTotal.Text)
        Select Case cboPaymentMethod.SelectedItem.ToString
            Case "Cash"
                With frmCashPayment
                    .lblPayable.Text = decAmtPayable.ToString("F2")
                    .ShowDialog()
                End With
            Case "Credit/Debit Card"
                With frmCardPayment
                    .lblPayable.Text = decAmtPayable.ToString("F2")
                    .ShowDialog()
                End With
            Case Else
                MessageBox.Show("Payment method is not selected. Please select one of the payment method to proceed to payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

    End Sub

    Private Sub tabMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMember.SelectedIndexChanged
        Dim int As Integer = tabMember.SelectedIndex
        If tabMember.SelectedIndex = 1 And blnIsMember Then
            GetCurrentMember()
        ElseIf tabMember.SelectedIndex = 1 Then 'Member Tab is selected
            lblMemberID.Text = "N/A"
            lblAvailablePoints.Text = "N/A"
            frmSearchMember.ShowDialog() 'SHOULD FIRE frmSearchMember from CHUNKIT 
        Else 'tabMember.SelectedIndex = 0
            CurrentTransaction.currentMemberId = Nothing
            blnIsMember = False
        End If
    End Sub

    Private Sub GetCurrentMember()
        Dim db As New KingDBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = CurrentTransaction.currentMemberId)

        lblMemberID.Text = m.Member_Id
        lblAvailablePoints.Text = m.Member_RewardPoint.ToString
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New KingDBDataContext
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MovieImage\")
        Dim m = CType((From p In db.Movies Select p Where p.Movie_Title.Equals(CurrentSchedule.ToMovieString)).Single(), Movie)

        Dim PicInFolder As String = System.IO.Path.Combine(path, m.Movie_Image)
        picBoxMov.Image = Image.FromFile(PicInFolder)

        GetTicketTypeList() 'Load all ticketType to private var

        cboPaymentMethod.SelectedIndex = 0 'Default payment method: Cash

        'Movie Details
        lblMovie.Text = CurrentSchedule.ToMovieString
        lblShowTime.Text = CurrentSchedule.ToStartTimeString
        lblHall.Text = CurrentSchedule.ToHallString

        'Ticket Details
        intAdultCt = CInt(frmTicketing.numAdult.Value)
        Dim decAdultPricePer As Decimal = 14D
        intChildCt = CInt(frmTicketing.numChild.Value)
        Dim decChildPricePer As Decimal = 9D
        intSeniorCt = CInt(frmTicketing.numSenior.Value)
        Dim decSeniorPricePer As Decimal = 10D

        Dim decAdultTotalPrice As Decimal = intAdultCt * decAdultPricePer
        Dim decChildTotalPrice As Decimal = intChildCt * decChildPricePer
        Dim decSeniorTotalPrice As Decimal = intSeniorCt * decSeniorPricePer

        txtSeats.Text = frmTicketing.txtSeats.Text
        lblAdultQty.Text = If(intAdultCt = 0, "N/A", intAdultCt.ToString)
        lblAdultPrice.Text = decAdultTotalPrice.ToString("F2")
        lblChildQty.Text = If(intChildCt = 0, "N/A", intChildCt.ToString)
        lblChildPrice.Text = decChildTotalPrice.ToString("F2")
        lblSeniorQty.Text = If(intSeniorCt = 0, "N/A", intSeniorCt.ToString)
        lblSeniorPrice.Text = decSeniorTotalPrice.ToString("F2")
        Dim decIicketPrice As Decimal = decAdultTotalPrice + decChildTotalPrice + decSeniorTotalPrice
        lblTotalPriceInTicket.Text = decIicketPrice.ToString("F2")

        'Payment Details
        Dim decServTax As Decimal = decIicketPrice * decSERVICE_TAX_RATE
        Dim decTotal As Decimal = decIicketPrice + decServTax
        Dim decDiscount As Decimal = 0D 'Need to get from member module
        Dim decGrandTotal As Decimal = decTotal + decDiscount
        lblTicketPrice.Text = decIicketPrice.ToString("F2")

        lblServTax.Text = decServTax.ToString("F2")
        lblTotal.Text = decTotal.ToString("F2")
        lblDiscount.Text = decDiscount.ToString("F2")
        lblGrandTotal.Text = decGrandTotal.ToString("F2")

        decAmtPayable = decGrandTotal 'Save to Friend variable to allow frmPay from accessing the amt to be paid

        'UPDATE VALUE TO CurrentTransaction.vb
        UpdateCurrentTransaction()
    End Sub

    Private Sub UpdateCurrentTransaction()
        'trx_id will be generated when insert to db
        With CurrentTransaction.trx
            'Trx
            .Schedule_Id = CurrentSchedule.sch.Schedule_Id
            .Transaction_Status = "In Progress"
            .Amount_Payable = decAmtPayable
            .Points_Earned = 1000
        End With

        'Trx_Dets
        For seatCt As Integer = 1 To frmTicketing.intMaxSeatCount
            Dim trxDet As New Transaction_Detail()
            With trxDet
                .Seat_No = CurrentTransaction.strSeatSelected(seatCt - 1)
            End With
            CurrentTransaction.trxDetsList.Add(trxDet)
        Next

        'Tic_Dets
        If intAdultCt <> 0 Then
            Dim ticDetAdult As New Ticket_Detail()
            With ticDetAdult
                .Ticket = ticketTypeList(0) 'Adult
                .Quantity = intAdultCt
                .Ticket_Price = ticketTypeList(0).Ticket_Price
            End With
            CurrentTransaction.ticDetsList.Add(ticDetAdult)
        End If

        If intChildCt <> 0 Then
            Dim ticDetChild As New Ticket_Detail()
            With ticDetChild
                .Ticket = ticketTypeList(1) 'Child
                .Quantity = intChildCt
                .Ticket_Price = ticketTypeList(1).Ticket_Price
            End With
            CurrentTransaction.ticDetsList.Add(ticDetChild)
        End If

        If intSeniorCt <> 0 Then
            Dim ticDetSenior As New Ticket_Detail()
            With ticDetSenior
                .Ticket = ticketTypeList(2) 'Senior
                .Quantity = intSeniorCt
                .Ticket_Price = ticketTypeList(2).Ticket_Price
            End With
            CurrentTransaction.ticDetsList.Add(ticDetSenior)
        End If

    End Sub

    Private Sub GetTicketTypeList() 'Get ALL 3 types of ticket
        Try
            Dim db As New KingDBDataContext
            Dim rs = From o In db.Tickets
            ticketTypeList = rs.ToArray
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPayment_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If blnIsPaid Then
            'If the transaction isPaid, then disable tabMember and btnPay
            With btnPayNow
                .Enabled = False
                .Text = "Paid"
            End With

            With btnPrint
                .Enabled = True
                btnPrint.Focus()
            End With

            btnRefund.Enabled = True
            tabMember.Enabled = False
            grpMovieDetails.Enabled = False
            grpNoTicket.Enabled = False
            grpPaymentDetails.Enabled = False
            lblMsgBox.Text = "Please proceed to print ticket(s)!"
        Else
            With btnPayNow
                .Enabled = True
                .Text = "&Pay Now"
            End With

            With btnPrint
                .Enabled = False
            End With

            btnRefund.Enabled = False
            tabMember.Enabled = True
            grpMovieDetails.Enabled = True
            grpNoTicket.Enabled = True
            grpPaymentDetails.Enabled = True
            lblMsgBox.Text = "Please confirm the transaction with customer before proceed to payment!"
        End If

        If blnIsMember Then 'If member is passed back, display tabMember, else tabGuest
            tabMember.SelectedIndex = 1

            GetCurrentMember()
            If CInt(lblAvailablePoints.Text) < 1000 Then
                cboPtsAction.Enabled = False
            Else
                cboPtsAction.Enabled = True
            End If
        Else
            tabMember.SelectedIndex = 0
        End If

        If blnIsRefund Then
            btnRefund.Enabled = False
            Me.Dispose()
            frmShowMovie.Show()
        End If

        If blnIsPaid And blnIsPrint Then
            btnBack.Text = "&Back to Main Page"
        Else
            btnBack.Text = "&Back"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "&Back" Then
            Me.Close()
        Else 'btnBack.Text = "&Back to Main Page"
            frmShowMovie.Show()
            frmTicketing.Dispose()
            Me.Dispose()
        End If

    End Sub

    Private Sub frmPayment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If blnIsPaid And Not blnIsPrint Then
            Dim result As DialogResult = MessageBox.Show("Form cannot be closed, please proceed to print ticket(s).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If result = DialogResult.OK Then
                e.Cancel = True
            End If
        Else
            CurrentTransaction.trx = New Transaction
            CurrentTransaction.trxDetsList = New List(Of Transaction_Detail)
            CurrentTransaction.ticDetsList = New List(Of Ticket_Detail)
        End If
    End Sub

    Private Sub frmPayment_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With frmTicketing
            .isNewTransaction = False
            .Show()
        End With
    End Sub

    Private Sub docTicket_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docTicket.PrintPage
        '(1) Fonts
        Dim fontTitle As New Font("Consolas", 34, FontStyle.Bold)
        Dim fontShowingTime As New Font("Consolas", 30, FontStyle.Regular)
        Dim fontPrinted As New Font("Consolas", 10, FontStyle.Regular)
        Dim fontHall As New Font("Consolas", 136, FontStyle.Bold)
        Dim fontSeat As New Font("Consolas", 40, FontStyle.Bold)

        Dim fontPrice As New Font("Consolas", 11, FontStyle.Regular)

        Dim fontSmallTitle As New Font("Consolas", 18, FontStyle.Bold)
        Dim fontSmallShowingTime As New Font("Consolas", 17, FontStyle.Regular)
        Dim fontSmallPrinted As New Font("Consolas", 7, FontStyle.Regular)
        Dim fontSmallHall As New Font("Consolas", 78, FontStyle.Bold)
        Dim fontSmallSeat As New Font("Consolas", 22, FontStyle.Bold)

        '(2) Prepare header and sub-header
        'Dim subHeader As String = String.Format(
        '"Printed on {0:dd MMMM yyyy hh:mm:ss tt}" & vbNewLine &
        '"Generated by King's Cinema [StaffID]", DateTime.Now)

        Dim movieTitle As String = CurrentSchedule.ToMovieString.ToUpper
        If movieTitle.Length > 14 Then
            movieTitle = movieTitle.Substring(0, 14)
        End If

        Dim showingTime As New StringBuilder()
        showingTime.AppendLine(CurrentSchedule.sch.Schedule_Date.ToShortDateString)

        Dim startTime As DateTime = DateTime.Today.Add(CurrentSchedule.sch.Start_Time)
        showingTime.AppendLine(String.Format("{0:h:mmtt}", startTime))

        Dim hallNo As String = CurrentSchedule.sch.Hall_Id.ToString

        Dim printDateTime As DateTime = DateTime.Now
        Dim strPrintDateTime As String = "Printed on " & printDateTime.ToShortDateString & " " & printDateTime.ToShortTimeString 'Printed on 14/04/2020 11:59 PM

        Dim ticketPrice As New StringBuilder
        If lblAdultQty.Text = "N/A" Then
            ticketPrice.AppendLine()
        Else
            ticketPrice.AppendLine("ADULT   x " & lblAdultQty.Text)
        End If

        If lblChildQty.Text = "N/A" Then
            ticketPrice.AppendLine()
        Else
            ticketPrice.AppendLine("CHILD   x " & lblChildQty.Text)
        End If

        If lblSeniorQty.Text = "N/A" Then
            ticketPrice.AppendLine()
        Else
            ticketPrice.AppendLine("SR CTZ. x " & lblSeniorQty.Text)
        End If

        ticketPrice.AppendLine()
        ticketPrice.AppendLine("Payment Method   : " & cboPaymentMethod.SelectedItem.ToString)
        ticketPrice.AppendLine("Grand Total      : RM" & lblGrandTotal.Text)

        If CurrentTransaction.currentMemberId IsNot Nothing Then
            Dim db As New KingDBDataContext()
            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = CurrentTransaction.currentMemberId)
            ticketPrice.AppendLine("Remaining Points : " & m.Member_RewardPoint & " pts")
        End If

        'DrawPen
        Dim drawPenHori As New Pen(Color.Gray, 4)
        drawPenHori.DashStyle = Drawing2D.DashStyle.DashDot

        Dim drawPenVert As New Pen(Color.Gray, 4)
        drawPenVert.DashStyle = Drawing2D.DashStyle.Dot

        'Vertical printedDate on left-side ticket
        Dim drawFormat As New StringFormat
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical

        With e.Graphics
            '.DrawLine(drawPenD, 0, 0, 823, 0) '595points x 842 points (A4 paper)
            Dim intOffset As Single = 0
            For count As Integer = 1 To CurrentTransaction.strSeatSelected.Count

                Dim seatNo As String = CurrentTransaction.strSeatSelected(count - 1)
                seatNo = seatNo.Substring(0, 1) & "-" & seatNo.Substring(1) 'Add dash(-) to seatNo, A04 --> A-04

                Dim imgBarcode As Image = GenerateBarcode(RandomBarcodeValue())
                imgBarcode.RotateFlip(RotateFlipType.Rotate90FlipNone)

                'Right side large ticket
                .DrawImage(My.Resources.kings_cinema_400px, 140, 25 + intOffset, 282, 240)
                .DrawImage(imgBarcode, 0, 2 + intOffset, 70, 285)

                .DrawString(movieTitle, fontTitle, Brushes.Black, 70, 40 + intOffset)
                .DrawString(showingTime.ToString, fontShowingTime, Brushes.Black, 70, 110 + intOffset)
                .DrawString(hallNo, fontHall, Brushes.Black, 430, -20 + intOffset)
                .DrawString(seatNo, fontSeat, Brushes.Black, 440, 170 + intOffset)
                .DrawString(strPrintDateTime, fontPrinted, Brushes.Black, 70, 270 + intOffset)

                .DrawString(ticketPrice.ToString, fontPrice, Brushes.Black, 320, 162 + intOffset)

                'Left side small ticket
                .DrawImage(My.Resources.kings_cinema_400px, 630, 50 + intOffset, 169.2, 144)
                imgBarcode.RotateFlip(RotateFlipType.Rotate270FlipNone)
                .DrawImage(imgBarcode, 603, 233 + intOffset, 222.3, 54.6)

                .DrawString(movieTitle, fontSmallTitle, Brushes.Black, 610, 25 + intOffset)
                .DrawString(showingTime.ToString, fontSmallShowingTime, Brushes.Black, 610, 55 + intOffset)
                .DrawString(hallNo, fontSmallHall, Brushes.Black, 740, 110 + intOffset)
                .DrawString(seatNo, fontSmallSeat, Brushes.Black, 680, 182 + intOffset)
                .DrawString(strPrintDateTime, fontSmallPrinted, Brushes.Black, 600, 2 + intOffset, drawFormat)

                'Vertical line
                .DrawLine(drawPenVert, 600, 0, 600, 289.25F + intOffset) '1169)
                .DrawLine(drawPenHori, 0, 289.25F + intOffset, 826, 289.25F + intOffset)
                intOffset += 293.25F
                e.HasMorePages = True
            Next
            e.HasMorePages = False

            'Horizontal line
            '.DrawLine(drawPenHori, 0, 289.25, 826, 289.25) '595points x 842 points (A4 paper)
            '.DrawLine(drawPenHori, 0, 582.5, 826, 582.5) '826.6666points x 1169.3333 points (A4 paper)
            '.DrawLine(drawPenHori, 0, 875.75, 826, 875.75) '826.6666points x 1169.3333 points (A4 paper)
        End With

    End Sub

    Private Function RandomBarcodeValue() As String
        Dim randomNumber As Double

        Randomize()
        randomNumber = ((100000000000 * Rnd()) + 10000000000)

        Return randomNumber.ToString("F0")
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, Button2.Click
        With dlgPreviewTicket
            'docTicket.DefaultPageSettings.PaperSize = (From s As PaperSize In docTicket.PrinterSettings.PaperSizes.Cast(Of PaperSize) Where s.RawKind = PaperKind.A4).FirstOrDefault
            docTicket.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)
            .Document = docTicket
            .ShowDialog(Me)
        End With
    End Sub
    Private Function GenerateBarcode(barcodeValue As String) As Image
        Dim barcode As New Barcode
        Dim foreColor As Color = Color.Black
        Dim backColor As Color = Color.White
        Dim image As Image = barcode.Encode(TYPE.UPCA, barcodeValue, foreColor, backColor, 285, 70)
        Return image
    End Function

    Private Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click, Button3.Click
        '1. Prompt Manager to login''''''''''''''''''

        '2. Ask whether confirm to refund to the customer?
        Dim result As DialogResult = MessageBox.Show("Are you sure to cancel this transaction and issue a refund?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then

            Dim result2 As DialogResult = frmRefundValidation.ShowDialog()
            'If result = DialogResult.OK Then
            '    frmRefund.ShowDialog() Then
            'End If
        End If
        '5. Back to Main Page (Not showing frmPayment anymore)
    End Sub

    Private Sub docTicket_EndPrint(sender As Object, e As PrintEventArgs) Handles docTicket.EndPrint
        blnIsPrint = True
    End Sub

    Private Sub cboPtsAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPtsAction.SelectedIndexChanged
        If cboPtsAction.SelectedIndex = 0 Then 'Earn pts
            lblEarnedOrRedeemed.Text = "Points to be Earned :"
            lblEarnOrRedeemPts.Text = CInt(CDec(lblTotal.Text) * 5).ToString 'points earned 'RM 100.00 can earn 500pts
            CurrentTransaction.isEarnPts = True
            CurrentTransaction.memberPointsEarnedOrRedeemed = CInt(CDec(lblTotal.Text) * 5)
            lblDiscount.Text = "0.00"
        Else 'cboPtsAction.SelectedIndex = 1 ==> Redeem pts
            lblEarnedOrRedeemed.Text = "Points to be Redeemed :"

            Dim ptsCanAvailable As Integer = CInt(lblAvailablePoints.Text)
            Dim ptsRedeem As Integer
            If ptsCanAvailable > CInt(CDec(lblTotal.Text) * 100) Then
                ptsRedeem = CInt(CDec(lblTotal.Text) * 100) ' / 100D
            Else
                ptsRedeem = ptsCanAvailable
            End If
            lblDiscount.Text = (ptsRedeem / -100D).ToString("F2") '500 pts can redeem RM 5.00
            lblEarnOrRedeemPts.Text = ptsRedeem.ToString 'points redeemed
            CurrentTransaction.isEarnPts = False
            CurrentTransaction.memberPointsEarnedOrRedeemed = ptsRedeem
        End If
        DisplayGrandTotal()
    End Sub

    Private Sub DisplayGrandTotal()


        Dim decIicketPrice As Decimal = CDec(lblTicketPrice.Text)
        Dim decServTax As Decimal = decIicketPrice * decSERVICE_TAX_RATE
        Dim decTotal As Decimal = decIicketPrice + decServTax
        Dim decDiscount As Decimal = CDec(lblDiscount.Text)
        Dim decGrandTotal As Decimal = decTotal + decDiscount
        lblGrandTotal.Text = decGrandTotal.ToString("F2")

        ''lblEarnOrRedeemPts.Text = lblDiscount.Text
    End Sub

    Private Sub lnkRegMember_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegMember.LinkClicked
        frmRegisterMember.ShowDialog()
    End Sub

    Private Sub picPointsRate_MouseHover(sender As Object, e As EventArgs) Handles picPointsRate.MouseHover
        picPointsRate.Image = My.Resources.information_icon
    End Sub

    Private Sub picPointsRate_MouseLeave(sender As Object, e As EventArgs) Handles picPointsRate.MouseLeave
        picPointsRate.Image = My.Resources.information_icon_grey
    End Sub

    Private Sub picPointsRate_Click(sender As Object, e As EventArgs) Handles picPointsRate.Click
        frmPointsRate.ShowDialog()
    End Sub
    Private Sub mnuFileAccount_Click(sender As Object, e As EventArgs) Handles mnuFileAccount.Click

    End Sub

    Private Sub mnuFileLogout_Click(sender As Object, e As EventArgs) Handles mnuFileLogout.Click

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