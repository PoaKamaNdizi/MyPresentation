Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyDatabaseDataSet.TotalSums' table. You can move, or remove it, as needed.
        ' contains SQL aggregate function SUM:
        ' SUM(HoursWorked) AS TotalHours -> creating a new field TotalHours
        ' SUM(PerHour * HoursWorked) AS TotalSalaries -> creating a new field TotalSalaries
        Me.TotalSumsTableAdapter.Fill(Me.MyDatabaseDataSet.TotalSums)

        'TODO: This line of code loads data into the 'MyDatabaseDataSet.MyTable' table. You can move, or remove it, as needed.
        ' contains a Calculated field created by modifying the default SQL statement:
        '...PerHour * HoursWorked AS [Total Salary]
        Me.MyTableTableAdapter.Fill(Me.MyDatabaseDataSet.MyTable)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Select Case True
            Case rad1IdAsc.Checked
                MyTableTableAdapter.Fill(MyDatabaseDataSet.MyTable)
            Case rad2PerHourAsc.Checked
                MyTableTableAdapter.FillBy_rad2PerHourAsc(MyDatabaseDataSet.MyTable)
            Case rad3PerHourDes.Checked
                MyTableTableAdapter.FillBy_rad3PerHourDes(MyDatabaseDataSet.MyTable)
            Case rad4HoursWorkedAsc.Checked
                MyTableTableAdapter.FillBy_rad4HoursWorkedAsc(MyDatabaseDataSet.MyTable)
            Case rad5HoursWorkedDes.Checked
                MyTableTableAdapter.FillBy_rad5HoursWorkedDes(MyDatabaseDataSet.MyTable)
            Case rad6TotalAsc.Checked
                MyTableTableAdapter.FillBy_rad6TotalAsc(MyDatabaseDataSet.MyTable)
            Case rad7TotalDes.Checked
                MyTableTableAdapter.FillBy_rad7TotalDes(MyDatabaseDataSet.MyTable)
        End Select
    End Sub

    Private Sub radAll_CheckedChanged(sender As Object, e As EventArgs) Handles rad1IdAsc.CheckedChanged, rad2PerHourAsc.CheckedChanged,
                                    rad3PerHourDes.CheckedChanged, rad4HoursWorkedAsc.CheckedChanged, rad5HoursWorkedDes.CheckedChanged,
                                    rad6TotalAsc.CheckedChanged, rad6TotalAsc.CheckedChanged
        ' my idea for a čistírna: I created a Query whose condition can't be fulfilled, therefore it shows nothing:
        MyTableTableAdapter.FillBy_Empty(MyDatabaseDataSet.MyTable)
    End Sub
End Class