using System;

namespace ProyectoBigonHnos.dominio
{
    public class Telefono
    {
        public int IdTelefono { get; set; }
        public string Numero { get; set; }

        public Telefono() { }

        public Telefono(string numero)
        {
            this.Numero = numero;
        }

        public void mostrar()
        {
            Console.WriteLine(Numero);
        }

        public override string ToString()
        {
            return String.Format("id: {0}\nNumero: {1}", IdTelefono, Numero);
        }
    }
}
