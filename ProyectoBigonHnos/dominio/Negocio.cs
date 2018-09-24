using ProyectoBigonHnos.data.ProveedorDao;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.data.ClienteDao;
using ProyectoBigonHnos.data.EmpleadoDao;
using ProyectoBigonHnos.data.VentaDao;
using ProyectoBigonHnos.data.PedidoDao;
using ProyectoBigonHnos.data.ConceptoDao;
using ProyectoBigonHnos.data.MaterialDao;

namespace ProyectoBigonHnos.dominio
{
    class Negocio
    {
        private static Negocio negocio;

        private CRUD<Proveedor> proveedorDao;
        private CRUD<Cliente> clieteDao;
        private CRUD<Empleado> empleadoDao;
        private CRUD<Material> materialDao;
        private CRUD<Venta> ventaDao;
        private CRUD<Pedido> pedidoDao;
        private CRUD<Concepto> conceptoDao;

        private CatalogoDeMateriales catalogo;



        public Negocio()
        {
            catalogo = CatalogoDeMateriales.getInstancia();
            proveedorDao = new ProveedorDaoListImpl();
            clieteDao = new ClienteDaoListImpl();
            empleadoDao = new EmpleadoDaoListImpl();
            materialDao = new MaterialDaoListImpl();
            ventaDao = new VentaDaoListImpl();
            pedidoDao = new PedidoDaoListImpl();
            conceptoDao = new ConceptoDaoListImpl();
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
            
            return clieteDao.listarTodos();
        }

        public Cliente buscarCliente(string dni)
        {

            foreach( var unCliente in clieteDao.listarTodos())
            {
                if (dni.Equals(unCliente.Dni))
                    return unCliente;
            }

            return null;
        }

        public void agregarCliente(Cliente cliente)
        {

            clieteDao.registrar(cliente);
        }

        public void borrarCliente(string dni)
        {
            List<Cliente> listaDeClientes = clieteDao.listarTodos();

            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                if (listaDeClientes.ElementAt(i).Dni == dni)
                    clieteDao.eliminar(listaDeClientes.ElementAt(i).IdCliente);
            }

        }


        //MATERIAL
        public Material buscarMaterial(int idMaterial)
        {
            return catalogo.obtenerMaterial(idMaterial);
        }


        //VENTA
        internal IEnumerable<Venta> obtenerTodasVentasRealizadas()
        {
            return ventaDao.listarTodos();
        }

        public void BorrarVenta(int idVenta)
        {
            ventaDao.eliminar(idVenta);

        }

        public void cargarVentasConfirmadas(Venta venta)
        {
            ventaDao.registrar(venta);
        }


        //EMPLEADO
        public List<Empleado> obtenerTodosEmpleados()
        {
            return empleadoDao.listarTodos();
        }

        public void borrarEmpleado(string legajo)
        {
            List<Empleado> listaEmpleados = empleadoDao.listarTodos();

            for ( int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Legajo == legajo)
                    empleadoDao.eliminar(listaEmpleados[i].IdEmpleado);
            }
        }

        internal Empleado buscarEmpleado(string legajoSeleccionado)
        {

            List<Empleado> listaEmpleados = empleadoDao.listarTodos();

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Legajo == legajoSeleccionado)
                    return empleadoDao.leerPorId(listaEmpleados[i].IdEmpleado);
            }
            return null;
        }

        public void nuevoEmpleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, bool admin, DateTime fechaIngreso)
        {
            Empleado empleado = new Empleado(nombre, apellido, dni, categoria, cuil, password, admin, fechaIngreso);
        }

        public void agregarEmpleado(Empleado empleado)
        {
            empleadoDao.registrar(empleado);
        }


        //PEDIDOS
        internal IEnumerable<Pedido> obtenerTodosPedidosRealizados()
        {
            return pedidoDao.listarTodos();
        }

        public Pedido buscarPedido(int idPedido)
        {
            return pedidoDao.leerPorId(idPedido);
        }

        internal IEnumerable<Pedido> obtenerTodosPedidos()
        {
            return pedidoDao.listarTodos();
        }

        public void cargarPedidosRealizados(Pedido pedido)
        {
            pedidoDao.registrar(pedido);
        }

        public void borrarPedido(int idPedido)
        {
            pedidoDao.eliminar(idPedido);
        }


        //CONCEPTOS
        internal IEnumerable<Concepto> obtenerTodosConceptos()
        {
            return conceptoDao.listarTodos();
        }

        public void agregarConcepto(Concepto concepto)
        {
            conceptoDao.registrar(concepto);
        }

        public void borrarConcepto(int idConcepto)
        {
            conceptoDao.eliminar(idConcepto);
        }

        public Concepto buscarConcepto(int idConcepto)
        {
            return conceptoDao.leerPorId(idConcepto);
        }

        internal void actualizarConcepto(Concepto concepto)
        {
            conceptoDao.actualizar(concepto);
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

            proveedorDao.registrar(prov);

        }

        public Proveedor buscarProveedor(int idProveedor)
        { 
            return proveedorDao.leerPorId(idProveedor);
        }

        public Proveedor buscarProveedor(string razonSocial)
        {
            foreach (var unProveedor in proveedorDao.listarTodos())
            {
                if (unProveedor.RazonSocial == razonSocial)
                    return proveedorDao.leerPorId(unProveedor.IdProveedor);
            }

            return null;
        }

        public void actualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            proveedorDao.actualizar(proveedor);
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            proveedorDao.registrar(proveedor);
        }

        public void borrarProveedor(string razonSocial)
        {
            foreach (var unProveedor in proveedorDao.listarTodos())
                if (unProveedor.RazonSocial == razonSocial)
                    proveedorDao.eliminar(unProveedor.IdProveedor);
        }

        public void borrarProveedor(int idProveedor)
        {
            proveedorDao.eliminar(idProveedor);
        }

        public List<Proveedor> obtenerTodosProveedores()
        {
            return proveedorDao.listarTodos();
        }
    }
}