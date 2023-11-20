using FormUsuario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUsuario
{
    public partial class FrmElegirPersonaje : Form, IConfiguracion
    {
        public int personaje;

        public FrmElegirPersonaje()
        {
            InitializeComponent();
            this.ConfigurarForm();
            this.personaje = -1;
 
        }


        public void ConfigurarForm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario Elegir Personaje";
            this.cmbTipoPersonaje.Focus();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.personaje = this.cmbTipoPersonaje.SelectedIndex;
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
