Public Class Form4
    Private ReadOnly _menu As Form1
    Private ReadOnly _scoreManager As ScoreManager
    Private ReadOnly _levelManager As LevelManager
    Private ReadOnly _playArea As Form2
    Private ReadOnly _game As LaserDefender

    Public Sub New(ByVal menu As Form1, ByVal score As ScoreManager, ByVal levelmanager As LevelManager, ByVal playArea As Form2, ByVal game As LaserDefender)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _menu = menu
        _scoreManager = score
        _levelManager = levelmanager
        _playArea = playArea
        _game = game

        AddHandler _game.GameLose, AddressOf InvokeLose
    End Sub

    Public Sub InvokeLose()
        _playArea.Hide()
        Me.Show()

        ScoreCount.Text = _scoreManager.Score
        LevelCounter.Text = _levelManager.CurrentLevel
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            _menu.Show()
        End If
    End Sub
End Class