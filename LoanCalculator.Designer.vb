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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRate = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.radSelectList = New System.Windows.Forms.RadioButton()
        Me.radRate = New System.Windows.Forms.RadioButton()
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
        Me.lblPrincipal.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrincipal.Location = New System.Drawing.Point(40, 58)
        Me.lblPrincipal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(219, 36)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Principal Amount"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDuration.Location = New System.Drawing.Point(40, 138)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(233, 36)
        Me.lblDuration.TabIndex = 1
        Me.lblDuration.Text = "Duration (Months)"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(284, 63)
        Me.txtPrincipal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(196, 40)
        Me.txtPrincipal.TabIndex = 2
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(284, 144)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(196, 40)
        Me.txtDuration.TabIndex = 3
        '
        'gbRates
        '
        Me.gbRates.Controls.Add(Me.Label3)
        Me.gbRates.Controls.Add(Me.cbRate)
        Me.gbRates.Controls.Add(Me.txtRate)
        Me.gbRates.Controls.Add(Me.radSelectList)
        Me.gbRates.Controls.Add(Me.radRate)
        Me.gbRates.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRates.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbRates.Location = New System.Drawing.Point(60, 248)
        Me.gbRates.Margin = New System.Windows.Forms.Padding(6)
        Me.gbRates.Name = "gbRates"
        Me.gbRates.Padding = New System.Windows.Forms.Padding(6)
        Me.gbRates.Size = New System.Drawing.Size(536, 248)
        Me.gbRates.TabIndex = 4
        Me.gbRates.TabStop = False
        Me.gbRates.Text = "Rates"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(98, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "OR"
        '
        'cbRate
        '
        Me.cbRate.FormattingEnabled = True
        Me.cbRate.Items.AddRange(New Object() {"1", "2.5", "5", "7.5", "10", "15", "20"})
        Me.cbRate.Location = New System.Drawing.Point(316, 167)
        Me.cbRate.Margin = New System.Windows.Forms.Padding(6)
        Me.cbRate.Name = "cbRate"
        Me.cbRate.Size = New System.Drawing.Size(196, 44)
        Me.cbRate.TabIndex = 3
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(316, 56)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(196, 43)
        Me.txtRate.TabIndex = 2
        '
        'radSelectList
        '
        Me.radSelectList.AutoSize = True
        Me.radSelectList.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radSelectList.Location = New System.Drawing.Point(16, 167)
        Me.radSelectList.Margin = New System.Windows.Forms.Padding(6)
        Me.radSelectList.Name = "radSelectList"
        Me.radSelectList.Size = New System.Drawing.Size(268, 40)
        Me.radSelectList.TabIndex = 1
        Me.radSelectList.TabStop = True
        Me.radSelectList.Text = "Select from the list"
        Me.radSelectList.UseVisualStyleBackColor = True
        '
        'radRate
        '
        Me.radRate.AutoSize = True
        Me.radRate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radRate.Location = New System.Drawing.Point(16, 58)
        Me.radRate.Margin = New System.Windows.Forms.Padding(6)
        Me.radRate.Name = "radRate"
        Me.radRate.Size = New System.Drawing.Size(295, 40)
        Me.radRate.TabIndex = 0
        Me.radRate.TabStop = True
        Me.radRate.Text = "Enter rate in text box"
        Me.radRate.UseVisualStyleBackColor = True
        '
        'lstAmounts
        '
        Me.lstAmounts.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAmounts.FormattingEnabled = True
        Me.lstAmounts.ItemHeight = 33
        Me.lstAmounts.Location = New System.Drawing.Point(688, 63)
        Me.lstAmounts.Margin = New System.Windows.Forms.Padding(6)
        Me.lstAmounts.Name = "lstAmounts"
        Me.lstAmounts.Size = New System.Drawing.Size(632, 400)
        Me.lstAmounts.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.Window
        Me.btnCalc.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnCalc.Location = New System.Drawing.Point(60, 571)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 50)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Window
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(264, 571)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 50)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(462, 577)
        Me.lblMonthlyPayment.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(224, 36)
        Me.lblMonthlyPayment.TabIndex = 8
        Me.lblMonthlyPayment.Text = "Monthly Payment"
        '
        'lblTotalInterestPaid
        '
        Me.lblTotalInterestPaid.AutoSize = True
        Me.lblTotalInterestPaid.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInterestPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalInterestPaid.Location = New System.Drawing.Point(918, 575)
        Me.lblTotalInterestPaid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTotalInterestPaid.Name = "lblTotalInterestPaid"
        Me.lblTotalInterestPaid.Size = New System.Drawing.Size(228, 36)
        Me.lblTotalInterestPaid.TabIndex = 10
        Me.lblTotalInterestPaid.Text = "Total interest paid"
        '
        'lblMonthlyPay
        '
        Me.lblMonthlyPay.BackColor = System.Drawing.SystemColors.Window
        Me.lblMonthlyPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyPay.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPay.Location = New System.Drawing.Point(688, 571)
        Me.lblMonthlyPay.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMonthlyPay.Name = "lblMonthlyPay"
        Me.lblMonthlyPay.Size = New System.Drawing.Size(198, 42)
        Me.lblMonthlyPay.TabIndex = 11
        '
        'lblTotalInterestPay
        '
        Me.lblTotalInterestPay.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalInterestPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalInterestPay.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInterestPay.Location = New System.Drawing.Point(1170, 571)
        Me.lblTotalInterestPay.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTotalInterestPay.Name = "lblTotalInterestPay"
        Me.lblTotalInterestPay.Size = New System.Drawing.Size(152, 42)
        Me.lblTotalInterestPay.TabIndex = 12
        '
        'LoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1380, 675)
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
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "LoanCalculator"
        Me.Text = "Loan Calculator"
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
