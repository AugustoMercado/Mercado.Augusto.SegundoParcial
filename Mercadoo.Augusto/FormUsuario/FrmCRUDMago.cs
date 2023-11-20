using FormUsuario.Interfaces;
using PrimerParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUsuario
{
    public partial class FrmCRUDMago : FrmCRUDPrincipal, IConfiguracion
    {
        #region  Atributos
        public Mago personaje;
        private static Emagia magia;
        #endregion

        #region  Constructores
        public FrmCRUDMago()
        {
            InitializeComponent();
            this.ConfigurarForm();
        }

        public FrmCRUDMago(Mago prod) : this()
        {

            base.txtNombre.Text = prod.nombre;
            base.txtNivel.Text = prod.nivel.ToString();
            this.txtPuntosMagia.Text = prod.puntosMagia.ToString();
            this.cmbTipoMagia.Text = prod.tipoMagia.ToString();


        }
        #endregion

        #region metodos form

        public void ConfigurarForm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario Mago";
            this.txtNombre.Focus();


        }
        private void btnAceptarMago_Click(object sender, EventArgs e)
        {
            string nombre = base.txtNombre.Text;
            int resultNivel = ValidarEntero(base.txtNivel.Text);
            int resultPuntosMagia = ValidarEntero(txtPuntosMagia.Text);
            int tipoMagia = -1;
            tipoMagia = this.cmbTipoMagia.SelectedIndex;
            switch (tipoMagia)
            {
                case 0:
                    magia = Emagia.Hielo;
                    break;
                case 1:
                    magia = Emagia.Fuego;
                    break;
                case 2:
                    magia = Emagia.Tierra;
                    break;
                case 3:
                    magia = Emagia.Curación;
                    break;
            }
            if (resultNivel != -1 && resultPuntosMagia != -1)
            {
                this.personaje = new(magia, resultPuntosMagia, resultNivel, nombre);
                this.DialogResult = DialogResult.OK;

            }
        }

        private void btnCancelarMago_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
