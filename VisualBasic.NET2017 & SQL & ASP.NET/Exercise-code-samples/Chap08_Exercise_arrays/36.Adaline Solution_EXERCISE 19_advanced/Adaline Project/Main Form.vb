Option Explicit On
Option Strict On
Option Infer Off

'declare a Class-level Integer 2D Array to store amounts for the following salespeople.
'   - you can create either a 2-row & 6-column or 6-row & 2-column 2D Array.
'Salespeople:      2018 Sales ($):     2019 Sales ($):        Total:
' All                  22,000              38,900             60,900
' Jacob Schmidt         4,000               7,200             11,200
' Joe Smith             4,000               5,000              9,000
' Rex Parker            2,500               6,500              9,000
' Sue Chen              4,000               7,200             11,200
' Sue Perez             3,900               6,000              9,900
' Suman Patel           3,600               7,000             10,600

'GroupBox1: (btn1_DisplaySales) should:
' display in (lbl1_Sales) the sales amount associated with the items selected in (lst1a_Salespeople) & (lst1b_Years)
' - e.g.1: if (All) & (Both) are selected, (lbl1_Sales) should display the Total of all sales stored in 2D Array = $60,900
' - e.g.2: if (All) & (2019) are selected, (lbl1_Sales) should display only the sales amounts for the year 2019 = $38,900
' - e.g.3: if (Sue Chen) & (Both) are selected, (lbl1_Sales) should display the Total sales made by Sue Chen for both years = $11,200
' - e.g.4: if (Sue Chen) & (2018) are selected, (lbl1_Sales) should display only the amount Sue Chen sold in 2018 = $4000

'GroupBox2: (btn2_SalesAndNames) should:
' display the sales amount in (lbl2_Sales) and names in (lst2c_SoldBy) associated with the items selected in (lst2a_Years) & (lst2b_Status)
' - e.g.1: if (2018) & (Highest) are selected:
'      (lbl2_Sales) should display the highest sales amount made in 2018 = $4,000 &
'      (lst2c_SoldBy) should display the name of each salesperson who made that sales amount = Jacob Schmidt, Joe Smith, Sue Chen

