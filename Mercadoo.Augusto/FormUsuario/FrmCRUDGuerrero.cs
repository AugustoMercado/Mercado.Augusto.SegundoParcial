using FormUsuario.Interfaces;
using PrimerParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUsuario
{
    public partial class FrmCRUDGuerrero : FrmCRUDPrincipal,IConfiguracion
    {
        #region Atributos
        public Guerrero guerrero;
        #endregion

        #region Constructores
        public FrmCRUDGuerrero()
        {
            InitializeComponent();
            this.ConfigurarForm();
        }

        public FrmCRUDGuerrero(Guerrero prod) : this()
        {
            base.txtNombre.Text = prod.nombre;
            base.txtNivel.Text = $"{prod.nivel}";
            this.txtPuntosAtaque.Text = $"{prod.puntosAtaque}";
            this.txtPuntosDefensa.Text = ($"{prod.puntosDefensa}");

        }
        #endregion

        #region Metodos forms

        public void ConfigurarForm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario Guerreo";
            this.txtNombre.Focus();


        }
        private void btnAceptarGuerrero_Click(object sender, EventArgs e)
        {

            string nombre = base.txtNombre.Text;
            int resultNivel = ValidarEntero(base.txtNivel.Text);
            int resultPuntosAtaque = ValidarEntero(txtPuntosAtaque.Text);
            int resultPuntosDefensa = ValidarEntero(base.txtNivel.Text);

            if (resultNivel != -1 && resultPuntosAtaque != -1 && resultPuntosDefensa != -1)
            {
                this.guerrero = new Guerrero(resultPuntosAtaque, resultPuntosDefensa, resultNivel, nombre);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void BtnCancelarGuerrero_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
