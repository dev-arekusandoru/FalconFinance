Imports System.Data.OleDb
Public Class Form1
    Private Const ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Databases\users.mdb"
    Private con As OleDbConnection
    Private cmd As OleDbCommand

    Public tableId As Integer

    Dim firstName As String
    Dim lastName As String
    Public userPass As String
    Public checkingBal As Double
    Public savingBal As Double
    Public emergencyBal As Double
    Public checkingP As Double
    Public savingP As Double
    Public emergencyP As Double


    ' Hides all other forms when Form 1 is open
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrencyConverter.Hide()
        LoanCalculator.Hide()
        InterestCalculator.Hide()

        Dim reader As OleDbDataReader = Nothing
        Using con = New OleDbConnection(ConnectionString)
            cmd = New OleDbCommand()
            cmd.CommandText = "SELECT * FROM users WHERE ID = " & tableId
            cmd.Connection = con
            con.Open()
            reader = cmd.ExecuteReader

            While reader.Read
                firstName = reader.GetValue(3)
                lastName = reader.GetValue(4)
                checkingBal = reader.GetValue(5)
                savingBal = reader.GetValue(6)
                emergencyBal = reader.GetValue(7)
                savingP = reader.GetValue(8)
                emergencyP = reader.GetValue(9)
                checkingP = 100 - (reader.GetValue(8) + reader.GetValue(9))
                userPass = reader.GetValue(10)
            End While

            con.Close()
        End Using
        lblCheckingBalance.Text = checkingBal.ToString("c2")
        lblSavingsBalance.Text = savingBal.ToString("c2")
        lblEmergencyFundBalance.Text = emergencyBal.ToString("c2")
        lblWelcome.Text += ", " & firstName
    End Sub

    ' Show the Currency Converter form when button is clicked
    Private Sub btnCurrencyConverter_Click(sender As Object, e As EventArgs) Handles btnCurrencyConverter.Click
        CurrencyConverter.Show()

        CurrencyConverter.lblDollarAmount.Text = String.Empty
        CurrencyConverter.txtAmount.Text = String.Empty
        CurrencyConverter.ComboBox1.SelectedIndex = -1

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

    ' Updates the balances in the table
    Public Sub updateBalances()
        Using con = New OleDbConnection(ConnectionString)
            cmd = New OleDbCommand()
            cmd.CommandText = "UPDATE users SET checkingBal = " & checkingBal & ", savingBal = " & savingBal & ", emergencyBal = " & emergencyBal & " WHERE ID = " & tableId
            cmd.Connection = con
            con.Open()
            cmd.ExecuteReader()
            con.Close()
        End Using
        lblCheckingBalance.Text = checkingBal.ToString("C2")
        lblSavingsBalance.Text = savingBal.ToString("C2")
        lblEmergencyFundBalance.Text = emergencyBal.ToString("C2")
    End Sub

    ' Prompt the user to deposit money
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim strAmount As String = InputBox("What account? " & checkingP & "% will be deposited to your checking account, " & savingP & "% to your savings, and " & emergencyP & "% to your emergency fund.")
        Dim dblAmount As Double
        Double.TryParse(strAmount, dblAmount)
        Dim dblCheckingBalance As Double = (checkingP / 100) * dblAmount
        Dim dblSavingsBalance As Double = (savingP / 100) * dblAmount
        Dim dblEmergencyBalance As Double = (emergencyP / 100) * dblAmount

        checkingBal += dblCheckingBalance
        savingBal += dblCheckingBalance
        emergencyBal += dblEmergencyBalance

        Call updateBalances()



    End Sub

    ' Prompt the user to withdraw money
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Withdraw.Show()
        LoanCalculator.Hide()
        CurrencyConverter.Hide()
        InterestCalculator.Hide()
        UserLogin.Hide()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        settings.Show()
    End Sub


End Class
