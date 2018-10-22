using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio.liquidacion
{
    public class ConceptosDatos
    {
        public int IdConceptos { get; set; }
        public static ConceptosDatos instancia { get; set; }
        public List<Concepto> ConceptosGuardados { get; set; }

        public ConceptosDatos()
        {
            ConceptosGuardados = new List<Concepto>();
            agregarConceptos();
        }

        private void agregarConceptos()
        {
            ConceptosGuardados.Add(new Concepto(TipoConcepto.REMUNERATIVO, "concepto1", 2.1, false));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.REMUNERATIVO, "concepto2", 1.1, true));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.NO_REMUNERATIVO, "concepto3", 0.5, true));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.NO_REMUNERATIVO, "concepto4", 0.1, false));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.DESCUENTO, "concepto5", 4.1, true));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.DESCUENTO, "concepto6", 5.1, false));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.DESCUENTO, "concepto7", 3.2, true));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.REMUNERATIVO, "concepto8", 4.1, false));
            ConceptosGuardados.Add(new Concepto(TipoConcepto.REMUNERATIVO, "concepto9", 6.5, true));

        }


        public static ConceptosDatos getInstancia()
        {
            if (instancia == null)
                instancia = new ConceptosDatos();
            return instancia;
        }
    }
}
