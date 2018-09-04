using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ProvinciaDAO
{
    class ProvinciaDAOImpl : IProvinciaDAO
    {
        private DBConector db;


        public ProvinciaDAOImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Provincia t)
        {
            string query = string.Format("update provincia set nombre = \'{0}\' where id_provincia = {1};", t.Nombre, t.IdProvincia);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from provincia where id_provincia = {0};", id);

            db.borrarRegistro(query);
        }

        public Provincia leerPorId(int id)
        {
            string query = string.Format("select * from provincia where id_provincia = {0};", id);

            Provincia p = new Provincia();

            foreach (List<Object> l in db.consultarQuery(query))
            {
                p.IdProvincia = (int) l.ElementAt(0);
                p.Nombre = (string) l.ElementAt(1);
                break;
            }

            return p;
        }

        public List<Provincia> listarTodos()
        {
            string query = String.Format("select * from provincia");

            List<List<object>> registros = db.consultarQuery(query);

            List<Provincia> todasLasProvincias = new List<Provincia>();

            foreach(List<Object> list in registros)
            {
                Provincia p = new Provincia();
                p.IdProvincia = (int)list.ElementAt(0);
                p.Nombre = (string) list.ElementAt(1);

                todasLasProvincias.Add(p);
            }

            return todasLasProvincias;
        }

        public void registrar(Provincia t)
        {
            string query = String.Format("insert into provincia (nombre) values (\'{0}\');", t.Nombre);

            db.ejectuarQuery(query);
        }
    }
}
