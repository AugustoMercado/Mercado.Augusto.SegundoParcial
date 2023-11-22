using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcial;

namespace FormUsuario
{
    public partial class FrmCRUDPrincipal : Form
    {

        public string nombre;
        public int nivel;
        public CancellationTokenSource cancellationSource;
        public CancellationToken cancellationToken;

        public FrmCRUDPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cancellationSource = new CancellationTokenSource();
            this.cancellationToken = this.cancellationSource.Token;

        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            this.nombre = this.txtNombre.Text;
            this.nivel = int.Parse(this.txtNivel.Text);
            this.DialogResult = DialogResult.OK;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Valida si el string contiene un int.
        /// <param string="numero"> numero en formato string para confirmar que sea int.>
        ///  Va a devolver -1 y mostrar un messageBox si no es un numero, y si es un numero, va a devolver dicho numero. 
        /// </summary>
        /// 
        public int ValidarEntero(string numero)
        {
            int rst = -1;

            if (int.TryParse(numero, out int result))
            {
                rst = result;
            }
            else
            {

                MessageBox.Show($"Error al ingresar '{numero}'. Ingrese un numero.");

            }
            return rst;
        }

        /// <summary>
        /// Metodo para ejecutar el un hilo el metodo cambiarColor
        /// </summary>
        /// <param name="nuevoColor">color a cambiar la interface</param>
        public void EjecutarCambiarColor(Color nuevoColor)
        {
      
            Thread hiloColor = new Thread(() => CambiarColorEnHilo(nuevoColor));
            hiloColor.Start();
        }

        /// <summary>
        /// Cambia el color de la interfaz
        /// </summary>
        /// <param name="nuevoColor">color de la interfaz</param>
        private void CambiarColorEnHilo(Color nuevoColor)
        {
            // Espera para cambiar el color
            Thread.Sleep(1000);

     
            this.Invoke(new Action(() =>{this.BackColor = nuevoColor;}));
        }

        /// <summary>
        /// Metodo para actualizar los label Nombre y Nivel.
        /// </summary>
        /// <param name="personaje">Personaje al cual se esta agregando.</param>
        public void ActualizarLabel(EPersonajes personaje)
        {
            if (this.lblNombre.InvokeRequired)
            {

                DelegadoPersonaje prs = new(ActualizarLabel);
                //object[] parametros = { personaje };

                this.lblNombre.Invoke(prs, personaje);
            }
            else
            {
                if (this.cancellationToken.IsCancellationRequested)
                {
                    Thread.Sleep(1000);
                    this.lblNombre.Text = "Nombre ";
                    this.lblNivel.Text = "Nivel ";
                }
                else
                {
                    Thread.Sleep(1000);
                    this.lblNombre.Text = "Nombre del " + personaje.ToString();
                    this.lblNivel.Text = "Nivel del " + personaje.ToString();
                }


            }

        }


    }
}
