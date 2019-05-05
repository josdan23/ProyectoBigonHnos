using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.TelefonoDaoList
{
    class TelefonoDaoListImpl : ITelefonoDao
    {
        static private List<Telefono> todosLosTelefonos = new List<Telefono>();
        static private int id = 0;

        public void actualizar(Telefono t)
        {
            for (int i = 0; i < todosLosTelefonos.Count; i++)
            {
                if (todosLosTelefonos[i].IdTelefono == t.IdTelefono)
                    todosLosTelefonos[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosTelefonos.Count; i++)
            {
                if (todosLosTelefonos[i].IdTelefono == id)
                    todosLosTelefonos.RemoveAt(i);
            }

            Console.WriteLine("telefono eliminado");
        }

        public Telefono leerPorId(int id)
        {
            for (int i = 0; i < todosLosTelefonos.Count; i++)
            {
                if (todosLosTelefonos[i].IdTelefono == id)
                    return todosLosTelefonos.ElementAt(i);
            }

            return null;
        }

        public List<Telefono> listarTodos()
        {
            return todosLosTelefonos;
        }

        public void registrar(Telefono t)
        {
            t.IdTelefono = id;
            id++;

            todosLosTelefonos.Add(t);

            Console.WriteLine("telefono registrado");
        }

        
            
    }
}
