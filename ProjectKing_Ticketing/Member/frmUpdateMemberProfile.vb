Imports System.Text.RegularExpressions

Public Class frmUpdateMemberProfile

    Public SelectedMemberIdToUpdate As String

    Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MemberImage\")


    Private Sub UpdateMemberProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim timeFormat As String = "dd/MM/yyyy"

        Dim db As New KingDBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = SelectedMemberIdToUpdate)

        Dim mImg_In_mImgFolder As String = System.IO.Path.Combine(path, m.Member_Photo)

        If m Is Nothing Then
            MessageBox.Show("Sorry, member record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return

        Else
            lblMemberID.Text = m.Member_Id
            picProfilePicture.Image = Image.FromFile(mImg_In_mImgFolder)
            lblFullName.Text = m.Member_Name
            lblPIN.Text = m.Member_PIN.ToString("******")
            lblICNO.Text = "XXXXXX-XX-" & m.Member_ICNO.Substring(10)
            mskMobileNo.Text = m.Member_MobileNo
            txtEmail.Text = m.Member_Email
            lblRewardPoint.Text = m.Member_RewardPoint.ToString()
            lblRewardPointExpDate.Text = m.Member_RewardPointExp.ToString(timeFormat)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim db As New KingDBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = SelectedMemberIdToUpdate)

        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim validEmail As New Regex(regex.ToString())

        Dim mImg_In_mImgFolder As String = System.IO.Path.Combine(path, m.Member_Photo)

        Try
            If Not mskMobileNo.MaskCompleted Then
                MessageBox.Show("Invalid contact no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            ElseIf txtEmail.Text = "" Then
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf Not regex.IsMatch(txtEmail.Text.Trim) Then
                MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            ElseIf isDuplicatedEmail(txtEmail.Text) = False Or m.Member_Email.Equals(txtEmail.Text) Then
                m.Member_MobileNo = mskMobileNo.Text
                m.Member_Email = txtEmail.Text

                db.SubmitChanges()
                MessageBox.Show("Member profile updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                frmDisplayMemberSearched.Show()
                Me.Close()
            Else
                MessageBox.Show("Email has been used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMemberList.Show()
        Me.Close()
    End Sub

    Function isDuplicatedEmail(email As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Members.Any(Function(o) o.Member_Email = txtEmail.Text)

    End Function
End Class