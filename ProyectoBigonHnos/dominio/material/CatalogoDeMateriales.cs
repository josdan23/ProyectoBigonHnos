using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class CatalogoDeMateriales
    {
        public static CatalogoDeMateriales catalogo;

        public List<Material> materiales { get; set; }

        public CatalogoDeMateriales()
        {
            materiales = new List<Material>();
        }

        public Material obtenerMaterial(int idMaterial)
        {
            foreach (Material mat in materiales)
            {
                if (idMaterial == mat.IdMaterial)
                {
                    return mat;
                }
            }
            return null;
        }

        public void mostrarCatalogo()
        {
            foreach (Material material in materiales)
            {
                material.mostrar();
            }
        }

        public void crearMaterial(string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        { 
            materiales.Add(new Material(descripcion, cantidad,precio, stockDisponible, stockMinimo));
        }

        public void borrarMaterial(int idMaterial)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                if (materiales.ElementAt(i).IdMaterial == idMaterial)
                {
                    materiales.RemoveAt(i);
                }
            }
        }

        public void modificarMaterial(int idMaterial, string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            Material material;

            for (int i = 0; i < materiales.Count; i++)
            {
                if (idMaterial == materiales.ElementAt(i).IdMaterial)
                {
                    material = materiales.ElementAt(i);
                    material.Descripcion = descripcion;
                    material.Cantidad = cantidad;
                    material.Precio = precio;
                    material.StockDisponible = stockDisponible;
                    material.StockMinimo = stockMinimo;
                }
            }
        }


        public static CatalogoDeMateriales instacia()
        {
            if (catalogo is null)
            {
                catalogo = new CatalogoDeMateriales();
            }
            return catalogo;
        }

        public void editarMaterial(int id, string descripcion, int cantidad, double precio, int stockMinimo, int stockDisponible)
        {
            Material material;
            for (int i = 0; i < materiales.Count; i++)
            {
                if (materiales[i].IdMaterial == id)
                {
                    material = materiales[i];
                    material.Descripcion = descripcion;
                    material.Cantidad = cantidad;
                    material.Precio = precio;
                    material.StockMinimo = stockMinimo;
                    material.StockDisponible = stockDisponible;
                    materiales[i] = material;
                }
            }
        }

    }
}