Public Class frmMain

    ' {2018, 2019}:
    Private intAmounts2D(,) As Integer = {{4000, 7200}, {4000, 5000}, {2500, 6500}, {4000, 7200}, {3900, 6000}, {3600, 7000}}
    ' idea for _Load and selecting and answering: - added "All" & changed indexes:
    Private strNames() As String = {"All", "Jacob Schmidt", "Joe Smith", "Rex Parker", "Sue Chen", "Sue Perez", "Suman Patel"}
    ' ideaa for _Load and selecting:
    Private strYears() As String = {"Both", "2018", "2019"}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' GroupBox1:
        '   (lst1a_Salespeople) from: Private str2_Names()
        For Each strName As String In strNames
            lst1a_Salespeople.Items.Add(strName)
        Next strName
        lst1a_Salespeople.SelectedIndex = 0

        '   (lst1b_Years) from: Private strYears() = {"Both", "2018", "2019"}
        For Each strYear As String In strYears
            lst1b_Years.Items.Add(strYear)
        Next strYear
        lst1b_Years.SelectedIndex = 0

        ' GroupBox2:
        '   (lst2a_Years) from: Private strYears() = {"Both", "2018", "2019"} - but only indexes 1&2
        lst2a_Years.Items.Add(strYears(1))
        lst2a_Years.Items.Add(strYears(2))
        lst2a_Years.SelectedIndex = 0

        '   (lst2b_Status)
        lst2b_Status.Items.Add("Highest")
        lst2b_Status.Items.Add("Lowest")
        lst2b_Status.SelectedIndex = 0
    End Sub


    Private Sub btn1_DisplaySales_Click(sender As Object, e As EventArgs) Handles btn1_DisplaySales.Click
        ' lst1a_Salespeople -> index 0(all) to index 6
        ' lst1b_Years -> 0=all, 1=2018, 2=2019
        Dim intNumbers As Integer = Nothing

        If lst1a_Salespeople.SelectedIndex = 0 Then                 ' all Salesperson:
            Select Case True
                Case lst1b_Years.SelectedIndex = 0                      ' all in 2018 + 2019:
                    For Each intElement As Integer In intAmounts2D
                        intNumbers += intElement
                    Next intElement
                    lbl1_Sales.Text = intNumbers.ToString("C0")
                Case lst1b_Years.SelectedIndex = 1                      ' all in 2018:
                    For intCounter As Integer = 0 To 5
                        intNumbers += intAmounts2D(intCounter, 0)
                    Next intCounter
                    lbl1_Sales.Text = intNumbers.ToString("C0")
                Case lst1b_Years.SelectedIndex = 2                       ' all in 2019:
                    For intCounter As Integer = 0 To 5
                        intNumbers += intAmounts2D(intCounter, 1)
                    Next intCounter
                    lbl1_Sales.Text = intNumbers.ToString("C0")
            End Select

        Else                                                         ' 1->6 each Salesperson:
            For intCounter As Integer = 1 To 6
                If lst1a_Salespeople.SelectedIndex = intCounter Then
                    Select Case True
                        Case lst1b_Years.SelectedIndex = 0                      ' in 2018 + 2019:
                            intNumbers = intAmounts2D(intCounter - 1, 0) + intAmounts2D(intCounter - 1, 1)
                            lbl1_Sales.Text = intNumbers.ToString("C0")
                        Case lst1b_Years.SelectedIndex = 1                      ' in 2018:
                            intNumbers = intAmounts2D(intCounter - 1, 0)
                            lbl1_Sales.Text = intNumbers.ToString("C0")
                        Case lst1b_Years.SelectedIndex = 2                       ' in 2019:
                            intNumbers = intAmounts2D(intCounter - 1, 1)
                            lbl1_Sales.Text = intNumbers.ToString("C0")
                    End Select

                End If
            Next intCounter
        End If
    End Sub


    Private Sub btn2_SalesAndNames_Click(sender As Object, e As EventArgs) Handles btn2_SalesAndNames.Click
        Dim intColumn As Integer = Nothing
        Dim intNumber As Integer = Nothing
        lst2c_SoldBy.Items.Clear()

        Select Case True

            ' year 2018:
            Case lst2a_Years.SelectedIndex = 0
                intColumn = 0
                intNumber = intAmounts2D(0, 0)

                ' highest in 2018: fill number (lbl2_Sales)_ok
                If lst2b_Status.SelectedIndex = 0 Then
                    For intCounter As Integer = 0 To intAmounts2D.GetUpperBound(0)
                        If intNumber < intAmounts2D(intCounter, intColumn) Then
                            intNumber = intAmounts2D(intCounter, intColumn)
                        End If
                    Next intCounter
                    lbl2_Sales.Text = intNumber.ToString("C0")

                    ' lowest in 2018: fill number (lbl2_Sales)_ok
                ElseIf lst2b_Status.SelectedIndex = 1 Then
                    For intCounter As Integer = 0 To intAmounts2D.GetUpperBound(0)
                        If intNumber > intAmounts2D(intCounter, intColumn) Then
                            intNumber = intAmounts2D(intCounter, intColumn)
                        End If
                    Next intCounter
                    lbl2_Sales.Text = intNumber.ToString("C0")
                End If

            ' year 2019:
            Case lst2a_Years.SelectedIndex = 1
                intColumn = 1
                intNumber = intAmounts2D(0, 1)

                ' highest in 2019: fill number (lbl2_Sales)_ok
                If lst2b_Status.SelectedIndex = 0 Then
                    For intCounter As Integer = 0 To intAmounts2D.GetUpperBound(0)
                        If intNumber < intAmounts2D(intCounter, intColumn) Then
                            intNumber = intAmounts2D(intCounter, intColumn)
                        End If
                    Next intCounter
                    lbl2_Sales.Text = intNumber.ToString("C0")

                    ' lowest in 2019: fill number (lbl2_Sales)_ok
                ElseIf lst2b_Status.SelectedIndex = 1 Then   ' lowest in 2019
                    For intCounter As Integer = 0 To intAmounts2D.GetUpperBound(0)
                        If intNumber > intAmounts2D(intCounter, intColumn) Then
                            intNumber = intAmounts2D(intCounter, intColumn)
                        End If
                    Next intCounter
                    lbl2_Sales.Text = intNumber.ToString("C0")
                End If
        End Select

        ' global: fill names (lst2c_SoldBy)_ok
        For intCounter2 As Integer = 0 To 5
            If intAmounts2D(intCounter2, intColumn) = intNumber Then
                lst2c_SoldBy.Items.Add(strNames(intCounter2 + 1))
            End If
        Next intCounter2

    End Sub

    Private Sub GroupBox1SelectedIndex(sender As Object, e As EventArgs) Handles lst1a_Salespeople.SelectedIndexChanged,
                                                                                 lst1b_Years.SelectedIndexChanged
        lbl1_Sales.Text = Nothing
    End Sub

    Private Sub GroupBox2SelectedIndex(sender As Object, e As EventArgs) Handles lst2a_Years.SelectedIndexChanged,
                                                                                 lst2b_Status.SelectedIndexChanged
        lbl2_Sales.Text = Nothing
        lst2c_SoldBy.Items.Clear()
    End Sub

End Class