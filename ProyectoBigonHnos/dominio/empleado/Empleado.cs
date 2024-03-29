﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Empleado : Persona
    {   
        public int IdEmpleado { get; set; }
        public string Legajo { get; set; }
        public string Categoria { get; set; }
        public string Cuil { get; set; }

        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }

        public Usuario Usuario { get; set; }
        public List<GrupoFamiliar> Familiares { get; set; }

        public Empleado()
        {
            Familiares = new List<GrupoFamiliar>();
        }

        public Empleado(string nombre, string apellido, string dni, string categoria, string cuil, string password, bool admin, DateTime fechaIngreso) : base (nombre,apellido,dni)
        { 
            Categoria = categoria;
            Cuil = cuil;
            FechaIngreso = fechaIngreso;

            Usuario = new Usuario( password, admin);
            Familiares = new List<GrupoFamiliar>();
        }

        public void agregarInformacionPersonal(string nombre, string apellido, string cuil)
        {
            Dni = cuil.Substring(2, 8);

            Nombre = nombre;
            Apellido = apellido;
            Cuil = cuil;
        }

        internal void agregarCategoria(string categoria)
        {
            Categoria = categoria;
        }

        internal void agregarLegajo(string legajo)
        {
            Legajo = legajo;
        }

        public void agregarDomicilio(string calle, int numero, string localidad, string provincia)
        {
            Domicilio dir = new Domicilio(calle, numero, localidad, provincia);
            agregarDomicilio(dir);
        }

        internal void agregarInfoUsuario(string username, string password, bool esAdmin)
        {
           
            Usuario.Password = password;
            Usuario.Administrador = esAdmin;
        }

        public void agregarTelefono(string numeroTelefono)
        {
            Telefono tel = new Telefono(numeroTelefono);
            agregarTelefono(tel);
        } 

        public void agregarFamiliar(string dni, string parentesco, DateTime fechaNacimiento, bool discapacidad)
        {
            Familiares.Add(new GrupoFamiliar(dni, parentesco, fechaNacimiento, discapacidad));
        }

        public void agregarCuenta ( string password, bool admin)
        {
            Usuario = new Usuario( password, admin); 
        }

        public void mostrar()
        {
            Console.WriteLine("DETALLE DE EMPLEADO");
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Dni);
            Console.WriteLine(Categoria);
            Console.WriteLine(Cuil);
            Console.WriteLine(FechaIngreso);
            Console.WriteLine(FechaEgreso);
            Console.WriteLine(Usuario);
            
            foreach (Telefono tel in Telefonos)
            {
                tel.mostrar();
            }

            foreach (Domicilio dir in Domicilioes)
            {
                dir.mostrar();
            }

            foreach (GrupoFamiliar familiar in Familiares)
            {
                if (familiar != null)
                    Console.WriteLine(familiar);
            }

        }

        public void ingreso(DateTime fechaIngreso)
        {
            FechaIngreso = fechaIngreso;
        }

        public void egreso(DateTime fechaEgreso)
        {
            FechaEgreso = fechaEgreso;
        }


        public void eliminarFamiliar(string dniFamiliar)
        {
            int index = Familiares.FindIndex(x => x.Dni == dniFamiliar);

            Familiares.RemoveAt(index);
        }
    }
}
