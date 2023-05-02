Option Explicit On
Option Strict On
Option Infer Off
' create an app that dislays: - the total sales made in each of three regions: US, Canada, Mexico -> no decimal places, $
'                             - total Company sales -> no decimal places, $
'                             - percentage that each region contributed to the total sales -> no decimal places, %
' store the sales amounts (Figure 8-52) in a 2D Array (6 months; US, Canada, Mexico) 
Public Class frmMain
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        ' all of the amounts are originally *1000:
        Dim dblSales(,) As Double = {{120, 90, 65}, {190, 85, 64}, {175, 80, 71}, {188, 83, 67}, {125, 87, 65}, {163, 80, 64}}
        ' ttl US = 961,000; ttl Canada = 505,000; ttl Mexico = 396,000

        Dim dblAmounts(8) As Double

        ' ttls $:
        For intRowIndexes As Integer = 0 To dblSales.GetUpperBound(0)
            For intCounter As Integer = 0 To 2
                dblAmounts(intCounter + 1) += dblSales(intRowIndexes, intCounter)   ' same like: *
            Next intCounter
            'dblAmounts(1) += dblSales(intRowIndexes, 0) ' 1_ttl US = 961           ' same like: *
            'dblAmounts(2) += dblSales(intRowIndexes, 1) ' 2_ttl Canada = 505       ' same like: *
            'dblAmounts(3) += dblSales(intRowIndexes, 2) ' 3_ttl Mexico = 396       ' same like: *
        Next intRowIndexes

        ' 4_ttl Company: 1,862
        For Each dblElement As Double In dblSales
            dblAmounts(4) += dblElement
        Next dblElement

        For intCounter1 As Integer = 5 To 7
            dblAmounts(intCounter1) = (dblAmounts(intCounter1 - 4) / dblAmounts(4))     ' same like: **
            dblAmounts(8) += dblAmounts(intCounter1)                                            ' same like: ***
        Next intCounter1

        ' perc_US= 51.6%; perc_Canada= 27.1%; perc_Mexico = 21.3%
        'dblAmounts(5) = (dblAmounts(1) / dblAmounts(4))                                ' same like: **
        'dblAmounts(6) = (dblAmounts(2) / dblAmounts(4))                                ' same like: **
        'dblAmounts(7) = (dblAmounts(3) / dblAmounts(4))                                ' same like: **

        'dblAmounts(8) = dblAmounts(5) + dblAmounts(6) + dblAmounts(7)                          ' same like: ***

        lbl1Ttl_US.Text = (1000 * dblAmounts(1)).ToString("C0")
        lbl2Ttl_Canada.Text = (1000 * dblAmounts(2)).ToString("C0")
        lbl3Ttl_Mexico.Text = (1000 * dblAmounts(3)).ToString("C0")
        lbl4Ttl_Company.Text = (1000 * dblAmounts(4)).ToString("C0")
        lbl5Perc_US.Text = dblAmounts(5).ToString("P0")
        lbl6Perc_Canada.Text = dblAmounts(6).ToString("P0")
        lbl7Perc_Mexico.Text = dblAmounts(7).ToString("P0")
        lbl8Perc_Company.Text = dblAmounts(8).ToString("P0")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbl1Ttl_US.Text = String.Empty
        lbl2Ttl_Canada.Text = String.Empty
        lbl3Ttl_Mexico.Text = String.Empty
        lbl4Ttl_Company.Text = String.Empty
        lbl5Perc_US.Text = String.Empty
        lbl6Perc_Canada.Text = String.Empty
        lbl7Perc_Mexico.Text = String.Empty
        lbl8Perc_Company.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class