using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.vista.materiales
{
    interface IMaterialesView
    {
        void mostrarMaterial(int id, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo);
    }
}
