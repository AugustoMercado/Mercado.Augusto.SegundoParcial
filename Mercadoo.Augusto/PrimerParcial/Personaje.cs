using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrimerParcial
{
    public abstract class Personaje
    {

        #region  Atributos


        public string nombre;
        public int nivel;
        public EPersonajes tipoPersonaje;
        private int id;
        #endregion

        

        public EPersonajes TipoPersonaje { get { return this.tipoPersonaje; } set { this.tipoPersonaje = value; } }
        #region Constructores

        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public Personaje()
        {

        }

        public Personaje(string nombre) : this()
        {

            this.nombre = nombre;


        }
        /// <summary>
        /// Constructor para pasar el nombre
        /// </summary>
        /// <param name="nombre">Nombre del personaje</param>
        public Personaje(string nombre, int nivel) : this(nombre)
        {
            this.nivel = nivel;
        }


        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="nombre">Nombre del personaje</param>
        /// <param name="nivel">Nivel del personaje</param>
        /// <param name="personaje">Tipo del personaje</param>
        public Personaje(string nombre, int nivel, EPersonajes personaje) : this(nombre, nivel)
        {

            this.tipoPersonaje = personaje;

        }
        #endregion


        #region Sobrecarga de operadores

        /// <summary>
        /// sobrecarga del operador  == para saber si dos personajes son iguales.
        /// </summary>
        /// <param name="p1">1er personaje a comparar</param>
        /// <param name="p2">2do personaje a comprar con el 1ro</param>
        /// <returns>retorna un bool, true en caso de que sean iguales, caso contrario false</returns>
        public static bool operator ==(Personaje p1, Personaje p2)
        {

            return (p1.Equals(p2));

        }

        /// <summary>
        /// sobrecarga del operador  != para saber si dos personajes son diferntes.
        /// </summary>
        /// <param name="p1">1er personaje a comparar</param>
        /// <param name="p2">2do personaje a comprar con el 1ro</param>
        /// <returns>retorna un bool, false en caso de que sean iguales, caso contrario true</returns>
        public static bool operator !=(Personaje p1, Personaje p2)
        {

            return !(p1.Equals(p2));


        }

        #endregion


        #region Metodos

        /// <summary>
        /// Nos indica como esta atacando el ejercito.
        /// </summary>
        public abstract string Atacar();

        /// <summary>
        /// Sobrecarga del metodo Equals.
        /// </summary>
        public override bool Equals(object? obj)
        {
            bool rst = false;
            if (obj is Personaje)
            {
                Personaje otraPersona = (Personaje)obj;
                return this.tipoPersonaje == otraPersona.tipoPersonaje && this.nombre == otraPersona.nombre;

               
            }
            return rst;

        }
        /// <summary>
        /// Sobrecarga del metodo GetHasCode.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
            
        }

        /// <summary>
        /// Sobrecarga del metodo ToString.
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"\nNombre: {this.nombre} \nNivel: {this.nivel} \nTipo de personaje: {this.tipoPersonaje}");
         
            return sb.ToString();
        }
        #endregion

    }
} 