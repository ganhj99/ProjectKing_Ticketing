Public Class frmMemberList

    Private Sub BindData()
        Dim db As New KingDBDataContext()

        Dim ic As String = mskMemberIC.Text
        Dim contactNo As String = mskMemberContact.Text

        Dim rs = From o In db.Members
                 Where o.Member_ICNO.Contains(ic) Or o.Member_MobileNo.Contains(contactNo)
                 Select New With {
                     .ID = o.Member_Id, .Name = o.Member_Name, .Email = o.Member_Email, .JoinDate = o.Member_JoinedDate, .RewardPoints = o.Member_RewardPoint
            }

        dgvMemberList.DataSource = rs

        'lblCount.Text = rs.Count.ToString("0 record(s) found.")
    End Sub

    Private Sub filterID()
        Dim db As New KingDBDataContext()

        Dim mID As String = mskMemberID.Text

        Dim rs = From o In db.Members
                 Where o.Member_Id.Contains(mID)
                 Select New With {
                     .ID = o.Member_Id, .Name = o.Member_Name, .Email = o.Member_Email, .JoinDate = o.Member_JoinedDate, .RewardPoints = o.Member_RewardPoint
            }

        dgvMemberList.DataSource = rs

        'lblCount.Text = rs.Count().ToString("0 record(s) found.")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Close()
        frmMonthlyNewMemberRegisterReport.ShowDialog()


    End Sub

    Private Sub dgvMemberList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMemberList.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgvMemberList.Rows(i).Cells(0).Value)
            frmDisplayMemberSearched.SelectedMemberID = id
            frmDisplayMemberSearched.ShowDialog()
            BindData()

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If mskMemberIC.MaskCompleted Or mskMemberContact.MaskCompleted Then
            BindData()
            mskMemberIC.Select()
            mskMemberIC.SelectAll()
            mskMemberContact.Select()
            mskMemberContact.SelectAll()

        ElseIf mskMemberID.MaskCompleted Then
            filterID()
            mskMemberID.Select()
            mskMemberID.SelectAll()

        Else
            MessageBox.Show("Enter information for search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub mskMemberID_TextChanged(sender As Object, e As EventArgs)
        mskMemberIC.Clear()
        mskMemberContact.Clear()

    End Sub

    Private Sub MemberList_Load(sender As Object, e As EventArgs) Handles Me.Load
        mskMemberIC.Select()
    End Sub
End Class