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

namespace ProyectoBigonHnos.vista.empleado
{
    public partial class EditarEmpleadoView : Form, IEmpleadosView
    {
        private EmpleadoControlador Controlador { get; set; }

        public EditarEmpleadoView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            dgvFamiliares.Rows.Clear();
            Controlador.mostrarGrupoFamiliar();
        }

        public void UnirControlador(EmpleadoControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
        }

        public void mostrarInfoPersona(string nombre, string apellido, string dni, string cuit)
        {
            tboxNombre.Text = nombre;
            tboxApellido.Text = apellido;
            tboxDni.Text = dni;
            tboxCuit.Text = cuit;
        }

        public void mostrarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            tboxCalle.Text = calle;
            tboxNumero.Text = numero.ToString();
            tboxLocalidad.Text = localidad;
            tboxProvincia.Text = provincia;
        }

        public void mostrarTelefono(string telefono)
        {
            tboxTelefono.Text = telefono;
        }

        public void mostrarInfoEmpleado(string legajo, string usuario, string password, bool administrador, string categoria)
        {
            tboxLegajo.Text = legajo;
            tboxUsuario.Text = usuario;
            tboxContrasenia.Text = password;
            cboxAdministrador.Checked = administrador;
            tboxCategoria.Text = categoria;
        }

        public void mostrarFechas(DateTime fechaIngreso, DateTime fechaEgreso)
        {
            dtpFechaIngreso.Value = fechaIngreso;

            if (!fechaEgreso.Equals(new DateTime()))
                dtpFechaEgreso.Value = fechaEgreso;    
            
        }

        public void mostrarFamiliar(string dniFamiliar, string parentesco, DateTime fechaNac, bool discapacidad)
        {
            dgvFamiliares.Rows.Add(
                dniFamiliar,
                parentesco,
                fechaNac.ToString(),
                discapacidad.ToString()
                );
        }

        public void mostrarDetalle(string legajoSeleccionado)
        {
            Controlador.mostraDetalleDeEmpleado(legajoSeleccionado);
        }

        private void btnBorrarFamiliar_Click(object sender, EventArgs e)
        {
            string dniFamiliar = dgvFamiliares.CurrentRow.Cells[0].Value.ToString();
            Controlador.eliminarFamiliar(dniFamiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String legajo = tboxLegajo.Text;
            String nombre = tboxNombre.Text;
            String apellido = tboxApellido.Text;

            String dni = tboxDni.Text;
            String cuit = tboxCuit.Text;
            String calle = tboxCalle.Text;
            int numero = int.Parse(tboxNumero.Text);
            String localidad = tboxLocalidad.Text;
            String provincia = tboxProvincia.Text;
            String telefono = tboxTelefono.Text;
            String categoria = tboxCategoria.Text;
            String usuario = tboxUsuario.Text;
            String Contraseña = tboxContrasenia.Text;

            DateTime fechaIngreso = dtpFechaIngreso.Value;
            DateTime fechaEgreso = dtpFechaEgreso.Value;

            Controlador.actualizarEmpleado(legajo);
            Controlador.actualizarInformacionPersonalEmpleado(nombre, apellido, dni);
            Controlador.actualizarDatosEmpleado(legajo, categoria, cuit);
            Controlador.actualizarTelefonoEmpleado(telefono);
            Controlador.actuzalizarDomicilioEmpleado(calle, numero, localidad, provincia);
            Controlador.actualizarFechas(fechaIngreso, fechaEgreso);
            Controlador.confirmarActualizacion();
            Dispose();
        }
    }
}
