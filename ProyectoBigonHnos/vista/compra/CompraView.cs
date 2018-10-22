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
        }

        public void ActualizarVista()
        {
            throw new NotImplementedException();
        }

        public void limpiar()
        {
            throw new NotImplementedException();
        }

        public void UnirControlador(CompraControlador controlador)
        {
            this.controlador = controlador;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCompraView v = new NuevaCompraView();
            v.UnirControlador(new CompraControlador());
            v.ShowDialog();
            
        }

        public void close()
        {
            Dispose();
        }
    }
}
