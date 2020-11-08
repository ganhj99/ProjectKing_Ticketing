Public Class frmScheduleCreate
    Dim db As New KingDBDataContext()
    Dim movieList As New List(Of Movie)
    Dim scheList As New List(Of Schedule)
    Dim dateFrom As Date = Date.Now
    Dim dateTo As Date = Date.Now

    'Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 10, 0, 0, 0) And o.Schedule_Date = dateFrom.AddDays(i) And o.Hall_Id = 1)
    'If scheE Is Nothing Then
    'Else
    '    countErr += 1
    'End If

    Private Sub scheduleCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cboMovie.SelectedIndex = 0
            dtpDateFrom.Value = dateFrom
            dtpDateFrom.MinDate = dateFrom
            dtpDateTo.Value = dateTo
            dtpDateTo.MinDate = dateTo
            dtpDate.Value = dtpDateFrom.Value

            checkSchedule()
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim count As Integer = 0
        Dim countErr As Integer = 0
        Dim errMess As String = ""
        Dim movieId As Integer
        Dim dateF As Date
        Dim dateT As Date

        Try
            dateF = dtpDateFrom.Value
            dateT = dtpDateTo.Value

            For Each movie In movieList
                If movie.Movie_Title = cboMovie.SelectedItem.ToString Then
                    movieId = movie.Movie_Id
                End If
            Next

            Dim days As Integer = CInt((dateT.AddDays(1).Subtract(dateF)).TotalDays)

            If pn1h101.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 10, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 1)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 1, " + New TimeSpan(0, 10, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 13, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn1h13.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 13, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 1)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 1, " + New TimeSpan(0, 13, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 16, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn1h36.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 16, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 1)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 1, " + New TimeSpan(0, 16, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 19, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn1h69.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 19, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 1)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 1, " + New TimeSpan(0, 19, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 21, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn1h912.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 21, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 1)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 1, " + New TimeSpan(0, 21, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 23, 59, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn2h101.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 10, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 2)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 2, " + New TimeSpan(0, 10, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 13, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn2h13.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 13, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 2)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 2, " + New TimeSpan(0, 13, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 16, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn2h36.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 16, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 2)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 2, " + New TimeSpan(0, 16, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 19, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn2h69.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 19, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 2)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 2, " + New TimeSpan(0, 19, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 21, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn2h912.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 21, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 2)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 2, " + New TimeSpan(0, 21, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 23, 59, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn3h101.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 10, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 3)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 3, " + New TimeSpan(0, 10, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 13, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn3h13.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 13, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 3)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 3, " + New TimeSpan(0, 13, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 16, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn3h36.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 16, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 3)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 3, " + New TimeSpan(0, 16, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 19, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn3h69.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 19, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 3)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 3, " + New TimeSpan(0, 19, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 21, 0, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If pn3h912.BackColor = Color.Lime Then
                For i As Integer = 0 To (days - 1)
                    Dim scheE As Schedule = db.Schedules.FirstOrDefault(Function(o) o.Start_Time = New TimeSpan(0, 21, 0, 0, 0) And o.Schedule_Date = dateF.AddDays(i) And o.Hall_Id = 3)
                    If scheE Is Nothing Then
                    Else
                        countErr += 1
                        errMess += dateFrom.AddDays(i).ToString("M/d/yyyy") + ", Hall 3, " + New TimeSpan(0, 21, 0, 0, 0).ToString("hh") + " to " + New TimeSpan(0, 23, 59, 0, 0).ToString("hh") + vbNewLine
                    End If
                Next
            End If

            If countErr = 0 Then
                If pn1h101.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 10, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 13, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 1
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn1h13.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 13, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 15, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 1
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn1h36.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 16, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 18, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 1
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn1h69.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 19, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 21, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 1
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn1h912.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 21, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 23, 59, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 1
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn2h101.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 10, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 13, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 2
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn2h13.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 13, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 15, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 2
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn2h36.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 16, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 18, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 2
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next

                End If

                If pn2h69.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 19, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 21, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 2
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn2h912.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 21, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 23, 59, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 2
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn3h101.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 10, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 13, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 3
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn3h13.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 13, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 15, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 3
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn3h36.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 16, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 18, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 3
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn3h69.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 19, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 21, 0, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 3
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If

                If pn3h912.BackColor = Color.Lime Then
                    For i As Integer = 0 To (days - 1)
                        Dim sche As New Schedule()
                        sche.Schedule_Id = getNewId()
                        sche.Start_Time = New TimeSpan(0, 21, 0, 0, 0)
                        sche.End_Time = New TimeSpan(0, 23, 59, 0, 0)
                        sche.Schedule_Date = dateF.AddDays(i)
                        sche.Schedule_Status = "Available"
                        sche.Movie_Id = movieId
                        sche.Hall_Id = 3
                        db.Schedules.InsertOnSubmit(sche)
                        db.SubmitChanges()
                        count += 1
                    Next
                End If
                MsgBox(count & " schedule create successful", CType(0, MsgBoxStyle), "Success")

            Else
                MsgBox("Schedule create fail!!" & vbNewLine & errMess & vbNewLine & "Above " & countErr & " schedule(s) are duplicate", CType(48, MsgBoxStyle), "Error")
            End If
            checkSchedule()

        Catch ex As Exception
            MsgBox("Please fill in correctly", CType(48, MsgBoxStyle), "Error")
        End Try
    End Sub

    Function getNewId() As Integer
        scheList.Clear()
        scheList = (From s In db.Schedules Select s).ToList
        Dim lastId As Integer
        If IsNothing(scheList) Then
            lastId = 0
        Else
            For Each scheCurrent In scheList
                lastId = scheCurrent.Schedule_Id
            Next
        End If
        Return lastId + 1
    End Function

    Private Sub panel_Click(sender As Object, e As EventArgs) Handles pn1h101.Click, pn1h13.Click, pn1h36.Click, pn1h69.Click, pn1h912.Click, pn2h101.Click, pn2h13.Click, pn2h36.Click, pn2h69.Click, pn2h912.Click, pn3h101.Click, pn3h13.Click, pn3h36.Click, pn3h69.Click, pn3h912.Click
        If TypeOf sender Is Panel Then
            Dim pnl As Panel = CType(sender, Panel)
            If pnl.BackColor = Color.LightGray Then
                pnl.BackColor = Color.Lime

            ElseIf pnl.BackColor = Color.Lime Then
                pnl.BackColor = Color.LightGray
            End If
        End If

    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        If dtpDateFrom.Value > dtpDateTo.Value Then
            dtpDateFrom.Value = dateFrom
            MsgBox("Invalid date range", CType(48, MsgBoxStyle), "Error")
        Else
            dtpDate.MinDate = dtpDateFrom.Value
        End If
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        If dtpDateFrom.Value > dtpDateTo.Value Then
            dtpDateTo.Value = dateTo
            MsgBox("Invalid date range", CType(48, MsgBoxStyle), "Error")
        Else
            dtpDate.MaxDate = dtpDateTo.Value
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        checkSchedule()
    End Sub

    Private Sub cboMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged
        checkSchedule()

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MovieImage\")
        Dim m = CType((From p In db.Movies Select p Where p.Movie_Title.Equals(cboMovie.SelectedItem.ToString)).Single(), Movie)

        Dim PicInFolder As String = System.IO.Path.Combine(path, m.Movie_Image)
        pbMovieImg.Image = Image.FromFile(PicInFolder)
    End Sub

    Private Sub checkSchedule()
        scheList.Clear()
        scheList = (From s In db.Schedules Select s Where s.Schedule_Status = "Available").ToList
        Dim dateSelect As String = dtpDate.Value.ToString("M/d/yyyy")
        Dim movieId As Integer
        For Each movie In movieList
            If movie.Movie_Title = cboMovie.SelectedItem.ToString Then
                movieId = movie.Movie_Id
            End If
        Next

        pn1h101.BackColor = Color.LightGray
        pn1h13.BackColor = Color.LightGray
        pn1h36.BackColor = Color.LightGray
        pn1h69.BackColor = Color.LightGray
        pn1h912.BackColor = Color.LightGray
        pn2h101.BackColor = Color.LightGray
        pn2h13.BackColor = Color.LightGray
        pn2h36.BackColor = Color.LightGray
        pn2h69.BackColor = Color.LightGray
        pn2h912.BackColor = Color.LightGray
        pn3h101.BackColor = Color.LightGray
        pn3h13.BackColor = Color.LightGray
        pn3h36.BackColor = Color.LightGray
        pn3h69.BackColor = Color.LightGray
        pn3h912.BackColor = Color.LightGray

        For Each scheCurrent In scheList
            If scheCurrent.Schedule_Date.ToString("M/d/yyyy").Equals(dateSelect) Then
                If scheCurrent.Hall_Id = 1 Then
                    If scheCurrent.Start_Time = New TimeSpan(0, 10, 0, 0, 0) Then
                        pn1h101.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 13, 0, 0, 0) Then
                        pn1h13.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 16, 0, 0, 0) Then
                        pn1h36.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 19, 0, 0, 0) Then
                        pn1h69.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 21, 0, 0, 0) Then
                        pn1h912.BackColor = Color.Red
                    End If
                ElseIf scheCurrent.Hall_Id = 2 Then
                    If scheCurrent.Start_Time = New TimeSpan(0, 10, 0, 0, 0) Then
                        pn2h101.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 13, 0, 0, 0) Then
                        pn2h13.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 16, 0, 0, 0) Then
                        pn2h36.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 19, 0, 0, 0) Then
                        pn2h69.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 21, 0, 0, 0) Then
                        pn2h912.BackColor = Color.Red
                    End If
                ElseIf scheCurrent.Hall_Id = 3 Then
                    If scheCurrent.Start_Time = New TimeSpan(0, 10, 0, 0, 0) Then
                        pn3h101.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 13, 0, 0, 0) Then
                        pn3h13.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 16, 0, 0, 0) Then
                        pn3h36.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 19, 0, 0, 0) Then
                        pn3h69.BackColor = Color.Red
                    End If
                    If scheCurrent.Start_Time = New TimeSpan(0, 21, 0, 0, 0) Then
                        pn3h912.BackColor = Color.Red
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class