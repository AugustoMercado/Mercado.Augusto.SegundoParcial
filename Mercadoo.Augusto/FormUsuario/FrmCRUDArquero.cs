using FormUsuario.Interfaces;
using PrimerParcial;
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
    public partial class FrmCRUDArquero : FrmCRUDPrincipal, IConfiguracion
    {
        #region Atributos
        public Arquero arquero;
        #endregion

        #region Constructores
        public FrmCRUDArquero()
        {
            InitializeComponent();
            this.ConfigurarForm();

        }

        public FrmCRUDArquero(Arquero arquero) : this()
        {
            base.txtNombre.Text = arquero.nombre;
            base.txtNivel.Text = arquero.nivel.ToString();
            this.txtVelocidad.Text = arquero.puntosVelocidad.ToString();
            this.txtPrecision.Text = arquero.puntosPrecision.ToString();

        }
        #endregion


        #region Metodos Forms

        public void ConfigurarForm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario Arquero";
            this.txtNombre.Focus();


        }
        private void btnAceptarArquero_Click(object sender, EventArgs e)
        {
            string nombre = base.txtNombre.Text;
            int resultNivel = ValidarEntero(base.txtNivel.Text);
            int resultPuntosVelocidad = ValidarEntero(this.txtVelocidad.Text);
            int resultPrecision = ValidarEntero(this.txtPrecision.Text);

            if (resultNivel != -1 && resultPuntosVelocidad != -1 && resultPrecision != -1)
            {

                this.arquero = new(resultPuntosVelocidad, resultPrecision, resultNivel, nombre);
                this.DialogResult = DialogResult.OK;

            }
        }

        private void BtnCancelarArquero_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        #endregion
    }
}
