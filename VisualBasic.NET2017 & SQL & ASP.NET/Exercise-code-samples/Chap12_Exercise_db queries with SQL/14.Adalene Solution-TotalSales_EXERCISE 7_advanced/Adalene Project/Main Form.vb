' Name:         Adalene Project
' Purpose:      Select and view records.
' Programmer:   <your name> on <current date>
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdaleneDataSet.SalesFranchisees' table. You can move, or remove it, as needed.
        Me.SalesFranchiseesTableAdapter.FillByFranchisees(Me.AdaleneDataSet.SalesFranchisees)
        'TODO: This line of code loads data into the 'AdaleneDataSet.SalesCompany' table. You can move, or remove it, as needed.
        Me.SalesCompanyTableAdapter.FillByCompany(Me.AdaleneDataSet.SalesCompany)
        'TODO: This line of code loads data into the 'AdaleneDataSet.SalesAll' table. You can move, or remove it, as needed.
        Me.SalesAllTableAdapter.FillByAll(Me.AdaleneDataSet.SalesAll)
        'TODO: This line of code loads data into the 'AdaleneDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.AdaleneDataSet.Stores)

        'lblAll.Text = StoresTableAdapter.Fill(AdaleneDataSet.Stores).ToString

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If radCompany.Checked Then ' display only Ownership = 'C'
            StoresTableAdapter.FillByOwnership_Company(AdaleneDataSet.Stores)
        ElseIf radFranchisee.Checked Then ' display only Ownership = 'F'
            StoresTableAdapter.FillByOwnership_Franchisee(AdaleneDataSet.Stores)
        Else ' display default all - C + F
            StoresTableAdapter.Fill(AdaleneDataSet.Stores)
        End If
    End Sub

    Private Sub Allrad_CheckedChanged(sender As Object, e As EventArgs) Handles radAll.CheckedChanged, radCompany.CheckedChanged,
        radFranchisee.CheckedChanged
        ' my idea for clearing values when (rad)s changed.
        StoresTableAdapter.FillByEmpty(AdaleneDataSet.Stores)
    End Sub
End Class