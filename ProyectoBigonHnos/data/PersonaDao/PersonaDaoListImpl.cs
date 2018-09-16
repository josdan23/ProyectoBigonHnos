using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.PersonaDao
{
    class PersonaDaoListImpl : IPersonaDAO
    {
        private static List<Persona> todasLasPersonas = new List<Persona>();
        private static int IdContador = 0;

        public void actualizar(Persona t)
        {
            for (int i = 0; i < todasLasPersonas.Count; i++)
            {
                if (todasLasPersonas.ElementAt(i).IdPersona == t.IdPersona)
                    todasLasPersonas[i] = t;
            }

        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasPersonas.Count; i++)
            {
                if (todasLasPersonas.ElementAt(i).IdPersona == id)
                    todasLasPersonas.RemoveAt(i);
            }

        }

        public Persona leerPorId(int id)
        {
            for ( int i = 0; i < todasLasPersonas.Count; i++)
            {
                if (todasLasPersonas.ElementAt(i).IdPersona == id)
                    return todasLasPersonas.ElementAt(i);
            }

            return null;
        }

        public List<Persona> listarTodos()
        {
            return todasLasPersonas;
        }

        public void registrar(Persona t)
        {
            t.IdPersona = IdContador;
            IdContador++;

            todasLasPersonas.Add(t);
        }
    }
}
