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
    partial class ProveedorView : UserControl, IProveedorView
    {
        private GestionarProveedorControlador controlador;

        public ProveedorView()
        {
            InitializeComponent();
            controlador = new GestionarProveedorControlador(this);
            controlador.listarProvedores();
        }

        public void listarProveedores(string razonSocial)
        {
            cboxProveedores.Items.Add(razonSocial);
        }

        private void onSeleccionarItem(object sender, EventArgs e)
        {
            controlador.obtenerDetalleDeProveedor(obtenerNombreDeItemSeleccionado());

            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
            controlador.eliminarProveedor(obtenerNombreDeItemSeleccionado());
            refrescarLista();
            
        }


        private string obtenerNombreDeItemSeleccionado()
        {
            return (string) cboxProveedores.SelectedItem;
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


            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoProveedorView vista = new NuevoProveedorView(controlador);
            vista.ShowDialog();
            refrescarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idProveedorSeleccionado = int.Parse(lblIdProveedor.Text);
            EditarProveedorVista vista = new EditarProveedorVista(idProveedorSeleccionado);
            vista.ShowDialog();
            refrescarLista();
        }

        public void mostrarIdProveedor(int id)
        {
            lblIdProveedor.Text = id.ToString();
        }

        public void mostrarRazonSocial(string razonSocial)
        {
            lblRazonSocial.Text = razonSocial;
        }

        public void mostrarCuit(string cuit)
        {
            lblCuit.Text = cuit;
        }

        public void mostrarCalle(string calle)
        {
            lblCalle.Text = calle;
        }

        public void mostrarNumero(int numero)
        {
            lblNumero.Text = numero.ToString();
        }

        public void mostrarLocalidad(string localidad)
        {
            lblLocalidad.Text = localidad;
        }

        public void mostrarProvincia(string provincia)
        {
            lblProvincia.Text = provincia;
        }

        public void mostrarTelefono(string telefono)
        {
            lblTelefono.Text = telefono;
        }
    }
}
