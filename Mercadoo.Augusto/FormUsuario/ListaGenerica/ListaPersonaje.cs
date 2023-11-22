using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial;
using Microsoft.Data.SqlClient;

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
        public bool EliminarPersonaje(T personaje,int id)
        {
            SqlConnection conexion = new(this.cadenaConexion);
            bool retorno = false;

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
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar el arquero: " + e.Message);
                retorno = false;
            }

            return retorno;
        }
        #endregion
    }
}
