using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    class GrupoFamiliar
    {
        public string Dni { get; set; }
        public string Parentesco { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Discapacidad { get; set; }

        public GrupoFamiliar (string dni, string parentesco, DateTime fechaNac, bool discapacidad)
        {
            Dni = dni;
            Parentesco = parentesco;
            FechaNacimiento = fechaNac;
            Discapacidad = discapacidad;
        }

        public override string ToString()
        {
            return $"Dni: {Dni}\nParentesco: {Parentesco}\nFechaNacimiento: {FechaNacimiento}\nDiscapacidad: {Discapacidad}";
        }
    }
}
