using System;

namespace ProyectoBigonHnos.dominio
{
    class Telefono
    {
        public string Numero { get; set; }

        public Telefono(string numero)
        {
            this.Numero = numero;
        }

        public void mostrar()
        {
            Console.WriteLine(Numero);
        }
    }
}
