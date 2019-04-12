using System;
using System.Windows.Forms;
using ProyectoBigonHnos.vista.pedidos;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista
{
    partial class PedidosView : UserControl, IPedidoView
    {
        public IPedidoController Controlador { get; set; }

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
            ((PedidoControlador)Controlador).crearNuevoPedido();
            vista.ShowDialog();
            ((PedidoControlador)Controlador).unirVista(this);
            ActualizarVista();
        }

        public void listarPedido(string nroPedido, string cliente, DateTime fecha, double total)
        {
            dgvPedidos.Rows.Add(nroPedido, cliente, fecha.ToShortDateString(), total);
        }

        public void unirControlador(IPedidoController controlador)
        {
            Controlador = controlador;
            ((PedidoControlador)Controlador).unirVista(this);
        }

        public void ActualizarVista()
        {
            limpiarTabla();
            ((PedidoControlador)Controlador).mostrarPedidos();
        }

        private void limpiarTabla()
        {
            dgvPedidos.Rows.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPedidoSeleccionado = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());

            Console.WriteLine(idPedidoSeleccionado);
            ((PedidoControlador)Controlador).eliminarPedido(idPedidoSeleccionado);
            ActualizarVista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idPedido = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());

            EditarPedidoView vista = new EditarPedidoView();
            IPedidoController controlador = new EditarPedidoControlador();
            vista.unirControlador(controlador);
            ((EditarPedidoControlador)controlador).recuperarPedido(idPedido);

            vista.ShowDialog();
            
        }
    }
}
