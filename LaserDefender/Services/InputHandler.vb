Public Class InputHandler
    Private ReadOnly _laserDefender As LaserDefender
    Private ReadOnly _playArea As Form2
    Private ReadOnly _player As PlayerController

    Public Sub New(ByVal laserDefender As LaserDefender, ByVal playArea As Form2, ByVal player As PlayerController)
        _laserDefender = laserDefender
        _playArea = playArea
        _player = player

        AddHandler laserDefender.GameStart, AddressOf StartHandling
        AddHandler laserDefender.GameDispose, AddressOf StopHandling
    End Sub

    Public Sub StartHandling()
        AddHandler _playArea.KeyDown, AddressOf HandleInput
    End Sub

    Public Sub StopHandling()
        RemoveHandler _playArea.KeyDown, AddressOf HandleInput
    End Sub

    Private Sub HandleInput(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Right Then
            _player.MoveRight()
        End If
        If e.KeyCode = Keys.Left Then
            _player.MoveLeft()
        End If
        If e.KeyCode = Keys.Space Then
            _player.Fire()
        End If
        If e.KeyCode = Keys.Escape Then
            _laserDefender.ReturnToMenu()
        End If
    End Sub

End Class
