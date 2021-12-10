<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnLoanCalculator = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCurrencyConverter = New System.Windows.Forms.Button()
        Me.btnInterestCalculator = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCheckingBalance = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblSavingsBalance = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblEmergencyFundBalance = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoanCalculator
        '
        Me.btnLoanCalculator.BackColor = System.Drawing.SystemColors.Window
        Me.btnLoanCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanCalculator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnLoanCalculator.Location = New System.Drawing.Point(19, 39)
        Me.btnLoanCalculator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoanCalculator.Name = "btnLoanCalculator"
        Me.btnLoanCalculator.Size = New System.Drawing.Size(196, 33)
        Me.btnLoanCalculator.TabIndex = 0
        Me.btnLoanCalculator.Text = "Loan Calculator"
        Me.btnLoanCalculator.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCurrencyConverter)
        Me.GroupBox1.Controls.Add(Me.btnInterestCalculator)
        Me.GroupBox1.Controls.Add(Me.btnLoanCalculator)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(25, 320)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(240, 197)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Financial Tools"
        '
        'btnCurrencyConverter
        '
        Me.btnCurrencyConverter.BackColor = System.Drawing.SystemColors.Window
        Me.btnCurrencyConverter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCurrencyConverter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnCurrencyConverter.Location = New System.Drawing.Point(19, 145)
        Me.btnCurrencyConverter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCurrencyConverter.Name = "btnCurrencyConverter"
        Me.btnCurrencyConverter.Size = New System.Drawing.Size(196, 33)
        Me.btnCurrencyConverter.TabIndex = 2
        Me.btnCurrencyConverter.Text = "Currency Converter"
        Me.btnCurrencyConverter.UseVisualStyleBackColor = False
        '
        'btnInterestCalculator
        '
        Me.btnInterestCalculator.BackColor = System.Drawing.SystemColors.Window
        Me.btnInterestCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInterestCalculator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnInterestCalculator.Location = New System.Drawing.Point(19, 91)
        Me.btnInterestCalculator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInterestCalculator.Name = "btnInterestCalculator"
        Me.btnInterestCalculator.Size = New System.Drawing.Size(196, 34)
        Me.btnInterestCalculator.TabIndex = 1
        Me.btnInterestCalculator.Text = "Interest Calculator"
        Me.btnInterestCalculator.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(417, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 69)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FalconFinance"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSettings)
        Me.GroupBox2.Controls.Add(Me.btnWithdraw)
        Me.GroupBox2.Controls.Add(Me.btnDeposit)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(25, 90)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(240, 207)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.SystemColors.Window
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSettings.Location = New System.Drawing.Point(19, 143)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(196, 36)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.SystemColors.Window
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnWithdraw.Location = New System.Drawing.Point(19, 87)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(196, 34)
        Me.btnWithdraw.TabIndex = 1
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.SystemColors.Window
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnDeposit.Location = New System.Drawing.Point(19, 38)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(196, 33)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCheckingBalance)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(320, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(285, 87)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Checking Balance"
        '
        'lblCheckingBalance
        '
        Me.lblCheckingBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckingBalance.Location = New System.Drawing.Point(0, 42)
        Me.lblCheckingBalance.Name = "lblCheckingBalance"
        Me.lblCheckingBalance.Size = New System.Drawing.Size(285, 31)
        Me.lblCheckingBalance.TabIndex = 0
        Me.lblCheckingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSavingsBalance)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Location = New System.Drawing.Point(320, 278)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(285, 87)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Savings Balance"
        '
        'lblSavingsBalance
        '
        Me.lblSavingsBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblSavingsBalance.Location = New System.Drawing.Point(0, 42)
        Me.lblSavingsBalance.Name = "lblSavingsBalance"
        Me.lblSavingsBalance.Size = New System.Drawing.Size(285, 31)
        Me.lblSavingsBalance.TabIndex = 1
        Me.lblSavingsBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblEmergencyFundBalance)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Location = New System.Drawing.Point(320, 390)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(285, 87)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Emergency Fund Balance"
        '
        'lblEmergencyFundBalance
        '
        Me.lblEmergencyFundBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblEmergencyFundBalance.Location = New System.Drawing.Point(0, 42)
        Me.lblEmergencyFundBalance.Name = "lblEmergencyFundBalance"
        Me.lblEmergencyFundBalance.Size = New System.Drawing.Size(285, 31)
        Me.lblEmergencyFundBalance.TabIndex = 1
        Me.lblEmergencyFundBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(439, 515)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWelcome.Location = New System.Drawing.Point(25, 58)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(293, 29)
        Me.lblWelcome.TabIndex = 10
        Me.lblWelcome.Text = "Welcome"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 581)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "FalconFinance"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoanCalculator As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCurrencyConverter As Button
    Friend WithEvents btnInterestCalculator As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblCheckingBalance As Label
    Friend WithEvents lblSavingsBalance As Label
    Friend WithEvents lblEmergencyFundBalance As Label
    Friend WithEvents lblWelcome As Label
End Class
