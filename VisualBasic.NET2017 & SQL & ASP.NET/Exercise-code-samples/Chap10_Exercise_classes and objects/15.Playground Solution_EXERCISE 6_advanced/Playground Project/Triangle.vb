' Name:         Triangle.vb.
' Programmer:   PoaKamaNdizi on time stamp.

'_2. create a Class named "Triangle", where the class should:
'_2.1. verify that the base and height dimensions are greater than 0, before assigning the values to the Private variables
'_      (although the dimensions come from list boxes in this application, the Triangle class might subsequently be used in
'_        an application whose dimensions come from text boxes - therefore, it is a good idea to verify the user's input)
'_2.2. include a default constructor
'_2.3. include a parameterized constructor
'_2.4. include a method to calculate and return the area of a triangle
Option Explicit On
Option Strict On
Option Infer Off

Public Class Triangle
    Private dblBase As Double
    Private dblHeight As Double

    Public Property Base As Double
        Get
            Return dblBase
        End Get
        Set(value As Double)
            If value > 0 Then
                dblBase = value
            Else
                dblBase = 0
            End If
        End Set
    End Property

    Public Property Height As Double
        Get
            Return dblHeight
        End Get
        Set(value As Double)
            If value > 0 Then
                dblHeight = value
            Else
                dblHeight = 0
            End If
        End Set
    End Property

    Public Sub New()
        ' default Constructor:
        dblBase = 0
        dblHeight = 0
    End Sub

    Public Sub New(ByVal dblB As Double, ByVal dblH As Double)
        ' parameterized Constructor:
        Base = dblB
        Height = dblH
    End Sub

    Public Function GetTriangleArea() As Double
        ' method/function to calculate and return the area of a triangle
        Return (dblBase / 2) * dblHeight
    End Function
End Class