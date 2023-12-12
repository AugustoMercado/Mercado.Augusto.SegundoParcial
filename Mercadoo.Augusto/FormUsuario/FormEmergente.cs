using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormUsuario.Interfaces;

namespace FormUsuario
{
    public partial class FormEmergente : Form,IConfiguracion
    {
        private System.Windows.Forms.Timer timer;
        private string mensaje;
        public FormEmergente()
        {
            InitializeComponent();
            this.timer = new();
            this.timer.Interval = 4000;
            this.timer.Tick += Timer_Tick;
            this.ConfigurarForm();

        }

        public FormEmergente(string mensajee) : this()
        {
            this.mensaje = mensajee;
            this.CambiarLabelMensaje();
        }

        public void ConfigurarForm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = " ";
            this.BackColor = System.Drawing.Color.GhostWhite;


        }
        /// <summary>
        /// Metodo para cambiar el mensaje.
        /// </summary>
        private void CambiarLabelMensaje()
        {
            
            this.Textlbl.Text = this.mensaje;
            this.timer.Start();
        }

        /// <summary>
        /// Detiene el temporizador cuando alcanza el intervalo especificado y cierra la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Detiene el temporizador 
            this.timer.Stop();

            // Cierra la ventana emergente
            this.Close();
        }

    }
}
