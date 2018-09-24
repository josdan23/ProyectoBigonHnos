using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.venta;
using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.vista.ventas;
using System;

namespace ProyectoBigonHnos.controladores
{
    class VentaControlador
    {
        private Venta Venta { get; set; }

        private IVentaView Vista { get; set; }

        public VentaControlador()
        {
        }

        public void iniciarVenta()
        {
            //TODO: agregar Empleado
            Venta = new Venta();
        }

        public void agregarCliente(string dniCliente)
        {
            Cliente cliente = Negocio.getNegocio().buscarCliente(dniCliente);
            Venta.agregarCliente(cliente);
        }

        public void agregarPedido(int idPedido)
        {
            Pedido pedido = Negocio.getNegocio().buscarPedido(idPedido);

            if (pedido == null)
                Console.WriteLine("pedido nulo");
            Venta.agregarPedido(pedido);

            Venta.agregarCliente(pedido.cliente);
        }

        public void agregarNumeroDeCuotas(int nroCuotas)
        {
            Venta.agregarNumeroDeCuotas(nroCuotas);
        }

        public void confirmarVenta()   
        {
            Venta.confirmar();
            Negocio.getNegocio().cargarVentasConfirmadas(Venta);

            Console.WriteLine("SE HA CREADO LA VENTA");
        }

        public void unirVista(IVentaView vista)
        {
            Vista = vista;
        }

        public void MostrarVentas()
        {
            VentasView view = (VentasView) Vista;

            foreach (Venta venta in Negocio.getNegocio().obtenerTodasVentasRealizadas())
            {
                    view.listarVenta(
                        venta.IdVenta,
                        venta.Cliente.Apellido,
                        DateTime.Now,
                        0.0); //TODO: mostrar con valores reales de una venta
            }
        }

        public void eliminarVenta(int idVenta)
        {
            Negocio.getNegocio().BorrarVenta(idVenta);
        }

        public void MostrarPedidos(string dniClienteFiltro)
        {
            NuevaVentaView view = (NuevaVentaView)Vista;

            foreach (Pedido pedido in Negocio.getNegocio().obtenerTodosPedidosRealizados())
            {
                if (pedido.cliente.Dni == dniClienteFiltro)
                {
                    view.listarPedido(pedido.idPedido, pedido.cliente.Apellido, pedido.fechaDePedido);
                }
            }
        }
    }
}
