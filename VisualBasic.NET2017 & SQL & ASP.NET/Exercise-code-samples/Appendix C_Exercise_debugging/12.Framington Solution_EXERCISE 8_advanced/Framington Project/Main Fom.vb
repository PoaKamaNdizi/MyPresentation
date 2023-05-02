' Name:         Framington Project
' Purpose:      Display the number of tables needed to seat guests at a party.
' Programmer:   <your name> on <current date>
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Calculates the number of tables that seat 10, the number of tables that seat 5,
        ' and the number of guests remaining.
        ' Example: 67 guests need 6 tables of 10 and 1 table of 5, with 2 guests remaining.

        Dim intGuests As Integer
        Dim intTable10 As Integer
        Dim intTable5 As Integer
        Dim intRemain As Integer

        Integer.TryParse(txtGuests.Text, intGuests)

        intTable10 = intGuests \ 10
        intRemain = intGuests - intTable10 * 10    ' or: intRemain = intGuests Mod 10
        intTable5 = intRemain \ 5
        intRemain = intRemain - intTable5 * 5      ' or: intRemain = intRemain Mod 5

        lblTable10.Text = intTable10.ToString
        lblTable5.Text = intTable5.ToString
        lblRemain.Text = intRemain.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class