Public Class ucHallNormal
    Private seatAvailable As New Bitmap(My.Resources.available)
    Private seatSold As New Bitmap(My.Resources.sold)
    Private seatSelected As New Bitmap(My.Resources.selected)

    Private seatSoldList As New List(Of String)
    Private seatSelectedList As New List(Of String) 'Real selected list in is CurrentTransaction, this is to diplsay picBox
    Private Sub ucHallNormal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OBJECTIVE:
        '1. Get from database the latest seat status (which seats is available)
        '2. Populate the seat with different image

        seatSoldList = CurrentSchedule.GetSeatSoldList()
        For Each seatSelect As String In CurrentTransaction.strSeatSelected
            seatSelectedList.Add(seatSelect)
        Next

        UpdateSeatSold()
        UpdateSeatSelected()
    End Sub

    Private Sub UpdateSeatSold()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim pic As PictureBox = CType(ctrl, PictureBox)

                If seatSoldList.Contains(pic.Name.Substring(3)) Then
                    pic.Image = seatSold
                    seatSoldList.Remove(pic.Name.Substring(3)) 'To prevent to search the entire list again
                ElseIf seatSelectedList.Contains(pic.Name.Substring(3)) Then
                    pic.Image = seatSelected
                    seatSelectedList.Remove(pic.Name.Substring(3)) 'To prevent to search the entire list again
                Else
                    pic.Image = seatAvailable
                End If
                'AddHandler ctrl.Click, AddressOf seatIcon_Click 'Cause slow UI response
            End If
        Next
    End Sub

    Private Sub seatIcon_Click(sender As Object, e As EventArgs) Handles picA01.Click, picA02.Click, picA03.Click, picA04.Click, picA05.Click, picA06.Click, picA07.Click, picA08.Click,
                                                                         picA09.Click, picA10.Click, picA11.Click, picA12.Click, picA13.Click, picA14.Click, picA15.Click, picA16.Click,
                                                                         picB01.Click, picB02.Click, picB03.Click, picB04.Click, picB05.Click, picB06.Click, picB07.Click, picB08.Click,
                                                                         picB09.Click, picB10.Click, picB11.Click, picB12.Click, picB13.Click, picB14.Click, picB15.Click, picB16.Click,
                                                                         picC01.Click, picC02.Click, picC03.Click, picC04.Click, picC05.Click, picC06.Click, picC07.Click, picC08.Click,
                                                                         picC09.Click, picC10.Click, picC11.Click, picC12.Click, picC13.Click, picC14.Click, picC15.Click, picC16.Click,
                                                                         picD01.Click, picD02.Click, picD03.Click, picD04.Click, picD05.Click, picD06.Click, picD07.Click, picD08.Click,
                                                                         picD09.Click, picD10.Click, picD11.Click, picD12.Click, picD13.Click, picD14.Click, picD15.Click, picD16.Click,
                                                                         picE01.Click, picE02.Click, picE03.Click, picE04.Click, picE05.Click, picE06.Click, picE07.Click, picE08.Click,
                                                                         picE09.Click, picE10.Click, picE11.Click, picE12.Click, picE13.Click, picE14.Click, picE15.Click, picE16.Click,
                                                                         picF01.Click, picF02.Click, picF03.Click, picF04.Click, picF05.Click, picF06.Click, picF07.Click, picF08.Click,
                                                                         picF09.Click, picF10.Click, picF11.Click, picF12.Click, picF13.Click, picF14.Click, picF15.Click, picF16.Click,
                                                                         picG01.Click, picG02.Click, picG03.Click, picG04.Click, picG05.Click, picG06.Click, picG07.Click, picG08.Click,
                                                                         picG09.Click, picG10.Click, picG11.Click, picG12.Click, picG13.Click, picG14.Click, picG15.Click, picG16.Click,
                                                                         picH01.Click, picH02.Click, picH03.Click, picH04.Click, picH05.Click, picH06.Click, picH07.Click, picH08.Click,
                                                                         picH09.Click, picH10.Click, picH11.Click, picH12.Click, picH13.Click, picH14.Click, picH15.Click, picH16.Click,
                                                                         picI01.Click, picI02.Click, picI03.Click, picI04.Click, picI05.Click, picI06.Click, picI07.Click, picI08.Click,
                                                                         picI09.Click, picI10.Click, picI11.Click, picI12.Click, picI13.Click, picI14.Click, picI15.Click, picI16.Click,
                                                                         picJ01.Click, picJ02.Click, picJ03.Click, picJ04.Click, picJ05.Click, picJ06.Click, picJ07.Click, picJ08.Click,
                                                                         picJ09.Click, picJ10.Click, picJ11.Click, picJ12.Click, picJ13.Click, picJ14.Click, picJ15.Click, picJ16.Click
        'OBJECTIVE
        '1. Check what status is this
        '2. if it is a sold out, do nothing.
        '3. if it is a available, then change to selected
        Try
            Dim seatClicked As PictureBox = CType(sender, PictureBox)
            Dim strSeatNo As String
            Dim hashSet As SortedSet(Of String) = New SortedSet(Of String)(CurrentTransaction.strSeatSelected)
            Dim selectedCt As Integer = CurrentTransaction.strSeatSelected.Count

            If seatClicked.Image Is seatAvailable Then
                If frmTicketing.intMaxSeatCount = 0 Then
                    Throw New Exception("Please select number of ticket(s) first!")
                ElseIf selectedCt = frmTicketing.intMaxSeatCount Then
                    Throw New Exception("The number of selected seats is met! Please add more ticket(s) in order to select seats.")
                Else
                    seatClicked.Image = seatSelected
                    strSeatNo = seatClicked.Name.Substring(3)
                    hashSet.Add(strSeatNo)
                    selectedCt += 1
                End If

            ElseIf seatClicked.Image Is seatSelected Then
                seatClicked.Image = seatAvailable
                strSeatNo = seatClicked.Name.Substring(3)
                hashSet.Remove(strSeatNo)
                selectedCt -= 1
            End If
            CurrentTransaction.strSeatSelected = hashSet.ToList

            UpdateSeatSelected()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UpdateSeatSelected()
        Dim strShow As String = CurrentTransaction.ToSelectedSeatsString

        frmTicketing.txtSeats.Text = If(CurrentTransaction.strSeatSelected.Count = 0, "N/A", strShow)
        frmTicketing.lblCount.Text = String.Format("{0} of {1} selected", CurrentTransaction.strSeatSelected.Count, frmTicketing.intMaxSeatCount)
    End Sub

    Private Sub ucHallNormal_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        'Triggered when ShowingTime is changed
        ucHallNormal_Load(Nothing, Nothing)
    End Sub
End Class
