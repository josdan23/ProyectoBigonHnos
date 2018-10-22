using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.vista
{
    public partial class CompraView : UserControl, ICompraView
    {
        public CompraControlador controlador { get; set; }

        public CompraView()
        {
            InitializeComponent();
            UnirControlador(new CompraControlador());
            ActualizarVista();
            
        }

        public void ActualizarVista()
        {
            comprasRealizadasDataGrid.Rows.Clear();
            controlador.cargarComprasRealizadas();
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void UnirControlador(CompraControlador controlador)
        {
            this.controlador = controlador;
            controlador.UnirVista(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCompraView v = new NuevaCompraView();
            v.UnirControlador(new CompraControlador());
            v.ShowDialog();
            
            
            ActualizarVista();

        }

        public void close()
        {
            Dispose();  
        }

        public void mostrarCompra(int id, string proveedor, DateTime fecha, string estado)
        {
            comprasRealizadasDataGrid.Rows.Add(id, proveedor, fecha, estado);
        }
    }
}
