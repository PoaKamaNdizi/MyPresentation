Option Explicit On
Option Strict On
Option Infer Off
' app will display a grade based on number of points entered by user:
' user input points in (txtPoints), app will display a grade ABCDF on (lblGrade)
' store the minimum points & grades in 2x Parallel 1D Arrays named: intMins & strGrades
' F=0-299; D=300-349; C=350-414; B=415-464, A=465-500
' btnDisplay_Click should use the number of points to search the intMins() and display corresponding grade from strGrades()
' if more than 500: display the appropriate msg & N/A in (lblGrade)
Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Dim intMins() As Integer = {0, 300, 350, 415, 465, 500}
        'Dim strGrades() As String = {"F", "D", "C", "B", "A", "N/A"}
        Dim intPoints As Integer
        Integer.TryParse(txtPoints.Text, intPoints)

        ' like this I can write for all of them, BUT CAN I MAKE IT LOOP??????
        'If intPoints > intMins(5) Then
        'MessageBox.Show("Please enter your grade less than 500.", "Professor Schneider", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'lblGrade.Text = "N/A"
        'ElseIf intPoints >= intMins(0) AndAlso intPoints < intMins(1) Then
        'lblGrade.Text = strGrades(0)
        'ElseIf intPoints >= intMins(1) AndAlso intPoints < intMins(2) Then
        'lblGrade.Text = strGrades(1)
        'ElseIf intPoints >= intMins(2) AndAlso intPoints < intMins(3) Then
        'lblGrade.Text = strGrades(2)
        'ElseIf intPoints >= intMins(3) AndAlso intPoints < intMins(4) Then
        'lblGrade.Text = strGrades(3)
        'ElseIf intPoints >= intMins(4) AndAlso intPoints <= intMins(5) Then
        'lblGrade.Text = strGrades(4)
        'End If

        Dim intMins2() As Integer = {0, 300, 350, 415, 465}
        Dim strGrades2() As String = {"F", "D", "C", "B", "A"}

        If intPoints > 500 Then
            lblGrade.Text = "N/A"
            MessageBox.Show("Please enter your grade less than 500.", "Professor Schneider", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For intIndex As Integer = 0 To intMins2.GetUpperBound(0)
                If intPoints >= intMins2(intIndex) Then
                    lblGrade.Text = strGrades2(intIndex)
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