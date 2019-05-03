using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.data
{
    class DaoFactory
    {
        public static DaoFactory instance;

        public static DaoFactory getInstance()
        {
            if (instance == null)
                instance = new DaoFactory();

            return instance;
        }

        static public CRUD<T> instanciarDao<T>()
        {
            string nombreCortoParametro = typeof(T).GetTypeInfo().Name;

            var nombreDeClase = "ProyectoBigonHnos.data." + nombreCortoParametro + "Dao."+ nombreCortoParametro +"DaoImpl";

            Type tipo = Type.GetType(nombreDeClase);

            return (CRUD<T>)Activator.CreateInstance(tipo);
        }

    }
}
