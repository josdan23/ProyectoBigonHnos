using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Localidad Localidad { get; set; }

        public Direccion(string nombreCalle, int numero, string nombreLocalidad, string nombreProvincia)
        {
            this.Calle = nombreCalle;
            this.Numero = numero;
            this.Localidad = new Localidad(nombreLocalidad, nombreProvincia);
        }

        public void mostrar()
        { 
            Console.WriteLine(Calle);
            Console.WriteLine(Numero);
            Localidad.mostrar();

        }
    }
}
