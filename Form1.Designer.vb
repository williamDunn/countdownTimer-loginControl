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
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.CountdownTimer2 = New A11_DUNN.CountdownTimer()
        Me.CountdownTimer1 = New A11_DUNN.CountdownTimer()
        Me.LogIn1 = New A11_DUNN.LogIn()
        Me.SuspendLayout()
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(173, 331)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(176, 23)
        Me.btnPause.TabIndex = 3
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        Me.btnPause.Visible = False
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(173, 388)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(176, 23)
        Me.btnResume.TabIndex = 4
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = True
        Me.btnResume.Visible = False
        '
        'CountdownTimer2
        '
        Me.CountdownTimer2.HowLong = 120
        Me.CountdownTimer2.Location = New System.Drawing.Point(301, 235)
        Me.CountdownTimer2.Name = "CountdownTimer2"
        Me.CountdownTimer2.Size = New System.Drawing.Size(176, 68)
        Me.CountdownTimer2.TabIndex = 2
        '
        'CountdownTimer1
        '
        Me.CountdownTimer1.HowLong = 65
        Me.CountdownTimer1.Location = New System.Drawing.Point(43, 235)
        Me.CountdownTimer1.Name = "CountdownTimer1"
        Me.CountdownTimer1.Size = New System.Drawing.Size(176, 68)
        Me.CountdownTimer1.TabIndex = 1
        '
        'LogIn1
        '
        Me.LogIn1.CorrectPassword = "275"
        Me.LogIn1.CorrectUserName = "CPSC"
        Me.LogIn1.Location = New System.Drawing.Point(143, 26)
        Me.LogIn1.Name = "LogIn1"
        Me.LogIn1.Size = New System.Drawing.Size(234, 173)
        Me.LogIn1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 465)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.CountdownTimer2)
        Me.Controls.Add(Me.CountdownTimer1)
        Me.Controls.Add(Me.LogIn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogIn1 As LogIn
    Friend WithEvents CountdownTimer1 As CountdownTimer
    Friend WithEvents CountdownTimer2 As CountdownTimer
    Friend WithEvents btnPause As Button
    Friend WithEvents btnResume As Button
End Class
