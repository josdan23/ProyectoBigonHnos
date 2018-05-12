using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Localidad
    {
        public string Nombre { get; set; }
        public Provincia Prov { get; set; }

        public Localidad(string nombreLocalidad, string nombreProvincia)
        {
            this.Nombre = nombreLocalidad;
            this.Prov = new Provincia(nombreProvincia);
        }

        public void mostrar()
        {
            Console.WriteLine(Nombre);
            Prov.mostrar();
        }

    }
}
