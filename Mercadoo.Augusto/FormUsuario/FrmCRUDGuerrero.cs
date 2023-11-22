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
        private int id;
        private Mensaje mensaje;
        #endregion

        #region Constructores
        public FrmCRUDGuerrero()
        {
            InitializeComponent();
            this.ConfigurarForm();
            this.mensaje = MostrarMensaje;
        
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
            this.ActualizarLabel(EPersonajes.guerrero);

        }
        private void btnAceptarGuerrero_Click(object sender, EventArgs e)
        {

            string nombre = base.txtNombre.Text;
            int resultNivel = ValidarEntero(base.txtNivel.Text);
            int resultPuntosAtaque = ValidarEntero(txtPuntosAtaque.Text);
            int resultPuntosDefensa = ValidarEntero(base.txtNivel.Text);

            if (txtNombre.Text != string.Empty && txtNivel != null && resultNivel != -1 && resultPuntosAtaque != -1 && resultPuntosDefensa != -1)
            {
                if (this.id > 0 && resultNivel != -1 && resultPuntosAtaque != -1 && resultPuntosDefensa != -1)
                {

                    this.guerrero = new Guerrero(resultPuntosAtaque, resultPuntosDefensa, resultNivel, nombre);
                    this.guerrero.ID = this.id;
                    this.DialogResult = DialogResult.OK;

                }

                else if (resultNivel != -1 && resultPuntosAtaque != -1 && resultPuntosDefensa != -1)
                {

                    this.guerrero = new Guerrero(resultPuntosAtaque, resultPuntosDefensa, resultNivel, nombre);

                    this.DialogResult = DialogResult.OK;
                }
            }
            else 
            {
                this.mensaje.Invoke("Debe llenar los campos");
            }

        }

        public void MostrarMensaje(string mensaje)
        {

            MessageBox.Show(mensaje);


        }


        private void BtnCancelarGuerrero_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.cancellationSource.Cancel();
        }
        #endregion
    }
}
