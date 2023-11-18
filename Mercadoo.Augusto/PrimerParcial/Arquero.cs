using PrimerParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Arquero : Personaje
    {
        #region Atributos

        public int puntosPrecision;
        public int puntosVelocidad;
        #endregion

        #region Propiedades
        public int ID { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Nivel { get { return this.nivel; } set { this.nivel = value; } }
        public int PuntosPrecision { get { return this.puntosPrecision; } set { this.puntosPrecision = value; } }
        public int PuntosVelocidad { get { return this.puntosVelocidad; } set { this.puntosVelocidad = value; } }
        public EPersonajes TipoPersonaje { get { return this.tipoPersonaje; } set { this.tipoPersonaje = value; } }
        #endregion

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
        public Arquero(int precision, int velocidad, int id, int nivel, string nombre) : base(nombre, nivel, id, EPersonajes.arquero)
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

        #endregion

    }
}
