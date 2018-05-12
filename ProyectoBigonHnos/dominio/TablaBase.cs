using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class TablaBase
    {
        public int Id { get; set; }

        public TablaBase()
        {

        }

        public TablaBase(int id)
        {
            Id = id;
        }

    }
}
