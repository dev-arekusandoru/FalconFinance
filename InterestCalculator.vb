Public Class InterestCalculator
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Gonna need help to connect to our other pages and use GitHub (again)
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPrinciple.TextChanged, txtTime.TextChanged, txtRate.TextChanged
        'Clears results if inputs are changed
        txtResult.Clear()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblPrinciple As Double
        Double.TryParse(txtPrinciple.Text, dblPrinciple)

        Dim dblTime As Double
        Double.TryParse(txtTime.Text, dblTime)

        Dim dblRate As Double
        Double.TryParse(txtRate.Text, dblRate)

        Dim dblResult As Double
        dblResult = dblPrinciple * (1 + ((dblRate / 100) * dblTime))

        'dblResult = -(Financial.Pmt(((dblRate / 100) / 12), (dblTime * 12), dblPrinciple)) 'credits to Suberi for this line

        txtResult.Text = dblResult.ToString("c")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
