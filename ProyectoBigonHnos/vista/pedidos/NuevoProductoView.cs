using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.dominio;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
     partial class NuevoProductoView : Form, IPedidoView
    {

        private IPedidoController controlador;

        public NuevoProductoView()
        {
            InitializeComponent();
        }

        public void mostrarDescripcion(string descripcion)
        {
            tboxDescripcion.Text = descripcion;
        }
        
        public void mostrarAlto(double alto)
        {
            tboxAlto.Text = alto.ToString();
        }

        public void mostrarAncho(double ancho)
        {
            tboxAncho.Text = ancho.ToString();
        }

        public void mostrarProfundidad(double profundidad)
        {
            tboxProfundidad.Text = profundidad.ToString();
        }

        public void mostrarColorPrimario(string colorPrimario)
        {
            tboxColorP.Text = colorPrimario;
        }

        public void mostrarColorSecundario(string colorSecundario)
        {
            tboxColorS.Text = colorSecundario;
        }

        public void mostrarCantidad(int cantidad)
        {
            tboxCantidad.Text = cantidad.ToString();
        }

        public void unirControlador(IPedidoController controlador)
        {
            this.controlador = controlador;
            if (controlador is PedidoControlador)
                ((PedidoControlador)controlador).unirVista(this);
            else
                ((EditarPedidoControlador)controlador).unirVista(this);
        }

        public void unirControlador(EditarPedidoControlador controlador)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = tboxDescripcion.Text;
                double alto = double.Parse(tboxAlto.Text);
                double ancho = double.Parse(tboxAncho.Text);
                double profundidad = double.Parse(tboxProfundidad.Text);
                string colorPrimario = tboxColorP.Text;
                string colorSecundario = tboxColorS.Text;
                int cantidad = int.Parse(tboxCantidad.Text);

                if (controlador is PedidoControlador)
                {

                    ((PedidoControlador)controlador).agregarProducto(
                        descripcion,
                        alto,
                        ancho,
                        profundidad,
                        colorPrimario,
                        colorSecundario,
                        cantidad);
                }
                else
                {
                    ((EditarPedidoControlador)controlador).agregarNuevoProducto(
                    descripcion,
                    alto,
                    ancho,
                    profundidad,
                    colorPrimario,
                    colorSecundario,
                    cantidad);
                }

                Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void ActualizarVista()
        {
            Console.WriteLine("Actualizar: vista de producto");
        }
    }
}
