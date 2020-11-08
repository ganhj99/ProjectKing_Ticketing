Imports System.Net.Mail

Public Class frmStaffResetPassword

    Public Function randomPass() As Object
        Dim a, b, c, d, e As Object
        a = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        b = Len(a)
        c = 8
        Randomize()
        d = ""
        For intstep = 1 To c
            e = Int((CInt(b) * Rnd()) + 1)
            d = CStr(d) & Mid(a.ToString(), CInt(e), 1)
        Next

        randomPass = d
    End Function

    Function validStaffEmail(email As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Staffs.Any(Function(o) o.Staff_Email = email)
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newPass As String
        Dim staffEmail As String = txtEmail.Text
        Dim db As New KingDBDataContext()

        newPass = randomPass().ToString()

        If validStaffEmail(staffEmail) Then

            Try
                Dim SmtpServer As New SmtpClient()
                Dim mail As New MailMessage()
                SmtpServer.UseDefaultCredentials = False
                SmtpServer.Credentials = New Net.NetworkCredential("kingcinema12@gmail.com", "HiHi123456")
                SmtpServer.Port = 587
                SmtpServer.EnableSsl = True
                SmtpServer.Host = "smtp.gmail.com"
                mail.From = New MailAddress("kingcinema12@gmail.com")
                mail.To.Add(staffEmail)
                mail.Subject = "Reset Password"
                mail.IsBodyHtml = False
                mail.Body = "This is your new password for your account, " + newPass + vbNewLine + "Please login again with this password"
                SmtpServer.Send(mail)

                Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Email = staffEmail)

                s.Staff_Password = newPass
                s.Staff_ResetPass = newPass

                db.SubmitChanges()
                frmStaffLogin.txtStaffID.Text = ""
                frmStaffLogin.txtStaffPassword.Text = ""
                MessageBox.Show("Your new password has been sent to your email", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("None of the staff here registered with this email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class