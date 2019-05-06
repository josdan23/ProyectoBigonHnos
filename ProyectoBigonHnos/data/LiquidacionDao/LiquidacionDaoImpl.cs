using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.EmpleadoDao;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.liquidacion;

namespace ProyectoBigonHnos.data.LiquidacionDao
{
    class LiquidacionDaoImpl : ILiquidacionDao
    {
        DBConector db;

        public LiquidacionDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Liquidacion t)
        {
            string query = String.Format("update liquidacion set periodo={0}, lugar_pago=\'{1}\', total={2}, empleado_id_empleado={3} where id_liquidacion={4};",
                t.PeriodoLiquidacion,
                t.LugarPago,
                t.GetImporteTotal().ToString(CultureInfo.InvariantCulture),
                t.Empleado.IdEmpleado,
                t.IdLiquidacion);

            db.ejectuarQuery(query);

            //actualizar las lineas de liquidacion

        }

        public void eliminar(int id)
        {
            String query = String.Format("delete from liquidacion where id_liquidacion={0};", id);
            db.borrarRegistro(query);

            //eliminar las lineas de liquidacion
        }

        public Liquidacion leerPorId(int id)
        {
            String query = String.Format("select * from liquidacion where id_liquidacion = {0};", id);
            
            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<Liquidacion> listarTodos()
        {
            String query = String.Format("select * from liquidacion");

            List<Liquidacion> liquidacionRegistradas = new List<Liquidacion>();

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                liquidacionRegistradas.Add(parse(unRegistro));
            }
            return liquidacionRegistradas;
        }

        public void registrar(Liquidacion t)
        {
            string query = String.Format("insert into liquidacion (periodo, lugar_pago, total, empleado_id_empleado) values ({0},\'{1}\', {2}, {3});",
                t.PeriodoLiquidacion,
                t.LugarPago,
                t.GetImporteTotal(),
                t.Empleado.IdEmpleado);

            db.ejectuarQuery(query);

            //registrar las lineas de liquidacion
        }

        private Liquidacion parse(List<Object> unRegistro)
        {
            int idLiquidacion = (int)unRegistro.ElementAt(0);
            int periodo = (int)unRegistro.ElementAt(1);
            String lugarPago = (String)unRegistro.ElementAt(2);
            double total = Convert.ToDouble(unRegistro.ElementAt(3));
            int idEmpleado = (int)unRegistro.ElementAt(4);

            IEmpleadoDAO empleadoDao = new EmpleadoDaoImpl();
            Empleado empleado = empleadoDao.leerPorId(idEmpleado);
            Liquidacion liquidacion = new Liquidacion(empleado, periodo, lugarPago);
            liquidacion.IdLiquidacion = idLiquidacion;


            //agregar las lineas de liquidacion
            return liquidacion;
        }
    }
}
