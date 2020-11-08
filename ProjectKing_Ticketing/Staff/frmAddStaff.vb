Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices

Public Class frmAddStaff
    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_GET_STATUS As Integer = WM_CAP + 54
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1
    Private DeviceID As Integer = 0
    Private hHwnd As Integer

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStaffJoinDate.Text = DateTime.Now.ToString()
        NextID()
        btnRefresh.BackgroundImageLayout = ImageLayout.Stretch
        staffTooltip.SetToolTip(btnRefresh, "Please click this if staff ID were duplicated")
        dtpStaffDOB.Format = DateTimePickerFormat.Custom
        dtpStaffDOB.CustomFormat = "dd MMMM yyyy"
        ClosePreviewWindow()
    End Sub

    Private Sub clearForm()
        txtStaffName.Text = ""
        mskStaffIC.Text = ""
        txtStaffEmail.Text = ""
        mskStaffPhone.Text = ""
        txtStaffPass.Text = ""
        txtStaffConfirmPass.Text = ""
        cboStaffRole.SelectedIndex = -1
        txtStaffJoinDate.Text = DateTime.Now.ToString()
        radFemale.Checked = True
        txtStaffName.Focus()
        staffErr.Clear()
        pbStaffImage.Image = Nothing
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        clearForm()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        clearForm()
        Me.Close()
    End Sub

    Private Sub cboStaffRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStaffRole.SelectedIndexChanged
        If cboStaffRole.SelectedIndex <> -1 Then
            txtStaffConfirmPass.Enabled = True
            txtStaffPass.Enabled = True
        End If
    End Sub

    Private Sub NextID()
        Dim db As New KingDBDataContext()

        Dim id = From o In db.Staffs
        Dim idd = id.Count() + 1

        lblStaffID.Text = "S" + idd.ToString("0000")
    End Sub

    Function duplicateId(id As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Staffs.Any(Function(o) o.Staff_Id = id)
    End Function

    Function duplicateEmail(email As String) As Boolean
        Dim db As New KingDBDataContext()
        Return db.Staffs.Any(Function(o) o.Staff_Email = email)
    End Function

    Private Sub txtStaffName_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffName.Validating
        Dim chkName As String = txtStaffName.Text.Trim()

        If chkName = "" Then
            staffErr.SetError(txtStaffName, "Staff Name is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtStaffName, Nothing)
        End If
    End Sub

    Private Sub mskStaffIC_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles mskStaffIC.Validating
        Dim chkIc As String = If(mskStaffIC.MaskCompleted, mskStaffIC.Text, "")

        If chkIc = "" Then
            staffErr.SetError(mskStaffIC, "- Staff IC is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(mskStaffIC, Nothing)
        End If
    End Sub

    Private Sub mskStaffPhone_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles mskStaffPhone.Validating
        Dim chkPhone As String = If(mskStaffPhone.MaskCompleted, mskStaffPhone.Text, "")

        If chkPhone = "" Then
            staffErr.SetError(mskStaffPhone, "- Staff Phone.No is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(mskStaffPhone, Nothing)
        End If
    End Sub

    Private Sub txtStaffEmail_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffEmail.Validating
        Dim chkEmail As String = txtStaffEmail.Text

        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(chkEmail)

        If chkEmail = "" Then
            staffErr.SetError(txtStaffEmail, "- Staff Email is Empty")
            e.Cancel = True
        ElseIf Not isValid Then
            staffErr.SetError(txtStaffEmail, "- Staff Email is not valid")
            e.Cancel = True
        ElseIf duplicateEmail(chkEmail) Then
            staffErr.SetError(txtStaffEmail, "- Email has been used by other staff")
            e.Cancel = True
        Else
            staffErr.SetError(txtStaffEmail, Nothing)
        End If
    End Sub

    Private Sub cboStaffRole_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles cboStaffRole.Validating
        Dim chkRole As ComboBox = cboStaffRole

        If chkRole.SelectedIndex = -1 Then
            staffErr.SetError(cboStaffRole, "- Staff Role is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(cboStaffRole, Nothing)
        End If
    End Sub

    Private Sub txtStaffPass_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffPass.Validating
        Dim chkPassword As String = txtStaffPass.Text

        If chkPassword = "" Then
            staffErr.SetError(txtStaffPass, "- Staff Password is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(txtStaffPass, Nothing)
        End If
    End Sub

    Private Sub txtStaffConfirmPass_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles txtStaffConfirmPass.Validating
        Dim chkConfirmPassword As String = txtStaffConfirmPass.Text

        If chkConfirmPassword = "" Then
            staffErr.SetError(txtStaffConfirmPass, "- Staff Confirm Password is Empty")
            e.Cancel = True
        ElseIf chkConfirmPassword <> txtStaffPass.Text Then
            staffErr.SetError(txtStaffConfirmPass, "- Staff password does not match")
            e.Cancel = True
        Else
            staffErr.SetError(txtStaffConfirmPass, Nothing)
        End If
    End Sub

    Private Sub btnCapture_Validating(sender As Object,
                                 e As System.ComponentModel.CancelEventArgs) Handles btnCapture.Validating

        If pbStaffImage.Image Is Nothing Then
            staffErr.SetError(btnCapture, "- Staff Images is Empty")
            e.Cancel = True
        Else
            staffErr.SetError(btnCapture, Nothing)
        End If
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim gender As String
        Dim staffDate As Date
        Dim name As String = txtStaffName.Text.Trim()

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "StaffImage\")

        staffDate = Convert.ToDateTime(txtStaffJoinDate.Text)

        If radFemale.Checked Then
            gender = "Female"
        Else 'radMale.Checked
            gender = "Male"
        End If

        Try
            Dim s As New Staff()
            s.Staff_Id = lblStaffID.Text
            s.Staff_Password = txtStaffConfirmPass.Text
            s.Staff_Name = name
            s.Staff_Role = cboStaffRole.SelectedItem.ToString
            s.Staff_Email = txtStaffEmail.Text
            s.Staff_DoB = dtpStaffDOB.Value
            s.Staff_IC = mskStaffIC.Text
            s.Staff_Phone = mskStaffPhone.Text
            s.Staff_Gender = gender
            s.Staff_StartDate = staffDate
            s.Staff_Status = txtStaffStatus.Text
            s.Staff_Picture = lblStaffID.Text + ".jpeg"
            pbStaffImage.Image.Save(path + lblStaffID.Text + ".jpeg", Imaging.ImageFormat.Jpeg)

            If duplicateId(lblStaffID.Text) Then
                MessageBox.Show("Staff [" + lblStaffID.Text + "] is duplicated, please click the refresh button besides", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim db As New KingDBDataContext()
                db.Staffs.InsertOnSubmit(s)
                db.SubmitChanges()

                MessageBox.Show("Staff [" + txtStaffName.Text + "] added successfully", "Staff Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearForm()
                NextID()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        NextID()
    End Sub

    Public Structure CAPSTATUS
        Dim uiImageWidth As Integer
        Dim uiImageHeight As Integer
        Dim fLiveWindow As Integer
        Dim fOverlayWindow As Integer
        Dim fScale As Integer
        Dim ptScroll As POINTAPI
        Dim fUsingDefaultPalette As Integer
        Dim fAudioHardware As Integer
        Dim fCapFileExists As Integer
        Dim dwCurrentVideoFrame As Integer
        Dim dwCurrentVideoFramesDropped As Integer
        Dim dwCurrentWaveSamples As Integer
        Dim dwCurrentTimeElapsedMS As Integer
        Dim hPalCurrent As Integer
        Dim fCapturingNow As Integer
        Dim dwReturn As Integer
        Dim wNumVideoAllocated As Integer
        Dim wNumAudioAllocated As Integer
    End Structure

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        ByRef lParam As CAPSTATUS) As Boolean


    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
       (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Boolean,
       ByRef lParam As Integer) As Boolean


    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
         (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
         ByRef lParam As Integer) As Boolean


    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
         (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
         ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
         ByVal nHeight As Short, ByVal hWndParent As Integer,
         ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = pbStaffImage.Height
        Dim iWidth As Integer = pbStaffImage.Width

        ' Open Preview window in picturebox
        hHwnd = capCreateCaptureWindowA(DeviceID.ToString, WS_VISIBLE Or WS_CHILD, 0, 0, 1280,
            1024, pbStaffImage.Handle.ToInt32, 0)

        ' Connect to device
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, DeviceID, 0) Then

            'Set the preview scale
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            'Set the preview rate in milliseconds
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            'Start previewing the image from the camera
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            ' Resize window to fit in picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pbStaffImage.Width, pbStaffImage.Height,
                    SWP_NOMOVE Or SWP_NOZORDER)
        Else
            ' Error connecting to device close window
            DestroyWindow(hHwnd)
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        OpenPreviewWindow()
        Dim bReturn As Boolean
        Dim s As CAPSTATUS
        bReturn = SendMessage(hHwnd, WM_CAP_GET_STATUS, Marshal.SizeOf(s), s)
        Debug.WriteLine(String.Format("Video Size {0} x {1}", s.uiImageWidth, s.uiImageHeight))
    End Sub

    Private Sub ClosePreviewWindow()

        ' Disconnect from device
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, DeviceID, 0)

        ' close window
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        Dim data As IDataObject
        Dim bmap As Bitmap

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        'Get image from clipboard And convert it to a bitmap
        data = Clipboard.GetDataObject()

        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            pbStaffImage.Image = bmap
            ClosePreviewWindow()

            If My.Computer.Clipboard.ContainsImage() Then
                MsgBox("Capture Successfully")
            Else
                MsgBox("Capture Failed")
            End If

        End If
    End Sub

End Class