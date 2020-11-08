Public Class frmStaffLogin

    Function validStaffID(id As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Staffs.Any(Function(o) o.Staff_Id = id)
    End Function

    Private Sub txtStaffID_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffID.Validating
        Dim chkID As String = txtStaffID.Text

        If chkID = "" Then
            staffErr.SetError(txtStaffID, "- Staff ID is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtStaffID, Nothing)
        End If
    End Sub

    Private Sub txtStaffPassword_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffPassword.Validating
        Dim chkID As String = txtStaffPassword.Text

        If chkID = "" Then
            staffErr.SetError(txtStaffPassword, "- Staff Password is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtStaffPassword, Nothing)
        End If
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New KingDBDataContext()

        If validStaffID(txtStaffID.Text) Then

            Dim thisStaff As Staff = db.Staffs.FirstOrDefault(Function(ps) ps.Staff_Id = txtStaffID.Text)
            Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "StaffImage\")
            Dim PicInFolder As String

            Try
                PicInFolder = System.IO.Path.Combine(path, thisStaff.Staff_Picture)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            If txtStaffPassword.Text.Equals(thisStaff.Staff_Password) Then

                If thisStaff.Staff_ResetPass IsNot Nothing Then
                    frmStaffFirstLogin.firstTimeID = thisStaff.Staff_Id
                    frmStaffFirstLogin.ShowDialog(Me)
                Else
                    If thisStaff.Staff_Status.Equals("Inactive") Then
                        MessageBox.Show("This staff has alreay resigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        txtStaffID.Text = ""
                        txtStaffPassword.Text = ""

                        If thisStaff.Staff_Role.Equals("Cashier") Then
                            With frmShowMovie
                                .staffId = thisStaff.Staff_Id
                                .mnuManagement.Visible = True
                                .mnuFileLogout.Text = "Logout (" & thisStaff.Staff_Name & ")"
                                .mnuTransaction.Enabled = True
                                .mnuManagement.Enabled = True
                                .mnuFileAccount.Visible = True
                                .UcStaffHeader1.Label1.Text = " Welcome, " + thisStaff.Staff_Name
                                .UcStaffHeader1.lblLoginNow.Visible = False
                                .UcStaffHeader1.staffPic.Image = Image.FromFile(PicInFolder)

                                .mnuManagementStaff.Visible = False
                                .mnuManagementMovie.Visible = False
                                .mnuManagementReport.Visible = False
                                .mnuManagementMemberRegister.Visible = True
                                .Show()
                            End With

                            With frmTicketing
                                .mnuManagement.Visible = True
                                .mnuFileLogout.Text = "Logout (" & thisStaff.Staff_Name & ")"
                                .mnuTransaction.Enabled = True
                                .mnuManagement.Enabled = True
                                .mnuFileAccount.Visible = True

                                .mnuManagementStaff.Visible = False
                                .mnuManagementMovie.Visible = False
                                .mnuManagementReport.Visible = False
                                .mnuManagementMemberRegister.Visible = True
                            End With

                            With frmPayment
                                .mnuManagement.Visible = True
                                .mnuFileLogout.Text = "Logout (" & thisStaff.Staff_Name & ")"
                                .mnuTransaction.Enabled = True
                                .mnuManagement.Enabled = True
                                .mnuFileAccount.Visible = True

                                .mnuManagementStaff.Visible = False
                                .mnuManagementMovie.Visible = False
                                .mnuManagementReport.Visible = False
                                .mnuManagementMemberRegister.Visible = True
                            End With

                            Me.Hide()
                        ElseIf thisStaff.Staff_Role.Equals("Manager") Then
                            With frmShowMovie
                                .staffId = thisStaff.Staff_Id
                                .mnuManagement.Visible = True
                                .mnuFileLogout.Text = "Logout (" & thisStaff.Staff_Name & ")"
                                .mnuTransaction.Enabled = True
                                .mnuManagement.Enabled = True
                                .mnuFileAccount.Visible = True
                                .UcStaffHeader1.Label1.Text = " Welcome, " + thisStaff.Staff_Name
                                .UcStaffHeader1.lblLoginNow.Visible = False
                                .UcStaffHeader1.staffPic.Image = Image.FromFile(PicInFolder)

                                .mnuManagementStaff.Visible = True
                                .mnuManagementReport.Visible = True
                                .mnuManagementMovie.Visible = True
                                .mnuManagementMemberRegister.Visible = True
                                .Show()
                            End With

                            With frmTicketing
                                .mnuManagement.Visible = True
                                .mnuFileLogout.Text = "Logout (" & thisStaff.Staff_Name & ")"
                                .mnuTransaction.Enabled = True
                                .mnuManagement.Enabled = True
                                .mnuFileAccount.Visible = True

                                .mnuManagementStaff.Visible = True
                                .mnuManagementReport.Visible = True
                                .mnuManagementMovie.Visible = True
                                .mnuManagementMemberRegister.Visible = True
                            End With

                            With frmPayment
                                .mnuManagement.Visible = True
                                .mnuFileLogout.Text = "Logout (" & thisStaff.Staff_Name & ")"
                                .mnuTransaction.Enabled = True
                                .mnuManagement.Enabled = True
                                .mnuFileAccount.Visible = True

                                .mnuManagementStaff.Visible = True
                                .mnuManagementReport.Visible = True
                                .mnuManagementMovie.Visible = True
                                .mnuManagementMemberRegister.Visible = True
                            End With
                            Me.Hide()
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Invalid id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Invalid id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub llForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llForgetPassword.LinkClicked
        frmStaffResetPassword.ShowDialog()
    End Sub

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStaffID.Focus()
    End Sub
End Class
