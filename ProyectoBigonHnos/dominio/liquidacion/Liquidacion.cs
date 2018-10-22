using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    public class Liquidacion
    {
        public int IdLiquidacion { get; set; }
        public int PeriodoLiquidacion { get; set; }
        public string LugarPago { get; set; }
        public Empleado Empleado { get; set; }
        public List<LineaLiquidacion> LineasLiquidacion { get; set; }

        public Liquidacion()
        {
            LineasLiquidacion = new List<LineaLiquidacion>();
        }

        public Liquidacion(Empleado empleado, int periodo, string lugarPago)
        {
            Empleado = empleado;
            PeriodoLiquidacion = periodo;
            LugarPago = lugarPago;
            LineasLiquidacion = new List<LineaLiquidacion>();
        }

        public void agregarLineaLiquidacion(int cantidad, Concepto concepto, double valorBase)
        {
            LineasLiquidacion.Add(new LineaLiquidacion(cantidad, concepto, valorBase));
        }

        public double GetImporteTotal()
        {
            var totalRemunerativo = getTotalRemunerativo();
            var totalNoRemunerativo = getTotalNoRemunerativo();
            var totalDescuento = getTotalDescuento();

            var total = totalRemunerativo + totalNoRemunerativo - totalDescuento;
            return total; //recorrer todas las lineas para sumar y restar el sueldo total
        }

        public double getTotalRemunerativo()
        {
            var totalRemunerativo = 0.0;
            foreach (LineaLiquidacion linea in LineasLiquidacion)
            {
                if (linea.Concepto.Tipo == TipoConcepto.REMUNERATIVO)
                    totalRemunerativo = totalRemunerativo + linea.getImporte();
            }
            return totalRemunerativo;
        }

        public double getTotalNoRemunerativo()
        {
            var totalNoRemunerativo = 0.0;
            foreach (LineaLiquidacion linea in LineasLiquidacion)
            {
                if (linea.Concepto.Tipo == TipoConcepto.NO_REMUNERATIVO)
                    totalNoRemunerativo = totalNoRemunerativo + linea.getImporte();
            }
            return totalNoRemunerativo;
        }

        public double getTotalDescuento()
        {
            var totalDescuento = 0.0;
            foreach (LineaLiquidacion linea in LineasLiquidacion)
            {
                if (linea.Concepto.Tipo == TipoConcepto.DESCUENTO)
                    totalDescuento = totalDescuento + linea.getImporte();
            }
            return totalDescuento;
        }

        public void Imprimir() { 
        
            Console.WriteLine("---------------------------");
            Console.WriteLine("Empleado: \t{0},{1} - {2}", Empleado.Apellido, Empleado.Nombre, Empleado.Dni);
            Console.WriteLine("Lugar de pago: \t{0}", LugarPago);
            Console.WriteLine("Periodo: \t{0}\n", PeriodoLiquidacion);

            Console.WriteLine("DETALLE");
            Console.WriteLine("+++++++++++++++++++++++++++");

            foreach (LineaLiquidacion linea in LineasLiquidacion)
            {
                Console.WriteLine(linea.ToString());
            }

            Console.WriteLine("\nTotal Remunerativo: \t{0}",getTotalRemunerativo());
            Console.WriteLine("Total No Remunerativo:\t{0}", getTotalNoRemunerativo());
            Console.WriteLine("Total Descuento:\t{0}", getTotalDescuento());
        }
    }
}