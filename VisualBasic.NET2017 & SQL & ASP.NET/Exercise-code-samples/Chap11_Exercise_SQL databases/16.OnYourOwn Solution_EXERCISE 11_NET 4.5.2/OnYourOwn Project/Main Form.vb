Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub MyFactuurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyFactuurBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MyFactuurBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OnYourOwnDatabaseDataSet)
            MessageBox.Show("Saved.", "% Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblCounter.Text = Nothing : lblCZ.Text = Nothing : lblFR.Text = Nothing : lblResult.Text = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "% Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnYourOwnDatabaseDataSet.MyFactuur' table. You can move, or remove it, as needed.
        Me.MyFactuurTableAdapter.Fill(Me.OnYourOwnDatabaseDataSet.MyFactuur)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblCZ As Double : Dim dblOther As Double : Dim dblALL As Double : Dim intCounter As Integer
        For Each row As OnYourOwnDatabaseDataSet.MyFactuurRow In OnYourOwnDatabaseDataSet.MyFactuur.Rows
            If row.Code = "CZ" Then
                dblCZ += 1
            Else
                dblOther += 1
            End If
            intCounter += 1
        Next row
        'MessageBox.Show(intCZ.ToString) = 2 = 40%
        'MessageBox.Show(intFR.ToString) = 3 = 60%

        dblALL = dblCZ + dblOther ' intALL = 5 = 100%

        dblCZ /= dblALL
        dblOther = 1 - dblCZ

        lblCZ.Text = dblCZ.ToString("P0")
        lblFR.Text = dblOther.ToString("P0")
        lblCounter.Text = intCounter.ToString

        If dblCZ >= 0.25 Then
            lblResult.ForeColor = Color.Green
            lblResult.Text = "So far so good."
        Else
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Need some CZ invoices."
        End If
    End Sub
End Class