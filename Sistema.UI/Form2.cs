using System.ComponentModel;
using System.Globalization;

namespace Sistema.UI
{
    public partial class Form2 : Form1
    {
        private List<DetalleVenta> carrito = new List<DetalleVenta>();
        private List<Producto> productosAll = new List<Producto>();

        public Form2()
        {
            InitializeComponent();
            this.Load += Ventas_Load;
            listProductos!.DoubleClick += ListProductos_DoubleClick;
            listProductos!.KeyDown += ListProductos_KeyDown;
            // Configurar DataGridView como carrito
            ConfigurarDataGridCarrito();
            dataGridView1!.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            btnRealizarVenta!.Click += BtnRealizarVenta_Click;
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
            productosAll = new List<Producto>
            {
                new Producto(1, "Block", 500),
                new Producto(2, "Cemento", 50),
                new Producto(3, "Pintura", 120),
                new Producto(4, "Arena", 30)
            };

            listProductos.DataSource = new BindingList<Producto>(productosAll);
            listProductos.DisplayMember = "Nombre";
        }

        private void CargarClientes()
        {
            cmbCliente!.Items.Clear();
            cmbCliente.Items.Add("Cliente General");
            cmbCliente.Items.Add("Empresa ABC");
            cmbCliente.Items.Add("Juan Pérez");
        }

        // =========================
        // AGREGAR PRODUCTO
        // =========================
        private void ListProductos_DoubleClick(object? sender, EventArgs e)
        {
            AñadirProductoSeleccionadoDesdeLista();
        }

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
            if (listProductos!.SelectedItem is Producto prod)
            {
                var existente = carrito.FirstOrDefault(x => x.Producto.Id == prod.Id);

                if (existente != null)
                {
                    existente.Cantidad++;
                }
                else
                {
                    carrito.Add(new DetalleVenta(prod, 1));
                }

                RefrescarCarrito(carrito.Count - 1);
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
                var precioUnitario = $"Q{item.Producto.Precio:0.00}";
                var cantidad = item.Cantidad.ToString();
                var subtotal = $"Q{item.Subtotal:0.00}";

                // Añadimos en el orden de columnas: Producto, Precio Unitario, Cantidad, Subtotal
                int rowIndex = dataGridView1.Rows.Add(nombre, precioUnitario, cantidad, subtotal);
                dataGridView1.Rows[rowIndex].Tag = item;
            }

            // El total se calcula a partir de la propia columna Subtotal del grid
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
            var item = row.Tag as DetalleVenta;
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
            if (carrito.Count == 0)
            {
                MessageBox.Show("Agrega productos primero");
                return;
            }

            if (cmbCliente!.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }

            string tipoPago = rbCredito!.Checked ? "Crédito" : "Físico";

            var venta = CrearVenta(1, 1, carrito);

            ProcesarPago(venta, tipoPago);
            RegistrarVenta(venta);

            MessageBox.Show("✅ Venta realizada correctamente");

            carrito.Clear();
            RefrescarCarrito();
        }

        // =========================
        // BLL SIMULADO
        // =========================
        private Venta CrearVenta(int clienteId, int usuarioId, List<DetalleVenta> detalles)
        {
            return new Venta(clienteId, usuarioId, detalles, CalcularTotal());
        }

        private void ProcesarPago(Venta venta, string tipoPago)
        {
            // Aquí luego conectas con tu BLL real
        }

        private void RegistrarVenta(Venta venta)
        {
            // Aquí luego conectas con DB
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            var term = txtBuscar.Text?.Trim() ?? string.Empty;

            // Ignorar placeholder
            if (string.IsNullOrWhiteSpace(term) || term == "Añadir Producto")
            {
                listProductos.DataSource = new BindingList<Producto>(productosAll);
                return;
            }

            var filtered = productosAll
                .Where(p => p.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            listProductos.DataSource = new BindingList<Producto>(filtered);
            listProductos.DisplayMember = "Nombre";

            if (filtered.Count > 0)
                listProductos.SelectedIndex = 0;
        }

        private void listCarrito_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // ya no usado
        }

        private void btnRealizarVenta_Click_1(object? sender, EventArgs e)
        {

        }

        private void btnHome_Click(object? sender, EventArgs e)
        {

        }

        private void Form2_Load(object? sender, EventArgs e)
        {

        }

        private void listProductos_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void panelCantidad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1!.Rows[e.RowIndex];
            var item = row.Tag as DetalleVenta;
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
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            // No-op (puedes ampliar si necesitas sincronizar controles externos)
        }

        // panelCantidad and related controls removed. Quantity changes handled via grid Inc/Dec buttons.
    }

    // =========================
    // MODELOS
    // =========================
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
    }

    public class DetalleVenta
    {
        public Producto Producto;
        public int Cantidad;

        public decimal Subtotal => Producto.Precio * Cantidad;

        public DetalleVenta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }

    public class Venta
    {
        public int ClienteId;
        public int UsuarioId;
        public List<DetalleVenta> Detalles;
        public decimal Total;

        public Venta(int clienteId, int usuarioId, List<DetalleVenta> detalles, decimal total)
        {
            ClienteId = clienteId;
            UsuarioId = usuarioId;
            Detalles = detalles;
            Total = total;
        }
    }
}