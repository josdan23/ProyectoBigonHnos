using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.controladores;

namespace ProyectoBigonHnos.vista.conceptos
{
    public interface IConceptoView
    {
        void UnirControlador(ConceptoControlador controlador);

        void ActualizarVista();

        void limpiar();

        void agregarConcepto(int id, string descripcion);

        void mostrarConceptos(Dictionary<int, string> conceptos);

        void mostrarDetalleConceptos(int idConcepto, string descripcion, string tipo, double porcentaje, Boolean obligatorio);
    }
}
