using ProyectoBigonHnos.controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.vista.ventas
{
    interface IVentaView
    {
        void UnirControlador(VentaControlador controlador);

        void ActualizarVista();

        void limpiar();
    
    }
}
