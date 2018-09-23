using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class LineaLiquidacion
    {
        public int IdLineaLiquidacion { get; set; }
        public double Cantidad { get; set; }
        public Concepto Concepto { get; set; }
        public double ValorBase { get; set; }

        public LineaLiquidacion(int cantidad, Concepto concepto, double valor)
        {
            Cantidad = cantidad;
            Concepto = concepto;
            ValorBase = valor;
        }

        public double getImporte()
        {
            if (Cantidad != 0)
                return Cantidad * Concepto.aplicarPorcentaje(ValorBase);

            return Concepto.aplicarPorcentaje(ValorBase);
        }

        public override string ToString()
        {
            return string.Format("LL\tCONC: {0,-20}\ttConc: {1}\tCANT: {2}\tVALBSE: {3}\tIMPORTE:{4}",
                Concepto.Descripcion,
                Concepto.Tipo,
                Cantidad,
                ValorBase, 
                getImporte());
        }
    }
}
