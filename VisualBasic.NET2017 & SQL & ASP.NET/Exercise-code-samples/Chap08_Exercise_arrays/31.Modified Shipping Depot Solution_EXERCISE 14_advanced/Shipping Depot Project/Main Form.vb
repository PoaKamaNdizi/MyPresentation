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
'MOD: locate the btnDisplay_Click event procedure and:
'       -> change 2D Array from 4x3 into 3x4 (each row for each shipper & each column for each week)
'       -> make the necessary modifications to the procedure's code
Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim int2DinfoMod(,) As Integer = {{225, 199, 230, 150}, {216, 225, 200, 175}, {150, 215, 225, 200}}  ' 3 shippers, 4 weeks
        ' ttl= 2410, ttl FedEx= 804(33.36%), ttl UPS= 816(33.86%); ttl USPS= 790(32.78%)  <- ok

        Dim int0Total As Integer
        Dim int1FedEx As Integer
        Dim int2UPS As Integer
        Dim int3USPS As Integer
        Dim dbl4FedExPerc As Double
        Dim dbl5UPS As Double
        Dim dbl6USPS As Double

        'MOD: int0Total, lbl0Total:
        For Each intElements As Integer In int2DinfoMod
            int0Total += intElements
            lbl0Total.Text = int0Total.ToString ' = 2410 ok
        Next intElements

        'MOD: int1-3, lbl1-3:
        For intCol As Integer = 0 To int2DinfoMod.GetUpperBound(1) ' 0-1-2-3 ok
            int1FedEx += int2DinfoMod(0, intCol)
            int2UPS += int2DinfoMod(1, intCol)
            int3USPS += int2DinfoMod(2, intCol)
        Next intCol

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