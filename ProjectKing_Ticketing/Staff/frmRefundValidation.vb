Public Class frmRefundValidation
    Dim db As New KingDBDataContext()

    Function validStaff(id As String) As Boolean
        Return db.Staffs.Any(Function(o) o.Staff_Id = id)
    End Function

    Private Sub txtManagerID_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtManagerID.Validating
        Dim chkID As String = txtManagerID.Text

        If chkID = "" Then
            staffErr.SetError(txtManagerID, "- Manager ID is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtManagerID, Nothing)
        End If
    End Sub

    Private Sub txtManagerPass_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtManagerPass.Validating
        Dim chkID As String = txtManagerPass.Text

        If chkID = "" Then
            staffErr.SetError(txtManagerPass, "- Manager Password is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtManagerPass, Nothing)
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        If validStaff(txtManagerID.Text) Then
            Dim thisStaff As Staff = db.Staffs.FirstOrDefault(Function(ps) ps.Staff_Id = txtManagerID.Text)

            If thisStaff.Staff_Status.Equals("Inactive") Then
                MessageBox.Show("This manager has already resigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If txtManagerPass.Text.Equals(thisStaff.Staff_Password) Then

                    If thisStaff.Staff_Role.Equals("Cashier") Then
                        MessageBox.Show("Only manager are able to refund", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf thisStaff.Staff_Role.Equals("Manager") Then

                        'MessageBox.Show("hi manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmRefund.ShowDialog()
                    End If
                Else
                    MessageBox.Show("Wrong id or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("No such staff exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class