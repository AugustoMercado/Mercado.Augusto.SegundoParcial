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
        public int id;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public Personaje()
        {

        }

        public Personaje(int id) : this()
        {

            this.id = id;


        }

        /// <summary>
        /// Constructor para pasar nombre y id
        /// </summary>
        /// <param name="nombre">nombre del personaje</param>
        /// <param name="id">id del personaje.</param>
        public Personaje(string nombre, int id) : this(id)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor para pasar nombre, id y nivel
        /// </summary>
        /// <param name="nombre">nombre del personaje</param>
        /// <param name="id">id del personaje.</param>
        /// <param name="nivel">nivel del personaje.</param>
        public Personaje(string nombre, int id, int nivel) : this(nombre, id)
        {

            this.nivel = nivel;


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre">nombre del personaje</param>
        /// <param name="nivel">nivel del personaje.</param>
        /// <param name="id">id del personaje.</param>
        /// <param name="personaje">El tipo de personaje</param>
        public Personaje(string nombre, int nivel, int id, EPersonajes personaje) : this(nombre, nivel, id)
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