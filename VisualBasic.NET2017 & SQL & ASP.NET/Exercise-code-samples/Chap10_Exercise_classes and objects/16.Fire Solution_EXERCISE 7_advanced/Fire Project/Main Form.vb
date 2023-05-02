' Name:         Water tank volume calculator.
' Purpose:      Display capacity/volume of a water tank.
' Programmer:   PoaKamaNdizi on Time Stamp.
' display the capacity (volume) of a water tank in - cubic feet & gallons
' (1 cubic foot = 7.48 gallons)
' input: tank's length, width, and height measurements
' create a suitable interface
' code the application by using a Class to instantiate a water tank Object
' display the output with 1 decimal place
' test
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lbl1CubicFeet.BackColor = Color.Yellow : lbl2Gallons.BackColor = Color.Yellow
        Dim dbl1Length As Double : Dim dbl2Width As Double : Dim dbl3Height As Double

        ' im gonna use Parameterized constructor, who will verify the input for me:
        Dim MyWaterTank As WaterTank

        Double.TryParse(txt1Length.Text, dbl1Length)
        Double.TryParse(txt2Width.Text, dbl2Width)
        Double.TryParse(txt3Height.Text, dbl3Height)

        ' invoke Parameterized Constructor and flush him inputs to verify:
        MyWaterTank = New WaterTank(dbl1Length, dbl2Width, dbl3Height)

        lbl1CubicFeet.Text = MyWaterTank.GetCapacity.ToString("N1")
        lbl2Gallons.Text = MyWaterTank.GetVolume.ToString("N1")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1Length.KeyPress,
                                                             txt2Width.KeyPress, txt3Height.KeyPress
        ' accept only numbers, decimal point, and BackSpace key:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt1Length_TextChanged(sender As Object, e As EventArgs) Handles txt1Length.TextChanged,
                                                          txt2Width.TextChanged, txt3Height.TextChanged
        lbl1CubicFeet.Text = Nothing : lbl1CubicFeet.BackColor = SystemColors.Control
        lbl2Gallons.Text = Nothing : lbl2Gallons.BackColor = SystemColors.Control
    End Sub

    Private Sub txt1Length_Enter(sender As Object, e As EventArgs) Handles txt1Length.Enter
        txt1Length.SelectAll()
    End Sub

    Private Sub txt2Width_Enter(sender As Object, e As EventArgs) Handles txt2Width.Enter
        txt2Width.SelectAll()
    End Sub

    Private Sub txt3Height_Enter(sender As Object, e As EventArgs) Handles txt3Height.Enter
        txt3Height.SelectAll()
    End Sub

    Private Sub txt1Length_MouseClick(sender As Object, e As MouseEventArgs) Handles txt1Length.MouseClick
        txt1Length.SelectAll()
    End Sub

    Private Sub txt2Width_MouseClick(sender As Object, e As MouseEventArgs) Handles txt2Width.MouseClick
        txt2Width.SelectAll()
    End Sub

    Private Sub txt3Height_MouseClick(sender As Object, e As MouseEventArgs) Handles txt3Height.MouseClick
        txt3Height.SelectAll()
    End Sub
End Class