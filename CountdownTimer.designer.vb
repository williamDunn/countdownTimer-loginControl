<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountdownTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAlarm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(14, 13)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(55, 39)
        Me.lblMinutes.TabIndex = 0
        Me.lblMinutes.Text = "00"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.Location = New System.Drawing.Point(75, 13)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(26, 39)
        Me.lblColon.TabIndex = 1
        Me.lblColon.Text = ":"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(107, 13)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(55, 39)
        Me.lblSeconds.TabIndex = 2
        Me.lblSeconds.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblAlarm
        '
        Me.lblAlarm.AutoSize = True
        Me.lblAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarm.Location = New System.Drawing.Point(18, 13)
        Me.lblAlarm.Name = "lblAlarm"
        Me.lblAlarm.Size = New System.Drawing.Size(135, 39)
        Me.lblAlarm.TabIndex = 3
        Me.lblAlarm.Text = "ALARM"
        Me.lblAlarm.Visible = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAlarm)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblMinutes)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(176, 68)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblColon As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblAlarm As Label
End Class
