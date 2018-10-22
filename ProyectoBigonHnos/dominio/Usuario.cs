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
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Administrador { get; set; }
        public bool Activo { get; set; }

        public Usuario(string username, string password, bool administrador)
        {
            Username = username;
            Password = password;
            Administrador = administrador;
        }

        public override string ToString()
        {
            return $"Username: {Username}\nPassword: {Password}\nEsAdmin: {Administrador}";
        }

        public bool esAdmin()
        {
            return Administrador;
        }
    }
}
