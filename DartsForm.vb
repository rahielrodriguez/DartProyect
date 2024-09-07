Imports System.Drawing.Drawing2D

Public Class DartsForm

    Sub DrawCircle()
        Dim draw As Pen
        draw = New Pen(Drawing.Color.Blue, 3)
        Dim myGraphics As Graphics = DartPictureBox.CreateGraphics
        For i = 1 To 3
            myGraphics.DrawEllipse(draw, 325 * Rnd(), 325 * Rnd(), 5, 5)

        Next

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        DrawCircle()
        DartPictureBox.Refresh()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        DartPictureBox.Refresh()
    End Sub
End Class
