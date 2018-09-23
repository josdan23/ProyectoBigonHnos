using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.GrupoFamiliarDao
{
    class GrupoFamiliarDaoListImpl : IGrupoFamiliarDao
    {
        private static List<GrupoFamiliar> todosLosFamiliares = new List<GrupoFamiliar>();
        private static int IdContador = 0;

        public void actualizar(GrupoFamiliar t)
        {
            for (int i = 0; i < todosLosFamiliares.Count; i++)
            {
                if (todosLosFamiliares.ElementAt(i).IdGrupoFamiliar == t.IdGrupoFamiliar)
                    todosLosFamiliares[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosFamiliares.Count; i++)
            {
                if (todosLosFamiliares.ElementAt(i).IdGrupoFamiliar == id)
                    todosLosFamiliares.RemoveAt(i);
            }
        }

        public GrupoFamiliar leerPorId(int id)
        {
            for ( int i = 0; i < todosLosFamiliares.Count; i++)
            {
                if (todosLosFamiliares.ElementAt(i).IdGrupoFamiliar == id)
                    return todosLosFamiliares.ElementAt(i);
            }

            return null;
        }

        public List<GrupoFamiliar> listarTodos()
        {
            return todosLosFamiliares;
        }

        public void registrar(GrupoFamiliar t)
        {
            t.IdGrupoFamiliar = IdContador;

            IdContador++;

            todosLosFamiliares.Add(t);
        }
    }
}
