Public Class Frames

    Public Event Update()

    Private _timer As Timer


    Public Sub New()
        _timer = New Timer

        AddHandler _timer.Tick, AddressOf TimerUpdate
    End Sub

    Private Sub TimerUpdate()
        RaiseEvent Update()
    End Sub

    Public Sub StartTimer()
        _timer.Start()
    End Sub

    Public Sub StopTimer()
        _timer.Stop()
    End Sub

End Class
