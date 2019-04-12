using ProyectoBigonHnos.controladores;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
    partial class EditarPedidoView : Form, IPedidoView
    {
        IPedidoController controlador;

        public EditarPedidoView()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteView vista = new AgregarClienteView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
            unirControlador(controlador);
            ((EditarPedidoControlador)controlador).mostrarPedido();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProductoView vista = new NuevoProductoView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
            unirControlador(controlador);
            ((EditarPedidoControlador)controlador).mostrarPedido();
        }


        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            ((EditarPedidoControlador)controlador).actualizarFechaEntrega(fechaEntregaPicker.Value.Date);
            ((EditarPedidoControlador)controlador).regitrarPedidoActualizado();
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
            ((EditarPedidoControlador)controlador).mostrarPedido();

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
            ((EditarPedidoControlador)controlador).mostrarPedido();
        }

        public void mostrarMaterialesSeleccionados(string descripcionMaterial, double precio, int cantidad, double subtotal)
        {
            dgvMateriales.Rows.Add(descripcionMaterial, precio, cantidad, subtotal);
            
        }

        public void unirControlador(IPedidoController controlador)
        {
            this.controlador = controlador;
            ((EditarPedidoControlador)controlador).unirVista(this);
            Console.WriteLine("estoy en vista de EDITAR PEDIDO");
        }

        public void ActualizarVista()
        {
            dgvProductos.Rows.Clear();
            dgvMateriales.Rows.Clear();
            dgvCostosExtras.Rows.Clear();

        }

        public void mostrarFechaDePedido(DateTime fechaDePedido)
        {
            lblFechaPedido.Text = fechaDePedido.ToShortDateString();
        }

        public void mostrarFechaEntrega(DateTime fechaDeEntrega)
        {
            fechaEntregaPicker.Text = fechaDeEntrega.ToShortDateString();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            int index = dgvProductos.CurrentRow.Index;
            ((EditarPedidoControlador)controlador).eliminarProducto(index);
            ((EditarPedidoControlador)controlador).mostrarPedido();
        }

        private void borrarMaterialBtn_Click(object sender, EventArgs e)
        {
            int index = dgvMateriales.CurrentRow.Index;
            ((EditarPedidoControlador)controlador).eliminarMaterial(index);
            ((EditarPedidoControlador)controlador).mostrarPedido();
        }

        private void borrarCostoExtraBtn_Click(object sender, EventArgs e)
        {
            int index = dgvCostosExtras.CurrentRow.Index;
            ((EditarPedidoControlador)controlador).eliminarCostosExtras(index);
            ((EditarPedidoControlador)controlador).mostrarPedido();
        }
    }
}
