using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace FormUsuario.BaseDatos
{
    public class AccesoBaseDatos
    {
        private SqlConnection conexion;
        static string cadenaConexion;
        private SqlCommand sqlComando;

        static AccesoBaseDatos()
        {
            AccesoBaseDatos.cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=parcialDB;Integrated Security=True;Trust Server Certificate=True";
        }

        public AccesoBaseDatos()
        {
            this.conexion = new SqlConnection(AccesoBaseDatos.cadenaConexion);

        }

        /// <summary>
        /// Metodo para probar que la conexion funcione.
        /// </summary>
        /// <returns>retorna true si se logro, false en caso contrario.</returns>
        public bool ProbarConexion()
        {
            try
            {
                this.conexion.Open();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {

                    this.conexion.Close();

                }
            }
        }

        /// <summary>
        /// Metodo que nos permitira agregegar un personaje a la base de datos.
        /// </summary>
        /// <param name="cadena">Le pasamos una cadena con la tabla y los atributos que va agregar.</param>
        /// <returns>retorna true si logro agregar, en caso contrario false.</returns>
        public bool AgregarPersonajeBaseDato(string cadena)

        {
            bool retorno = false;
            try
            {
                this.sqlComando = new SqlCommand();
                this.sqlComando.CommandType = System.Data.CommandType.Text;
                this.sqlComando.CommandText = cadena;


                this.sqlComando.Connection = this.conexion;
                this.conexion.Open();

                int filaAfectadas = this.sqlComando.ExecuteNonQuery();
                if (filaAfectadas == 1)
                {

                    retorno = true;
                }


            }
            catch (Exception e)
            {

                retorno = false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {

                    this.conexion.Close();

                }

            }

            return retorno;

        }

    }
}
