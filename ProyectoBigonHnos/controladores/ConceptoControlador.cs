using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.conceptos;

namespace ProyectoBigonHnos.controladores
{
    public class ConceptoControlador
    {
        private IConceptoView Vista { get; set; }

        Concepto Concepto { get; set; }

        public ConceptoControlador()
        {

        }

        public void unirVista(IConceptoView vista)
        {
            Vista = vista;
        }

        public void nuevoConcepto(TipoConcepto tipo, string descripcion, double porcentaje, bool obligatorio)
        {
            Concepto concp = new Concepto(tipo, descripcion, porcentaje, obligatorio);
            Negocio.getNegocio().agregarConcepto(concp);
        }
            
        public void nuevoConcepto(int tipo, string descripcion, double porcentaje, bool obligatorio)
        {
            Concepto concepto = new Concepto(tipo, descripcion, porcentaje, obligatorio);
            Negocio.getNegocio().agregarConcepto(concepto);
            ((Conceptos)Vista).limpiarCamposNuevoConcepto();

            listarConceptos();
        }

        public void eliminarConcepto(int idConcepto)
        {
            Negocio.getNegocio().borrarConcepto(idConcepto);
            listarConceptos();
        }

        public void editarConcepto (int idConcepto, string tipo, string descripcion, double cantidad, bool obligatorio)
        {
            
            Concepto concepto = new Concepto(TipoConcepto.DESCUENTO, descripcion, cantidad, obligatorio);
            concepto.IdConcepto = idConcepto;

            Negocio.getNegocio().actualizarConcepto(concepto);
        }

        public void listarConceptos()
        {
            Vista.limpiar();
            foreach (Concepto concepto in Negocio.getNegocio().obtenerTodosConceptos())
            {
                Vista.agregarConcepto(concepto.IdConcepto, concepto.Descripcion);
            }
        }

        internal void obtenerDetalleConcepto(int idConcepto)
        {
            Concepto concepto = Negocio.getNegocio().buscarConcepto(idConcepto);

            Vista.mostrarDetalleConceptos(
                concepto.IdConcepto,
                concepto.Descripcion,
                concepto.Tipo.ToString(),
                concepto.Porcentaje,
                concepto.Obligatorio);
        }
    }
}
