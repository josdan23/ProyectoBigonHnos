using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Password { get; set; }
        public bool Administrador { get; set; }
        public bool Activo { get; set; }

        public Usuario( string password, bool administrador)
        {
 
            Password = password;
            Administrador = administrador;
        }



        public bool esAdmin()
        {
            return Administrador;
        }
    }
}
