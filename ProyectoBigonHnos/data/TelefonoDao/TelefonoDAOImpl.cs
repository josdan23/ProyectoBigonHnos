using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.TelefonoDao
{
    class TelefonoDAOImpl : ITelefonoDao
    {
        private DBConector db;

        public TelefonoDAOImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Telefono t)
        {
            string query = String.Format("update telefono set numero=\'{0}\' where id_telefono = {1}", t.Numero, t.IdTelefono);
            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            string query = String.Format("delete from telefono where id_telefono = {0};", id);

            db.borrarRegistro(query);
        }

        public Telefono leerPorId(int id)
        {
            string query = String.Format("select * from telefono where id_telefono = {0};", id);

            List<List<Object>> registro = db.consultarQuery(query);
            
            foreach (List<Object> lista in registro)
            {
                Telefono telefono = new Telefono();
                telefono.Numero = (string)lista.ElementAt(1);
                telefono.IdTelefono = (int)lista.ElementAt(0);
                return telefono;
            }
            return null;
        }

        public List<Telefono> listarTodos()
        {
            string query = "select *  from telefono;";

            List<Telefono> todosLosTelefonosRegistrados = new List<Telefono>();

            List<List<Object>> registro = db.consultarQuery(query);

            foreach (List<Object> lista in registro)
            {
                Telefono telefono = new Telefono();
                telefono.IdTelefono = (int)lista.ElementAt(0);
                telefono.Numero = (string)lista.ElementAt(1);

                todosLosTelefonosRegistrados.Add( telefono);
            }
            return todosLosTelefonosRegistrados;

        }

        public void registrar(Telefono t)
        {
            string query = String.Format("insert into telefono (numero) values (\'{0}\');", t.Numero);
            db.ejectuarQuery(query);
        }
    }
}
