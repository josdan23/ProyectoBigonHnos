using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.data.PersonaDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.UsuarioDao
{
    class UsuarioDaoListImpl : IUsuarioDAO
    {
        static private List<Usuario> todosLosUsuarios = new List<Usuario>();
        static private int id = 0;

        public void actualizar(Usuario t)
        {
            for (int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].IdUsuario == t.IdUsuario)
                    todosLosUsuarios[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for ( int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].IdUsuario == id)
                    todosLosUsuarios.RemoveAt(i);
            }
        }

        public Usuario leerPorId(int id)
        {
            for ( int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].IdUsuario == id)
                    return todosLosUsuarios.ElementAt(i);
            }

            return null;
        }

        public List<Usuario> listarTodos()
        {
            return todosLosUsuarios;
        }

        public void registrar(Usuario t)
        {
          
            t.IdUsuario = id;

            id++;

            todosLosUsuarios.Add(t);

        }
    }
}
