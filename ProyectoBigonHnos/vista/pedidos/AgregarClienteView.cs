using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
    partial class AgregarClienteView : Form, IPedidoView
    {
        public IPedidoController controller;
        
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
            if (controller is PedidoControlador)
                ((PedidoControlador)controller).buscarCliente(dni);
            else
                ((EditarPedidoControlador)controller).buscarCliente(dni);

        }

        public void unirControlador(IPedidoController controlador)
        {
            controller = controlador;
            if (controlador is PedidoControlador)
                ((PedidoControlador)controller).unirVista(this);
            else
                ((EditarPedidoControlador)controller).unirVista(this);
            Console.WriteLine("estoy en vista de agregarCliente");
        }

   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dniClienteDePedido = lblDni.Text;
            if (controller is PedidoControlador)
                ((PedidoControlador)controller).agregarCliente(dniClienteDePedido);
            else
                ((EditarPedidoControlador)controller).actualizarCliente(dniClienteDePedido);
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void ActualizarVista()
        {
            Console.WriteLine("vista de agregar cliente");
        }
    }
}
