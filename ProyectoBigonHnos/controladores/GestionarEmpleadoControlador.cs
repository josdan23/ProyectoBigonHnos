using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.controladores
{
    class GestionarEmpleadoControlador
    {
        public Empleado Empleado { get; set; }
        public Negocio Negocio { get; set; }

        public GestionarEmpleadoControlador(Negocio negocio)
        {
            Negocio = negocio;
        }

        public void nuevoEmpleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, bool esAdmin, DateTime fechaIngreso)
        {
            Empleado = new Empleado(nombre, apellido, dni, categoria, cuil, password, esAdmin, fechaIngreso);
        }

        public void agregarTelefono(string telefono)
        {
            Empleado.agregarTelefono(telefono);
        }

        public void agregarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Empleado.agregarDomicilio(calle, numero, localidad, provincia);
        }

        public void confirmarNuevoEmpleado()
        {
            Negocio.agregarEmpleado(Empleado);
        }

        public void mostrar()
        {
            Empleado.mostrar();
        }

        public void agregarFamiliar(string dni, string parentesco, DateTime fechaNacimiento, bool discapacidad)
        {
            Empleado.agregarFamiliar(dni, parentesco, fechaNacimiento, discapacidad);
        }

        public void egresoEmpleado(DateTime fechaEgreso)
        {
            Empleado.egreso(fechaEgreso);
        }

        public void agregarUsuario(string username, string password, bool esAdmin)
        {
            Empleado.agregarInfoUsuario(username, password, esAdmin);
        }

    }
}
