using ProyectoBigonHnos.dominio.pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Pedido
    {

        private static int id = 0;

        public int idPedido { get; set; }
        public DateTime fechaDePedido;
        public DateTime fechaDeEntrega;
        public string estado;
        public Cliente cliente { get; set; }

        public List<LineaPedido> lineasDePedido;
        public List<ListaDeMateriales> ListaDeMateriales { get; set; }
        public List<CostoExtra> costosExtras { get; set; }


        public Pedido()
        {
            this.idPedido = id;
            id++;
            fechaDePedido = DateTime.Now;
            estado = "nuevo";

            lineasDePedido = new List<LineaPedido>();
            ListaDeMateriales = new List<ListaDeMateriales>();
            costosExtras = new List<CostoExtra>();
        }


        public void crearLineaDePedido(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad)
        {
            LineaPedido lp = new LineaPedido(cantidad);
            lp.crearProducto(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario);
            lineasDePedido.Add(lp);
            
        }

        public void agregarMaterialAUsar(Material material, int cantidad)
        {
            ListaDeMateriales.Add(new ListaDeMateriales(material, cantidad));
        }

        public double obtenerSubtotalDeMateriales()
        {
            double subtotal = 0;
            foreach(ListaDeMateriales material in ListaDeMateriales)
            {
                subtotal = subtotal + material.getSubtotal();
            }
            return subtotal;
        }

        public void agregarCostoExtra(string descripcion, double subtotal)
        {
            costosExtras.Add(new CostoExtra(descripcion, subtotal));
        }

        public double obtenerSubtotalCostosExtras()
        {
            double subtotal = 0;
            foreach(CostoExtra costo in costosExtras)
            {
                subtotal = subtotal + costo.importe;
            }

            return subtotal;
        }
        /*
        public void agregarComponente(string descripcion, double alto, double ancho, double profundidad, string colorPrimario, string colorSecundario, int cantidad, Material material)
        {
            //LineaDePedido lp = lineasDePedido.ElementAt(lineasDePedido.Count - 1);
            LineaPedido lp = lineasDePedido.Last();
            lp.crearComponente(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario, cantidad, material);
        }
        */


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

            foreach (LineaPedido linea in lineasDePedido) {
                linea.mostrar();
            }
            
        }

        public double obtenerTotal()
        {
            return obtenerSubtotalCostosExtras() + obtenerSubtotalDeMateriales();
        }

        public List<LineaPedido> obtenerLineasDePedido()
        {
            return lineasDePedido;
        }
    }
}
