Public Class frmCashierChangePass
    Public thisId As String
    Dim db As New KingDBDataContext()

    Private Sub txtCurrentPass_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtCurrentPass.Validating
        Dim chkPass As String = txtCurrentPass.Text
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = thisId)

        If chkPass = "" Then
            staffErr.SetError(txtCurrentPass, "- Current Password is Empty")
            e.Cancel = True
        ElseIf chkPass <> s.Staff_Password Then
            staffErr.SetError(txtCurrentPass, "- Current Password is Wrong")
            e.Cancel = True
        Else
            staffErr.SetError(txtCurrentPass, Nothing)
        End If
    End Sub

    Private Sub txtNewPassword_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtNewPassword.Validating
        Dim chkPass As String = txtNewPassword.Text

        If chkPass = "" Then
            staffErr.SetError(txtNewPassword, "- Password is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtNewPassword, Nothing)
        End If
    End Sub

    Private Sub txtConfirmPass_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtConfirmPass.Validating
        Dim chkConfirmPass As String = txtConfirmPass.Text

        If chkConfirmPass = "" Then
            staffErr.SetError(txtConfirmPass, "- Confirm Password is Empty")
            e.Cancel = True
        ElseIf chkConfirmPass <> txtNewPassword.Text Then
            staffErr.SetError(txtConfirmPass, "- Password entered is different")
            e.Cancel = True
        Else
            staffErr.SetError(txtConfirmPass, Nothing)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = thisId)

        Dim answer As DialogResult = MessageBox.Show("Are you sure you want to update your password?", "Update?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If answer = DialogResult.Yes Then
            Try
                s.Staff_Password = txtConfirmPass.Text

                db.SubmitChanges()
                MessageBox.Show("Password change successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception

            End Try
        ElseIf answer = DialogResult.No Then

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub CashierChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class