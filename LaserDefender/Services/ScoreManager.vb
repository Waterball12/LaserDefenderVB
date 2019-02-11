Public Class ScoreManager
    Private ReadOnly _playArea As Form2
    Private ReadOnly _gameConfig As GameConfig

    Public Score As Integer

    Public Sub New(ByVal frame As Frames, ByVal playArea As Form2, ByVal player As PlayerController, ByVal gameConfig As GameConfig, ByVal game As LaserDefender)
        Score = 0
        _playArea = playArea
        _gameConfig = gameConfig

        AddHandler frame.Update, AddressOf UpdateScore
        AddHandler player.OnEnemyHit, AddressOf Add
        AddHandler game.GameStart, AddressOf InitializateScore
    End Sub

    Private Sub Add(ByVal e As Integer)
        Score += e
    End Sub

    Private Sub UpdateScore()
        _playArea.ScoreLabel.Text = Score
    End Sub

    Private Sub InitializateScore()
        Score = 0
        _playArea.ScoreLabel.Text = Score
    End Sub

End Class
