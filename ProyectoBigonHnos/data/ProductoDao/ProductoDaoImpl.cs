using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.ProductoDao
{
    class ProductoDaoImpl : IProductoDao
    {

        private DBConector db;

        public ProductoDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(Producto t)
        {
            String query = String.Format("update producto set alto={0}, ancho={1}, profundidad={2}, descripcion=\'{3}\', color_primario=\'{4}\', color_secundario=\'{5}\' where id_producto={6}",
                t.alto.ToString(CultureInfo.InvariantCulture),
                t.ancho.ToString(CultureInfo.InvariantCulture),
                t.profundidad.ToString(CultureInfo.InvariantCulture),
                t.descripcion,
                t.colorPrimario,
                t.colorSecundario,
                t.IdProducto);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            String query = String.Format("delete from producto where id_producto = {0}", id);
            db.borrarRegistro(query);
        }

        public Producto leerPorId(int id)
        {
            String query = String.Format("select * from producto where id_producto = {0}", id);

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }
            return null;
        }

        public List<Producto> listarTodos()
        {
            string query = string.Format("select * from producto");

            List<Producto> listaDeProductosRegistrados = new List<Producto>();

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                listaDeProductosRegistrados.Add(parse(unRegistro));
            }

            return listaDeProductosRegistrados;
        }

        public void registrar(Producto t)
        {
            String query = String.Format("insert into producto (alto,ancho,profundidad,descripcion,color_primario,color_secundario) values ({0},{1},{2},\'{3}\',\'{4}\',\'{5}\');",
                t.alto.ToString(CultureInfo.InvariantCulture),
                t.ancho.ToString(CultureInfo.InvariantCulture),
                t.profundidad.ToString(CultureInfo.InvariantCulture),
                t.descripcion,
                t.colorPrimario,
                t.colorSecundario);

            db.ejectuarQuery(query);
        }

        private Producto parse(List<Object> unRegistro)
        {
            int idProducto = (int)unRegistro.ElementAt(0);
            double alto = Convert.ToDouble(unRegistro.ElementAt(1));
            double ancho = Convert.ToDouble(unRegistro.ElementAt(2));
            double profundidad = Convert.ToDouble(unRegistro.ElementAt(3));
            string descripcion = (string)unRegistro.ElementAt(4);
            string colorPrimario = (string)unRegistro.ElementAt(5);
            string colorSecundario = (string)unRegistro.ElementAt(6);

            Producto producto = new Producto(descripcion, alto, ancho, profundidad, colorPrimario, colorSecundario);
            producto.IdProducto = idProducto;

            return producto;
        }
    }
}
