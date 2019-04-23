using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.vista.pedidos;
using ProyectoBigonHnos.dominio.pedido;
using System;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.dominio
{
    public class PedidoControlador: IPedidoController
    {
        private Negocio negocio;
        private Pedido pedido;

        private IPedidoView vista;

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

        /*
        public void agregarComponente(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad, int idMaterial)
        {
            Material material = Negocio.getNegocio().buscarMaterial(idMaterial);
           
            pedido.agregarComponente(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad, material);
        }
        */

        public void agregarCostoExtra(string descripcion, double importe)
        {
            pedido.agregarCostoExtra(descripcion, importe);
        }

        public void agregarMaterialAUsar(int idMaterial, int cantidad)
        {
            Material material = negocio.buscarMaterial(idMaterial);

            pedido.agregarMaterialAUsar(material, cantidad);
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
            if (cliente != null)
            {
                if (vista.GetType() == typeof(AgregarClienteView))
                {
                    AgregarClienteView agregarClienteView = (AgregarClienteView)vista;
                    agregarClienteView.mostrarNombre(cliente.Nombre);
                    agregarClienteView.mostrarApellido(cliente.Apellido);
                    agregarClienteView.mostrarDni(cliente.Dni);
                    agregarClienteView.mostrarCalle(cliente.Domicilioes[0].Calle);
                    agregarClienteView.mostrarNumero(cliente.Domicilioes[0].Numero);
                    agregarClienteView.mostrarLocalidad(cliente.Domicilioes[0].Localidad.Nombre);
                    agregarClienteView.mostrarProvincia(cliente.Domicilioes[0].Localidad.Provincia.Nombre);
                    agregarClienteView.mostrarTelefono(cliente.Telefonos[0].Numero);

                }
            }
            
        }

        public void mostrarMateriales()
        {
            if (vista.GetType() == typeof(AgregarMaterialesNecesariosView))
            {
                AgregarMaterialesNecesariosView view = (AgregarMaterialesNecesariosView)vista;
                foreach (Material unMaterial in CatalogoDeMateriales.getInstancia().obtenerMateriales())
                {
                    view.mostrarMaterialDisponible(unMaterial.IdMaterial, unMaterial.Descripcion, unMaterial.tipoUnidad, unMaterial.Precio);
                }
            }
        }

        public void mostrarCliente()
        {
            if ( pedido.cliente != null)
            {
                if (vista.GetType() == typeof(NuevoPedidoView))
                {
                    NuevoPedidoView view = (NuevoPedidoView)vista;

                    view.mostrarNombre(pedido.cliente.Nombre);
                    view.mostrarApellido(pedido.cliente.Apellido);
                    view.mostrarDni(pedido.cliente.Dni);
                    view.mostrarTelefono(pedido.cliente.Telefonos[0].Numero);

                    view.mostrarDomicilio(
                        pedido.cliente.Domicilioes[0].Calle,
                        pedido.cliente.Domicilioes[0].Numero,
                        pedido.cliente.Domicilioes[0].Localidad.Provincia.Nombre);
                }
            }
            
        }

        public void mostrarProductos()
        {
            NuevoPedidoView view = (NuevoPedidoView)vista;

            foreach (LineaPedido lp in pedido.obtenerLineasDePedido())
            {

                view.listarProducto(
                    lp.producto.descripcion,
                    lp.producto.alto,
                    lp.producto.ancho,
                    lp.producto.profundidad,
                    lp.producto.colorPrimario,
                    lp.producto.colorSecundario,
                    lp.cantidad);

                //TODO: ver el precio del producto
            }
        }

        internal string mostrarSubtotalCargosExtras()
        {
            return pedido.obtenerSubtotalCostosExtras().ToString() ;
        }

        internal string mostrarSubtotalMaterial()
        {
            return pedido.obtenerSubtotalDeMateriales().ToString() ;
        }

        /*
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
*/
        public void mostrarPedidos()
        {
            PedidosView view = (PedidosView) vista;

            foreach (Pedido pedido in Negocio.getNegocio().obtenerTodosPedidos())
            {
                view.listarPedido(pedido.idPedido.ToString(), pedido.cliente.Apellido, pedido.fechaDePedido, pedido.obtenerTotal());
            }
        }

        public string mostrarTotal()
        {
            return pedido.obtenerTotal().ToString();
        }

        public void eliminarPedido(int idPedido)
        {
            Negocio.getNegocio().borrarPedido(idPedido);
        }

        public void mostrarCargosExtrasDelPedido()
        {
            NuevoPedidoView view = (NuevoPedidoView)vista;

            foreach(CostoExtra cargosExtra in pedido.costosExtras)
            {
                view.mostrarCargosExtras(cargosExtra.descripcion, cargosExtra.importe);
            }
        }

        public void mostrarMaterialesDelPedido()
        {
            NuevoPedidoView view = (NuevoPedidoView)vista;

            foreach (ListaDeMateriales materiales in pedido.ListaDeMateriales)
            {
                view.mostrarMaterialesSeleccionados(materiales.material.Descripcion, materiales.material.Precio, materiales.cantidad, materiales.getSubtotal());
            }
        }
    }
}
