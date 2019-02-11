Public Class Form3

    Private ReadOnly _menu As Form1

    Public Sub New(ByVal menu As Form1)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _menu = menu
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        _menu.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            _menu.Show()
            Me.Hide()
        End If
    End Sub
End Class