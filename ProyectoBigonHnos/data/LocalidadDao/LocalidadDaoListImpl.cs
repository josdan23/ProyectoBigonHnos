
using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.data.LocalidadDao
{
    class LocalidadDaoListImpl : ILocalidadDAO
    {
        private static List<Localidad> todasLasLocalidades = new List<Localidad>();
        private static int idContador = 0;


        public void actualizar(Localidad t)
        {
            for (int i = 0; i < todasLasLocalidades.Count; i++)
            {
                if (todasLasLocalidades.ElementAt(i).IdLocalidad == t.IdLocalidad)
                    todasLasLocalidades[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasLocalidades.Count; i++)
            {
                if (todasLasLocalidades.ElementAt(i).IdLocalidad == id)
                    todasLasLocalidades.RemoveAt(i);
            }
        }

        public Localidad leerPorId(int id)
        {
            for (int i = 0; i < todasLasLocalidades.Count; i++)
            {
                if (todasLasLocalidades.ElementAt(i).IdLocalidad == id)
                    return todasLasLocalidades[i];
            }

            return null;
        }

        public List<Localidad> listarTodos()
        {
            return todasLasLocalidades;
        }

        public void registrar(Localidad t)
        {
            t.IdLocalidad = idContador;
            idContador++;

            todasLasLocalidades.Add(t);
        }
    }
}
