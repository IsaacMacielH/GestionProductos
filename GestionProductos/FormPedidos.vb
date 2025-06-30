Imports System.ComponentModel

Public Class FormPedidos
    Private pedidoActual As Pedido
    Private productos As BindingList(Of Producto)
    Private detallePedido As BindingList(Of DetallePedido)
    Private siguienteIDPedido As Integer = 1

    Public Sub New(productosDisponibles As BindingList(Of Producto))
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        productos = productosDisponibles
        detallePedido = New BindingList(Of DetallePedido)
    End Sub

    Private Sub FormPedidos_Cargar(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
        NuevoPedido()
    End Sub

    Private Sub ConfigurarControles()
        dgvProductos.DataSource = productos
        dgvProductos.AutoGenerateColumns = True
        dgvProductos.ReadOnly = True
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.MultiSelect = False

        dgvDetallePedido.DataSource = detallePedido
        dgvDetallePedido.AutoGenerateColumns = True
        dgvDetallePedido.ReadOnly = True
        dgvDetallePedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetallePedido.MultiSelect = False

        dtpFecha.Value = DateTime.Now
        dtpFecha.Enabled = False

        nudCantidad.Minimum = 1
        nudCantidad.Maximum = 1000
        nudCantidad.Value = 1
    End Sub

    Private Sub NuevoPedido()
        pedidoActual = New Pedido(siguienteIDPedido, "")
        siguienteIDPedido += 1

        txtCliente.Clear()
        dtpFecha.Value = DateTime.Now
        nudCantidad.Value = 1

        detallePedido.Clear()
        ActualizarTotales()
        txtCliente.Focus()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If dgvProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un producto para agregar al pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim productoSeleccionado As Producto = CType(dgvProductos.SelectedRows(0).DataBoundItem, Producto)
        Dim cantidad As Integer = CInt(nudCantidad.Value)

        If productoSeleccionado.Stock < cantidad Then
            MessageBox.Show($"Stock insuficiente. Disponible: {productoSeleccionado.Stock}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim detalleExiste = detallePedido.FirstOrDefault(Function(d) d.ProductoID = productoSeleccionado.ID)

        If detalleExiste IsNot Nothing Then
            If productoSeleccionado.Stock < (detalleExiste.Cantidad + cantidad) Then
                MessageBox.Show($"Stock insuficiente. Disponible: {productoSeleccionado.Stock}, Ya en pedido: {detalleExiste.Cantidad}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            detalleExiste.Cantidad += cantidad
            detalleExiste.CalcularSubtotal()
            detalleExiste.CalcularIVA()
            detalleExiste.CalcularTotal()
            dgvDetallePedido.Refresh()
            productoSeleccionado.Stock -= cantidad

        Else
            Dim nuevoDetalle As New DetallePedido()
            nuevoDetalle.ProductoID = productoSeleccionado.ID
            nuevoDetalle.NombreProducto = productoSeleccionado.Nombre
            nuevoDetalle.PrecioUnitario = productoSeleccionado.PrecioUnitario
            nuevoDetalle.Cantidad = cantidad
            nuevoDetalle.CalcularSubtotal()
            nuevoDetalle.CalcularIVA()
            nuevoDetalle.CalcularTotal()

            detallePedido.Add(nuevoDetalle)
        End If

        ActualizarTotales()
        nudCantidad.Value = 1

        MessageBox.Show("Producto agregado al pedido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvProductos.Refresh()
    End Sub

    Private Sub ActualizarTotales()
        If pedidoActual IsNot Nothing Then
            pedidoActual.Subtotal = detallePedido.Sum(Function(d) d.Subtotal)
            pedidoActual.IVA = detallePedido.Sum(Function(d) d.IVA)
            pedidoActual.Total = detallePedido.Sum(Function(d) d.Total)

            If Me.lblTotal IsNot Nothing Then
                Me.lblTotal.Text = $"{pedidoActual.Total:F2}"
                Me.lblSubtotal.Text = $"{pedidoActual.Subtotal:F2}"
                Me.lblIVA.Text = $"{pedidoActual.IVA:F2}"
            End If
        End If
    End Sub

    Private Sub btnremoverProducto_Click(sender As Object, e As EventArgs) Handles btnRemoverProducto.Click
        If dgvDetallePedido.SelectedRows.Count < 0 Then
            MessageBox.Show("Seleccione un producto para remover del pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim detalleSeleccionado As DetallePedido = CType(dgvDetallePedido.SelectedRows(0).DataBoundItem, DetallePedido)
        detallePedido.Remove(detalleSeleccionado)
        ActualizarTotales()
        MessageBox.Show("Producto removido del pedido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnConfirmarPedido_Click(sender As Object, e As EventArgs) Handles btnConfirmarPedido.Click
        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            MessageBox.Show("Debe ingresar el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCliente.Focus()
            Return
        End If

        If detallePedido.Count = 0 Then
            MessageBox.Show("Debe agregar productos al pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        pedidoActual.Cliente = txtCliente.Text.Trim()
        pedidoActual.FechaPedido = dtpFecha.Value
        pedidoActual.Total = detallePedido.Sum(Function(d) d.Subtotal)

        MessageBox.Show($"Pedido #{pedidoActual.ID} guardado exitosamente para {pedidoActual.Cliente}.", "Pedido guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvProductos.Refresh()
    End Sub

    Private Sub btnNuevoPedido_Click(sender As Object, e As EventArgs) Handles btnNuevoPedido.Click
        NuevoPedido()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim formulario1 As New Form1()
        Me.Close()
        formulario1.Show()
    End Sub


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class