Public Class LogIn
    Private mCorrectUserName As String
    Public Property CorrectUserName As String
        Get
            Return mCorrectUserName
        End Get
        Set(value As String)
            mCorrectUserName = value
        End Set
    End Property

    Private mCorrectPassword As String
    Public Property CorrectPassword As String
        Get
            Return mCorrectPassword
        End Get
        Set(value As String)
            mCorrectPassword = value
        End Set
    End Property

    Private mUsername As String
    Public ReadOnly Property UserName As String
        Get
            Return mUsername
        End Get
    End Property

    Private mPassword As String
    Public ReadOnly Property Password As String
        Get
            Return mPassword
        End Get
    End Property

    Public Enum StatusEnum
        Accepted
        Invalid
        NoLogin
    End Enum

    Private mStatus As StatusEnum = StatusEnum.NoLogin
    Public ReadOnly Property Status As StatusEnum
        Get
            Return mStatus
        End Get
    End Property

    Public Event LoginAccepted As EventHandler(Of EventArgs)

    Public Event LoginFailed As EventHandler(Of EventArgs)

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        mUsername = tbUsername.Text
        mPassword = tbPassword.Text

        If (mUsername <> mCorrectUserName Or mPassword <> mCorrectPassword) Then
            RaiseEvent LoginFailed(Me, New EventArgs())
            mStatus = StatusEnum.Invalid
        ElseIf (mUsername = mCorrectUserName And mPassword = mCorrectPassword) Then
            RaiseEvent LoginAccepted(Me, New EventArgs())
            mStatus = StatusEnum.Accepted
        Else
            mStatus = StatusEnum.Invalid
        End If
    End Sub
End Class
