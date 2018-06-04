using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;


namespace ProyectoBigonHnos
{
    class Program
    {
        public static CatalogoDeMateriales catalogo;
        public static Negocio negocio;
        static void Main(string[] args)
        {
            /*
            catalogo = CatalogoDeMateriales.instacia();
            GestionarMaterialControlador contr = new GestionarMaterialControlador();
            contr.agregarNuevoMaterial("madera1", 23, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera2", 234, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera3", 53, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera4", 82, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera5", 13, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera6", 21, 31.2, 10, 12);

            //catalogo.mostrarCatalogo();
            contr.eliminarMaterial(3);
            //catalogo.mostrarCatalogo();
            contr.modificarMaterial(2, "acero", 234, 31.2, 10, 12);
            //catalogo.mostrarCatalogo();
            negocio = Negocio.instancia();
            negocio.agregarCatalogo(catalogo);

            //probarEmpleado();
            //probarNuevoPedido();
            //probarMaterial();
            //probarCompraDeMateriales();
            //Console.ReadKey();
            */
            Application.EnableVisualStyles();
            Application.Run(new VistaPrincipal());

        }

        public static void probarEmpleado()
        {
          
            GestionarEmpleadoControlador controler = new GestionarEmpleadoControlador(negocio);

            controler.nuevoEmpleado("daniel", "yapura", "35.053.344", "categoria1", "1231231231", "contrasenia", "empleado", new DateTime(2018,10,12));
            controler.agregarDomicilio("lavalle", 577, "san miguel de tucuman", "tucuman");
            controler.agregarTelefono("420648");
            controler.confirmarNuevoEmpleado();
            controler.mostrar();
    
        }

        public static void probarNuevoPedido()
        {

            PedidoControlador controlador = new PedidoControlador();

            controlador.crearNuevoPedido();
            controlador.agregarProducto("cocina", 2.1, 3.5, 2.5, "blanco", "beige", 1);
            controlador.agregarComponente("cajon", 0.8, 0.4, 2.4, "blanco", "dorado", 6, 2);
            controlador.agregarComponente("puertas", 0.8, 0.4, 2.4, "blanco", "dorado", 6, 2);
            controlador.agregarComponente("estantes", 0.8, 0.4, 2.4, "blanco", "dorado", 6, 2);
            controlador.agregarComponente("cajones-grandes", 0.8, 0.4, 2.4, "blanco", "dorado", 6, 2);
            controlador.agregarCliente("dni3");
            controlador.agregarFechaDeEntrega(new DateTime(2018, 5, 24));
            controlador.confirmarPedido();

        }

        public static void probarMaterial()
        {
            /*
            CatalogoDeMateriales catalogo = new CatalogoDeMateriales();
            //GestionarMaterialControlador contr = new GestionarMaterialControlador(catalogo);
            contr.agregarNuevoMaterial("madera1", 23, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera2", 234, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera3", 53, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera4", 82, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera5", 13, 31.2, 10, 12);
            contr.agregarNuevoMaterial("madera6", 21, 31.2, 10, 12);


            catalogo.mostrarCatalogo();
            contr.eliminarMaterial(3);
            catalogo.mostrarCatalogo();
            contr.modificarMaterial(2, "acero", 234, 31.2, 10, 12);
            catalogo.mostrarCatalogo();
            Negocio negocio = new Negocio(catalogo);
            +*/
        }


        public static void probarCompraDeMateriales()
        {

            CompraControlador controlador = new CompraControlador(negocio);
            controlador.iniciarNuevaCompra();
            controlador.agregarProveedor(2);
            controlador.agregarMaterial(1, 2);
            controlador.agregarMaterial(2, 2);
            controlador.agregarMaterial(4, 2);
            controlador.agregarMaterial(5, 2);
            controlador.confirmarComprar();
        }
    }
}
