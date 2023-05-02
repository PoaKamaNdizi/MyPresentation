' Name:         ParkingLot.vb
' Programmer:   PoaKamaNdizi on Time Stamp.
Option Explicit On
Option Strict On
Option Infer Off

Public Class ParkingLot
    Private dblBase As Double
    Private dblHeight As Double
    Private dblCost As Double

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

    Public Property Cost As Double
        Get
            Return dblCost
        End Get
        Set(value As Double)
            If value > 0 Then
                dblCost = value
            Else
                dblCost = 0
            End If
        End Set
    End Property

    Public Sub New()
        ' default constructor
        dblBase = 0 : dblHeight = 0 : dblCost = 0
    End Sub

    Public Sub New(ByVal dblB As Double, ByVal dblH As Double, ByVal dblC As Double)
        ' parameterized constructor
        Base = dblB : Height = dblH : Cost = dblC
    End Sub

    Public Function GetArea() As Double
        ' area in square feet
        Return dblBase * dblHeight
    End Function

    Public Function GetCost() As Double
        ' calculate price in square yards (1 square yard = 9 square feet)
        Return (GetArea() / 9) * dblCost
    End Function
End Class