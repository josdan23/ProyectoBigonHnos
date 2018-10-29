using ProyectoBigonHnos.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.proveedor
{
    partial class NuevoProveedorView : Form
    {
        GestionarProveedorControlador controlador;

        public NuevoProveedorView(GestionarProveedorControlador controlador)
        {
            InitializeComponent();

            this.controlador = controlador;
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

            controlador.crearNuevoProveedor(razonSocial, cuit);
            controlador.agregarTelefono(telefono);
            controlador.agregarDomicilio(calle, numero, localidad, provincia);
            controlador.confirmarNuevoProveedor();
            Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
