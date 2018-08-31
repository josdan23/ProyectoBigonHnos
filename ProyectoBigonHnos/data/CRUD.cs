using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.data
{
    interface CRUD<T>
    {
        List<T> listarTodos();
        void registrar(T t);
        T leerPorId(int id);
        void actualizar(T t);
        void eliminar(int id);

    }
}
