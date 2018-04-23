Imports ColorObjectColorizerExample.Model
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ColorObjectColorizerExample.ViewModel
    Friend Class BubblesViewModel
        Private privateDataPoints As IEnumerable(Of BubbleDataPoint)
        Public Property DataPoints() As IEnumerable(Of BubbleDataPoint)
            Get
                Return privateDataPoints
            End Get
            Private Set(ByVal value As IEnumerable(Of BubbleDataPoint))
                privateDataPoints = value
            End Set
        End Property

        Public Sub New()
            DataPoints = New Collection(Of BubbleDataPoint)() From { _
                New BubbleDataPoint(xArgument:= "A", yArgument:= "B", value:= 10.0R, weight:= 2.0R, color:= &HFF5B9BD5UI), _
                New BubbleDataPoint(xArgument:= "B", yArgument:= "C", value:= 3.0R, weight:= 3.0R, color:= &HFFED7D31UI), _
                New BubbleDataPoint(xArgument:= "C", yArgument:= "E", value:= 8.0R, weight:= 4.0R, color:= &HFFED7D31UI), _
                New BubbleDataPoint(xArgument:= "D", yArgument:= "D", value:= 7.0R, weight:= 1.0R, color:= &HFFA5A5A5UI), _
                New BubbleDataPoint(xArgument:= "E", yArgument:= "A", value:= 5.0R, weight:= 2.0R, color:= &HFF5B9BD5UI) _
            }
        End Sub
    End Class
End Namespace
