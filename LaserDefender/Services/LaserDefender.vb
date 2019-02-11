Imports System.IO

Public Class LaserDefender
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
     Integer, ByVal hwndCallback As Integer) As Integer

    Public Event GameStart()
    Public Event GameDispose()
    Public Event GameLose()

    Private ReadOnly _frames As Frames
    Private ReadOnly _menu As Form1
    Private ReadOnly _playArea As Form2
    Private ReadOnly _gameConfig As GameConfig

    Public Sub New(ByVal frames As Frames, ByVal enemys As EnemyFormation, ByVal menu As Form1, ByVal playArea As Form2, ByVal gameConfig As GameConfig)
        _frames = frames
        _menu = menu
        _playArea = playArea
        _gameConfig = gameConfig
    End Sub

    Public Sub RunGame()
        _frames.StartTimer()

        If File.Exists(_gameConfig.BackgroundSound) Then
            mciSendString("open " & (Chr(34) + _gameConfig.BackgroundSound + Chr(34)) & " alias myDevice", Nothing, 0, 0)
            mciSendString("play myDevice", Nothing, 0, 0)
        Else
            MsgBox("Sound path error. background sound disabled")
        End If

        RaiseEvent GameStart()
    End Sub

    Public Sub ReturnToMenu()
        PrepareToExit()
        _playArea.Hide()
        _menu.Show()
    End Sub

    Public Sub Lose()
        PrepareToExit()
        RaiseEvent GameLose()
    End Sub

    Private Sub PrepareToExit()
        _frames.StopTimer()
        mciSendString("stop myDevice", Nothing, 0, 0)
        RaiseEvent GameDispose()
    End Sub
End Class
