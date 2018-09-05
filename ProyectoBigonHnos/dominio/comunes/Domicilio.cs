﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class Domicilio
    {
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Localidad Localidad { get; set; }

        public Domicilio() { }

        public Domicilio(string nombreCalle, int numero, string nombreLocalidad, string nombreProvincia)
        {
            this.Calle = nombreCalle;
            this.Numero = numero;
            this.Localidad = new Localidad(nombreLocalidad, nombreProvincia);
        }

        public void mostrar()
        { 
            Console.WriteLine(Calle);
            Console.WriteLine(Numero);
            Localidad.mostrar();

        }

        public override string ToString()
        {
            return string.Format("Calle: {0}\nNumero: {1} \n{2}", Calle, Numero, Localidad.ToString());
        }
    }
}