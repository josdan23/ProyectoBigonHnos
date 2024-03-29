﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Domicilio
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

        public Domicilio(String nombreCalle, int numero, Localidad localidad)
        {
            this.Calle = nombreCalle;
            this.Numero = numero;
            this.Localidad = localidad;
        }

        public void mostrar()
        { 
            Console.WriteLine(Calle);
            Console.WriteLine(Numero);
            Localidad.mostrar();

        }

        public override string ToString()
        {
            return string.Format("idDomicilio: {0}\nCalle: {1}\nNumero: {2}\n{3}",IdDomicilio, Calle, Numero, Localidad);
        }

        public string domicilioToString()
        {
            return string.Format("{0}-{1}, {2} - {3}", Calle, Numero, Localidad.Nombre, Localidad.Provincia.Nombre);
        }
    }
}
