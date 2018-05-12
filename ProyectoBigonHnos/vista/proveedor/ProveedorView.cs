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

        private void onSeleccionarItem(object sender, EventArgs e)
        {
            string item = (string)cboxProveedores.SelectedItem;

            controlador.obtenerDetalle(item);
        }
    }
}
