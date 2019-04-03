using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.pedidos
{
    public partial class AgregarCostosExtrasView : Form, IPedidoView
    {
        private PedidoControlador controlador;

        public AgregarCostosExtrasView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            descripcionTxtBox.Text = "";
            MontoTxtBox.Text = "";
        }

        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            string descripcion = descripcionTxtBox.Text;
            double monto = double.Parse(MontoTxtBox.Text);

            controlador.agregarCostoExtra(descripcion, monto);
            ActualizarVista();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
