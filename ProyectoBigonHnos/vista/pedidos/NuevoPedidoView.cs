using ProyectoBigonHnos.dominio;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
    partial class NuevoPedidoView : Form, IPedidoView
    {
        PedidoControlador controlador;

        public NuevoPedidoView()
        {
            InitializeComponent();
            lblFechaPedido.Text = $"{DateTime.Now}";
        }

        private void NuevoPedidoView_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteView vista = new AgregarClienteView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
            ActualizarVista();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProductoView vista = new NuevoProductoView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
            ActualizarVista();
        }

        private void btnNuevoComponente_Click(object sender, EventArgs e)
        {
            /*
            NuevoComponenteView vista = new NuevoComponenteView()
            vista.unirControlador(controlador);
            vista.ShowDialog();
            ActualizarVista();
            */
        }

        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            Console.WriteLine("estoy en vista de nuevo pedido");
        }


        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            controlador.agregarFechaDeEntrega(dateTimePicker1.Value.Date);
            controlador.confirmarPedido();
            Dispose();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void mostrarNombre(string nombre)
        {
            lblNombre.Text = nombre;
        }

        public void mostrarApellido(String apellido)
        {
            lblApellido.Text = apellido;
        }

        public void mostrarDni(string dni)
        {
            lblDni.Text = dni;
        }

        public void mostrarDomicilio(string calle, int numero, string provincia)
        {
            lblDomicilio.Text = $"{calle}, {numero} - {provincia}";
        }

        public void mostrarTelefono(string telefono)
        {
            lblTelefono.Text = telefono;
        }

        public void mostrarMail(string mail)
        {
            lblMail.Text = mail;
        }

        public void ActualizarVista()
        {

            dgvProductos.Rows.Clear();
            controlador.unirVista(this);
            controlador.mostrarCliente();
            controlador.mostrarProductos();
            //controlador.mostrarComponentes(0);
            controlador.mostrarTotal();
            dgvCostosExtras.Rows.Clear();
            controlador.mostrarCargosExtrasDelPedido();
            dgvMateriales.Rows.Clear();
            controlador.mostrarMaterialesDelPedido();
            mostrarSubtotalyTotal();
        }

        public void listarProducto(string descripcion, double alto, double ancho, double prof, string colorP, string colorS, int cant, double precio)
        {
            dgvProductos.Rows.Add(
                descripcion,
                alto,
                ancho,
                prof,
                colorP,
                colorS,
                cant,
                precio);
        }
        /*
        public void listarComponente(string descripcion, double alto, double ancho, double prof, string colorP, string colorS, int cant, string material, double precio)
        {
            dgvComponentes.Rows.Add(
                descripcion,
                alto,
                ancho, 
                prof,
                colorP,
                colorS,
                cant,
                material,
                precio);
        }
        */
        public void mostrarTotal(double total)
        {
            totalLabel.Text = total.ToString();
        }

        public void mostrarSubtotalMateriales(double subtotal)
        {
            subtotalMaterialLabel.Text = subtotal.ToString();
        }

        public void mostrarSubtotalCostosExtras(double subtotal)
        {
            subtotalCostosExtrasLabel.Text = subtotal.ToString();
        }

        private void btnAgregarCostoExtra_Click(object sender, EventArgs e)
        {
            AgregarCostosExtrasView vista = new AgregarCostosExtrasView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
            unirControlador(controlador);
            ActualizarVista();
        }

        public void mostrarCargosExtras(string descripcion, double monto)
        {
            dgvCostosExtras.Rows.Add(descripcion, monto);
        }

        private void btnNuevoMaterial_Click(object sender, EventArgs e)
        {
            AgregarMaterialesNecesariosView vista = new AgregarMaterialesNecesariosView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
            unirControlador(controlador);
            ActualizarVista();
        }

        public void mostrarMaterialesSeleccionados(string descripcionMaterial, double precio, int cantidad, double subtotal)
        {
            dgvMateriales.Rows.Add(descripcionMaterial, precio, cantidad, subtotal);
            
        }

        public void mostrarSubtotalyTotal()
        {
            subtotalCostosExtrasLabel.Text = controlador.mostrarSubtotalCargosExtras();
            subtotalMaterialLabel.Text = controlador.mostrarSubtotalMaterial();
            totalLabel.Text = controlador.mostrarTotal();
        }
    }
}
