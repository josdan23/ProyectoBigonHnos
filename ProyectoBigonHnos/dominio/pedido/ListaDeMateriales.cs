using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.pedido
{
    public class ListaDeMateriales
    {
        public int idListaDeMateriales { get; set; }
        public Material material { get; set; }
        public int cantidad { get; set; }

        public ListaDeMateriales(Material material, int cantidad)
        {
            this.material = material;
            this.cantidad = cantidad;
        }

        public double getSubtotal()
        {
            return cantidad * material.Precio;
        }


    }
}
