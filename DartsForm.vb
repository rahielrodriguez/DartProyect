Option Strict On
Option Explicit On

Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text

Public Class DartsForm

    Sub DrawCircle()
        Dim draw As Pen
        draw = New Pen(Drawing.Color.Blue, 3)
        Dim myGraphics As Graphics = DartPictureBox.CreateGraphics
        Dim dartsThrow As Integer
        Dim file As System.IO.StreamWriter
        dartsThrow = 0
        Randomize()

        For i = 1 To 3
            Dim xAxis = 325 * Rnd()
            Dim yAxis = 325 * Rnd()

            dartsThrow += 1
            myGraphics.DrawEllipse(draw, xAxis, yAxis, 5, 5)


            File = My.Computer.FileSystem.OpenTextFileWriter("Darts Coordinates.txt", True)
            file.WriteLine($"{dartsThrow}. X = {xAxis} , Y = {yAxis}{vbNewLine}")
            file.Close()
        Next
        file = My.Computer.FileSystem.OpenTextFileWriter("Darts Coordinates.txt", True)
        file.WriteLine("---------------------------------------------------------------")
        file.Close()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        DartPictureBox.Refresh()
        DrawCircle()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        DartPictureBox.Refresh()
    End Sub

End Class
