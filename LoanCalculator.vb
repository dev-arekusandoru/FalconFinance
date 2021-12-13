Public Class LoanCalculator
    Private Sub LoanCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrencyConverter.Hide()
        InterestCalculator.Hide()
        UserLogin.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Handle_DoubleInputs(sender As Object, e As KeyPressEventArgs) Handles txtPrincipal.KeyPress, txtRate.KeyPress
        ' allows the text box to accept only numbers, decimal point, and Backspace key, for double inputs

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub Handle_IntegerInputs(sender As Object, e As KeyPressEventArgs) Handles txtDuration.KeyPress
        ' allows the text box to accept only numbers, decimal point, and Backspace key, for integer inputs

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' define variables
        Dim dblPrincipal As Double
        Dim dblRate As Double
        Dim intDuration As Integer
        Dim dblTotalPayment As Double
        Dim dblPayment As Double
        Dim dblBalance As Double
        Dim dblPpmt As Double
        Dim dblIpmt As Double

        ' define and get principal
        Double.TryParse(txtPrincipal.Text, dblPrincipal)

        ' define and get duration
        Integer.TryParse(txtDuration.Text, intDuration)

        ' get rate from radio buttons
        If radRate.Checked Then
            Double.TryParse(txtRate.Text, dblRate)
        End If

        If radSelectList.Checked Then
            dblRate = cbRate.SelectedItem
        End If

        ' calculate monthly payment
        dblPayment = -(Financial.Pmt(((dblRate / 100) / 12), intDuration, dblPrincipal))
        lblMonthlyPay.Text = Format(dblPayment, "C2")

        ' calculate total payment
        dblTotalPayment = dblPayment * intDuration

        ' calculate balance
        dblBalance = dblTotalPayment

        ' calculate total interest payment
        lblTotalInterestPay.Text = Format((dblTotalPayment - dblPrincipal), "C2")

        ' display list headings
        lstAmounts.Items.Add("Year" & vbTab & "PA" & vbTab & "IA" & vbTab & "Balance")
        lstAmounts.Items.Add("--------" & vbTab & "--------" & vbTab & "--------" & vbTab & "--------")

        ' calculate list results
        For intMonth As Integer = 1 To intDuration
            dblPpmt = -(Financial.PPmt(((dblRate / 100) / 12), intMonth, intDuration, dblPrincipal))
            dblIpmt = -(Financial.IPmt(((dblRate / 100) / 12), intMonth, intDuration, dblPrincipal))

            dblBalance -= dblPayment

            lstAmounts.Items.Add(intMonth.ToString & vbTab & dblPpmt.ToString("C2") & vbTab & dblIpmt.ToString("C2") _
                & vbTab & dblBalance.ToString("C2"))

        Next
        'comment
    End Sub
    Private Sub txtPrincipal_TextChanged(sender As Object, e As EventArgs) Handles txtPrincipal.TextChanged
        lstAmounts.Items.Clear()
    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        lstAmounts.Items.Clear()
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        lstAmounts.Items.Clear()
    End Sub

    Private Sub cbRate_TextChanged(sender As Object, e As EventArgs) Handles cbRate.TextChanged
        lstAmounts.Items.Clear()
    End Sub


End Class