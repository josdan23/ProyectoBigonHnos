using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.vista.materiales;
using ProyectoBigonHnos.vistasImpresas;

namespace ProyectoBigonHnos.controladores
{
    class GestionarMaterialControlador
    {
        private CatalogoDeMateriales catalogo;
        private IMaterialesView vista;

        public GestionarMaterialControlador(IMaterialesView vista)
        {
            this.vista = vista;
            catalogo = CatalogoDeMateriales.getInstancia();

            cargarMateriales();
        }

        public GestionarMaterialControlador()
        {
            catalogo = CatalogoDeMateriales.getInstancia();
        }

        public void agregarNuevoMaterial(String descripcion, double precio, int stockMinimo, int stockDisponible, String unidad)
        {
            catalogo.crearMaterial(descripcion, precio, stockDisponible, stockMinimo, unidad);
        }

        public void eliminarMaterial (int idMaterial)
        {
            catalogo.borrarMaterial(idMaterial);
        }

        public void modificarMaterial(int idMaterial, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo, string unidad)
        {
            catalogo.editarMaterial(idMaterial, descripcion,  precio, stockDisponible, stockMinimo, unidad);
        }

        public void listarMateriales()
        {
            string descripcion = "";
            int cantidad = 0;
            double precio = 0.0;
            int stockDisponible = 0;
            int stockMinimo = 0;
            int idMaterial = 0;
            string unidad = "";

            foreach(Material material in catalogo.obtenerMateriales())
            {
                idMaterial = material.IdMaterial;
                descripcion = material.Descripcion;
                cantidad = material.Cantidad;
                precio = material.Precio;
                stockDisponible = material.StockDisponible;
                stockMinimo = material.StockMinimo;
                unidad = material.tipoUnidad;
                

                vista.mostrarMaterial(idMaterial, descripcion, cantidad, precio, stockDisponible, stockMinimo, unidad );
            }
        }

        private void cargarMateriales()
        {
            agregarNuevoMaterial("madera1", 31.2, 10, 12, "cm2");
            agregarNuevoMaterial("madera2", 31.2, 10, 12, "cm2");
            agregarNuevoMaterial("madera3", 31.2, 10, 12, "unidad");
            agregarNuevoMaterial("madera4", 31.2, 10, 12, "unidad");
            agregarNuevoMaterial("madera5", 31.2, 10, 12, "cm2");
            agregarNuevoMaterial("madera6", 31.2, 10, 12, "unidad");
            agregarNuevoMaterial("madera6", 31.2, 10, 12, "cm2");
        }

        internal void imprimir()
        {
            MaterialesPdfView pdf = new MaterialesPdfView();
            pdf.imprimir(PersistenciaFacade.getInstance().obtenerTodos<Material>());
        }

        public void detalleMaterial (int idMaterial)
        {
            Material material = catalogo.obtenerMaterial(idMaterial);

            vista.mostrarMaterial(
                material.IdMaterial,
                material.Descripcion,
                material.Cantidad,
                material.Precio,
                material.StockDisponible,
                material.StockMinimo,
                material.tipoUnidad);
        }
    }
}
