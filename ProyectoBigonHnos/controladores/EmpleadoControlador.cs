using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.controladores
{
    class EmpleadoControlador
    {
        private IEmpleadosView Vista { get; set; }

        private Empleado Empleado { get; set; }

        public EmpleadoControlador()
        {

        }

        public void unirVista(IEmpleadosView vista)
        {
            Vista = vista;
        }

        public void crearEmpleado()
        {
            Empleado = new Empleado();
        }

        public void agregarInformacionPersonal(string apellido, string nombre, string dni, string cuil)
        {
            Empleado.agregarInformacionPersonal(nombre, apellido, dni, cuil);
        }

        public void agregarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Empleado.agregarDomicilio(calle, numero, localidad, provincia);
        }

        public void agregarTelefono(string numero)
        {
            Empleado.agregarTelefono(numero);
        }


        public void agregarCategoria(string categoria)
        {
            Empleado.agregarCategoria(categoria);
        }

        public void agregarLegajo(string legajo)
        {
            Empleado.agregarLegajo(legajo);
        }

        public void agregarFamiliar(string dni, DateTime fechaNacimiento, string parentesco, bool discapacidad)
        {
            Empleado.agregarFamiliar(dni, parentesco, fechaNacimiento, discapacidad);
        }

        public void agregarUsuario(string username, string password, bool admin)
        {
            Empleado.agregarCuenta(username, password, admin);
        }

        internal void eliminarEmpleado(string legajo)
        {
            Negocio.getNegocio().borrarEmpleado(legajo);
        }

        public void eliminarFamiliar()
        {
            //Eliminar familiar de el usuario actual
        }

        public void confimarEmpleado()
        {
            Negocio.getNegocio().agregarEmpleado(Empleado);
        }

        public void mostrarInfoEmpleado(string legajo)
        {
            //Empleado empleado = Negocio.getNegocio().buscarEmpleado();

            
        }

        public void mostrarGrupoFamiliar()
        {
            NuevoEmpleadoView view = (NuevoEmpleadoView)Vista;

            foreach (GrupoFamiliar familiar in Empleado.Familiares)
            {
                view.listarFamiliar(
                    familiar.Dni,
                    familiar.Parentesco,
                    familiar.FechaNacimiento,
                    familiar.Discapacidad);
            }
        }

        internal void mostraDetalleDeEmpleado(string legajoSeleccionado)
        {
            Empleado empleado = Negocio.getNegocio().buscarEmpleado(legajoSeleccionado);

            DetalleEmpleadoView view = (DetalleEmpleadoView)Vista;
            view.mostrarInfoEmpleado(
                empleado.Legajo,
                empleado.Usuario.Username,
                empleado.Usuario.Password,
                empleado.Usuario.Administrador,
                empleado.Categoria);

            view.mostrarInfoPersona(
                empleado.Nombre,
                empleado.Apellido,
                empleado.Dni,
                empleado.Cuil);

            view.mostrarDomicilio(
                empleado.Domicilioes[0].Calle,
                empleado.Domicilioes[0].Numero,
                empleado.Domicilioes[0].Localidad.Nombre,
                empleado.Domicilioes[0].Localidad.Provincia.Nombre);

            view.mostrarTelefono(
                empleado.Telefonos[0].Numero);

            view.mostrarFechas(
                empleado.FechaIngreso,
                empleado.FechaEgreso);

            
            foreach( GrupoFamiliar familiar in empleado.Familiares)
            {
                view.mostrarFamiliar(familiar.Dni, familiar.Parentesco, familiar.FechaNacimiento, familiar.Discapacidad);
            }
        }

        public void mostrarEmpleados()
        {
            EmpleadoView view = (EmpleadoView)Vista;

            foreach(Empleado empleado in Negocio.getNegocio().obtenerTodosEmpleados())
            {
                view.listarEmpleado(
                    empleado.Legajo, // implementar id de empleado
                    empleado.Apellido,
                    empleado.Nombre,
                    empleado.Dni,
                    empleado.FechaIngreso,
                    empleado.Categoria
                    );
            }
        }


    }
}
