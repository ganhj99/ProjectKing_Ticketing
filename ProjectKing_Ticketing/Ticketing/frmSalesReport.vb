Imports System.Drawing.Printing
Imports System.Text
Imports BarcodeLib

Public Class frmSalesReport

    Private PrintForm1 As Object
    Public Property mRow As Integer
    Public Property PrintForm As Object
    Private newPage As Boolean

    Private movieList As New List(Of String)
    Private dateFrom As Date = Date.Now.AddMonths(-1)
    Private dateTo As Date = Date.Now

    Private Sub BindData()
        Dim db As New KingDBDataContext()

        Dim rs = From t In db.Transactions
                 Where t.Transaction_Date >= dtpFrom.Value And t.Transaction_Date <= dtpTo.Value And t.Transaction_Status = "Paid" And (cboMovie.Text = "All Movie" Or t.Schedule.Movie.Movie_Title.Equals(cboMovie.Text))
                 Select New With {
                     .Date = t.Transaction_Date, .ID = t.Transaction_Id, .Pay_Method = t.Payment_Method, .Total_Price_In_RM = t.Amount_Payable, .Operated_By = t.Staff_Id
                     }

        dgvResults.DataSource = rs
        'Where o.Member_JoinedDate.Month.Equals(dtpicker.Value.Month) And o.Member_JoinedDate.Year.Equals(dtpicker.Value.Year)
        'Select Case New With {
        '                 .ID = o.Member_Id, .Name = o.Member_Name, .Email = o.Member_Email, .JoinDate = o.Member_JoinedDate
        '        }
        'dgvMember.DataSource = rs

        'lblCMRM.Text = rs.Count().ToString("There are 0 customer(s) registered King Cinema membership.")
    End Sub

    Private Sub docTicket_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docTicket.PrintPage


        Dim fontKingCinemaTitle As New Font("Calibri", 26, FontStyle.Bold)
        Dim fontKingCinemaAddress As New Font("Calibri", 12, FontStyle.Bold)
        Dim fontKingCinemaPhone_Email As New Font("Calibri", 12, FontStyle.Regular)

        Dim fontHeader As New Font("Calibri", 17, FontStyle.Underline)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontCount As New Font("Consolas", 10)
        Dim itemcount As Integer = dgvResults.Rows.Count()

        Dim kingCinemaTitle = String.Format("Kings Cinema")
        Dim kingCinemaAddress As String = String.Format("7A, Jalan SS4D/2, People's Park, " & vbNewLine & "47301 Petaling Jaya, Selangor.")
        Dim kingCinemaPhone_Email As String = String.Format("Phone: 03-52667266     Email: Kingcinema12@gmail.com")

        Dim header As String = String.Format("Sales Report based on {0} from {1:dd MMM yyyy} to {2:dd MMM yyyy}", cboMovie.Text, dtpFrom.Value, dtpTo.Value)
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim body As String = String.Format("{0} record(s)", itemcount)

        With e.Graphics
            .DrawImage(My.Resources.kings_cinema_gold, 400, 0, 115, 100)
            .DrawString(kingCinemaTitle, fontKingCinemaTitle, Brushes.Black, 340, 90)
            .DrawString(kingCinemaAddress, fontKingCinemaAddress, Brushes.Black, 328, 135)
            .DrawString(kingCinemaPhone_Email, fontKingCinemaPhone_Email, Brushes.Black, 250, 180)
            .DrawString(header, fontHeader, Brushes.Black, 80, 210)
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


        If newPage Then
            row = dgvResults.Rows(mRow)
            x = e.MarginBounds.Left

            For Each cell As DataGridViewCell In row.Cells

                If cell.Visible Then
                    rc = New Rectangle(x, 250, 130, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvResults.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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

                    e.Graphics.DrawString(dgvResults.Columns(cell.ColumnIndex).HeaderText.Replace("_", " ").Replace("In RM", "(RM)"),
                                            dgvResults.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y = 270

        End If
        newPage = False

        Dim thisNDX As Int32
        For thisNDX = mRow To dgvResults.RowCount - 1
            If dgvResults.Rows(thisNDX).IsNewRow Then Exit For

            row = dgvResults.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            x = e.MarginBounds.Left

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, 130, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvResults.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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
                                          dgvResults.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newPage = True
                Return
            End If
        Next

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs)

        With dlgPreviewTicket
            'docTicket.DefaultPageSettings.PaperSize = (From s As PaperSize In docTicket.PrinterSettings.PaperSizes.Cast(Of PaperSize) Where s.RawKind = PaperKind.A4).FirstOrDefault
            docTicket.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

            .Document = docTicket
            .ShowDialog(Me)
        End With
    End Sub


    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMovieList()

        dtpFrom.Value = dateFrom 'DateFrom set to 1 month before today
        dtpTo.Value = dateTo 'DateTo set to today

        dtpFrom.MaxDate = Date.Now
        dtpTo.MaxDate = Date.Now

        cboMovie.Items.Clear()
        cboMovie.Items.Add("All Movie")
        For Each movie As String In movieList
            cboMovie.Items.Add(movie)
        Next
        cboMovie.SelectedIndex = 0

    End Sub

    Private Sub GetMovieList()
        Dim db As New KingDBDataContext
        Dim rs = From m In db.Movies
                 Select m.Movie_Title

        movieList = rs.ToList
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged
        Try
            If dtpFrom.Value > dtpTo.Value Then
                dtpFrom.Value = dateFrom
                dtpTo.Value = dateTo
                Throw New Exception("Invalid date range, please try again.")
            Else
                dateFrom = dtpFrom.Value
                dateTo = dtpTo.Value
                BindData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        mRow = 0
        newPage = True
        dlgPreviewTicket.Document = docTicket
        dlgPreviewTicket.ShowDialog(Me)
    End Sub


    Private Sub cboMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged
        BindData()
    End Sub

End Class