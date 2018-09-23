using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.liquidacion;

namespace ProyectoBigonHnos.data.ConceptoDao
{
    class ConceptoDaoListImpl : IConceptoDao
    {
        private static List<Concepto> todosLosConceptos = new List<Concepto>();
        private static int IdContador = 0;

        public void actualizar(Concepto t)
        {
            for ( int i = 0; i < todosLosConceptos.Count; i++)
            {
                if (todosLosConceptos.ElementAt(i).IdConcepto == t.IdConcepto)
                    todosLosConceptos[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for ( int i = 0; i < todosLosConceptos.Count; i++)
            {
                if (todosLosConceptos.ElementAt(i).IdConcepto == id)
                    todosLosConceptos.RemoveAt(i);
            }
        }

        public Concepto leerPorId(int id)
        {
            for ( int i = 0; i < todosLosConceptos.Count; i++)
            {
                if (todosLosConceptos.ElementAt(i).IdConcepto == id)
                    return todosLosConceptos.ElementAt(i);
            }

            return null;
        }

        public List<Concepto> listarTodos()
        {
            return todosLosConceptos;
        }

        public void registrar(Concepto t)
        {
            t.IdConcepto = IdContador;

            IdContador++;
            todosLosConceptos.Add(t);
        }
    }
}
