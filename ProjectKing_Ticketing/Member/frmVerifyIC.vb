Public Class frmVerifyIC

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim db As New KingDBDataContext()
        Dim ic As Member = db.Members.SingleOrDefault(Function(o) o.Member_ICNO = mskIC.Text)

        Try
            If mskIC.MaskCompleted = False Then
                MessageBox.Show("Invalid IC no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mskIC.Clear()
                Return

            ElseIf ic Is Nothing Then
                MessageBox.Show("Sorry, member record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mskIC.Clear()
                Return

            Else
                frmPINRecovery.SelectedIcForResetPIN = mskIC.Text
                frmPINRecovery.ShowDialog()
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'MemberLogin.Show()
        Me.Close()

    End Sub

    Private Sub VerifyIC_Load(sender As Object, e As EventArgs) Handles Me.Load
        mskIC.Select()
    End Sub
End Class