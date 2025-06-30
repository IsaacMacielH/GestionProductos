Imports System.ComponentModel
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Form1
    Private productos As New BindingList(Of Producto)
    Private siguienteID As Integer = 1
    Private ProductoSeleccionado As Producto = Nothing
    Private Property rate As Decimal
    Private Property count As Integer
    Private Shared ReadOnly httpClient As New HttpClient()
    Private Const BASE_URL As String = "https://fakestoreapi.com"

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarDataGridView()
        LimpiarCampos()
        'AgregarProductoEjemplo()
        Await CargarProductosAPI()
    End Sub

    Private Sub ConfigurarDataGridView()
        dgvProductos.DataSource = productos
        dgvProductos.AutoGenerateColumns = True
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.ReadOnly = True
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.MultiSelect = False

        If dgvProductos.Columns.Count > 0 Then
            dgvProductos.Columns("ID").Width = 50
            dgvProductos.Columns("PrecioUnitario").DefaultCellStyle.Format = "C2"
        End If
    End Sub

    Private Async Function CargarProductosAPI() As Task
        Dim url As String = "https://fakestoreapi.com/products"
        Using client As New WebClient()
            Try
                Dim jsonString As String = Await client.DownloadStringTaskAsync(url)
                Dim jsonArray As JArray = JArray.Parse(jsonString)

                For Each item As JObject In jsonArray
                    Dim productoN As New Producto With {
                        .ID = CInt(item("id")),
                        .Nombre = item("title").ToString(),
                        .Descripcion = item("description"),
                        .PrecioUnitario = CDec(item("price")),
                        .Stock = CInt(10)
                    }
                    productos.Add(productoN)
                Next
            Catch ex As Exception
                MessageBox.Show("Error al consumir la API: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub AgregarProductoEjemplo()
        ' Agregar algunos productos de ejemplo para probar
        productos.Add(New Producto(1, "Laptop HP", "Laptop HP 15 pulgadas", 15000D, 10))
        productos.Add(New Producto(2, "Mouse Logitech", "Mouse USB", 350.5D, 25))
        siguienteID = 3
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarCampos() Then
            Try
                Dim nuevoProducto As New Producto()
                nuevoProducto.ID = siguienteID
                nuevoProducto.Nombre = txtNombre.Text.Trim()
                nuevoProducto.Descripcion = txtDescripcion.Text.Trim()
                nuevoProducto.PrecioUnitario = Convert.ToDecimal(txtPrecio.Text)
                nuevoProducto.Stock = Convert.ToInt64(txtStock.Text)

                If nuevoProducto.EsValido() Then
                    productos.Add(nuevoProducto)
                    siguienteID += 1
                    LimpiarCampos()
                    MessageBox.Show("Producto registrado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim errores = nuevoProducto.ObtenerErrores()
                    MessageBox.Show("Errores de validación: " & vbCrLf & String.Join(vbCrLf, errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al agregar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Clck(Sender As Object, e As EventArgs) Handles btnModificar.Click
        If ProductoSeleccionado IsNot Nothing Then
            If ValidarCampos() Then
                Try
                    ProductoSeleccionado.Nombre = txtNombre.Text.Trim()
                    ProductoSeleccionado.Descripcion = txtDescripcion.Text.Trim()
                    ProductoSeleccionado.PrecioUnitario = txtPrecio.Text.Trim()
                    ProductoSeleccionado.Stock = txtStock.Text.Trim()

                    If ProductoSeleccionado.EsValido() Then
                        dgvProductos.Refresh()
                        LimpiarCampos()
                        MessageBox.Show("¡Producto Modificado Exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim errores = ProductoSeleccionado.ObtenerErrores()
                        MessageBox.Show("Errores obtenidos: " & vbCrLf & String.Join(vbCrLf, errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al modificar el producto" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ProductoSeleccionado IsNot Nothing Then
            Dim resultado = MessageBox.Show($"¿Está seguro de eliminar el producto '{ProductoSeleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                productos.Remove(ProductoSeleccionado)
                LimpiarCampos()
                MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvProductos_Seleccion(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        If dgvProductos.SelectedRows.Count > 0 Then
            ProductoSeleccionado = CType(dgvProductos.SelectedRows(0).DataBoundItem, Producto)
            CargarProducto(ProductoSeleccionado)
        End If
    End Sub

    Private Sub CargarProducto(producto As Producto)
        txtID.Text = producto.ID.ToString()
        txtNombre.Text = producto.Nombre
        txtDescripcion.Text = producto.Descripcion
        txtPrecio.Text = producto.PrecioUnitario.ToString()
        txtStock.Text = producto.Stock.ToString()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub


    Private Function ValidarCampos() As Boolean
        Dim errores As New List(Of String)

        ' Validar datos
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            errores.Add("El nombre es requerido")
        End If

        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            errores.Add("La descripción es requerida")
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecio.Text, precio) Then
            errores.Add("El precio debe ser un número válido")
        ElseIf precio < 0 Then
            errores.Add("El precio no puede ser negativo")
        End If

        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text, stock) Then
            errores.Add("El stock debe ser un número entero válido")
        ElseIf stock < 0 Then
            errores.Add("El stock no puede ser menor que 0")
        End If

        ' Mostrar si hay errores
        If errores.Count > 0 Then
            MessageBox.Show("Corrija los siguientes errores:" & vbCrLf & String.Join(vbCrLf, errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub LimpiarCampos()
        txtID.Text = siguienteID.ToString()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        ProductoSeleccionado = Nothing

        ' Deseleccionar en el DataGridView
        dgvProductos.ClearSelection()
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim formularioPedido As New FormPedidos(productos)

        Me.Hide()
        formularioPedido.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click

    End Sub
End Class