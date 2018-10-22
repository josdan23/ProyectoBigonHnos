using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.vista
{
    public interface ICompraView
    {
        void UnirControlador(CompraControlador controlador);

        void ActualizarVista();

        void limpiar();

        void close();
    }
}
