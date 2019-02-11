Public Class LevelManager
    Private ReadOnly _playerController As PlayerController
    Private ReadOnly _playArea As Form2
    Private _enemyKilled As Integer

    Public CurrentLevel As Integer

    Public Sub New(ByVal playercontroller As PlayerController, ByVal playArea As Form2, ByVal game As LaserDefender)
        _playerController = playercontroller
        _playArea = playArea


        AddHandler _playerController.OnEnemyHit, AddressOf HandleEnemyKilled
        AddHandler game.GameStart, AddressOf InitializeLevel
    End Sub

    Private Sub HandleEnemyKilled()
        _enemyKilled += 1

        If Math.Floor(_enemyKilled / 10) = _enemyKilled / 10 Then
            CurrentLevel += 1
            _playArea.LevelLabel.Text = CurrentLevel
        End If
    End Sub

    Private Sub InitializeLevel()
        CurrentLevel = 1
        _playArea.LevelLabel.Text = CurrentLevel
    End Sub

End Class
