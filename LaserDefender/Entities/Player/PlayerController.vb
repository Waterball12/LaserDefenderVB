Public Class PlayerController

    Private ReadOnly _playArea As Form2
    Private ReadOnly _gameConfig As GameConfig
    Private ReadOnly _screenSize As ScreenSize
    Private ReadOnly _frames As Frames
    Private ReadOnly _enemyFormation As EnemyFormation
    Private ReadOnly _game As LaserDefender

    Public SpaceShip As PictureBox
    Public Projectiles As New List(Of Projectile)
    Public Event OnEnemyHit(ByVal score As Integer)
    Public Event OnPlayerHit()

    Public Sub New(ByVal playArea As Form2, ByVal gameConfig As GameConfig, ByVal screen As ScreenSize, ByVal frame As Frames, ByVal enemys As EnemyFormation, ByVal game As LaserDefender)

        _gameConfig = gameConfig
        _playArea = playArea
        SpaceShip = _playArea.SpaceShipPosition
        _screenSize = screen
        _frames = frame
        _enemyFormation = enemys
        _game = game


        SpaceShip.Image = My.Resources.playerShip1_blue


        AddHandler _frames.Update, AddressOf HandleProjectiles

    End Sub

    Public Sub MoveLeft()
        If SpaceShip.Left >= _screenSize.xMin Then
            SpaceShip.Left = SpaceShip.Left - _gameConfig.SpaceshipMovementSpeed
        End If
    End Sub

    Public Sub MoveRight()
        If SpaceShip.Left <= _screenSize.CalcxMaxOffSet(SpaceShip) Then
            SpaceShip.Left = SpaceShip.Left + _gameConfig.SpaceshipMovementSpeed
        End If
    End Sub

    Public Sub Fire()

        My.Computer.Audio.Play(My.Resources.SpaceshipFire, AudioPlayMode.Background)

        Dim gameObject As New PictureBox

        gameObject.Name = "Projectile"
        gameObject.Width = 5
        gameObject.Height = 5

        gameObject.Top = SpaceShip.Top - 10
        gameObject.Left = SpaceShip.Left + (SpaceShip.Width / 2) - 3
        gameObject.BackColor = Color.Blue
        gameObject.BringToFront()
        _playArea.Controls.Add(gameObject)
        Projectiles.Add(New Projectile(gameObject, _gameConfig.SpaceshipProjectileSpeed, _gameConfig.SpaceshipProjectileDamage))

    End Sub

    Public Sub DestroyProjectile(ByVal projectile As Projectile)
        projectile.Obj.Visible = False
        projectile.Obj.Dispose()
        _playArea.Controls.Remove(projectile.Obj)
        Projectiles.Remove(projectile)
    End Sub

    Private Sub HandleProjectiles()

        For index = 0 To Projectiles.Count - 1
            If Projectiles.ElementAtOrDefault(index) IsNot Nothing Then
                Projectiles(index).Obj.Top -= Projectiles(index).Speed

                If Projectiles(index).Obj.Top <= -40 Then
                    DestroyProjectile(Projectiles(index))
                Else
                    HandleCollision(Projectiles(index))
                End If
            End If
        Next

        For index = 0 To _enemyFormation.EnemysFire.Count - 1
            If _enemyFormation.EnemysFire.ElementAtOrDefault(index) IsNot Nothing Then
                Dim element = _enemyFormation.EnemysFire(index)

                element.Top -= _gameConfig.AlienFireSpeed

                If element.Bounds.IntersectsWith(SpaceShip.Bounds) And element.Visible Then
                    element.Visible = False
                    element.Dispose()
                    _playArea.Controls.Remove(element)
                    _enemyFormation.EnemysFire.Remove(element)
                    RaiseEvent OnPlayerHit()
                ElseIf element.Top >= _screenSize.yMax Then
                    element.Visible = False
                    element.Dispose()
                    _playArea.Controls.Remove(element)
                    _enemyFormation.EnemysFire.Remove(element)
                End If
            End If
        Next
    End Sub

    Public Sub HandleCollision(ByVal Projectile As Projectile)
        For index = 0 To _enemyFormation.Enemys.Count - 1
            If Projectile.Obj.Bounds.IntersectsWith(_enemyFormation.Enemys(index).Obj.Bounds) Then
                If _enemyFormation.Enemys(index).IsAlive Then
                    DestroyProjectile(Projectile)
                    _enemyFormation.Enemys(index).GetDamage(_gameConfig.SpaceshipProjectileDamage)
                    If _enemyFormation.Enemys(index).IsAlive = False Then
                        RaiseEvent OnEnemyHit(_enemyFormation.Enemys(index).ScorePerKill)
                        My.Computer.Audio.Play(My.Resources.EnemyHit, AudioPlayMode.Background)
                    End If

                    If _enemyFormation.AllMembersDead() Then
                        _enemyFormation.SpawnEnemys()
                    End If
                    Return
                End If
            End If
        Next
    End Sub

End Class
