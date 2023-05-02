'ORIGINAL: 09. EXERCISE 2
' Name:         Workers Project
' Purpose:      Saves worker names to a sequential access files.
' Programmer:   <your name> on <current date>
'_user will: - enter a name in the (txtName) control &
'            - click the button (btnAdd) which should add the name to the (lstWorkers) control
'_when finished entering names:
' - the frmMain_FormClosing procedure should write the contents Of the (lstWorkers) to a new sequential access file: "workers.txt"
'_test by entering 2 names: "Henry Kaplan" and "Mario Brown", stop the app and verify the contents of the "workers.txt"
' <- it should countain 2 names
'_start the app again and:
'  _test by entering 3 names: "Jose Juarez", "Maya Harris", "Savannah Carlisle", stop the app and verify
' <- it should contain only 3 names

'MODIFICATION: 15. EXERCISE 8
'-1: add to the form above the existing controls and reset the Tab order:
'-  1.1: a label: Text = &Filename:
'-  1.2: a text box: (name) = txtFilename

'-2: code the: "txtFilename_KeyPress" procedure to accept only numbers, uppercase & lowercase letters & the Backspace key

' modify the "frmMain_FormClosing" procedure using those rules:
'-3: If the user doesn't provide a filename in the (txtFilename) control, the procedure should use a "MessageBox" to:
'-    - display message: "Please provide a filename.", button = OK, icon = Information
'-    - then prevent the form from being closed

'-4: The procedure should append the ".txt" extension to the filename
'- 4.1: Then determine whether the file exists:
'-    4.1.1: If the file doesn't exist, the procedure should write the ListBox information to the file
'-            -> use an Independent Sub procedure to write the information to the file
'-    4.1.2: If the file exists, the procedure should use a "MessageBox" to:
'-            - display message: "Replace existing file before exiting?", button = OKNoCancel, icon = Exclamation
'-       - if CANCEL: the procedure should prevent the form from being closed
'-       - if YES: the procedure should replace the file before the form is closed
'-            -> use an Independent Sub procedure to write the information to the file - the same like in 4.1.1
'-       - if NO: the procedure should close the form without saving the information
'thats all

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strFilename As String
    Private outFile As IO.StreamWriter

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If txtFilename.Text = Nothing Then
            MessageBox.Show("Please provide a filename.", "Restaurant workers", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        Else
            strFilename = txtFilename.Text & ".txt"

            If IO.File.Exists(strFilename) Then
                'MessageBox.Show("exists")
                Dim dlgButton As DialogResult
                dlgButton = MessageBox.Show("Replace existing file before exiting?", "Restaurant workers", MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Exclamation)
                Select Case True
                    Case dlgButton = DialogResult.Yes
                        WriteToFile()
                    Case dlgButton = DialogResult.No
                        e.Cancel = False
                    Case dlgButton = DialogResult.Cancel
                        e.Cancel = True
                End Select

            Else
                WriteToFile()
            End If
        End If
    End Sub

    Private Sub WriteToFile()
        outFile = IO.File.CreateText(strFilename)
        For intCounter As Integer = 0 To lstWorkers.Items.Count - 1
            outFile.WriteLine(lstWorkers.Items(intCounter))
        Next intCounter
        outFile.Close()
    End Sub

    Private Sub txtFilename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilename.KeyPress
        ' 2: code the: "txtFilename_KeyPress" procedure to accept only numbers, uppercase & lowercase letters & the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso
        (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "A" OrElse e.KeyChar > "Z") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstWorkers.Items.Add(txtName.Text)
        txtName.Focus()
        txtName.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

End Class