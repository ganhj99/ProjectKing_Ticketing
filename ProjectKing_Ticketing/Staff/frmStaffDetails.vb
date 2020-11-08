Imports System.Text.RegularExpressions

Public Class frmStaffDetails
    Public SelectedId As String
    Dim db As New KingDBDataContext()

    Function duplicateEmail(email As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Staffs.Any(Function(o) o.Staff_Email = email)
    End Function

    Private Sub StaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New KingDBDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = SelectedId)
        Dim staffname As String = s.Staff_Name

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "StaffImage\")
        Dim PicInFolder As String = System.IO.Path.Combine(path, s.Staff_Picture)

        lblStaffName.Text = s.Staff_Name
        lblStaffAge.Text = s.Staff_DoB.ToString()
        lblStaffIC.Text = s.Staff_IC
        mskStaffPhone.Text = s.Staff_Phone
        txtStaffEmail.Text = s.Staff_Email
        lblStaffID.Text = s.Staff_Id
        cboStaffStatus.SelectedItem = s.Staff_Status
        cboStaffRole.SelectedItem = s.Staff_Role
        lblStaffJoinDate.Text = s.Staff_StartDate.ToString()
        StaffPicture.Image = Image.FromFile(PicInFolder)

        If s.Staff_Role.Equals("Cashier") Then
            btnChange.Visible = True
        ElseIf s.Staff_Role.Equals("Manager") Then
            btnChange.Visible = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub mskStaffPhone_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles mskStaffPhone.Validating
        Dim chkPhone As String = If(mskStaffPhone.MaskCompleted, mskStaffPhone.Text, "")

        If chkPhone = "" Then
            StaffErr.SetError(mskStaffPhone, "- Staff Phone.No is Empty")
            e.Cancel = True
        Else
            StaffErr.SetError(mskStaffPhone, Nothing)
        End If
    End Sub

    Private Sub txtStaffEmail_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffEmail.Validating
        Dim chkEmail As String = txtStaffEmail.Text

        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(chkEmail)

        If chkEmail = "" Then
            StaffErr.SetError(txtStaffEmail, "- Staff Email is Empty")
            e.Cancel = True
        ElseIf Not isValid Then
            StaffErr.SetError(txtStaffEmail, "- Staff Email is not valid")
            e.Cancel = True
        Else
            StaffErr.SetError(txtStaffEmail, Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = SelectedId)

        Dim dob As Nullable(Of DateTime) = Nothing

        Dim answer As DialogResult = MessageBox.Show("Are you sure you want to update current staff details", "Update?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)


        If answer = DialogResult.Yes Then
            Try
                If duplicateEmail(txtStaffEmail.Text) = False Or s.Staff_Email.Equals(txtStaffEmail.Text) Then
                    s.Staff_Phone = mskStaffPhone.Text
                    s.Staff_Email = txtStaffEmail.Text
                    s.Staff_Role = cboStaffRole.SelectedItem.ToString
                    If cboStaffStatus.SelectedItem.ToString = "Active" Then
                        s.Staff_Status = cboStaffStatus.SelectedItem.ToString
                        s.Staff_EndDate = dob
                    ElseIf cboStaffStatus.SelectedItem.ToString = "Inactive" Then
                        s.Staff_Status = cboStaffStatus.SelectedItem.ToString
                        s.Staff_EndDate = DateTime.Now
                    End If

                    db.SubmitChanges()
                    MessageBox.Show("Staff details has been updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("This email has already been used! Please use other email", "Duplicated", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf answer = DialogResult.No Then
            mskStaffPhone.Text = s.Staff_Phone
            txtStaffEmail.Text = s.Staff_Email
            cboStaffRole.SelectedItem = s.Staff_Role
            cboStaffStatus.SelectedItem = s.Staff_Status
        ElseIf answer = DialogResult.Cancel Then
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = SelectedId)

        With frmCashierChangePass
            .thisId = s.Staff_Id
            .txtConfirmPass.Text = ""
            .txtCurrentPass.Text = ""
            .txtNewPassword.Text = ""
            .ShowDialog()
        End With
    End Sub
End Class