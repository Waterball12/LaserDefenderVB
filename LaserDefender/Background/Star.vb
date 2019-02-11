Public Class Star
    Public Speed As Integer
    Public X As Integer
    Public Y As Integer
    Public Colour As Object
    Public Width As Integer
    Public Heigh As Integer

    Public Sub New(ByVal Speed As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal Colour As Object, ByVal Width As Integer, ByVal Height As Integer)
        Me.Speed = Speed
        Me.X = X
        Me.Y = Y
        Me.Colour = Colour
        Me.Width = Width
        Me.Heigh = Height
    End Sub
End Class
