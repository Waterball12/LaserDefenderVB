Imports System.IO

Public Class GameConfig
    ' This should be loaded from a configuration file

    'Background
    Public MaxStarInScreen = 40
    Public MaxStarSpeed = 8
    Public MinStarSpeed = 4
    Public DefaultStarWidth = 4
    Public DefaultStarHeigh = 4
    Public DeepStarWidth = 3
    Public DeepStarHeigh = 3
    Public DefaultStarColour = Brushes.Gray
    Public DeepStarColour = Brushes.DarkGray

    'Spaceship/Player
    Public SpaceshipLife = 3
    Public SpaceshipMovementSpeed = 20
    Public SpaceshipProjectileSpeed = 20
    Public SpaceshipProjectileDamage = 1000

    'Aliens
    Public AlienShipMovementSpeed = 5
    Public AlienFireSpeed = -5

    'EarthDistanceCounter
    Public EarthDistanceCounterEarthSpeed = 2
    Public EarthDistanceCounterSpeed = 2

    'Sound
    Public BackgroundSound = Path.Combine(Path.GetFullPath("..\..\"), "Background\Fantasy_Game_Background.wav")


End Class
