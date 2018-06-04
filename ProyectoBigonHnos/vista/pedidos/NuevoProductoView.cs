using ProyectoBigonHnos.dominio;
using System;
using System.Windows.Forms;

namespace ProyectoBigonHnos.vista.pedidos
{
     partial class NuevoProductoView : Form, IPedidoView
    {

        private PedidoControlador controlador;

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

        public void unirControlador(PedidoControlador controlador)
        {
            this.controlador = controlador;
            controlador.unirVista(this);
            Console.WriteLine("estoy en la nuevoProducto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcion = tboxDescripcion.Text;
            double alto = double.Parse(tboxAlto.Text);
            double ancho = double.Parse(tboxAncho.Text);
            double profundidad = double.Parse(tboxProfundidad.Text);
            string colorPrimario = tboxColorP.Text;
            string colorSecundario = tboxColorS.Text;
            int cantidad = int.Parse(tboxCantidad.Text);

            controlador.agregarProducto(
                descripcion,
                alto,
                ancho,
                profundidad,
                colorPrimario,
                colorSecundario,
                cantidad);

            Console.WriteLine("producto agregado");
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
