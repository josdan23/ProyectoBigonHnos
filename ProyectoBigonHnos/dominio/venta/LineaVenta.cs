using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.venta
{
    class LineaVenta
    {
        public int IdLineaVenta { get; set; }
        public int cantidad { get; set; }
        public Producto producto { get; set; }

        public LineaVenta( int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
        }

        public double obtenerSubtotal()
        {
            return 0.1;
        }

        public override string ToString()
        {
            return $"Producto: {producto}\nCantidad: {cantidad}";
        }
    }
}
