Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ColorObjectColorizerExample.Model
    Friend Class BubbleDataPoint
        Private privateXArgument As String
        Public Property XArgument() As String
            Get
                Return privateXArgument
            End Get
            Private Set(ByVal value As String)
                privateXArgument = value
            End Set
        End Property
        Private privateYArgument As String
        Public Property YArgument() As String
            Get
                Return privateYArgument
            End Get
            Private Set(ByVal value As String)
                privateYArgument = value
            End Set
        End Property
        Private privateValue As Double
        Public Property Value() As Double
            Get
                Return privateValue
            End Get
            Private Set(ByVal value As Double)
                privateValue = value
            End Set
        End Property
        Private privateWeight As Double
        Public Property Weight() As Double
            Get
                Return privateWeight
            End Get
            Private Set(ByVal value As Double)
                privateWeight = value
            End Set
        End Property
        Private privateColor As UInteger
        Public Property Color() As UInteger
            Get
                Return privateColor
            End Get
            Private Set(ByVal value As UInteger)
                privateColor = value
            End Set
        End Property

        Public Sub New(ByVal xArgument As String, ByVal yArgument As String, ByVal value As Double, ByVal weight As Double, ByVal color As UInteger)
            Me.XArgument = xArgument
            Me.YArgument = yArgument
            Me.Value = value
            Me.Weight = weight
            Me.Color = color
        End Sub
    End Class
End Namespace
