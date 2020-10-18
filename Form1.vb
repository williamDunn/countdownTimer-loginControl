'William Dunn - 275 - Assignment 11
Public Class Form1
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        CountdownTimer1.PauseTimer()
        CountdownTimer2.PauseTimer()
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        CountdownTimer1.ResumeTimer()
        CountdownTimer2.ResumeTimer()
    End Sub

    Private Sub LogIn1_LoginAccepted(sender As Object, e As EventArgs) Handles LogIn1.LoginAccepted
        btnPause.Visible = True
        btnResume.Visible = True
    End Sub
End Class
