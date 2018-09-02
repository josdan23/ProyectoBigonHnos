using ProyectoBigonHnos.dominio;
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
            Negocio = Negocio.getNegocio();
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
    }
}
