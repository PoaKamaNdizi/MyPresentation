'1. every ODD digit (even index) add together: 6+1+2+1+6 ==16
'2. every EVEN digit (odd index) multiply by 2: 3*2=6, 6*2=12, 0*2=0, 7*2=14              =6  (=32)
'2b. if a product from step 2. is greater than 9, sum the two digits: 12:1+2=3, 14:1+4=5  =8  (==14)
'3. add together the results from step 1. and step 2: 16+14=30
'4. divide the sum from step 3 by 10 and find the remainder: 30 Mod 10
'5. if the remainder is 0, then the number is valid
' txtNumber (MaxLength property = 9), lblStatus
' 631620176
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim strNumber As String = txtNumber.Text
        Dim intDigit As Integer         ' will be used as a single digit picked from both: even index & odd index
        Dim intTwoDigits As Integer     ' 2b. 2 digits
        Dim intSumOdd As Integer        ' 1. will add together all ODD digits (even indexes)
        Dim intSumEven As Integer       ' 2. EVEN digits *2, but if 2 digits then add them together
        Dim intTotalSum As Integer      ' 3. results from 1. & 2. add together 16+14=30
        Dim intRemainder As Integer     ' 4. intTotalSum Mod 10

        If strNumber.Length = 9 Then    ' user entry must have 9 digits to continue

            For intEvenIndex As Integer = 0 To 8 Step 2                 ' 1.even indexes 0-2-4-6-8
                ' 1.from strNumber pick character with index of intEvenIndex and transform it to a number named intDigit
                Integer.TryParse(strNumber(intEvenIndex), intDigit)
                intSumOdd += intDigit                                   ' 1.odd numbers
            Next intEvenIndex                                           ' 1.loop
            'MessageBox.Show(intSumOdd.ToString)                        ' 1. 6+1+2+1+6 = 16 .ok

            For intOddIndex As Integer = 1 To 7 Step 2                  ' 2.odd indexes
                ' 2.from strNumber pick character with index of intOddIndex and transform it to a number named intDigit
                Integer.TryParse(strNumber(intOddIndex), intDigit)
                'MessageBox.Show(intDigit.ToString)                     ' 2. 3, 6, 0, 7 .ok
                intDigit = intDigit * 2

                If intDigit > 9 Then                                    ' 2. if intDigit has a 2 digits
                    'MessageBox.Show(intMultiplied.ToString)            ' 2. 12, 14 .ok
                    intTwoDigits = (intDigit - 10) + 1
                    'MessageBox.Show(intTwoDigits.ToString)             ' 2. 3, 5 .ok
                    intSumEven += intTwoDigits
                Else
                    intSumEven += intDigit
                End If

            Next intOddIndex
            'MessageBox.Show(intSumEven.ToString)                       ' 2. =14 .ok

            intTotalSum = intSumOdd + intSumEven                        ' 3.
            'MessageBox.Show(intTotalSum.ToString)                      ' 3. =30 .ok

            intRemainder = intTotalSum Mod 10
            'MessageBox.Show(intRemainder.ToString)                     ' 4. =0 .ok

            If intRemainder = 0 Then
                lblStatus.Text = "Valid number"
                txtNumber.Focus()
                txtNumber.SelectAll()

            Else
                lblStatus.Text = "Invalid number"
                txtNumber.Focus()
                txtNumber.SelectAll()
            End If

        Else
            MessageBox.Show("Please enter a 9-digit number.", "Number validator",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNumber.Focus()
            txtNumber.SelectAll()
            lblStatus.Text = String.Empty
        End If

    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblStatus.Text = String.Empty
    End Sub
    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Verify that the user wants to kill the application.

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Number validator",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        ' If the "No" button is selected, do not close the form:
        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class