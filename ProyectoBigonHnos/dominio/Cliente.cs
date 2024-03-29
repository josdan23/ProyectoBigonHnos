﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }

        public Cliente(string nombre, string apellido, string dni): base(nombre, apellido, dni)
        {
            
        }

        public void mostrar()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Dni);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format("IdCliente: {0}\n{1}",IdCliente, base.ToString());
        }
    }
}
