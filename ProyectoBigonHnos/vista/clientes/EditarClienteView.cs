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
    public partial class EditarClienteView : Form
    {
        GestionarClientesControlador Controlador { get; set; }

        public EditarClienteView()
        {
            InitializeComponent();
        }

        public void unirControlador(GestionarClientesControlador controlador)
        {
            Controlador = controlador;
            
        }

        public void mostrarCliente(string dni, string nombre, string apellido)
        {
            tboxDni.Text = dni;
            tboxNombre.Text = nombre;
            tboxApellido.Text = apellido;
        }

        public void mostrarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            tboxCalle.Text = calle;
            tboxNumero.Text = $"{numero}";
            tboxLocalidad.Text = localidad;
            tboxProvincia.Text = provincia;
        }

        public void mostrarTelefono(string telefono)
        {
            tboxTelefono.Text = telefono;
        }

        private void actualizarCliente()
        {
            Controlador.actualizarCliente(
                int.Parse(idClienteLb.Text),
                tboxDni.Text,
                tboxApellido.Text,
                tboxNombre.Text,
                tboxCalle.Text,
                tboxNumero.Text,
                tboxLocalidad.Text,
                tboxProvincia.Text,
                tboxTelefono.Text);

        }

        public void mostrarIdCliente(int idCliente)
        {
            idClienteLb.Text = idCliente.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(idClienteLb.Text);
            string nombre = tboxNombre.Text;
            string apellido = tboxApellido.Text;
            string dni = tboxDni.Text;
            string telefono = tboxTelefono.Text;
            string calle = tboxCalle.Text;
            string numero = tboxNumero.Text;
            string localidad = tboxLocalidad.Text;
            string provincia = tboxProvincia.Text;

            Controlador.actualizarCliente(
                idCliente,
                dni,
                apellido,
                nombre,
                calle,
                numero,
                localidad,
                provincia,
                telefono);

            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }


}
