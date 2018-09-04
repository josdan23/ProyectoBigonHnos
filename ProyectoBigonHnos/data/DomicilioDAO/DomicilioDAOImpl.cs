using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.DomicilioDAO
{
    class DomicilioDAOImpl : IDomicilioDAO
    {

        private DBConector db;

        public DomicilioDAOImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Domicilio t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Domicilio leerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domicilio> listarTodos()
        {
            throw new NotImplementedException();
        }

        public void registrar(Domicilio t)
        {

            string query = String.Format("insert into domicilio (calle, numero) values (\'{0}\',{1});", 
                t.Calle,
                t.Numero);

            db.ejectuarQuery(query);

            
        }
    }
}
