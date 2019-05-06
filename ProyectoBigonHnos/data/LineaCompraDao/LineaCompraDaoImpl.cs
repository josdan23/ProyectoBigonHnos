using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.MaterialDao;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.LineaCompraDao
{
    class LineaCompraDaoImpl : ILineaCompraDao
    {
        DBConector db;

        public LineaCompraDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(LineaCompra t)
        {
            string query = string.Format("update linea_compra set descripcion = \'{0}\', cantidad = {1}, subtotal={2}, compra_id_compra = {3}, material_id_material = {4};",
                t.material.Descripcion,
                t.cantidad,
                t.obtenerSubTotal().ToString(CultureInfo.InvariantCulture),
                t.IdCompra,
                t.material.IdMaterial);

            db.consultarQuery(query);
        }

        public void eliminar(int id)
        {
            int idCompra = leerPorId(id).IdCompra;

            string query = string.Format("delete linea_compra where id_linea_compra = {0}", id);

            db.borrarRegistro(query);


        }

        public LineaCompra leerPorId(int id)
        {
            String query = string.Format("select * from linea_compra where id_linea_compra = {0}", id);

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }
            return null;
        }

        public List<LineaCompra> listarTodos()
        {
            String query = string.Format("select * from linea_compra");

            List<LineaCompra> lineasRegistradas = new List<LineaCompra>();

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                lineasRegistradas.Add(parse(unRegistro));
            }

            return lineasRegistradas;
        }

        public void registrar(LineaCompra t)
        {
            String query = String.Format("insert into linea_compra (descripcion, cantidad, subtotal, compra_id_compra, material_id_material) values (\'{0}\', {1}, {2}, {3},{4});",
                t.material.Descripcion.ToString(),
                t.cantidad,
                t.obtenerSubTotal().ToString(CultureInfo.InvariantCulture),
                t.IdCompra,
                t.material.IdMaterial);

            db.ejectuarQuery(query);
        }

        public LineaCompra parse(List<Object> unRegistro)
        {
            int idLineaCompra = (int) unRegistro.ElementAt(0);
            string descripcion = (string)unRegistro.ElementAt(1);
            int cantidad = (int)unRegistro.ElementAt(2);
            double subtotal = Convert.ToDouble(unRegistro.ElementAt(3));
            int compra_id_compra = (int)unRegistro.ElementAt(4);
            int material_id_material = (int)unRegistro.ElementAt(5);

            IMaterialDao materialDao = new MaterialDaoImpl();
            Material material = materialDao.leerPorId(material_id_material);

            LineaCompra lineaCompra = new LineaCompra(material, cantidad);
            lineaCompra.IdCompra = compra_id_compra;
            lineaCompra.IdLineaCompra = idLineaCompra;
            return lineaCompra;
        }
    }
}
