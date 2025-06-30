Public Class Pedido
    Public Property ID As Integer
    Public Property FechaPedido As String
    Public Property Cliente As String
    Public Property Subtotal As Decimal
    Public Property IVA As Decimal
    Public Property Total As Decimal
    Public Property Estado As String

    Public Sub New()
        FechaPedido = DateTime.Now
        'Detalles = New List(Of DetallePedido)
        Estado = "Pendiente"
    End Sub

    Public Sub New(id As Integer, cliente As String)
        Me.New()
        Me.ID = id
        Me.Cliente = cliente
    End Sub

End Class
