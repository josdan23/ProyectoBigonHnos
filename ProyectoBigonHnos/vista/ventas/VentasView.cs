using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.ventas;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista
{
    partial class VentasView : UserControl, IVentaView
    {
        private Empleado EmpleadoLogueado { get; set; }
        public VentaControlador Controlador { get; set; }

        public VentasView()
        {
            InitializeComponent();
            UnirControlador(new VentaControlador());
            ActualizarVista();
        }

        public VentasView(Empleado empleado)
        {
            if (empleado == null)
                Console.WriteLine("empleado nulo");
            EmpleadoLogueado = empleado;
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
            Console.WriteLine("ventas vie");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void listarVenta(int idVenta, string apellidoCliente, DateTime fechaVenta, double total)
        {
            dgvVentas.Rows.Add(idVenta, apellidoCliente, fechaVenta.ToShortDateString(), total);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(dgvVentas.CurrentRow.Cells[0].Value.ToString());

            Controlador.eliminarVenta(idVenta);
            ActualizarVista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVentaView vista = new NuevaVentaView(EmpleadoLogueado);
            if (EmpleadoLogueado == null)
                Console.WriteLine("empleado nuleo2");
            vista.UnirControlador(Controlador);
            Controlador.iniciarVenta();
            Controlador.agregarEmpleado(EmpleadoLogueado);
            vista.ShowDialog();

            UnirControlador(Controlador);
            ActualizarVista();
        }

        public void limpiar()
        {
            dgvVentas.Rows.Clear();
        }

        private void seleccionarFial(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void imprimirBtn_Click(object sender, EventArgs e)
        {
            Controlador.imprimirFactura();
        }
    }
}
