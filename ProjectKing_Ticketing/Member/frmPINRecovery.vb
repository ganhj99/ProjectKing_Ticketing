Public Class frmPINRecovery

    Public SelectedIcForResetPIN As String
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim db As New KingDBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_ICNO = SelectedIcForResetPIN)

        Try
            If m Is Nothing Then
                errorMsg()
                Return

            ElseIf txtNewPIN.Text = "" And txtNewPIN2.Text = "" Then
                MessageBox.Show("Please enter PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            ElseIf txtNewPIN.Text.Length < 6 And txtNewPIN2.Text.Length < 6 Then
                MessageBox.Show("Please enter with 6 digital numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            ElseIf txtNewPIN.Text.Equals(txtNewPIN2.Text) = False And txtNewPIN2.Text.Equals(txtNewPIN.Text) = False Then
                MessageBox.Show("PIN not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPIN.Clear()
                txtNewPIN2.Clear()
                txtNewPIN.Focus()
                Return

            Else
                m.Member_PIN = Integer.Parse(txtNewPIN2.Text)
                db.SubmitChanges()

                MessageBox.Show("Your PIN has been updated. Enjoy your Movie.", "PIN Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub errorMsg()
        MessageBox.Show("Sorry, member record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub PINRecovery_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNewPIN.Select()

    End Sub
End Class