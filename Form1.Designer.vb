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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblCheckingBalance = New System.Windows.Forms.Label()
        Me.lblSavingsBalance = New System.Windows.Forms.Label()
        Me.lblEmergencyFundBalance = New System.Windows.Forms.Label()
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
        Me.btnLoanCalculator.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnLoanCalculator.Location = New System.Drawing.Point(19, 39)
        Me.btnLoanCalculator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoanCalculator.Name = "btnLoanCalculator"
        Me.btnLoanCalculator.Size = New System.Drawing.Size(196, 33)
        Me.btnLoanCalculator.TabIndex = 0
        Me.btnLoanCalculator.Text = "Loan Calculator"
        Me.btnLoanCalculator.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCurrencyConverter)
        Me.GroupBox1.Controls.Add(Me.btnInterestCalculator)
        Me.GroupBox1.Controls.Add(Me.btnLoanCalculator)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(25, 351)
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
        Me.btnCurrencyConverter.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnCurrencyConverter.Location = New System.Drawing.Point(19, 145)
        Me.btnCurrencyConverter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCurrencyConverter.Name = "btnCurrencyConverter"
        Me.btnCurrencyConverter.Size = New System.Drawing.Size(196, 33)
        Me.btnCurrencyConverter.TabIndex = 2
        Me.btnCurrencyConverter.Text = "Currency Converter"
        Me.btnCurrencyConverter.UseVisualStyleBackColor = True
        '
        'btnInterestCalculator
        '
        Me.btnInterestCalculator.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnInterestCalculator.Location = New System.Drawing.Point(19, 91)
        Me.btnInterestCalculator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInterestCalculator.Name = "btnInterestCalculator"
        Me.btnInterestCalculator.Size = New System.Drawing.Size(196, 34)
        Me.btnInterestCalculator.TabIndex = 1
        Me.btnInterestCalculator.Text = "Interest Calculator"
        Me.btnInterestCalculator.UseVisualStyleBackColor = True
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
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 69)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FalconFinance"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTransfer)
        Me.GroupBox2.Controls.Add(Me.btnSettings)
        Me.GroupBox2.Controls.Add(Me.btnWithdraw)
        Me.GroupBox2.Controls.Add(Me.btnDeposit)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(25, 84)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(240, 247)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btnSettings
        '
        Me.btnSettings.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSettings.Location = New System.Drawing.Point(19, 194)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(196, 36)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnWithdraw.Location = New System.Drawing.Point(19, 87)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(196, 34)
        Me.btnWithdraw.TabIndex = 1
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnDeposit.Location = New System.Drawing.Point(19, 38)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(196, 33)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCheckingBalance)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSavingsBalance)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblEmergencyFundBalance)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe Print", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button2.Location = New System.Drawing.Point(439, 515)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnTransfer.Location = New System.Drawing.Point(19, 138)
        Me.btnTransfer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(196, 36)
        Me.btnTransfer.TabIndex = 3
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblCheckingBalance
        '
        Me.lblCheckingBalance.Location = New System.Drawing.Point(35, 42)
        Me.lblCheckingBalance.Name = "lblCheckingBalance"
        Me.lblCheckingBalance.Size = New System.Drawing.Size(189, 31)
        Me.lblCheckingBalance.TabIndex = 0
        '
        'lblSavingsBalance
        '
        Me.lblSavingsBalance.Location = New System.Drawing.Point(35, 42)
        Me.lblSavingsBalance.Name = "lblSavingsBalance"
        Me.lblSavingsBalance.Size = New System.Drawing.Size(189, 31)
        Me.lblSavingsBalance.TabIndex = 1
        '
        'lblEmergencyFundBalance
        '
        Me.lblEmergencyFundBalance.Location = New System.Drawing.Point(35, 42)
        Me.lblEmergencyFundBalance.Name = "lblEmergencyFundBalance"
        Me.lblEmergencyFundBalance.Size = New System.Drawing.Size(189, 31)
        Me.lblEmergencyFundBalance.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(650, 571)
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
    Friend WithEvents btnTransfer As Button
    Friend WithEvents lblCheckingBalance As Label
    Friend WithEvents lblSavingsBalance As Label
    Friend WithEvents lblEmergencyFundBalance As Label
End Class
