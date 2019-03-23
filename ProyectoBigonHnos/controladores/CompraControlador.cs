using ProyectoBigonHnos.controladores;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.vista.compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class CompraControlador
    {
        private Compra compra;
        private Negocio negocio;

        private ICompraView vista;

        public CompraControlador(Negocio negocio)
        {
            this.negocio = negocio;
        }

        public CompraControlador()
        {
            negocio = Negocio.getNegocio();
        }

        public void iniciarNuevaCompra()
        {
            compra = new Compra();
        }

        public void agregarProveedor(int idProveedor)
        {
            Proveedor proveedor = negocio.buscarProveedor(idProveedor);

            if (proveedor != null)
            {
                compra.agregarProveedor(proveedor);
                //Console.WriteLine("proveedor" + proveedor);
            }

            String domicilioProveedor = String.Format("{0} - {1}. {2}. {3}",
                proveedor.Domicilios[0].Calle,
                proveedor.Domicilios[0].Numero,
                proveedor.Domicilios[0].Localidad.Nombre,
                proveedor.Domicilios[0].Localidad.Provincia.Nombre);


                ((NuevaCompraView)vista).mostratCamposProveedor(
                    proveedor.RazonSocial, 
                    proveedor.Cuit, 
                    domicilioProveedor, 
                    proveedor.Telefonos[0].Numero);
            
        }

        internal void mostrarFechaActual()
        {
            ((NuevaCompraView) vista).mostrarFechaActualDeCompra(compra.fechaCompra);
        }

        internal void cargarComprasRealizadas()
        {
            List<Compra> comprasRealizadas = PersistenciaFacade.getInstance().obtenerTodos<Compra>();

            CompraView view = (CompraView)vista;

            foreach (Compra comp in comprasRealizadas)
            {
                view.mostrarCompra(comp.IdCompra, comp.proveedor.RazonSocial, comp.fechaCompra, comp.estado.ToString());
            }
        }

        internal void finalizarCompra(int idCompraCargada)
        {
            Compra compra = PersistenciaFacade.getInstance().obtenerObjeto<Compra>(idCompraCargada);
            compra.finalizarCompra();

            CompraDetalleView view = (CompraDetalleView)vista;
            view.mostrarEstado(compra.estado.ToString());
        }

        internal void eliminarCompra(int id)
        {
            PersistenciaFacade.getInstance().eliminarObjeto<Compra>(id);
            vista.ActualizarVista();
        }

        internal bool esCompraConfirmada(int idCompra)
        {
            Compra compra = PersistenciaFacade.getInstance().obtenerObjeto<Compra>(idCompra);

            if (compra.estado.Equals(EstadoCompra.COMPLETADO))
                return true;
            else
                return false;
        }

        internal void mostrarMateriales()
        {

            List<Material> materiales = PersistenciaFacade.getInstance().obtenerTodos<Material>();

            NuevaCompraView view = (NuevaCompraView)vista;
            foreach(Material mat in materiales)
            {
                view.agregarMaterialATabla(mat.IdMaterial, mat.Descripcion, mat.StockMinimo, mat.StockDisponible);
            }
        }

        public void agregarMaterial(int idMaterial, int cantidad)
        {
            Material material = negocio.buscarMaterial(idMaterial);
           
            int idLineaCompra = compra.crearLineaDeCompra(material, cantidad);

            NuevaCompraView view = (NuevaCompraView)vista;
            view.agregarMaterialACompra(idLineaCompra, material.IdMaterial, material.Descripcion, cantidad);
        }

        public void confirmarComprar()
        {
            compra.seHaCompletado();
            //compra.mostrar();

            PersistenciaFacade.getInstance().registrarObjeto<Compra>(compra);
            vista.close();
        }

        internal void cancelarMaterial(int idLineaDeCompra)
        {
            compra.lineasDeCompra.RemoveAt(idLineaDeCompra);
            mostrarLineasDeCompra();
        }

        public void UnirVista(ICompraView view)
        {
            vista = view;
        }

        private void mostrarLineasDeCompra()
        {
            vista.ActualizarVista();

            NuevaCompraView view = (NuevaCompraView)vista;
            int i = 0;
            foreach(LineaCompra linea in compra.lineasDeCompra)
            {
                Material material = linea.material;

                view.agregarMaterialACompra(i,material.IdMaterial, material.Descripcion, linea.cantidad);
                i++;
            }
        }

        public void mostrarCompraCargada(int idCompraCargada)
        {
            Compra compra = PersistenciaFacade.getInstance().obtenerObjeto<Compra>(idCompraCargada);

            CompraDetalleView view = (CompraDetalleView)vista;
            view.mostrarIdCompra(compra.IdCompra);
            view.mostrarRazonSocial(compra.proveedor.RazonSocial);
            view.mostrarCuil(compra.proveedor.Cuit);
            view.mostrarDomicilio(compra.proveedor.Domicilios[0].domicilioToString());
            view.mostrarTelefono(compra.proveedor.Telefonos[0].Numero);
            view.mostrarFechaDeCompra(compra.fechaCompra);
            view.mostrarEstado(compra.estado.ToString());

            foreach(LineaCompra linea in compra.lineasDeCompra)
            {
                view.mostrarMaterial(linea.material.IdMaterial, linea.material.Descripcion, linea.cantidad);
            }

            if (compra.estado.Equals(EstadoCompra.COMPLETADO))
                view.cambiarEstadoBotonAprobar(false);
            else
                view.cambiarEstadoBotonAprobar(true);
        }

        
    }
}
