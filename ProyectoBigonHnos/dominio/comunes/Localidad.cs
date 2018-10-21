using System;

namespace ProyectoBigonHnos.dominio
{
    class Localidad
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }

        public Localidad() { }

        public Localidad(string nombreLocalidad, string nombreProvincia)
        {
            this.Nombre = nombreLocalidad;
            this.Provincia = new Provincia(nombreProvincia);
        }

        public Localidad(string nombre, Provincia provincia)
        {
            this.Nombre = nombre;
            this.Provincia = provincia;
        }

        public void mostrar()
        {
            Console.WriteLine(Nombre);
            Provincia.mostrar();
        }

        public override string ToString()
        {
            return string.Format("idLocalidad: {0}\nLocalidad: {1}\nProvincia\n{2}",IdLocalidad, Nombre, Provincia);
        }

    }
}
