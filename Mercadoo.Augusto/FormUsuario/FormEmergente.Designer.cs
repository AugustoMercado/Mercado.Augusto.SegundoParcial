namespace FormUsuario
{
    partial class FormEmergente
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
            Textlbl = new Label();
            SuspendLayout();
            // 
            // Textlbl
            // 
            Textlbl.AutoSize = true;
            Textlbl.Location = new Point(12, 29);
            Textlbl.Name = "Textlbl";
            Textlbl.Size = new Size(51, 15);
            Textlbl.TabIndex = 0;
            Textlbl.Text = "mensaje";
            // 
            // FormEmergente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 84);
            Controls.Add(Textlbl);
            Name = "FormEmergente";
            Text = "FormEmergente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Textlbl;
    }
}