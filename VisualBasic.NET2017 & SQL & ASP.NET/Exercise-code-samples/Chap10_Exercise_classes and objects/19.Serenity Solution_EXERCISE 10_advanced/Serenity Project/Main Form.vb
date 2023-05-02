' Name:       Serenity project
' Purpose:    Record the payments
' Programmer: PoaKamaNdizi on TimeStamp
'_1. create GUI shown in Figure 10-44
'_2. The manager of the Accounts Payable department at Serenity Photos wants an app, that
'_  keeps track of the checks written by her department: she wants to record
'_   - in sequential access file: the check number, date, payee, amount of each check.
'_3. class.vb
'_  - create a class that can instantiate a "check" object. The Class should contain:
'_  - a default constructor, a parameterized constructor
'_  - a method that saves the check information to a sequential access file
'_  - use the Class to code the application. Test
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim MyCheck As Check
        Dim intNumber As Integer
        Dim strDate As String = txt2Date.Text.Trim
        Dim dblAmount As Double
        Dim strName As String = txt4Name.Text.Trim

        Integer.TryParse(txt1Number.Text.Trim, intNumber)
        Double.TryParse(txt3Amount.Text.Trim, dblAmount)

        ' invoke a parameterized constructor and flush him input data:
        MyCheck = New Check(intNumber, strDate, dblAmount, strName)

        MyCheck.Save()   ' call "Check" Class's function named "Save"
        lblSaved.Visible = MyCheck.ShowLabel   ' call "Check" Class's function named "ShowLabel" and assign its return value
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txt1Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1Number.KeyPress
        ' input: Check number - only numbers, BackSpace key:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt2Date_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2Date.KeyPress
        ' input: date - only numbers, "/", BackSpace key:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "/" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt3Amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3Amount.KeyPress
        ' input: Amount - only numbers, ".", BackSpace key:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txts_TextChanged(sender As Object, e As EventArgs) Handles txt1Number.TextChanged, txt2Date.TextChanged,
                                                                           txt3Amount.TextChanged, txt4Name.TextChanged
        lblSaved.Visible = False
    End Sub

    Private Sub txt1Number_Enter(sender As Object, e As EventArgs) Handles txt1Number.Enter
        txt1Number.SelectAll()
    End Sub

    Private Sub txt2Date_Enter(sender As Object, e As EventArgs) Handles txt2Date.Enter
        txt2Date.SelectAll()
    End Sub

    Private Sub txt3Amount_Enter(sender As Object, e As EventArgs) Handles txt3Amount.Enter
        txt3Amount.SelectAll()
    End Sub

    Private Sub txt4Name_Enter(sender As Object, e As EventArgs) Handles txt4Name.Enter
        txt4Name.SelectAll()
    End Sub
End Class