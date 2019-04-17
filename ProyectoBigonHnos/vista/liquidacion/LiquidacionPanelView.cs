using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.conceptos;

namespace ProyectoBigonHnos.vista.liquidacion
{
    public partial class LiquidacionPanelView : UserControl, ILiquidacionView
    {
        private LiquidacionControlador controlador;

        public LiquidacionPanelView()
        {
            InitializeComponent();
            controlador = new LiquidacionControlador();

            configurarComboBox();
        }

     

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConceptosView view = new ConceptosView();
            view.UnirControlador(new ConceptoControlador());
            view.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiquidacionView view = new LiquidacionView();
            view.UnirControlador(controlador);
            view.ShowDialog();

            UnirControlador(controlador);
        }

        public void listarLiquidacion(string periodo, string legajo, string apellido, string nombre, int idLiquidacion)
        {
            liquidacionDgv.Rows.Add(periodo, legajo, apellido, nombre, idLiquidacion);
        }

        private void configurarComboBox()
        {
            periodoCombobox.ValueMember = "numero";
            periodoCombobox.DisplayMember = "nombre";

            periodoCombobox.Items.Add(new MesesItemCombobox("Enero", 1));
            periodoCombobox.Items.Add(new MesesItemCombobox("Febrero", 2));
            periodoCombobox.Items.Add(new MesesItemCombobox("Marzo", 3));
            periodoCombobox.Items.Add(new MesesItemCombobox("Abril", 4));
            periodoCombobox.Items.Add(new MesesItemCombobox("Mayo", 5));
            periodoCombobox.Items.Add(new MesesItemCombobox("Junio", 6));
            periodoCombobox.Items.Add(new MesesItemCombobox("Julio", 7));
            periodoCombobox.Items.Add(new MesesItemCombobox("Agosto", 8));
            periodoCombobox.Items.Add(new MesesItemCombobox("Septiembre", 9));
            periodoCombobox.Items.Add(new MesesItemCombobox("Octubre", 10));
            periodoCombobox.Items.Add(new MesesItemCombobox("Noviembre", 11));
            periodoCombobox.Items.Add(new MesesItemCombobox("Diciembre", 12));

        }

        private void periodoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(((MesesItemCombobox)periodoCombobox.SelectedItem).numero);
            ActualizarVista();
            controlador.filtrarLiquidacionPorPeriodo((MesesItemCombobox)periodoCombobox.SelectedItem);
            
        }

        private void detalleBtn_Click(object sender, EventArgs e)
        {
            int idLiquidacion = int.Parse(liquidacionDgv.CurrentRow.Cells[4].Value.ToString());

            DetalleLiquidacionView view = new DetalleLiquidacionView();

            view.UnirControlador(controlador);
            controlador.mostrarDetalleLiquidacion(idLiquidacion);
            view.ShowDialog();
        }

        public void UnirControlador(LiquidacionControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            ActualizarVista();
            controlador.motrarLiquidaciones();
        }

        public void ActualizarVista()
        {
            liquidacionDgv.Rows.Clear();

        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void mostrarFamiliar(int idFamiliar, string dni, string parentesco, DateTime fechaNac, bool discapacidad)
        {
            throw new NotImplementedException();
        }

        public void mostrarLiquidacion(string concepto, double valor, double remunerativo, double noRemunerativo, double descuento)
        {
            throw new NotImplementedException();
        }

        public void mostrarDatosEmpleado(int idEmpleado, string legajo, string categoria, string cuil, DateTime fechaIngreso)
        {
            throw new NotImplementedException();
        }

        public void mostrarTotal(double total)
        {
            throw new NotImplementedException();
        }

        public void mostrarTotalRemunerativo(double totalRemunerativo)
        {
            throw new NotImplementedException();
        }

        public void mostrarTotalNoRemunerativo(double totalNoRemunerativo)
        {
            throw new NotImplementedException();
        }

        public void mostrarTotalDescuento(double totalDescuento)
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
    }

    class MesesItemCombobox
    {
        public string nombre { get; set; }
        public int numero { get; set; }
        
        public MesesItemCombobox(string nombre, int numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }
    }
}
