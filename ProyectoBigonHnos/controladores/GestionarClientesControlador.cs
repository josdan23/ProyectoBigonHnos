using ProyectoBigonHnos.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.vista;

namespace ProyectoBigonHnos.controladores
{
    class GestionarClientesControlador
    {
        public ClientesView vista;

        public Negocio Negocio { get; set; }
        public Cliente Cliente { get; set; }


        public GestionarClientesControlador(ClientesView vista)
        {
            Negocio = Negocio.instancia();
            this.vista = vista;
        }

        public void nuevoCliente(string nombre, string apellido, string dni)
        { 
            Cliente = new Cliente(nombre, apellido, dni);
        }

        public void agregarTelefono(string telefono)
        {
            Telefono tel = new Telefono(telefono);
            Cliente.agregarTelefono(tel);
        }

        public void agregarDireccion(string calle, int numero, string localidad, string provincia)
        {
            Direccion dir = new Direccion(calle, numero, localidad, provincia);
            Cliente.agregarDireccion(dir);
        }

        public void confirmarNuevoCliente()
        {
            Negocio.agregarCliente(Cliente);
        }

    
        public void listarClientes()
        {
            
            foreach (Cliente cliente in Negocio.clientes)
            {
                string dni = cliente.Dni;
                string apellido = cliente.Apellido;
                string nombre = cliente.Nombre;

                vista.mostrarCliente(dni, apellido, nombre);
            }
        }

        public void detalleCliente(string dni)
        {
            Cliente cliente = Negocio.buscarCliente(dni);

            vista.mostrarInformmacion(cliente.Dni, cliente.Apellido, cliente.Nombre);
            
            foreach(Telefono telefono in cliente.Telefonos)
            {
                vista.mostrarTelefono(telefono.Numero);
            }

            foreach(Direccion dir in cliente.Direcciones)
            {
                vista.mostrarDireccion(dir.Numero.ToString() , dir.Calle, dir.Localidad.Nombre, dir.Localidad.Prov.Nombre);
            }
        }

        public void borrarCliente(string dni)
        {
            Negocio.borrarCliente(dni);
            
        }

        public void cambiarInformacion(string dni)
        {
            Cliente = Negocio.buscarCliente(dni);
        }
    }
}
