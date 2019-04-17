using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.pedido;
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

        public void agregarEmpleado(Empleado empleadoLoguado)
        {
            Venta.Empleado = empleadoLoguado;
        }

        public void iniciarVenta()
        {
            //TODO: agregar Empleado en sesion
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
            else
            {
                Venta.agregarPedido(pedido);

                Venta.agregarCliente(pedido.cliente);

                mostrarDetalleVenta();
            }
            

        }

        public void mostrarDetalleVenta()
        {
            double subtotalCostosExtras = 0.0;
            double subtotalMateriales = 0.0;
            double total = 0.0;

            if (Vista is NuevaVentaView)
            {
                ((NuevaVentaView)Vista).mostrarCliente(Venta.Cliente.Apellido, Venta.Cliente.Nombre);
                ((NuevaVentaView)Vista).mostrarDniCliente(Venta.Cliente.Dni);
                
                foreach(LineaVenta lv in Venta.lineasDeVenta)
                {
                    ((NuevaVentaView)Vista).listarProducto(
                        lv.producto.IdProducto,
                        lv.producto.descripcion,
                        lv.producto.alto,
                        lv.producto.ancho,
                        lv.producto.profundidad,
                        lv.producto.colorPrimario,
                        lv.producto.colorSecundario,
                        lv.cantidad);
                }

                foreach(ListaDeMateriales lm in Venta.materialesNecesarios)
                {
                    ((NuevaVentaView)Vista).listarMaterial(
                        lm.material.IdMaterial,
                        lm.material.Descripcion,
                        lm.material.Precio,
                        lm.material.tipoUnidad,
                        lm.cantidad,
                        lm.getSubtotal());

                    subtotalMateriales += lm.getSubtotal();
                }

                foreach (CostoExtra ce in Venta.costosExtras)
                {
                    ((NuevaVentaView)Vista).listarCostosExtras(
                        ce.descripcion,
                        ce.importe);

                    subtotalCostosExtras += ce.importe;
                }
                total = subtotalMateriales + subtotalCostosExtras;
                ((NuevaVentaView)Vista).mostrarSubtotalCostosExtras(subtotalCostosExtras);
                ((NuevaVentaView)Vista).mostrarSubtotalMateriales(subtotalMateriales);
                ((NuevaVentaView)Vista).mostrarTotal(total);

                ((NuevaVentaView)Vista).mostrarFechaDeVenta(Venta.fechaDeVenta);
                ((NuevaVentaView)Vista).mostrarDomicilio(
                    Venta.Cliente.Domicilioes[0].Calle,
                    Venta.Cliente.Domicilioes[0].Numero,
                    Venta.Cliente.Domicilioes[0].Localidad.Nombre,
                    Venta.Cliente.Domicilioes[0].Localidad.Provincia.Nombre);

                ((NuevaVentaView)Vista).mostrarLegajoVendedor(Venta.Empleado.Legajo);
            }
        }

        public void agregarNumeroDeCuotas(int nroCuotas)
        {
            Venta.agregarNumeroDeCuotas(nroCuotas);

            double montoPorCuota = Venta.obtenerTotal() / nroCuotas;
            ((NuevaVentaView)Vista).mostrarMontoXCuotas(montoPorCuota);

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
                        venta.obtenerTotal());
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
