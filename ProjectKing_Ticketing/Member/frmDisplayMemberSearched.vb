Public Class frmDisplayMemberSearched
    Public SelectedMemberID As String

    Private Sub DiaplayMemberSearched_Load(sender As Object, e As EventArgs) Handles Me.Load

        MyBase.Activate()

        Dim timeFormat As String = "dd/MM/yyyy"

        Dim db As New KingDBDataContext()
        Dim m = db.Members.FirstOrDefault(Function(o) o.Member_Id = SelectedMemberID)

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MemberImage\")
        Dim mImg_In_mImgFolder As String = System.IO.Path.Combine(path, m.Member_Photo)

        lblMemberID.Text = m.Member_Id
        picProfilePicture.Image = Image.FromFile(mImg_In_mImgFolder)
        lblFullName.Text = m.Member_Name
        lblPIN.Text = m.Member_PIN.ToString("******")
        lblICNO.Text = "XXXXXX-XX-" & m.Member_ICNO.Substring(10)
        lblContactNo.Text = "XXX-XXX " & m.Member_MobileNo.Substring(7)
        lblEmail.Text = m.Member_Email
        lblRewardPoint.Text = m.Member_RewardPoint.ToString()
        lblRewardPointExpDate.Text = m.Member_RewardPointExp.ToString(timeFormat)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMemberList.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmUpdateMemberProfile.SelectedMemberIdToUpdate = lblMemberID.Text
        Me.Hide()
        frmUpdateMemberProfile.ShowDialog()
    End Sub

    Private Sub LinklblForgetPIN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblForgetPIN.LinkClicked
        frmVerifyIC.Show()
    End Sub
End Class