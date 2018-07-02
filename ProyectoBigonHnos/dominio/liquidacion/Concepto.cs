using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    class Concepto
    {
        int IdConcepto { get; set; }
        string Tipo { get; set; }
        string Descripcion { get; set; }
        double Cantidad { get; set; }
        bool Obligatorio { get; set; }

        public Concepto() { }

        public Concepto(int idConcepto, string tipo, string descripcion, double cantidad, bool obligatorio)
        {
            IdConcepto = idConcepto;
            Tipo = tipo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Obligatorio = obligatorio;
        }

    }
}
