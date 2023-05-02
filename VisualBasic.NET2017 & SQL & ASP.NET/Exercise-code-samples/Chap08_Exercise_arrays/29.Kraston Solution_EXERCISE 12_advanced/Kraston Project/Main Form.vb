Option Explicit On
Option Strict On
Option Infer Off
' Display a shipping charge based on the number of Items a customer orders (txtOrdered):
' store the Minimum order amounts & Shipping charges in 2D Class-level Array
' display the appropriate shipping charge with a $ and 2 decimal places in (lblShipping)
'0-0= N/A; 1-5= 10.99; 6-10= 7.99; 11-20= 3.99; 21-no maximum= 0.

Public Class frmMain
    Private dblArray As Double(,) = {{1, 6, 11, 21}, {10.99, 7.99, 3.99, 0}}

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intOrdered As Integer
        Integer.TryParse(txtOrdered.Text, intOrdered)

        If intOrdered = 0 Then
            lblShipping.Text = "N/A"
        Else
            For intIndex As Integer = 0 To dblArray.GetUpperBound(1)
                'MessageBox.Show(intIndex.ToString)   ' shows: 0-1-2-3, because 4 columns, therefore correct
                ' if you use GetUpperBound(0), then it shows: 0-1, because 2 rows, therefore wrong
                If intOrdered >= dblArray(0, intIndex) Then
                    lblShipping.Text = dblArray(1, intIndex).ToString("C2")
                End If

            Next intIndex
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtordered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrdered.KeyPress
        ' Accept numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtordered_TextChanged(sender As Object, e As EventArgs) Handles txtOrdered.TextChanged
        lblShipping.Text = String.Empty
    End Sub

    Private Sub txtOrdered_Enter(sender As Object, e As EventArgs) Handles txtOrdered.Enter
        txtOrdered.SelectAll()
    End Sub

End Class