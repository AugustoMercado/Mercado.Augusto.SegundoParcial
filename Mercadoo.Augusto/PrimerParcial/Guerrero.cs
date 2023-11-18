using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PrimerParcial
{

    public  class Guerrero : Personaje
    {
        #region  Atributos

        public int puntosAtaque;
        public int puntosDefensa;
        public int id;


        #endregion
        #region Propiedades
        public int ID { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Nivel { get { return this.nivel; } set { this.nivel = value; } }
        public int Ataque { get { return this.puntosAtaque; } set { this.puntosAtaque = value; } }
        public int Defensa { get { return this.puntosDefensa; } set { this.puntosAtaque = value; } }
        public EPersonajes TipoPersonaje { get { return this.tipoPersonaje; } set { this.tipoPersonaje = value; } }
        #endregion

        #region Constructores


        public Guerrero() 
        {


        }

        /// <summary>
        /// Constructor para crear un guerrero
        /// </summary>
        /// <param name="ataque">numero de ataque del personaje</param>
        /// <param name="defensa">numero de defensa del personaje</param>
        /// <param name="nivel">nivel del personaje</param>
        /// <param name="nombre">nombre del personaje</param>
        public Guerrero(int ataque, int defensa, int nivel, string nombre) : base(nombre, nivel, EPersonajes.guerrero)
        {
            this.puntosAtaque = ataque;
            this.puntosDefensa = defensa;
            this.nombre = nombre;
            this.nivel = nivel;

        }
        #endregion



        #region Metodos

        public override string Atacar()
        {
           return ($"{this.nombre} realiza un poderoso ataque con su espada.");
        }
        public override bool Equals(object? obj)
        {
            bool rst = false;
            if (obj is Guerrero)
            {
                Guerrero otraPersona = (Guerrero)obj;
                return this.tipoPersonaje == otraPersona.tipoPersonaje && this.nombre == otraPersona.nombre;

            }
            return rst;

        }
        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"\n Puntos de ataque: {this.puntosAtaque}\n Puntos de defensa: {this.puntosDefensa}");
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
                sqlComando.CommandText = "select id, nombre, nivel, tipoPersonaje,ataque,defensa FROM Personaje";
                sqlComando.Connection = conexion;
                conexion.Open();
                lector = sqlComando.ExecuteReader();
                while (lector.Read())
                {
                    Guerrero personaje = new Guerrero();
                    personaje.ID = (int)lector["id"];
                    personaje.Nombre = lector[1].ToString();
                    personaje.Nivel = (int)lector["nivel"];
                    personaje.TipoPersonaje = EPersonajes.guerrero;
                    personaje.Ataque = (int)lector["ataque"];
                    personaje.Defensa = (int)lector["defensa"];


                    lista += personaje;

                }
                lector.Close();


            }
            catch (Exception e)
            {


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
                sqlComando.CommandText = $"DELETE FROM Personaje WHERE id = @id";
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
