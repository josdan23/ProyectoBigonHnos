using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Pedido
    {

        private static int id = 0;

        public int idPedido { get; set; }
        public DateTime fechaDePedido;
        public DateTime fechaDeEntrega;
        public string estado;
        public Cliente cliente{ get; set;}

        public List<LineaDePedido> lineasDePedido;

        public Pedido()
        {
            this.idPedido = id;
            id++;
            fechaDePedido = DateTime.Now;
            estado = "nuevo";

            lineasDePedido = new List<LineaDePedido>();
        }


        public void crearLineaDePedido(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad)
        {
            LineaDePedido lp = new LineaDePedido(cantidad);
            lp.crearProducto(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario);
            lineasDePedido.Add(lp);
            
        }


        public void agregarComponente(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad, Material material)
        {
            //LineaDePedido lp = lineasDePedido.ElementAt(lineasDePedido.Count - 1);
            LineaDePedido lp = lineasDePedido.Last();
            lp.crearComponente(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad, material);
        }


        public void agregarCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }



        public void agregarFechaDeEntrega(DateTime fechaDeEntrega)
        {
            this.fechaDeEntrega = fechaDeEntrega;
        }



        public void seHaCompletado()
        {
            this.estado = "completo";
        }

        public void imprimirPedido()
        {
           
            Console.WriteLine(fechaDePedido);
            Console.WriteLine(fechaDeEntrega);
            Console.WriteLine(estado);
            cliente.mostrar();

            foreach (LineaDePedido linea in lineasDePedido) {
                linea.mostrar();
            }
            
        }

        public double obtenerTotal()
        {
            //TODO: obtener subtotal
            double total = 0.0;

            foreach(LineaDePedido lp in lineasDePedido)
            {
                total += lp.obtenerSubtotal();
            }

            return total;
        }

        public List<LineaDePedido> obtenerLineasDePedido()
        {
            return lineasDePedido;
        }
    }
}
