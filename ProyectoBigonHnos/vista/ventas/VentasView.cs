using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.ventas;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista
{
    partial class VentasView : UserControl, IVentaView
    {

        public VentaControlador Controlador { get; set; }

        public VentasView()
        {
            InitializeComponent();
            UnirControlador(new VentaControlador());
            ActualizarVista();
        }

        public void ActualizarVista()
        {
            limpiar();
            Controlador.MostrarVentas();
        }

        public void UnirControlador(VentaControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void listarVenta(int idVenta, string apellidoCliente, DateTime fechaVenta, double total)
        {
            dgvVentas.Rows.Add(idVenta, apellidoCliente, fechaVenta, total);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(dgvVentas.CurrentRow.Cells[0].Value.ToString());

            Controlador.eliminarVenta(idVenta);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVentaView vista = new NuevaVentaView();
            vista.UnirControlador(Controlador);
            vista.ShowDialog();

            UnirControlador(Controlador);
            ActualizarVista();
        }

        public void limpiar()
        {
            dgvVentas.Rows.Clear();
        }
    }
}
