Public Class frmConfirmPIN
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim db As New KingDBDataContext()

        Dim timeFormat As String = "dd/MM/yyyy"

        If txtPIN1.Text = "" And txtPIN2.Text = "" Then

            MessageBox.Show("Please enter PIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtPIN1.Text.Length < 6 And txtPIN2.Text.Length < 6 Then

            MessageBox.Show("Please enter PIN with 6 digital numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtPIN1.Text <> txtPIN2.Text Then

            MessageBox.Show("PIN not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPIN1.Clear()
            txtPIN2.Clear()
            txtPIN1.Select()

        Else

            txtPIN1.Text.Equals(txtPIN2.Text)

            Dim m As New Member()

            m.Member_Id = GetNextID()
            m.Member_Name = lblName.Text
            m.Member_Photo = GetNextID() + ".jpeg"
            m.Member_ICNO = frmRegisterMember.mskMemberIC.Text
            m.Member_MobileNo = frmRegisterMember.mskMemberContact.Text
            m.Member_Email = lblEmail.Text
            m.Member_BirthDate = frmRegisterMember.dtpickMemberBOF.Value
            m.Member_PIN = Integer.Parse(txtPIN2.Text)
            m.Member_JoinedDate = DateTime.Now()
            m.Member_RewardPoint = 0
            m.Member_RewardPointExp = DateTime.Now.AddMonths(3)

            db.Members.InsertOnSubmit(m)
            db.SubmitChanges()

            MessageBox.Show("Member Register Successful." & vbNewLine & "Enjoy your Movie.", "Member Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With frmRegisterMember
                .txtMemberName.Clear()
                .txtMemberEmail.Clear()
                .mskMemberContact.Clear()
                .mskMemberIC.Clear()
                .picMemberPhoto.Image = Nothing
                .btnOpenCam.Enabled = True
                .dtpickMemberBOF.ResetText()
            End With

            Me.Hide()
            frmRegisterMember.Close()

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmRegisterMember.Show()
        Me.Hide()

    End Sub
End Class