namespace FormUsuario
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            Correo = new Label();
            textBox2 = new TextBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 359);
            button1.Name = "button1";
            button1.Size = new Size(104, 48);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Logear;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 43);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 2;
            label1.Text = "Correo:";
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Correo.Location = new Point(40, 180);
            Correo.Name = "Correo";
            Correo.Size = new Size(114, 28);
            Correo.TabIndex = 3;
            Correo.Text = "Contraseña:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 211);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(145, 359);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(104, 48);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 429);
            Controls.Add(btnCerrar);
            Controls.Add(textBox2);
            Controls.Add(Correo);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label Correo;
        private TextBox textBox2;
        private Button btnCerrar;
    }
}