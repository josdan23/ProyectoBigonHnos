using System;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.vistasImpresas;
using System.Collections.Generic;

namespace ProyectoBigonHnos.controladores
{
    public class GestionarClientesControlador
    {
        public ClientesView vista;

        public Negocio Negocio { get; set; }
        public Cliente Cliente { get; set; }

        public GestionarClientesControlador(ClientesView vista)
        {
            Negocio = Negocio.getNegocio();
            this.vista = vista;
        }

        public GestionarClientesControlador()
        {
            Negocio = Negocio.getNegocio();
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

        public void agregarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Domicilio dir = new Domicilio(calle, numero, localidad, provincia);
            Cliente.agregarDomicilio(dir);
        }

        public void confirmarNuevoCliente()
        {
            Negocio.agregarCliente(Cliente);
        }

    
        public void listarClientes()
        {
            
            foreach (Cliente cliente in Negocio.obtenerTodosClientes())
            {
                string dni = cliente.Dni;
                string apellido = cliente.Apellido;
                string nombre = cliente.Nombre;

                vista.mostrarCliente(dni, apellido, nombre);
            }
        }

        internal void actualizarCliente(int idCliente, string dni, string apellido, string nombre, string calle, string numero, string localidad, string provincia, string telefono)
        {
            Cliente cliente = PersistenciaFacade.getInstance().obtenerObjeto<Cliente>(idCliente);

            cliente.Dni = dni;
            cliente.Apellido = apellido;
            cliente.Nombre = nombre;
            cliente.Domicilioes[0].Calle = calle;
            cliente.Domicilioes[0].Numero = int.Parse(numero);
            cliente.Domicilioes[0].Localidad.Nombre = localidad;
            cliente.Domicilioes[0].Localidad.Provincia.Nombre = provincia;
            cliente.Telefonos[0].Numero = telefono;

            PersistenciaFacade.getInstance().actualiarObjeto(cliente);

    

        }

        public void detalleCliente(string dni)
        {
            Cliente cliente = Negocio.buscarCliente(dni);

            vista.mostrarInformmacion(cliente.Dni, cliente.Apellido, cliente.Nombre);
            vista.mostrarIdCliente(cliente.IdCliente.ToString());
            foreach(Telefono telefono in cliente.Telefonos)
            {
                vista.mostrarTelefono(telefono.Numero);
            }

            foreach(Domicilio dir in cliente.Domicilioes)
            {
                vista.mostrarDomicilio(
                    dir.Numero.ToString(),
                    dir.Calle, 
                    dir.Localidad.Nombre, 
                    dir.Localidad.Provincia.Nombre
                    );
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

        public void verDetalleActualizacionCliente(int idCliente, EditarClienteView view)
        {
            Cliente cliente = PersistenciaFacade.getInstance().obtenerObjeto<Cliente>(idCliente);


            view.mostrarCliente(cliente.Dni, cliente.Nombre, cliente.Apellido);
            view.mostrarDomicilio(
                cliente.Domicilioes[0].Calle,
                cliente.Domicilioes[0].Numero,
                cliente.Domicilioes[0].Localidad.Nombre,
                cliente.Domicilioes[0].Localidad.Provincia.Nombre);
            view.mostrarTelefono(cliente.Telefonos[0].Numero);
            view.mostrarIdCliente(idCliente);
        }

        internal void imprimir()
        {
            ClientesPdfView impresion = new ClientesPdfView();

            List<Cliente> listaClientes = PersistenciaFacade.getInstance().obtenerTodos<Cliente>();

            impresion.imprimir(listaClientes);
        }
    }
}
