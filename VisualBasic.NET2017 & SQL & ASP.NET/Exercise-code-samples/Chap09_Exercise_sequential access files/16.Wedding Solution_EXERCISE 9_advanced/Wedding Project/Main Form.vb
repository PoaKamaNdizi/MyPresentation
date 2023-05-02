Option Explicit On
Option Strict On
Option Infer Off

'The application should:
'create GUI:
'-1. 3x (lst): (lstInvited); Sorted = True; SelectionMode = One.          = invited.txt    = inFiles(0)
'-             (lstAccepted); Sorted = True; SelectionMode = None.        = accepted.txt   = inFiles(1)
'-             (lstRejected); Sorted = True; SelectionMode = None.        = rejected.txt   = inFiles(2)
'-2. 3x (btn): "Accepted" = (btnAccepted)
'-             "Rejected" = (btnRejected)
'-             "Exit"     = (btnExit)

'Other:
'-1. create a Sequential access file: "invited.txt" and save it in the Wedding Project's bin\Debug folder
'-   - enter the names of 20 guests in the file, each name in separate file, in the format: "LastName, FirstName"
'-2. create a Sequential access file: "accepted.txt" and save it in the Wedding Project's bin\Debug folder
'-   - enter the following 2 names in the file: "Nitzki, Akanna", and "Jefferson, Josephine"
'-3. create a Sequential access file: "rejected.txt" and save it in the Wedding Project's bin\Debug folder
'-   - enter the following name in the file: "Kellog, Zelda"

'Code:
'-1. when the GUI appears, each (lst) should be filled with a names from the appropriate Sequential Access Files

' 2. (btnAccepted) should: move the name selected in (lstInvited) to the (lstAccepted)

' 3. (btnRejected) should: move the name selected in (lstInvited) to the (lstRejected)

' 4. before the form is closed, its "FormClosing" procedure should: save the contents of each (lst) in the appropriate file
'that's all

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 1. when the GUI appears, each (lst) should be filled with a names from the appropriate Sequential Access Files

        'Invited()

        Dim inFiles(2) As IO.StreamReader

        If IO.File.Exists("invited.txt") AndAlso IO.File.Exists("accepted.txt") AndAlso IO.File.Exists("rejected.txt") Then
            'MessageBox.Show("OK")

            inFiles(0) = IO.File.OpenText("invited.txt")
            inFiles(1) = IO.File.OpenText("accepted.txt")
            inFiles(2) = IO.File.OpenText("rejected.txt")

            Do Until inFiles(0).Peek = -1
                lstInvited.Items.Add(inFiles(0).ReadLine)
            Loop
            'lstInvited.SelectedIndex = 0
            inFiles(0).Close()

            Invited()

            Do Until inFiles(1).Peek = -1
                lstAccepted.Items.Add(inFiles(1).ReadLine)
            Loop
            inFiles(1).Close()

            Do Until inFiles(2).Peek = -1
                lstRejected.Items.Add(inFiles(2).ReadLine)
            Loop
            inFiles(2).Close()

        Else
            MessageBox.Show("Can't locate the files.", "Wedding list", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Invited()
        If lstInvited.Items.Count = 0 Then
            btnAccepted.Enabled = False
            btnRejected.Enabled = False
            'lstInvited.SelectedIndex = Nothing
            lstInvited.SelectionMode = Nothing
        End If
    End Sub

    Private Sub btnAccepted_Click(sender As Object, e As EventArgs) Handles btnAccepted.Click
        ' 2. (btnAccepted) should: move the name selected in (lstInvited) to the (lstAccepted)

        If lstInvited.SelectedIndex >= 0 Then
            lstAccepted.Items.Add(lstInvited.SelectedItem)
            lstInvited.Items.Remove(lstInvited.SelectedItem)
        End If

        Invited()

    End Sub

    Private Sub btnRejected_Click(sender As Object, e As EventArgs) Handles btnRejected.Click
        ' 3. (btnRejected) should: move the name selected in (lstInvited) to the (lstRejected)

        If lstInvited.SelectedIndex >= 0 Then
            lstRejected.Items.Add(lstInvited.SelectedItem)
            lstInvited.Items.Remove(lstInvited.SelectedItem)
        End If

        Invited()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' 4. before the form is closed, its "FormClosing" procedure should: save the contents of each (lst) in the appropriate file
        Dim outFiles(2) As IO.StreamWriter
        outFiles(0) = IO.File.CreateText("invited.txt")
        outFiles(1) = IO.File.CreateText("accepted.txt")
        outFiles(2) = IO.File.CreateText("rejected.txt")

        For intCounter As Integer = 0 To lstInvited.Items.Count - 1
            outFiles(0).WriteLine(lstInvited.Items(intCounter))
        Next

        For intCounter As Integer = 0 To lstAccepted.Items.Count - 1
            outFiles(1).WriteLine(lstAccepted.Items(intCounter))
        Next

        For intCounter As Integer = 0 To lstRejected.Items.Count - 1
            outFiles(2).WriteLine(lstRejected.Items(intCounter))
        Next

        outFiles(0).Close()
        outFiles(1).Close()
        outFiles(2).Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class