Public Class ucStaffHeader
    Private Sub timeCurrentTime_Tick(sender As Object, e As EventArgs) Handles timeCurrentTime.Tick
        Dim d As Date = Date.Now
        lblCurrentDate.Text = d.ToLongDateString
        lblCurrentTime.Text = d.ToString("h:mm:ss tt")
    End Sub

    Private Sub ucStaffHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeCurrentTime.Start()
    End Sub

    Private Sub lblLoginNow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLoginNow.LinkClicked
        frmStaffLogin.ShowDialog()
    End Sub

    Private Sub staffPic_Click(sender As Object, e As EventArgs) Handles staffPic.Click

        If frmShowMovie.staffId = Nothing Then
            MessageBox.Show("Please login to perform this action.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With frmStaffDetails
                .SelectedId = frmShowMovie.staffId
                .Text = "My Account"
                .lblTitle.Text = "My Account"
                .cboStaffStatus.Enabled = False
                .cboStaffRole.Enabled = False
                .ShowDialog()
            End With
        End If

    End Sub
End Class
