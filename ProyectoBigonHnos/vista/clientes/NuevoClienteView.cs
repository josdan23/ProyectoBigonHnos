using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista
{
     partial class NuevoClienteView : Form
    {
        public GestionarClientesControlador controlador ;

        public NuevoClienteView( GestionarClientesControlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = tboxDni.Text;
            string nombre = tboxNombre.Text;
            string apellido = tboxApellido.Text;

            string calle = tboxCalle.Text;
            int numero = int.Parse( tboxNumero.Text.ToString());
            string localidad = tboxLocalidad.Text;
            string provincia = tboxProvincia.Text;

            string telefono = tboxTelefono.Text;

            controlador.nuevoCliente(nombre, apellido, dni);
            controlador.agregarDomicilio(calle, numero, localidad, provincia);
            controlador.agregarTelefono(telefono);
            controlador.confirmarNuevoCliente();

            Dispose();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxLocalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
