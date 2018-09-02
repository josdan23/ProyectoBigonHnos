using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Proveedor
    {
        public static int contadorId = 0;

        private int idProveedor;
        private string razonSocial;
        private string cuit;
        private List<Telefono> telefonos;
        private List<Domicilio> domicilios;


        public Proveedor()
        {
            idProveedor = contadorId;
            contadorId++;
            Console.WriteLine(contadorId);
            telefonos = new List<Telefono>();
            domicilios = new List<Domicilio>();
        }

        public Proveedor(string razonSocial, string cuit)
        {
            RazonSocial = razonSocial;
            Cuit = cuit;
            Telefonos = new List<Telefono>();
            domicilios = new List<Domicilio>();
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public List<Telefono> Telefonos { get => telefonos; set => telefonos = value; }
        public List<Domicilio> Domicilios { get => domicilios; set => domicilios = value; }

        public void mostrar()
        {
            Console.WriteLine(IdProveedor);
            Console.WriteLine(RazonSocial);
            Console.WriteLine(Cuit);
        }

        public void agregarNuevaDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Domicilio nuevaDomicilio = new Domicilio(calle, numero, localidad, provincia);
            Domicilios.Add(nuevaDomicilio);
        }

        public void agregarNuevoTelefono(String numeroDeTelefono)
        {
            Telefono nuevoTelefono = new Telefono(numeroDeTelefono);
            Telefonos.Add(nuevoTelefono);
        }

    }
}
