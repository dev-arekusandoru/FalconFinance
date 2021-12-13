Imports System.Data.OleDb
Public Class settings
    Private Const ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Databases\users.mdb"
    Private con As OleDbConnection
    Private cmd As OleDbCommand

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call updateLabels()
    End Sub

    Private Sub savingPercentBtn_Click(sender As Object, e As EventArgs) Handles savingPercentBtn.Click
        Dim newP As String = InputBox("Enter a new percentage: 0-" & (100 - Form1.emergencyP))
        Dim dblNewP As Double
        Double.TryParse(newP, dblNewP)

        If dblNewP >= 0 AndAlso dblNewP <= (100 - Form1.emergencyP) Then
            Form1.savingP = dblNewP
            Form1.checkingP = 100 - (Form1.savingP + Form1.emergencyP)

            Call updatePercentages()
            Call updateLabels()
        Else
            MessageBox.Show("Please enter a valid amount")
        End If




    End Sub

    Private Sub updateLabels()
        checkingPLbl.Text = "Checking - " & Form1.checkingP.ToString & "%"
        savingPLbl.Text = "Saving - " & Form1.savingP.ToString & "%"
        emergencyPLbl.Text = "Emergency - " & Form1.emergencyP.ToString & "%"
    End Sub
    Public Sub updatePercentages()
        Using con = New OleDbConnection(ConnectionString)
            cmd = New OleDbCommand()
            cmd.CommandText = "UPDATE users SET savingPercent = " & Form1.savingP & ", emergencyPercent = " & Form1.emergencyP & " WHERE ID = " & Form1.tableId
            cmd.Connection = con
            con.Open()
            cmd.ExecuteReader()
            con.Close()
        End Using
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
    End Sub


    Private Sub emergencyPercentBtn_Click(sender As Object, e As EventArgs) Handles emergencyPercentBtn.Click
        Dim newP As String = InputBox("Enter a new percentage: 0-" & (100 - Form1.savingP))
        Dim dblNewP As Double
        Double.TryParse(newP, dblNewP)

        If dblNewP >= 0 AndAlso dblNewP <= (100 - Form1.savingP) Then
            Form1.emergencyP = dblNewP
            Form1.checkingP = 100 - (Form1.savingP + Form1.emergencyP)

            Call updatePercentages()
            Call updateLabels()
        Else
            MessageBox.Show("Please enter a valid amount")
        End If
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form1.Close()
        LoanCalculator.Hide()
        InterestCalculator.Hide()
        Withdraw.Hide()
        CurrencyConverter.Hide()
        UserLogin.txtUsername.Text = String.Empty
        UserLogin.txtPassword.Text = String.Empty
        UserLogin.Show()
        Me.Hide()
    End Sub
End Class