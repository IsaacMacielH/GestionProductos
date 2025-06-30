Public Class Producto
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property PrecioUnitario As Decimal
    Public Property Stock As Integer

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, descripcion As String, precio As Decimal, stock As Integer)
        Me.ID = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.PrecioUnitario = precio
        Me.Stock = stock
    End Sub

    Public Function EsValido() As Boolean
        Return Not String.IsNullOrWhiteSpace(Nombre) AndAlso
            Not String.IsNullOrWhiteSpace(Descripcion) AndAlso PrecioUnitario >= 0 AndAlso Stock >= 0
    End Function

    Public Function ObtenerErrores() As List(Of String)
        Dim errores As New List(Of String)

        If String.IsNullOrWhiteSpace(Nombre) Then
            errores.Add("El nombre del producto es requerido")
        End If
        If String.IsNullOrWhiteSpace(Descripcion) Then
            errores.Add("La descripcion del producto es requerida")
        End If
        If PrecioUnitario < 0 Then
            errores.Add("El precio no puede ser negativo")
        End If
        If Stock < 0 Then
            errores.Add("El stock no puede ser menor que 0")
        End If

        Return errores
    End Function
End Class
