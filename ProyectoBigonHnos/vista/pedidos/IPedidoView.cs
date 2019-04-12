
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.pedidos
{
    public interface IPedidoView
    {
        void unirControlador(IPedidoController controlador);

        void ActualizarVista();
    }
}
