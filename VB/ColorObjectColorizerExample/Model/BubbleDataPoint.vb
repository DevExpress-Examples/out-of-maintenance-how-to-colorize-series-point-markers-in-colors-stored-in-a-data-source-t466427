Namespace ColorObjectColorizerExample.Model

    Friend Class BubbleDataPoint

        Private _XArgument As String, _YArgument As String, _Value As Double, _Weight As Double, _Color As UInteger

        Public Property XArgument As String
            Get
                Return _XArgument
            End Get

            Private Set(ByVal value As String)
                _XArgument = value
            End Set
        End Property

        Public Property YArgument As String
            Get
                Return _YArgument
            End Get

            Private Set(ByVal value As String)
                _YArgument = value
            End Set
        End Property

        Public Property Value As Double
            Get
                Return _Value
            End Get

            Private Set(ByVal value As Double)
                _Value = value
            End Set
        End Property

        Public Property Weight As Double
            Get
                Return _Weight
            End Get

            Private Set(ByVal value As Double)
                _Weight = value
            End Set
        End Property

        Public Property Color As UInteger
            Get
                Return _Color
            End Get

            Private Set(ByVal value As UInteger)
                _Color = value
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
