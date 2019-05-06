using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class LineaCompra
    {
        
        public int IdLineaCompra { get; set; }
        public int cantidad { get; set; }
        public Material material { get; set; }
        public int IdCompra { get; set; }

        public LineaCompra() { }

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

        public override string ToString()
        {
            return String.Format("\nLINEA DE COMPRA\n" +
                "IdLineaDeCompra: {0}\n" +
                "Cantidad: {1}\n" +
                "Materiales: {2}",
                IdLineaCompra,
                cantidad,
                material);
        }
    }
}
