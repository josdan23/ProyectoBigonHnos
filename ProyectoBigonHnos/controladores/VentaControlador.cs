using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.controladores
{
    class VentaControlador
    {
        private Venta venta;
        private Negocio negocio;

        public VentaControlador(Negocio negocio)
        {
            this.negocio = negocio;
        }

        public void iniciarVenta()
        {
            //TODO: agregar Empleado
            this.venta = new Venta();
        }

        public void agregarCliente(string dniCliente)
        {
            Cliente cliente = negocio.buscarCliente(dniCliente);
            venta.agregarCliente(cliente);
        }

        public void agregarPedido(int idPedido)
        {
            Pedido pedido = negocio.buscarPedido(idPedido);
            venta.agregarPedido(pedido);

        }

        public void agregarNumeroDeCuotas(int nroCuotas)
        {
            venta.agregarNumeroDeCuotas(nroCuotas);
        }

        public void confirmarVenta()   
        {
            venta.confirmar();
            negocio.cargarVentasConfirmadas(venta);
        }
    }
}
