using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PrimerParcial
{
    public class Mago : Personaje, IBaseDatos
    {
        #region Atributos

        public Emagia tipoMagia;
        public int puntosMagia;
        private int id;
        #endregion

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Nivel { get { return this.nivel; } set { this.nivel = value; } }
        public Emagia Magia { get { return this.tipoMagia; } set { this.tipoMagia = value; } }
        public int PuntosMagia { get { return this.puntosMagia; } set { this.puntosMagia = value; } }
        public EPersonajes TipoPersonaje { get { return this.tipoPersonaje; } set { this.tipoPersonaje = value; } }


        #region Constructor
        public Mago()
        {


        }

        /// <summary>
        /// Constructor para crear un mago
        /// </summary>
        /// <param name="magia">Tipo de magia del mago</param>
        /// <param name="puntosMagia">Numero de magia del mago</param>
        /// <param name="nivel">Nivel del personaje</param>
        /// <param name="nombre">Nombre del personaje</param>
        public Mago(Emagia magia, int puntosMagia, int nivel, string nombre) : base(nombre, nivel, EPersonajes.mago)
        {
            this.tipoMagia = magia;
            this.puntosMagia = puntosMagia;

        }
        #endregion



        #region Metodos


        public override string Atacar()
        {
          return ($"{this.nombre} lanza un hechizo de {this.tipoMagia}.");
        }


        public override bool Equals(object? obj)
        {
            bool rst = false;
            if (obj is Mago)
            {
                Mago otraPersona = (Mago)obj;
                return this.tipoPersonaje == otraPersona.tipoPersonaje && this.tipoMagia == otraPersona.tipoMagia;

            }
            return rst;

        }
        public override string ToString()
        {
            StringBuilder sb = new();
            
            sb.AppendLine(base.ToString());
            sb.AppendLine($"\n Tipo de magia: {this.tipoMagia}\n Puntos de Magia: {this.puntosMagia}");
            return sb.ToString();

        }

        public Ejercito ObtenerDatos(string cadena, Ejercito lista)
        {
            SqlConnection conexion = new(cadena);
            SqlDataReader lector;
            try
            {
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.CommandType = System.Data.CommandType.Text;
                //en vez de codearlo, pasarlo como parametro.
                sqlComando.CommandText = "select id, nombre, nivel, tipoPersonaje,tipoMagia,puntosMagia FROM Mago";
                sqlComando.Connection = conexion;
                conexion.Open();
                lector = sqlComando.ExecuteReader();
                while (lector.Read())
                {
                    Mago personaje = new Mago();
                    personaje.ID = (int)lector["id"];
                    personaje.nombre = lector[1].ToString();
                    personaje.nivel = (int)lector["nivel"];
                    personaje.tipoPersonaje = EPersonajes.mago;
                    switch (lector["tipoMagia"].ToString())
                    {
                        case "Hielo":
                            personaje.tipoMagia = Emagia.Hielo;
                            break;
                        case "Curacion":
                            personaje.tipoMagia = Emagia.Curación;
                            break;
                        case "Tierra":
                            personaje.tipoMagia = Emagia.Tierra;
                            break;
                        case "Fuego":
                            personaje.tipoMagia = Emagia.Fuego;
                            break;
                    }
                    personaje.puntosMagia = (int)lector["puntosMagia"];



                    lista += personaje;

                }
                lector.Close();


            }
            catch (Exception e)
            {

                lista.mensaje = $"Error al traer los datos. Error: {e}";

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {

                    conexion.Close();

                }

            }
            return lista;


        }
        public bool EliminarPersonaje(string cadena, int id)
        {
            SqlConnection conexion = new(cadena);
            bool retorno = false;

            try
            {
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.CommandType = System.Data.CommandType.Text;
                sqlComando.CommandText = $"DELETE FROM Mago WHERE id = @id";
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
