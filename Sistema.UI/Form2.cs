
using Sistema.Entities.Productos;
using Sistema.Entities.Ventas;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Sistema.Entities.Clientes;
using Sistema.BLL.Factories;
using System.Runtime.CompilerServices;



namespace Sistema.UI
{
    public partial class Form2 : Form
    {
        private List<CartItem> carrito = new List<CartItem>();
        private List<Producto> productosAll = new List<Producto>();
        private Button btnVerVentas = null!;
   

        public Form2()
        {
            InitializeComponent();

            

            this.Load += Ventas_Load;

            listProductos!.KeyDown += ListProductos_KeyDown;
            listProductos.CellDoubleClick += ListProductos_CellDoubleClick;
            // Configurar DataGridView como carrito
            ConfigurarDataGridCarrito();
            dataGridView1!.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            btnRealizarVenta!.Click += BtnRealizarVenta_Click;



            // Añadimos al panel principal (si existe)
            if (panelMain != null)
                panelMain.Controls.Add(btnVerVentas);
        }

        // =========================
        // LOAD
        // =========================
        private void Ventas_Load(object? sender, EventArgs e)
        {
            ConfigurarPlaceholder();
            CargarProductos();
            CargarClientes();
        }

        // =========================
        // PLACEHOLDER
        // =========================
        private void ConfigurarPlaceholder()
        {
            txtBuscar!.Text = "Añadir Producto";
            txtBuscar.ForeColor = Color.Gray;

            txtBuscar.Enter += (s, e) =>
            {
                if (txtBuscar.Text == "Añadir Producto")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = Color.Black;
                }
            };

