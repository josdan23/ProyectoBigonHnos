using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Empleado : Persona
    {       
        public string Legajo { get; set; }
        public string Categoria { get; set; }
        public string Cuil { get; set; }

        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }

        public Usuario Usuario { get; set; }
        public List<GrupoFamiliar> Familiares { get; set; }


        public Empleado()
        {
            Familiares = new List<GrupoFamiliar>();
        }

        public Empleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, string perfil, DateTime fechaIngreso) : base (nombre,apellido,dni)
        { 
            Categoria = categoria;
            Cuil = cuil;
            FechaIngreso = fechaIngreso;

            Usuario = new Usuario(nombre, password, perfil);
            Familiares = new List<GrupoFamiliar>();
        }

        public void agregarInformacionPersonal(string nombre, string apellido, string dni, string cuil)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Cuil = cuil;
        }

        internal void agregarCategoria(string categoria)
        {
            Categoria = categoria;
        }

        internal void agregarLegajo(string legajo)
        {
            Legajo = legajo;
        }

        public void agregarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Direccion dir = new Direccion(calle, numero, localidad, provincia);
            agregarDireccion(dir);
        }

        internal void agregarInfoUsuario(string username, string password, bool esAdmin)
        {
            Usuario.Username = username;
            Usuario.Password = password;
            Usuario.Administrador = esAdmin;
        }

        public void agregarTelefono(string numeroTelefono)
        {
            Telefono tel = new Telefono(numeroTelefono);
            agregarTelefono(tel);
        } 

        public void agregarFamiliar(string dni, string parentesco, DateTime fechaNacimiento, bool discapacidad)
        {
            Familiares.Add(new GrupoFamiliar(dni, parentesco, fechaNacimiento, discapacidad));
        }

        public void agregarCueta (string nombreUsuario, string password, string perfil)
        {
            Usuario = new Usuario(nombreUsuario, password, perfil); 
        }

        public void mostrar()
        {
            Console.WriteLine("DETALLE DE EMPLEADO");
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Dni);
            Console.WriteLine(Categoria);
            Console.WriteLine(Cuil);
            Console.WriteLine(FechaIngreso);
            Console.WriteLine(FechaEgreso);
            Console.WriteLine(Usuario);
            
            foreach (Telefono tel in Telefonos)
            {
                tel.mostrar();
            }

            foreach (Direccion dir in Direcciones)
            {
                dir.mostrar();
            }

            foreach (GrupoFamiliar familiar in Familiares)
            {
                if (familiar != null)
                    Console.WriteLine(familiar);
            }

        }

        public void egreso(DateTime fechaEgreso)
        {
            FechaEgreso = fechaEgreso;
        }

    }
}
