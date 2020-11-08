Public Class frmMonthlyMovieScheduleReport


    Private PrintForm1 As Object
    Public Property mRow As Integer
    Public Property PrintForm As Object

    Dim newpage As Boolean

    Private Sub BindData()
        Dim db As New KingDBDataContext()

        Dim rs = From s In db.Schedules
                 Join m In db.Movies On s.Movie_Id Equals m.Movie_Id
                 Where s.Schedule_Date.Month.Equals(dtpicker.Value.Month) And s.Schedule_Date.Year.Equals(dtpicker.Value.Year) And s.Schedule_Status = "Available"
                 Group s By m.Movie_Title, m.Movie_Rating Into Total_Schedule = Count()
                 Order By Total_Schedule Descending

        dgvMovieSchedule.DataSource = rs

        lblCMRM.Text = rs.Count().ToString("0 record(s) found")
    End Sub

    Private Sub docMember_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docMember.PrintPage
        Dim fontKingCinemaTitle As New Font("Calibri", 26, FontStyle.Bold)
        Dim fontKingCinemaAddress As New Font("Calibri", 12, FontStyle.Bold)
        Dim fontKingCinemaPhone_Email As New Font("Calibri", 12, FontStyle.Regular)

        Dim fontHeader As New Font("Calibri", 20, FontStyle.Underline)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontCount As New Font("Consolas", 10)
        Dim itemcount As Integer = dgvMovieSchedule.Rows.Count()

        Dim kingCinemaTitle = String.Format("Kings Cinema")
        Dim kingCinemaAddress As String = String.Format("7A, Jalan SS4D/2, People's Park, " & vbNewLine & "47301 Petaling Jaya, Selangor.")
        Dim kingCinemaPhone_Email As String = String.Format("Phone: 03-52667266     Email: Kingciname12@gmail.com")

        Dim header As String = String.Format("{0:MMMM yyyy} Movie Schedule Report", DateTime.Now)
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim body As String = String.Format("{0} record(s)", itemcount)

        With e.Graphics
            .DrawImage(My.Resources.kings_cinema_gold, 400, 0, 115, 100)
            .DrawString(kingCinemaTitle, fontKingCinemaTitle, Brushes.Black, 340, 90)
            .DrawString(kingCinemaAddress, fontKingCinemaAddress, Brushes.Black, 328, 135)
            .DrawString(kingCinemaPhone_Email, fontKingCinemaPhone_Email, Brushes.Black, 250, 180)
            .DrawString(header, fontHeader, Brushes.Black, 200, 210)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 1000)
            .DrawString(body, fontCount, Brushes.Black, 650, 1000)
        End With

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow


        If newpage Then
            row = dgvMovieSchedule.Rows(mRow)
            x = e.MarginBounds.Left

            For Each cell As DataGridViewCell In row.Cells

                If cell.Visible Then
                    rc = New Rectangle(x, 250, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvMovieSchedule.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgvMovieSchedule.Columns(cell.ColumnIndex).HeaderText.Replace("_", " ").Replace("StartDate", "Start Date"),
                                            dgvMovieSchedule.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y = 274

        End If
        newpage = False

        Dim thisNDX As Int32
        For thisNDX = mRow To dgvMovieSchedule.RowCount - 1
            If dgvMovieSchedule.Rows(thisNDX).IsNewRow Then Exit For

            row = dgvMovieSchedule.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            x = e.MarginBounds.Left

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvMovieSchedule.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                          dgvMovieSchedule.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newpage = True
                Return
            End If
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        mRow = 0
        newpage = True
        dlgPreviewMember.Document = docMember
        dlgPreviewMember.ShowDialog(Me)

    End Sub

    Private Sub MonthlyNewMemberRegisterReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttipPrintReport.SetToolTip(btnPrint, "Print")
        ttipFilterReport.SetToolTip(PictureBox1, "Filter monthly movie schedule report by month or year")
        BindData()

    End Sub

    Private Sub dtpicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker.ValueChanged
        BindData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub
End Class