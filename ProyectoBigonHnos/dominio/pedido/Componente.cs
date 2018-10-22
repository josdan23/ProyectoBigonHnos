using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Componente
    {
        public int IdComponente { get; set; }
        public string descripcion { get; set; }
        public double altura { get; set; }
        public double ancho { get; set; }
        public double profundidad { get; set; }
        public string colorPrimario { get; set; }
        public string colorSecundario { get; set; }
        public int cantidad { get; set; }
        public Material material;

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
            Console.WriteLine(material);
            Console.WriteLine();
        }
    }
}
