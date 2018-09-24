using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.vista;
using ProyectoBigonHnos.vista.materiales;

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

            //cargarMateriales();
        }

        public void agregarNuevoMaterial(String descripcion, int cantidad, double precio, int stockMinimo, int stockDisponible)
        {
            catalogo.crearMaterial(descripcion, cantidad, precio, stockDisponible, stockMinimo);
        }

        public void eliminarMaterial (int idMaterial)
        {
            catalogo.borrarMaterial(idMaterial);
        }

        public void modificarMaterial(int idMaterial, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            catalogo.editarMaterial(idMaterial, descripcion, cantidad, precio, stockDisponible, stockMinimo);
        }

        public void listarMateriales()
        {
            string descripcion = "";
            int cantidad = 0;
            double precio = 0.0;
            int stockDisponible = 0;
            int stockMinimo = 0;
            int idMaterial = 0;

            foreach(Material material in catalogo.obtenerMateriales())
            {
                idMaterial = material.IdMaterial;
                descripcion = material.Descripcion;
                cantidad = material.Cantidad;
                precio = material.Precio;
                stockDisponible = material.StockDisponible;
                stockMinimo = material.StockMinimo;

                vista.mostrarMaterial(idMaterial, descripcion, cantidad, precio, stockDisponible, stockMinimo);
            }
        }

        private void cargarMateriales()
        {
            agregarNuevoMaterial("madera1", 23, 31.2, 10, 12);
            agregarNuevoMaterial("madera2", 234, 31.2, 10, 12);
            agregarNuevoMaterial("madera3", 53, 31.2, 10, 12);
            agregarNuevoMaterial("madera4", 82, 31.2, 10, 12);
            agregarNuevoMaterial("madera5", 13, 31.2, 10, 12);
            agregarNuevoMaterial("madera6", 21, 31.2, 10, 12);
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
                material.StockMinimo);
        }
    }
}
