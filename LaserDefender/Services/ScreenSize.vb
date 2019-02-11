Public Class ScreenSize
    Public xMax As Integer = Form2.Width
    Public xMin As Integer = 0

    Public yMax As Integer = Form2.Height
    Public yMin As Integer = 0

    Public Function CalcxMaxOffSet(ByVal obj As PictureBox) As Integer
        Return (xMax - obj.Width) - (obj.Width / 2)
    End Function

    Private _playArea As Form2

    Public Sub New(ByVal playArea As Form2)
        _playArea = playArea
        AddHandler playArea.ResizeEnd, AddressOf Reload
    End Sub

    Public Sub Reload()
        ' This is not gonna work for background

        xMax = _playArea.Width
        yMax = _playArea.Height
    End Sub

End Class
