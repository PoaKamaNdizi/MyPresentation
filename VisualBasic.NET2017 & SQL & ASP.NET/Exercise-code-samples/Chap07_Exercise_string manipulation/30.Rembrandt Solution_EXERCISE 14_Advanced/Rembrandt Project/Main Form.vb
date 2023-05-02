Option Explicit On
Option Strict On
Option Infer Off
' each salesperson is assigned a 5-character ID number: ?-?-?-N/U-F/P
' 1-3 = some numbers
' 4 = N/U : N = salesperson sales New cars, U = salesperson sales Used cars
' 5 = F/P : F = full-time employee, P = part-time employee
' the app should allow the sales manager to enter the ID and the number of cars sold for
'    as many salespeople as needed
' display the total number of cars sold by each of the 4 categories
' btnCalculate, btnClear, btnExit, txt1ID, txt2Sold
' lbl1FullTime, lbl2PartTime, lbl3NewCar, lbl4UsedCar
Public Class frmMain
    Private int1FullTime As Integer       ' F =lbl1FullTime
    Private int2PartTime As Integer       ' P =lbl2PartTime
    Private int3NewCar As Integer         ' N =lbl3NewCar
    Private int4UsedCar As Integer        ' U =lbl4UsedCar

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim str1ID As String = txt1ID.Text                ' =txt1ID (MaxLength = 5)
        Dim int2Sold As Integer                           ' =txt2Sold ->only numbers: Private Sub txt2Sold_KeyPress...
        Integer.TryParse(txt2Sold.Text, int2Sold)

        If str1ID.ToUpper Like "###[NU][FP]" Then  ' if the user entry matches the predefined conditions:

            Select Case True
                Case str1ID.ToUpper.Contains("N")
                    int3NewCar += int2Sold
                Case str1ID.ToUpper.Contains("U")
                    int4UsedCar += int2Sold
            End Select

            Select Case True
                Case str1ID.ToUpper.Contains("F")
                    int1FullTime += int2Sold
                Case str1ID.ToUpper.Contains("P")
                    int2PartTime += int2Sold
            End Select

            lbl1FullTime.Text = int1FullTime.ToString
            lbl2PartTime.Text = int2PartTime.ToString
            lbl3NewCar.Text = int3NewCar.ToString
            lbl4UsedCar.Text = int4UsedCar.ToString
            txt1ID.Focus()
            txt1ID.SelectAll()

        Else       ' if the user entry won't match the predefined conditions:
            MessageBox.Show("Please enter the valid ID number", "Rembrandt Auto-Mart",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt1ID.Focus()
            txt1ID.SelectAll()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        int1FullTime = 0
        int2PartTime = 0
        int3NewCar = 0
        int4UsedCar = 0
        txt1ID.Text = String.Empty
        txt2Sold.Text = String.Empty
        lbl1FullTime.Text = String.Empty
        lbl2PartTime.Text = String.Empty
        lbl3NewCar.Text = String.Empty
        lbl4UsedCar.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txt2Sold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2Sold.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Ent(sender As Object, e As EventArgs) Handles txt1ID.Enter, txt2Sold.Enter
        txt1ID.SelectAll()
        txt2Sold.SelectAll()
    End Sub
End Class