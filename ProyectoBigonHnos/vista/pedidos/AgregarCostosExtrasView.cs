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
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista.pedidos
{
    public partial class AgregarCostosExtrasView : Form, IPedidoView
    {
        private IPedidoController controlador;

        public AgregarCostosExtrasView()
        {
            InitializeComponent();
        }

        public void ActualizarVista()
        {
            descripcionTxtBox.Text = "";
            MontoTxtBox.Text = "";
        }

        public void unirControlador(IPedidoController controlador)
        {
            this.controlador = controlador;
            if (controlador is PedidoControlador)
            {
                ((PedidoControlador)controlador).unirVista(this);
            }
            else
                ((EditarPedidoControlador)controlador).unirVista(this);
            
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            string descripcion = descripcionTxtBox.Text;
            double monto = double.Parse(MontoTxtBox.Text);

            if (controlador is PedidoControlador)
                ((PedidoControlador)controlador).agregarCostoExtra(descripcion, monto);
            else
                ((EditarPedidoControlador)controlador).agregarCostoExtra(descripcion, monto);
            ActualizarVista();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
