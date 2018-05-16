using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Material
    {
        private static int contadorId = 0;

        public int IdMaterial { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int StockDisponible { get; set; }
        public int StockMinimo { get; set; }
        public int Cantidad;

        public Material(string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            contadorId++;

            IdMaterial = contadorId;
            Descripcion = descripcion;
            Precio = precio;
            StockDisponible = stockDisponible;
            StockMinimo = stockMinimo;
            Cantidad = cantidad;
        }

        public void mostrar()
        {
            Console.WriteLine("DESCRIPCIOIN DEL MATERIAL");
            Console.WriteLine("idMaterial: " + IdMaterial);
            Console.WriteLine("descripcion: " + Descripcion);
            Console.WriteLine("cantidad:" + Cantidad);
            Console.WriteLine("precio: " + Precio);
            Console.WriteLine("stock disponible: " + StockDisponible);
            Console.WriteLine("stock minimo: " + StockMinimo);
            Console.WriteLine();
        }


        public void modificarAtributos(String descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.StockDisponible = stockDisponible;
            this.StockMinimo = stockMinimo;
            this.Cantidad = cantidad;
        }
    }
}
