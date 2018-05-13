using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista.proveedor
{
    partial class ProveedorView : UserControl
    {
        private GestionarProveedorControlador controlador;

        public ProveedorView()
        {
            InitializeComponent();
            controlador = new GestionarProveedorControlador(this);
            controlador.listarProvedores();
        }

        public void mostrarProveedor(string nombre)
        {
            cboxProveedores.Items.Add(nombre);

        }

        public void mostrarInformacion(string razonSocial, string cuit)
        {
            lblRazonSocial.Text = razonSocial;
            lblCuit.Text = cuit;
        }

        public void mostrarTelefono(string numero)
        {
            lblTelefono.Text = numero;
        }

        public void mostrarDireccion(string calle, int numero, string localidad, string provincia)
        {
            lblCalle.Text = calle;
            lblNumero.Text = $"{numero}";
            lblLocalidad.Text = localidad;
            lblProvincia.Text = provincia;
        }

        private void onSeleccionarItem(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;

            string item = (string)cboxProveedores.SelectedItem;

            controlador.obtenerDetalle(item);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string razonSocial = (string)cboxProveedores.SelectedItem;

            controlador.eliminarProveedor(razonSocial);
            refrescarLista();
            
        }

        public void refrescarLista()
        {
            lblRazonSocial.Text = "";
            lblCuit.Text = "";
            lblTelefono.Text = "";
            lblCalle.Text = "";
            lblNumero.Text = "";
            lblLocalidad.Text = "";
            lblProvincia.Text = "";

            cboxProveedores.Text = "";
            cboxProveedores.Items.Clear();
            controlador.listarProvedores();
        }
    }
}
