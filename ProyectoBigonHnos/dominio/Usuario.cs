using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }

        public Usuario(string username, string password, string perfil)
        {
            Username = username;
            Password = password;
            Perfil = perfil;
        }

        public override string ToString()
        {
            return $"Username: {Username}\nPassword: {Password}\nPerfil: {Perfil}";
        }
    }
}
