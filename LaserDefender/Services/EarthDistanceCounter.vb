Public Class EarthDistanceCounter
    Private ReadOnly _gameConfig As GameConfig
    Private ReadOnly _playArea As Form2
    Private ReadOnly _screenSize As ScreenSize
    Private _counter As Integer

    Public Sub New(ByVal frames As Frames, ByVal playArea As Form2, ByVal gameConfig As GameConfig, ByVal game As LaserDefender, ByVal screen As ScreenSize)
        _gameConfig = gameConfig
        _playArea = playArea
        _screenSize = screen
        AddHandler frames.Update, AddressOf Add
        AddHandler game.GameStart, AddressOf InitializeCounter
    End Sub

    Private Sub InitializeCounter()
        _counter = 0
        _playArea.EarthImage.Top = _screenSize.yMax - 60
        _playArea.DistanceEarthCounter.Text = _counter
    End Sub

    Public Sub Add()

        _counter += _gameConfig.EarthDistanceCounterSpeed

        If Math.Floor(_counter / 5) = _counter / 5 Then
            _playArea.EarthImage.Top += _gameConfig.EarthDistanceCounterEarthSpeed
        End If

        _playArea.DistanceEarthCounter.Text = _counter
    End Sub
End Class
