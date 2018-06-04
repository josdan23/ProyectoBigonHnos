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
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProductoView vista = new NuevoProductoView();
            vista.unirControlador(controlador);
            vista.ShowDialog();
        }

        private void btnNuevoComponente_Click(object sender, EventArgs e)
        {
            NuevoComponenteView vista = new NuevoComponenteView();
            vista.ShowDialog();
        }

        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            Console.WriteLine("estoy en vista de nuevo pedido");
        }

        public void mostrarDescripcion(string descripcion)
        {
            
        }
    }
}
