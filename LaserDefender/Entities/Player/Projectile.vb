Public Class Projectile

    Public Obj As PictureBox
    Public Speed As Integer
    Public Damage As Integer

    Public Sub New(ByVal obj As PictureBox, ByVal speed As Integer, ByVal damage As Integer)
        Me.Obj = obj
        Me.Speed = speed
        Me.Damage = damage
    End Sub
End Class
