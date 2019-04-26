using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.data;

namespace ProyectoBigonHnos.vista.usuario
{
    public partial class UsuarioView : UserControl
    {
        private Empleado EmpleadoLogueado { get; set; }
        private UsuarioControlador controlador { get; set; }

        public UsuarioView()
        {
            InitializeComponent();
        }

        public UsuarioView(String legajo)
        {
            InitializeComponent();
            EmpleadoLogueado = Negocio.getNegocio().buscarEmpleado(legajo);
            controlador = new UsuarioControlador();
            controlador.unirVista(this);
            controlador.setEmpleadoLogueado(legajo);
            controlador.obtenerInformacionEmpleado();
        }

        public void mostrarLegajo(String legajo)
        {
            legajoLbl.Text = legajo;
        }

        public void mostrarApellido(String apellido)
        {
            apellidoLbl.Text = apellido;
        }

        public void mostrarNombre(String nombre)
        {
            nombreLbl.Text = nombre;
        }

        public void mostrarCuil(String cuil)
        {
            cuilLbl.Text = cuil;
        }

        public void mostrarCalle(String calle)
        {
            calleLbl.Text = calle;
        }

        public void mostrarNumero (int numero)
        {
            numeroLbl.Text = numero.ToString();
        }

        public void mostrarLocalidad(String localidad)
        {
            localidadLbl.Text = localidad;
        }

        public void mostrarProvincia(String provincia)
        {
            provinciaLbl.Text = provincia;
        }

        public void mostrarContrasenia (String contrasenia)
        {
            contraseniaLbl.Text = contrasenia;
        }

        public void mostrarAdmin (bool esAdmin)
        {
            if (esAdmin)
                adminLbl.Text = "SI";
            else
                adminLbl.Text = "NO";
        }

        public void mostrarTelefono(String telefono)
        {
            telLbl.Text = telefono;
        }

        private void verContraseniaBtn_Click(object sender, EventArgs e)
        {
            contraseniaLbl.UseSystemPasswordChar = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CambiarContraseniaView cambiarContraseniaView = new CambiarContraseniaView();
            cambiarContraseniaView.unirControlador(new CabiarContraseniaControlador(EmpleadoLogueado.Legajo));
            cambiarContraseniaView.ShowDialog();
            actualizarVista();
            controlador.obtenerInformacionEmpleado();

        }
        
        public void actualizarVista()
        {
            legajoLbl.Text = "";
            apellidoLbl.Text = "";
            nombreLbl.Text = "";
            cuilLbl.Text = "";
            calleLbl.Text = "";
            numeroLbl.Text = "";
            localidadLbl.Text = "";
            provinciaLbl.Text = "";
            telLbl.Text = "";
            adminLbl.Text = "";
            contraseniaLbl.Text = "";
        }

      
    }
}
