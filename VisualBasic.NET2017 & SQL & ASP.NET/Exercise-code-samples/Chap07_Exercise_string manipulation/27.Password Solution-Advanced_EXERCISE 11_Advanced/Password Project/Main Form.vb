'Modification:
'->before inserting the number, the btnCreate_Click procedure should alternate the case of each letter in the password
'   if the 1st char is lowercase, the procedue should change it to uppercase, it should then change the 2nd letter to lowercase...
'     e.g. if the password is "abcd", the procedure should change it to "AbCd"
'   on the other hand - if the 1st char is uppercase, the procedure should change it to lowercase and then
'                        alternate the Case Of the following letters
'     e.g. if the password is "Abcd" the procedure should change it to "aBcD"
'->test: "May the Force be with you" => "m6TfBwY"
'        "may the Force be with you" => "M6tFbWy"

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Create a password.

        Dim strWords As String
        Dim strPassword As String = String.Empty
        Dim intSpaceIndex As Integer
        Dim strTest As String = String.Empty
        Dim strNewPassword As String = String.Empty
        Dim strEven As String = String.Empty
        Dim strOdd As String = String.Empty

        strWords = txtWords.Text.Trim

        If strWords <> String.Empty Then

            strPassword = strWords(0)               ' Assign the first character as the password:
            intSpaceIndex = strWords.IndexOf(" ")    ' Search for the first space in the input

            Do Until intSpaceIndex = -1
                ' Concatenate the character that follows the space to the password:
                strPassword = strPassword & strWords(intSpaceIndex + 1)

                intSpaceIndex = strWords.IndexOf(" ", intSpaceIndex + 1)    ' Search for the next space
            Loop

            ' MODIFICATION: alternate each letter in the password:
            For intIndex As Integer = 0 To strPassword.Length - 1
                strTest = strTest & intIndex.ToString

                If strPassword(0) Like "[A-Z]" Then             'if the 1st(0) char is UPPERCASE
                    If intIndex Mod 2 = 0 Then
                        strEven = strPassword(intIndex)
                        strEven = strEven.ToLower
                        strNewPassword += strEven
                    ElseIf intIndex Mod 2 = 1 Then
                        strOdd = strPassword(intIndex)
                        strOdd = strOdd.ToUpper
                        strNewPassword += strOdd
                    End If

                ElseIf strPassword(0) Like "[a-z]" Then         'if the 1st(0) char is lowercase
                    If intIndex Mod 2 = 0 Then
                        strEven = strPassword(intIndex)
                        strEven = strEven.ToUpper
                        strNewPassword += strEven
                    ElseIf intIndex Mod 2 = 1 Then
                        strOdd = strPassword(intIndex)
                        strOdd = strOdd.ToLower
                        strNewPassword += strOdd
                    End If
                End If
                '0 Mod2 = 0; 1 Mod 2 = 1
            Next intIndex

            strPassword = strNewPassword

            ' Insert the number after the first character: 
            strPassword = strPassword.Insert(1, strPassword.Length.ToString)

            ' Display the final password:
            lblPassword.Text = strPassword
        End If
    End Sub

    Private Sub txtWords_Enter(sender As Object, e As EventArgs) Handles txtWords.Enter
        txtWords.SelectAll()
    End Sub

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        lblPassword.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class