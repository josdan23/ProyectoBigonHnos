using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.controladores
{
    class UsuarioControlador
    {
        private UsuarioView Vista { get; set; }
        private Empleado EmpleadoLogueado { get; set; }

        public UsuarioControlador()
        {

        }

        public void unirVista(UsuarioView view)
        {
            Vista = view;
        }

        public void obtenerInformacionEmpleado()
        {
            Vista.mostrarLegajo(EmpleadoLogueado.Legajo);
            Vista.mostrarApellido(EmpleadoLogueado.Apellido);
            Vista.mostrarNombre(EmpleadoLogueado.Nombre);
            Vista.mostrarCuil(EmpleadoLogueado.Cuil);
            Vista.mostrarCalle(EmpleadoLogueado.Domicilioes[0].Calle);
            Vista.mostrarNumero(EmpleadoLogueado.Domicilioes[0].Numero);
            Vista.mostrarLocalidad(EmpleadoLogueado.Domicilioes[0].Localidad.Nombre);
            Vista.mostrarProvincia(EmpleadoLogueado.Domicilioes[0].Localidad.Provincia.Nombre);
            Vista.mostrarContrasenia(EmpleadoLogueado.Usuario.Password);
            Vista.mostrarAdmin(EmpleadoLogueado.Usuario.esAdmin());
            Vista.mostrarTelefono(EmpleadoLogueado.Telefonos[0].Numero);
        }

        public void setEmpleadoLogueado(string legajo)
        {
            EmpleadoLogueado = Negocio.getNegocio().buscarEmpleado(legajo);
        }

    }
}
