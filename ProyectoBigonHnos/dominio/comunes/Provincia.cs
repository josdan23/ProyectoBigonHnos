using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }

        public Provincia()
        {

        }

        public Provincia(string nombre)
        {
            Nombre = nombre;
        }

        public void mostrar()
        {
            Console.WriteLine(Nombre);
        }

        public override string ToString()
        {
            return string.Format("idProvincia: {0}\nNombre: {1}", IdProvincia, Nombre);
        }
    }
}
