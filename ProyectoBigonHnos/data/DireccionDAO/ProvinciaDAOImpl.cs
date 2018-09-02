using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.DomicilioDAO
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
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Provincia leerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Provincia> listarTodos()
        {
            throw new NotImplementedException();
        }

        public void registrar(Provincia t)
        {
            string query = String.Format("insert into provincia (nombre)");

            db.ejectuarQuery(query);
        }
    }
}
