using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.ClienteDao;
using ProyectoBigonHnos.data.CostoExtraDao;
using ProyectoBigonHnos.data.LineaPedidoDao;
using ProyectoBigonHnos.data.ListaMaterialesDao;
using ProyectoBigonHnos.data.MaterialDao;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.pedido;

namespace ProyectoBigonHnos.data.PedidoDao
{
    class PedidoDaoImpl : IPedidoDao
    {
        DBConector db;

        public PedidoDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Pedido t)
        {
            //actualizar las lines de materiales
            IListaMaterialDao listaMaterialDao = new ListaMaterialDaoImpl();
            foreach (ListaDeMateriales unaLinea in t.ListaDeMateriales)
            {
                listaMaterialDao.actualizar(unaLinea);
            }

            //actualizar las lineas de pedido
            ILineaPedidoDao lineaPedidoDao = new LineaPedidoDaoImpl();
            foreach (LineaPedido linea in t.lineasDePedido)
            {
                lineaPedidoDao.actualizar(linea);
            }

            //actualizar las lineas de costos extras




            string query = string.Format("udpate pedido set fecha_pedido=\'{0}\', fecha_entrega=\'{1}\', estado=\'{2}\', importe_total={3}, cliente_id_cliente = {4} where id_pedido = {5};",
                t.fechaDePedido.ToShortDateString(),
                t.fechaDeEntrega.ToShortDateString(),
                t.estado,
                t.obtenerTotal().ToString(CultureInfo.InvariantCulture),
                t.cliente.IdCliente);

            db.ejectuarQuery(query);

            
        }

        public void eliminar(int id)
        {
            Pedido pedido = leerPorId(id);


            //eliminar las las lineas de materiales
            IListaMaterialDao listaMaterialDao = new ListaMaterialDaoImpl();
            foreach (ListaDeMateriales unaLinea in pedido.ListaDeMateriales)
            {
                listaMaterialDao.eliminar(unaLinea.idListaDeMateriales);
            }

            //eliminar las lineas de pedido
            ILineaPedidoDao lineaPedidoDao = new LineaPedidoDaoImpl();
            foreach(LineaPedido linea in pedido.lineasDePedido)
            {
                lineaPedidoDao.eliminar(linea.IdLineaPedido);
            }

            //eliminar los y las lineas de costo extra

            String queryLineaCostos = String.Format("delete from linea_costo_extra where pedido_id_pedido = {0};", id);
            db.borrarRegistro(queryLineaCostos);

            string query = string.Format("delete from pedido where id_pedido={0};", 0);
            db.ejectuarQuery(query);
        }

        public Pedido leerPorId(int id)
        {
            string query = string.Format("select * from pedido where id_pedido = {0}", id);

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<Pedido> listarTodos()
        {
            string query = string.Format("select * from pedido");

            List<Pedido> pedidosRegistrados = new List<Pedido>();

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                pedidosRegistrados.Add(parse(unRegistro));
            }

            return pedidosRegistrados;
        }

        public void registrar(Pedido t)
        {
            String query = string.Format("insert into pedido (fecha_pedido, fecha_entrega, estado, importe_total, cliente_id_cliente) values (\'{0}\', \'{1}\', \'{2}\', {3}, {4});",
                t.fechaDePedido.ToShortDateString(),
                t.fechaDeEntrega.ToShortDateString(),
                t.estado,
                t.obtenerTotal().ToString(CultureInfo.InvariantCulture),
                t.cliente.IdCliente);

            db.ejectuarQuery(query);

            int idPedido = listarTodos().Last().idPedido;
            ILineaPedidoDao lineaPedidoDao = new LineaPedidoDaoImpl();

            foreach (LineaPedido linea in t.lineasDePedido)
            {
                linea.IdPedido = idPedido;
                lineaPedidoDao.registrar(linea);
            }

            //registras costos extras

            ICostoExtraDao costoExtraDao = new CostoExtraDaoImpl();
            int idCostoExtra;
            string queryCostos = "";
            foreach (CostoExtra costo in t.costosExtras)
            {
                costoExtraDao.registrar(costo);
                idCostoExtra = costoExtraDao.listarTodos().Last().idCostoExtra;

                queryCostos = string.Format("insert into linea_costo_extra (cantidad, pedido_id_pedido, costo_extra_id_costo_extra) values ({0},{1},{2});",
                   1,
                   idPedido,
                   idCostoExtra);

                db.ejectuarQuery(queryCostos);
            }

            //registra line de materiales
            IListaMaterialDao listaMaterialDao = new ListaMaterialDaoImpl();
            foreach (ListaDeMateriales unaLinea in t.ListaDeMateriales)
            {
                unaLinea.idPedido = idPedido;
                listaMaterialDao.registrar(unaLinea);
            }

        }

        public Pedido parse(List<Object> unRegistro)
        {
            int id_pedido = (int)unRegistro.ElementAt(0);
            DateTime fechaPedido = DateTime.Parse(unRegistro.ElementAt(1).ToString());
            DateTime fechaEntrega = DateTime.Parse(unRegistro.ElementAt(2).ToString());
            string estado = (string)unRegistro.ElementAt(3);
            double importe = Convert.ToDouble(unRegistro.ElementAt(4));
            int idCliente = (int)unRegistro.ElementAt(5);

            IClienteDAO clienteDao = new ClienteDaoImpl();
            Cliente cliente = clienteDao.leerPorId(idCliente);


            Pedido pedido = new Pedido();
            pedido.idPedido = id_pedido;
            pedido.fechaDePedido = fechaPedido;
            pedido.fechaDeEntrega = fechaEntrega;
            pedido.estado = estado;
            pedido.cliente = cliente;


            //lineas de pedido de producto
            ILineaPedidoDao lineaPedidoDao = new LineaPedidoDaoImpl();
            foreach(LineaPedido linea in lineaPedidoDao.listarTodos())
            {
                if (linea.IdPedido == id_pedido)
                {
                    pedido.lineasDePedido.Add(linea);
                }
            }

            String queryLineaCostos = string.Format("select * from linea_costo_extra;");

            //lineas de costos extras
            int idPedidoCostoExtra;
            int idCostoExtra;
            ICostoExtraDao costoExtraDao = new CostoExtraDaoImpl();
            foreach(List<Object> unRegistroCostoExtra in db.consultarQuery(queryLineaCostos))
            {
                idPedidoCostoExtra = (int)unRegistroCostoExtra.ElementAt(2);
                idCostoExtra = (int)unRegistroCostoExtra.ElementAt(3);

                if(id_pedido == idPedidoCostoExtra)
                {
                    CostoExtra costoExtra = costoExtraDao.leerPorId(idCostoExtra);
                    pedido.costosExtras.Add(costoExtra);
                }
            }

            //lineas de materiales necesarios
            IListaMaterialDao listaMaterialDao = new ListaMaterialDaoImpl();
            foreach (ListaDeMateriales unaLinea in listaMaterialDao.listarTodos())
            {
                if (unaLinea.idPedido == id_pedido)
                    pedido.ListaDeMateriales.Add(unaLinea);
            }

            return pedido;
        }
    }
}
