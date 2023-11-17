using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using PrimerParcial;
using static System.Windows.Forms.Design.AxImporter;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.Logging;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using FormUsuario.BaseDatos;

namespace FormUsuario
{
    public partial class FrmPrincipal : Form
    {

        #region Atributos
        private Ejercito personajes;
        private string path;
        private CrearLog escribirlog;
        private AccesoBaseDatos baseDatos;
        #endregion

        #region Constructores
        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public FrmPrincipal(LogearUsuario usuario) : this()
        {

            MessageBox.Show($"Bienvenido de nuevo {usuario.apellido} {usuario.nombre}");
            this.escribirlog = new($"Inicio sesion {usuario.apellido} {usuario.nombre}", usuario);
            this.Text = $"{usuario.apellido} {usuario.nombre} - {DateTime.Today}";
            this.lblEjercito.Text = $"Ejercito de {usuario.apellido}";
            this.personajes = new(6, "Brasil");
            this.path = $"EjercitoDe{usuario.apellido}.xml";
            this.MostrarCRUD(usuario);
            this.ActualizarVisualizador();


        }
        #endregion

        #region Metodos Forms Del CRUD
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            FrmElegirPersonaje frmE = new();
            frmE.ShowDialog();

            if (frmE.DialogResult == DialogResult.OK)
            {
                if (frmE.personaje == 0)
                {
                    FrmCRUDMago crudMago = new();
                    crudMago.ShowDialog();

                    if (crudMago.DialogResult == DialogResult.OK)
                    {

                        personajes = this.personajes += crudMago.personaje;
                        this.baseDatos.AgregarPersonajeBaseDato("insert into Mago (nombre,nivel,tipoPersonaje,tipoMagia,puntosMagia)" +
                        " values ('" + crudMago.personaje.nombre + "'," + crudMago.personaje.nivel + ",'" + crudMago.personaje.tipoPersonaje.ToString() + "','" + crudMago.personaje.tipoMagia.ToString() + "'," + crudMago.personaje.puntosMagia + ")");
                        this.escribirlog.mensaje = personajes.mensaje;

                    }
                }
                else if (frmE.personaje == 1)
                {
                    FrmCRUDGuerrero crudGuerrero = new();
                    crudGuerrero.ShowDialog();


                    if (crudGuerrero.DialogResult == DialogResult.OK)
                    {
                        personajes = this.personajes += crudGuerrero.guerrero;

                        this.baseDatos.AgregarPersonajeBaseDato("insert into Guerrero (nombre,nivel,tipoPersonaje,ataque,defensa)" +
                        " values ('" + crudGuerrero.guerrero.nombre + "'," + crudGuerrero.guerrero.nivel + ",'" + crudGuerrero.guerrero.tipoPersonaje.ToString() + "'," + crudGuerrero.guerrero.puntosAtaque + "," + crudGuerrero.guerrero.puntosAtaque + ")");
                        this.escribirlog.mensaje = personajes.mensaje;
                    }
                }
                else if (frmE.personaje == 2)
                {

                    FrmCRUDArquero crudArquero = new();
                    crudArquero.ShowDialog();


                    if (crudArquero.DialogResult == DialogResult.OK)
                    {
                        personajes = this.personajes += crudArquero.arquero;
                        this.baseDatos.AgregarPersonajeBaseDato("insert into Arqueroo (nombre,nivel,tipoPersonaje,puntosPrecision,puntosVelocidad)" +
                        " values ('" + crudArquero.arquero.nombre + "'," + crudArquero.arquero.nivel + ",'" + crudArquero.arquero.tipoPersonaje.ToString() + "'," + crudArquero.arquero.puntosPrecision + "," + crudArquero.arquero.puntosVelocidad + ")");
                        this.escribirlog.mensaje = personajes.mensaje;
                    }

                }
                this.MostrarBoton();
            }

            this.ActualizarVisualizador();
            this.ActualizarEjercito();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            int index = this.lstEjercito.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            var personaje = this.personajes.miembros[index];

