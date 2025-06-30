<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.labelL1 = New System.Windows.Forms.Label()
        Me.labelL2 = New System.Windows.Forms.Label()
        Me.labelL3 = New System.Windows.Forms.Label()
        Me.labelL4 = New System.Windows.Forms.Label()
        Me.labelL5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(350, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Producto"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(120, 185)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(200, 22)
        Me.txtStock.TabIndex = 5
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(120, 148)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(200, 22)
        Me.txtPrecio.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 74)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 22)
        Me.txtNombre.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(120, 37)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 22)
        Me.txtID.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 111)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'labelL1
        '
        Me.labelL1.AutoSize = True
        Me.labelL1.Location = New System.Drawing.Point(120, 153)
        Me.labelL1.Name = "labelL1"
        Me.labelL1.Size = New System.Drawing.Size(23, 16)
        Me.labelL1.TabIndex = 5
        Me.labelL1.Text = "ID:"
        '
        'labelL2
        '
        Me.labelL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelL2.Location = New System.Drawing.Point(20, 123)
        Me.labelL2.Name = "labelL2"
        Me.labelL2.Size = New System.Drawing.Size(80, 13)
        Me.labelL2.TabIndex = 6
        Me.labelL2.Text = "Nombre:"
        '
        'labelL3
        '
        Me.labelL3.Location = New System.Drawing.Point(20, 93)
        Me.labelL3.Name = "labelL3"
        Me.labelL3.Size = New System.Drawing.Size(66, 13)
        Me.labelL3.TabIndex = 7
        Me.labelL3.Text = "Descripcion:"
        '
        'labelL4
        '
        Me.labelL4.Location = New System.Drawing.Point(20, 63)
        Me.labelL4.Name = "labelL4"
        Me.labelL4.Size = New System.Drawing.Size(47, 13)
        Me.labelL4.TabIndex = 8
        Me.labelL4.Text = "Precio Unitario:"
        '
        'labelL5
        '
        Me.labelL5.Location = New System.Drawing.Point(20, 33)
        Me.labelL5.Name = "labelL5"
        Me.labelL5.Size = New System.Drawing.Size(21, 13)
        Me.labelL5.TabIndex = 9
        Me.labelL5.Text = "Stock:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPedidos)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 29)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 246)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(12, 283)
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(568, 308)
        Me.dgvProductos.TabIndex = 2
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(22, 164)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 37)
        Me.btnLimpiar.TabIndex = 0
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(22, 16)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(160, 37)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(22, 65)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(160, 37)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(22, 115)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 37)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.btnPedidos.Location = New System.Drawing.Point(22, 209)
        Me.btnPedidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(160, 37)
        Me.btnPedidos.TabIndex = 4
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 604)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Gestion de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents labelL1 As Label
    Friend WithEvents labelL2 As Label
    Friend WithEvents labelL3 As Label
    Friend WithEvents labelL4 As Label
    Friend WithEvents labelL5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnPedidos As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
End Class
