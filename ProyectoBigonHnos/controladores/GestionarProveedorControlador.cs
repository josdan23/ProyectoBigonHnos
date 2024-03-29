﻿using ProyectoBigonHnos.data;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista.proveedor;
using ProyectoBigonHnos.vistasImpresas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoBigonHnos.controladores
{
    class GestionarProveedorControlador
    {
        IProveedorView vista;

        public Negocio Negocio { get; set; }
        public Proveedor Proveedor { get; set; }

        public GestionarProveedorControlador(IProveedorView vista)
        {
            this.vista = vista;
            Negocio = Negocio.getNegocio();
        }

        public void crearNuevoProveedor( string razonSocial, string cuit)
        {
            Proveedor = new Proveedor();
            Proveedor.RazonSocial = razonSocial;
            Proveedor.Cuit = cuit;
        }

        public void agregarTelefono(string numeroDeTelefono)
        { 
            Proveedor.agregarNuevoTelefono(numeroDeTelefono);
        }

        public void agregarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Proveedor.agregarNuevaDomicilio(calle, numero, localidad, provincia);
        }

        public void confirmarNuevoProveedor()
        {
            Negocio.agregarProveedor(Proveedor);
            Proveedor = null;
        }

        public void listarProvedores()
        { 
            foreach (Proveedor prov in Negocio.obtenerTodosProveedores())
            {
                vista.listarProveedores(prov.RazonSocial);
            }
        }

        public void obtenerDetalleDeProveedor(string razonSocial)
        {
            Proveedor proveedor = Negocio.buscarProveedor(razonSocial);

            if(proveedor != null)
            {
                mostrarDetalleDeProveedor(proveedor);
            }
        }

        private void mostrarDetalleDeProveedor(Proveedor proveedor)
        {
            vista.mostrarIdProveedor(proveedor.IdProveedor);
            vista.mostrarRazonSocial(proveedor.RazonSocial);
            vista.mostrarCuit(proveedor.Cuit);
            vista.mostrarTelefono(proveedor.Telefonos[0].Numero);
            vista.mostrarCalle(proveedor.Domicilios[0].Calle);
            vista.mostrarNumero(proveedor.Domicilios[0].Numero);
            vista.mostrarLocalidad(proveedor.Domicilios[0].Localidad.Nombre);
            vista.mostrarProvincia(proveedor.Domicilios[0].Localidad.Provincia.Nombre);
        }

        public void obtenerDetalleDeProveedor(int idProveedor)
        {
            Proveedor proveedor = Negocio.buscarProveedor(idProveedor);

            if (proveedor != null)
            {
                mostrarDetalleDeProveedor(proveedor);
            }
        }
        

        public void eliminarProveedor(string razonSocial)
        {
            Negocio.borrarProveedor(razonSocial);
        }

        public void editarRazonSocial(string nuevaRazonSocial)
        {
            Proveedor.RazonSocial = nuevaRazonSocial;
        }

        public void editarCuit(string nuevoCuit)
        {
            Proveedor.Cuit = nuevoCuit;
        }

        public void editarTelefono (string nuevoNumero)
        {
            Proveedor.agregarNuevoTelefono(nuevoNumero);
        }

        public void editarDomicilio(string nuevaCalle, int nuevoNumero, string nuevaLocalidad, string nuevaProvincia)
        {
            Proveedor.agregarNuevaDomicilio(nuevaCalle, nuevoNumero, nuevaLocalidad, nuevaProvincia);
        }

        public void buscarProveedor(string razonSocial)
        {
            Proveedor = Negocio.buscarProveedor(razonSocial);
        }

        public void buscarProveedor(int idProveedor)
        {
            Proveedor = Negocio.buscarProveedor(idProveedor);
        }

        public void guadarProveedorActualizado(int idProveedor)
        {
            Negocio.actualizarProveedor(idProveedor, Proveedor);
            Proveedor = null;
        }

        internal void imprimir()
        {
            ProveedorPdfView pdf = new ProveedorPdfView();
            pdf.imprimir(PersistenciaFacade.getInstance().obtenerTodos<Proveedor>());
        }
    }
}
