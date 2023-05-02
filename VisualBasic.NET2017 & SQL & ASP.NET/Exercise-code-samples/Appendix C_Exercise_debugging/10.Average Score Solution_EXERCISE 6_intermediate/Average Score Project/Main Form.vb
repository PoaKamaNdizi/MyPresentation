' Name:         Average Score Project
' Purpose:      Display the average score.
' Programmer:   <your name> on <current date>
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays the average of two test scores.

        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblAverage As Double

        Double.TryParse(txtScore1.Text, dblScore1)
        Double.TryParse(txtScore2.Text, dblScore2)
        dblAverage = (dblScore1 + dblScore2) / 2
        lblAvg.Text = dblAverage.ToString("N2")
    End Sub
End Class