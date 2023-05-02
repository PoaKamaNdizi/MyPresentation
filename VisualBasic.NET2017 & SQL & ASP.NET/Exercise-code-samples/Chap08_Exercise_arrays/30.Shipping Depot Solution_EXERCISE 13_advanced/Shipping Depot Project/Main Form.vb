Option Explicit On
Option Strict On
Option Infer Off
' The Shipping Depot store ships packages by FedEx, UPS and USPS
'-> create a GUI shown in a picture (groupbox, 11 labels, 2 buttons(I made 3)
'-> btnDisplay_Click event procedure should:
'    -> declare 2D Array that contains 4 rows (one for each week) & 3 columns (one for each shipper)
'    -> initialize the Array using the data shown in Figure 8-50
'    -> display the total: -> number of packages shipped ... lbl0Total ... int0Total
'                          -> shipped by FedEx           ... lbl1FedEx ... int1FedEx
'                          -> shipped by UPS             ... lbl2UPS   ... int2UPS
'                          -> shipped by USPS            ... lbl3USPS  ... int3USPS
'    -> display % of total number with a % sign and no decimal places: -> shipped by FedEx ...lbl4FedExPerc ... 
'                                                                      -> shipped by UPS   ...lbl5UPSPerc   ... 
'                                                                      -> shipped by USPS  ...lbl6USPSPerc  ... 
Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim int2Dinfo(,) As Integer = {{225, 216, 150}, {199, 225, 215}, {230, 200, 225}, {150, 175, 200}} ' 4 weeks, 3 shippers
        ' ttl= 2410, ttl FedEx= 804(33.36%), ttl UPS= 816(33.86%); ttl USPS= 790(32.78%)  <- ok

        Dim int0Total As Integer
        Dim int1FedEx As Integer
        Dim int2UPS As Integer
        Dim int3USPS As Integer
        Dim dbl4FedExPerc As Double
        Dim dbl5UPS As Double
        Dim dbl6USPS As Double

        ' int0Total, lbl0Total:
        For Each intElements As Integer In int2Dinfo
            int0Total += intElements
            lbl0Total.Text = int0Total.ToString ' = 2410 ok
        Next intElements

        ' int1-3, lbl1-3:
        For intRow As Integer = 0 To int2Dinfo.GetUpperBound(0) ' 0-1-2-3 ok
            int1FedEx += int2Dinfo(intRow, 0)
            int2UPS += int2Dinfo(intRow, 1)
            int3USPS += int2Dinfo(intRow, 2)
        Next intRow
        lbl1FedEx.Text = int1FedEx.ToString
        lbl2UPS.Text = int2UPS.ToString
        lbl3USPS.Text = int3USPS.ToString

        ' %:
        dbl4FedExPerc = int1FedEx / int0Total
        lbl4FedExPerc.Text = dbl4FedExPerc.ToString("P0") ' 33% ok

        dbl5UPS = int2UPS / int0Total
        lbl5UPSPerc.Text = dbl5UPS.ToString("P0") ' 34% ok

        dbl6USPS = int3USPS / int0Total
        lbl6USPSPerc.Text = dbl6USPS.ToString("P0") '33% ok

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbl0Total.Text = Nothing
        lbl1FedEx.Text = Nothing
        lbl2UPS.Text = Nothing
        lbl3USPS.Text = Nothing
        lbl4FedExPerc.Text = Nothing
        lbl5UPSPerc.Text = Nothing
        lbl6USPSPerc.Text = Nothing
    End Sub
End Class