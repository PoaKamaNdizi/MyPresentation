' Name:       Dues.vb
' Programmer: PoaKamaNdizi on JustNow
'_3. class.vb: - use the class to code the application
'_  - create a Class named "Dues", that:
'_  - contains 2 auto-implemented properties for: Basic charges and Additional charges
'_  - default constructor, parameterized constructor
'_  - method that calculates and returns the total monthly dues
Option Explicit On
Option Strict On
Option Infer Off

Public Class Dues
    Private intBasic As Integer
    Private intAdditional As Integer

    Public Property BasicCharges As Integer
        Get
            Return intBasic
        End Get
        Set(value As Integer)
            If value > 0 Then
                intBasic = value
            Else
                intBasic = 0
            End If
        End Set
    End Property

    Public Property AdditionalCharges As Integer
        Get
            Return intAdditional
        End Get
        Set(value As Integer)
            If value > 0 Then
                intAdditional = value
            Else
                intAdditional = 0
            End If
        End Set
    End Property

    Public Sub New()
        intBasic = 0 : intAdditional = 0
    End Sub

    Public Sub New(ByVal intB As Integer, ByVal intA As Integer)
        'intB = BasicCharges : intA = AdditionalCharges   ' this won't work
        BasicCharges = intB : AdditionalCharges = intA    ' this is working
    End Sub

    Public Function GetTotal() As Integer
        Return intBasic + intAdditional
    End Function
End Class