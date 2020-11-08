Public Class frmViewStaff
    Private mRow As Integer = 0
    Private newpage As Boolean = True

    Private Sub staffBindData()
        Dim name As String = txtStaffName.Text.Trim()
        Dim staffStatus As String = cboStaffStatus.Text
        Dim staffRole As String = cboStaffRole.Text
        Dim staffStartDate As DateTime = dtpStaffStartDate.Value
        Dim status As String

        If staffStatus = "Active Staff" Then
            status = "Active"
        Else 'If staffStatus = "Resigned Staff" Then
            status = "Inactive"
        End If

        Dim db As New KingDBDataContext()

        If chkActivateDate.Checked = False Then
            dtpStaffStartDate.Enabled = False
            Dim staffDetails = From o In db.Staffs
                               Select o.Staff_Id, o.Staff_Name, o.Staff_Phone, o.Staff_Role, o.Staff_Status, o.Staff_StartDate
                               Where Staff_Name.Contains(name) And (staffStatus = "All Staff" Or Staff_Status.Equals(status)) And (staffRole = "All Staff" Or Staff_Role.Equals(staffRole))

            staffDGV.DataSource = staffDetails
        Else
            dtpStaffStartDate.Enabled = True
            Dim staffDetails = From o In db.Staffs
                               Select o.Staff_Id, o.Staff_Name, o.Staff_Phone, o.Staff_Role, o.Staff_Status, o.Staff_StartDate
                               Where Staff_Name.Contains(name) And (staffStatus = "All Staff" Or Staff_Status.Equals(status)) And (staffRole = "All Staff" Or Staff_Role.Equals(staffRole)) And Staff_StartDate.Month.Equals(staffStartDate.Month) And Staff_StartDate.Year.Equals(staffStartDate.Year)

            staffDGV.DataSource = staffDetails
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStaffStatus.SelectedItem = "All Staff"
        cboStaffRole.SelectedItem = "All Staff"
        dtpStaffStartDate.Format = DateTimePickerFormat.Custom
        dtpStaffStartDate.CustomFormat = "MMMM"
        staffBindData()
    End Sub

    Private Sub txtStaffName_TextChanged(sender As Object, e As EventArgs) Handles txtStaffName.TextChanged
        staffBindData()
    End Sub

    Private Sub cboStaffStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStaffStatus.SelectedIndexChanged
        staffBindData()
    End Sub

    Private Sub staffDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles staffDGV.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(staffDGV.Rows(i).Cells(0).Value)
            frmStaffDetails.SelectedId = id
            frmStaffDetails.cboStaffRole.Enabled = True
            frmStaffDetails.cboStaffStatus.Enabled = True
            frmStaffDetails.lblTitle.Text = "Staff Details"
            frmStaffDetails.Text = "Staff Details"
            frmStaffDetails.ShowDialog(Me)
            staffBindData()
        End If
    End Sub

    Private Sub dtpStaffStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStaffStartDate.ValueChanged
        staffBindData()
    End Sub

    Private Sub cboStaffRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStaffRole.SelectedIndexChanged
        staffBindData()
    End Sub

    Private Sub chkActivateDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivateDate.CheckedChanged
        staffBindData()
    End Sub

    Private Sub StaffDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles StaffDoc.PrintPage
        Dim fontKingCinemaTitle As New Font("Calibri", 26, FontStyle.Bold)
        Dim fontKingCinemaAddress As New Font("Calibri", 12, FontStyle.Bold)
        Dim fontKingCinemaPhone_Email As New Font("Calibri", 12, FontStyle.Regular)

        Dim fontHeader As New Font("Calibri", 20, FontStyle.Underline)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontCount As New Font("Consolas", 10)
        Dim itemcount As Integer = staffDGV.Rows.Count()

        Dim kingCinemaTitle = String.Format("Kings Cinema")
        Dim kingCinemaAddress As String = String.Format("7A, Jalan SS4D/2, People's Park, " & vbNewLine & "47301 Petaling Jaya, Selangor.")
        Dim kingCinemaPhone_Email As String = String.Format("Phone: 03-52667266     Email: Kingciname12@gmail.com")

        Dim header As String = String.Format("          {0:MMMM yyyy} Active Staff Report", DateTime.Now)
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
            row = staffDGV.Rows(mRow)
            x = e.MarginBounds.Left

            For Each cell As DataGridViewCell In row.Cells

                If cell.Visible Then
                    rc = New Rectangle(x, 250, 110, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case staffDGV.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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

                    e.Graphics.DrawString(staffDGV.Columns(cell.ColumnIndex).HeaderText.Replace("_", " ").Replace("StartDate", "Start Date"),
                                            staffDGV.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            'y += h
            y = 270

        End If
        newpage = False

        Dim thisNDX As Int32
        For thisNDX = mRow To staffDGV.RowCount - 1
            If staffDGV.Rows(thisNDX).IsNewRow Then Exit For

            row = staffDGV.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            'x = e.MarginBounds.Left

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, 110, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case staffDGV.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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
                                          staffDGV.Font, Brushes.Black, rc, fmt)

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
        DocPreview.Document = StaffDoc
        DocPreview.ShowDialog(Me)
    End Sub

End Class