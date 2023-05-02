' Name:       Check.vb
' Programmer: PoaKamaNdizi on TimeStamp
'_2. The manager of the Accounts Payable department at Serenity Photos wants an app, that
'_  keeps track of the checks written by her department: she wants to record
'_  - in sequential access file: the check number, date, payee, amount of each check.
'_3. class.vb
'_  - create a class that can instantiate a "check" object. The Class should contain:
'_  - a default constructor, a parameterized constructor
'_  - a method that saves the check information to a sequential access file
'_  - use the Class to code the application. Test
Option Explicit On
Option Strict On
Option Infer Off

Public Class Check
    Private intNumber As Integer  ' input: txt1Number
    Private strDate As String     ' input: txt2Date
    Private dblAmount As Double   ' input: txt3Amount
    Private strName As String     ' input: txt4Name
    Private outFile As IO.StreamWriter           ' CH9_F2
    Private blnIsTrue As Boolean  ' will b used to show a confirmation label: "lblSaved"

    Public Property CheckNumber As Integer
        Get
            Return intNumber
        End Get
        Set(value As Integer)
            If value > 0 Then
                intNumber = value
            Else
                intNumber = 0
            End If
        End Set
    End Property

    Public Property CheckDate As String
        Get
            Return strDate
        End Get
        Set(value As String)
            If value Like "##/##/####" Then
                strDate = value
            Else
                strDate = Nothing
            End If
        End Set
    End Property

    Public Property CheckAmount As Double
        Get
            Return dblAmount
        End Get
        Set(value As Double)
            If value > 0 Then
                dblAmount = value
            Else
                dblAmount = 0
            End If
        End Set
    End Property

    Public Property CheckName As String
        Get
            Return strName
        End Get
        Set(value As String)
            If value <> Nothing Then
                strName = value
            Else
                strName = Nothing
            End If
        End Set
    End Property

    Public Sub New()
        ' default constructor:
        intNumber = 0 : strDate = Nothing : dblAmount = 0 : strName = Nothing
    End Sub

    Public Sub New(ByVal intN As Integer, ByVal strD As String, ByVal dblA As Double, ByVal strN As String)
        ' parameterized constructor:
        CheckNumber = intN : CheckDate = strD : CheckAmount = dblA : CheckName = strN
    End Sub

    Public Function Save() As IO.StreamWriter
        ' conditions:
        ' - txt1Number > 0; txt2Date must have a form: ##/##/####; txt3Amount > 0, txt4Name <> String.Empty

        If intNumber > 0 Then                     ' #1 condition: number > 0
            If strDate <> Nothing Then            ' #2 condition: date in correct format
                If dblAmount > 0 Then             ' #3 condition: amount > 0
                    If strName <> Nothing Then    ' #4 condition: Name is filled
                        ' if all of the conditions are met:
                        outFile = IO.File.AppendText("Checks.txt")
                        outFile.WriteLine("Check number: " & intNumber.ToString & ", Date: " & strDate &
                                          ", Payee: " & strName & ", Amount: " & dblAmount.ToString("C2"))
                        outFile.Close()
                    Else
                        MessageBox.Show("Please enter the name.", "Serenity Photos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Please enter the amount.", "Serenity Photos", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please enter the date in correct format.", "Serenity Photos", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter the check number.", "Serenity Photos", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

        Return outFile
    End Function

    Public Function ShowLabel() As Boolean
        ' function for showing the confirmaton label:
        If intNumber <> 0 AndAlso strDate <> Nothing AndAlso dblAmount <> 0 AndAlso strName <> Nothing Then
            blnIsTrue = True
        End If
        Return blnIsTrue
    End Function
End Class