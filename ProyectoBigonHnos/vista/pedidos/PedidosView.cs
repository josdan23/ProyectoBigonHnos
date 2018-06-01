using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.vista.pedidos;

namespace ProyectoBigonHnos.vista
{
    partial class PedidosView : UserControl
    {
        public PedidosView()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedidoView vista = new NuevoPedidoView();
            vista.ShowDialog();
        }
    }
}
