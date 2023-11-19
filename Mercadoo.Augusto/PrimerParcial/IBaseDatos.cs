using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimerParcial
{
    public interface IBaseDatos
    {
        /// <summary>
        /// Metodo para obtener los datos de la base de datos.
        /// </summary>
        /// <param name="cadena">La conexion a la base de datos</param>
        /// <param name="lista">Lista donde se van agregar los datos</param>
        /// <returns>retorna el ejercito</returns>
        public Ejercito ObtenerDatos(string cadena, Ejercito lista);

        /// <summary>
        /// Metodo para eliminar un personaje de la base de datos.
        /// </summary>
        /// <param name="cadena">La conexion a la base de datos</param>
        /// <param name="id">Id del personaje a borrar</param>
        /// <returns>Retorna True si lo borro, en caso contrario False</returns>
        public bool EliminarPersonaje(string cadena, int id);
    }
}
