namespace FormUsuario
{
    partial class FrmElegirPersonaje
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
            cmbTipoPersonaje = new ComboBox();
            lblTipoPersonaje = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbTipoPersonaje
            // 
            cmbTipoPersonaje.FormattingEnabled = true;
            cmbTipoPersonaje.Items.AddRange(new object[] { "Mago", "Guerrero", "Arquero" });
            cmbTipoPersonaje.Location = new Point(189, 28);
            cmbTipoPersonaje.Name = "cmbTipoPersonaje";
            cmbTipoPersonaje.Size = new Size(182, 23);
            cmbTipoPersonaje.TabIndex = 17;
            // 
            // lblTipoPersonaje
            // 
            lblTipoPersonaje.AutoSize = true;
            lblTipoPersonaje.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoPersonaje.Location = new Point(12, 23);
            lblTipoPersonaje.Name = "lblTipoPersonaje";
            lblTipoPersonaje.Size = new Size(143, 28);
            lblTipoPersonaje.TabIndex = 18;
            lblTipoPersonaje.Text = "Tipo Personaje:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(30, 108);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(125, 30);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(189, 108);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 30);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmElegirPersonaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 150);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTipoPersonaje);
            Controls.Add(cmbTipoPersonaje);
            Name = "FrmElegirPersonaje";
            Text = "FrmElegirPersonaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoPersonaje;
        private Label lblTipoPersonaje;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}