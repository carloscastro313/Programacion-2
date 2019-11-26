using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class SateliteDB
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader reader;
        public SateliteDB()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=planetario; Integrated Security = True"); ;
        }

        public bool Guardar(Satelite satelite)
        {
            bool retorno= false;
            string cmd = String.Format("INSERT INTO Satelites (nombre, duracion_orbita,duracion_rotacion) VALUES ('{0}','{1}', '{2}')", satelite.Nombre, satelite.DuraOrbita, satelite.DuraRotacion);
            try
            {
                conexion.Open();
                comando = new SqlCommand(cmd, conexion);

                if(comando.ExecuteNonQuery()==0)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al guardar en la base de dato...",e);
            }
            finally
            {
                if(conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public List<Satelite> Leer()
        {
            List<Satelite> satelites = new List<Satelite>();
            string cmd = "SELECT* from Satelites";
            try
            {
                conexion.Open();
                comando = new SqlCommand(cmd, conexion);
                reader = comando.ExecuteReader();
                while(reader.Read()!=false)
                {
                    satelites.Add(new Satelite((int)reader["duracion_orbita"], (int)reader["duracion_rotacion"],reader["nombre"].ToString()));
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al cargar con la base de dato...", e);
            }
            finally
            {
                if(!reader.IsClosed)
                {
                    reader.Close();
                }
                if(conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return satelites;
        }
    }
}
