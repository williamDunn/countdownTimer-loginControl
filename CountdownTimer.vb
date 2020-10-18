Public Class CountdownTimer
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private mSeconds As Integer

    Public Event CountdownTimerAlarm As EventHandler(Of EventArgs)

    Public Property HowLong As Integer
        Get
            Return mSeconds
        End Get
        Set(value As Integer)
            mSeconds = value
            If (value > 1) Then
                Timer1.Start()
            ElseIf (value <= 0) Then
                value = 60
            End If
        End Set
    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim minute As Integer = mSeconds \ 60
        Dim second As Integer = mSeconds Mod 60

        If (minute < 10) Then
            lblMinutes.Text = "0" & minute
        Else
            lblMinutes.Text = minute
        End If

        If (second < 10) Then
            lblSeconds.Text = "0" & second
        Else
            lblSeconds.Text = second
        End If

        If Not Me.DesignMode Then
            If (mSeconds > 0) Then
                mSeconds -= 1
            Else
                RaiseEvent CountdownTimerAlarm(Me, New EventArgs())
                lblAlarm.Visible = True
                Timer1.Stop()
            End If
        End If
    End Sub

    Public Sub PauseTimer()
        If (Timer1.Enabled = True) Then
            Timer1.Enabled = False
        End If
    End Sub

    Public Sub ResumeTimer()
        If (Timer1.Enabled = False) Then
            Timer1.Enabled = True
        End If
    End Sub
End Class
