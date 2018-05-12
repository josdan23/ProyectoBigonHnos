using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Provincia
    {
        public string Nombre { get; set; }

        public Provincia(string nombre)
        {
            this.Nombre = nombre;
        }

        public void mostrar()
        {
            Console.WriteLine(Nombre);
        }
    }
}
