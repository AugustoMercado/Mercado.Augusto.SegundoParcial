using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUsuario
{
    public class CrearLog
    {
        #region Atributos
        private LogearUsuario usuarioActual;
        public string mensaje;
        #endregion

        /// <summary>
        /// Constructor para pasar el mensaje por parámetro en la creación de la clase y el usuario.
        /// </summary>
        /// <param name="mensajeEnviar">mensaje a escribir en el archivo</param>
        /// <param name="usuario">actual usuario que esta usando el programa</param>

        public CrearLog(string mensajeEnviar, LogearUsuario usuario)
        {
            this.usuarioActual = usuario;
            this.mensaje = mensajeEnviar;
            
        }


        /// <summary>
        /// Escribe el mensaje de la propiedad Mensaje en un fichero que tiene el nombre del usuario actual.
        /// </summary>
        public void escribirLineaFichero()
        {
            try
            {
                using (FileStream fs = new FileStream($@"..\..\..\{this.usuarioActual.nombre}.log", FileMode.OpenOrCreate, FileAccess.Write))
                {

                    StreamWriter streamWriter = new StreamWriter(fs);
                    //Escribe al final del archivo.
                    streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                    //Quitar posibles saltos de línea del mensaje
                    this.mensaje = this.mensaje.Replace(Environment.NewLine, " | ");
                    this.mensaje = this.mensaje.Replace("\r\n", " | ").Replace("\n", " | ").Replace("\r", " | ");
                    streamWriter.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + this.mensaje);
                    //Agrega todo el contenido del buffer en el archivo.
                    streamWriter.Flush();

                }
         
            }
            catch
            {
                Console.Write("Error al usar el archivo.");
            }
        }

        /// <summary>
        /// Lee el mensaje del fichero que tiene el nombre del usuario actual.
        /// </summary>
        /// <returns>Retorna una string con todos los datos.</returns>
        public string LeerFichero() 
        {
            StringBuilder sb = new();
            string contenido = "";
            try
            {
                // Abre el archivo en modo lectura
                using (StreamReader reader = new StreamReader($@"..\..\..\{this.usuarioActual.nombre}.log"))
                {
                    // Lee todo el contenido del archivo y lo concatenamos con el metodo Appendline.
                    while ((contenido = reader.ReadLine()) != null) 
                    {
                    
                        sb.AppendLine(contenido);
                    
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
            return sb.ToString();
        }


    }
}
