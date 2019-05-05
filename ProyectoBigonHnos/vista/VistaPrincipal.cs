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
using ProyectoBigonHnos.vista.empleado;
using ProyectoBigonHnos.vista.liquidacion;
using ProyectoBigonHnos.vista.proveedor;
using ProyectoBigonHnos.vista.compra;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.usuario;

namespace ProyectoBigonHnos.vista
{
    public partial class VistaPrincipal : Form
    {
        private Empleado EmpleadoLogeado { get; set; }

        public VistaPrincipal(Empleado empleado)
        {
            InitializeComponent();
            EmpleadoLogeado = empleado;
        }


        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoPedidos.Show();
            btnPedidos.BackColor = Color.White;
            agregarVista(new PedidosView());
        }

        public void ocultarPaneles()
        {
            pnlActivoPedidos.Hide();
            btnPedidos.BackColor = Color.Transparent;
            pnlActivoVentas.Hide();
            btnVentas.BackColor = Color.Transparent;
            pnlActivoCompras.Hide();
            btnCompras.BackColor = Color.Transparent;
            pnlActivoMateriales.Hide();
            btnMateriales.BackColor = Color.Transparent;
            pnlActivoClientes.Hide();
            btnClientes.BackColor = Color.Transparent;
            pnlActivoEmpleados.Hide();
            btnEmpleados.BackColor = Color.Transparent;
            pnlActivoUsuario.Hide();
            btnUsuario.BackColor = Color.Transparent;
            pnlActivoProveedor.Hide();
            btnProveedores.BackColor = Color.Transparent;
            pnlActivoLiquidacion.Hide();
            btnLiquidacion.BackColor = Color.Transparent;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoVentas.Show();
            btnVentas.BackColor = Color.White;
            agregarVista(new VentasView(EmpleadoLogeado));
        }



        private void btnCompras_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoCompras.Show();
            btnCompras.BackColor = Color.White;
            agregarVista(new CompraView(EmpleadoLogeado));
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoMateriales.Show();
            btnMateriales.BackColor = Color.White;
            agregarVista(new MaterialView());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoClientes.Show();
            btnClientes.BackColor = Color.White;
            agregarVista(new ClientesView());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoEmpleados.Show();
            btnEmpleados.BackColor = Color.White;
            agregarVista(new EmpleadoView(EmpleadoLogeado));

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoUsuario.Show();
            btnUsuario.BackColor = Color.White;
            agregarVista(new UsuarioView(EmpleadoLogeado.Legajo));
        }

       
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoProveedor.Show();
            btnProveedores.BackColor = Color.White;
            agregarVista(new ProveedorView());
        }

        public void agregarVista(UserControl usercontrol)
        {
            pnlCuerpo.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            pnlCuerpo.Controls.Add(usercontrol);
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlActivoLiquidacion.Show();
            btnLiquidacion.BackColor = Color.White;
            agregarVista(new LiquidacionPanelView());
        }
    }
}
