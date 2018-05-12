using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista
{
    public partial class EditarClienteView : Form
    {
        public EditarClienteView()
        {
            InitializeComponent();
        }

        public void mostrarCliente(string dni, string nombre, string apellido)
        {
            tboxDni.Text = dni;
            tboxNombre.Text = nombre;
            tboxApellido.Text = Text;
        }

        public void mostrarDireccion(string calle, int numero, string localidad, string provincia)
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
    }

}
