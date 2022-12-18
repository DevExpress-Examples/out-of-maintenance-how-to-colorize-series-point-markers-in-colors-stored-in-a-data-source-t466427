Imports ColorObjectColorizerExample.Model
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace ColorObjectColorizerExample.ViewModel

    Friend Class BubblesViewModel

        Private _DataPoints As IEnumerable(Of ColorObjectColorizerExample.Model.BubbleDataPoint)

        Public Property DataPoints As IEnumerable(Of BubbleDataPoint)
            Get
                Return _DataPoints
            End Get

            Private Set(ByVal value As IEnumerable(Of BubbleDataPoint))
                _DataPoints = value
            End Set
        End Property

        Public Sub New()
            DataPoints = New Collection(Of BubbleDataPoint)() From {New BubbleDataPoint(xArgument:="A", yArgument:="B", value:=10.0R, weight:=2.0R, color:=&HFF5B9BD5UI), New BubbleDataPoint(xArgument:="B", yArgument:="C", value:=3.0R, weight:=3.0R, color:=&HFFED7D31UI), New BubbleDataPoint(xArgument:="C", yArgument:="E", value:=8.0R, weight:=4.0R, color:=&HFFED7D31UI), New BubbleDataPoint(xArgument:="D", yArgument:="D", value:=7.0R, weight:=1.0R, color:=&HFFA5A5A5UI), New BubbleDataPoint(xArgument:="E", yArgument:="A", value:=5.0R, weight:=2.0R, color:=&HFF5B9BD5UI)}
        End Sub
    End Class
End Namespace
