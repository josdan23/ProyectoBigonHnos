using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class PedidoControlador
    { 
        private Negocio negocio;
        private Pedido pedido;

        public PedidoControlador(Negocio negocio)
        {
            this.negocio = negocio;
        }

        public void crearNuevoPedido()
        {
            pedido = new Pedido();
        }

        public void agregarProducto(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad)
        {
            pedido.crearLineaDePedido(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad);
        }

        public void agregarComponente(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad, int idMaterial)
        {
            Material material = negocio.buscarMaterial(idMaterial);
            pedido.agregarComponente(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad, material);
        }

        public void agregarCliente(string dni)
        {
            Cliente cliente = negocio.buscarCliente(dni);
            pedido.agregarCliente(cliente);
        }

        public void agregarFechaDeEntrega(DateTime fechaDeEntrega)
        {
            pedido.agregarFechaDeEntrega(fechaDeEntrega);
        }

        public void confirmarPedido()
        {
            pedido.seHaCompletado();

            pedido.imprimirPedido();

            negocio.cargarPedidosRealizados(pedido);
        }

    }
}
