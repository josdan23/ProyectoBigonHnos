using System.Collections.Generic;
using System.Linq;

namespace ProyectoBigonHnos.data.UsuarioDao
{
    class UsuarioDaoListImpl : IUsuarioDAO
    {
        static private List<dominio.Usuario> todosLosUsuarios = new List<dominio.Usuario>();
        static private int id = 0;

        public void actualizar(dominio.Usuario t)
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

        public dominio.Usuario leerPorId(int id)
        {
            for ( int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].IdUsuario == id)
                    return todosLosUsuarios.ElementAt(i);
            }

            return null;
        }

        public List<dominio.Usuario> listarTodos()
        {
            return todosLosUsuarios;
        }

        public void registrar(dominio.Usuario t)
        {
            t.IdUsuario = id;

            id++;

            todosLosUsuarios.Add(t);
        }
    }
}
