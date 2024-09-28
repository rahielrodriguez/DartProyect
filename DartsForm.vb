'Rahiel Rodriguez
'RCET 3371
'Sept 10, 2024
'Darts Game

Option Strict On
Option Explicit On

Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Public Class DartsForm
    Dim xAxis As Single
    Dim yAxis As Single
    Dim xAxisArray(100) As Single
    Dim yAxisArray(100) As Single
    Dim simulatedXAxis As Single
    Dim simulatedYAxis As Single
    Dim simulationIndex As Integer
    Dim recoverIndex As Integer

    Sub DrawCircle()
        'Set all the parameters for graphics to be ready to draw
        Dim draw As Pen
        draw = New Pen(Drawing.Color.Blue, 3)
        Dim myGraphics As Graphics = DartPictureBox.CreateGraphics
        'Variable made to keep track of the dart number for each 3
        Dim dartsThrow As Integer
        Static dartsTotal As Integer
        dartsThrow = 0
        Randomize()

        'Generates a loop for 3 interations to create all 3 darts
        For i = 0 To 2
            'Generates the number of the coordinates for the darts and usses a number that covers most of the picture box
            xAxis = 325 * Rnd()
            yAxis = 325 * Rnd()

            'generates all darts and keep tracks from 1 to 3
            dartsThrow += 1
            myGraphics.DrawEllipse(draw, xAxis, yAxis, 5, 5)

            simulationIndex = dartsTotal
            'change i for dart count to update correctly the index
            xAxisArray(dartsTotal) = xAxis
            yAxisArray(dartsTotal) = yAxis
            dartsTotal += 1
            'opens a text file with the selected name
            'writes a line with the number of the dart and the coordinates
            'to move the file one level up in its folder, add ..\ before the name of the file, add it twice to move it 2 levels up and so on...
            Try
                FileOpen(1, "..\..\Darts Coordinates.txt", OpenMode.Append)
                PrintLine(1, $"{dartsThrow}. X = {xAxis} , Y = {yAxis}")
                FileClose()
            Catch ex As Exception

            End Try

        Next

        Try
            FileOpen(1, "..\..\Darts Coordinates.txt", OpenMode.Append)
            PrintLine(1, "---------------------------------------------------------------")
            FileClose()
        Catch ex As Exception

        End Try

        simulationIndex = dartsTotal
        recoverIndex = dartsTotal
    End Sub

    Sub SimulateAttempts()

        Dim draw As Pen
        draw = New Pen(Drawing.Color.Blue, 3)
        Dim myGraphics As Graphics = DartPictureBox.CreateGraphics
        'Variable made to keep track of the dart number for each 3
        Static dartsThrow As Integer
        dartsThrow = recoverIndex

        If simulationIndex > 0 Then
            For i = 0 To 2
                simulatedXAxis = xAxisArray(simulationIndex)
                simulatedYAxis = yAxisArray(simulationIndex)
                myGraphics.DrawEllipse(draw, simulatedXAxis, simulatedYAxis, 5, 5)
                simulationIndex -= 1
            Next
        Else
            simulationIndex = dartsThrow
            MsgBox($"All previous attempts were thrown. Press Replay to reproduce them again.")
        End If

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

    Private Sub ReplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        DartPictureBox.Refresh()
        SimulateAttempts()
    End Sub
End Class
