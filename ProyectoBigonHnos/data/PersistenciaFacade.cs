using ProyectoBigonHnos.dominio;
using ProyectoBigonHnos.dominio.liquidacion;
using ProyectoBigonHnos.dominio.venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.data
{
    class PersistenciaFacade
    {
        public static PersistenciaFacade instance;


        public static PersistenciaFacade getInstance()
        {
            if (instance == null)
                instance = new PersistenciaFacade();
            return instance;
        }

        //metodo para registrar usando reflexion, se determina el tipo dinamicamente en tiempo de ejecucion
        public void registrar (Object x)
        {
            Type t = x.GetType();

            Type[] typeArguments = t.GetGenericArguments();

            MethodInfo metodoEstaticoGenerico = typeof(DaoFactory).GetMethod("instanciarDao").MakeGenericMethod(x.GetType());

            var dao = metodoEstaticoGenerico.Invoke(null, null);

            dynamic dao3 = metodoEstaticoGenerico.Invoke(null, null);
            dao3.registrar((Persona) x);

            //DaoFactory.instanciarDao<>().registrar(x);
        }

        public void registrarObjeto<T>(T x)
        {
            CRUD<T> dao = DaoFactory.instanciarDao<T>();
            dao.registrar(x);
        }

        public void eliminarObjeto<T> (T t, int id)
        {
            CRUD<T> dao = DaoFactory.instanciarDao<T>();
            dao.eliminar(id);
        }

        public void eliminarObjeto<T> (int id)
        {
            CRUD<T> dao = DaoFactory.instanciarDao<T>();
            dao.eliminar(id);
        }

        public T obtenerObjeto<T> (int id)
        {
            CRUD<T> dao = DaoFactory.instanciarDao<T>();
            return dao.leerPorId(id);
        }

        public void actualiarObjeto<T> (T t)
        {
            CRUD<T> dao = DaoFactory.instanciarDao<T>();
            dao.actualizar(t);
        }

        public List<T> obtenerTodos<T>()
        {
            CRUD<T> dao = DaoFactory.instanciarDao<T>();
            return dao.listarTodos();
        }



    }
}
