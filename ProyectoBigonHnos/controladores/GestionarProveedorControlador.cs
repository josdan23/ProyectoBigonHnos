using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.controladores
{
    class GestionarProveedorControlador
    {
        ProveedorView vista;

        public Negocio Negocio { get; set; }
        public Proveedor Proveedor { get; set; }

        public GestionarProveedorControlador(ProveedorView vista)
        {
            this.vista = vista;

            Negocio = Negocio.instancia();
        }

        public void nuevoProveedor( string razonSocial, string cuit)
        {
            Proveedor = new Proveedor( razonSocial, cuit);
        }

        public void agregarTelefono(string numeroTelefono)
        {
            Telefono tel = new Telefono(numeroTelefono);
            Proveedor.agregarTelefono(tel);
        }

        public void agregarDireccion(string calle, int numero, string localidad, string provincia)
        {
            Direccion dir = new Direccion(calle, numero, localidad, provincia);
            Proveedor.agregarDireccion(dir);
        }

        public void confirmarNuevoProveedor()
        {
            Negocio.agregarProveedor(Proveedor);
        }

        public void listarProvedores()
        {
            string calle = "";
            int numero = 0;
            string localidad = "";
            string provincia = "";


            for (int i = 0; i < Negocio.proveedores.Count(); i++)
            {
                vista.mostrarProveedor(Negocio.proveedores[i].razonSocial);
                

            }
        }

        public void obtenerDetalle(string razonSocial)
        {
            Proveedor proveedor = Negocio.buscarProveedor(razonSocial);

            if(proveedor != null)
            { 
                string nombre = proveedor.razonSocial;
                string cuit = proveedor.cuit;

                vista.mostrarInformacion(nombre, cuit);
                vista.mostrarTelefono(proveedor.Telefonos[0].Numero);
                vista.mostrarDireccion(
                    proveedor.Direcciones[0].Calle,
                    proveedor.Direcciones[0].Numero,
                    proveedor.Direcciones[0].Localidad.Nombre,
                    proveedor.Direcciones[0].Localidad.Prov.Nombre);
            }
        }

        public void eliminarProveedor(string razonSocial)
        {
            Negocio.borrarProveedor(razonSocial);
        }
    }
}
