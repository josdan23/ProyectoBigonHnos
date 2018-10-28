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
    public partial class LiquidacionPanelView : UserControl
    {
        public LiquidacionPanelView()
        {
            InitializeComponent();
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
            view.UnirControlador(new LiquidacionControlador());
            view.ShowDialog();
        }
    }
}
