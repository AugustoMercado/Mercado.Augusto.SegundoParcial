namespace FormUsuario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstEjercito = new ListBox();
            lblEjercito = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCerrarSesion = new Button();
            GrpOrden = new GroupBox();
            cbOrdenar = new ComboBox();
            btnOrdenar = new Button();
            OrdenPorNombre = new RadioButton();
            OrdenPorNivel = new RadioButton();
            lstLog = new ListBox();
            label1 = new Label();
            btnAtacar = new Button();
            GrpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // lstEjercito
            // 
            lstEjercito.FormattingEnabled = true;
            lstEjercito.ItemHeight = 15;
            lstEjercito.Location = new Point(11, 26);
            lstEjercito.Margin = new Padding(2);
            lstEjercito.Name = "lstEjercito";
            lstEjercito.Size = new Size(590, 259);
            lstEjercito.TabIndex = 0;
            // 
            // lblEjercito
            // 
            lblEjercito.AutoSize = true;
            lblEjercito.Location = new Point(11, 9);
            lblEjercito.Margin = new Padding(2, 0, 2, 0);
            lblEjercito.Name = "lblEjercito";
            lblEjercito.Size = new Size(46, 15);
            lblEjercito.TabIndex = 1;
            lblEjercito.Text = "Ejercito";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(617, 26);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 46);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(617, 97);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 46);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(617, 172);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 46);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(919, 239);
            btnCerrarSesion.Margin = new Padding(2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(97, 46);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // GrpOrden
            // 
            GrpOrden.Controls.Add(cbOrdenar);
            GrpOrden.Controls.Add(btnOrdenar);
            GrpOrden.Controls.Add(OrdenPorNombre);
            GrpOrden.Controls.Add(OrdenPorNivel);
            GrpOrden.Location = new Point(769, 26);
            GrpOrden.Name = "GrpOrden";
            GrpOrden.Size = new Size(247, 175);
            GrpOrden.TabIndex = 6;
            GrpOrden.TabStop = false;
            GrpOrden.Text = "Ordenar";
            // 
            // cbOrdenar
            // 
            cbOrdenar.FormattingEnabled = true;
            cbOrdenar.Items.AddRange(new object[] { "Descendente", "Ascendente" });
            cbOrdenar.Location = new Point(57, 71);
            cbOrdenar.Name = "cbOrdenar";
            cbOrdenar.Size = new Size(121, 23);
            cbOrdenar.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(71, 113);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(107, 31);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // OrdenPorNombre
            // 
            OrdenPorNombre.AutoSize = true;
            OrdenPorNombre.Location = new Point(134, 35);
            OrdenPorNombre.Name = "OrdenPorNombre";
            OrdenPorNombre.Size = new Size(90, 19);
            OrdenPorNombre.TabIndex = 1;
            OrdenPorNombre.TabStop = true;
            OrdenPorNombre.Text = "Por Nombre";
            OrdenPorNombre.UseVisualStyleBackColor = true;
            // 
            // OrdenPorNivel
            // 
            OrdenPorNivel.AutoSize = true;
            OrdenPorNivel.Location = new Point(18, 35);
            OrdenPorNivel.Name = "OrdenPorNivel";
            OrdenPorNivel.Size = new Size(73, 19);
            OrdenPorNivel.TabIndex = 0;
            OrdenPorNivel.TabStop = true;
            OrdenPorNivel.Text = "Por Nivel";
            OrdenPorNivel.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.HorizontalScrollbar = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(11, 309);
            lstLog.Margin = new Padding(2);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(1005, 79);
            lstLog.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 292);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 8;
            label1.Text = "Visualizador Log";
            // 
            // btnAtacar
            // 
            btnAtacar.Location = new Point(617, 259);
            btnAtacar.Margin = new Padding(2);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(92, 26);
            btnAtacar.TabIndex = 9;
            btnAtacar.Text = "Atacar";
            btnAtacar.UseVisualStyleBackColor = true;
            btnAtacar.Click += btnAtacar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 390);
            Controls.Add(btnAtacar);
            Controls.Add(label1);
            Controls.Add(lstLog);
            Controls.Add(GrpOrden);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblEjercito);
            Controls.Add(lstEjercito);
            Margin = new Padding(2);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            GrpOrden.ResumeLayout(false);
            GrpOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEjercito;
        private Label lblEjercito;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCerrarSesion;
        private GroupBox GrpOrden;
        private Button btnOrdenar;
        private RadioButton OrdenPorNombre;
        private RadioButton OrdenPorNivel;
        private ComboBox cbOrdenar;
        private ListBox lstLog;
        private Label label1;
        private Button btnAtacar;
    }
}