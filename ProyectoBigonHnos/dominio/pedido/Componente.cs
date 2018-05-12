using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Componente
    {
        private string descripcion { get; set; }
        private double altura { get; set; }
        private double ancho { get; set; }
        private double profundidad { get; set; }
        private string colorPrimario { get; set; }
        private string colorSecundario { get; set; }
        private int cantidad { get; set; }
        private Material material;

        public Componente(string descripcion, double altura, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad, Material material)
        {
            this.descripcion = descripcion;
            this.altura = altura;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.colorPrimario = colorPrimario;
            this.colorSecundario = colorSecundario;
            this.cantidad = cantidad;
            this.material = material;
        }

        public void mostrar()
        {
            Console.WriteLine(descripcion);
            Console.WriteLine(altura);
            Console.WriteLine(ancho);
            Console.WriteLine(profundidad);
            Console.WriteLine(colorPrimario);
            Console.WriteLine(colorSecundario);
            Console.WriteLine(cantidad);
            material.mostrar();
            Console.WriteLine();
        }
    }
}
