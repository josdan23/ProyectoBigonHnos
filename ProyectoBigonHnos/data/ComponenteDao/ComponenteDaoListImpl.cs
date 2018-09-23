using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ComponenteDao
{
    class ComponenteDaoListImpl : IComponenteDao
    {
        private static List<Componente> todosLosComponentes = new List<Componente>();
        private static int IdContador = 0;


        public void actualizar(Componente t)
        {
            for (int i = 0; i < todosLosComponentes.Count; i++)
            {
                if (todosLosComponentes.ElementAt(i).IdComponente == t.IdComponente)
                    todosLosComponentes[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosComponentes.Count; i++)
            {
                if (todosLosComponentes.ElementAt(i).IdComponente == id)
                    todosLosComponentes.RemoveAt(i);
            }
        }

        public Componente leerPorId(int id)
        {
            for (int i = 0; i < todosLosComponentes.Count; i++)
            {
                if ( todosLosComponentes.ElementAt(i).IdComponente == id)
                {
                    return todosLosComponentes.ElementAt(i);
                }
            }

            return null;
        }

        public List<Componente> listarTodos()
        {
            return todosLosComponentes;
        }

        public void registrar(Componente t)
        {
            t.IdComponente = IdContador;
            IdContador++;
            todosLosComponentes.Add(t);
        }
    }
}
