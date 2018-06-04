using System;
using System.Windows.Forms;
using ProyectoBigonHnos.vista.pedidos;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista
{
    partial class PedidosView : UserControl
    {

        PedidoControlador controlador;

        public PedidosView()
        {
            InitializeComponent();
            controlador = new PedidoControlador();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedidoView vista = new NuevoPedidoView();
            vista.unirControlador(controlador);
            controlador.crearNuevoPedido();
            vista.ShowDialog();
        }
    }
}
