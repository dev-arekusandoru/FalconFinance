Public Class Withdraw
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label2.Hide()
        txtVerify.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label2.Hide()
        txtVerify.Hide()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label2.Show()
        txtVerify.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblAmount As Double
        Double.TryParse(txtWithdrawAmount.Text, dblAmount)

        If RadioButton1.Checked Then
            If dblAmount <= Form1.checkingBal Then
                Form1.checkingBal = Form1.checkingBal - dblAmount
                Form1.updateBalances()
            Else
                MessageBox.Show("Please enter a valid amount")
            End If
        ElseIf RadioButton2.Checked Then
            If dblAmount <= Form1.savingBal Then
                Form1.savingBal = Form1.savingBal - dblAmount
                Form1.updateBalances()
            Else
                MessageBox.Show("Please enter a valid amount")
            End If

        ElseIf RadioButton3.Checked Then
            If Form1.userPass.Equals(txtVerify.Text.ToString) Then
                If dblAmount <= Form1.emergencyBal Then
                    Form1.emergencyBal = Form1.emergencyBal - dblAmount
                    Form1.updateBalances()
                Else
                    MessageBox.Show("Please enter a valid amount")
                End If
            Else
                MessageBox.Show("Incorrect Password")
            End If
        End If
    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Select()
        txtVerify.Text = String.Empty
        txtWithdrawAmount.Text = String.Empty
    End Sub
End Class

