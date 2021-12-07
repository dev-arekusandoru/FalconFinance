Public Class CurrencyConverter

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblAmount As String
        Integer.TryParse(txtAmount.Text, dblAmount)
        Dim dblType As String
        Integer.TryParse(ComboBox1.Text, dblType)
        Dim dblDollarAmount As String

        Select Case dblType
            Case Is = "euro"
                dblDollarAmount = dblAmount * 1.128
            Case Is = "peso"
                dblDollarAmount = dblAmount * 0.04708
            Case Is = "pound sterling"
                dblDollarAmount = dblAmount * 1.323
            Case Is = "franc"
                dblDollarAmount = dblAmount * 0.1714
            Case Is = "rupee"
                dblDollarAmount = dblAmount * 0.0132573
        End Select


        lblDollarAmount.Text = dblDollarAmount.ToString("N2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    'Accept only numbers, the period, and the Backspace key.
    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

End Class