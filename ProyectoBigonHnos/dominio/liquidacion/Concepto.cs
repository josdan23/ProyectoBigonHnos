using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class Concepto
    {
        public int IdConcepto { get; set; }
        string Tipo { get; set; }
        string Descripcion { get; set; }
        double Cantidad { get; set; }
        bool Obligatorio { get; set; }

        public Concepto() { }

        public Concepto(string tipo, string descripcion, double cantidad, bool obligatorio)
        {
            Tipo = tipo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Obligatorio = obligatorio;
        }

    }
}
