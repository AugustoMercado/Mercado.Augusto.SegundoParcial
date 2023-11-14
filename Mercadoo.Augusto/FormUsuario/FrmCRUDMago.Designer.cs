namespace FormUsuario
{
    partial class FrmCRUDMago
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
            txtPuntosMagia = new TextBox();
            lblTipoMagia = new Label();
            lblPuntosMagia = new Label();
            cmbTipoMagia = new ComboBox();
            btnAceptarMago = new Button();
            btnCancelarMago = new Button();
            SuspendLayout();
            // 
            // txtPuntosMagia
            // 
            txtPuntosMagia.Location = new Point(186, 242);
            txtPuntosMagia.Name = "txtPuntosMagia";
            txtPuntosMagia.Size = new Size(182, 23);
            txtPuntosMagia.TabIndex = 16;
            // 
            // lblTipoMagia
            // 
            lblTipoMagia.AutoSize = true;
            lblTipoMagia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoMagia.Location = new Point(12, 180);
            lblTipoMagia.Name = "lblTipoMagia";
            lblTipoMagia.Size = new Size(144, 28);
            lblTipoMagia.TabIndex = 18;
            lblTipoMagia.Text = "Tipo De Magia:";
            // 
            // lblPuntosMagia
            // 
            lblPuntosMagia.AutoSize = true;
            lblPuntosMagia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntosMagia.Location = new Point(12, 234);
            lblPuntosMagia.Name = "lblPuntosMagia";
            lblPuntosMagia.Size = new Size(162, 28);
            lblPuntosMagia.TabIndex = 19;
            lblPuntosMagia.Text = "Puntos de magia:";
            // 
            // cmbTipoMagia
            // 
            cmbTipoMagia.FormattingEnabled = true;
            cmbTipoMagia.Items.AddRange(new object[] { "    Hielo", "    Fuego", "    Tierra", "    Curación" });
            cmbTipoMagia.Location = new Point(186, 185);
            cmbTipoMagia.Name = "cmbTipoMagia";
            cmbTipoMagia.Size = new Size(182, 23);
            cmbTipoMagia.TabIndex = 20;
            // 
            // btnAceptarMago
            // 
            btnAceptarMago.Location = new Point(12, 377);
            btnAceptarMago.Name = "btnAceptarMago";
            btnAceptarMago.Size = new Size(149, 42);
            btnAceptarMago.TabIndex = 22;
            btnAceptarMago.Text = "Aceptar";
            btnAceptarMago.UseVisualStyleBackColor = true;
            btnAceptarMago.Click += btnAceptarMago_Click;
            // 
            // btnCancelarMago
            // 
            btnCancelarMago.Location = new Point(273, 377);
            btnCancelarMago.Name = "btnCancelarMago";
            btnCancelarMago.Size = new Size(149, 42);
            btnCancelarMago.TabIndex = 23;
            btnCancelarMago.Text = "Cancelar";
            btnCancelarMago.UseVisualStyleBackColor = true;
            btnCancelarMago.Click += btnCancelarMago_Click;
            // 
            // FrmCRUDMago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 433);
            Controls.Add(btnCancelarMago);
            Controls.Add(btnAceptarMago);
            Controls.Add(cmbTipoMagia);
            Controls.Add(lblPuntosMagia);
            Controls.Add(lblTipoMagia);
            Controls.Add(txtPuntosMagia);
            Name = "FrmCRUDMago";
            Text = "CRUDMago";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtNivel, 0);
            Controls.SetChildIndex(txtPuntosMagia, 0);
            Controls.SetChildIndex(lblTipoMagia, 0);
            Controls.SetChildIndex(lblPuntosMagia, 0);
            Controls.SetChildIndex(cmbTipoMagia, 0);
            Controls.SetChildIndex(btnAceptarMago, 0);
            Controls.SetChildIndex(btnCancelarMago, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPuntosMagia;
        private Label lblTipoMagia;
        private Label lblPuntosMagia;
        private ComboBox cmbTipoMagia;
        private Button btnAceptarMago;
        private Button btnCancelarMago;
    }
}