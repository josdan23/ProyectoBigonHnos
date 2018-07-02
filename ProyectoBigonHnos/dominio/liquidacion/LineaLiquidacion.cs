using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class LineaLiquidacion
    {
        int IdLineaLiquidacion { get; set; }
        string DescripcionConcepto { get; set; }
        string Cantidad { get; set; }
        int Remuneracion { get; set; }
        int NoRemuneracion { get; set; }
        int Descuento { get; set; }

        Concepto Concepto { get; set; }


    }
}
