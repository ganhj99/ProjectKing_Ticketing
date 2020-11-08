Module App
    Public Function GetNextID() As String
        Dim db As New KingDBDataContext()

        Dim m = From o In db.Members
        Dim newMemberID = m.Count() + 1

        Return "M" + newMemberID.ToString("1000000")
    End Function
End Module
