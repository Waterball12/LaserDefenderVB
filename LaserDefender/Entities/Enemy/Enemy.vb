Public Class Enemy
    Public Obj As PictureBox
    Public IsAlive As Boolean
    Public Health As Integer = 50
    Public ScorePerKill As Integer = 100

    Public Sub New(ByVal obj As PictureBox)
        Me.Obj = obj
        Me.IsAlive = True
    End Sub

    Public Sub GetDamage(ByVal DamageInflict As Integer)
        If IsAlive Then
            Health -= DamageInflict

            If Health <= 0 Then
                Die()
            End If
        End If
    End Sub

    Public Sub Die()
        IsAlive = False
        Obj.Visible = False
    End Sub
End Class