            if (personaje.tipoPersonaje == EPersonajes.mago)
            {

                Mago personajeM = (Mago)personaje;
                FrmCRUDMago crudMago = new(personajeM);
                crudMago.ShowDialog();


                if (crudMago.DialogResult == DialogResult.OK)
                {

                    this.personajes.miembros[index] = crudMago.personaje;
                    mensaje = $"Se modifico{personajeM} a {crudMago.personaje}.";

                }
            }
            else if (personaje.tipoPersonaje == EPersonajes.guerrero)
            {
                Guerrero personajeG = (Guerrero)personaje;
                FrmCRUDGuerrero crudGuerrero = new(personajeG);
                crudGuerrero.ShowDialog();


                if (crudGuerrero.DialogResult == DialogResult.OK)
                {

                    this.personajes.miembros[index] = crudGuerrero.guerrero;
                    this.baseDatos.ModificarPersonaje(crudGuerrero.guerrero);
                    mensaje = $"Se modifico{personajeG} a {crudGuerrero.guerrero}.";

                }


            }
            else if (personaje.tipoPersonaje == EPersonajes.arquero)
            {

                Arquero personajeA = (Arquero)personaje;
                FrmCRUDArquero crudArquero = new(personajeA);
                crudArquero.ShowDialog();


                if (crudArquero.DialogResult == DialogResult.OK)
                {

                    this.personajes.miembros[index] = crudArquero.arquero;
                    mensaje = $"Se modifico{personajeA} a {crudArquero.arquero}.";


                }

            }
            this.escribirlog.mensaje = mensaje;
            this.ActualizarVisualizador();
            this.ActualizarEjercito();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int index = this.lstEjercito.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            var personaje = this.personajes.miembros[index];

            if (personaje.tipoPersonaje == EPersonajes.mago)
            {
                Mago personajeM = (Mago)personaje;
                FrmCRUDMago crudMago = new(personajeM);
                crudMago.ShowDialog();

                if (crudMago.DialogResult == DialogResult.OK)
                {

                    personajes = this.personajes -= personajeM;
                    this.escribirlog.mensaje = this.personajes.mensaje;

                }

            }
            else if (personaje.tipoPersonaje == EPersonajes.guerrero)
            {

                Guerrero personajeG = (Guerrero)personaje;
                FrmCRUDGuerrero crudGuerrero = new(personajeG);
                crudGuerrero.ShowDialog();


                if (crudGuerrero.DialogResult == DialogResult.OK)
                {
                    personajes = this.personajes -= personajeG;
                    this.escribirlog.mensaje = this.personajes.mensaje;
                }

            }
            else if (personaje.tipoPersonaje == EPersonajes.arquero)
            {

                Arquero personajeA = (Arquero)personaje;
                FrmCRUDArquero crudArquero = new(personajeA);
                crudArquero.ShowDialog();


                if (crudArquero.DialogResult == DialogResult.OK)
                {

                    personajes = this.personajes -= personajeA;
                    this.escribirlog.mensaje = this.personajes.mensaje;
                }

            }

            this.ActualizarVisualizador();
            this.ActualizarEjercito();

        }
        #endregion

        /// <summary>
        /// Nos permite cerrar el programa, pero antes, no muestra un mensaje para confirmar o no el cerrar sesion.
        /// </summary>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Al apretar el boton 'Cerrar Sesion' finaliza el programa.

