Imports System.ComponentModel

Public Class frmLoading
    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    'NOT WORKING, NOT ANIMATED

    '    Dim num As Integer = 1
    '    While True
    '        If num Mod 3 = 0 Then
    '            BackgroundWorker1.ReportProgress(num Mod 100, "Loading.")
    '        ElseIf num Mod 3 = 1 Then
    '            BackgroundWorker1.ReportProgress(num Mod 100, "Loading..")
    '        Else
    '            BackgroundWorker1.ReportProgress(num Mod 100, "Loading...")
    '        End If

    '        num += 1

    '        Application.DoEvents()
    '        Delay(500)
    '    End While
    'End Sub

    'Private Sub Delay(ByVal DelayInMilliseconds As Integer)
    '    Dim ts As TimeSpan
    '    Dim targetTime As DateTime = DateTime.Now.AddMilliseconds(DelayInMilliseconds)
    '    Do
    '        ts = targetTime.Subtract(DateTime.Now)
    '        Application.DoEvents() ' keep app responsive
    '        'System.Threading.Thread.Sleep(50) ' reduce CPU usage
    '    Loop While ts.TotalSeconds > 0
    'End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Label1.Text = e.UserState.ToString
        lblMessage.Text = "Loading..."
    End Sub

    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class