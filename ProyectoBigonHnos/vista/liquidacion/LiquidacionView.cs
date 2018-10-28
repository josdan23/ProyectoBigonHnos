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
    public partial class LiquidacionView : Form, ILiquidacionView
    {

        private LiquidacionControlador controlador { get; set; }

        public LiquidacionView()
        {
            InitializeComponent();
            mostrarPeriodoComboBox();
        }

        public void ActualizarVista()
        {
            throw new NotImplementedException();
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void UnirControlador(LiquidacionControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            controlador.iniciarLiquidacion();
            controlador.listarConceptos();
        }

        public void cerrar()
        {
            Dispose();
        }

        public void mostrarFamiliar(int idFamiliar, string dni, string parentesco, DateTime fechaNac, bool discapacidad)
        {
            familiaresDataGrid.Rows.Add(idFamiliar, dni, parentesco, fechaNac.ToShortDateString(), discapacidad);
        }

        public void mostrarLiquidacion(string concepto, double valor, double remunerativo, double noRemunerativo, double descuento)
        {
            liquidacionDataGrid.Rows.Add(concepto, valor, remunerativo, noRemunerativo, descuento);
        }

        private void buscarEmpleadoButton_Click(object sender, EventArgs e)
        {
            string legajo = legajoEmpleadoTextView.Text;
            controlador.buscarEmpleado(legajo);

        }

        public void mostrarDatosEmpleado(int idEmpleado, string legajo, string categoria, string cuil, DateTime fechaIngreso)
        {
            idEmpleadoLabel.Text = idEmpleado.ToString();
            legajoEmpleadoLabel.Text = legajo;
            categoriaEmpleadoLabel.Text = legajo;
            cuilEmpleadoLabel.Text = cuil;
            fechaIngresoEmpleadoLabel.Text = fechaIngreso.ToShortDateString();
        }

        private void agregarConceptoButton_Click(object sender, EventArgs e)
        {
            
            int idConcepto =int.Parse(codigoLiquidacionComboBox.SelectedValue.ToString());
            int cantidad = int.Parse(cantidadLiquidacionTextView.Text);
            double valorBase = double.Parse(valorLiquidacionTextView.Text);

            controlador.agregarLineaLiquidacion(idConcepto, cantidad, valorBase);
        }

        private void refrescarTablaFamiliares()
        {
            familiaresDataGrid.Rows.Clear();
        }

        private void refrescarTablaLiquidacion()
        {
            liquidacionDataGrid.Rows.Clear();
        }

        public void mostrarTotal(double total)
        {
            totalLiquidacionTextView.Text = total.ToString();
        }

        private void confirmarLiquidacionButton_Click(object sender, EventArgs e)
        {
            //int periodo = int.Parse(periodoLiquidacionTextView.Text);
            int periodo = int.Parse(periodoComboBox.SelectedValue.ToString());

            controlador.agregarPeriodo(periodo);

            string lugarDePago = lugarPagoLiquidacionTextView.Text;
            controlador.agregarLugarPago(lugarDePago);

            controlador.confimarLiquidacion();
        }

        private void cancelarLiquidacionButton_Click(object sender, EventArgs e)
        {
            controlador.cancelarLiquidacion();
        }

        public void agregarConceptosALista(Dictionary<int,String> conceptos)
        {
            codigoLiquidacionComboBox.DataSource = new BindingSource(conceptos, null);
            codigoLiquidacionComboBox.DisplayMember = "Value";
            codigoLiquidacionComboBox.ValueMember = "Key";
        }

        public void mostrarTotalRemunerativo(double totalRemunerativo)
        {
            totalRemunerativoTextView.Text = totalRemunerativo.ToString();
        }

        public void mostrarTotalNoRemunerativo(double totalNoRemunerativo)
        {
            totalNoRemunerativoTextView.Text = totalNoRemunerativo.ToString();
        }

        public void mostrarTotalDescuento(double totalDescuento)
        {
            totalDescuentoTextView.Text = totalDescuento.ToString();
        }

        private void borrarConceptoButton_Click(object sender, EventArgs e)
        {
            int index = liquidacionDataGrid.CurrentRow.Index;
            liquidacionDataGrid.Rows.RemoveAt(index);

            controlador.eliminarLineaLiquidacion(index);
        }

        private void mostrarPeriodoComboBox()
        {
            periodoComboBox.DisplayMember = "Text";
            periodoComboBox.ValueMember = "Value";

            periodoComboBox.Items.Add(new { Text = "Enero", Value = "1" });
            periodoComboBox.Items.Add(new { Text = "Febrero", Value = "2" });
            periodoComboBox.Items.Add(new { Text = "Marzo", Value = "3" });
            periodoComboBox.Items.Add(new { Text = "Abril", Value = "4" });
            periodoComboBox.Items.Add(new { Text = "Mayo", Value = "5" });
            periodoComboBox.Items.Add(new { Text = "Junio", Value = "6" });
            periodoComboBox.Items.Add(new { Text = "Julio", Value = "7" });
            periodoComboBox.Items.Add(new { Text = "Agosto", Value = "8" });
            periodoComboBox.Items.Add(new { Text = "Septiembre", Value = "9" });
            periodoComboBox.Items.Add(new { Text = "Octubre", Value = "10" });
            periodoComboBox.Items.Add(new { Text = "Noviembre", Value = "11" });
            periodoComboBox.Items.Add(new { Text = "Diciembre", Value = "12" });

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
