using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class LineaCompra
    {
        public int IdLineaCompra { get; set; }
        int cantidad;
        Material material;

        public LineaCompra(Material material, int cantidad)
        {
            this.material = material;
            this.cantidad = cantidad;
        }

        public double obtenerSubTotal()
        {
            //TODO: calcular el precio según el producto y el material
            return 0.1;
        }

        public void mostrar()
        {
            material.mostrar();
        }
    }
}
