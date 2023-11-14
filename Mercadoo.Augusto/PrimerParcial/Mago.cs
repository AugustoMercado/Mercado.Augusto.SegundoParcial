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
        #endregion

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
        public Mago(Emagia magia,int puntosMagia, int nivel, string nombre) :base(nombre, nivel, EPersonajes.mago)
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
