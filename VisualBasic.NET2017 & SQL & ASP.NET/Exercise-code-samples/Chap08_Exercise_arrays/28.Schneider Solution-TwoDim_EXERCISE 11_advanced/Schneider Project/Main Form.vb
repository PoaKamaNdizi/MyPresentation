Option Explicit On
Option Strict On
Option Infer Off
' app will display a grade based on number of points entered by user:
' user input points in (txtPoints), app will display a grade ABCDF on (lblGrade)
' *store the minimum points & grades in 2x Parallel 1D Arrays named: intMins & strGrades
'MOD: change 2x Parallel 1D Array to a 2D Array named strGradeInfo
' F=0-299; D=300-349; C=350-414; B=415-464, A=465-500
' *btnDisplay_Click should use the number of points to search the intMins() and display corresponding grade from strGrades()
'MOD: modify the btnDisplay_Click
' if more than 500: display the appropriate msg & N/A in (lblGrade)
Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtPoints.SelectAll()

        Dim intPoints As Integer
        Integer.TryParse(txtPoints.Text, intPoints)

        Dim strGradeInfo(,) As String = {{"0", "300", "350", "415", "465"}, {"F", "D", "C", "B", "A"}}
        Dim intGradeInfo As Integer

        If intPoints > 500 Then
            lblGrade.Text = "N/A"
            MessageBox.Show("Please enter the valid points betweed 0 and 500", "Professor Schneider",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For intIndex As Integer = 0 To 4
                Integer.TryParse(strGradeInfo(0, intIndex), intGradeInfo)

                If intPoints >= intGradeInfo Then
                    lblGrade.Text = strGradeInfo(1, intIndex)
                End If
            Next intIndex
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(sender As Object, e As EventArgs) Handles txtPoints.Enter
        txtPoints.SelectAll()
    End Sub

    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPoints_TextChanged(sender As Object, e As EventArgs) Handles txtPoints.TextChanged
        lblGrade.Text = String.Empty
    End Sub

End Class