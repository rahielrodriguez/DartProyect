'Rahiel Rodriguez
'RCET 3371
'Sept 10, 2024
'Darts Game

Option Strict On
Option Explicit On

Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text

Public Class DartsForm

    Sub DrawCircle()
        'Set all the parameters for graphics to be ready to draw
        Dim draw As Pen
        draw = New Pen(Drawing.Color.Blue, 3)
        Dim myGraphics As Graphics = DartPictureBox.CreateGraphics
        'Variable made to keep track of the dart number for each 3
        Dim dartsThrow As Integer
        dartsThrow = 0
        Randomize()

        'Generates a loop for 3 interations to create all 3 darts
        For i = 1 To 3
            'Generates the number of the coordinates for the darts and usses a number that covers most of the picture box
            Dim xAxis = 325 * Rnd()
            Dim yAxis = 325 * Rnd()

            'generates all darts and keep tracks from 1 to 3
            dartsThrow += 1
            myGraphics.DrawEllipse(draw, xAxis, yAxis, 5, 5)

            'opens a text file with the selected name
            'writes a line with the number of the dart and the coordinates
            Try
                FileOpen(1, "Darts Coordinates.txt", OpenMode.Append)
                WriteLine(CInt($"{dartsThrow}. X = {xAxis} , Y = {yAxis}"))
                FileClose()
            Catch ex As Exception

            End Try

        Next

        Try
            FileOpen(1, "Darts Coordinates.txt", OpenMode.Append)
            WriteLine(CInt("---------------------------------------------------------------"))
            FileClose()
        Catch ex As Exception

        End Try

    End Sub
    Sub SimulateCoordinates()
        Dim draw As Pen
        draw = New Pen(Drawing.Color.Blue, 3)
        Dim myGraphics As Graphics = DartPictureBox.CreateGraphics

        For i = 1 To 3
            'uses the text box coordinates to replay a dart.
            Dim xAxis = CInt(XTextBox.Text)
            Dim yAxis = CInt(YTextBox.Text)

            myGraphics.DrawEllipse(draw, xAxis, yAxis, 5, 5)

        Next

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
        XTextBox.Text = ""
        YTextBox.Text = ""

    End Sub

    Private Sub ReplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        SimulateCoordinates()

    End Sub
End Class
