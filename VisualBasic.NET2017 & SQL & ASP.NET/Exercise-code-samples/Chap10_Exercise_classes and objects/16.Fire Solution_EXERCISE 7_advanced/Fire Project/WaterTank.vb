' Name:         WaterTank.vb
' Programmer:   PoaKamaNdizi on Time Stamp.
Option Explicit On
Option Strict On
Option Infer Off

Public Class WaterTank
    Private dbl1Length As Double
    Private dbl2Width As Double
    Private dbl3Height As Double

    Public Property Length As Double
        Get
            Return dbl1Length
        End Get
        Set(value As Double)
            If value > 0 Then
                dbl1Length = value
            Else
                dbl1Length = 0
            End If
        End Set
    End Property

    Public Property Width As Double
        Get
            Return dbl2Width
        End Get
        Set(value As Double)
            If value > 0 Then
                dbl2Width = value
            Else
                dbl2Width = 0
            End If
        End Set
    End Property

    Public Property Height As Double
        Get
            Return dbl3Height
        End Get
        Set(value As Double)
            If value > 0 Then
                dbl3Height = value
            Else
                dbl3Height = 0
            End If
        End Set
    End Property

    Public Sub New()
        ' default constructor:
        dbl1Length = 0 : dbl2Width = 0 : dbl3Height = 0
    End Sub

    Public Sub New(ByVal dblL As Double, ByVal dblW As Double, ByVal dblH As Double)
        ' parameterized constructor:
        Length = dblL : Width = dblW : Height = dblH
    End Sub

    Public Function GetCapacity() As Double
        ' function to calculate in Cubic feet:
        Return dbl1Length * dbl2Width * dbl3Height
    End Function

    Public Function GetVolume() As Double
        ' function to calculate in Gallons:
        ' (1 cubic foot = 7.48 gallons)
        Return GetCapacity() * 7.48
    End Function
End Class