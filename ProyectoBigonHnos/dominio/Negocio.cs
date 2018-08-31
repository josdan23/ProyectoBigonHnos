using ProyectoBigonHnos.data;
using ProyectoBigonHnos.data.Proveedor;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoBigonHnos.dominio
{
    class Negocio
    {
        public static Negocio negocio;

        public List<Cliente> clientes { get; set; }
        public CatalogoDeMateriales catalogo { get; set; }
        public List<Proveedor> proveedores { get; set; }
        public List<Pedido> pedidosRealizados { get; set; }
        public List<Venta> ventasRealizadas { get; set; }
        public List<Concepto> conceptos { get; set; }
        public List<Empleado> empleados { get; set; }

        private CRUD<Proveedor> proveedorDao;
        private Negocio (CatalogoDeMateriales catalogo)
        {

            this.catalogo = catalogo;
            proveedores = new List<Proveedor>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            cargarClientes();
            cargarProveedores();
            pedidosRealizados = new List<Pedido>();
            ventasRealizadas = new List<Venta>();
            conceptos = new List<Concepto>();

            proveedorDao = new ProveedorDAOImpl();
        }

        public Negocio()
        {
            catalogo = CatalogoDeMateriales.getInstancia();
          
            proveedores = new List<Proveedor>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            cargarClientes();
            cargarProveedores();
            pedidosRealizados = new List<Pedido>();
            ventasRealizadas = new List<Venta>();
            conceptos = new List<Concepto>();

            proveedorDao = new ProveedorDAOImpl();
        }


        public void agregarCatalogo( CatalogoDeMateriales catalogo)
        {
            this.catalogo = catalogo;
        }

        public Cliente buscarCliente(string dni)
        {
            foreach (Cliente cliente in clientes)
            {
                if (dni.Equals(cliente.getDni()))
                    return cliente;
            }
            return null;
        }

      
        public Material buscarMaterial(int idMaterial)
        {
            return catalogo.obtenerMaterial(idMaterial);
        }

        public void borrarEmpleado(string legajo)
        {
            for (int i = 0; i < empleados.Count(); i++)
            {
                if (empleados[i].Legajo == legajo)
                {
                    empleados.RemoveAt(i);
                }
            }
        }


        //BORRAR VENTA CON EL ID
        public void BorrarVenta(int idVenta)
        {
            for (int i=0; i < ventasRealizadas.Count; i++)
            {
                if (ventasRealizadas[i].IdVenta == idVenta)
                    ventasRealizadas.RemoveAt(i);
            }
        }

    

        internal Empleado buscarEmpleado(string legajoSeleccionado)
        {
            for ( int i = 0; i < empleados.Count(); i++)
            {
                if (empleados[i].Legajo == legajoSeleccionado)
                {
                    return empleados[i];
                }
            }

            return null;
        }


        public Pedido buscarPedido(int idPedido )
        {
            foreach( Pedido pedido in pedidosRealizados)
            {
                if (idPedido == pedido.idPedido)
                    return pedido;
            }
            return null;
        }

        
        //METODOS PARA CARGAR CLIENTES DE PRUEBA
        public void cargarClientes()
        {
            Cliente cliente = new Cliente("nombre1", "apellido1", "dni1");
            cliente.agregarTelefono(new Telefono("42067"));
            cliente.agregarTelefono(new Telefono("42068"));
            cliente.agregarTelefono(new Telefono("42069"));
            cliente.agregarDireccion(new Direccion("calle1", 1, "localidad1", "provincia1"));
            clientes.Add(cliente);
            clientes.Add(new Cliente("nombre2", "apellido2", "dni2"));
            clientes.Add(new Cliente("nombre3", "apellido3", "dni3"));
            clientes.Add(new Cliente("nombre4", "apellido4", "dni4"));
            clientes.Add(new Cliente("nombre5", "apellido5", "dni5"));
        }



        public void cargarVentasConfirmadas(Venta venta)
        {
            ventasRealizadas.Add(venta);
        }

        public void cargarPedidosRealizados(Pedido pedido)
        {
            pedidosRealizados.Add(pedido);
        }

        public void nuevoEmpleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, bool admin, DateTime fechaIngreso)
        {
            Empleado empleado = new Empleado(nombre, apellido, dni, categoria, cuil, password, admin, fechaIngreso);

            //agregarEmpleado(empleado);
        }

        public void agregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
            Console.WriteLine("El empleado se ha guardado");
        }

        public void agregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        

        public static Negocio getNegocio()
        {
            if (negocio is null)
                negocio = new Negocio();
            return negocio;
        }

        public void borrarCliente(string dni)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes.ElementAt(i).Dni.Equals(dni))
                {
                    Console.WriteLine(i);
                    clientes.RemoveAt(i);
                }
            }
        }



        //METODO PARA CARGAR PROVEEDORES DE PRUEBA
        public void cargarProveedores()
        {
            Proveedor prov = new Proveedor();
            prov.RazonSocial = "rzonSocial";
            prov.Cuit = "cuit";
            Console.WriteLine("hola");
            //prov.agregarTelefono(new Telefono("nasdfasdf"));
            prov.agregarNuevoTelefono("telefono1");
            //prov.agregarDireccion(new Direccion("calle1", 233, "sanmiguel", "tucuman"));
            prov.agregarNuevaDireccion("calle1", 233, "samiguel", "tucuman");
            proveedores.Add(prov);

        }

        public Proveedor buscarProveedor(int idProveedor)
        {/*
            foreach (Proveedor proveedor in proveedores)
            {
                if (idProveedor == proveedor.IdProveedor )
                    return proveedor;
            }
            return null;*/

            return proveedorDao.leerPorId(idProveedor);
        }

        public Proveedor buscarProveedor(string razonSocial)
        {
            foreach (Proveedor proveedor in proveedores)
            {
                if (razonSocial.Equals(proveedor.RazonSocial))
                    return proveedor;
            }
            return null;
        }

        public void actualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            /*
            for (int i = 0; i < proveedores.Count(); i++)
            {
                if (proveedores[i].IdProveedor == idProveedor)
                    proveedores[i] = proveedor;
            }*/

            proveedorDao.actualizar(proveedor);
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            //proveedores.Add(proveedor);

            proveedorDao.registrar(proveedor);
        }


        public void borrarProveedor(string razonSocial)
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].RazonSocial.Equals(razonSocial))
                {
                    proveedores.RemoveAt(i);
                    Console.WriteLine("proveedor borrado");

                }
            }
        }

        public void borrarProveedor(int idProveedor)
        {
            proveedorDao.eliminar(idProveedor);
        }

        public void borrarPedido(int idPedido)
        {
            for (int i = 0; i < pedidosRealizados.Count; i++)
            {
                if(pedidosRealizados[i].idPedido == idPedido)
                {
                    pedidosRealizados.RemoveAt(i);
                    Console.WriteLine("pedido eliminado");
                }
            }
        }

        public List<Proveedor> obtenerTodosProveedores()
        {
            return proveedorDao.listarTodos();
        }


        public void agregarConcepto(Concepto concepto)
        {
            conceptos.Add(concepto);
        }

        public void borrarConcepto(int idConcepto)
        {
            for (int i = 0; i < conceptos.Count; i++)
            {
                if (conceptos[i].IdConcepto == idConcepto)
                {
                    pedidosRealizados.RemoveAt(i);
                    Console.WriteLine("Concepto eliminado");
                }
            }
        }

        public Concepto buscarConcepto(int idConcepto)
        {
            foreach (Concepto concepto in conceptos)
            {
                if (concepto.IdConcepto == idConcepto)
                    return concepto;
            }
            return null;
        }
    }
}
