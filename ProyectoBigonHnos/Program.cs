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
using ProyectoBigonHnos.data.TelefonoDao;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.data.PersonaDao;
using ProyectoBigonHnos.data.DomicilioDao;
using System.Reflection;
using ProyectoBigonHnos.dominio.venta;
using ProyectoBigonHnos.vista.liquidacion;
using ProyectoBigonHnos.vista.conceptos;

namespace ProyectoBigonHnos
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

            Login vista = new Login();
            vista.unirControlador(new LoginControlador());

            agregarConceptos();
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
