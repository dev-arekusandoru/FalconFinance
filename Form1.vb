Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrencyConverter.Hide()
        LoanCalculator.Hide()
        InterestCalculator.Hide()
    End Sub


    ' Show the Currency Converter form when button is clicked
    Private Sub btnCurrencyConverter_Click(sender As Object, e As EventArgs) Handles btnCurrencyConverter.Click
        CurrencyConverter.Show()
    End Sub

    ' Show the Loan Calculator form when button is clicked
    Private Sub btnLoanCalculator_Click(sender As Object, e As EventArgs) Handles btnLoanCalculator.Click
        LoanCalculator.Show()
    End Sub


End Class
