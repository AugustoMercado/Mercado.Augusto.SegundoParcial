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
    public partial class FrmElegirPersonaje : Form
    {
        public int personaje;

        public FrmElegirPersonaje()
        {
            InitializeComponent();
            this.personaje = -1;
            this.StartPosition = FormStartPosition.CenterScreen;
 
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
