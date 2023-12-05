using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUsuario.Excepciones
{
    public class MiExcepcion:Exception
    {
        public MiExcepcion()
        {
            
        }
        public MiExcepcion(string mensaje): base (mensaje)
        {
            
        }

        public MiExcepcion(string message, Exception exception) : base(message, exception) 
        {
        
        }

    }
}
