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

namespace ProyectoBigonHnos.controladores
{
    class ConceptoControlador
    {
        Concepto Concepto { get; set; }

        public ConceptoControlador()
        {

        }

        public void nuevoConcepto(TipoConcepto tipo, string descripcion, double cantidad, bool obligatorio)
        {
            Concepto concp = new Concepto(tipo, descripcion, cantidad, obligatorio);
            Negocio.getNegocio().agregarConcepto(concp);
        }
            
        public void eliminarConcepto(int idConcepto)
        {
            Negocio.getNegocio().borrarConcepto(idConcepto);
        }

        public void editarConcepto (int idConcepto, string tipo, string descripcion, double cantidad, bool obligatorio)
        {
            
            Concepto concepto = new Concepto(TipoConcepto.DESCUENTO, descripcion, cantidad, obligatorio);
            concepto.IdConcepto = idConcepto;

            Negocio.getNegocio().actualizarConcepto(concepto);
        }

        public void listarConceptos()
        {   

        }
    }
}
