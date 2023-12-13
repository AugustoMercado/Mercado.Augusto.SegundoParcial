using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial;
using Microsoft.Data.SqlClient;
using FormUsuario.Excepciones;

namespace FormUsuario.ListaGenerica
{
    public class ListaPersonaje<T> where T : Personaje
    {
        #region Atributo
        private string cadenaConexion;
        #endregion

        #region Constructor
        public ListaPersonaje(string stringConexion)
        {
            this.cadenaConexion = stringConexion;
        }

        #endregion


        #region Metodo

        /// <summary>
        ///  Nos elimina un personaje de la base de datos.
        /// </summary>
        /// <param name="personaje">Personaje para acceder a su tabla</param>
        /// <param name="id">id del personaje a borrar</param>
        /// <returns>si lo borro retorna true, en caso contrario retorna false</returns>
        public bool EliminarPersonaje(T personaje,int id)
        {
            SqlConnection conexion = new(this.cadenaConexion);
            bool retorno = false;

            try
            {
                try
                {

                    SqlCommand sqlComando = new SqlCommand();
                    sqlComando.CommandType = System.Data.CommandType.Text;

                    sqlComando.CommandText = $"DELETE FROM {typeof(T).Name} WHERE id = @id";
                    sqlComando.Parameters.AddWithValue("@id", id);

                    sqlComando.Connection = conexion;
                    conexion.Open();

                    int filasAfectadas = sqlComando.ExecuteNonQuery();

                    if (filasAfectadas == 1)
                    {
                        retorno = true;
                    }
                }
                catch (Exception ex)
                {
                
                    throw new MiExcepcion("Error al eliminar....",ex); 
                
                }
            }
            catch (MiExcepcion e)
            {
                MessageBox.Show($"{e.Message} {personaje.nombre} de la Base De Datos.");
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Metodo para buscar el ultimo id de la base de datos.
        /// </summary>
        /// <param name="personaje">Tipo de personaje</param>
        /// <param name="id">id que se va a cambiar o asignar</param>
        /// <returns>retorna el id + 1 en caso de que la base tenga datos, caso contario retorna 0 + 1</returns>
        public int ObtenerUltimoID(T personaje, int id)
        {

            SqlConnection conexion = new(this.cadenaConexion);
            SqlDataReader lector;

            try
            {
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.CommandType = System.Data.CommandType.Text;
                sqlComando.CommandText = $"select TOP 1 id FROM {typeof(T).Name} Order by id DESC";
                sqlComando.Connection = conexion;
                conexion.Open();
                lector = sqlComando.ExecuteReader();
                if (lector.Read())
                {
                    id = (int)lector["id"];
                }
                else
                {

                    id = 0;

                }
                lector.Close();


            }
            catch (Exception e)
            {

                throw new MiExcepcion("Error al obtener ultimo id de la base....", e);

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {

                    conexion.Close();

                }

            }
            return id + 1;



        }
        #endregion
    }
}
