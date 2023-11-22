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
        private int id;
        private Mensaje mensaje;
        private bool camposLlenos;
        #endregion

        #region  Constructores
        public FrmCRUDMago()
        {
            InitializeComponent();
            this.ConfigurarForm();
            this.camposLlenos = false;
        }

        public FrmCRUDMago(Mago prod) : this()
        {
            this.camposLlenos = true;
            this.id = prod.ID;
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
            this.mensaje = MostrarMensaje;
            this.ActualizarLabel(EPersonajes.mago);
            this.EjecutarCambiarColor(Color.Aquamarine);

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

            if (txtNombre.Text != string.Empty && txtNivel != null && resultNivel != -1 && resultPuntosMagia != -1 && tipoMagia != -1 || this.camposLlenos == true)
            {
                if (this.id > 0 && resultNivel != -1 && resultPuntosMagia != -1)
                {
                    this.personaje = new(magia, resultPuntosMagia, resultNivel, nombre);
                    this.personaje.ID = this.id;
                    this.DialogResult = DialogResult.OK;

                }
                else if (resultNivel != -1 && resultPuntosMagia != -1)
                {
                    this.personaje = new(magia, resultPuntosMagia, resultNivel, nombre);
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

        private void btnCancelarMago_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.cancellationSource.Cancel();
        }
        #endregion
    }
}
