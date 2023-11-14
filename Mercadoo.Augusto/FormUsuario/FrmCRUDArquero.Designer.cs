namespace FormUsuario
{
    partial class FrmCRUDArquero
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
            txtPrecision = new TextBox();
            txtVelocidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAceptarArquero = new Button();
            BtnCancelarArquero = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 66);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Size = new Size(129, 23);
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(157, 128);
            txtNivel.Margin = new Padding(4, 5, 4, 5);
            txtNivel.Size = new Size(129, 23);
            // 
            // txtPrecision
            // 
            txtPrecision.Location = new Point(157, 251);
            txtPrecision.Name = "txtPrecision";
            txtPrecision.Size = new Size(182, 23);
            txtPrecision.TabIndex = 16;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(157, 190);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(182, 23);
            txtVelocidad.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 185);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 18;
            label1.Text = "Velocidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 246);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 19;
            label2.Text = "Precision:";
            // 
            // btnAceptarArquero
            // 
            btnAceptarArquero.Location = new Point(8, 322);
            btnAceptarArquero.Name = "btnAceptarArquero";
            btnAceptarArquero.Size = new Size(149, 42);
            btnAceptarArquero.TabIndex = 22;
            btnAceptarArquero.Text = "Aceptar";
            btnAceptarArquero.UseVisualStyleBackColor = true;
            btnAceptarArquero.Click += btnAceptarArquero_Click;
            // 
            // BtnCancelarArquero
            // 
            BtnCancelarArquero.Location = new Point(191, 322);
            BtnCancelarArquero.Name = "BtnCancelarArquero";
            BtnCancelarArquero.Size = new Size(149, 42);
            BtnCancelarArquero.TabIndex = 23;
            BtnCancelarArquero.Text = "Cancelar";
            BtnCancelarArquero.UseVisualStyleBackColor = true;
            BtnCancelarArquero.Click += BtnCancelarArquero_Click;
            // 
            // FrmCRUDArquero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 407);
            Controls.Add(BtnCancelarArquero);
            Controls.Add(btnAceptarArquero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtVelocidad);
            Controls.Add(txtPrecision);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCRUDArquero";
            Text = "CRUDArquero";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtNivel, 0);
            Controls.SetChildIndex(txtPrecision, 0);
            Controls.SetChildIndex(txtVelocidad, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btnAceptarArquero, 0);
            Controls.SetChildIndex(BtnCancelarArquero, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecision;
        private TextBox txtVelocidad;
        private Label label1;
        private Label label2;
        private Button btnAceptarArquero;
        private Button BtnCancelarArquero;
    }
}