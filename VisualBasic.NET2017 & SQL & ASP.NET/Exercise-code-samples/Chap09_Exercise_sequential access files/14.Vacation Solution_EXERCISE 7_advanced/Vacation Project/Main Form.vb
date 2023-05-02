'the app will use 2x Sequential Access Files:
'1. "NeedToVisit.txt" = contains the names of 5 destinations that the user wants to visit
'2. "Visited.txt"  = contains the names of 3 destinations that the user already visited

'-1. create GUI, where:
'-  1.1. the File menu should have an Exit option
'-  1.2. "lstNeed" control's property: Sorted = True
'-  1.3. "lstVisited" control's properties: Sorted = True; SelectionMode = None

'-2. the "frmMain_Load" procedure should:
'-  2.1. use the "NeedToVisit.txt" file to fill the "lstNeed" control
'-  2.2. select the 1st item in the "lstNeed" control
'-  2.3. use the "Visited.txt" file to fill the "lstVisited" control

'-3. the "btnMove" control should move the selected item from the "lstNeed" to the "lstVisited"

'-4. if at least 1 change was made to the list boxes, the "frmMain_FormClosing" procedure should: 
'- use a MessageBox to ask the user whether wants to save the changes
'- -> if the user clicks the "Yes" button, the procedure should save the items in both list boxes to appropriate files before the form closes
'that's all

Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain

    Private intCount As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 2. the "frmMain_Load" procedure should:
        '   2.1. use the "NeedToVisit.txt" file to fill the "lstNeed" control
        '   2.2. select the 1st item in the "lstNeed" control
        '   2.3. use the "Visited.txt" file to fill the "lstVisited" control

        Dim inNeed As IO.StreamReader
        Dim inVisited As IO.StreamReader

        If IO.File.Exists("NeedToVisit.txt") AndAlso IO.File.Exists("Visited.txt") Then
            inNeed = IO.File.OpenText("NeedToVisit.txt")
            inVisited = IO.File.OpenText("Visited.txt")

            Do Until inNeed.Peek = -1
                lstNeed.Items.Add(inNeed.ReadLine)
            Loop

            If lstNeed.Items.Count > 0 Then
                lstNeed.SelectedIndex = 0
            Else
                btnMove.Enabled = False
            End If

            Do Until inVisited.Peek = -1
                lstVisited.Items.Add(inVisited.ReadLine)
            Loop

            ' count the input number items:
            intCount = lstNeed.Items.Count
            'MessageBox.Show(intCount.ToString)

            inNeed.Close()
            inVisited.Close()

        Else
            MessageBox.Show("Can't locate the files.", "Vacations Destinations", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        ' 3. the "btnMove" control should move the selected item from the "lstNeed" to the "lstVisited"

        ' add:
        If lstNeed.Items.Count > 0 Then
            lstVisited.Items.Add(lstNeed.SelectedItem)
        Else
            btnMove.Enabled = False
        End If
        ' remove:
        lstNeed.Items.Remove(lstNeed.SelectedItem)

        ' always select the 1st item in the (lstNeed):
        If lstNeed.Items.Count > 0 Then
            lstNeed.SelectedIndex = 0
        Else
            ' if there are no items:
            btnMove.Enabled = False
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' 4. if at least 1 change was made to the list boxes, the "frmMain_FormClosing" procedure should: 
        '  use a MessageBox to ask the user whether wants to save the changes
        '  -> if the user clicks the "Yes" button, the procedure should save the items in both list boxes to appropriate files before the form closes

        If lstNeed.Items.Count <> intCount Then
            'MessageBox.Show("changed")

            Dim dlgButton As DialogResult
            dlgButton = MessageBox.Show("Save the changes?", "Vacation Destinations", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
            If dlgButton = DialogResult.Yes Then

                ' #1 step:
                Dim outNeed As IO.StreamWriter       ' (lstNeed), "NeedToVisit.txt"
                Dim outVisited As IO.StreamWriter    ' (lstVisited), "Visited.txt"

                ' #2 step:
                outNeed = IO.File.CreateText("NeedToVisit.txt")
                outVisited = IO.File.CreateText("Visited.txt")

                ' #3 step:

                For intNeed As Integer = 0 To lstNeed.Items.Count - 1
                    outNeed.WriteLine(lstNeed.Items(intNeed))
                Next intNeed

                For intVisited As Integer = 0 To lstVisited.Items.Count - 1
                    outVisited.WriteLine(lstVisited.Items(intVisited))
                Next intVisited

                ' #4 step:
                outNeed.Close()
                outVisited.Close()

            ElseIf dlgButton = DialogResult.Cancel Then
                e.Cancel = True
            End If

            'Else
            'MessageBox.Show("no change")
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

End Class