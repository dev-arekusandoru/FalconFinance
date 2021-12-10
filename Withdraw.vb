Public Class Withdraw

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label2.Show()
        TextBox1.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label2.Hide()
        TextBox1.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label2.Hide()
        TextBox1.Hide()
    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrencyConverter.Hide()
        Form1.Hide()
        InterestCalculator.Hide()
        LoanCalculator.Hide()
        UserLogin.Hide()
    End Sub
End Class

