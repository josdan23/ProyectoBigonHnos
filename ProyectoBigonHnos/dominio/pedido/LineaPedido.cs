using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class LineaPedido
    {
        public int IdLineaPedido { get; set; }
        public int cantidad { get; set; }
        public Producto producto { get; set; }
        public int IdPedido { get; set; }

        public LineaPedido() { }

        public LineaPedido(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void crearProducto(string descripcion, double alto, double ancho, double profundidad,
            string colorPrimario, string colorSecundario)
        {
            producto = new Producto(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario);
        }
        /*
        public void crearComponente(string descripcion, double alto, double ancho, double profundidad,
            string colorPrimario, string colorSecundario, int cantidad, Material material) 
        {
            producto.crearComponente(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad, material);
        }*/

        public void mostrar()
        {
            Console.WriteLine(cantidad);
            producto.mostrar();
        }

        /*
        public double obtenerSubtotal()
        {
            //TODO: calcular el subtotal de acuerdo al producto 
            return 0.1;
        }
        */
    }
}
