using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBigonHnos.dominio;

namespace ProyectoBigonHnos.data.GrupoFamiliarDao
{
    class GrupoFamiliarDaoImpl : IGrupoFamiliarDao
    {
        DBConector db;

        public GrupoFamiliarDaoImpl()
        {
            db = DBConector.getInstance();
        }

        public void actualizar(GrupoFamiliar t)
        {
            string query = string.Format("update grupo_familiar set dni = \'{0}\', parentesco=\'{1}\', fecha_nacimiento=\'{2}\', discapacidad=\'{3}\', empleado_id_empleado={4} where id_grupo_familiar = {5};",
                t.Dni,
                t.Parentesco,
                t.FechaNacimiento.ToShortDateString(),
                t.Discapacidad,
                t.IdEmpleado,
                t.IdGrupoFamiliar);

            db.ejectuarQuery(query);

        }

        public void eliminar(int id)
        {
            string query = String.Format("delete from grupo_familiar where id_grupo_familiar = {0};", id);
            db.borrarRegistro(query);
        }

        public GrupoFamiliar leerPorId(int id)
        {
            string query = string.Format("select * from grupo_familiar where id_grupo_familiar = {0};", id);

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                return parse(unRegistro);
            }

            return null;
        }

        public List<GrupoFamiliar> listarTodos()
        {
            string query = string.Format("select * from grupo_familiar;");

            List<GrupoFamiliar> grupofamilares = new List<GrupoFamiliar>();

            foreach(List<Object> unRegistro in db.consultarQuery(query))
            {
                grupofamilares.Add(parse(unRegistro));
            }

            return grupofamilares;
        }

        public void registrar(GrupoFamiliar t)
        {
            string query = string.Format("insert into grupo_familiar (dni, parentesco, fecha_nacimiento, discapacidad, empleado_id_empleado) values (\'{0}\', \'{1}\',\'{2}\',\'{3}\',{4});",
                t.Dni,
                t.Parentesco,
                t.FechaNacimiento,
                t.Discapacidad,
                t.IdEmpleado);

            db.ejectuarQuery(query);
            Console.WriteLine("Se guardo el grupo familiar");
        }

        private GrupoFamiliar parse(List<Object> unRegistro)
        {
            int idGrupoFamiliar = (int) unRegistro.ElementAt(0);
            string dni = (string)unRegistro.ElementAt(1);
            string parentesco = (string) unRegistro.ElementAt(2);
            DateTime fechaNacimiento = DateTime.Parse(unRegistro.ElementAt(3).ToString());
            bool discapacidad = Convert.ToBoolean(unRegistro.ElementAt(4));
            int idEmpleado = (int)unRegistro.ElementAt(5);

            GrupoFamiliar grupoFamiliar = new GrupoFamiliar(dni, parentesco, fechaNacimiento, discapacidad);
            grupoFamiliar.IdGrupoFamiliar = idGrupoFamiliar;
            grupoFamiliar.IdEmpleado = idEmpleado;

            return grupoFamiliar;

        }
    }
}
