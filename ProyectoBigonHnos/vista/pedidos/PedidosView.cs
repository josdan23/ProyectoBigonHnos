using System;
using System.Windows.Forms;
using ProyectoBigonHnos.vista.pedidos;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista
{
    partial class PedidosView : UserControl, IPedidoView
    {
    
        public PedidoControlador Controlador { get; set; }

        public PedidosView()
        {
            InitializeComponent();
            unirControlador(new PedidoControlador());
            ActualizarVista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedidoView vista = new NuevoPedidoView();
            vista.unirControlador(Controlador);
            Controlador.crearNuevoPedido();
            vista.ShowDialog();
            Controlador.unirVista(this);
            ActualizarVista();
        }

        public void listarPedido(string nroPedido, string cliente, DateTime fecha)
        {
            dgvPedidos.Rows.Add(nroPedido, cliente, fecha);
        }

        public void unirControlador(PedidoControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
        }

        public void ActualizarVista()
        {
            limpiarTabla();
            Controlador.mostrarPedidos();
        }

        private void limpiarTabla()
        {
            dgvPedidos.Rows.Clear();
        }
    }
}
