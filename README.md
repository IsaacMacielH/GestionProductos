# GestionProductos
## 📌 Funcionalidades implementadas

✅ Gestión de Productos

Alta, baja y modificación de productos.

Validaciones: campos obligatorios, precios y stock ≥ 0.

Visualización en DataGridView.

✅ Gestión de Pedidos

Selección de productos para crear pedidos.

Cálculo automático de Subtotal, IVA (16%) y Total.

Descuento automático de stock por producto.

✅ Módulo 3 – Consumo de API Externa

Consumo de https://fakestoreapi.com/products con HttpClient.

Visualización de productos (nombre, descripción, precio e imagen).

## 📦 Estructura
/GearionProductos
├── Forms/
│   ├── FormPedidos.vb
│   ├── Form1.vb
├── Clases/
│   ├── Producto.vb
│   ├── Pedido.vb
│   └── DetallePedido.vb
|
└── README.md


## 🚀 Instrucciones para ejecutar

Entorno: Visual Studio 2022

1. Clonar o descargar el repositorio.


2. Restaurar los paquetes NuGet (Newtonsoft.Json).


3. Compilar y ejecutar el proyecto desde FrmMain.vb.