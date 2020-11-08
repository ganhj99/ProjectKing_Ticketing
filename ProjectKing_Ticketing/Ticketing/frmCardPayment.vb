Imports System.ComponentModel

Public Class frmCardPayment
    Dim ctrlFocus As Control
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        If btnPay.Text = "&Pay" Then
            Dim decAmtPayable As Decimal = Decimal.Parse(lblPayable.Text)

            CurrentTransaction.trx.Payment_Method = "Credit/Debit Card"
            If CurrentTransaction.NewTransaction() Then
                MessageBox.Show("Transaction is processed successfully, please proceed to print ticket(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Transaction is not processed successfully, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            frmPayment.blnIsPaid = True
            btnReset.Enabled = False
            btnPay.Text = "C&lose"
            Me.Close()
        Else 'btnOK.Text = "&Close"
            btnBack_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With txtName
            .Clear()
            .Select()
        End With
        mskCardNo.Clear()
        cboMonth.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        mskCCV.Clear()
        radVisa.Checked = True
    End Sub

    Private Sub frmCardPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReset_Click(Nothing, Nothing)

        'uncomment with frmPayment 'btnPay.Text = If(frmPayment.btnPayNow.Enabled, "&Pay", "C&lose")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim chkName As String = txtName.Text

        If chkName = "" Then
            errCardPay.SetError(txtName, "Card Holder Name is empty")
            e.Cancel = True
        Else
            errCardPay.SetError(txtName, Nothing)
        End If
    End Sub

    Private Sub mskCardNo_Validating(sender As Object, e As CancelEventArgs) Handles mskCardNo.Validating
        Dim chkCardNo As String = mskCardNo.Text

        If chkCardNo = "" Then
            errCardPay.SetError(mskCardNo, "Card number is empty")
            e.Cancel = True
        ElseIf Not mskCardNo.MaskCompleted Then
            errCardPay.SetError(mskCardNo, "Credit/Debit card number is not completed")
            e.Cancel = True
        ElseIf Not isValidCardNo(chkCardNo.Replace("-", "")) Then
            errCardPay.SetError(mskCardNo, "Invalid Credit/Debit card number")
            e.Cancel = True
        Else
            errCardPay.SetError(mskCardNo, Nothing)
        End If
    End Sub

    Private Sub mskCCV_Validating(sender As Object, e As CancelEventArgs) Handles mskCCV.Validating
        Dim chkCCV As String = mskCCV.Text

        If chkCCV = "" Then
            errCardPay.SetError(mskCCV, "CCV is empty")
            e.Cancel = True
        ElseIf Not mskCCV.MaskCompleted Then
            errCardPay.SetError(mskCCV, "CCV is not completed")
            e.Cancel = True
        Else
            errCardPay.SetError(mskCCV, Nothing)
        End If
    End Sub

    Private Function isValidCardNo(value As String) As Boolean 'Luhn algorithm
        Return value.Select(Function(c, i) (AscW(c) - 48) << ((value.Length - i - 1) And 1)).Sum(Function(n) If(n > 9, n - 9, n)) Mod 10 = 0
    End Function

    Private Function isAllValidated() As Boolean
        Dim isValidate As Boolean = True

        If txtName.Text = "" Then
            Return False
        End If

        If Not mskCardNo.MaskCompleted Or mskCardNo.Text = "" Or Not isValidCardNo(mskCardNo.Text.Replace("-", "")) Then
            Return False
        End If

        If Not mskCCV.MaskCompleted Or mskCCV.Text = "" Then
            Return False
        End If

        If cboMonth.SelectedIndex = -1 Or cboYear.SelectedIndex = -1 Then 'Not selecting any month & year
            Return False
        End If

        Return isValidate
    End Function

    Private Sub grpCardDetails_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, mskCardNo.TextChanged, mskCCV.TextChanged, cboMonth.SelectedIndexChanged, cboYear.SelectedIndexChanged
        btnPay.Enabled = If(isAllValidated(), True, False)
    End Sub

    Private Sub frmCardPayment_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        btnReset_Click(Nothing, Nothing)
    End Sub
End Class