﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InterestCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPrinciple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(530, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Falcon Finance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtPrinciple)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(55, 182)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(441, 300)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(247, 192)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(171, 43)
        Me.txtTime.TabIndex = 5
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(247, 132)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(171, 43)
        Me.txtRate.TabIndex = 4
        '
        'txtPrinciple
        '
        Me.txtPrinciple.Location = New System.Drawing.Point(247, 70)
        Me.txtPrinciple.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(171, 43)
        Me.txtPrinciple.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Time (Years)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 37)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Interest Rate (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Principle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtResult)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(532, 182)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(447, 300)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(207, 132)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(171, 43)
        Me.txtResult.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(29, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "End Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(55, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(540, 59)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Simple Interest Calculator"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Window
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(851, 508)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.Window
        Me.btnCalc.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnCalc.Location = New System.Drawing.Point(677, 508)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(147, 50)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'InterestCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 584)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InterestCalculator"
        Me.Text = "Interest Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtPrinciple As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
End Class
