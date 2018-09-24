using ProyectoBigonHnos.data;
using ProyectoBigonHnos.data.MaterialDao;
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
        private PersistenciaFacade persistencia;

        public CatalogoDeMateriales()
        {
            persistencia = PersistenciaFacade.getInstance();
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
            return persistencia.obtenerObjeto<Material>(idMaterial);
        }

        public void mostrarCatalogo()
        {
            foreach (Material material in persistencia.obtenerTodos<Material>())
            {
                material.mostrar();
            }
        }

        public void crearMaterial(string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo)
        {
            persistencia.registrarObjeto(new Material(descripcion, cantidad, precio, stockDisponible, stockMinimo));

        }

        public void borrarMaterial(int idMaterial)
        {
            persistencia.eliminarObjeto<Material>(idMaterial);
        }

        public void editarMaterial(int id, string descripcion, int cantidad, double precio, int stockMinimo, int stockDisponible)
        {
            Material material = new Material(descripcion, cantidad, precio, stockDisponible, stockMinimo);
            material.IdMaterial = id;
            persistencia.actualiarObjeto(material);
        }

        public List<Material> obtenerMateriales()
        {
            return persistencia.obtenerTodos<Material>();
        }
    }
}
