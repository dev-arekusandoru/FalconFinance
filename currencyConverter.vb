Public Class CurrencyConverter

    ' Hides the other forms when Currency Converter is open
    Private Sub CurrencyConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    ' Clears Dollar Amount if Type or Amount is changed
    Private Sub ClearDollarAmount(sender As Object, E As EventArgs) _
        Handles ComboBox1.TextChanged, txtAmount.TextChanged

        lblDollarAmount.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblAmount As Double = txtAmount.Text
        Dim strType As String = ComboBox1.Text
        Dim dblDollarAmount As Double
        Dim strMessage As String = "You have neglected to select a currency type!"

        If strType = "euro" Then
            dblDollarAmount = dblAmount * 1.128
        ElseIf strType = "peso" Then
            dblDollarAmount = dblAmount * 0.04708
        ElseIf strType = "pound sterling" Then
            dblDollarAmount = dblAmount * 1.323
        ElseIf strType = "franc" Then
            dblDollarAmount = dblAmount * 0.1714
        ElseIf strType = "rupee" Then
            dblDollarAmount = dblAmount * 0.0132573
        Else
            MessageBox.Show(strMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        lblDollarAmount.Text = dblDollarAmount.ToString("C2")

    End Sub

    ' Returns to Form 1 when Exit button is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'Accept only numbers, the period, and the Backspace key.
    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

End Class