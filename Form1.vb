﻿Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrencyConverter.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrencyConverter.Hide()
    End Sub
End Class
