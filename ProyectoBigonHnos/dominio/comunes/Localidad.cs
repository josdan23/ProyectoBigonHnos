using System;

namespace ProyectoBigonHnos.dominio
{
    class Localidad
    {
        public int idProvincia {get; set;}
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }

        public Localidad(string nombreLocalidad, string nombreProvincia)
        {
            this.Nombre = nombreLocalidad;
            this.Provincia = new Provincia(nombreProvincia);
        }

        public void mostrar()
        {
            Console.WriteLine(Nombre);
            Provincia.mostrar();
        }

    }
}
