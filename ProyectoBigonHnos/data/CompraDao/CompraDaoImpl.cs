using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.EmpleadoDao;
using ProyectoBigonHnos.data.LineaCompraDao;
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
            ILineaCompraDao lineaCompraDao = new LineaCompraDaoImpl();
            foreach(LineaCompra lc in t.lineasDeCompra)
            {
                lineaCompraDao.actualizar(lc);
            }


            string query = string.Format("update compra set fecha_compra = \'{0}\', importe_total={1}, estado=\'{2}\', proveedor_id_proveedor={3}, empleado_id_empleado={4} where id_compra = {5};",
                t.fechaCompra.ToShortDateString(),
                t.obtenerTotal().ToString(CultureInfo.InvariantCulture),
                t.estado,
                t.proveedor.IdProveedor,
                t.empleado.IdEmpleado,
                t.IdCompra);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            Compra compraRegistrada = leerPorId(id);

            foreach(LineaCompra lc in compraRegistrada.lineasDeCompra)
            {
                ILineaCompraDao lineaCompraDao = new LineaCompraDaoImpl();
                lineaCompraDao.eliminar(lc.IdLineaCompra);
            }

            String query = String.Format("delete from compra where id_compra={0}", id);
            db.borrarRegistro(query);

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
  
            String query = String.Format("insert into compra (fecha_compra, importe_total, estado, proveedor_id_proveedor, empleado_id_empleado) values (\'{0}\',{1},\'{2}\',{3},{4})",
                t.fechaCompra.ToShortDateString(),
                t.obtenerTotal().ToString(CultureInfo.InvariantCulture),
                t.estado.ToString(),
                t.proveedor.IdProveedor,
                t.empleado.IdEmpleado);

    
            db.ejectuarQuery(query);

            //Compra compra = listarTodos().Last();
     
            ILineaCompraDao lineaCompraDao = new LineaCompraDaoImpl();
            int idCompraRegistrada = obtenerIndexDelUltimoAgregado();
            foreach(LineaCompra lc in t.lineasDeCompra)
            {
                lc.IdCompra = idCompraRegistrada;
                
                lineaCompraDao.registrar(lc);
                

            }
        }

        private Compra parse(List<Object> unRegistro)
        {
            int idCompra = (int)unRegistro.ElementAt(0);
            DateTime fechaCompra = (DateTime) unRegistro.ElementAt(1);

            double total = Convert.ToDouble(unRegistro.ElementAt(2));

            EstadoCompra estado;
            Enum.TryParse<EstadoCompra>(unRegistro.ElementAt(3).ToString(), true, out estado);

            int idProveedor = (int)unRegistro.ElementAt(4);
            IProveedorDAO proveedorDAO = new ProveedorDaoImpl();
            Proveedor proveedor = proveedorDAO.leerPorId(idProveedor);

            int idEmpleado = (int)unRegistro.ElementAt(5);
            
            IEmpleadoDAO empleadoDao = new EmpleadoDaoImpl();
            Empleado empleado = empleadoDao.leerPorId(idEmpleado);
           
            Compra compra = new Compra();
            compra.IdCompra = idCompra;
            compra.fechaCompra = fechaCompra;
            compra.estado = estado;
            compra.agregarEmpleado(empleado);
            compra.agregarProveedor(proveedor);


            //falta agregar las lineas de compra. 

            ILineaCompraDao lineaCompraDao = new LineaCompraDaoImpl();
            List<LineaCompra> lineasComprasRegistradasParaUnaVenta = new List<LineaCompra>();
            foreach(LineaCompra lc in lineaCompraDao.listarTodos())
            {
                
                if (lc.IdCompra == compra.IdCompra)
                {
                    LineaCompra lineaCompra = new LineaCompra();

                    lineaCompra.material = lc.material;
                    lineaCompra.cantidad = lc.cantidad;
                    lineaCompra.IdLineaCompra = lc.IdLineaCompra;
                    lineaCompra.IdCompra = lc.IdCompra;

                    lineasComprasRegistradasParaUnaVenta.Add(lineaCompra);
                    
                    Console.WriteLine(lineaCompra.IdLineaCompra);
                }
                    
            }

            compra.lineasDeCompra = lineasComprasRegistradasParaUnaVenta;
            //Console.WriteLine(compra.lineasDeCompra.Last().material.Descripcion);
            return compra;
        }

        private int obtenerIndexDelUltimoAgregado()
        {
            String query = string.Format("select * from compra");

            return (int) db.consultarQuery(query).Last().ElementAt(0);
        }
    }
}
