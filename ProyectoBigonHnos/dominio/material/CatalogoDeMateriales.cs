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
        //public const int INDICE_NO_ENCONTRADO = -1;

        public static CatalogoDeMateriales catalogo;

        //public List<Material> materiales { get; set; }

        private CRUD<Material> dao { get; set; }

        private PersistenciaFacade persistencia;

        public CatalogoDeMateriales()
        {
            //materiales = new List<Material>();

            dao = new MaterialDaoListImpl();

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
            //foreach (Material mat in materiales)
            //{
            //    if (idMaterial == mat.IdMaterial)
            //    {
            //        return mat;
            //    }
            //}
            //return null;

            //return dao.leerPorId(idMaterial);

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
            //materiales.Add(new Material(descripcion, cantidad,precio, stockDisponible, stockMinimo));
            //dao.registrar(new Material(descripcion, cantidad, precio, stockDisponible, stockMinimo));
            persistencia.registrarObjeto(new Material(descripcion, cantidad, precio, stockDisponible, stockMinimo));

        }

        public void borrarMaterial(int idMaterial)
        {
            //int indice = getIndiceBuscandoPorId(idMaterial);

            //if (indice != INDICE_NO_ENCONTRADO)
            //    materiales.RemoveAt(indice);

            //dao.eliminar(idMaterial);
            persistencia.eliminarObjeto<Material>(idMaterial);
        }


        public void editarMaterial(int id, string descripcion, int cantidad, double precio, int stockMinimo, int stockDisponible)
        {

            //int indice = getIndiceBuscandoPorId(id);

            //if (indice != INDICE_NO_ENCONTRADO)
            //{
            //    materiales[indice].Descripcion = descripcion;
            //    materiales[indice].Cantidad = cantidad;
            //    materiales[indice].Precio = precio;
            //    materiales[indice].StockMinimo = stockMinimo;
            //    materiales[indice].StockDisponible = stockDisponible;
            //}

            Material material = new Material(descripcion, cantidad, precio, stockDisponible, stockMinimo);
            material.IdMaterial = id;
            //dao.actualizar(material);
            persistencia.actualiarObjeto(material);
        }

        public List<Material> obtenerMateriales()
        {
            //return dao.listarTodos();
            return persistencia.obtenerTodos<Material>();
        }

        //private int getIndiceBuscandoPorId(int idMaterial)
        //{
        //    for (int i = 0; i < materiales.Count; i++)
        //    {
        //        if (materiales.ElementAt(i).IdMaterial == idMaterial)
        //        {
        //            return i;
        //        }
        //    }

        //    return INDICE_NO_ENCONTRADO;
        //}

    }
}
