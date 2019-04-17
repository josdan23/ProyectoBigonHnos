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

namespace ProyectoBigonHnos.vista.liquidacion
{
    public partial class DetalleLiquidacionView : Form, ILiquidacionView
    {
        private LiquidacionControlador controlador;

        public DetalleLiquidacionView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            throw new NotImplementedException();
        }

        public void agregarConceptosALista(Dictionary<int, string> conceptos)
        {
            throw new NotImplementedException();
        }

        public void cerrar()
        {
            throw new NotImplementedException();
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void mostrarInfoEmpleado(string apellido, string nombre)
        {
            apellidoLbl.Text = apellido;
            nombreLbl.Text = nombre;
        }

        public void mostrarDatosEmpleado(int idEmpleado, string legajo, string categoria, string cuil, DateTime fechaIngreso)
        {
            legajoLbl.Text = legajo;
            categoriaLbl.Text = categoria;
            cuilLbl.Text = cuil;
            fechaIngresoLbl.Text = fechaIngreso.ToShortDateString() ;
        }

        public void mostrarFamiliar(int idFamiliar, string dni, string parentesco, DateTime fechaNac, bool discapacidad)
        {
            throw new NotImplementedException();
        }

        public void mostrarLiquidacion(string concepto, double valor, double remunerativo, double noRemunerativo, double descuento)
        {
            liquidacionDgv.Rows.Add(concepto, valor, remunerativo, noRemunerativo, descuento);
        }

        public void mostrarTotal(double total)
        {
            totalLbl.Text = total.ToString();
        }

        public void mostrarTotalDescuento(double totalDescuento)
        {
            descuentoLbl.Text = totalDescuento.ToString();
        }

        public void mostrarTotalNoRemunerativo(double totalNoRemunerativo)
        {
            noRemunerativoLbl.Text = totalNoRemunerativo.ToString();
        }

        public void mostrarTotalRemunerativo(double totalRemunerativo)
        {
            remunertivoLbl.Text = totalRemunerativo.ToString();
        }

        public void UnirControlador(LiquidacionControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
        }
    }
}
