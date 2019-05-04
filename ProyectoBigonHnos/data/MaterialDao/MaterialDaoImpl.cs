using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.MaterialDao
{
    class MaterialDaoImpl : IMaterialDao
    {
        private DBConector db;

        public MaterialDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Material t)
        {
            string query = string.Format("update material set descripcion = \'{0}\', precio={1}, stock_disponible={2}, stock_minimo={3}, unidad=\'{4}\' where id_material={5};",
                t.Descripcion,
                t.Precio.ToString(CultureInfo.InvariantCulture),
                t.StockDisponible,
                t.StockMinimo,
                t.tipoUnidad,
                t.IdMaterial);
        }

        public void eliminar(int id)
        {
            string query = string.Format("delete from material where id_material= {0}", id);

            db.borrarRegistro(query);
        }

        public Material leerPorId(int id)
        {
            String query = "select * from material where id_material = " + id;

            string descripcion = "";
            double precio = 0;
            int stockDisponible = 0;
            int stockMinimo = 0;
            string unidad = "";

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                descripcion = (string)unRegistro.ElementAt(1);
                precio = Convert.ToDouble(unRegistro.ElementAt(2));
                stockDisponible = (int)unRegistro.ElementAt(3);
                stockMinimo = (int)unRegistro.ElementAt(4);
                unidad = (string)unRegistro.ElementAt(5);

                Material material = new Material(descripcion, precio, stockDisponible, stockMinimo, unidad);
                material.IdMaterial = (int)unRegistro.ElementAt(0);

                return material;
            }

            return null;
        }

        public List<Material> listarTodos()
        {
            String query = "select * from material";

            List<Material> listaDeMaterialesRegistrados = new List<Material>();

            string descripcion = "";
            double precio = 0;
            int stockDisponible = 0;
            int stockMinimo = 0;
            string unidad = "";

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                descripcion = (string)unRegistro.ElementAt(1);
                precio = Convert.ToDouble(unRegistro.ElementAt(2));
                stockDisponible = (int)unRegistro.ElementAt(3);
                stockMinimo = (int)unRegistro.ElementAt(4);
                unidad = (string)unRegistro.ElementAt(5);

                Material material = new Material(descripcion, precio, stockDisponible, stockMinimo,unidad);
                material.IdMaterial = (int)unRegistro.ElementAt(0);

                listaDeMaterialesRegistrados.Add(material);
            }

            return listaDeMaterialesRegistrados;
        }

        public void registrar(Material t)
        {
            String query = String.Format("insert into material (descripcion, precio, stock_disponible, stock_minimo, unidad) values(\'{0}\',{1},{2},{3},\'{4}\');",
                t.Descripcion,
                t.Precio.ToString(CultureInfo.InvariantCulture),
                t.StockDisponible,
                t.StockMinimo,
                t.tipoUnidad);

            db.ejectuarQuery(query);
        }
    }
}
