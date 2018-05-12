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
using ProyectoBigonHnos.vista.proveedor;

namespace ProyectoBigonHnos.vista
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }


        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoPedidos.Show();
            agregarVista(new PedidosView());
        }

        public void ocultarPaneles()
        {
            pnlActivoPedidos.Hide();
            pnlActivoVentas.Hide();
            pnlActivoCompras.Hide();
            pnlActivoPago.Hide();
            pnlActivoMateriales.Hide();
            pnlActivoClientes.Hide();
            pnlActivoEmpleados.Hide();
            pnlActivoUsuario.Hide();
            pnlActivoProveedor.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoVentas.Show();
            agregarVista(new VentasView());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoPago.Show();

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoCompras.Show();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoMateriales.Show();
            agregarVista(new MaterialView());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoClientes.Show();
            agregarVista(new ClientesView());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoProveedor.Show();
            agregarVista(new ProveedorView());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoUsuario.Show();
        }

        public void agregarVista(UserControl usercontrol)
        {
            pnlCuerpo.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            pnlCuerpo.Controls.Add(usercontrol);
        }
    }
}
