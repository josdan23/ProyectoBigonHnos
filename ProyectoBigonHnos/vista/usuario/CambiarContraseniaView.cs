using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.usuario
{
    public partial class CambiarContraseniaView : Form
    {
        private bool Bandera1;
        private bool Bandera2;

        private CabiarContraseniaControlador Controlador { get; set; }

        public CambiarContraseniaView()
        {
            InitializeComponent();
           
        }

        public void unirControlador(CabiarContraseniaControlador controlador)
        {
            Controlador = controlador;
            Controlador.unirVista(this);
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {

            Controlador.establecerContrasenia(nuevaTxb.Text);
            Dispose();

        }
   
    
        private void nuevaTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nuevaTxb.Text.ToString().Count() < 7)
            {
                msgLbl.Text = "Debe contener mas de 8 caracteres";
                msgLbl.Visible = true;
                Bandera2 = false;
            }
            else
            {
                msgLbl.Visible = false;
                Bandera2 = true;
            }
        }

        private void repetirTxb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void repetirTxb_KeyUp(object sender, KeyEventArgs e)
        {
            if (repetirTxb.Text != nuevaTxb.Text)
            {
                msgLbl.Text = "Incorrecta";
                msgLbl.Visible = true;
                Bandera1 = false;
            }
            else
            {
                msgLbl.Text = "";
                msgLbl.Visible = false;
                Bandera1 = true;

            }

            if (Bandera1 && Bandera2)
            {
                aceptarBtn.Enabled = true;
            }
            else
                aceptarBtn.Enabled = false;

        }
    }
}
