using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.venta
{
    class Pago
    {
        private DateTime fecha;
        private int nroCuotas;
        private double montoTotal;

        List<Cuota> cuotas;

        public Pago (int nroCuotas)
        {
            this.nroCuotas = nroCuotas;
            this.fecha = DateTime.Now;
            this.cuotas = new List<Cuota>();
        }
    }
}
