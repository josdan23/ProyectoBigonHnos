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
            int numero = int.Parse( tboxNumero.Text);
            string localidad = tboxLocalidad.Text;
            string provincia = tboxProvincia.Text;

            string telefono = tboxTelefono.Text;

            controlador.nuevoCliente(nombre, apellido, dni);
            controlador.agregarDireccion(calle, numero, localidad, provincia);
            controlador.agregarTelefono(telefono);
            controlador.confirmarNuevoCliente();

            Dispose();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
