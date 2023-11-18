using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using PrimerParcial;
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

        /// <summary>
        /// Nos permite modificar un personaje (guerrero) de la base buscando su ID
        /// </summary>
        /// <param name="p">guerrero a modificar/buscar en la base</param>
        /// <returns>retorna true si logro modificarlo, en caso contrario false</returns>
        public bool ModificarPersonaje(Guerrero p)
        {
            bool retorno = false;
            try
            {
                this.sqlComando = new SqlCommand();
                this.sqlComando.CommandType = System.Data.CommandType.Text;
                this.sqlComando.CommandText = "update Personaje SET nombre = @nombre, nivel = @nivel, tipoPersonaje = @tipoPersonaje, ataque = @ataque, defensa = @defensa WHERE id = @id";
                this.sqlComando.Parameters.AddWithValue("@nombre", p.nombre);
                this.sqlComando.Parameters.AddWithValue("@nivel", p.nivel);
                this.sqlComando.Parameters.AddWithValue("@tipoPersonaje", p.TipoPersonaje.ToString());
                this.sqlComando.Parameters.AddWithValue("@ataque", p.Ataque);
                this.sqlComando.Parameters.AddWithValue("@defensa", p.Defensa);
                this.sqlComando.Parameters.AddWithValue("@id", p.ID);

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

        /// <summary>
        /// Nos permite modificar un personaje (mago) de la base buscando su ID
        /// </summary>
        /// <param name="m">mago a modificar/buscar en la base</param>
        /// <returns>retorna true si logro modificarlo, en caso contrario false</returns>
        public bool ModificarPersonaje(Mago m)
        {
            bool retorno = false;
            try
            {
                this.sqlComando = new SqlCommand();
                this.sqlComando.CommandType = System.Data.CommandType.Text;
                this.sqlComando.CommandText = "update Mago SET nombre = @nombre, nivel = @nivel, tipoPersonaje = @tipoPersonaje, tipoMagia = @tipoMagia, puntosMagia = @puntosMagia WHERE id = @id";
                this.sqlComando.Parameters.AddWithValue("@nombre", m.nombre);
                this.sqlComando.Parameters.AddWithValue("@nivel", m.nivel);
                this.sqlComando.Parameters.AddWithValue("@tipoPersonaje", m.tipoPersonaje.ToString());
                this.sqlComando.Parameters.AddWithValue("@tipoMagia", m.tipoMagia.ToString());
                this.sqlComando.Parameters.AddWithValue("@puntosMagia", m.puntosMagia);
                this.sqlComando.Parameters.AddWithValue("@id", m.ID);

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

        /// <summary>
        /// Nos permite modificar un personaje (arquero) de la base buscando su ID
        /// </summary>
        /// <param name="a">arquero a modificar/buscar en la base</param>
        /// <returns>retorna true si logro modificarlo, en caso contrario false</returns>
        public bool ModificarPersonaje(Arquero a)
        {
            bool retorno = false;
            try
            {
                this.sqlComando = new SqlCommand();
                this.sqlComando.CommandType = System.Data.CommandType.Text;
                this.sqlComando.CommandText = "update Mago SET nombre = @nombre, nivel = @nivel, tipoPersonaje = @tipoPersonaje, puntosPrecision = @puntosPrecision, puntosVelocidad = @puntosVelocidad WHERE id = @id";
                this.sqlComando.Parameters.AddWithValue("@nombre", a.nombre);
                this.sqlComando.Parameters.AddWithValue("@nivel", a.nivel);
                this.sqlComando.Parameters.AddWithValue("@tipoPersonaje", a.tipoPersonaje.ToString());
                this.sqlComando.Parameters.AddWithValue("@puntosPrecision", a.PuntosPrecision);
                this.sqlComando.Parameters.AddWithValue("@puntosVelocidad", a.PuntosVelocidad);
                this.sqlComando.Parameters.AddWithValue("@id", a.ID);

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

        /// <summary>
        /// Nos elimina un personaje de la base de datos.
        /// </summary>
        /// <param name="tabla">nombre de la tabla para buscar el personaje.</param>
        /// <param name="id">id del personaje a borrar</param>
        /// <returns>si lo borro retorna true, en caso contrario retorna false</returns>
        public bool EliminarPersonaje(string tabla, int id)
        {
            bool retorno = false;

            try
            {
                this.sqlComando = new SqlCommand();
                this.sqlComando.CommandType = System.Data.CommandType.Text;
                this.sqlComando.CommandText = $"DELETE FROM {tabla} WHERE id = @id";
                this.sqlComando.Parameters.AddWithValue("@id", id);

                this.sqlComando.Connection = this.conexion;
                this.conexion.Open();

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




    }
}
