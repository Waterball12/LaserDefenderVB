Imports System.Threading.Tasks

Public Class EnemyFormation
    Private ReadOnly _frames As Frames
    Private ReadOnly _playArea As Form2
    Private ReadOnly _screen As ScreenSize
    Private ReadOnly _gameConfig As GameConfig
    Private ReadOnly _random As Random

    Private MovingRight As Boolean
    Public EnemysFire As New List(Of PictureBox)

    Public Enemys As New List(Of Enemy)


    Public Sub New(ByVal playArea As Form2, ByVal frame As Frames, ByVal sceen As ScreenSize, ByVal gameConfig As GameConfig, ByVal game As LaserDefender)
        _frames = frame
        _playArea = playArea
        _screen = sceen
        _gameConfig = gameConfig
        _random = New Random

        For index = 0 To playArea.Controls.Count - 1
            If playArea.Controls(index).Name.Contains("Enemy") Then
                Enemys.Add(New Enemy(playArea.Controls(index)))
            End If
        Next

        AddHandler game.GameStart, AddressOf SpawnEnemys
        AddHandler _frames.Update, AddressOf MoveEnemys

    End Sub

    Public Sub SpawnEnemys()
        For index = 0 To Enemys.Count - 1
            Enemys(index).Obj.Visible = True
            Enemys(index).IsAlive = True

            Enemys(index).Obj.Image = My.Resources.enemyship1
        Next
        For index = 0 To EnemysFire.Count - 1

            Dim element = EnemysFire(index)

            element.Visible = False
            element.Dispose()
            _playArea.Controls.Remove(element)
        Next
        EnemysFire.Clear()

    End Sub

    Public Sub MoveEnemys()
        If MovingRight Then
            MoveRight()
        Else
            MoveLeft()
        End If

        ' This is bad
        If _playArea.EnemyPosition1.Left <= _screen.xMin Then
            MovingRight = True
        ElseIf _playArea.EnemyPosition7.Left >= _screen.CalcxMaxOffSet(_playArea.EnemyPosition7) Then
            MovingRight = False
        End If
    End Sub

    Public Function AllMembersDead()
        For index = 0 To Enemys.Count - 1
            If Enemys(index).IsAlive = True Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub MoveRight()
        For index = 0 To Enemys.Count - 1
            Enemys(index).Obj.Left = Enemys(index).Obj.Left + _gameConfig.AlienShipMovementSpeed
            If Enemys(index).IsAlive Then
                Fire(Enemys(index).Obj.Left, Enemys(index).Obj.Top)
            End If
        Next
    End Sub

    Private Sub MoveLeft()
        For index = 0 To Enemys.Count - 1
            Enemys(index).Obj.Left = Enemys(index).Obj.Left - _gameConfig.AlienShipMovementSpeed
            If Enemys(index).IsAlive Then
                Fire(Enemys(index).Obj.Left, Enemys(index).Obj.Top)
            End If
        Next
    End Sub

    Private Sub Fire(ByVal x As Integer, ByVal y As Integer)
        Dim value = _random.Next(0, 100)

        If value = 10 Then

            Dim gameObject As New PictureBox
            gameObject.Name = "Projectile"
            gameObject.Width = 5
            gameObject.Height = 5

            gameObject.Top = y + 20
            gameObject.Left = x + 15
            gameObject.BackColor = Color.Red
            gameObject.BringToFront()
            _playArea.Controls.Add(gameObject)

            EnemysFire.Add(gameObject) ' Add property similar to Player projectile?
        End If
    End Sub

End Class
