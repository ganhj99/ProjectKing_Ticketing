Imports System.Text

Module CurrentSchedule
    Public intSelectedId As Integer = 1 'current selected schedule id (based on db) ' Set to 1 (to be imported from previousform 
    Public sch As New Schedule

    Public Function GetSeatSoldList() As List(Of String)
        Dim seatSoldList As New List(Of String)
        Dim db As New KingDBDataContext

        Dim rs = From td In db.Transaction_Details
                 Where (From t In db.Transactions
                        Where t.Schedule_Id = sch.Schedule_Id
                        Select t.Transaction_Id).Contains(td.Transaction_Id)
                 Select td.Seat_No
        'In SQL
        'SELECT * FROM [Transaction_Detail] AS td
        'WHERE td.Transaction_Id IN (SELECT t.Transaction_Id from [Transaction] AS t
        '                            WHERE t.Schedule_Id = 13)

        seatSoldList = rs.ToList
        Return seatSoldList
    End Function

    Public Function ToHallString() As String
        Return String.Format("{0} [{1}]", sch.Hall.Hall_Id, sch.Hall.Hall_Type.ToUpper)
    End Function

    Public Function ToMovieString() As String
        Return sch.Movie.Movie_Title
    End Function

    Public Function ToStartTimeString() As String
        Dim startTime As DateTime = DateTime.Today.Add(sch.Start_Time)
        Return String.Format("{0:ddd, d MMM yyyy} [{1:h:mmtt}]", sch.Schedule_Date, startTime)
    End Function
End Module