            DialogResult result = MessageBox.Show("Esta seguro que quiere cerrar sesion?", string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.escribirlog.mensaje = $"Cerro sesion.";
                this.ActualizarVisualizador();
                Application.Exit();
            }


        }

        #region Metodos
        /// <summary>
        /// Nos muestra los miembros en el ListBox.
        /// </summary>
        private void ActualizarEjercito()
        {
            this.lstEjercito.Items.Clear();

            foreach (Personaje miembro in personajes.miembros)
            {
                this.lstEjercito.Items.Add(miembro.ToString() + "\n");

            }

        }
        /// <summary>
        /// Nos muestra los datos del archivo .Log en un ListBox.
        /// </summary>
        private void ActualizarVisualizador()
        {
            this.escribirlog.escribirLineaFichero();
            this.lstLog.Items.Clear();
            string cadenaLog = this.escribirlog.LeerFichero();
            //separa cadenaLog cuando llega a un salto de linea.
            string[] cadena = cadenaLog.Split("\n");
            foreach (string str in cadena)
            {

                this.lstLog.Items.Add(str + "\n");

            }

        }


        /// <summary>
        /// Con un ComboBox seleccionamos de que forma queremos ordenarlos (Ascendente o descendente)
        /// <paramref name="metodo"/>Es el numero del metodo por el cual vamos a ordenar.
        /// </summary>
        private void OrdenarLista(int metodo)
        {
            string mensaje = "";
            if (metodo == 0)
            {
                mensaje = "Ordenar de forma descendente";
                this.personajes.miembros.Reverse();
                

            }
            else 
            {
                mensaje = "Ordenar de forma ascendente";

            }
            this.escribirlog.mensaje = mensaje;
            this.ActualizarVisualizador();

        }
        /// <summary>
        /// Con un RadioButton seleccionamos por cual metodo deseamos ordenar a los miembros (por nivel o nombre
        /// </summary>
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            
            int metodoOrdenar = this.cbOrdenar.SelectedIndex;
            if (OrdenPorNivel.Checked)
            {
                mensaje = "Ordenar miembros por nivel";
                this.personajes.miembros.Sort(Ejercito.OrdenarPorNivel);
                OrdenarLista(metodoOrdenar);
            }
            else if (OrdenPorNombre.Checked)
            {
                mensaje = "Ordenar miembros por nombre";
                this.personajes.miembros.Sort(Ejercito.OrdenarEjercitoPorNombre);
                OrdenarLista(metodoOrdenar);

            }
            else
            {

                MessageBox.Show("Debe elegir de que manera quiere mostrar los miembros.");

            }
            this.escribirlog.mensaje = mensaje;
            this.ActualizarVisualizador();
            this.ActualizarEjercito();
            metodoOrdenar = -1;
        }

        /// <summary>
        /// Oculta el boton si no hay ningun personaje, si hay personajes lo muestra.
        /// </summary>
        private void MostrarBoton()
        {
            if (this.personajes.Miembros.Count > 0)
            {
                this.btnAtacar.Show();

            }
            else
            {
                this.btnAtacar.Hide();

            }

        }

        private void MostrarCRUD(LogearUsuario usuario) 
        {
            switch (usuario.perfil) 
            {
                case "vendedor":
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cbOrdenar.Enabled = false;
                    btnOrdenar.Enabled = false;
                    break; 
                case "supervisor":
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;
                    break;
               default:
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;
            }
        
        }

        /// <summary>
        ///Al tocar el boton se va a mostrar en el log el ataque que realiza dicho personaje. 
        /// </summary>
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            int index = this.lstEjercito.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Primero debe elegir algun personaje de la lista");
                return;
            }

            var personaje = this.personajes.miembros[index];

            foreach (Personaje miembro in personajes.miembros)
            {
                if (personaje.tipoPersonaje == miembro.tipoPersonaje)
                {

                    sb.AppendLine($" {miembro.Atacar()}\n");

                }

            }
            this.escribirlog.mensaje = sb.ToString();
            this.ActualizarVisualizador();
            this.ActualizarEjercito();
        }
        #endregion

        #region Metodos de archivos.

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            try
            {
                using (XmlTextReader reader = new XmlTextReader($@"..\..\..\{this.path}"))
                {

                    XmlSerializer ser = new XmlSerializer(typeof(List<Personaje>), new Type[] { typeof(Guerrero), typeof(Mago), typeof(Arquero) });

                    List<Personaje> personajes = (List<Personaje>?)ser.Deserialize(reader);

                    foreach (Personaje per in personajes)
                    {

                        this.personajes += per;
                    }
                    this.MostrarBoton();
                    this.escribirlog.mensaje = "Datos obtenidos del archivo xlm";
                    this.ActualizarVisualizador();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al Deserializar los Datos");
            }


            this.ActualizarEjercito();

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.personajes.miembros.Count > 0)
            {

                try
                {
                    using (XmlTextWriter writer = new XmlTextWriter($@"..\..\..\{this.path}", Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Personaje>), new Type[] { typeof(Guerrero), typeof(Mago), typeof(Arquero) });
                        ser.Serialize(writer, this.personajes.Miembros);
                        this.escribirlog.mensaje = "Datos guardados en el archivo xlm";
                        this.ActualizarVisualizador();
                    }
                }
                catch (Exception exepcion)
                {

                    Console.WriteLine("Error al Deserializar los Datos");
                }

            }

        }



        #endregion

    }
}
