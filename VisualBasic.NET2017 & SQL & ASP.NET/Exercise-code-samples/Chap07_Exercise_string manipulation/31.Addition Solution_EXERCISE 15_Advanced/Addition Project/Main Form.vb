Option Explicit On
Option Strict On
Option Infer Off

' btnNew_Click procedure is responsible for generating two random integers from 0 to 10 included,
'        and displaying them in the lblNum1 and lblNum2 controls

' user enters his answer in: txtAnswer control

' btnCheck_Click procedure is responsible for determining whether the user's answer is correct
'   - if correct, then display an appropriate message and clear problem and answer from GUI
'   - if not correct, then display an appropriate message and then allow the user to answer the
'            addition problem again

' code both procedures and include any other code that will professionalize GUI
' txtAnswer, lblNum1, lblNum2

Public Class frmMain
    Private intNum1 As Integer   ' 1st global Random integer, lblNum1
    Private intNum2 As Integer   ' 2nd global Random integer, lblNum2
    Private intNum3 As Integer   ' 1st + 2nd to check with the user's answer

    Private Sub RandomInteger()        ' i have used an Independent Sub Procedure to generate a random integer
        Dim randGen As New Random
        intNum1 = randGen.Next(0, 11)  ' random integer between 0-10
        intNum2 = randGen.Next(0, 11)  ' other random integer between 0-10
        ' the procedure ONLY say "Hi, I am an Independent Procedure, do what you desire"
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        RandomInteger()                ' hellooo, waaaake uuuuup RandomInteger and give me all your values

        intNum3 = intNum1 + intNum2

        lblNum1.Text = intNum1.ToString
        lblNum2.Text = intNum2.ToString
        'MessageBox.Show(intNum3.ToString)    ' shows the addition of 2 independent random integers

        btnNew.Enabled = False
        btnCheck.Enabled = True
        txtAnswer.Focus()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' txtAnswer = user's input
        Dim intAnswer As Integer
        Integer.TryParse(txtAnswer.Text, intAnswer)

        If intNum3 = intAnswer Then
            MessageBox.Show("You are right, " & intAnswer.ToString & " is the answer", "Two Numbers Addition",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNew.Enabled = True
            btnCheck.Enabled = False
            lblNum1.Text = String.Empty
            lblNum2.Text = String.Empty
            txtAnswer.Text = String.Empty
            btnNew.Focus()
        Else
            MessageBox.Show("Please try again,  " & lblNum1.Text & " + " & lblNum2.Text & "  is not  " &
                            intAnswer.ToString, "Two Numbers Addition", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnswer.SelectAll()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnswer.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

End Class