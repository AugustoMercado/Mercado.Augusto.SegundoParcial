using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using FormUsuario.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;

namespace FormUsuario
{
    public partial class Login : Form, IConfiguracion
    {

        private List<LogearUsuario> listaUsuarios;
        private int intentos;


        public Login()
        {
            InitializeComponent();
            this.listaUsuarios = new List<LogearUsuario>();
            this.intentos = 0;
            this.ConfigurarForm();

        }

        public void ConfigurarForm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario Login";
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("../../../usuarios.Json"))
            {

                using (StreamReader reader = new StreamReader("../../../usuarios.Json"))
                {
                    string cadena = reader.ReadToEnd();

                    //deserealizacion del archivo
                    List<LogearUsuario>? usuarios = (List<LogearUsuario>?)JsonSerializer.Deserialize(cadena, typeof(List<LogearUsuario>));
                    this.listaUsuarios = usuarios;

                }


            }

        }

        private void button1_Logear(object sender, EventArgs e)
        {

            if (this.intentos < 3)
            {
                this.EjecutarTask();
                ///this.EjecutarTask("Buscando usuario...");
                 Thread.Sleep(5000);
                foreach (LogearUsuario user in listaUsuarios)
                {

                    if (this.textBox1.Text == user.correo && this.textBox2.Text == user.clave)
                    {
                        //Si coiciden el correo y la clave con algun usuario, se ingresara al Forms.
                        this.Hide();
                        FrmPrincipal frmPrincipal = new(user);
                        frmPrincipal.ShowDialog();
                        break;
                    }

                }
                MessageBox.Show("Error de clave/correo.");
                ///MessageBox.Show("Error de clave/correo.");
            }
            else 
            {
                MessageBox.Show("Maximo de intentos alcanzados.");
                this.Close();

            }
              this.intentos++;
   
        }

        private void MostrarMensaje()
        {
            FormEmergente formEmergente = new("Buscando usuario....");
            formEmergente.ShowDialog();
        }


        private void EjecutarTask()

        {
            Task task = new Task(MostrarMensaje);
            task.Start();
           
          

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }


}