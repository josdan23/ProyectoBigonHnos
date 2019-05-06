using System;
using System.Collections.Generic;

namespace ProyectoBigonHnos.dominio
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime fechaCompra;
        public EstadoCompra estado;
        public Proveedor proveedor;
        public Empleado empleado;
        public List<LineaCompra> lineasDeCompra { get; set; }

        public Compra()
        {
            this.fechaCompra = DateTime.Now;
            this.estado = EstadoCompra.EN_PROCESO;
            lineasDeCompra = new List<LineaCompra>();
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
        }

        public void agregarEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }

        public int crearLineaDeCompra(Material material, int cantidad)
        {
            LineaCompra lc = new LineaCompra(material, cantidad);
            Console.WriteLine("idMaterial:" + material.IdMaterial);
            lineasDeCompra.Add(lc);
            return lineasDeCompra.Count-1;
        }

        public void seHaCompletado()
        {
            fechaCompra = DateTime.Now;
            this.estado = EstadoCompra.EN_PROCESO;
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

        internal void finalizarCompra()
        {
            estado = EstadoCompra.COMPLETADO;
        }
    }

    public enum EstadoCompra
    {
        COMPLETADO,
        EN_PROCESO
    };
}
    