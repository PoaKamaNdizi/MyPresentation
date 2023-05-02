' Name:         Parking lot (parallelogram shape) pavement price calculator.
' Purpose:      Calculate the cost of paving the parking lot in a shape of parallelogram.
' Programmer:   PoaKamaNdizi on Time Stamp.
' the application should display the total cost of paving the parking lot in a shape of parallelogram
' create a suitable interface
' the user will enter the: - dimensions in feet
'                          - cost per square yard
' area of parallelogram (rovnoběžník) = base * height
' 1 feet = 0.33333 yards; 1 yard = 3 feet
' 1 square yard = 9 square feet; 1 square feet = 0.11111111 square yards (1/9)
' code the application by using a Class to instantiate a parking lot Object
' test
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lbl1TotalArea_SquareFeet.BackColor = Color.Yellow
        lbl2TotalCost.BackColor = Color.Yellow

        Dim dblBase As Double : Dim dblHeight As Double : Dim dblCost As Double
        Dim MyParkingLot As ParkingLot

        Double.TryParse(txt1Base_Feet.Text, dblBase)
        Double.TryParse(txt2Height_Feet.Text, dblHeight)
        Double.TryParse(txt3Price_SquareYard.Text, dblCost)

        ' invoke parameterized constructor and give him input values:
        MyParkingLot = New ParkingLot(dblBase, dblHeight, dblCost)

        lbl1TotalArea_SquareFeet.Text = MyParkingLot.GetArea.ToString("N2")
        lbl2TotalCost.Text = MyParkingLot.GetCost.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtInputs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1Base_Feet.KeyPress,
                                                    txt2Height_Feet.KeyPress, txt3Price_SquareYard.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtInputs_TextChanged(sender As Object, e As EventArgs) Handles txt1Base_Feet.TextChanged,
                                            txt2Height_Feet.TextChanged, txt3Price_SquareYard.TextChanged
        lbl1TotalArea_SquareFeet.Text = Nothing : lbl2TotalCost.Text = Nothing
        lbl1TotalArea_SquareFeet.BackColor = SystemColors.Control
        lbl2TotalCost.BackColor = SystemColors.Control
    End Sub

    Private Sub txt1Base_Feet_Enter(sender As Object, e As EventArgs) Handles txt1Base_Feet.Enter
        txt1Base_Feet.SelectAll()
    End Sub

    Private Sub txt2Height_Feet_Enter(sender As Object, e As EventArgs) Handles txt2Height_Feet.Enter
        txt2Height_Feet.SelectAll()
    End Sub

    Private Sub txt3Price_SquareYard_Enter(sender As Object, e As EventArgs) Handles txt3Price_SquareYard.Enter
        txt3Price_SquareYard.SelectAll()
    End Sub

    Private Sub txt1Base_Feet_MouseClick(sender As Object, e As MouseEventArgs) Handles txt1Base_Feet.MouseClick
        txt1Base_Feet.SelectAll()
    End Sub

    Private Sub txt2Height_Feet_MouseClick(sender As Object, e As MouseEventArgs) Handles txt2Height_Feet.MouseClick
        txt2Height_Feet.SelectAll()
    End Sub

    Private Sub txt3Price_SquareYard_MouseClick(sender As Object, e As MouseEventArgs) Handles txt3Price_SquareYard.MouseClick
        txt3Price_SquareYard.SelectAll()
    End Sub
End Class