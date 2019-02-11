Public Class Background
    Private ReadOnly _playArea As Form2
    Private ReadOnly _screenSize As ScreenSize
    Private ReadOnly _gameConfig As GameConfig
    Private ReadOnly _random As New Random
    Private ReadOnly _form As Form2
    Private ReadOnly _frames As Frames

    Private _stars As New List(Of Star)

    Public Sub New(ByVal form As Form2, ByVal screenSize As ScreenSize, ByVal gameConfig As GameConfig, ByVal frames As Frames)
        _form = form
        _screenSize = screenSize
        _gameConfig = gameConfig
        _frames = frames

        AddHandler _form.Paint, Sub(ByVal sender As Object, ByVal e As PaintEventArgs)
                                    For Each star In _stars
                                        e.Graphics.FillEllipse(star.Colour, star.X, star.Y, star.Width, star.Heigh)
                                    Next
                                End Sub
        AddHandler _frames.Update, AddressOf HandleFrame
        LoadStars()
    End Sub

    Public Sub LoadStars()
        For index = 0 To _gameConfig.MaxStarInScreen

            Dim X = _random.Next(_screenSize.xMin, _screenSize.xMax)
            Dim Y = _random.Next(_screenSize.yMin, _screenSize.yMax)
            Dim Width = _gameConfig.DefaultStarWidth
            Dim Heigh = _gameConfig.DefaultStarHeigh
            Dim Colour = _gameConfig.DefaultStarColour

            If Math.Floor(index / 2) = index / 2 Then
                Width = _gameConfig.DeepStarWidth
                Heigh = _gameConfig.DeepStarHeigh
                Colour = _gameConfig.DeepStarColour
            End If

            Dim star = New Star(_random.Next(_gameConfig.MinStarSpeed, _gameConfig.MaxStarSpeed), X, Y, Colour, Width, Heigh)

            _stars.Add(star)
        Next
    End Sub

    Private Sub HandleFrame()
        _form.Invalidate()

        For Each star In _stars
            If star.Y > _screenSize.yMax Then
                star.Y = -40
            Else
                star.Y += star.Speed
            End If
        Next
    End Sub
End Class
