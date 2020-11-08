Imports System.ComponentModel

Public Class frmSearchMember

    Private m As New Member
    Private Sub filterIC_ContactNo()
        Dim ic As String = mskMemberIC.Text
        Dim contactNo As String = mskMemberContact.Text

        Dim db As New KingDBDataContext()
        m = db.Members.FirstOrDefault(Function(o) o.Member_ICNO = ic Or o.Member_MobileNo = contactNo)

        If m Is Nothing Then
            Throw New KeyNotFoundException("Unable to find a member with the given information, please try again.")
        Else
            showMemberProfile()
        End If
    End Sub

    Private Sub filterID()
        Dim mID As String = mskMemberID.Text
        Dim db As New KingDBDataContext()
        m = db.Members.FirstOrDefault(Function(o) o.Member_Id = mID)

        If m Is Nothing Then
            Throw New KeyNotFoundException("Unable to find a member with the given information, please try again.")
        Else
            showMemberProfile()
        End If
    End Sub

    Private Sub ResetDisplayLabel()
        mskMemberIC.Clear()
        mskMemberContact.Clear()
        mskMemberID.Clear()
        lblMemberID.ResetText()
        picProfilePicture.Image = Nothing
        lblFullName.ResetText()
        lblICNO.ResetText()
        lblContactNo.ResetText()
        lblICNO.ResetText()
        lblEmail.ResetText()
        lblRewardPoint.ResetText()
    End Sub

    Private Sub showMemberProfile()
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MemberImage\")
        Dim PicInFolder As String = System.IO.Path.Combine(path, m.Member_Photo)
        picProfilePicture.Image = Image.FromFile(PicInFolder)

        lblMemberID.Text = m.Member_Id
        lblFullName.Text = m.Member_Name
        lblICNO.Text = "XXXXXX-XX-" & m.Member_ICNO.Substring(10)
        lblContactNo.Text = "XXX-XXXX " & m.Member_MobileNo.Substring(9)
        lblEmail.Text = m.Member_Email
        lblRewardPoint.Text = m.Member_RewardPoint.ToString
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If mskMemberIC.MaskCompleted Or mskMemberContact.MaskCompleted Then
                filterIC_ContactNo()
            ElseIf mskMemberID.MaskCompleted Then
                filterID()
            ElseIf mskMemberIC.Text = "" And mskMemberContact.Text = "" And mskMemberID.Text = "" Then
                Throw New NoNullAllowedException("There is no input data detected, please try again.")
            ElseIf mskMemberIC.Text <> "" Or mskMemberContact.Text <> "" Or mskMemberID.Text <> "" Then
                Throw New FormatException("The information given doesn't match with the format required, please try again.")
            Else
                Throw New Exception("There is an error, please try again.")
            End If
        Catch ex As Exception When TypeOf ex Is KeyNotFoundException OrElse
                                   TypeOf ex Is NoNullAllowedException 'OrElse
            'TypeOf ex Is FormatException
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ResetSearchForm()
        End Try
    End Sub

    Private Sub ResetSearchForm()
        With mskMemberIC
            .Clear()
            .Select()
        End With

        mskMemberContact.Clear()
        mskMemberID.Clear()
    End Sub

    Private Sub mskMemberID_TextChanged(sender As Object, e As EventArgs) Handles mskMemberID.TextChanged
        mskMemberIC.Clear()
        mskMemberContact.Clear()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        With frmEnterPIN
            .memberId = m.Member_Id.ToString
            .ShowDialog()
        End With
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub lblMemberID_TextChanged(sender As Object, e As EventArgs) Handles lblMemberID.TextChanged
        btnOK.Enabled = If(lblMemberID.Text <> "", True, False)
    End Sub

    Private Sub frmSearchMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetDisplayLabel()
    End Sub

End Class