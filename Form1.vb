Public Class Form1

    ' Hides all other forms when Form 1 is open
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrencyConverter.Hide()
        LoanCalculator.Hide()
        InterestCalculator.Hide()
        UserLogin.Hide()
    End Sub

    ' Show the Currency Converter form when button is clicked
    Private Sub btnCurrencyConverter_Click(sender As Object, e As EventArgs) Handles btnCurrencyConverter.Click
        CurrencyConverter.Show()
    End Sub

    ' Show the Loan Calculator form when button is clicked
    Private Sub btnLoanCalculator_Click(sender As Object, e As EventArgs) Handles btnLoanCalculator.Click
        LoanCalculator.Show()
    End Sub

    ' Show the Interest Calculator form when button is clicked
    Private Sub btnInterestCalculator_Click(sender As Object, e As EventArgs) Handles btnInterestCalculator.Click
        InterestCalculator.Show()
    End Sub

    ' Close the form when Exit button is clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

    End Sub
End Class
