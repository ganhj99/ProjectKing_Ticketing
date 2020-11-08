Public Class frmStaffFirstLogin
    Public firstTimeID As String
    Dim db As New KingDBDataContext()

    Private Sub txtPassword_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        Dim chkPass As String = txtPassword.Text

        If chkPass = "" Then
            staffErr.SetError(txtPassword, "- Password is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtPassword, Nothing)
        End If
    End Sub

    Private Sub txtConfirmPass_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtConfirmPass.Validating
        Dim chkConfirmPass As String = txtConfirmPass.Text

        If chkConfirmPass = "" Then
            staffErr.SetError(txtConfirmPass, "- Confirm Password is Empty")
            e.Cancel = True
        ElseIf chkConfirmPass <> txtPassword.Text Then
            staffErr.SetError(txtConfirmPass, "- Password entered is different")
            e.Cancel = True
        Else
            staffErr.SetError(txtPassword, Nothing)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = firstTimeID)

        Try
            s.Staff_Password = txtConfirmPass.Text
            s.Staff_ResetPass = Nothing

            db.SubmitChanges()
            frmStaffLogin.txtStaffID.Text = ""
            frmStaffLogin.txtStaffPassword.Text = ""
            MessageBox.Show("Thanks! Please login again with your new password", "Change Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class