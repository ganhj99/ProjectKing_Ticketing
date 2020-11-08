Public Class frmScheduleEdit
    Dim db As New KingDBDataContext()
    Dim movieList As New List(Of Movie)
    Dim scheList As New List(Of Schedule)
    Dim movieId As Integer

    Private Sub scheduleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboMovie.Items.Clear()
        movieList.Clear()
        movieList = (From p In db.Movies Select p Where p.Movie_Status = "Active").ToList

        If movieList.Count = 0 Then
            MsgBox("There is no active Movie", CType(48, MsgBoxStyle), "Error")
            Me.Close()
        Else
            For Each movie In movieList
                cboMovie.Items.Add(movie.Movie_Title)
            Next
            cboMovie.SelectedIndex = -1
            dgvSchedule.Rows.Clear()

        End If
    End Sub

    Private Sub cboMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged
        If cboMovie.SelectedIndex = -1 Then

        Else

            For Each movie In movieList
            If movie.Movie_Title = cboMovie.SelectedItem.ToString Then
                movieId = movie.Movie_Id
            End If
        Next

        Dim rs = From s In db.Schedules
                 Where s.Movie_Id = movieId
                 Select s.Hall_Id, s.Schedule_Date, s.Start_Time, s.End_Time

        dgvSchedule.DataSource = rs
        dgvSchedule.Columns(1).ReadOnly = True
        dgvSchedule.Columns(2).ReadOnly = True
        dgvSchedule.Columns(3).ReadOnly = True
        dgvSchedule.Columns(4).ReadOnly = True

        scheList.Clear()
        scheList = (From s In db.Schedules
                    Where s.Movie_Id = movieId).ToList

        Dim count As Integer
        Dim i As Integer

        i = 0
        For Each scheCurrent In scheList
            If scheCurrent.Schedule_Status.Equals("Available") Then
                dgvSchedule.Rows(i).Cells(0).Value = True
            Else
                dgvSchedule.Rows(i).Cells(0).Value = False
            End If
            i += 1
            count += 1
        Next
        cboHall.SelectedIndex = -1
            lblRecord.Text = count.ToString & " records"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim i As Integer
        i = 0
        For Each scheCurrent In scheList
            Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Schedule_Id = scheCurrent.Schedule_Id)
            Dim Checked As Boolean = CType(dgvSchedule.Rows(i).Cells(0).Value, Boolean)
            If Checked = True Then
                scheE.Schedule_Status = "Available"
                db.SubmitChanges()
            Else
                scheE.Schedule_Status = "Not Available"
                db.SubmitChanges()
            End If
            i += 1
        Next
        MsgBox("Schedules update successfully", CType(0, MsgBoxStyle), "Success")
    End Sub

    Private Sub cboHall_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHall.SelectedIndexChanged
        If cboHall.SelectedIndex = -1 Then

        Else
            For Each movie In movieList
                If movie.Movie_Title = cboMovie.SelectedItem.ToString Then
                    movieId = movie.Movie_Id
                End If
            Next

            Dim rs = From s In db.Schedules
                     Where s.Movie_Id = movieId And s.Hall_Id = Integer.Parse(cboHall.SelectedItem.ToString)
                     Select s.Hall_Id, s.Schedule_Date, s.Start_Time, s.End_Time

            dgvSchedule.DataSource = rs
            dgvSchedule.Columns(1).ReadOnly = True
            dgvSchedule.Columns(2).ReadOnly = True
            dgvSchedule.Columns(3).ReadOnly = True
            dgvSchedule.Columns(4).ReadOnly = True

            scheList.Clear()
            scheList = (From s In db.Schedules
                        Where s.Movie_Id = movieId And s.Hall_Id = Integer.Parse(cboHall.SelectedItem.ToString)).ToList

            Dim count As Integer
            Dim i As Integer

            i = 0
            For Each scheCurrent In scheList
                If scheCurrent.Schedule_Status.Equals("Available") Then
                    dgvSchedule.Rows(i).Cells(0).Value = True
                Else
                    dgvSchedule.Rows(i).Cells(0).Value = False
                End If
                i += 1
                count += 1
            Next
            lblRecord.Text = count.ToString & " record(s)"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'Private Sub frmScheduleEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    If needRefresh Then
    '        needRefresh = False
    '        scheduleEdit_Load(Nothing, Nothing)
    '    End If
    'End Sub
End Class