using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.ClienteDao;
using ProyectoBigonHnos.data.EmpleadoDao;
using ProyectoBigonHnos.data.PedidoDao;
using ProyectoBigonHnos.data.ProductoDao;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.venta;

namespace ProyectoBigonHnos.data.VentaDao
{
    class VentaDaoImpl : IVentaDao
    {
        DBConector db;

        public VentaDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Venta t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from venta where id_venta = {0};", id);
            db.borrarRegistro(query);
        }

        public Venta leerPorId(int id)
        {
            string query = string.Format("select * from venta where id_venta = {0};", id);

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<Venta> listarTodos()
        {
            string query = string.Format("select * from venta ;");

            List<Venta> ventasRegistradas = new List<Venta>();

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                ventasRegistradas.Add( parse(unRegistro));
            }

            return ventasRegistradas;
        }

        public void registrar(Venta t)
        {
            string query = string.Format("insert into venta (fecha, iva, importe_total, cliente_id_cliente, empleado_id_empleado, pedido_id_pedido) values (\'{0}\', {1}, {2}, {3}, {4}, {5};",
                t.fechaDeVenta.ToShortDateString(),
                t.iva.ToString(CultureInfo.InvariantCulture),
                t.obtenerImporteTotal().ToString(CultureInfo.InvariantCulture),
                t.Cliente.IdCliente,
                t.Empleado.IdEmpleado,
                t.pedido.idPedido);

            db.ejectuarQuery(query);
        }

        private Venta parse(List<Object> unRegistro)
        {
            int idVenta = (int)unRegistro.ElementAt(0);
            DateTime fechaVenta = DateTime.Parse( unRegistro.ElementAt(1).ToString());
            double iva = Convert.ToDouble(unRegistro.ElementAt(2));
            double importeTotal = Convert.ToDouble(unRegistro.ElementAt(3));
            int idCliente = (int)unRegistro.ElementAt(4);
            int idEmpleado = (int)unRegistro.ElementAt(5);
            int idPedido = (int)unRegistro.ElementAt(6);

            Venta nuevaVenta = new Venta();
            nuevaVenta.IdVenta = idVenta;
            nuevaVenta.fechaDeVenta = fechaVenta;
            nuevaVenta.iva = iva;

            IClienteDAO clienteDao = new ClienteDaoImpl();
            nuevaVenta.agregarCliente(clienteDao.leerPorId(idCliente));

            IEmpleadoDAO emleadoDao = new EmpleadoDaoImpl();
            nuevaVenta.agregarEmpleado(emleadoDao.leerPorId(idEmpleado));

            IPedidoDao pedidoDao = new PedidoDaoImpl();
            Pedido pedidoRegistrado = pedidoDao.leerPorId(idPedido);
            nuevaVenta.pedido = pedidoRegistrado;

            nuevaVenta.materialesNecesarios = pedidoRegistrado.ListaDeMateriales;
            nuevaVenta.costosExtras = pedidoRegistrado.costosExtras;

            IProductoDao productoDao = new ProductoDaoImpl();

            //agregar lineas de venta
            foreach (LineaPedido lineaPedido in pedidoRegistrado.lineasDePedido)
            {
                int idLineaVenta = 1;
                int cantidadVenta = lineaPedido.cantidad;
                Producto producto = productoDao.leerPorId(lineaPedido.producto.IdProducto);

                LineaVenta lineaVenta = new LineaVenta(cantidadVenta, producto);
                nuevaVenta.lineasDeVenta.Add(lineaVenta);
            }


            //agregar listaMateriales
            nuevaVenta.materialesNecesarios = pedidoRegistrado.ListaDeMateriales;
            //agregar listaCostos

            nuevaVenta.costosExtras = pedidoRegistrado.costosExtras;

            return nuevaVenta;
        }
    }
}
