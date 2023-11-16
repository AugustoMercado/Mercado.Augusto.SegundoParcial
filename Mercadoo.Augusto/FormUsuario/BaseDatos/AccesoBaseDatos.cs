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

    }
}
