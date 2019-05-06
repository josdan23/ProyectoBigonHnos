using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.ConceptoDao;
using ProyectoBigonHnos.data.LiquidacionDao;
using ProyectoBigonHnos.dominio.liquidacion;

namespace ProyectoBigonHnos.data.LineaLiquidacionDao
{
    class LineaLiquidacionDaoImpl : ILineaLiquidacionDao
    {
        DBConector db;

        public LineaLiquidacionDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(LineaLiquidacion t)
        {
            double remunerativo = 0;
            double noRemunerativo = 0;
            double descuento = 0;
            if (t.Concepto.Tipo == TipoConcepto.REMUNERATIVO)
            {
                remunerativo = t.getImporte();
            }
            else if (t.Concepto.Tipo == TipoConcepto.NO_REMUNERATIVO)
            {
                noRemunerativo = t.getImporte();
            }
            else if (t.Concepto.Tipo == TipoConcepto.DESCUENTO)
            {
                descuento = t.getImporte();
            }

            string query = string.Format("update linea_liquidacion set descripcion= \'{0}\', cantidad = {1}, monto={2}, remuneracion={3}, no_remuneracion={4}, descuento={5}, liquidacion_id_liquidacion={6}, concepto_id_concepto={7} where id_linea_liquidacion={8};",
                t.Concepto.Descripcion,
                t.Cantidad,
                t.ValorBase,
                remunerativo,
                noRemunerativo,
                descuento,
                t.idLiquidacion,
                t.Concepto.IdConcepto,
                t.IdLineaLiquidacion);

            db.ejectuarQuery(query);

 
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from linea_liquidacion where id_linea_liquidacion={0}", id);
            db.borrarRegistro(query);
        }

        public LineaLiquidacion leerPorId(int id)
        {
            string query = string.Format("select * from liquidacion where id_liquidacion= {0}",id);

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<LineaLiquidacion> listarTodos()
        {
            string query = string.Format("select * from linea_liquidacion");

            List<LineaLiquidacion> lineasRegistradas = new List<LineaLiquidacion>();
            
            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                lineasRegistradas.Add(parse(unRegistro));
            }

            return lineasRegistradas;
        }

        public void registrar(LineaLiquidacion t)
        {
            double remunerativo = 0;
            double noRemunerativo = 0;
            double descuento = 0;
            if (t.Concepto.Tipo == TipoConcepto.REMUNERATIVO)
            {
                remunerativo = t.getImporte();
            }
            else if(t.Concepto.Tipo == TipoConcepto.NO_REMUNERATIVO)
            {
                noRemunerativo = t.getImporte();
            }
            else if(t.Concepto.Tipo == TipoConcepto.DESCUENTO)
            {
                descuento = t.getImporte();
            }

            string query = string.Format("insert into linea_liquidacion (descripcion, cantidad, monto, remuneracion, no_remuneracion, descuento, liquidacion_id_liquidacion, concepto_id_concepto) values (\'{0}\', {1}, {2}, {3},{4},{5},{6}, {7});",
                t.Concepto.Descripcion,
                t.Cantidad,
                t.ValorBase.ToString(CultureInfo.InvariantCulture),
                remunerativo.ToString(CultureInfo.InvariantCulture),
                noRemunerativo.ToString(CultureInfo.InvariantCulture),
                descuento.ToString(CultureInfo.InvariantCulture),
                t.idLiquidacion,
                t.Concepto.IdConcepto);

            db.ejectuarQuery(query);
        }

        private LineaLiquidacion parse(List<Object> unRegistro)
        {
            int idLineaLiquidacion = (int)unRegistro.ElementAt(0);
            string descripcion = (string)unRegistro.ElementAt(1);
            //int cantidad = (int)unRegistro.ElementAt(2);
            int cantidad = int.Parse(unRegistro.ElementAt(2).ToString());
            double monto = Convert.ToDouble(unRegistro.ElementAt(3));
            double remuneracion = Convert.ToDouble(unRegistro.ElementAt(4));
            double noRemuneracion = Convert.ToDouble(unRegistro.ElementAt(5));
            double descuento = Convert.ToDouble(unRegistro.ElementAt(6));
            int idLiquidacion = (int)unRegistro.ElementAt(7);
            int idConcepto = (int)unRegistro.ElementAt(8);

            IConceptoDao conceptoDao = new ConceptoDaoImpl();
            Concepto concepto = conceptoDao.leerPorId(idConcepto);

            LineaLiquidacion lineaLiquidacion = new LineaLiquidacion(cantidad, concepto, monto);
            lineaLiquidacion.IdLineaLiquidacion = idLineaLiquidacion;
            lineaLiquidacion.idLiquidacion = idLiquidacion;

            return lineaLiquidacion;
        }
    }
}
