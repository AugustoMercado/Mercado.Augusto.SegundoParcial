using PrimerParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PrimerParcial
{
    public class Arquero : Personaje, IBaseDatos
    {
        #region Atributos

        public int id;
        public int puntosPrecision;
        public int puntosVelocidad;
        #endregion

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Nivel { get { return this.nivel; } set { this.nivel = value; } }
        public int PuntosPrecision { get { return this.puntosPrecision; } set { this.puntosPrecision = value; } }
        public int PuntosVelocidad { get { return this.puntosVelocidad; } set { this.puntosVelocidad = value; } }
        public EPersonajes TipoPersonaje { get { return this.tipoPersonaje; } set { this.tipoPersonaje = value; } }


        #region Constructores
        public Arquero()
        {


        }
        /// <summary>
        /// Constructor para crear un arquero.
        /// </summary>
        /// <param name="precision">Numero de precision del personaje.</param>
        /// <param name="velocidad">Numero de velocidad del personaje.</param>
        /// <param name="nivel">Numero de nivel del personaje.</param>
        /// <param name="nombre">Nombre del personaje.</param>
        public Arquero(int precision, int velocidad, int nivel, string nombre) : base(nombre, nivel, EPersonajes.arquero)
        {
            this.puntosPrecision = precision;
            this.puntosVelocidad = velocidad;

        }
        #endregion


        #region Metodos

        public override string Atacar()
        {
            return ($"{this.nombre} dispara una flecha con precisión.");
        }

        public override bool Equals(object? obj)
        {
            bool rst = false;
            if (obj is Arquero)
            {
                Arquero otraPersona = (Arquero)obj;
                return this.tipoPersonaje == otraPersona.tipoPersonaje && this.nombre == otraPersona.nombre;

            }
            return rst;

        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"\n Puntos de precision: {this.puntosPrecision}\n Puntos de velocidad: {this.puntosVelocidad}");
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
                sqlComando.CommandText = "select id, nombre, nivel, tipoPersonaje,puntosPrecision,puntosVelocidad FROM Arqueroo";
                sqlComando.Connection = conexion;
                conexion.Open();
                lector = sqlComando.ExecuteReader();
                while (lector.Read())
                {
                    Arquero personaje = new Arquero();
                    personaje.ID = (int)lector["id"];
                    personaje.nombre = lector[1].ToString();
                    personaje.nivel = (int)lector["nivel"];
                    personaje.tipoPersonaje = EPersonajes.arquero;
                    personaje.puntosPrecision = (int)lector["puntosPrecision"];
                    personaje.puntosVelocidad = (int)lector["puntosVelocidad"];
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
                sqlComando.CommandText = $"DELETE FROM Arquero  WHERE id = @id";
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
