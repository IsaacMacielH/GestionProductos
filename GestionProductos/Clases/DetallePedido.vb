Public Class DetallePedido
    Public Property ID As Integer
    Public Property PedidoID As Integer
    Public Property ProductoID As Integer
    Public Property NombreProducto As String
    Public Property PrecioUnitario As Decimal
    Public Property Cantidad As Integer
    Public Property Subtotal As Decimal
    Public Property IVA As Decimal
    Public Property Total As Decimal


    Public Const PORCENTAJE_IVA As Decimal = 0.16

    Public Sub New()

    End Sub

    Public Sub New(productoID As Integer, nombreProducto As String, precioUnitario As Decimal, cantidad As Integer)
        Me.ProductoID = productoID
        Me.NombreProducto = nombreProducto
        Me.PrecioUnitario = precioUnitario
        Me.Cantidad = cantidad
        CalcularSubtotal()
        CalcularIVA()
        CalcularTotal()
    End Sub

    Public Sub CalcularSubtotal()
        Subtotal = PrecioUnitario * Cantidad
    End Sub

    Public Sub CalcularIVA()
        IVA = Subtotal * PORCENTAJE_IVA
    End Sub

    Public Sub CalcularTotal()
        Total = Subtotal + IVA
    End Sub
End Class
