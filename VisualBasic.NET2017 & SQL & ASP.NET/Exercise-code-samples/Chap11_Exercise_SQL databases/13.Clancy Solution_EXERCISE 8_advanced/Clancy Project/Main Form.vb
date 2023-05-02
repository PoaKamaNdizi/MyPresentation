Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClancyDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.ClancyDataSet.Stores)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' field Ownership: "C" = Company-owned, "F" = Franchisee
        ' lbls: $ and integers
        Dim intC As Integer : Dim intF As Integer

        For Each row As ClancyDataSet.StoresRow In ClancyDataSet.Stores.Rows
            Select Case True
                Case row.Ownership = "C"
                    intC += row.Sales
                Case Else
                    intF += row.Sales
            End Select
        Next row
        lbl1C.Text = intC.ToString("C0") : lbl2F.Text = intF.ToString("C0") : lbl3T.Text = (intC + intF).ToString("C0")
    End Sub
End Class