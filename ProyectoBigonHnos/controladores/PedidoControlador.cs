using ProyectoBigonHnos.vista;
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
        }

        public void agregarProducto(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad)
        {
            pedido.crearLineaDePedido(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad);
        }

        public void agregarComponente(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad, int idMaterial)
        {
            Material material = Negocio.getNegocio().buscarMaterial(idMaterial);
           
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

        public void mostrarMateriales()
        {
            if (vista.GetType() == typeof(NuevoComponenteView))
            {
                NuevoComponenteView viewNuevoComponente = (NuevoComponenteView)vista;
                foreach (Material unMaterial in CatalogoDeMateriales.getInstancia().materiales)
                {
                    viewNuevoComponente.listarMaterial(unMaterial.IdMaterial, unMaterial.Descripcion);
                }
            }
        }

        public void mostrarCliente()
        {
            if (vista.GetType() == typeof(NuevoPedidoView))
            {
                NuevoPedidoView view = (NuevoPedidoView)vista;

                view.mostrarNombre(pedido.cliente.Nombre);
                view.mostrarApellido(pedido.cliente.Apellido);
                view.mostrarDni(pedido.cliente.Dni);
                view.mostrarTelefono(pedido.cliente.Telefonos[0].Numero);

                view.mostrarDireccion(
                    pedido.cliente.Direcciones[0].Calle,
                    pedido.cliente.Direcciones[0].Numero,
                    pedido.cliente.Direcciones[0].Localidad.Provincia.Nombre);
            }
        }

        public void mostrarProductos()
        {
            NuevoPedidoView view = (NuevoPedidoView)vista;

            foreach (LineaDePedido lp in pedido.obtenerLineasDePedido())
            {

                view.listarProducto(
                    lp.producto.descripcion,
                    lp.producto.alto,
                    lp.producto.ancho,
                    lp.producto.profundidad,
                    lp.producto.colorPrimario,
                    lp.producto.colorSecundario,
                    lp.cantidad,
                    0.0
                    );

                //TODO: ver el precio del producto
            }
        } 
        
        public void mostrarComponentes(int indexProducto)
        {
            NuevoPedidoView view = (NuevoPedidoView)vista;
            if (indexProducto < pedido.lineasDePedido.Count)
            {
                foreach (Componente comp in pedido.lineasDePedido[indexProducto].producto.componentes)
                {
                    view.listarComponente(
                        comp.descripcion,
                        comp.altura,
                        comp.ancho,
                        comp.profundidad,
                        comp.colorPrimario,
                        comp.colorSecundario,
                        comp.cantidad,
                        comp.material.Descripcion,
                        0.0); //TODO: arreglar el precio del producto
                }
            }  
        }

        public void mostrarPedidos()
        {
            PedidosView view = (PedidosView) vista;

            foreach (Pedido pedido in Negocio.getNegocio().pedidosRealizados)
            {
                view.listarPedido(pedido.idPedido.ToString(), pedido.cliente.Apellido, pedido.fechaDePedido);
            }
        }

        public void mostrarTotal()
        {
            NuevoPedidoView view = (NuevoPedidoView) vista;
            view.mostrarTotal(pedido.obtenerTotal().ToString());
        }

        public void eliminarPedido(int idPedido)
        {
            Negocio.getNegocio().borrarPedido(idPedido);
        }

    }
}
