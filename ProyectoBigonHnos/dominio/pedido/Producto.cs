using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Producto
    { 
        private string descripcion { get; set; }
        private double alto { get; set; }
        private double ancho { get; set; }
        private double profundidad { get; set; }
        private string colorPrimario { get; set; }
        private string colorSecundario { get; set; }
 

        private List<Componente> componentes;

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
