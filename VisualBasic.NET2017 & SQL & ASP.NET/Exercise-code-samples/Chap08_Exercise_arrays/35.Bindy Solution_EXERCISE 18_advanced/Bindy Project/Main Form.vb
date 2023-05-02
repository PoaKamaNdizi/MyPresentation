Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private dbl2DIndex(,) As Double = {{101, 102, 103, 104, 105, 106, 107, 108, 109, 110},
                                       {4.99, 4.99, 10.49, 10.49, 6.79, 6.79, 6.79, 21.99, 21.99, 21.99}}
    Private str1DColors() As String = {"Blue", "Red", "Blue", "Red", "White", "Red", "Blue", "Black", "White", "Blue"}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For intCounter As Integer = 0 To dbl2DIndex.GetUpperBound(1)    ' 10x
            lst1_ID.Items.Add(dbl2DIndex(0, intCounter))
        Next intCounter

        lst2_Color.Items.Add("Black")   ' SelectedIndex = 0
        lst2_Color.Items.Add("Blue")    ' SelectedIndex = 1
        lst2_Color.Items.Add("Red")     ' SelectedIndex = 2
        lst2_Color.Items.Add("White")   ' SelectedIndex = 3
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lst0_Show.Items.Clear()

        Select Case True
            Case rad1_ID.Checked  '= (rad1_ID) - display ID's color & price:_OK
                For intIndex As Integer = 0 To 9
                    If lst1_ID.SelectedIndex = intIndex Then
                        'MessageBox.Show(intIndex.ToString)   ' shows an index of selected item_OK
                        lst0_Show.Items.Insert(0, dbl2DIndex(0, intIndex) & ControlChars.Tab & str1DColors(intIndex) & ControlChars.Tab &
                                                  dbl2DIndex(1, intIndex).ToString("C2"))
                    End If
                Next intIndex

            Case rad2_Color.Checked  '= (rad2_Color) - display ID's & prices in the same color:_OK
                ' Black = 1x: 108 = $21.99.
                ' Blue = 4x: 101 = $4.99...103 = $10.49...107 = $6.79...110 = $21.99.
                ' Red = 3x: 102 = $4.99...104 = $10.49...106 = $6.79.
                ' White = 2x: 105 = $6.79...109 = $21.99.

                For intCounter As Integer = 0 To dbl2DIndex.GetUpperBound(1)
                    ' lst2: BETA_working OK
                    If lst2_Color.SelectedItem Is str1DColors(intCounter) Then
                        lst0_Show.Sorted = True
                        lst0_Show.Items.Insert(0, dbl2DIndex(0, intCounter) & ControlChars.Tab & str1DColors(intCounter) & ControlChars.Tab &
                                                  dbl2DIndex(1, intCounter).ToString("C2"))
                    End If
                Next intCounter

                ' lst2: ALFA_working, but not the best one (i will try it more easy in BETA version)
                'For intColorIndex As Integer = 0 To 3
                'If lst2_Color.SelectedIndex = intColorIndex Then
                ''lst0_Show.Items.Insert(0, lst2_Color.SelectedIndex)    ' shows Index of selected color from lst2_Color_OK
                'If lst2_Color.SelectedIndex = 0 Then
                ''0 = "Black" = str1DColors index = 7
                'lst0_Show.Items.Insert(0, dbl2DIndex(0, 7) & ControlChars.Tab & str1DColors(7) & ControlChars.Tab & dbl2DIndex(1, 7).ToString("C2"))
                'ElseIf lst2_Color.SelectedIndex = 1 Then
                ''1 = "Blue" = str1DColors index = 0, 2, 6, 9
                'lst0_Show.Items.Insert(0, dbl2DIndex(0, 0) & ControlChars.Tab & str1DColors(0) & ControlChars.Tab & dbl2DIndex(1, 0).ToString("C2"))
                'lst0_Show.Items.Insert(1, dbl2DIndex(0, 2) & ControlChars.Tab & str1DColors(2) & ControlChars.Tab & dbl2DIndex(1, 2).ToString("C2"))
                'lst0_Show.Items.Insert(2, dbl2DIndex(0, 6) & ControlChars.Tab & str1DColors(6) & ControlChars.Tab & dbl2DIndex(1, 6).ToString("C2"))
                'lst0_Show.Items.Insert(3, dbl2DIndex(0, 9) & ControlChars.Tab & str1DColors(9) & ControlChars.Tab & dbl2DIndex(1, 9).ToString("C2"))
                'ElseIf lst2_Color.SelectedIndex = 2 Then
                ''2 = "Red" = str1DColors index = 1, 3, 5
                'lst0_Show.Items.Insert(0, dbl2DIndex(0, 1) & ControlChars.Tab & str1DColors(1) & ControlChars.Tab & dbl2DIndex(1, 1).ToString("C2"))
                'lst0_Show.Items.Insert(1, dbl2DIndex(0, 3) & ControlChars.Tab & str1DColors(3) & ControlChars.Tab & dbl2DIndex(1, 3).ToString("C2"))
                'lst0_Show.Items.Insert(2, dbl2DIndex(0, 5) & ControlChars.Tab & str1DColors(5) & ControlChars.Tab & dbl2DIndex(1, 5).ToString("C2"))
                'ElseIf lst2_Color.SelectedIndex = 3 Then
                ''3 = "White" = str1DColors index = 4, 8
                'lst0_Show.Items.Insert(0, dbl2DIndex(0, 4) & ControlChars.Tab & str1DColors(4) & ControlChars.Tab & dbl2DIndex(1, 4).ToString("C2"))
                'lst0_Show.Items.Insert(1, dbl2DIndex(0, 8) & ControlChars.Tab & str1DColors(8) & ControlChars.Tab & dbl2DIndex(1, 8).ToString("C2"))
                'End If
                'End If
                'Next intColorIndex

            Case rad3_EnterThePrice.Checked   '_OK
                Dim dblEnterThePrice As Double
                Double.TryParse(txtEnterThePrice.Text, dblEnterThePrice)

                For intCounter As Integer = 0 To dbl2DIndex.GetUpperBound(1)
                    If dblEnterThePrice >= dbl2DIndex(1, intCounter) Then
                        lst0_Show.Sorted = True
                        lst0_Show.Items.Insert(0, dbl2DIndex(0, intCounter) & ControlChars.Tab & str1DColors(intCounter) & ControlChars.Tab &
                                                  dbl2DIndex(1, intCounter).ToString("C2"))
                    End If
                Next intCounter
                txtEnterThePrice.SelectAll()
        End Select
    End Sub

    Private Sub txtEnterThePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnterThePrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) Handles lst1_ID.SelectedIndexChanged, lst2_Color.SelectedIndexChanged,
                                                                       txtEnterThePrice.TextChanged
        lst0_Show.Items.Clear()
    End Sub

    Private Sub rad1_ID_CheckedChanged(sender As Object, e As EventArgs) Handles rad1_ID.CheckedChanged
        lst1_ID.Enabled = True
        lst2_Color.Enabled = False
        txtEnterThePrice.Enabled = False
        lst2_Color.SelectedItem = Nothing
        txtEnterThePrice.Text = Nothing
        lst0_Show.Items.Clear()
        lst1_ID.Focus()
    End Sub

    Private Sub rad2_Color_CheckedChanged(sender As Object, e As EventArgs) Handles rad2_Color.CheckedChanged
        lst2_Color.Enabled = True
        lst1_ID.Enabled = False
        txtEnterThePrice.Enabled = False
        lst1_ID.SelectedItem = Nothing
        txtEnterThePrice.Text = Nothing
        lst0_Show.Items.Clear()
        lst2_Color.Focus()
    End Sub

    Private Sub rad3_EnterThePrice_CheckedChanged(sender As Object, e As EventArgs) Handles rad3_EnterThePrice.CheckedChanged
        txtEnterThePrice.Enabled = True
        lst1_ID.Enabled = False
        lst2_Color.Enabled = False
        lst1_ID.SelectedItem = Nothing
        lst2_Color.SelectedItem = Nothing
        lst0_Show.Items.Clear()
        txtEnterThePrice.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class