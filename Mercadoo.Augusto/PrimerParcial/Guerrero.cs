using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Threading.Tasks;

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

        #endregion


    }
}
