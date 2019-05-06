using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.vista.login;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.data.TelefonoDaoList;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.data.PersonaDao;
using ProyectoBigonHnos.data.DomicilioDao;
using System.Reflection;
using ProyectoBigonHnos.dominio.venta;
using ProyectoBigonHnos.vista.liquidacion;
using ProyectoBigonHnos.vista.conceptos;
using ProyectoBigonHnos.dominio.pedido;

namespace ProyectoBigonHnos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            EmpleadoControlador controlador = new EmpleadoControlador();
            controlador.crearEmpleado();
            controlador.agregarInformacionPersonal("yapura", "daniel", "20350533444");
            controlador.agregarLegajo("1111");
            controlador.agregarUsuario("daniel", true);
            controlador.agregarDomicilio("san martin", 12, "santa maria", "catamarca");
            controlador.agregarFechaIngreso(DateTime.Now);
            controlador.agregarCategoria("empleado");
            controlador.agregarTelefono("420368");
            controlador.confimarEmpleado();

            GestionarClientesControlador con = new GestionarClientesControlador();
            con.nuevoCliente("jose", "yapura", "123");
            con.agregarDomicilio("san martin", 23, "santa maria", "catamarca");
            con.agregarTelefono("2930230");
            con.confirmarNuevoCliente();
             */
            Login vista = new Login();
            vista.unirControlador(new LoginControlador());


            // agregarConceptos();
            /*
            Empleado empleado = new Empleado("Mathias", "Yapura", "35053344", "empleado", "32039292", "pass", true, DateTime.Now);
            empleado.agregarTelefono("420358");
            empleado.agregarDomicilio(new Domicilio("Rivadavia", 1234, "santa maria", "catamarca"));
            PersistenciaFacade.getInstance().registrarObjeto(empleado);

            Proveedor nuevoProveedor = new Proveedor("ProvedorNorteño", "cuitProveedor");
            nuevoProveedor.agregarNuevaDomicilio("calleProveeodr", 12, "localidadProveedor", "provinciaProveedor");
            nuevoProveedor.agregarNuevoTelefono("92929");
            PersistenciaFacade.getInstance().registrarObjeto(nuevoProveedor);

            Empleado empleadoRegistrado = PersistenciaFacade.getInstance().obtenerObjeto<Empleado>(1);
            Proveedor proveedorRegistrado = PersistenciaFacade.getInstance().obtenerObjeto<Proveedor>(1);



            Material material = PersistenciaFacade.getInstance().obtenerObjeto<Material>(1);
            Material material2 = PersistenciaFacade.getInstance().obtenerObjeto<Material>(3);

            Console.WriteLine("idmaterial " + material.IdMaterial);

            Compra compra = new Compra();
            compra.agregarEmpleado(empleadoRegistrado);
            compra.agregarProveedor(proveedorRegistrado);
            compra.estado = EstadoCompra.COMPLETADO;
            compra.fechaCompra = DateTime.Now;

            Console.WriteLine(material);
            compra.crearLineaDeCompra(material, 2);
            compra.crearLineaDeCompra(material2, 5);

            PersistenciaFacade.getInstance().registrarObjeto<Compra>(compra);
            */
            Compra compraRegistrada = PersistenciaFacade.getInstance().obtenerObjeto<Compra>(55);
            compraRegistrada.estado = EstadoCompra.EN_PROCESO;
            
            foreach(LineaCompra lc in compraRegistrada.lineasDeCompra)
            {
                lc.material.Descripcion = "NombreCambiado";
                Console.WriteLine("Linea:" + lc.IdLineaCompra + ",," + lc.material.Descripcion);
            }

            PersistenciaFacade.getInstance().actualiarObjeto<Compra>(compraRegistrada);

            

           // PersistenciaFacade.getInstance().eliminarObjeto<Compra>(2);
            Application.EnableVisualStyles();
            Application.Run(vista);
        }

        static void liquidacion()
        {
            Empleado empleado = new Empleado();
            empleado.agregarInformacionPersonal("daniel", "Yapura", "20350533444");

            double valorbase = 4000;

            Liquidacion liquidacion = new Liquidacion(empleado, 2, "Banco Nacion");
            liquidacion.agregarLineaLiquidacion(1, new Concepto(TipoConcepto.REMUNERATIVO, "concepto1", 100, true), valorbase);
            liquidacion.agregarLineaLiquidacion(2, new Concepto(TipoConcepto.REMUNERATIVO, "concepto2", 2, true), valorbase);
            liquidacion.agregarLineaLiquidacion(1, new Concepto(TipoConcepto.REMUNERATIVO, "concepto3", 1, true), valorbase);
            liquidacion.agregarLineaLiquidacion(1, new Concepto(TipoConcepto.NO_REMUNERATIVO, "concepto4", 10, true), valorbase);
            liquidacion.agregarLineaLiquidacion(1, new Concepto(TipoConcepto.NO_REMUNERATIVO, "concepto5", 1, true), valorbase);
            liquidacion.agregarLineaLiquidacion(1, new Concepto(TipoConcepto.DESCUENTO, "concepto6", 1, true), valorbase);
            
            liquidacion.Imprimir();     
            Console.WriteLine(liquidacion.GetImporteTotal());
        }
        
        static void liquidacionControlador()
        {
            LiquidacionControlador controlador = new LiquidacionControlador();
            controlador.iniciarLiquidacion();
            controlador.buscarEmpleado("1111");
            controlador.agregarPeriodo(1);
            controlador.agregarLugarPago("banco nacion");

            controlador.agregarLineaLiquidacion(2, 2, 2500);
            controlador.agregarLineaLiquidacion(1, 2, 2500);
            controlador.agregarLineaLiquidacion(4, 2, 2500);
            controlador.confimarLiquidacion();
        }

        static void agregarConceptos()
        {
            ConceptoControlador controlador = new ConceptoControlador();

            controlador.nuevoConcepto(TipoConcepto.REMUNERATIVO, "sueldo basico", 100, true);
            controlador.nuevoConcepto(TipoConcepto.REMUNERATIVO, "otro remunerativo", 2, true);
            controlador.nuevoConcepto(TipoConcepto.REMUNERATIVO, "basico", 1, true);
            controlador.nuevoConcepto(TipoConcepto.NO_REMUNERATIVO, "aumento1", 10, true);
            controlador.nuevoConcepto(TipoConcepto.NO_REMUNERATIVO, "aumento2", 1, true);
            controlador.nuevoConcepto(TipoConcepto.DESCUENTO, "un descuento", 1, true);
        }
    }
}
