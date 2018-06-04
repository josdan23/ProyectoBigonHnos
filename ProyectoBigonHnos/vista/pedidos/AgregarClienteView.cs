using ProyectoBigonHnos.dominio;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
    partial class AgregarClienteView : Form, IPedidoView
    {
        public PedidoControlador controlador;

        public AgregarClienteView()
        {
            InitializeComponent();
        }

        public void mostrarNombre(string nombre)
        {
            lblNombre.Text = nombre;
        }

        public void mostrarApellido(string apellido)
        {
            lblApellido.Text = apellido;
        }

        public void mostrarDni(string dni)
        {
            lblDni.Text = dni;
        }

        public void mostrarNumero(int numero)
        {
            lblNumero.Text = numero.ToString();
        }

        public void mostrarCalle(string calle)
        {
            lblCalle.Text = calle;
        }

        public void mostrarProvincia(String provincia)
        {
            lblProvincia.Text = provincia;
        }

        public void mostrarLocalidad(String localidad)
        {
            lblLocalidad.Text = localidad;
        }

        public void mostrarTelefono (string telefono)
        {
            lblTelefono.Text = telefono;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = tbBuscarDni.Text;
            controlador.buscarCliente(dni);

        }

        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            Console.WriteLine("estoy en vista de agregarCliente");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dniClienteDePedido = lblDni.Text;
            controlador.agregarCliente(dniClienteDePedido);
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
