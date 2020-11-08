Public Class frmEnterPIN
    Public memberId As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            Dim db As New KingDBDataContext()
            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = memberId)

            Dim enteredPIN As Integer = CInt(txtPIN1.Text)

            If m.Member_PIN.Equals(enteredPIN) Then
                With frmPayment
                    .blnIsMember = True
                    .cboPtsAction.SelectedIndex = 0
                    CurrentTransaction.currentMemberId = m.Member_Id.ToString
                    .Show()
                End With

                Me.Close()
                frmSearchMember.Dispose()
            Else
                Throw New Exception("PIN entered does not match with database")
            End If
        Catch ex As FormatException
            MessageBox.Show("Invalid PIN format entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmEnterPIN_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtPIN1.Clear()
    End Sub
End Class