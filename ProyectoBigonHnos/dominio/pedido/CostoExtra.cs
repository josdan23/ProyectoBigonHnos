using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.pedido
{
    public class CostoExtra
    {
        public int idCostoExtra { get; set; }
        public string descripcion { get; set; }
        public double importe { get; set; }

        public CostoExtra(string descripcion, double importe)
        {
            this.descripcion = descripcion;
            this.importe = importe;
        }

    }
}
