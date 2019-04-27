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
            try {
                dataIngresada = int.Parse(cantidadTxtBx.Text);
                Close();
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Debe ingresar un entero");
            }
            
        }
    }
}
