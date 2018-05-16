using System;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista.proveedor
{
    partial class EditarProveedorVista : Form, IProveedorView
    {
        private GestionarProveedorControlador controlador;
        private int idProveedorSeleccionado;

        public GestionarProveedorControlador Controlador { get => controlador; set => controlador = value; }
        public int IdProveedorSeleccionado { get => idProveedorSeleccionado; set => idProveedorSeleccionado = value; }

        public EditarProveedorVista(int idProveedorSeleccionado)
        {
            InitializeComponent();
            Controlador = new GestionarProveedorControlador(this);
            IdProveedorSeleccionado = idProveedorSeleccionado;
            controlador.obtenerDetalleDeProveedor(idProveedorSeleccionado);

        }

        public void mostrarInformacionDeProveedor()
        {
            
            
        }

        public void mostrarRazonSocial(String razonSocial)
        {
            tboxRazonSocial.Text = razonSocial;
        }

        public void mostrarCuit(String cuit)
        {
            tboxCuit.Text = cuit;
        }

        public void mostrarTelefono(string telefono)
        {
            tboxTelefono.Text = telefono;
        }

        public void mostrarCalle(string calle)
        {
            tboxCalle.Text = calle;
        }

        public void mostrarLocalidad(string localidad)
        {
            tboxLocalidad.Text = localidad;
        }

        public void mostrarProvincia (string provincia)
        {
            tboxProvincia.Text = provincia;
        }

        public void mostrarIdProveedor(int id)
        {
            //throw new NotImplementedException();
        }

        public void mostrarNumero(int numero)
        {
            tboxNumero.Text = numero.ToString();
        }

        public void listarProveedores(string razonSocial)
        {
            throw new NotImplementedException();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string razonSocial = tboxRazonSocial.Text;
            string cuit = tboxCuit.Text;
            string telefono = tboxTelefono.Text;
            string calle = tboxCalle.Text;
            int numero = int.Parse(tboxNumero.Text);
            string localidad = tboxLocalidad.Text;
            string provincia = tboxProvincia.Text;

            controlador.buscarProveedor(idProveedorSeleccionado);
            controlador.editarRazonSocial(razonSocial);
            controlador.editarCuit(cuit);
            controlador.editarTelefono(telefono);
            controlador.editarDireccion(calle, numero, localidad, provincia);
            controlador.guadarProveedorActualizado(idProveedorSeleccionado);
            
            Dispose();
        }

       
    }
}
