Imports System.Text

Module CurrentTransaction
    Public currentStaffId As String '= "S0001" 'pass from usercontorl
    Public currentMemberId As String

    Public memberPointsEarnedOrRedeemed As Integer
    Public isEarnPts As Boolean 'True = this trx is earn pts, False = this trx is redeem pts

    Public intSelectedId As Integer = 1
    Public trx As New Transaction

    'temporaryHolder before adding to trx
    Public trxDetsList As New List(Of Transaction_Detail)
    Public ticDetsList As New List(Of Ticket_Detail)

    Public strSeatSelected As New List(Of String)
    'Public strSeatSelected() As String = {} ' temporary recording var (at frmPayment)

    Public Function GetCurrentStaff(staffId As String) As Staff
        Dim db As New KingDBDataContext
        Dim staff As Staff = db.Staffs.FirstOrDefault(Function(o) o.Staff_Id = staffId)
        Return staff
    End Function

    Public Function ToSelectedSeatsString() As String
        Dim strShow As New StringBuilder

        Dim index As Integer = 0
        For Each str As String In strSeatSelected
            If str IsNot Nothing Then
                If index = 0 Then
                    strShow.Append(str)
                Else
                    strShow.Append(", " & str)
                End If
                index += 1 'Placing this line before 'EndIf' can prevent from displaying ',' in the front
            End If
        Next

        Return strShow.ToString
    End Function

    Public Function NewTransaction() As Boolean
        Dim isSuccess As Boolean = True
        Try
            Dim db As New KingDBDataContext

            With CurrentTransaction.trx
                .Transaction_Id = Nothing
                'Schedule alrdy assigned
                .Staff_Id = frmShowMovie.staffId 'currentStaffId
                '.Member (optional)
                .Member_Id = If(currentMemberId, Nothing)
                .Transaction_Status = "Paid"
                'AmtPayable alrdy assigned in frmPayment
                'PointsEarned alrdy assigned in frmPayment
                .Transaction_Date = DateTime.Now
                .Ticket_Details = Nothing
                .Transaction_Details = Nothing
            End With

            db.Transactions.InsertOnSubmit(trx)
            db.SubmitChanges()

            If currentMemberId <> Nothing Then 'If this transaction is a member, then only update pt and expiry
                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Id = currentMemberId)
                If isEarnPts Then
                    m.Member_RewardPoint += memberPointsEarnedOrRedeemed
                Else 'REDEEM PTS
                    m.Member_RewardPoint -= memberPointsEarnedOrRedeemed
                End If
                m.Member_RewardPointExp = Date.Now.AddMonths(3) 'Update pt expiry to 3 month
                db.SubmitChanges()
            End If

            For Each t As Transaction_Detail In trxDetsList
                Dim tNew As New Transaction_Detail
                tNew.Transaction_Id = trx.Transaction_Id
                tNew.Seat_No = t.Seat_No
                't.Transaction_Id = trx.Transaction_Id
                db.Transaction_Details.InsertOnSubmit(tNew)
                db.SubmitChanges()
            Next

            For Each t As Ticket_Detail In ticDetsList
                Dim tNew As New Ticket_Detail
                tNew.Transaction_Id = trx.Transaction_Id
                tNew.Ticket_Id = t.Ticket_Id
                tNew.Ticket_Price = t.Ticket_Price
                t.Transaction_Id = trx.Transaction_Id
                db.Ticket_Details.InsertOnSubmit(tNew)
                db.SubmitChanges()
            Next
        Catch ex As Exception
            isSuccess = False
            MsgBox(ex.Message)
        End Try

        Return isSuccess
    End Function
End Module
