﻿using System;
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
        public bool Administrador { get; set; }

        public Usuario(string username, string password, bool administrador)
        {
            Username = username;
            Password = password;
            Administrador = administrador;
        }

        public override string ToString()
        {
            return $"Username: {Username}\nPassword: {Password}\nPerfil: {Perfil}";
        }

        public bool esAdmin()
        {
            return Administrador;
        }
    }
}
