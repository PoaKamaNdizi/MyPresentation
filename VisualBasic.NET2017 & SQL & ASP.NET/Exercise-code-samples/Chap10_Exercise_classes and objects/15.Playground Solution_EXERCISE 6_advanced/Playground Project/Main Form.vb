' Name:         Playground Project.
' Purpose:      Displays the area in square feet and cost of laying artificial grass for a triangular playground.
' Programmer:   PoaKamaNdizi on time stamp.

'_1. GUI: - 2x input lst filled with numbers 20-50 in increments of 0.5: - for "base" dimension in yards
'_                                                                       - for "height" dimension in yards
'_        - 1x input lst filled with numbers 1-6 in increments of 0.5: - for price per square foot
' 1 yard = ??? feet, 1 square foot = ??? square yards

'_2. create a Class named "Triangle", where the class should:
'_2.1. verify that the base and height dimensions are greater than 0, before assigning the values to the Private variables
'_      (although the dimensions come from list boxes in this application, the Triangle class might subsequently be used in
'_        an application whose dimensions come from text boxes - therefore, it is a good idea to verify the user's input)
'_2.2. include a default constructor
'_2.3. include a parameterized constructor
'_2.4. include a method to calculate and return the area of a triangle
' test
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'lst1Base & lst2Height: 20->50 step 0.5;  lst3Price -> 1-6 step 0.5
        For dblCounter1 As Double = 20 To 50 Step 0.5
            lst1Base.Items.Add(" " & dblCounter1)
            lst2Height.Items.Add(" " & dblCounter1)
        Next dblCounter1

        For dblCounter2 As Double = 1 To 6 Step 0.5
            lst3Price.Items.Add(" " & dblCounter2)
        Next dblCounter2

        lst1Base.SelectedIndex = 0 : lst2Height.SelectedIndex = 0 : lst3Price.SelectedIndex = 0
    End Sub

    Private Sub lst_MyCleaner(sender As Object, e As EventArgs) Handles lst1Base.SelectedIndexChanged,
            lst2Height.SelectedIndexChanged, lst3Price.SelectedIndexChanged
        lblArea.Text = Nothing
        lblTotalPrice.Text = Nothing
        lblArea.BackColor = SystemColors.Control
        lblTotalPrice.BackColor = SystemColors.Control
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblArea.BackColor = Color.Yellow
        lblTotalPrice.BackColor = Color.Yellow

        Dim MyTriangleArea As New Triangle
        Dim dblPrice As Double

        Double.TryParse(lst1Base.SelectedItem.ToString, MyTriangleArea.Base)
        Double.TryParse(lst2Height.SelectedItem.ToString, MyTriangleArea.Height)
        Double.TryParse(lst3Price.SelectedItem.ToString, dblPrice)

        ' input in square yards, output should be in square foot: 1 square yard = 9 square feet
        lblArea.Text = (MyTriangleArea.GetTriangleArea * 9).ToString("N2")
        lblTotalPrice.Text = ((MyTriangleArea.GetTriangleArea * 9) * dblPrice).ToString("C2")
    End Sub
End Class