Public Class LifeHandler
    Private ReadOnly _game As LaserDefender
    Private ReadOnly _player As PlayerController
    Private ReadOnly _gameConfig As GameConfig
    Private ReadOnly _playArea As Form2

    Public Life As Integer

    Public Sub New(ByVal playArea As Form2, ByVal player As PlayerController, ByVal game As LaserDefender, ByVal gameConfig As GameConfig)
        _game = game
        _player = player
        _gameConfig = gameConfig
        _playArea = playArea

        AddHandler _game.GameStart, AddressOf InitializeLife
        AddHandler _player.OnPlayerHit, AddressOf HandleLife
    End Sub

    Private Sub InitializeLife()
        Life = _gameConfig.SpaceshipLife

        _playArea.LifeCounter.Text = Life
    End Sub

    Private Sub HandleLife()
        Life = Life - 1

        _playArea.LifeCounter.Text = Life

        If Life <= 0 Then
            _game.Lose()
        End If
    End Sub

End Class
