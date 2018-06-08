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

        public void agregarDireccion(string calle, int numero, string localidad, string provincia)
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

        public void agregarUsuario(string username, string password, string perfil)
        {
            Empleado.agregarCueta(username, password, perfil);
        }

        public void eliminarFamiliar()
        {
            //Eliminar familiar de el usuario actual
        }

        public void confimarEmpleado()
        {
            Negocio.getNegocio().agregarEmpleado(Empleado);
        }

        public void mostrarInfoEmpleado()
        {
            //mostrar informacion de un empleado
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

        public void mostrarEmpleados()
        {
            EmpleadoView view = (EmpleadoView)Vista;

            foreach(Empleado empleado in Negocio.getNegocio().empleados)
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
