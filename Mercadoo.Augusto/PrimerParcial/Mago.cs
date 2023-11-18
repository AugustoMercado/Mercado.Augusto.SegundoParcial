using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Mago : Personaje
    {
        #region Atributos

        public Emagia tipoMagia;
        public int puntosMagia;
        private int id;
        #endregion

        #region Constructor

        #region Propiedades

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Nivel { get { return this.nivel; } set { this.nivel = value; } }
        public Emagia Magia { get { return this.tipoMagia; } set { this.tipoMagia = value; } }
        public int PuntosMagia { get { return this.puntosMagia; } set { this.puntosMagia = value; } }
        public EPersonajes TipoPersonaje { get { return this.tipoPersonaje; } set { this.tipoPersonaje = value; } }


        #endregion
        public Mago() 
        {
          

        }

        /// <summary>
        /// Construtor para crear un mago.
        /// </summary>
        /// <param name="magia">tipo de magia.</param>
        /// <param name="puntosMagia">cantidad de magia.</param>
        /// <param name="nivel">nivel del personaje</param>
        /// <param name="id">id del personaje.</param>
        /// <param name="nombre">nombre del personaje.</param>
        public Mago(Emagia magia, int puntosMagia, int nivel, int id, string nombre) : base(nombre, nivel, id, EPersonajes.mago)
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

        #endregion
    }
}
