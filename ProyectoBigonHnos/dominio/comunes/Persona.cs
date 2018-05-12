using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Persona
    {
        public string Nombre {get; set;}
        public string Apellido { get; set; }
        public string Dni { get; set; }

        public List<Telefono> Telefonos { get; set; }
        public List<Direccion> Direcciones { get; set; }

        public Persona()
        {
            Telefonos = new List<Telefono>();
            Direcciones = new List<Direccion>();
        }

        public Persona( string nombre, string apellido, string dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            Telefonos = new List<Telefono>();
            Direcciones = new List<Direccion>();

        }

        public void agregarTelefono(Telefono telefono)
        {
            Telefonos.Add(telefono);
        }

        public void agregarDireccion(Direccion direccion)
        {
            Direcciones.Add(direccion);
        }
    }
}
