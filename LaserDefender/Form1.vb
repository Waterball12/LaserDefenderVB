Public Class Form1

    Dim _serviceProvider As IServiceProvider

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True) ' This is for opmizated buffer paint

        _serviceProvider = New ServiceProvider

        _serviceProvider.AddService(Of Form1)(Me)
        _serviceProvider.AddService(Of Form3)()
        _serviceProvider.AddService(Of Form2)()
        _serviceProvider.AddService(Of GameConfig)()
        _serviceProvider.AddService(Of ScreenSize)()
        _serviceProvider.AddService(Of Frames)()
        _serviceProvider.AddService(Of Background)()
        _serviceProvider.AddService(Of LaserDefender)()
        _serviceProvider.AddService(Of EnemyFormation)()
        _serviceProvider.AddService(Of PlayerController)()
        _serviceProvider.AddService(Of InputHandler)()
        _serviceProvider.AddService(Of LevelManager)()
        _serviceProvider.AddService(Of LifeHandler)()
        _serviceProvider.AddService(Of ScoreManager)()
        _serviceProvider.AddService(Of EarthDistanceCounter)()
        _serviceProvider.AddService(Of Form4)()

        _serviceProvider.Initialize()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlay.Click
        Dim _playArea = _serviceProvider.GetService(Of Form2)()
        Dim _menu = _serviceProvider.GetService(Of Form1)()
        Dim _game = _serviceProvider.GetService(Of LaserDefender)()

        _menu.Hide()
        _playArea.Show()
        _game.RunGame()
    End Sub

    Private Sub BtnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHelp.Click
        Dim _help = _serviceProvider.GetService(Of Form3)()
        Dim _menu = _serviceProvider.GetService(Of Form1)()

        _menu.Hide()
        _help.Show()
    End Sub
End Class
