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

        public FrmCRUDPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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



    }
}
