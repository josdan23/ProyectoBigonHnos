using ProyectoBigonHnos.vista.pedidos;
using System;

namespace ProyectoBigonHnos.dominio
{
    class PedidoControlador
    {
        private Negocio negocio;
        private Pedido pedido;

        IPedidoView vista;

        public PedidoControlador()
        {
            negocio = Negocio.getNegocio();
        }

        public void unirVista(IPedidoView vista)
        {
            this.vista = vista;
        }

        public void crearNuevoPedido()
        {
            pedido = new Pedido();
            Console.WriteLine("se creo un nuevo pedido");
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
            Console.WriteLine("se agrego un cliente nuevo");
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

        public void buscarCliente(string dni)
        {
            Cliente cliente = negocio.buscarCliente(dni);
            mostrarInfoCliente(cliente);

        }

        private void mostrarInfoCliente(Cliente cliente)
        {
            if (vista.GetType() == typeof(AgregarClienteView))
            {
                AgregarClienteView agregarClienteView = (AgregarClienteView)vista;
                agregarClienteView.mostrarNombre(cliente.Nombre);
                agregarClienteView.mostrarApellido(cliente.Apellido);
                agregarClienteView.mostrarDni(cliente.Dni);
                agregarClienteView.mostrarCalle(cliente.Direcciones[0].Calle);
                agregarClienteView.mostrarNumero(cliente.Direcciones[0].Numero);
                agregarClienteView.mostrarLocalidad(cliente.Direcciones[0].Localidad.Nombre);
                agregarClienteView.mostrarProvincia(cliente.Direcciones[0].Localidad.Provincia.Nombre);
                agregarClienteView.mostrarTelefono(cliente.Telefonos[0].Numero);

            }
        }

    }
}
