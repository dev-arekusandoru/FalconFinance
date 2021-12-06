<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.gbRates = New System.Windows.Forms.GroupBox()
        Me.radRate = New System.Windows.Forms.RadioButton()
        Me.radSelectList = New System.Windows.Forms.RadioButton()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.cbRate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstAmounts = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.lblTotalInterestPaid = New System.Windows.Forms.Label()
        Me.lblMonthlyPay = New System.Windows.Forms.Label()
        Me.lblTotalInterestPay = New System.Windows.Forms.Label()
        Me.gbRates.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(27, 36)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(86, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Principal Amount"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(27, 79)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(91, 13)
        Me.lblDuration.TabIndex = 1
        Me.lblDuration.Text = "Duration (Months)"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(132, 33)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 2
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(132, 76)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 3
        '
        'gbRates
        '
        Me.gbRates.Controls.Add(Me.Label3)
        Me.gbRates.Controls.Add(Me.cbRate)
        Me.gbRates.Controls.Add(Me.txtRate)
        Me.gbRates.Controls.Add(Me.radSelectList)
        Me.gbRates.Controls.Add(Me.radRate)
        Me.gbRates.Location = New System.Drawing.Point(30, 129)
        Me.gbRates.Name = "gbRates"
        Me.gbRates.Size = New System.Drawing.Size(267, 129)
        Me.gbRates.TabIndex = 4
        Me.gbRates.TabStop = False
        Me.gbRates.Text = "Rates"
        '
        'radRate
        '
        Me.radRate.AutoSize = True
        Me.radRate.Location = New System.Drawing.Point(8, 30)
        Me.radRate.Name = "radRate"
        Me.radRate.Size = New System.Drawing.Size(122, 17)
        Me.radRate.TabIndex = 0
        Me.radRate.TabStop = True
        Me.radRate.Text = "Enter rate in text box"
        Me.radRate.UseVisualStyleBackColor = True
        '
        'radSelectList
        '
        Me.radSelectList.AutoSize = True
        Me.radSelectList.Location = New System.Drawing.Point(8, 87)
        Me.radSelectList.Name = "radSelectList"
        Me.radSelectList.Size = New System.Drawing.Size(111, 17)
        Me.radSelectList.TabIndex = 1
        Me.radSelectList.TabStop = True
        Me.radSelectList.Text = "Select from the list"
        Me.radSelectList.UseVisualStyleBackColor = True
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(150, 29)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 2
        '
        'cbRate
        '
        Me.cbRate.FormattingEnabled = True
        Me.cbRate.Location = New System.Drawing.Point(150, 87)
        Me.cbRate.Name = "cbRate"
        Me.cbRate.Size = New System.Drawing.Size(100, 21)
        Me.cbRate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "OR"
        '
        'lstAmounts
        '
        Me.lstAmounts.FormattingEnabled = True
        Me.lstAmounts.Location = New System.Drawing.Point(332, 33)
        Me.lstAmounts.Name = "lstAmounts"
        Me.lstAmounts.Size = New System.Drawing.Size(286, 225)
        Me.lstAmounts.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(30, 297)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(132, 297)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(238, 302)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(88, 13)
        Me.lblMonthlyPayment.TabIndex = 8
        Me.lblMonthlyPayment.Text = "Monthly Payment"
        '
        'lblTotalInterestPaid
        '
        Me.lblTotalInterestPaid.AutoSize = True
        Me.lblTotalInterestPaid.Location = New System.Drawing.Point(444, 302)
        Me.lblTotalInterestPaid.Name = "lblTotalInterestPaid"
        Me.lblTotalInterestPaid.Size = New System.Drawing.Size(91, 13)
        Me.lblTotalInterestPaid.TabIndex = 10
        Me.lblTotalInterestPaid.Text = "Total interest paid"
        '
        'lblMonthlyPay
        '
        Me.lblMonthlyPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMonthlyPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyPay.Location = New System.Drawing.Point(332, 297)
        Me.lblMonthlyPay.Name = "lblMonthlyPay"
        Me.lblMonthlyPay.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlyPay.TabIndex = 11
        '
        'lblTotalInterestPay
        '
        Me.lblTotalInterestPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalInterestPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalInterestPay.Location = New System.Drawing.Point(541, 297)
        Me.lblTotalInterestPay.Name = "lblTotalInterestPay"
        Me.lblTotalInterestPay.Size = New System.Drawing.Size(77, 23)
        Me.lblTotalInterestPay.TabIndex = 12
        '
        'LoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 351)
        Me.Controls.Add(Me.lblTotalInterestPay)
        Me.Controls.Add(Me.lblMonthlyPay)
        Me.Controls.Add(Me.lblTotalInterestPaid)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstAmounts)
        Me.Controls.Add(Me.gbRates)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "LoanCalculator"
        Me.Text = "LoanCalculator"
        Me.gbRates.ResumeLayout(False)
        Me.gbRates.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents gbRates As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRate As ComboBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents radSelectList As RadioButton
    Friend WithEvents radRate As RadioButton
    Friend WithEvents lstAmounts As ListBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents lblTotalInterestPaid As Label
    Friend WithEvents lblMonthlyPay As Label
    Friend WithEvents lblTotalInterestPay As Label
End Class
