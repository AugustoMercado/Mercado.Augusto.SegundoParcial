using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial;

namespace FormUsuario.ListaGenerica
{
    public class ListaPersonaje<T> where T : Personaje
    {
        private string cadenaConexion;

        public ListaPersonaje(string stringConexion)
        {
            this.cadenaConexion = stringConexion;
        }

    }
}
