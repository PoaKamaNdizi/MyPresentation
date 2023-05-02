Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GlobalDataSet.Salespeople' table. You can move, or remove it, as needed.
        Me.SalespeopleTableAdapter.Fill(Me.GlobalDataSet.Salespeople)
    End Sub
End Class