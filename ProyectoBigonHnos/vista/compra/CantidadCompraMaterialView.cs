using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.compra
{
    public partial class CantidadCompraMaterialView : Form
    {
        public int dataIngresada {get; set;}

        public CantidadCompraMaterialView()
        {
            InitializeComponent();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            dataIngresada = int.Parse(cantidadTxtBx.Text);
            Close();
        }
    }
}
