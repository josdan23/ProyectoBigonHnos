using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.vista.proveedor
{
    interface IProveedorView
    {
        void mostrarIdProveedor(int id);
        void mostrarRazonSocial(string razonSocial);
        void mostrarCuit(string cuit);
        void mostrarTelefono(string telefono);
        void mostrarCalle(string calle);
        void mostrarNumero(int numero);
        void mostrarLocalidad(string localidad);
        void mostrarProvincia(string provincia);

        void listarProveedores(string razonSocial);
    }
}
