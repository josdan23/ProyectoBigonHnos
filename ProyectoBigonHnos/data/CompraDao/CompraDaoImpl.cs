using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.EmpleadoDao;
using ProyectoBigonHnos.data.ProveedorDao;
using ProyectoBigonHnos.data.TelefonoDaoList;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.CompraDao
{
    class CompraDaoImpl : ICompraDao
    {
        DBConector db;

        public CompraDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Compra t)
        {
            string query = string.Format("update compra set fecha_compra = \'{0}\', importe_total={1}, estado={2}, proveedor_id_proveedor={3}, empleado_id_empleado={4};",
                t.fechaCompra.ToShortDateString(),
                t.obtenerTotal().ToString(CultureInfo.InvariantCulture),
                t.estado,
                t.proveedor.IdProveedor,
                t.empleado.IdEmpleado);
        }

        public void eliminar(int id)
        {
            String query = String.Format("delete from compra where id_compra={0}", id);

            //obtener las lineas de compra
            db.borrarRegistro(query);

            //borrar las lineas de compra
        }

        public Compra leerPorId(int id)
        {
            string query = string.Format("select * from compra where id_compra = {0}", id);

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }
            return null;
        }

        public List<Compra> listarTodos()
        {
            String query = string.Format("select * from compra");

            List<Compra> comprasRegistradas = new List<Compra>();
            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                comprasRegistradas.Add(parse(unRegistro));
            }

            return comprasRegistradas;
        }

        public void registrar(Compra t)
        {
            IProveedorDAO proveedorDao = new ProveedorDaoImpl();
            proveedorDao.registrar(t.proveedor);
            int idProveedor = proveedorDao.listarTodos().Last().IdProveedor;

            IEmpleadoDAO empleadoDao = new EmpleadoDaoImpl();
            empleadoDao.registrar(t.empleado);
            int idEmpleado = empleadoDao.listarTodos().Last().IdEmpleado;


            //falta registrar las lineas de compra

            String query = String.Format("insert into compra (fecha_compra, importe_total, estado, proveedor_id_proveedor, empleado_id_empleado) values (\'{0}\',{1},\'{2}\',{3},{4})",
                t.fechaCompra.ToShortDateString(),
                t.obtenerTotal().ToString(CultureInfo.InvariantCulture),
                t.estado.ToString(),
                idProveedor,
                idEmpleado);

            db.ejectuarQuery(query);
        }

        private Compra parse(List<Object> unRegistro)
        {
            int idCompra = (int)unRegistro.ElementAt(0);
            DateTime fechaCompra = (DateTime) unRegistro.ElementAt(1);

            EstadoCompra estado;
            Enum.TryParse<EstadoCompra>(unRegistro.ElementAt(2).ToString(), true, out estado);

            int idProveedor = (int)unRegistro.ElementAt(3);
            IProveedorDAO proveedorDAO = new ProveedorDaoImpl();
            Proveedor proveedor = proveedorDAO.leerPorId(idProveedor);

            int idEmpleado = (int)unRegistro.ElementAt(4);
            IEmpleadoDAO empleadoDao = new EmpleadoDaoImpl();
            Empleado empleado = empleadoDao.leerPorId(idEmpleado);

            Compra compra = new Compra();
            compra.IdCompra = idCompra;
            compra.fechaCompra = fechaCompra;
            compra.estado = estado;
            compra.empleado = empleado;

            //falta agregar las lineas de compra. 

            return compra;
        }
    }
}
