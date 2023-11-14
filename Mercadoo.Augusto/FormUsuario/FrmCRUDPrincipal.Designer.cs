namespace FormUsuario
{
    partial class FrmCRUDPrincipal
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
            lblNombre = new Label();
            lblNivel = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtNivel = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNivel.Location = new Point(12, 126);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(61, 28);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "Nivel:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 259);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(186, 131);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(182, 23);
            txtNivel.TabIndex = 9;
            // 
            // FrmCRUDPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 460);
            Controls.Add(txtNivel);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(lblNivel);
            Controls.Add(lblNombre);
            Name = "FrmCRUDPrincipal";
            Text = "CRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblNivel;
        private Label label7;
        public TextBox txtNombre;
        public TextBox txtNivel;
    }
}