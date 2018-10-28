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

namespace ProyectoBigonHnos.vista.conceptos
{
    public partial class ConceptosView : Form, IConceptoView
    {
        private ConceptoControlador Controlador { get; set; }

        public ConceptosView()
        {
            InitializeComponent();
            listarTipos();
            listarObligatorio();
     
        }

        public void ActualizarVista()
        {
            conceptosDataGrid.Rows.Clear();
        }

        public void agregarConcepto(int id, string descripcion)
        {
            conceptosDataGrid.Rows.Add(id, descripcion);
        }

        public void limpiar()
        {
            conceptosDataGrid.Rows.Clear();
        }

        public void mostrarConceptos(Dictionary<int, string> conceptos)
        {
            for (int i = 0; i < conceptos.Count(); i++)
            {
                conceptosDataGrid.Rows.Add(
                    conceptos.Keys.ElementAt(i),
                    conceptos.Values.ElementAt(i));
            }

        }

        public void mostrarDetalleConceptos(int idConcepto, string descripcion, string tipo, double porcentaje, bool obligatorio)
        {
            idConceptoDetalleTextView.Text = idConcepto.ToString();
            descripcionDetalleTextView.Text = descripcion;
            tipoDetalleTextView.Text = tipo;
            porcentajeDetalleTextView.Text = porcentaje.ToString();
            obligatorioDetalleTextView.Text = obligatorio.ToString();

        }

        public void UnirControlador(ConceptoControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
            Console.WriteLine("estoy en unircontrolador");
            Controlador.listarConceptos();
        }

        private void seleccionarFila(object sender, DataGridViewCellEventArgs e)
        {
            int idConcepto = int.Parse(conceptosDataGrid.CurrentRow.Cells[0].Value.ToString());

            Controlador.obtenerDetalleConcepto(idConcepto);
        }

        private void listarTipos()
        {

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(1, "Remunerativo");
            test.Add(2, "No remunerativo");
            test.Add(3, "Descuento");
            tipoNuevoComboBox.DataSource = new BindingSource(test, null);
            tipoNuevoComboBox.DisplayMember = "Value";
            tipoNuevoComboBox.ValueMember = "Key";
        }

        private void listarObligatorio()
        {
            Dictionary<Boolean, string> test = new Dictionary<bool, string>();
            test.Add(true, "Si");
            test.Add(false, "No");

            obligatorioNuevoComboBox.DataSource = new BindingSource(test, null);
            obligatorioNuevoComboBox.DisplayMember = "Value";
            obligatorioNuevoComboBox.ValueMember = "Key";

        }

        public void agregarButton_Click(object sender, EventArgs e)
        {
            
            int tipo = ((KeyValuePair<int, string>)tipoNuevoComboBox.SelectedItem).Key;
            Console.WriteLine( tipoNuevoComboBox.SelectedValue);
            string descripcion = descripcionNuevoTextView.Text;
            double porcentaje = double.Parse(porcentajeNuevoTextView.Text.ToString());
            bool obligatorio = ((KeyValuePair<bool, string>)obligatorioNuevoComboBox.SelectedItem).Key;

            Controlador.nuevoConcepto(tipo, descripcion, porcentaje, obligatorio);
        }

        public void limpiarCamposNuevoConcepto()
        {
            descripcionNuevoTextView.Text = "";
            porcentajeNuevoTextView.Text = "";
        }

        private void eliminarConceptoButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idConceptoDetalleTextView.Text);
            Controlador.eliminarConcepto(id);
        }
    }
}
