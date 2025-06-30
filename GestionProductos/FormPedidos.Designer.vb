<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRemoverProducto = New System.Windows.Forms.Button()
        Me.dgvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnConfirmarPedido = New System.Windows.Forms.Button()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Pedido"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(640, 37)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(265, 22)
        Me.dtpFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(560, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(107, 37)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(399, 22)
        Me.txtCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregarProducto)
        Me.GroupBox2.Controls.Add(Me.nudCantidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dgvProductos)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 123)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(507, 369)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos Disponibles"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(240, 289)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(160, 31)
        Me.btnAgregarProducto.TabIndex = 3
        Me.btnAgregarProducto.Text = "Agregar al Pedido"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(107, 293)
        Me.nudCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(107, 22)
        Me.nudCantidad.TabIndex = 2
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 295)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cantidad:"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(20, 31)
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(467, 246)
        Me.dgvProductos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRemoverProducto)
        Me.GroupBox3.Controls.Add(Me.dgvDetallePedido)
        Me.GroupBox3.Location = New System.Drawing.Point(544, 123)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(507, 369)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle del Pedido"
        '
        'btnRemoverProducto
        '
        Me.btnRemoverProducto.Location = New System.Drawing.Point(327, 326)
        Me.btnRemoverProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemoverProducto.Name = "btnRemoverProducto"
        Me.btnRemoverProducto.Size = New System.Drawing.Size(160, 31)
        Me.btnRemoverProducto.TabIndex = 1
        Me.btnRemoverProducto.Text = "Remover Producto"
        Me.btnRemoverProducto.UseVisualStyleBackColor = True
        '
        'dgvDetallePedido
        '
        Me.dgvDetallePedido.AllowUserToAddRows = False
        Me.dgvDetallePedido.AllowUserToDeleteRows = False
        Me.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePedido.Location = New System.Drawing.Point(20, 31)
        Me.dgvDetallePedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDetallePedido.MultiSelect = False
        Me.dgvDetallePedido.Name = "dgvDetallePedido"
        Me.dgvDetallePedido.ReadOnly = True
        Me.dgvDetallePedido.RowHeadersWidth = 51
        Me.dgvDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetallePedido.Size = New System.Drawing.Size(467, 283)
        Me.dgvDetallePedido.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblIVA)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 517)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(507, 148)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(160, 111)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 25)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "$0.00"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.Location = New System.Drawing.Point(160, 74)
        Me.lblIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(54, 20)
        Me.lblIVA.TabIndex = 3
        Me.lblIVA.Text = "$0.00"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(160, 37)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(54, 20)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.Text = "$0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 111)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "IVA (16%):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Subtotal:"
        '
        'btnConfirmarPedido
        '
        Me.btnConfirmarPedido.BackColor = System.Drawing.Color.Green
        Me.btnConfirmarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarPedido.ForeColor = System.Drawing.Color.White
        Me.btnConfirmarPedido.Location = New System.Drawing.Point(544, 529)
        Me.btnConfirmarPedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirmarPedido.Name = "btnConfirmarPedido"
        Me.btnConfirmarPedido.Size = New System.Drawing.Size(160, 49)
        Me.btnConfirmarPedido.TabIndex = 4
        Me.btnConfirmarPedido.Text = "Confirmar Pedido"
        Me.btnConfirmarPedido.UseVisualStyleBackColor = False
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.Location = New System.Drawing.Point(725, 529)
        Me.btnNuevoPedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(160, 49)
        Me.btnNuevoPedido.TabIndex = 5
        Me.btnNuevoPedido.Text = "Nuevo Pedido"
        Me.btnNuevoPedido.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(907, 529)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(160, 49)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 677)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Controls.Add(Me.btnConfirmarPedido)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FormPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRemoverProducto As Button
    Friend WithEvents dgvDetallePedido As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnConfirmarPedido As Button
    Friend WithEvents btnNuevoPedido As Button
    Friend WithEvents btnCancelar As Button
End Class