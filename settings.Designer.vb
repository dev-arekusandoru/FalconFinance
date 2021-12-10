<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.savingPercentBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkingPLbl = New System.Windows.Forms.Label()
        Me.savingPLbl = New System.Windows.Forms.Label()
        Me.emergencyPLbl = New System.Windows.Forms.Label()
        Me.emergencyPercentBtn = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'savingPercentBtn
        '
        Me.savingPercentBtn.BackColor = System.Drawing.SystemColors.Window
        Me.savingPercentBtn.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savingPercentBtn.Location = New System.Drawing.Point(12, 234)
        Me.savingPercentBtn.Name = "savingPercentBtn"
        Me.savingPercentBtn.Size = New System.Drawing.Size(496, 53)
        Me.savingPercentBtn.TabIndex = 0
        Me.savingPercentBtn.Text = "Change Saving %"
        Me.savingPercentBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Percentages:"
        '
        'checkingPLbl
        '
        Me.checkingPLbl.AutoSize = True
        Me.checkingPLbl.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.checkingPLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.checkingPLbl.Location = New System.Drawing.Point(34, 71)
        Me.checkingPLbl.Name = "checkingPLbl"
        Me.checkingPLbl.Size = New System.Drawing.Size(172, 42)
        Me.checkingPLbl.TabIndex = 4
        Me.checkingPLbl.Text = "Checking - "
        '
        'savingPLbl
        '
        Me.savingPLbl.AutoSize = True
        Me.savingPLbl.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.savingPLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.savingPLbl.Location = New System.Drawing.Point(34, 117)
        Me.savingPLbl.Name = "savingPLbl"
        Me.savingPLbl.Size = New System.Drawing.Size(135, 42)
        Me.savingPLbl.TabIndex = 5
        Me.savingPLbl.Text = "Saving - "
        '
        'emergencyPLbl
        '
        Me.emergencyPLbl.AutoSize = True
        Me.emergencyPLbl.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.emergencyPLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.emergencyPLbl.Location = New System.Drawing.Point(34, 161)
        Me.emergencyPLbl.Name = "emergencyPLbl"
        Me.emergencyPLbl.Size = New System.Drawing.Size(193, 42)
        Me.emergencyPLbl.TabIndex = 6
        Me.emergencyPLbl.Text = "Emergency -"
        '
        'emergencyPercentBtn
        '
        Me.emergencyPercentBtn.BackColor = System.Drawing.SystemColors.Window
        Me.emergencyPercentBtn.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emergencyPercentBtn.Location = New System.Drawing.Point(12, 293)
        Me.emergencyPercentBtn.Name = "emergencyPercentBtn"
        Me.emergencyPercentBtn.Size = New System.Drawing.Size(496, 53)
        Me.emergencyPercentBtn.TabIndex = 7
        Me.emergencyPercentBtn.Text = "Change Emergency %"
        Me.emergencyPercentBtn.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.Window
        Me.back.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(12, 352)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(245, 53)
        Me.back.TabIndex = 8
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.SystemColors.Window
        Me.logout.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(263, 352)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(245, 53)
        Me.logout.TabIndex = 9
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 420)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.emergencyPercentBtn)
        Me.Controls.Add(Me.emergencyPLbl)
        Me.Controls.Add(Me.savingPLbl)
        Me.Controls.Add(Me.checkingPLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savingPercentBtn)
        Me.Name = "settings"
        Me.Text = "settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents savingPercentBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents checkingPLbl As Label
    Friend WithEvents savingPLbl As Label
    Friend WithEvents emergencyPLbl As Label
    Friend WithEvents emergencyPercentBtn As Button
    Friend WithEvents back As Button
    Friend WithEvents logout As Button
End Class
