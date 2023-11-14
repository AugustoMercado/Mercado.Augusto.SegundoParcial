namespace FormUsuario
{
    partial class FrmCRUDGuerrero
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
            label1 = new Label();
            label2 = new Label();
            txtPuntosAtaque = new TextBox();
            txtPuntosDefensa = new TextBox();
            btnAceptarGuerrero = new Button();
            BtnCancelarGuerrero = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 74);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Size = new Size(129, 23);
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(191, 128);
            txtNivel.Margin = new Padding(4, 5, 4, 5);
            txtNivel.Size = new Size(129, 23);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 172);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 16;
            label1.Text = "Puntos de ataque:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 215);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 17;
            label2.Text = "Puntos de defensa:";
            // 
            // txtPuntosAtaque
            // 
            txtPuntosAtaque.Location = new Point(193, 177);
            txtPuntosAtaque.Name = "txtPuntosAtaque";
            txtPuntosAtaque.Size = new Size(182, 23);
            txtPuntosAtaque.TabIndex = 18;
            // 
            // txtPuntosDefensa
            // 
            txtPuntosDefensa.Location = new Point(193, 220);
            txtPuntosDefensa.Name = "txtPuntosDefensa";
            txtPuntosDefensa.Size = new Size(182, 23);
            txtPuntosDefensa.TabIndex = 19;
            // 
            // btnAceptarGuerrero
            // 
            btnAceptarGuerrero.Location = new Point(8, 286);
            btnAceptarGuerrero.Name = "btnAceptarGuerrero";
            btnAceptarGuerrero.Size = new Size(149, 42);
            btnAceptarGuerrero.TabIndex = 21;
            btnAceptarGuerrero.Text = "Aceptar";
            btnAceptarGuerrero.UseVisualStyleBackColor = true;
            btnAceptarGuerrero.Click += btnAceptarGuerrero_Click;
            // 
            // BtnCancelarGuerrero
            // 
            BtnCancelarGuerrero.Location = new Point(224, 286);
            BtnCancelarGuerrero.Name = "BtnCancelarGuerrero";
            BtnCancelarGuerrero.Size = new Size(149, 42);
            BtnCancelarGuerrero.TabIndex = 22;
            BtnCancelarGuerrero.Text = "Cancelar";
            BtnCancelarGuerrero.UseVisualStyleBackColor = true;
            BtnCancelarGuerrero.Click += BtnCancelarGuerrero_Click_1;
            // 
            // FrmCRUDGuerrero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 393);
            Controls.Add(BtnCancelarGuerrero);
            Controls.Add(txtPuntosDefensa);
            Controls.Add(txtPuntosAtaque);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptarGuerrero);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCRUDGuerrero";
            Text = "CRUDGuerrero";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtNivel, 0);
            Controls.SetChildIndex(btnAceptarGuerrero, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtPuntosAtaque, 0);
            Controls.SetChildIndex(txtPuntosDefensa, 0);
            Controls.SetChildIndex(BtnCancelarGuerrero, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPuntosAtaque;
        private TextBox txtPuntosDefensa;
        private Button btnAceptarGuerrero;
        private Button BtnCancelarGuerrero;
    }
}