using System.Collections.Generic;

namespace ProyectoBigonHnos.dominio
{
    class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre {get; set;}
        public string Apellido { get; set; }
        public string Dni { get; set; }

        public List<Telefono> Telefonos { get; set; }
        public List<Domicilio> Domicilioes { get; set; }

        public Persona()
        {
            Telefonos = new List<Telefono>();
            Domicilioes = new List<Domicilio>();
        }

        public Persona( string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefonos = new List<Telefono>();
            Domicilioes = new List<Domicilio>();
        }

        public void agregarTelefono(Telefono telefono)
        {
            Telefonos.Add(telefono);
        }

        public void agregarDomicilio(Domicilio Domicilio)
        {
            Domicilioes.Add(Domicilio);
        }

        public override string ToString()
        {
            return string.Format("IdPersona: {0}\nNombre: {1}\nApellido: {2}\nDni: {3}\nDomicilio: {4}\nTelefono: {5}",
                IdPersona, 
                Nombre, 
                Apellido, 
                Dni,
                Domicilioes[0],
                Telefonos[0]);
        }
    }
}
