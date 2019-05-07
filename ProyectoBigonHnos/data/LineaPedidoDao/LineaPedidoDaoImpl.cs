using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.ProductoDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.LineaPedidoDao
{
    class LineaPedidoDaoImpl : ILineaPedidoDao
    {

        DBConector db;

        public LineaPedidoDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(LineaPedido t)
        {
            IProductoDao productoDao = new ProductoDaoImpl();
            productoDao.actualizar(t.producto);

            string query = string.Format("udpate linea_pedido set descripcion = \'{0}\', cantidad=\'{1}\', pedido_id_pedido={2}, producto_id_producto={3} where id_linea_pedido = {4};", 
                t.producto.descripcion,
                t.cantidad,
                t.IdPedido,
                t.producto.IdProducto);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            int idProducto = leerPorId(id).producto.IdProducto;


            string query = string.Format("delete from linea_pedido where id_linea_pedido = {0}", id);
            db.borrarRegistro(query);

            IProductoDao productoDao = new ProductoDaoImpl();
            productoDao.eliminar(idProducto);
        }

        public LineaPedido leerPorId(int id)
        {
            string query = string.Format("select * from linea_pedido where id_linea_pedido = {0}", id);

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<LineaPedido> listarTodos()
        {
            string query = string.Format("select * from linea_pedido");

            List<LineaPedido> lineasRegistradas = new List<LineaPedido>();

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                lineasRegistradas.Add(parse(unRegistro));
            }

            return lineasRegistradas;
        }

        public void registrar(LineaPedido t)
        {
            IProductoDao productoDao = new ProductoDaoImpl();
            productoDao.registrar(t.producto);

            int idProducto = productoDao.listarTodos().Last().IdProducto;

            string query = string.Format("insert into linea_pedido (descripcion, cantidad, pedido_id_pedido, producto_id_producto) values (\'{0}\', {1},{2},{3});",
                t.producto.descripcion,
                t.cantidad,
                t.IdPedido,
                idProducto);

            db.ejectuarQuery(query);
        }

        private LineaPedido parse(List<Object> unRegistro)
        {
            int idLineaPedido = (int) unRegistro.ElementAt(0);
            string descripcion = (string) unRegistro.ElementAt(1);
            int cantidad = (int) unRegistro.ElementAt(2);
            int idPedido = (int) unRegistro.ElementAt(3);
            int idProducto = (int) unRegistro.ElementAt(4);

            IProductoDao productoDao = new ProductoDaoImpl();

            LineaPedido linea = new LineaPedido();
            linea.IdLineaPedido = idLineaPedido;
            linea.cantidad = cantidad;
            linea.IdPedido = idPedido;
            linea.producto = productoDao.leerPorId(idProducto);

            return linea;
        }
    }
}
