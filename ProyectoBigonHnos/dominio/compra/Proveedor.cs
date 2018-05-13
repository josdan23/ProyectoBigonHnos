using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Proveedor
    {
        private int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public string cuit;
        
        public List<Telefono> Telefonos { get; set; }
        public List<Direccion> Direcciones { get; set; }

        public Proveedor(int idProveedor, string razonSocial, string cuit)
        {
            this.idProveedor = idProveedor;
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            Telefonos = new List<Telefono>();
            Direcciones = new List<Direccion>();
        }

        public void mostrar()
        {
            Console.WriteLine(idProveedor);
            Console.WriteLine(razonSocial);
            Console.WriteLine(cuit);
        }

        public int getIdProveedor()
        {
            return idProveedor;
        }

        public void agregarDireccion(Direccion direccion)
        {
            Direcciones.Add(direccion);
        }

        public void agregarTelefono(Telefono telefono)
        {
            Telefonos.Add(telefono);
        }
    }
}
