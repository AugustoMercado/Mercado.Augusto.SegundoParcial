using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUsuario.Interfaces
{
    public interface IMensaje
    {
        /// <summary>
        /// Metodo para mostrar un mensaje.
        /// </summary>
        /// <param name="mensajeTrue">mensaje en caso de ser true</param>
        /// <param name="respuesta">bool que nos indique que mensaje mostrar</param>
        public void MostrarMensaje(string mensajeTrue, bool respuesta);
    }
}
