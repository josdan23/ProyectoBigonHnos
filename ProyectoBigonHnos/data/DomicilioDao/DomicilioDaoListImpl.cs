
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.DomicilioDao
{
    class DomicilioDaoListImpl : IDomicilioDAO
    {
        private static List<Domicilio> todosLosDomicilios = new List<Domicilio>();
        private static int IdContador = 0;

        public void actualizar(Domicilio t)
        {
            for (int i = 0; i < todosLosDomicilios.Count; i++)
            {
                if (todosLosDomicilios[i].IdDomicilio == t.IdDomicilio)
                {
                    todosLosDomicilios[i] = t;
                }
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todosLosDomicilios.Count; i++)
            {
                if (todosLosDomicilios[i].IdDomicilio == id)
                {
                    todosLosDomicilios.RemoveAt(i);
                }
            }
        }

        public Domicilio leerPorId(int id)
        {
            for (int i = 0; i < todosLosDomicilios.Count; i++)
            {
                if (todosLosDomicilios[i].IdDomicilio == id)
                {
                    return todosLosDomicilios.ElementAt(i);
                }
            }

            return null;
        }

        public List<Domicilio> listarTodos()
        {
            return todosLosDomicilios;
        }

        public void registrar(Domicilio t)
        {
            t.IdDomicilio = IdContador;
            IdContador++;

            todosLosDomicilios.Add(t);

        }
    }
}
