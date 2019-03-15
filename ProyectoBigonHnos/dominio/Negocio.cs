using ProyectoBigonHnos.data.ProveedorDao;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.data;

namespace ProyectoBigonHnos.dominio
{
    public class Negocio
    {
        private static Negocio negocio;
        private CatalogoDeMateriales catalogo;
        private PersistenciaFacade persistencia;

        public Negocio()
        {
            persistencia = PersistenciaFacade.getInstance();
        }

        public static Negocio getNegocio()
        {
            if (negocio is null)
                negocio = new Negocio();
            return negocio;
        }
 
        public void agregarCatalogo( CatalogoDeMateriales catalogo)
        {
            this.catalogo = catalogo;
        }

        //CLIENTE
        internal IEnumerable<Cliente> obtenerTodosClientes()
        { 
            return persistencia.obtenerTodos<Cliente>();
        }

        public Cliente buscarCliente(string dni)
        {
            List<Cliente> listaClientes = persistencia.obtenerTodos<Cliente>();

            foreach (var unCliente in listaClientes)
            {
                if (dni.Equals(unCliente.Dni))
                    return unCliente;
            }
            return null;
        }

        public void agregarCliente(Cliente cliente)
        {
            persistencia.registrarObjeto(cliente);
        }

        public void borrarCliente(string dni)
        {
            List<Cliente> listaDeClientes = persistencia.obtenerTodos<Cliente>();

            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                if (listaDeClientes.ElementAt(i).Dni == dni)
                    persistencia.eliminarObjeto<Cliente>(listaDeClientes.ElementAt(i).IdCliente);
            }
        }


        //MATERIAL
        public Material buscarMaterial(int idMaterial)
        {
            return CatalogoDeMateriales.getInstancia().obtenerMaterial(idMaterial);
        }

        //VENTA
        internal IEnumerable<Venta> obtenerTodasVentasRealizadas()
        {
            return persistencia.obtenerTodos<Venta>();
        }

        public void BorrarVenta(int idVenta)
        {
            persistencia.eliminarObjeto<Venta>(idVenta);
        }

        public void cargarVentasConfirmadas(Venta venta)
        {
            persistencia.registrarObjeto(venta);
        }


        //EMPLEADO
        public List<Empleado> obtenerTodosEmpleados()
        {
            return persistencia.obtenerTodos<Empleado>();
        }

        public void borrarEmpleado(string legajo)
        {
            List<Empleado> listaEmpleados = persistencia.obtenerTodos<Empleado>();

            for ( int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Legajo == legajo)
                    persistencia.eliminarObjeto<Empleado>(listaEmpleados[i].IdEmpleado);
            }
        }

        internal Empleado buscarEmpleado(string legajoSeleccionado)
        {
            List<Empleado> listaEmpleados = persistencia.obtenerTodos<Empleado>();

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Legajo == legajoSeleccionado)
                    return persistencia.obtenerObjeto<Empleado>(listaEmpleados[i].IdEmpleado);
            }
            return null;
        }

        public void nuevoEmpleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, bool admin, DateTime fechaIngreso)
        {
            Empleado empleado = new Empleado(nombre, apellido, dni, categoria, cuil, password, admin, fechaIngreso);
        }

        public void agregarEmpleado(Empleado empleado)
        {
            persistencia.registrarObjeto(empleado);
        }

        //PEDIDOS
        internal IEnumerable<Pedido> obtenerTodosPedidosRealizados()
        {
            return persistencia.obtenerTodos<Pedido>();
        }

        public Pedido buscarPedido(int idPedido)
        {
            return persistencia.obtenerObjeto<Pedido>(idPedido);
        }

        internal IEnumerable<Pedido> obtenerTodosPedidos()
        {
            return persistencia.obtenerTodos<Pedido>();
        }

        public void cargarPedidosRealizados(Pedido pedido)
        {
            persistencia.registrarObjeto(pedido);
        }

        public void borrarPedido(int idPedido)
        {
            persistencia.eliminarObjeto<Pedido>(idPedido);
        }

        //CONCEPTOS
        internal IEnumerable<Concepto> obtenerTodosConceptos()
        {
            return persistencia.obtenerTodos<Concepto>();
        }

        public void agregarConcepto(Concepto concepto)
        {
            persistencia.registrarObjeto(concepto);
            Console.WriteLine("concepto agregado");
        }

        public void borrarConcepto(int idConcepto)
        {
            persistencia.eliminarObjeto<Concepto>(idConcepto);
        }

        public Concepto buscarConcepto(int idConcepto)
        {
            return persistencia.obtenerObjeto<Concepto>(idConcepto);
        }

        internal void actualizarConcepto(Concepto concepto)
        {
            persistencia.actualiarObjeto(concepto);
        }

        //PROVEEDORES
        public void cargarProveedores()
        {
            Proveedor prov = new Proveedor();
            prov.RazonSocial = "rzonSocial";
            prov.Cuit = "cuit";
            Console.WriteLine("hola");
            //prov.agregarTelefono(new Telefono("nasdfasdf"));
            prov.agregarNuevoTelefono("telefono1");
            //prov.agregarDomicilio(new Domicilio("calle1", 233, "sanmiguel", "tucuman"));
            prov.agregarNuevaDomicilio("calle1", 233, "samiguel", "tucuman");
            //proveedores.Add(prov);

            //proveedorDao.registrar(prov);
            persistencia.registrarObjeto(prov);

        }

        public Proveedor buscarProveedor(int idProveedor)
        {
            return persistencia.obtenerObjeto<Proveedor>(idProveedor);
        }

        public Proveedor buscarProveedor(string razonSocial)
        {
            List<Proveedor> listaProveedores = persistencia.obtenerTodos<Proveedor>();
            foreach (var unProveedor in listaProveedores)
            {
                if (unProveedor.RazonSocial == razonSocial)
                    return persistencia.obtenerObjeto<Proveedor>(unProveedor.IdProveedor);
            }

            return null;
        }

        public void actualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            persistencia.actualiarObjeto(proveedor);
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            persistencia.registrarObjeto(proveedor);
        }

        public void borrarProveedor(string razonSocial)
        {
            List<Proveedor> listaProveedores = persistencia.obtenerTodos<Proveedor>();

            for (int i = 0; i < listaProveedores.Count; i++)
            {
                if(listaProveedores.ElementAt(i).RazonSocial == razonSocial)
                    persistencia.eliminarObjeto<Proveedor>(listaProveedores.ElementAt(i).IdProveedor);
            }
        }

        public void borrarProveedor(int idProveedor)
        {
            persistencia.eliminarObjeto<Proveedor>(idProveedor);
        }

        public List<Proveedor> obtenerTodosProveedores()
        {
            return persistencia.obtenerTodos<Proveedor>();
        }

        internal void actualizarEmpleado(Empleado empleadoActualizado)
        {
            persistencia.actualiarObjeto<Empleado>(empleadoActualizado);
        }
    }
}