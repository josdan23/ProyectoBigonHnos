using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class CatalogoDeMateriales
    {
        public const int INDICE_NO_ENCONTRADO = -1;

        public static CatalogoDeMateriales catalogo;

        public List<Material> materiales { get; set; }

        public CatalogoDeMateriales()
        {
            materiales = new List<Material>();
        }

        public static CatalogoDeMateriales getInstancia()
        {
            if (catalogo is null)
            {
                catalogo = new CatalogoDeMateriales();
            }
            return catalogo;
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
            int indice = getIndiceBuscandoPorId(idMaterial);

            if (indice != INDICE_NO_ENCONTRADO)
                materiales.RemoveAt(indice);
        }


        public void editarMaterial(int id, string descripcion, int cantidad, double precio, int stockMinimo, int stockDisponible)
        {

            int indice = getIndiceBuscandoPorId(id);

            if (indice != INDICE_NO_ENCONTRADO)
            {
                materiales[indice].Descripcion = descripcion;
                materiales[indice].Cantidad = cantidad;
                materiales[indice].Precio = precio;
                materiales[indice].StockMinimo = stockMinimo;
                materiales[indice].StockDisponible = stockDisponible;
            }
        }

        private int getIndiceBuscandoPorId(int idMaterial)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                if (materiales.ElementAt(i).IdMaterial == idMaterial)
                {
                    return i;
                }
            }

            return INDICE_NO_ENCONTRADO;
        }

    }
}