            txtBuscar.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Añadir Producto";
                    txtBuscar.ForeColor = Color.Gray;
                }
            };
        }

        // =========================
        // DATOS INICIALES
        // =========================
        private void CargarProductos()
        {
            try
            {
                // Cargar productos activos desde la base de datos a través del InventarioService
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    productosAll = service.ObtenerProductosActivos();
                }

                if (productosAll.Count == 0)
                {
                    MessageBox.Show("No hay productos activos en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productosAll = new List<Producto>();
            }

            RefrescarListaProductos(productosAll);
        }

        private void CargarClientes()
        {
            try
            {
                using (var service = ServiceFactory.CrearClienteService())
                {
                    var clientesActivos = service.ObtenerClientesActivos();

                    cmbCliente.DataSource = clientesActivos;
                    cmbCliente.DisplayMember = "Nombre";
                    cmbCliente.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                

                if (cmbCliente.Items.Count > 0)
                {
                    MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }



        // =========================
        // AGREGAR PRODUCTO
        // =========================


        private void ListProductos_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AñadirProductoSeleccionadoDesdeLista();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AñadirProductoSeleccionadoDesdeLista()
        {
            if (listProductos!.SelectedRows.Count > 0)
            {
                var row = listProductos.SelectedRows[0];
                var prod = row.Tag as Producto;
                if (prod != null)
                {
                    AgregarProductoAlCarrito(prod);
                }
            }
        }

        // =========================
        // REFRESCAR UI
        // =========================
        private void RefrescarCarrito(int? preserveIndex = null)
        {
            // Usamos dataGridView1 como representación del carrito
            int? current = preserveIndex;

            if (!current.HasValue && dataGridView1!.CurrentCell != null)
                current = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.Clear();

            for (int i = 0; i < carrito.Count; i++)
            {
                var item = carrito[i];
                var nombre = item.Producto?.Nombre ?? "(sin nombre)";
                var precioUnitario = $"Q{item.Producto.PrecioVenta:0.00}";
                var cantidad = item.Cantidad.ToString();
                var subtotal = $"Q{item.Subtotal:0.00}";

                // Añadimos en el orden de columnas: Producto, Precio Unitario, Cantidad, Subtotal
                int rowIndex = dataGridView1.Rows.Add(nombre, precioUnitario, cantidad, subtotal);
                dataGridView1.Rows[rowIndex].Tag = item;
            }

            // El total se calcula a partir del modelo
            lblTotal!.Text = $"Total: Q{CalcularTotal():0.00}";

            if (current.HasValue && current.Value >= 0 && current.Value < dataGridView1.Rows.Count)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[current.Value].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[current.Value].Cells[0];
            }
        }

        // =========================
        // CALCULAR TOTAL (desde el modelo 'carrito')
        // =========================
        private decimal CalcularTotal()
        {
            return carrito.Sum(x => x.Subtotal);
        }

        // =========================
        // MANEJADOR: fin de edición de celda (edición directa de 'Cantidad')
        // =========================
        private void DataGridView1_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var col = dataGridView1.Columns[e.ColumnIndex];
            if (col.Name != "Cantidad") return;

            var row = dataGridView1.Rows[e.RowIndex];
            var item = row.Tag as CartItem;
            if (item == null) return;

            var cell = row.Cells[e.ColumnIndex];
            var raw = cell?.Value?.ToString();
            if (string.IsNullOrWhiteSpace(raw))
            {
                // restaurar
                BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                return;
            }

            if (int.TryParse(raw, out int newQty))
            {
                if (newQty <= 0)
                {
                    carrito.Remove(item);
                    int? preserve = carrito.Count == 0 ? (int?)null : Math.Min(e.RowIndex, carrito.Count - 1);
                    BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
                }
                else
                {
                    item.Cantidad = newQty;
                    BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                }
            }
            else
            {
                // valor inválido, restaurar
                BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
            }
        }

        // =========================
        // REALIZAR VENTA
        // =========================
        private void BtnRealizarVenta_Click(object? sender, EventArgs e)
        {
            
        }

        // =========================
        // BLL SIMULADO
        // =========================



        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            var term = txtBuscar.Text?.Trim() ?? string.Empty;

            // Ignorar placeholder
            if (string.IsNullOrWhiteSpace(term) || term == "Añadir Producto")
            {
                RefrescarListaProductos(productosAll);
                return;
            }

            var filtered = productosAll
                .Where(p => p.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            RefrescarListaProductos(filtered);
        }


        private void btnRealizarVenta_Click_1(object? sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones básicas
                if (carrito.Count == 0) { MessageBox.Show("Agrega productos"); return; }
                if (cmbCliente.SelectedValue == null) { MessageBox.Show("Selecciona cliente"); return; }

                // 2. Captura de datos (CORREGIDO: Sin duplicar idcliente)
                int idcliente = Convert.ToInt32(cmbCliente.SelectedValue);
                TipoPago tipoPago = rbCredito.Checked ? TipoPago.Credito : TipoPago.Contado;

                // 3. Datos para el crédito
                DateTime fechaVence = DateTime.Now;
                decimal abonoInicial = 0;

                if (tipoPago == TipoPago.Credito)
                {
                    using (var frmManto = new frmMantenomientoCredito())
                    {
                        if (frmManto.ShowDialog() != DialogResult.OK) return;
                        fechaVence = frmManto.FechaVencimiento;
                        abonoInicial = frmManto.AbonoInicial;
                    }
                }

                // 4. Procesar con los servicios
                using (var _ventaService = ServiceFactory.CrearVentaService())
                {
                    // Mapeamos el carrito a la entidad
                    var detalles = carrito.Select(ci => new DetalleVenta
                    {
                        ProductoId = ci.Producto.Id,
                        Cantidad = ci.Cantidad,
                        PrecioUnitario = ci.PrecioUnitario
                    }).ToList();

                    // REGISTRO DE VENTA: Usamos el ID 1 que acabamos de crear en la BD
                    _ventaService.RegistrarVenta(idcliente, 1, detalles, tipoPago);

                    // 5. Lógica de Crédito (Si aplica)
                    if (tipoPago == TipoPago.Credito)
                    {
                        var ventaReciente = _ventaService.ListarVentas()
                            .OrderByDescending(v => v.Id)
                            .First(v => v.ClienteId == idcliente);

                        using (var _creditoService = ServiceFactory.CrearCreditoService())
                        {
                            _creditoService.CrearCredito(ventaReciente.Id, fechaVence);

                            if (abonoInicial > 0)
                            {
                                var credito = _creditoService.ListarCreditos()
                                    .First(c => c.VentaId == ventaReciente.Id);
                                _creditoService.RegistrarAbono(credito.Id, abonoInicial);
                            }
                        }
                    }
                }

                MessageBox.Show("✅ Venta realizada con éxito");
                carrito.Clear();
                RefrescarCarrito();

            }
            catch (Exception ex)
            {
                // El InnerException te dirá si algo más falla en la BD
                MessageBox.Show($"Error: {ex.Message} \nDetalle: {ex.InnerException?.Message}");
            }

        }




        private void Form2_Load(object? sender, EventArgs e)
        {

        }





        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1!.Rows[e.RowIndex];
            var item = row.Tag as CartItem;
            if (item == null) return;
            var col = dataGridView1.Columns[e.ColumnIndex];
            if (col.Name == "Dec")
            {
                if (item.Cantidad > 1) item.Cantidad--;
                else carrito.Remove(item);
                int? preserve = carrito.Count == 0 ? (int?)null : Math.Min(e.RowIndex, carrito.Count - 1);
                BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
            }
            else if (col.Name == "Inc")
            {
                item.Cantidad++;
                int? preserve = e.RowIndex;
                BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
            }
            else if (col.Name == "Del")
            {
                carrito.Remove(item);
                int? preserve = carrito.Count == 0 ? (int?)null : Math.Min(e.RowIndex, carrito.Count - 1);
                BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
            }
        }

        private void panelPago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigurarDataGridCarrito()
        {
            dataGridView1!.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = false;

            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Subtotal", "Subtotal");

            var btnDec = new DataGridViewButtonColumn { Name = "Dec", HeaderText = "", Text = "-", UseColumnTextForButtonValue = true, Width = 30 };
            var btnInc = new DataGridViewButtonColumn { Name = "Inc", HeaderText = "", Text = "+", UseColumnTextForButtonValue = true, Width = 30 };
            var btnDel = new DataGridViewButtonColumn { Name = "Del", HeaderText = "", Text = "Eliminar", UseColumnTextForButtonValue = true, Width = 70 };
            dataGridView1.Columns.Add(btnDec);
            dataGridView1.Columns.Add(btnInc);
            dataGridView1.Columns.Add(btnDel);

            dataGridView1.Columns["Producto"].ReadOnly = true;
            dataGridView1.Columns["PrecioUnitario"].ReadOnly = true;
            dataGridView1.Columns["Subtotal"].ReadOnly = true;
            dataGridView1.Columns["Cantidad"].ReadOnly = false;

            // Configurar DataGridView de productos
            listProductos!.Rows.Clear();
            listProductos.Columns.Clear();
            listProductos.AllowUserToAddRows = false;
            listProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listProductos.MultiSelect = false;
            listProductos.ReadOnly = true;

            listProductos.Columns.Add("Nombre", "Nombre Producto");
            listProductos.Columns.Add("CantidadDisponible", "Cantidad Disponible");
            listProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            listProductos.Columns.Add("Descripcion", "Descripción");

            listProductos.Columns["Nombre"].Width = 150;
            listProductos.Columns["CantidadDisponible"].Width = 120;
            listProductos.Columns["PrecioUnitario"].Width = 120;
            listProductos.Columns["Descripcion"].Width = 200;
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            // No-op (puedes ampliar si necesitas sincronizar controles externos)
        }

        // Botón: abrir FormVerVentas dentro del mismo panel (desde Form2)
        private void BtnVerVentas_Click(object? sender, EventArgs e)
        {
            // Buscar el host Form1 en las ventanas abiertas y abrir FormVerVentas dentro del mismo panel
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (host != null)
            {
                host.AbrirFormEnPanel(new FormVerVentas());
                return;
            }

            // fallback: mostrar en ventana normal si no hay host (debe ser raro)
            var fv = new FormVerVentas();
            fv.Show();
        }

        // Added: handler expected by designer for `button1.Click`.
        private void button1_Click(object? sender, EventArgs e)
        {
            // Reuse the same logic as BtnVerVentas_Click
            BtnVerVentas_Click(sender, e);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmIngresarCliente ventanamodal = new frmIngresarCliente();

            ventanamodal.StartPosition = FormStartPosition.CenterScreen;
            ventanamodal.ShowDialog();
            ventanamodal.ResumeLayout();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        // panelCantidad and related controls removed. Quantity changes handled via grid Inc/Dec buttons.

        private void RefrescarListaProductos(List<Producto> productos)
        {
            listProductos!.Rows.Clear();
            foreach (var prod in productos)
            {
                int rowIndex = listProductos.Rows.Add(
                    prod.Nombre,
                    prod.Stock,
                    $"Q{prod.PrecioVenta:0.00}",
                    prod.Descripcion ?? ""
                );
                listProductos.Rows[rowIndex].Tag = prod;
            }
            if (productos.Count > 0 && listProductos.Rows.Count > 0)
            {
                listProductos.ClearSelection();
                listProductos.Rows[0].Selected = true;
            }
        }

        private void ListProductos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = listProductos!.Rows[e.RowIndex];
            var prod = row.Tag as Producto;
            if (prod != null)
            {
                AgregarProductoAlCarrito(prod);
            }
        }

        private void AgregarProductoAlCarrito(Producto prod)
        {
            var existente = carrito.FirstOrDefault(x => x.Producto.Id == prod.Id);

            if (existente != null)
            {
                existente.Cantidad++;
            }
            else
            {
                carrito.Add(new CartItem(prod, 1));
            }

            RefrescarCarrito(carrito.Count - 1);
        }
    }

    // =========================
    // MODELOS
    // =========================
    // Local lightweight cart item that adapts to Sistema.Entities types
    internal class CartItem
    {
        public Producto Producto { get; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario => Producto.PrecioVenta;
        public decimal Subtotal => PrecioUnitario * Cantidad;

        public CartItem(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }
}