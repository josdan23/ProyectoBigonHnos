using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Compra
    {
        public int IdCompra { get; set; }
        private DateTime fechaCompra;
        private string estado;
        private Proveedor proveedor;
        private List<LineaDeCompra> lineasDeCompra;

        public Compra()
        {
            this.fechaCompra = DateTime.Now;
            this.estado = "nuevo";
            lineasDeCompra = new List<LineaDeCompra>();
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
        }

        public void crearLineaDeCompra(Material material, int cantidad)
        {
            LineaDeCompra lc = new LineaDeCompra(material, cantidad);
            lineasDeCompra.Add(lc);
        }

        public void seHaCompletado()
        {
            this.estado = "completado";
        }

        public double obtenerTotal()
        {
            double total = 0.0;

            foreach (LineaDeCompra lc in lineasDeCompra)
            {
                total += lc.obtenerSubTotal();
            }

            return total;
        }

        public void mostrar()
        {
            Console.WriteLine(fechaCompra);
            Console.WriteLine(proveedor);
            Console.WriteLine(estado);
            foreach (LineaDeCompra lc in lineasDeCompra)
            {
                lc.mostrar();
            }
        }
    }
}
