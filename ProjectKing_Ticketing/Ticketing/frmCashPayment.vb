Public Class frmCashPayment

    Private staff As New Staff
    Private Sub grpNumberPad_Click(sender As Object, e As EventArgs)
        '1. Get which btn is clicked
        '2. Just add the numberclicked to the far right behind
        '3. Update lblReceived
        Try
            Dim btnClicked As Button = CType(sender, Button)
            Dim strAmtReceived As String = lblReceived.Text

            Select Case btnClicked.Text
                Case "" 'Clicked backscape button
                    If strAmtReceived.Length = 1 Then
                        strAmtReceived = Nothing
                    Else
                        strAmtReceived = strAmtReceived.Substring(0, strAmtReceived.Length - 1)
                    End If
                Case Else 'Clicked 0-9 & "."
                    'Must check if there's already a decimal
                    'strAmtReceived.Contains(".") or throw exception
                    strAmtReceived &= btnClicked.Text

                    Dim decAmtReceived As Decimal = Decimal.Parse(strAmtReceived) 'Will throw FormatException if doesn't meet Decimal format

                    If Not decAmtReceived * 100 = Math.Floor(decAmtReceived * 100) Then 'To check if it is 2 decimal places
                        Throw New FormatException ' Has more than 2 digit
                    End If
            End Select

            lblReceived.Text = strAmtReceived

        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("There's no more digit to be delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As FormatException
            MessageBox.Show("Invalid currency format input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Exception caught: {0}", "Debugging Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Used for debugging
        End Try
    End Sub

    Private Sub frmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReset_Click(Nothing, Nothing)

        btnPay.Text = If(frmPayment.btnPayNow.Enabled, "&Pay", "C&lose")

        For Each ctrl As Control In grpNumberPad.Controls
            If TypeOf ctrl Is Button Then
                AddHandler ctrl.Click, AddressOf grpNumberPad_Click
            End If
        Next

        For Each ctrl As Control In grpAddMoney.Controls
            If TypeOf ctrl Is Button And ctrl IsNot btnExact Then
                AddHandler ctrl.Click, AddressOf grpAddMoney_Click
            End If
        Next
    End Sub

    Private Sub lblReceived_TextChanged(sender As Object, e As EventArgs) Handles lblReceived.TextChanged
        '1. If the lblReceived >= lblPayable
        '   then enable btnOK
        '   else disable btnOK
        '2. If lblReceived.Contains("."), disable . button, else enable
        '3. If there's Nothing in lblReceived, disable backscape btn, else enable

        Dim decAmtReceived As Decimal = If(lblReceived.Text = Nothing, 0, Decimal.Parse(lblReceived.Text))
        Dim decAmtPayable As Decimal = Decimal.Parse(lblPayable.Text)

        btnPay.Enabled = If(decAmtReceived >= decAmtPayable, True, False)
        btnDot.Enabled = If(lblReceived.Text.Contains("."), False, True)

        If Not decAmtReceived * 10 = Math.Floor(decAmtReceived * 10) Then 'To check if it is 2 decimal places
            ' Has 2 digit
            ActivateNumberPad(False)
        Else
            'has < 2 digits
            ActivateNumberPad(True)
        End If
    End Sub

    Private Sub ActivateNumberPad(isEnabled As Boolean)
        For Each ctrl As Control In grpNumberPad.Controls
            If TypeOf ctrl Is Button Then
                'Dim num As Integer
                'Integer.TryParse(ctrl.Text, num)

                'If num <> Nothing Then 'execute when it is 
                '    ctrl.Enabled = isEnabled
                'End If
                If ctrl.Text = "0" Or ctrl.Text = "1" Or ctrl.Text = "2" Or ctrl.Text = "3" Or ctrl.Text = "4" Or
                   ctrl.Text = "5" Or ctrl.Text = "6" Or ctrl.Text = "7" Or ctrl.Text = "8" Or ctrl.Text = "9" Then
                    ctrl.Enabled = isEnabled
                End If
            End If
        Next
    End Sub

    Private Sub frmPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If (e.KeyChar >= Chr(48) And e.KeyChar <= Convert.ToChar(57)) Or
           (e.KeyChar >= Chr(96) And e.KeyChar <= Convert.ToChar(105)) Or e.KeyChar = "." Or e.KeyChar = Chr(8) Then
            Dim codeAscii As Integer = Asc(e.KeyChar)

            Select Case codeAscii
                Case 48, 96 : grpNumberPad_Click(btn0, Nothing)
                Case 49, 97 : grpNumberPad_Click(btn1, Nothing)
                Case 50, 98 : grpNumberPad_Click(btn2, Nothing)
                Case 51, 99 : grpNumberPad_Click(btn3, Nothing)
                Case 52, 100 : grpNumberPad_Click(btn4, Nothing)
                Case 53, 101 : grpNumberPad_Click(btn5, Nothing)
                Case 54, 102 : grpNumberPad_Click(btn6, Nothing)
                Case 55, 103 : grpNumberPad_Click(btn7, Nothing)
                Case 56, 104 : grpNumberPad_Click(btn8, Nothing)
                Case 57, 105 : grpNumberPad_Click(btn9, Nothing)
                Case Asc(".") : grpNumberPad_Click(btnDot, Nothing)
                Case 8 : grpNumberPad_Click(btnBackspace, Nothing) 'btnBackspace.PerformClick()
            End Select
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If btnPay.Text = "&Pay" Then
            Dim decAmtPayable As Decimal = Decimal.Parse(lblPayable.Text)
            Dim decAmtReceived As Decimal = Decimal.Parse(lblReceived.Text)

            Dim decAmtChange As Decimal = decAmtReceived - decAmtPayable

            CurrentTransaction.trx.Payment_Method = "Cash"
            If CurrentTransaction.NewTransaction() Then
                MessageBox.Show("Transaction is processed successfully, please proceed to print ticket(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Transaction is not processed successfully, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            lblChange.Text = decAmtChange.ToString("F2")
            frmPayment.blnIsPaid = True
            btnReset.Enabled = False
            btnPay.Text = "C&lose"
        Else 'btnOK.Text = "&Close"
            btnBack_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblChange.Text = "N/A"
        lblRMChange.Visible = False
        With lblReceived
            .ResetText()
            .Select()
        End With
    End Sub

    Private Sub btnExact_Click(sender As Object, e As EventArgs) Handles btnExact.Click
        lblReceived.Text = lblPayable.Text
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub grpAddMoney_Click(sender As Object, e As EventArgs)
        Dim btnClicked As Button = CType(sender, Button)
        Dim decAmtToAdd As Decimal = Decimal.Parse(btnClicked.Text.Substring(4))
        Dim decAmtReceived As Decimal = 0

        If lblReceived.Text <> "" Then
            decAmtReceived = Decimal.Parse(lblReceived.Text)
        End If

        decAmtReceived += decAmtToAdd

        lblReceived.Text = decAmtReceived.ToString("F2")
    End Sub
End Class