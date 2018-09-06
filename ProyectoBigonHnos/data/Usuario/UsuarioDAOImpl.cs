using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.Usuario
{
    class UsuarioDAOImpl : IUsuarioDAO
    {
        DBConector db;

        public UsuarioDAOImpl()
        {
            db = new DBConector();
        }

        public void actualizar(dominio.Usuario t)
        {
            string query = string.Format("update usuario set nameuser = \'{0}\', password = \'{1}\', es_admin = {2} where id_usuario = {3};",
                t.Username, 
                t.Password,
                t.Administrador == true ? 1:0,
                t.IdUsuario);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from usuario where id_usuario = {0}", id);
            db.ejectuarQuery(query);
        }

        public dominio.Usuario leerPorId(int id)
        {
            string query = string.Format("select * from usuario where id_usuario = {0}", id);

            List<List<Object>> todosLosRegistros = db.consultarQuery(query);

            foreach (List<object> unRegistro in todosLosRegistros)
            {
                return parseUsuario(unRegistro);
            }

            return null;
        }

        public List<dominio.Usuario> listarTodos()
        {
            string query = "select * from usuario;";

            List<List<Object>> todosLosRegistros = db.consultarQuery(query);

            List<dominio.Usuario> todosLosUsuarios = new List<dominio.Usuario>();

            foreach (List<Object> unRegistro in todosLosRegistros)
            {
                todosLosUsuarios.Add(parseUsuario(unRegistro));
            }

            return todosLosUsuarios;
        }

        public void registrar(dominio.Usuario t)
        {
            int admin = t.esAdmin() ? 1 : 0;

            string query = string.Format("insert into usuario (nameuser, password, es_admin) values (\'{0}\', \'{1}\', {2});",
                t.Username,
                t.Password,
                admin);

            db.ejectuarQuery(query);
        }

        private dominio.Usuario parseUsuario(List<Object> registro)
        {
            int idUsuario = (int)registro.ElementAt(0);
            string userName = (string) registro.ElementAt(1);
            string password = (string)registro.ElementAt(2);
            bool esAdmin = (bool) registro.ElementAt(3);

            dominio.Usuario nuevoUsuario = new dominio.Usuario(userName, password, esAdmin);
            nuevoUsuario.IdUsuario  = idUsuario;

            return nuevoUsuario;

        }
    }
}
