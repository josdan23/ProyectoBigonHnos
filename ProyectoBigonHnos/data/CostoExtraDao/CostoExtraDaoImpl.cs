using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.pedido;

namespace ProyectoBigonHnos.data.CostoExtraDao
{
    class CostoExtraDaoImpl : ICostoExtraDao
    {

        private DBConector dBConector;

        public CostoExtraDaoImpl()
        {
            dBConector = DBConector.getInstance();
        }

        public void actualizar(CostoExtra t)
        {
            string query = String.Format("update costo_extra set descripcion=\'{0}\', importe={1} where id_costo_extra = {2}", 
                t.descripcion, 
                t.importe.ToString(CultureInfo.InvariantCulture),
                t.idCostoExtra);
            dBConector.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from costo_extra where id_costo_extra = {0};", id);
            dBConector.borrarRegistro(query);
        }

        public CostoExtra leerPorId(int id)
        {
            string query = string.Format("select * from costo_extra where id_costo_extra = {0};", id);

            string descripcion = "";
            double importe = 0;

            foreach (List<Object> unRegistro in dBConector.consultarQuery(query))
            {
                Console.WriteLine("id:" + unRegistro.ElementAt(0));
                Console.WriteLine("descr:" + unRegistro.ElementAt(1));
                Console.WriteLine("importe:" + Convert.ToDouble(unRegistro.ElementAt(2)));
         

                descripcion = (string)unRegistro.ElementAt(1);
                
                importe = Convert.ToDouble(unRegistro.ElementAt(2));
                CostoExtra costoExtra = new CostoExtra(descripcion, importe);
                costoExtra.idCostoExtra = (int)unRegistro.ElementAt(0);

                return costoExtra;
            }

            return null;
        }

        public List<CostoExtra> listarTodos()
        {
            string query = "select * from costo_extra";

            List<CostoExtra> listaCostosExtras = new List<CostoExtra>();

            List<List<Object>> registros = dBConector.consultarQuery(query);

            string descripcion = "";
            double importe = 0;

            foreach(List<Object> unRegistro in registros)
            {

                descripcion = (string)unRegistro.ElementAt(1);
                importe =Convert.ToDouble( unRegistro.ElementAt(2));
                CostoExtra unCostoExtra = new CostoExtra(descripcion, importe);
                unCostoExtra.idCostoExtra = (int)unRegistro.ElementAt(0);
                listaCostosExtras.Add(unCostoExtra);
            }

            return listaCostosExtras;

        }

        public void registrar(CostoExtra t)
        {
            string query = String.Format("insert into costo_extra (descripcion, importe) values (\'{0}\', {1});",
                t.descripcion,
                t.importe.ToString(CultureInfo.InvariantCulture));

            Console.WriteLine(query);

            dBConector.ejectuarQuery(query);
        }
    }
}
