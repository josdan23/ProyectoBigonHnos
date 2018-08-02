using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class Liquidacion
    {
        //int IdLiquidacion { get; set; }
        public int PeriodoLiquidacion { get; set; }
        public string LugarPago { get; set; }
        public double Total { get; set;}
        public Empleado Empleado { get; set; }
        public List<LineaLiquidacion> LineasLiquidacion { get; set; }

        double SueldoBasico { get; set; }

        public Liquidacion(Empleado empleado, int periodo, string lugarPago, double sueldoBasico)
        {
            Empleado = empleado;
            PeriodoLiquidacion = periodo;
            LugarPago = lugarPago;
            SueldoBasico = sueldoBasico;

            Total = 0.0;
            LineasLiquidacion = new List<LineaLiquidacion>();
        }

        public Liquidacion(Empleado empleado, int periodo, string lugarPago)
        {
            Empleado = empleado;
            PeriodoLiquidacion = periodo;
            LugarPago = lugarPago;

            Total = 0.0;
            LineasLiquidacion = new List<LineaLiquidacion>();
        }

        public void agregarLineaLiquidacion(int cantidad, Concepto concepto)
        {
            LineasLiquidacion.Add(new LineaLiquidacion(cantidad, concepto));
        }

        public double getTotal()
        {
            return Total; //recorrer todas las lineas para sumar y restar el sueldo total
        }

        public double getTotalRemunerativo()
        {
            return 0.0; //retornar el total de remunerativo
        }

        public double getTotalNoRemunerativo()
        {
            return 0.0;  //retornar el total de no remunerativo
        }

        public double getTotalDescuento()
        {
            return 0.0;  //retornar el total del descuento
        }

    }
}