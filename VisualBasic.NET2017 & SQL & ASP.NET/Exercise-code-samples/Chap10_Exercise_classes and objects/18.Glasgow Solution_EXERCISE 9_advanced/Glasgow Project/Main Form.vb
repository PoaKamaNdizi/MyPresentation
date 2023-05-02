' Name:       Glasgow Project
' Purpose:    Calculate member's monthly due
' Programmer: PoaKamaNdizi on JustNow
'_1. create GUI shown in Figure 10-43

'_2. frmMain: display: member's basic fee, additional charges, monthly dues
'_  - monthly dues consists of a basic fee and 1 or more optional charges
'_     -> single/family + Golf, Tennis, Racquetball
'_  - if single membership ($50), then: Golf = $25, Tennis = $30, Racquetball = $20
'_  - if family membership ($90), then: Golf = $35, Tennis = $50, Racquetball = $30

'_3. class.vb: - use the class to code the application
'_  - create a Class named "Dues", that:
'_  - contains 2 auto-implemented properties for: Basic charges and Additional charges
'_  - default constructor, parameterized constructor
'_  - method that calculates and returns the total monthly dues
' test
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' accumulator for chks:
    Public intAdditional As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Select Case False
            ' if non chk is selected:
            Case chk1golf.Checked OrElse chk2tennis.Checked OrElse chk3racq.Checked
                MessageBox.Show("Please select at least 1 activity.", "Glasgow Health Club",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' if at least 1 chk is selected:
            Case Else
                lbl1basic.BackColor = Color.Yellow : lbl2additional.BackColor = Color.Yellow
                lbl3dues.BackColor = Color.Yellow

                intAdditional = 0   ' erase previous values, otherwise they would accumulate

                Dim MyDues As Dues
                Dim intBasic As Integer
                Dim int2DPrices(,) As Integer = {{50, 25, 30, 20}, {90, 35, 50, 30}} ' 0,0 = 50; 0,1 = 25...
                'MessageBox.Show(int2DPrices(0, 1).ToString) '= 25, ok

                Select Case True
                    Case rad1single.Checked
                        intBasic = int2DPrices(0, 0)

                        If chk1golf.Checked = True Then
                            intAdditional += int2DPrices(0, 1)
                        End If

                        If chk2tennis.Checked = True Then
                            intAdditional += int2DPrices(0, 2)
                        End If

                        If chk3racq.Checked = True Then
                            intAdditional += int2DPrices(0, 3)
                        End If

                    Case rad2family.Checked
                        intBasic = int2DPrices(1, 0)

                        If chk1golf.Checked = True Then
                            intAdditional += int2DPrices(1, 1)
                        End If

                        If chk2tennis.Checked = True Then
                            intAdditional += int2DPrices(1, 2)
                        End If

                        If chk3racq.Checked = True Then
                            intAdditional += int2DPrices(1, 3)
                        End If
                End Select

                'MessageBox.Show(intBasic.ToString) ' check the dimension_OK
                'MessageBox.Show(intAdditional.ToString)   ' check additional_OK

                ' invoke parameterized constructor by flushing him input data:
                MyDues = New Dues(intBasic, intAdditional)

                lbl1basic.Text = intBasic.ToString("C2")
                lbl2additional.Text = intAdditional.ToString("C2")
                lbl3dues.Text = MyDues.GetTotal.ToString("C2")
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radsANDchks_CheckedChanged(sender As Object, e As EventArgs) Handles rad1single.CheckedChanged,
       rad2family.CheckedChanged, chk1golf.CheckedChanged, chk2tennis.CheckedChanged, chk3racq.CheckedChanged
        lbl1basic.BackColor = SystemColors.Control : lbl1basic.Text = Nothing
        lbl2additional.BackColor = SystemColors.Control : lbl2additional.Text = Nothing
        lbl3dues.BackColor = SystemColors.Control : lbl3dues.Text = Nothing
    End Sub
End Class