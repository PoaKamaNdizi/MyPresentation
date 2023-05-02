Option Explicit On
Option Strict On
Option Infer Off
' you code an app that generates & displays 6 UNIQUE RANDOM numbers for a lottery game
' each lottery number can range: 1-54 only
' btnDisplay_Click procedure should display in GUI

' lblLottery
'CH7_A3 info about Random, 31_15 Exercise

Public Class frmMain

    'Private intAccumulator(5) As Integer

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Generates and displays six unique random numbers from 1 through 54.

        lblLottery.Text = Nothing

        Dim intAccumulator(5) As Integer
        Dim intRandGen As New Random
        Dim intRandomNumber As Integer

        For intCounter As Integer = 0 To 5
            intRandomNumber = intRandGen.Next(1, 55)
            For intCheck As Integer = 0 To intCounter
                If intRandomNumber <> intAccumulator(intCheck) Then
                    intAccumulator(intCounter) = intRandomNumber
                Else
                    intRandomNumber = intRandGen.Next(1, 55)
                End If
            Next intCheck
            lblLottery.Text &= intAccumulator(intCounter).ToString & "  "
        Next intCounter

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class