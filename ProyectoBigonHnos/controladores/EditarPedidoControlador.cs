using System;
using ProyectoBigonHnos.vista.pedidos;
using ProyectoBigonHnos.dominio.pedido;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.data;

namespace ProyectoBigonHnos.controladores
{
    class EditarPedidoControlador : IPedidoController
    {
        private EditarPedidoView vista { get; set; }
        private IPedidoView view { get; set; }
        private Pedido pedidoSelecionado { get; set; }

        public EditarPedidoControlador()
        {

        }

        internal void unirVista(IPedidoView vista)
        {
            view = vista;

        }

        public void recuperarPedido (int idPedido)
        {
            pedidoSelecionado = Negocio.getNegocio().buscarPedido(idPedido);

            mostrarPedido();
        }

        public void mostrarPedido()
        {

            ((EditarPedidoView)view).ActualizarVista();//borrar todo y volver a mostrar

            if (view is EditarPedidoView)
            {
                ((EditarPedidoView)view).mostrarApellido(pedidoSelecionado.cliente.Apellido);
                ((EditarPedidoView)view).mostrarNombre(pedidoSelecionado.cliente.Nombre);
                ((EditarPedidoView)view).mostrarDni(pedidoSelecionado.cliente.Dni);
                ((EditarPedidoView)view).mostrarDomicilio(
                    pedidoSelecionado.cliente.Domicilioes[0].Calle,
                    pedidoSelecionado.cliente.Domicilioes[0].Numero,
                    pedidoSelecionado.cliente.Domicilioes[0].Localidad.Provincia.Nombre);
                ((EditarPedidoView)view).mostrarTelefono(pedidoSelecionado.cliente.Telefonos[0].Numero);

                foreach(LineaPedido lp in pedidoSelecionado.lineasDePedido)
                {
                    ((EditarPedidoView)view).listarProducto(
                        lp.producto.descripcion,
                        lp.producto.alto,
                        lp.producto.ancho,
                        lp.producto.profundidad,
                        lp.producto.colorPrimario,
                        lp.producto.colorSecundario,
                        lp.cantidad,
                        0);
                }

                foreach(ListaDeMateriales lm in pedidoSelecionado.ListaDeMateriales)
                {
                    ((EditarPedidoView)view).mostrarMaterialesSeleccionados(
                        lm.material.Descripcion,
                        lm.material.Precio,
                        lm.cantidad,
                        lm.getSubtotal());
                }

                foreach(CostoExtra ce in pedidoSelecionado.costosExtras)
                {
                    ((EditarPedidoView)view).mostrarCargosExtras(ce.descripcion, ce.importe);
                }

                ((EditarPedidoView)view).mostrarSubtotalCostosExtras(
                    pedidoSelecionado.obtenerSubtotalCostosExtras());

                ((EditarPedidoView)view).mostrarSubtotalMateriales(
                    pedidoSelecionado.obtenerSubtotalDeMateriales());

                ((EditarPedidoView)view).mostrarTotal(
                    pedidoSelecionado.obtenerTotal());

                ((EditarPedidoView)view).mostrarFechaDePedido(
                    pedidoSelecionado.fechaDePedido);

                ((EditarPedidoView)view).mostrarFechaEntrega(
                    pedidoSelecionado.fechaDeEntrega);
            }
        }

        public void buscarCliente(string dniClienteBuscado)
        {
            Cliente cliente = Negocio.getNegocio().buscarCliente(dniClienteBuscado);

            if (cliente != null)
            {

            }

           
        }

        public void actualizarCliente(string dniCliente)
        {
            Cliente cliente = Negocio.getNegocio().buscarCliente(dniCliente);

            pedidoSelecionado.cliente = cliente;

            ///mostrarPedido();
        }

        public void eliminarProducto(int indiceProductoAEliminar)
        {
            for (int i = 0; i < pedidoSelecionado.lineasDePedido.Count; i++)
            {
                pedidoSelecionado.lineasDePedido.RemoveAt(indiceProductoAEliminar);
            }
        }

        public void eliminarMaterial(int indiceMaterialAEliminar)
        {
            for (int i = 0; i < pedidoSelecionado.ListaDeMateriales.Count; i++)
            {
                pedidoSelecionado.ListaDeMateriales.RemoveAt(indiceMaterialAEliminar);
            }
        }

        public void eliminarCostosExtras(int indiceCostosExtrasAEliminar)
        {
            for (int i = 0; i < pedidoSelecionado.costosExtras.Count; i++)
            {
                pedidoSelecionado.costosExtras.RemoveAt(indiceCostosExtrasAEliminar);
            }
        }

        public void agregarNuevoProducto(string descripcion, double alto, double ancho, double profundidad, string colorP, string colorS, int cantidad)
        {
            pedidoSelecionado.crearLineaDePedido(
                descripcion,
                alto,
                ancho,
                profundidad,
                colorP,
                colorS,
                cantidad);
        }

        public void agregarNuevoMaterialDisponible(int idMaterial, int cantidad)
        {
            Material material = Negocio.getNegocio().buscarMaterial(idMaterial);
            if (material != null)
                pedidoSelecionado.agregarMaterialAUsar(material, cantidad);
        }

        public void agregarCostoExtra(string descripcionCostoExtra, double monto)
        {
            pedidoSelecionado.agregarCostoExtra(descripcionCostoExtra, monto);
        }

        public void mostrarMateriales()
        {
            if (view is AgregarMaterialesNecesariosView)
            {

                foreach (Material unMaterial in CatalogoDeMateriales.getInstancia().obtenerMateriales())
                {
                    ((AgregarMaterialesNecesariosView)view).mostrarMaterialDisponible(unMaterial.IdMaterial, unMaterial.Descripcion, unMaterial.tipoUnidad, unMaterial.Precio);
                }
            }
        }

        public void actualizarFechaEntrega(DateTime nuevaFechaDeEntrega)
        {
            pedidoSelecionado.fechaDeEntrega = nuevaFechaDeEntrega;
        }

        public void regitrarPedidoActualizado()
        {
            Negocio.getNegocio().actualizarPedido(pedidoSelecionado);
        }
    }
}
