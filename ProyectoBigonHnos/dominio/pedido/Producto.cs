using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Producto
    { 
        public int IdProducto { get; set; }
        public string descripcion { get; set; }
        public double alto { get; set; }
        public double ancho { get; set; }
        public double profundidad { get; set; }
        public string colorPrimario { get; set; }
        public string colorSecundario { get; set; }
 

        public List<Componente> componentes { get; set; }

        public Producto(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario)
        {
            this.descripcion = descripcion;
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.colorPrimario = colorPrimario;
            this.colorSecundario = colorSecundario;

            componentes = new List<Componente>();
        }


        public void crearComponente(string descripcion, double alto, double ancho, 
            double profundidad, string colorPrimario,string colorSecundario, int cantidad, Material material)
        {
            Componente componente = new Componente(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad, material);
            componentes.Add(componente);
        }

        public void mostrar()
        {
            Console.WriteLine(descripcion);
            Console.WriteLine(alto);
            Console.WriteLine(ancho);
            Console.WriteLine(profundidad);
            Console.WriteLine(colorPrimario);
            Console.WriteLine(colorSecundario);
            Console.WriteLine();

            foreach (Componente componente in componentes)
            {
                componente.mostrar();
            }
        }
    }
}
