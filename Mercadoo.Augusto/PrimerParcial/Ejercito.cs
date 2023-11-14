using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace PrimerParcial
{
    public class Ejercito
    {
        #region Atributos

        private int cantMaxMiembros;
        private string destinoDeAtaque;
        public List<Personaje> miembros;
        public string mensaje;
    

     
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public Ejercito() 
        {

            
        
        }

        /// <summary>
        /// Constructor del ejercito.
        /// </summary>
        /// <param name="canMaxMiembros">mimebros maximos a ser agregados</param>
        /// <param name="destino">destino de ataque del ejercito</param>
        public Ejercito(int canMaxMiembros, string destino): this()
        {
            this.cantMaxMiembros = canMaxMiembros;
            this.destinoDeAtaque = destino;
            this.miembros = new();
            this.mensaje = "";
        }

  
        #endregion

        /// <summary>
        /// Propiedad de lectura de miembros.
        /// </summary>
        public List<Personaje> Miembros
        { 
            get { return this.miembros; }
  
        }

        #region Sobrecarga de operadores


        /// <summary>
        /// Busca que el personaje este en la lista
        /// </summary>
        /// <param name="p1">Personaje a buscar</param>
        /// <param name="ejercito">Lista donde se va a buscar</param>
        /// <returns>retorna un bool, true si no esta, false si se encuentra</returns>
        public static bool operator ==(Personaje p1, Ejercito ejercito)
        {
            return ejercito.Miembros.Contains(p1);

        }

        /// <summary>
        /// compara que el personaje no este en la lista.
        /// </summary>
        /// <param name="p1">personaje a buscar</param>
        /// <param name="ejercito">lista donde se va a buscar</param>
        /// <returns>retorna un bool, true si esta, false si no esta</returns>
        public static bool operator !=(Personaje p1, Ejercito ejercito)
        {

            return !(p1 == ejercito);
             
        }

        /// <summary>
        /// El operador + nos permite agregar un personaje a la lista.
        /// </summary>
        /// <param name="ejercito">lista con todos los personajes</param>
        /// <param name="p1">personaje que si no esta en la lista, sera agregado</param>
        /// <returns>retorna una nueva lista</returns>
        public static Ejercito operator +(Ejercito ejercito, Personaje p1)
        {


            if (ejercito.Miembros.Count() < ejercito.cantMaxMiembros)
            {
                if (p1 != ejercito)
                {

                    ejercito.Miembros.Add(p1);
                    ejercito.mensaje = $"Se agrego al ejercito el personaje |Nombre: {p1.nombre} | Nivel: {p1.nivel} | Tipo de Personaje: {p1.tipoPersonaje}|";
       

                }
                else
                {

                    ejercito.mensaje = "El personaje ya se agrego al ejercito.";


                }

            }
            else
            {
                ejercito.mensaje = ("El Ejercito esta completo.");
            
            }

            return ejercito;

        }

        /// <summary>
        /// El operador - nos permite remover de la lista un personaje.
        /// </summary>
        /// <param name="ejercito">lista con todos los personajes</param>
        /// <param name="p1">personaje a ser buscado y eliminado de la lista</param>
        /// <returns>retorna una nueva lista</returns>
        public static Ejercito operator -(Ejercito ejercito, Personaje p1)
        {

            if (p1 == ejercito)
            {

                ejercito.Miembros.Remove(p1);
                ejercito.mensaje = $"Se quito del ejercito  el personaje |Nombre: {p1.nombre} | Nivel: {p1.nivel} | Tipo de Personaje: {p1.tipoPersonaje}|";
            }
            return ejercito;

        }
        #endregion

        #region Metodos de ordenamiento

        /// <summary>
        /// Ordena el ejercito por nombre.
        /// </summary>
        /// <param name="uno">1er personaje que se usa como metodo de comparacion</param>
        /// <param name="dos">2do personaje el cual se comparara con el 1ero</param>
        /// <returns>retorna un int dependiendo el caso,-1 si el 1ro es mas grande que el segundo, 1 si el 2do es mas grande y 0 si ambos son iguales</returns>
        public static int OrdenarEjercitoPorNombre(Personaje uno, Personaje dos)
        {
            
            int result = uno.nombre.CompareTo(dos.nombre);
            if (result == -1)
            {
                return -1;
            }
            else if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }



        }
        /// <summary>
        /// Ordena el ejercito por nivel.
        /// </summary>
        /// <param name="uno">1er personaje que se usa como metodo de comparacion</param>
        /// <param name="dos">2do personaje el cual se comparara con el 1ero</param>
        /// <returns>retorna un int dependiendo el caso,-1 si el 1ro es mas grande que el segundo, 1 si el 2do es mas grande y 0 si ambos son iguales</returns>
        public static int OrdenarPorNivel(Personaje uno, Personaje dos)
        {
            int result = uno.nivel.CompareTo(dos.nivel);
            if (result == -1)
            {
                return -1;
            }
            else if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
        #endregion


        #region Metodos


        /// <summary>
        /// Compara si el objecto pasado por parametros es de tipo ejercito.
        /// </summary>
        /// <param name="obj">objeto a ser comparado</param>
        /// <returns>retorna un bool, true si ese objeto es Ejercito y false si no lo es</returns>
        public override bool Equals(object? obj)
        {
            bool rst = false;
            if (obj is Ejercito)
            {
                rst = this == (Ejercito)obj;
            }
            return rst;

        }

        /// <summary>
        /// sobrecarga del metodo GetHadCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();

        }

        /// <summary>
        /// Nos muestra todo los datos del ejercito.
        /// </summary>
        /// <returns></returns>
        public string MostrarEjercito() 
        {
            StringBuilder sb = new StringBuilder();

            foreach (Personaje miembro in this.Miembros)
            {
                sb.AppendLine(miembro.ToString()+"\n");

            }
            return sb.ToString();

        }
        
        #endregion
    }
}
