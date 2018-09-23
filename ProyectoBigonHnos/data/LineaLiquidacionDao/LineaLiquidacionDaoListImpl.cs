using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.liquidacion;

namespace ProyectoBigonHnos.data.LineaLiquidacionDao
{
    class LineaLiquidacionDaoListImpl : ILineaLiquidacionDao
    {
        private static List<LineaLiquidacion> todasLasLineasLiquidacion = new List<LineaLiquidacion>();
        private static int IdContador = 0;

        public void actualizar(LineaLiquidacion t)
        {
            for (int i = 0; i < todasLasLineasLiquidacion.Count; i++)
            {
                if (todasLasLineasLiquidacion.ElementAt(i).IdLineaLiquidacion == t.IdLineaLiquidacion)
                    todasLasLineasLiquidacion[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasLineasLiquidacion.Count; i++)
            {
                if (todasLasLineasLiquidacion.ElementAt(i).IdLineaLiquidacion == id)
                    todasLasLineasLiquidacion.RemoveAt(i);
            }
        }

        public LineaLiquidacion leerPorId(int id)
        {
            for ( int i = 0; i < todasLasLineasLiquidacion.Count; i++)
            {
                if (todasLasLineasLiquidacion.ElementAt(i).IdLineaLiquidacion == id)
                    return todasLasLineasLiquidacion.ElementAt(i);
            }

            return null;
        }

        public List<LineaLiquidacion> listarTodos()
        {
            return todasLasLineasLiquidacion;
        }

        public void registrar(LineaLiquidacion t)
        {
            t.IdLineaLiquidacion = IdContador;
            IdContador++;

            todasLasLineasLiquidacion.Add(t);
        }
    }
}
