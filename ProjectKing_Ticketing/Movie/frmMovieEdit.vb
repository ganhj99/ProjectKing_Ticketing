Public Class frmMovieEdit
    Dim db As New KingDBDataContext()
    Dim movieList As New List(Of Movie)

    Private Sub movieEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboMovie.Items.Clear()
        movieList.Clear()
        movieList = (From p In db.Movies Select p).ToList

        For Each movie In movieList
            cboMovie.Items.Add(movie.Movie_Title)
        Next
    End Sub

    Private Sub cboMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged
        If cboMovie.SelectedIndex = -1 Then

        Else
            For Each movie In movieList
                If cboMovie.SelectedItem.ToString = movie.Movie_Title Then
                    cboRating.SelectedItem = movie.Movie_Rating
                    txtDesc.Text = movie.Movie_Desc
                    If movie.Movie_Status = "Active" Then
                        chbActive.Checked = True
                    Else
                        chbActive.Checked = False
                    End If
                End If
            Next
        End If
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MovieImage\")

        If cboMovie.SelectedIndex = -1 Then
            pbImage.Image = Nothing
        Else
            Dim m = CType((From p In db.Movies Select p Where p.Movie_Title.Equals(cboMovie.SelectedItem.ToString)).Single(), Movie)
            Dim PicInFolder As String = System.IO.Path.Combine(path, m.Movie_Image)
            If pbImage.Image Is Nothing Then
            Else
                pbImage.Image.Dispose()
                pbImage.Image = Nothing
            End If
            pbImage.Image = Image.FromFile(PicInFolder)
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If pbImage.Image Is Nothing Then
            Else
                pbImage.Image.Dispose()
                pbImage.Image = Nothing
            End If
            pbImage.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MsgBox("Image browse fail, Please Try Again", CType(48, MsgBoxStyle), "Error")
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MovieImage\")
            Dim movieE As Movie = db.Movies.FirstOrDefault(Function(o) o.Movie_Title = cboMovie.SelectedItem.ToString)
            If movieE Is Nothing Then
            Else
                For Each pnl As Control In frmShowMovie.pnlMain.Controls
                    If TypeOf pnl Is Panel Then
                        If pnl.Name.Equals("panel" + movieE.Movie_Id.ToString) Then
                            For Each ctrl As Control In pnl.Controls
                                If TypeOf ctrl Is PictureBox Then
                                    Dim pic As PictureBox = CType(ctrl, PictureBox)
                                    If pic.Image Is Nothing Then
                                    Else
                                        pic.Image.Dispose()
                                        pic.Image = Nothing
                                    End If
                                Else
                                End If
                            Next
                        End If
                    End If
                Next

                movieE.Movie_Rating = cboRating.SelectedItem.ToString
                movieE.Movie_Desc = txtDesc.Text
                movieE.Movie_Image = movieE.Movie_Title + ".jpeg"
                Dim img = New Bitmap(pbImage.Image)
                pbImage.Image.Dispose()
                pbImage.Image = Nothing
                img.Save(path + movieE.Movie_Title + ".jpeg", Imaging.ImageFormat.Jpeg)
                pbImage.Image = img
                If chbActive.Checked = True Then
                    movieE.Movie_Status = "Active"
                Else
                    movieE.Movie_Status = "Inactive"
                End If
                db.SubmitChanges()

                For Each pnl As Control In frmShowMovie.pnlMain.Controls
                    If TypeOf pnl Is Panel Then
                        If pnl.Name.Equals("panel" + movieE.Movie_Id.ToString) Then
                            For Each ctrl As Control In pnl.Controls
                                If TypeOf ctrl Is PictureBox Then
                                    Dim pic As PictureBox = CType(ctrl, PictureBox)
                                    pic.Image = Image.FromFile(path & movieE.Movie_Image)
                                Else
                                End If
                            Next
                        End If
                    End If
                Next

                MsgBox("Movie edit successful", CType(0, MsgBoxStyle), "Success")
                clearForm()
                frmShowMovie.needRefresh = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "Please fill in correctly", CType(48, MsgBoxStyle), "Error")
        End Try
    End Sub

    Private Sub clearForm()
        cboMovie.SelectedIndex = -1
        txtDesc.Text = ""
        cboRating.SelectedIndex = -1
        pbImage.Image = Nothing
        chbActive.Checked = False
        cboMovie.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class