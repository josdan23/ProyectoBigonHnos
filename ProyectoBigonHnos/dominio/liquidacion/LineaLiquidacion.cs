using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class LineaLiquidacion
    {
        //int IdLineaLiquidacion { get; set; }
        public double Cantidad { get; set; }
        public Concepto Concepto { get; set; }

        public LineaLiquidacion(int cantidad, Concepto concepto)
        {
            Cantidad = cantidad;
            Concepto = concepto;
        }


    }
}
