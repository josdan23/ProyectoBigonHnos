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

namespace ProyectoBigonHnos.vista
{
    public partial class ClientesView : UserControl
    {
        GestionarClientesControlador controlador;

        public ClientesView()
        {
            InitializeComponent();

            controlador = new GestionarClientesControlador(this);
            controlador.listarClientes();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoClienteView vista = new NuevoClienteView(controlador);
            vista.ShowDialog();
            refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            if ( dni != null)
            {
                controlador.borrarCliente(dni);
                refrescar();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            string dni = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            EditarClienteView vista = new EditarClienteView();
            vista.ShowDialog();
            refrescar();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void seleccionarFila(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow.Cells[0].Value != null)
            {
                controlador.detalleCliente(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                btnEliminar.Enabled = true;

            }
        }

        public void mostrarCliente( String dni, string apellido, string nombre) 
        {
            dgvClientes.Rows.Add(dni, apellido, nombre);

        }

        public void mostrarInformmacion(string dni, string apellido, string nombre)
        {
            tboxDni.Text = dni;
            tBoxNombre.Text = nombre;
            tBoxApellido.Text = apellido;
        }

        public void mostrarTelefono(string numero)
        {
            dgvTelefonos.Rows.Add(numero);
        }

        public void mostrarDomicilio(string numero, string calle, string localidad, string provincia)
        {
            tboxNumero.Text = numero;
            tboxCalle.Text = calle;
            tboxLocalidad.Text = localidad;
            tboxProvincia.Text = provincia;
        }

        private void limpiarTabla()
        {
            dgvClientes.Rows.Clear();
          
        }

        private void limpiarTablaTelefono()
        {
            dgvTelefonos.Rows.Clear();
        }

        public void refrescar()
        {
            tboxDni.Text = "";
            tBoxNombre.Text = "";
            tBoxApellido.Text = "";
            tboxCalle.Text = "";
            tboxNumero.Text = "";
            tboxLocalidad.Text = "";
            tboxProvincia.Text = "";

            limpiarTabla();
            limpiarTablaTelefono();

            controlador.listarClientes();
        }
    }
}
