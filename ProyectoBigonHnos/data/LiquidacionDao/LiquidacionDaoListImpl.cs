using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio.liquidacion;

namespace ProyectoBigonHnos.data.LiquidacionDao
{
    class LiquidacionDaoListImpl : ILiquidacionDao
    {
        private static List<Liquidacion> todasLasLineasLiquidacion = new List<Liquidacion>();
        private static int IdContador = 0;

        public void actualizar(Liquidacion t)
        {
            for (int i = 0; i < todasLasLineasLiquidacion.Count; i++)
            {
                if (todasLasLineasLiquidacion.ElementAt(i).IdLiquidacion == t.IdLiquidacion)
                    todasLasLineasLiquidacion[i] = t;
            }
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < todasLasLineasLiquidacion.Count; i++)
            {
                if (todasLasLineasLiquidacion.ElementAt(i).IdLiquidacion == id)
                    todasLasLineasLiquidacion.RemoveAt(i);
            }
        }

        public Liquidacion leerPorId(int id)
        {
            for ( int i = 0; i < todasLasLineasLiquidacion.Count; i++)
            {
                if (todasLasLineasLiquidacion.ElementAt(i).IdLiquidacion == id)
                    return todasLasLineasLiquidacion.ElementAt(i);
            }

            return null;
        }

        public List<Liquidacion> listarTodos()
        {
            return todasLasLineasLiquidacion;
        }

        public void registrar(Liquidacion t)
        {
            t.IdLiquidacion = IdContador;
            IdContador++;

            todasLasLineasLiquidacion.Add(t);
        }
    }
}
