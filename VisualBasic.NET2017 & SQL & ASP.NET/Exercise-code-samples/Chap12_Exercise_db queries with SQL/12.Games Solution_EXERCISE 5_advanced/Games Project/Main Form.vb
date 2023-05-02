' Name:         Games Project
' Purpose:      Display all records and records meeting specific criteria.
' Programmer:   <your name> on <current date>
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GaloreDataSet.Games' table. You can move, or remove it, as needed.
        Me.GamesTableAdapter.Fill(Me.GaloreDataSet.Games)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Select Case True
            Case radPlatform.Checked ' + txtPlatform
                GamesTableAdapter.FillByPlatform(GaloreDataSet.Games, txtPlatform.Text.Trim)
            Case radRating.Checked ' + txtRating
                GamesTableAdapter.FillByRating(GaloreDataSet.Games, txtRating.Text.Trim)
            Case radNew.Checked
                GamesTableAdapter.FillByNewUsed_New(GaloreDataSet.Games)
            Case radUsed.Checked
                GamesTableAdapter.FillByNewUsed_Used(GaloreDataSet.Games)
            Case Else ' radAll.Checked
                GamesTableAdapter.Fill(GaloreDataSet.Games)
        End Select
    End Sub
End Class