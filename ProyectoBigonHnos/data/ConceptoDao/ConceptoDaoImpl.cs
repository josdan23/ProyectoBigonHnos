using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.liquidacion;

namespace ProyectoBigonHnos.data.ConceptoDao
{
    class ConceptoDaoImpl:IConceptoDao
    {
        DBConector db;
        private object convertTo;

        public ConceptoDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Concepto t)
        {
            string query = string.Format("update concepto set tipo = \'{0}\', descripcion = \'{1}\', porcentaje = {2}, obligatorio = {3}",
                t.Tipo,
                t.Descripcion,
                t.Porcentaje.ToString(CultureInfo.InvariantCulture),
                t.Obligatorio);
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from concepto where id_concepto = {0}", id);

            db.borrarRegistro(query);
        }

        public Concepto leerPorId(int id)
        {
            String query = String.Format("select * from concepto where id_concepto = {0}", id);

            string descripcion = "";
            double porcentaje = 0;
            bool obligatorio;            

            foreach(List<Object> unRegistro in db.consultarQuery(query)){
                TipoConcepto tipoConcepto;
                if (Enum.TryParse<TipoConcepto>(unRegistro.ElementAt(1).ToString(), true, out tipoConcepto))
                {
                    descripcion = (string)unRegistro.ElementAt(2);
                    porcentaje = Convert.ToDouble(unRegistro.ElementAt(3));
                    obligatorio = Convert.ToBoolean(unRegistro.ElementAt(4));

                    Concepto concepto = new Concepto(tipoConcepto, descripcion, porcentaje, obligatorio);
                    concepto.IdConcepto = (int)unRegistro.ElementAt(0);

                    return concepto;
                }
                else
                    return null;

                
            }

            return null;
        }

        public List<Concepto> listarTodos()
        {
            string query = "select * from concepto";

            List<Concepto> listaDeConceptosRegistrados = new List<Concepto>();

            string descripcion = "";
            double porcentaje = 0;
            bool obligatorio;

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                TipoConcepto tipoConcepto;
                if (Enum.TryParse<TipoConcepto>(unRegistro.ElementAt(1).ToString(), true, out tipoConcepto))
                {
                    descripcion = (string)unRegistro.ElementAt(2);
                    porcentaje = Convert.ToDouble(unRegistro.ElementAt(3));
                    obligatorio = Convert.ToBoolean(unRegistro.ElementAt(4));

                    Concepto concepto = new Concepto(tipoConcepto, descripcion, porcentaje, obligatorio);
                    concepto.IdConcepto = (int)unRegistro.ElementAt(0);

                    listaDeConceptosRegistrados.Add(concepto);
                }
                else
                    return null;
            }

            return listaDeConceptosRegistrados;
        }

        public void registrar(Concepto t)
        {

            string query = string.Format("insert into concepto (tipo, descripcion,porcentaje, obligatorio) values (\'{0}\', \'{1}\', {2}, \'{3}\');",
                t.Tipo,
                t.Descripcion,
                t.Porcentaje.ToString(CultureInfo.InvariantCulture),
                t.Obligatorio);

            db.ejectuarQuery(query);
        }
    }
}
