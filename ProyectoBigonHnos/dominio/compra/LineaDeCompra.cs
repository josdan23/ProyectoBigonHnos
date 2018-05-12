using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class LineaDeCompra
    {
        int cantidad;
        Material material;

        public LineaDeCompra(Material material, int cantidad)
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
