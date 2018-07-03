using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.controladores
{
    class ConceptoControlador
    {
        Concepto Concepto { get; set; }

        public ConceptoControlador()
        {

        }

        public void nuevoConcepto(string tipo, string descripcion, double cantidad, bool obligatorio)
        {
            Concepto = new Concepto(tipo, descripcion, cantidad, obligatorio);
            Negocio.getNegocio().agregarConcepto(Concepto);
        }

        public void eliminarConcepto(int idConcepto)
        {
            Negocio.getNegocio().borrarConcepto(idConcepto);
        }

        public void editarConcepto (int idConcepto, string tipo, string descripcion, double cantidad, bool obligatorio)
        {
            //buscar el Concepto por el id y agregar la informacion del concept
        }

    }
}
