using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Material
    {
        public int idMaterial { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int stockDisponible { get; set; }
        public int stockMinimo { get; set; }
        public int cantidad;

        public Material(int idMaterial, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            this.idMaterial = idMaterial;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stockDisponible = stockDisponible;
            this.stockMinimo = stockMinimo;
            this.cantidad = cantidad;
        }

        public void mostrar()
        {
            Console.WriteLine("DESCRIPCIOIN DEL MATERIAL");
            Console.WriteLine("idMaterial: " + idMaterial);
            Console.WriteLine("descripcion: " + descripcion);
            Console.WriteLine("cantidad:" + cantidad);
            Console.WriteLine("precio: " + precio);
            Console.WriteLine("stock disponible: " + stockDisponible);
            Console.WriteLine("stock minimo: " + stockMinimo);
            Console.WriteLine();
        }

        public void setIdMaterial(int idMaterial)
        {
            this.idMaterial = idMaterial;
        }

        public int getIdMaterial()
        {
            return idMaterial;
        }

        public void modificarAtributos(String descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.stockDisponible = stockDisponible;
            this.stockMinimo = stockMinimo;
            this.cantidad = cantidad;
        }
    }
}
