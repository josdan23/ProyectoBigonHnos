using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Negocio
    {
        public static Negocio negocio;

        public List<Cliente> clientes { get; set; }
        private CatalogoDeMateriales catalogo;
        public List<Proveedor> proveedores;
        private List<Pedido> pedidosRealizados;
        private List<Venta> ventasRealizadas;
        private List<Empleado> empleados;

        public Negocio (CatalogoDeMateriales catalogo)
        {

            //catalogo = new CatalogoDeMateriales();
            this.catalogo = catalogo;
            proveedores = new List<Proveedor>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            cargarClientes();
            cargarProveedores();
            pedidosRealizados = new List<Pedido>();
            ventasRealizadas = new List<Venta>();
        }

        public Negocio()
        {
            catalogo = new CatalogoDeMateriales();
          
            proveedores = new List<Proveedor>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            cargarClientes();
            cargarProveedores();
            pedidosRealizados = new List<Pedido>();
            ventasRealizadas = new List<Venta>();
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

        public Proveedor buscarProveedor(int idProveedor)
        {
            foreach (Proveedor proveedor in proveedores)
            {
                if (idProveedor == proveedor.getIdProveedor() )
                    return proveedor;
            }
            return null;
        }

        public Proveedor buscarProveedor(string razonSocial)
        {
            foreach( Proveedor proveedor in proveedores)
            {
                if (razonSocial.Equals(proveedor.razonSocial))
                    return proveedor;
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


        //METODO PARA CARGAR PROVEEDORES DE PRUEBA
        public void cargarProveedores()
        {
            Proveedor prov = new Proveedor(1, "proveedor1", "cuil1");
            prov.agregarTelefono(new Telefono("nasdfasdf"));
            prov.agregarDireccion(new Direccion("calle1", 233, "sanmiguel", "tucuman"));
            proveedores.Add(prov);
            //proveedores.Add(new Proveedor(1, "proveedor1", "cuil1"));
            //proveedores.Add(new Proveedor(2, "proveedor2", "cuil2"));
            //proveedores.Add(new Proveedor(3, "proveedor3", "cuil3"));
            //proveedores.Add(new Proveedor(4, "proveedor4", "cuil4"));
            //proveedores.Add(new Proveedor(5, "proveedor5", "cuil5"));
            //proveedores.Add(new Proveedor(6, "proveedor6", "cuil6"));
        }

        public void cargarVentasConfirmadas(Venta venta)
        {
            ventasRealizadas.Add(venta);
        }

        public void cargarPedidosRealizados(Pedido pedido)
        {
            pedidosRealizados.Add(pedido);
        }

        public void nuevoEmpleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, string perfil, DateTime fechaIngreso)
        {
            Empleado empleado = new Empleado(nombre, apellido, dni, categoria, cuil, password, perfil, fechaIngreso);

            //agregarEmpleado(empleado);
        }

        public void agregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void agregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            proveedores.Add(proveedor);
        }


        public static Negocio instancia()
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

        public void borrarProveedor(string razonSocial)
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].razonSocial.Equals(razonSocial))
                {
                    proveedores.RemoveAt(i);
                    Console.WriteLine("proveedor borrado");

                }
            }
        }
    }
}
