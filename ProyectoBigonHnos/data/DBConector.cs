using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoBigonHnos.data
{
    class DBConector
    {
        public static DBConector conector;

        private string server = "DESKTOP-HGBHH3S\\SQLEXPRESS";
        private string database = "BigonsHnosDB";
        private string security = "True";
        private SqlConnection con;

        public DBConector()
        {
            string conexion = string.Format("server={0}; database={1} ; integrated security={2};",server,database,security);
            con = new SqlConnection(conexion);
        }

        public static DBConector getInstance()
        {
            if (conector == null)
                conector = new DBConector();
            return conector;
        }

        public void ejectuarQuery(String query)
        {
            con.Open();

            SqlCommand comando = new SqlCommand(query, con);
            comando.ExecuteNonQuery();

            Console.WriteLine("se ejecuto consulta en la base de datos");

            con.Close();
        }

        public List<List<Object>> consultarQuery(String query)
        {
            List<List<Object>> listaRegistros = new List<List<object>>();

            con.Open();
            SqlCommand comando = new SqlCommand(query, con);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                int columnas = registros.FieldCount;

                List<Object> fila = new List<object>();
                for ( int i = 0; i < columnas; i++)
                {
                    fila.Add(registros[i]);
                }

                listaRegistros.Add(fila);
            }

            con.Close();
            return listaRegistros;

        }

        public void borrarRegistro(String query)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(query, con);
            int retorno = comando.ExecuteNonQuery();

            if (retorno == 1)
                Console.WriteLine("registro borrado");
            else
                Console.WriteLine("No se borro el registro");

            con.Close();
        }

    }
}
