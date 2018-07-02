using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class Liquidacion
    {
        int IdLiquidacion { get; set; }
        int PeriodoLiquidacion { get; set; }
        string LugarPago { get; set; }
        double Total { get; set;}
        Empleado Empleado { get; set; }

        List<LineaLiquidacion> LineasLiquidacion { get; set; }

        public Liquidacion()
        {
            LineasLiquidacion = new List<LineaLiquidacion>();
        }

        public void agregarLineaLiquidacion(LineaLiquidacion nuevaLinea)
        {
            LineasLiquidacion.Add(nuevaLinea);
        }



    }
}
