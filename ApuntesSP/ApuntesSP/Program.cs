using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
namespace ApuntesSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //_________SQL__________//
            /*
            SqlConnection conexion = new SqlConnection(Configurar las propiedades);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "select * from nombre_de_la_tabla";
            comando.CommandText = "Update nombre_tabla Set nombre_campo1 = valor_campo1, nombre_campo2 = valor_campo2,... Where condiciones_de_selección";
            comando.CommandText = "INSERT INTO "nombre_tabla" ("columna1", "columna2", ...)VALUES("valor1", "valor2", ...); "
            comando.CommandText = "delete from nombre_tabla where condiciones_de_seleccion";
            */

// string cmd = String.Format("INSERT INTO Satelites (nombre, duracion_orbita,duracion_rotacion) VALUES ('{0}','{1}', '{2}')", satelite.Nombre, satelite.DuraOrbita, satelite.DuraRotacion);


//__DataTable__//
/*
private DataTable tablaPersonas;
this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);

this.tablaPersonas.Columns.Add("id", typeof(int));
this.tablaPersonas.Columns["id"].AutoIncrement = true;
this.tablaPersonas.Columns["id"].AutoIncrementSeed = 0;
this.tablaPersonas.Columns["id"].AutoIncrementStep = 1;
this.tablaPersonas.Columns.Add("nombre", typeof(string));
this.tablaPersonas.Columns.Add("apellido", typeof(string));
this.tablaPersonas.Columns.Add("edad", typeof(int));

// Configurando adaptador

this.adaptador.Fill(this.tablaPersonas);

this.adaptador.InsertCommand = new SqlCommand("insert into personas values(@p1, @p2, @p3)", this.conexion);
this.adaptador.UpdateCommand = new SqlCommand("update personas set nombre = @p1, apellido = @p2, edad = @p3 where id = @p4", this.conexion);
this.adaptador.DeleteCommand = new SqlCommand("delete from personas where id = @p1", this.conexion);

// Configurando parametros de cada comando
this.adaptador.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
this.adaptador.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
this.adaptador.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");

this.adaptador.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
this.adaptador.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
this.adaptador.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");
this.adaptador.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 10, "id");

this.adaptador.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 10, "id");            
*/

//__________HILOS________//
/*
Thread hilo = new Thread(Metodo que llevara a cabo el hilo);
hilo.Start();
hilo.Abort();
*/

//____EVENTOS____//
/*
public delegate TipoRetorno NombreDelegado(TipoDatoParametro NombreParametro);

public event NombreDelegado nombreEvento;

nombreEvento += ManejadorSinParametros;
*/

//___METODOS DE EXTENSION__//
/*
 * Se hacen en clases estaticas
 * 
 * public static TipoRetorno NombreMetodo(this Clase_a_la_que_le_vamos_a_agregar_el_metodo nombreparametro);


}

}
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
