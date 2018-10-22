using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime fechaCompra;
        public string estado;
        public Proveedor proveedor;
        public List<LineaCompra> lineasDeCompra { get; set; }

        public Compra()
        {
            this.fechaCompra = DateTime.Now;
            this.estado = "nuevo";
            lineasDeCompra = new List<LineaCompra>();
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
        }

        public void crearLineaDeCompra(Material material, int cantidad)
        {
            LineaCompra lc = new LineaCompra(material, cantidad);
            lineasDeCompra.Add(lc);
        }

        public void seHaCompletado()
        {
            fechaCompra = DateTime.Now;
            this.estado = "completado";
        }

        public double obtenerTotal()
        {
            double total = 0.0;

            foreach (LineaCompra lc in lineasDeCompra)
            {
                total += lc.obtenerSubTotal();
            }

            return total;
        }

        public void mostrar()
        {
            Console.WriteLine("\nCOMPRA\n");
            Console.WriteLine(fechaCompra);
            Console.WriteLine(proveedor);
            Console.WriteLine(estado);
            foreach (LineaCompra lc in lineasDeCompra)
            {
                Console.WriteLine(lc);
            }
        }

    }
}
    