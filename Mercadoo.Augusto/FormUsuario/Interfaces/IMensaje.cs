using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUsuario.Interfaces
{
    public interface IMensaje
    {
        public void MostrarMensaje(string mensajeTrue, string mensajeFalse, bool respuesta);
    }
}
