Public Class frmMovieCreate
    Dim db As New KingDBDataContext()

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MovieImage\")
            Dim movie As New Movie()
            movie.Movie_Id = 0
            movie.Movie_Title = txtName.Text
            movie.Movie_Desc = txtDesc.Text
            movie.Movie_Rating = cboRating.SelectedItem.ToString
            movie.Movie_Status = "Active"
            movie.Movie_Image = txtName.Text + ".jpeg"
        db.Movies.InsertOnSubmit(movie)
        pbImage.Image.Save(path + txtName.Text + ".jpeg", Imaging.ImageFormat.Jpeg)
        db.SubmitChanges()
        MsgBox("Movie create successful", CType(0, MsgBoxStyle), "Success")
            clearForm()
            frmShowMovie.needRefresh = True
        Catch ex As Exception
            MsgBox("Please fill in correctly", CType(48, MsgBoxStyle), "Error")
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            pbImage.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MsgBox("Image browse fail, Please Try Again", CType(48, MsgBoxStyle), "Error")
        End If
    End Sub

    Private Sub clearForm()
        txtName.Text = ""
        txtDesc.Text = ""
        cboRating.SelectedIndex = -1
        pbImage.Image = Nothing
        txtName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
