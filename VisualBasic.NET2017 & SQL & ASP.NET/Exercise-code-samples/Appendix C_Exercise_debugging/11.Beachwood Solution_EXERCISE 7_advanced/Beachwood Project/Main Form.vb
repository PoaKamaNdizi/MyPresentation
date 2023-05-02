' Name:         Beachwood Project
' Purpose:      Display the total pounds of coffee ordered and the total price of the order,
'               including sales tax and shipping.
' Programmer:   <your name> on <current date>
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays the total pounds of coffee ordered
        ' and the total price of the order, including sales tax and shipping.

        Const decPRICE_PER_POUND As Decimal = 11.15D
        Const decSALES_TAX_RATE As Decimal = 0.02D
        Const decSHIPPING_CHARGE As Decimal = 5D

        Dim intRegular As Integer
        Dim intDecaf As Integer
        Dim intTotalPounds As Integer
        Dim decSubTotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalPrice As Decimal

        Integer.TryParse(txtRegular.Text, intRegular)       ' test = 1
        Integer.TryParse(txtDecaf.Text, intDecaf)           ' test = 1
        intTotalPounds = intRegular + intDecaf              ' test = 2 OK         'logic error - calculation missing
        decSubTotal = intTotalPounds * decPRICE_PER_POUND   ' test = 22.30 OK
        decSalesTax = decSubTotal * decSALES_TAX_RATE       ' test = 0.4460
        decTotalPrice = decSubTotal + decSalesTax + decSHIPPING_CHARGE    ' test = 27.7460 OK
        lblShipping.Text = decSHIPPING_CHARGE.ToString("C2")   ' logic error - statement missing
        lblPounds.Text = intTotalPounds.ToString("N2")
        lblTotalPrice.Text = decTotalPrice.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class