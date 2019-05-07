using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.data.MaterialDao;
using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.pedido;

namespace ProyectoBigonHnos.data.ListaMaterialesDao
{
    class ListaMaterialDaoImpl : IListaMaterialDao
    {
        DBConector db;

        public ListaMaterialDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(ListaDeMateriales t)
        {
            String query = String.Format("update linea_material set cantidad = {0}, pedido_id_pedido = {1}, material_id_material={2} where id_linea_material = {3};",
                t.cantidad,
                t.idPedido,
                t.material.IdMaterial,
                t.idListaDeMateriales);

            db.ejectuarQuery(query);
        }

        public void eliminar(int id)
        {
            String query = String.Format("delete from linea_material where id_linea_material = {0};", id);
            db.borrarRegistro(query);
        }

        public ListaDeMateriales leerPorId(int id)
        {
            String query = String.Format("select * from linea_material where id_linea_material = {0};", id);

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<ListaDeMateriales> listarTodos()
        {
            String query = String.Format("select * from linea_material;");

            List<ListaDeMateriales> listaMateriales = new List<ListaDeMateriales>();

            foreach (List<Object> unRegistro in db.consultarQuery(query))
            {
                listaMateriales.Add(parse(unRegistro));
            }

            return listaMateriales;
        }

        public void registrar(ListaDeMateriales t)
        {
            String query = String.Format("insert into linea_material (cantidad, pedido_id_pedido, material_id_material) values ({0}, {1}, {2});",
                t.cantidad,
                t.idPedido,
                t.material.IdMaterial);

            db.ejectuarQuery(query);
        }

        private ListaDeMateriales parse(List<Object> unRegistro)
        {
            int idListaMaterial = (int)unRegistro.ElementAt(0);
            int cantidad = (int)unRegistro.ElementAt(1);
            int idPedido = (int)unRegistro.ElementAt(2);
            int idMaterial = (int)unRegistro.ElementAt(3);

            IMaterialDao materialDao = new MaterialDaoImpl();
            Material material = materialDao.leerPorId(idMaterial);
            ListaDeMateriales listaDeMateriales = new ListaDeMateriales(material, cantidad);
            listaDeMateriales.idPedido = idPedido;
            listaDeMateriales.idListaDeMateriales = idListaMaterial;

            return listaDeMateriales;
        }
    }
}
