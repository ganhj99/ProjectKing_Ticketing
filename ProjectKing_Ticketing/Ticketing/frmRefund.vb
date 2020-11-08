Imports System.ComponentModel
Imports System.Text

Public Class frmRefund
    Private Sub btnRefundNow_Click(sender As Object, e As EventArgs) Handles btnRefundNow.Click
        If chkFirst.Checked And chkSecond.Checked Then
            CancelTransaction()
            '4. Display Refund AMT
            Dim decRefundAmt As String = lblAmtRefundable.Text

            MessageBox.Show("Please refund RM" & decRefundAmt.ToString() & " to the customer. " & vbNewLine & "All points earned/redeemed will also be reverted.", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPayment.blnIsRefund = True
            frmTicketing.isNewTransaction = True
            frmTicketing.Dispose()
            Me.Close()
        Else
            MessageBox.Show("Refund does not processed successfully, please try again.", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chkTnC_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirst.CheckedChanged, chkSecond.CheckedChanged
        btnRefundNow.Enabled = If(chkFirst.Checked And chkSecond.Checked, True, False)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmRefund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAmtRefundable.Text = frmPayment.lblGrandTotal.Text

        btnRefundNow.Enabled = False
        chkSecond.Checked = False

        If frmPayment.blnIsPrint Then
            chkFirst.Checked = False
            chkFirst.Enabled = True
            lblPrinted.Visible = False
        Else
            chkFirst.Checked = True
            chkFirst.Enabled = False
            lblPrinted.Visible = True
        End If
    End Sub

    Private Sub CancelTransaction()
        Try
            Dim db As New KingDBDataContext
            Dim rs = From td In db.Transaction_Details
                     Where td.Transaction_Id = CurrentTransaction.trx.Transaction_Id
            'For Each trxDet As Transaction_Detail In rs.ToList
            If rs Is Nothing Then
                Throw New Exception("No tickets to be refunded!")
            Else
                db.Transaction_Details.DeleteAllOnSubmit(rs.ToList)
                db.SubmitChanges()
            End If

            Dim trx As Transaction = db.Transactions.FirstOrDefault(Function(t) t.Transaction_Id = CurrentTransaction.trx.Transaction_Id)
            If trx Is Nothing Then
                Throw New Exception("Transaction could not be found!")
            Else
                trx.Transaction_Status = "Cancelled"
                db.SubmitChanges()
            End If

            If CurrentTransaction.currentMemberId <> Nothing Then 'If this transaction is a member, then only update pt and expiry
                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = CurrentTransaction.currentMemberId)
                If CurrentTransaction.isEarnPts Then 'Do opposite operation with new trx
                    m.Member_RewardPoint -= CurrentTransaction.memberPointsEarnedOrRedeemed 'if earn pts, then we deduct back
                Else 'REDEEM PTS
                    m.Member_RewardPoint += CurrentTransaction.memberPointsEarnedOrRedeemed 'if redeem pts, then we add/refund back to pts
                End If
                m.Member_RewardPointExp = Date.Now.AddMonths(3) 'Update pt expiry to 3 month
                db.SubmitChanges()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRefund_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        frmPayment.Show()
    End Sub
End Class