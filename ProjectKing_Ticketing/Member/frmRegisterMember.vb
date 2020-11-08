Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class frmRegisterMember
    Inherits System.Windows.Forms.Form

    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Private SurnameValid As Boolean
    Private EmailValid As Boolean

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim timeFormat As String = "dd/MM/yyyy"

        Dim db As New KingDBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Member_Email = txtMemberEmail.Text)

        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim validEmail As New Regex(regex.ToString())

        If txtMemberName.Text.Trim = "" Then
            MessageBox.Show("Please enter Member Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not reSurname.IsMatch(txtMemberName.Text) Then
            MessageBox.Show("Please enter Alphabetic Characters Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtMemberName.Focus()
            txtMemberName.Clear()

            SurnameValid = False
            Return

        ElseIf Not mskMemberIC.MaskCompleted Then
            MessageBox.Show("Please enter Member IC No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf Not mskMemberContact.MaskCompleted Then
            MessageBox.Show("Please enter Member Contact No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf txtMemberEmail.Text = "" Then
            MessageBox.Show("Please enter Member Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not regex.IsMatch(txtMemberEmail.Text.Trim) Then
            MessageBox.Show("Email format error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf isDuplicatedEmail(txtMemberEmail.Text) Then
            MessageBox.Show("Email has been used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf dtpickMemberBOF.Format = Nothing Then
            MessageBox.Show("Please select Member BoD!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf picMemberPhoto.Image.Equals("") Then
            MessageBox.Show("Please capture Member Profile Picture!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            frmConfirmPIN.lblName.Text = txtMemberName.Text
            frmConfirmPIN.lblICNO.Text = mskMemberIC.Text
            frmConfirmPIN.lblMobileNo.Text = mskMemberContact.Text
            frmConfirmPIN.lblEmail.Text = txtMemberEmail.Text
            frmConfirmPIN.lblBirthDate.Text = dtpickMemberBOF.Value.ToString(timeFormat)
            frmConfirmPIN.ShowDialog()
        End If
    End Sub

    Function isDuplicatedEmail(email As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Members.Any(Function(o) o.Member_Email = txtMemberEmail.Text)
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = picMemberPhoto.Height
        Dim iWidth As Integer = picMemberPhoto.Width

        ' Open Preview window in picturebox
        hHwnd = capCreateCaptureWindowA(CType(iDevice, String), WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, picMemberPhoto.Handle.ToInt32, 0)

        ' Connect to device
        If CBool(SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)) Then

            'Set the preview scale
            SendMessage(hHwnd, WM_CAP_SET_SCALE, CInt(True), 0)

            'Set the preview rate in milliseconds
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            'Start previewing the image from the camera
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, CInt(True), 0)

            ' Resize window to fit in picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picMemberPhoto.Width, picMemberPhoto.Height,
                    SWP_NOMOVE Or SWP_NOZORDER)

            btnCapture.Enabled = True
            btnOpenCam.Enabled = False
        Else
            ' Error connecting to device close window
            DestroyWindow(hHwnd)

            btnCapture.Enabled = False
        End If
    End Sub

    Private Sub btnOpenCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenCam.Click
        'iDevice = lstDevices.SelectedIndex
        OpenPreviewWindow()

        ' Copy image to clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
    End Sub

    Private Sub ClosePreviewWindow()
        ' Disconnect from device
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        ' close window
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        Dim data As IDataObject
        Dim bmap As Bitmap

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Get image from clipboard and convert it to a bitmap
        data = Clipboard.GetDataObject()

        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            picMemberPhoto.Image = bmap
            ClosePreviewWindow()

            Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "MemberImage\")
            picMemberPhoto.Image.Save(path + GetNextID() + ".jpeg", Imaging.ImageFormat.Jpeg)

            MessageBox.Show("Image capture successful", "Image Capture", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class