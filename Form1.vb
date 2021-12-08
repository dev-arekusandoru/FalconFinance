Imports System.Data.OleDb
Public Class Form1
    Private Const ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Databases\users.mdb"
    Private con As OleDbConnection
    Private cmd As OleDbCommand

    Public tableId As Integer

    Dim fullName As String
    Dim checkingBal As Double
    Dim savingBal As Double
    Dim emergencyBal As Double
    Dim checkingP As Double
    Dim savingP As Double
    Dim emergencyP As Double


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
                fullName = reader.GetValue(3) & " " & reader.GetValue(4)
                checkingBal = reader.GetValue(5)
                savingBal = reader.GetValue(6)
                emergencyBal = reader.GetValue(7)
                savingP = reader.GetValue(8)
                emergencyP = reader.GetValue(9)
                checkingP = 100 - (reader.GetValue(8) + reader.GetValue(9))
            End While

            con.Close()
        End Using

        lblCheckingBalance.Text = checkingBal.ToString("c2")
        lblSavingsBalance.Text = savingBal.ToString("c2")
        lblEmergencyFundBalance.Text = emergencyBal.ToString("c2")
        lblWelcome.Text += ", " & fullName.Substring(0, fullName.IndexOf(" "))

    End Sub

    ' Show the Currency Converter form when button is clicked
    Private Sub btnCurrencyConverter_Click(sender As Object, e As EventArgs) Handles btnCurrencyConverter.Click
        CurrencyConverter.Show()
        Me.Hide()

        CurrencyConverter.lblDollarAmount.Text = String.Empty
        CurrencyConverter.txtAmount.Text = String.Empty
        CurrencyConverter.ComboBox1.SelectedIndex = -1

    End Sub

    ' Show the Loan Calculator form when button is clicked
    Private Sub btnLoanCalculator_Click(sender As Object, e As EventArgs) Handles btnLoanCalculator.Click
        LoanCalculator.Show()
        Me.Hide()
    End Sub

    ' Show the Interest Calculator form when button is clicked
    Private Sub btnInterestCalculator_Click(sender As Object, e As EventArgs) Handles btnInterestCalculator.Click
        InterestCalculator.Show()
        Me.Hide()
    End Sub

    ' Close the form when Exit button is clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim strAccount As String = InputBox("What account?")
        Dim strMoney As String = InputBox("Amount?")
        Dim dblCheckingBalance As Integer
        Dim dblSavingsBalance As Integer
        Dim dblEmergencyBalance As Integer

        ' Integer.TryParse()

        If strAccount = "Checking" Or "checking" Then
            dblCheckingBalance = dblCheckingBalance + strMoney
        ElseIf strAccount = "Savings" Or "savings" Then
            dblSavingsBalance = dblSavingsBalance + strMoney
        ElseIf strAccount = "Emergency Fund" Or "emergency fund" Or "Emergency fund" Then
            dblEmergencyBalance = dblEmergencyBalance + strMoney
        End If
    End Sub



End Class
