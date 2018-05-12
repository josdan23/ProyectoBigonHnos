using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class CompraControlador
    {
        private Compra compra;
        private Negocio negocio;

        public CompraControlador(Negocio negocio)
        {
            this.negocio = negocio;
        }

        public void iniciarNuevaCompra()
        {
            compra = new Compra();
        }

        public void agregarProveedor(int idProveedor)
        {
            Proveedor provedor = negocio.buscarProveedor(idProveedor);
            compra.agregarProveedor(provedor);
        }

        public void agregarMaterial(int idMaterial, int cantidad)
        {
            Material material = negocio.buscarMaterial(idMaterial);
           
            compra.crearLineaDeCompra(material, cantidad);
        }

        public void confirmarComprar()
        {
            compra.seHaCompletado();

            compra.mostrar();
        }
    }
}
